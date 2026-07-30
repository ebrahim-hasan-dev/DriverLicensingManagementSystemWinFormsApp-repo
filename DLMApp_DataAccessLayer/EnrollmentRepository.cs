using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using DLMApp_ModulesLayer;


namespace DLMApp_DataAccessLayer
{
    public class EnrollmentRepository
    {
        public static async Task<bool> Enroll(int AppointmentID, byte TestID, int CreatedByUserID, int NewLocalLicenseID, float TestFees, string Notes, int RetakeTestOrderID = 0)
        {
            bool IsAdded = false;

            if (AppointmentID > 0 && TestID > 0 && CreatedByUserID > 0 && NewLocalLicenseID > 0 && TestFees > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string AddQuery = @"insert into [Enrollments] ([Test_Fees], [Added_DateTime], [Test_Result], [Notes],
                                        [New_Local_License_ID], [Test_ID], [Appointment_ID], [CreatedBy_UserID], [RetakeTestOrderID]) 
                                        values (@TestFees, default, @TestResult, @Notes, @NewLocalLicenseID, @Test_ID, @AppointmentID, @CreatedByUserID, 
                                        @RetakeTestOrderID);";

                    Command = new SqlCommand(AddQuery, Connection);

                    Command.Parameters.AddWithValue("@TestFees", TestFees);
                    Command.Parameters.AddWithValue("@TestResult", DBNull.Value);

                    if (string.IsNullOrWhiteSpace(Notes))
                        Command.Parameters.AddWithValue("@Notes", DBNull.Value);
                    else
                        Command.Parameters.AddWithValue("@Notes", Notes);

                    Command.Parameters.AddWithValue("@NewLocalLicenseID", NewLocalLicenseID);
                    Command.Parameters.AddWithValue("@Test_ID", TestID);
                    Command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                    Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    if (RetakeTestOrderID > 0)
                        Command.Parameters.AddWithValue("@RetakeTestOrderID", RetakeTestOrderID);
                    else
                        Command.Parameters.AddWithValue("@RetakeTestOrderID", DBNull.Value);


                    await Connection.OpenAsync();

                    if (await Command.ExecuteNonQueryAsync() > 0)
                    {
                        IsAdded = true;
                    }
                }
                catch (Exception ex)
                {
                    clsEventLog.WriteToEventLog(ex.Message, enLogType.Error);
                }
                finally
                {
                    if (Command != null)
                    {
                        Command.Dispose();
                    }

                    if (Connection != null)
                    {
                        Connection.Close();
                        Connection.Dispose();
                    }
                }
            }

            return IsAdded;
        }

        public static async Task<bool> Enroll(int AppointmentID, byte TestID, int CreatedByUserID, float TestFees, string Notes, int RenewLicenseApplicationID)
        {
            bool IsAdded = false;

            if (AppointmentID > 0 && TestID > 0 && CreatedByUserID > 0 && TestFees > 0 && RenewLicenseApplicationID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string AddQuery = @"insert into [Enrollments] ([Test_Fees], [Added_DateTime], [Test_Result], [Notes],
                                         [Test_ID], [Appointment_ID], [CreatedBy_UserID], [RetakeTestOrderID]) 
                                        values (@TestFees, default, @TestResult, @Notes, @Test_ID, @AppointmentID, @CreatedByUserID, 
                                        @RenewLicenseApplicationID);";

                    Command = new SqlCommand(AddQuery, Connection);

                    Command.Parameters.AddWithValue("@TestFees", TestFees);
                    Command.Parameters.AddWithValue("@TestResult", DBNull.Value);

                    if (string.IsNullOrWhiteSpace(Notes))
                        Command.Parameters.AddWithValue("@Notes", DBNull.Value);
                    else
                        Command.Parameters.AddWithValue("@Notes", Notes);

                    Command.Parameters.AddWithValue("@Test_ID", TestID);
                    Command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                    Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                    Command.Parameters.AddWithValue("@RenewLicenseApplicationID", RenewLicenseApplicationID);


                    await Connection.OpenAsync();

                    if (await Command.ExecuteNonQueryAsync() > 0)
                    {
                        IsAdded = true;
                    }
                }
                catch (Exception ex)
                {
                    clsEventLog.WriteToEventLog(ex.Message, enLogType.Error);
                    IsAdded = false;
                }
                finally
                {
                    if (Command != null)
                    {
                        Command.Dispose();
                    }

                    if (Connection != null)
                    {
                        Connection.Close();
                        Connection.Dispose();
                    }
                }
            }

            return IsAdded;
        }

        public static async Task<bool> IsSameApplicationIDExistInSameAppointment(int AppointmentID, int NewLocalLicenseApplicationID)
        {
            bool Exist = false;

            if (AppointmentID > 0 && NewLocalLicenseApplicationID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string FindlQuery = "select * from [Enrollments] where [Appointment_ID] = @AppointmentID and [New_Local_License_ID] = @NewLocalLicenseApplicationID;";

                    Command = new SqlCommand(FindlQuery, Connection);

                    Command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                    Command.Parameters.AddWithValue("@NewLocalLicenseApplicationID", NewLocalLicenseApplicationID);

                    await Connection.OpenAsync();

                    Reader = await Command.ExecuteReaderAsync();

                    if (Reader.HasRows)
                    {
                        Exist = true;
                    }
                }
                catch (Exception ex)
                {
                    clsEventLog.WriteToEventLog(ex.Message, enLogType.Error);
                }
                finally
                {
                    if (Reader != null)
                    {
                        Reader.Close();
                        Reader.Dispose();
                    }

                    if (Command != null)
                    {
                        Command.Dispose();
                    }

                    if (Connection != null)
                    {
                        Connection.Close();
                        Connection.Dispose();
                    }
                }
            }

            return Exist;
        }

        public static async Task<bool> SetResults(List<clsPeopleRegisteredInAppointmentDTO> ListOfRegisteredPeople, byte TestID)
        {
            bool Success = false;

            if (ListOfRegisteredPeople.Count > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    StringBuilder stringBuilder = new StringBuilder();

                    short i;
                    for (i = 0; i < ListOfRegisteredPeople.Count; i++)
                    {
                        if (ListOfRegisteredPeople[i]?.Result == true)
                        {
                            stringBuilder.Append($"update [Enrollments] set [Test_Result] = 1 where [New_Local_License_ID] = @{ListOfRegisteredPeople[i].LocalLicenseApplicationID} and [Test_ID] = @TestID;");
                        }
                        else
                        {
                            stringBuilder.Append($"update [Enrollments] set [Test_Result] = 0 where [New_Local_License_ID] = @{ListOfRegisteredPeople[i].LocalLicenseApplicationID} and [Test_ID] = @TestID;");
                        }
                    }

                    Command = new SqlCommand(stringBuilder.ToString(), Connection);

                    Command.Parameters.AddWithValue("@TestID", TestID);

                    for (i = 0; i < ListOfRegisteredPeople.Count; i++)
                    {
                        Command.Parameters.AddWithValue("@" + ListOfRegisteredPeople[i].LocalLicenseApplicationID, ListOfRegisteredPeople[i].LocalLicenseApplicationID);
                    }

                    await Connection.OpenAsync();

                    if (await Command.ExecuteNonQueryAsync() > 0)
                    {
                        Success = true;
                    }
                }
                catch (Exception ex)
                {
                    clsEventLog.WriteToEventLog(ex.Message, enLogType.Error);
                }
                finally
                {
                    if (Command != null)
                    {
                        Command.Dispose();
                    }

                    if (Connection != null)
                    {
                        Connection.Close();
                        Connection.Dispose();
                    }
                }
            }

            return Success;
        }

        public static async Task<bool> SetResults(List<clsPeopleRegisteredInAppointmentDTO> ListOfRegisteredPeopleRenewLicense)
        {
            bool Success = false;

            if (ListOfRegisteredPeopleRenewLicense.Count > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    StringBuilder stringBuilder = new StringBuilder();

                    short i;
                    for (i = 0; i < ListOfRegisteredPeopleRenewLicense.Count; i++)
                    {
                        if (ListOfRegisteredPeopleRenewLicense[i]?.Result == true)
                        {
                            stringBuilder.Append($"update [Enrollments] set [Test_Result] = 1 where [RetakeTestOrderID] = @{ListOfRegisteredPeopleRenewLicense[i].ApplicationID};");
                        }
                        else
                        {
                            stringBuilder.Append($"update [Enrollments] set [Test_Result] = 0 where [RetakeTestOrderID] = @{ListOfRegisteredPeopleRenewLicense[i].ApplicationID};");
                        }
                    }

                    Command = new SqlCommand(stringBuilder.ToString(), Connection);

                    for (i = 0; i < ListOfRegisteredPeopleRenewLicense.Count; i++)
                    {
                        Command.Parameters.AddWithValue("@" + ListOfRegisteredPeopleRenewLicense[i].ApplicationID, ListOfRegisteredPeopleRenewLicense[i].ApplicationID);
                    }

                    await Connection.OpenAsync();

                    if (await Command.ExecuteNonQueryAsync() > 0)
                    {
                        Success = true;
                    }
                }
                catch (Exception ex)
                {
                    clsEventLog.WriteToEventLog(ex.Message, enLogType.Error);
                }
                finally
                {
                    if (Command != null)
                    {
                        Command.Dispose();
                    }

                    if (Connection != null)
                    {
                        Connection.Close();
                        Connection.Dispose();
                    }
                }
            }

            return Success;
        }

        public static async Task<bool> IsPassInTest(int NewLocalLicenseApplicationID, byte TestID)
        {
            bool Pass = false;

            if (TestID > 0 && NewLocalLicenseApplicationID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string FindlQuery = "select [Enrollment_ID] from [Enrollments] where [New_Local_License_ID] = @NewLocalLicenseApplicationID and [Test_ID] = @TestID and [Test_Result] = 1;";

                    Command = new SqlCommand(FindlQuery, Connection);

                    Command.Parameters.AddWithValue("@NewLocalLicenseApplicationID", NewLocalLicenseApplicationID);
                    Command.Parameters.AddWithValue("@TestID", TestID);

                    await Connection.OpenAsync();

                    Reader = await Command.ExecuteReaderAsync();

                    if (Reader.HasRows)
                    {
                        Pass = true;
                    }
                }
                catch (Exception ex)
                {
                    clsEventLog.WriteToEventLog(ex.Message, enLogType.Error);
                }
                finally
                {
                    if (Reader != null)
                    {
                        Reader.Close();
                        Reader.Dispose();
                    }

                    if (Command != null)
                    {
                        Command.Dispose();
                    }

                    if (Connection != null)
                    {
                        Connection.Close();
                        Connection.Dispose();
                    }
                }
            }

            return Pass;
        }

        public static async Task<bool> IsPassedInVisionTestRenewLicense(int ApplicationID)
        {
            bool Pass = false;

            if (ApplicationID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string FindlQuery = "select [Enrollment_ID] from [Enrollments] where [RetakeTestOrderID] = @ApplicationID and [Test_ID] = @TestID and [Test_Result] = 1;";

                    Command = new SqlCommand(FindlQuery, Connection);

                    Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                    Command.Parameters.AddWithValue("@TestID", (byte)enTests.eVisionTest);

                    await Connection.OpenAsync();

                    Reader = await Command.ExecuteReaderAsync();

                    if (Reader.HasRows)
                    {
                        Pass = true;
                    }
                }
                catch (Exception ex)
                {
                    clsEventLog.WriteToEventLog(ex.Message, enLogType.Error);
                }
                finally
                {
                    if (Reader != null)
                    {
                        Reader.Close();
                        Reader.Dispose();
                    }

                    if (Command != null)
                    {
                        Command.Dispose();
                    }

                    if (Connection != null)
                    {
                        Connection.Close();
                        Connection.Dispose();
                    }
                }
            }

            return Pass;
        }

        public static async Task<bool> DeleteByNewLocalLicenseApplicationID(int NewLocalLicenseApplicationID)
        {
            bool Deleted = false;

            if (NewLocalLicenseApplicationID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string DeletedQuery = "delete from [Enrollments] where [New_Local_License_ID] = @NewLocalLicenseApplicationID";

                    Command = new SqlCommand(DeletedQuery, Connection);

                    Command.Parameters.AddWithValue("@NewLocalLicenseApplicationID", NewLocalLicenseApplicationID);

                    await Connection.OpenAsync();

                    if (await Command.ExecuteNonQueryAsync() > 0)
                    {
                        Deleted = true;
                    }
                }
                catch (Exception ex)
                {
                    clsEventLog.WriteToEventLog(ex.Message, enLogType.Error);
                }
                finally
                {
                    if (Command != null)
                    {
                        Command.Dispose();
                    }

                    if (Connection != null)
                    {
                        Connection.Close();
                        Connection.Dispose();
                    }
                }
            }

            return Deleted;
        }

        public static async Task<bool> DeleteByApplicationID(int ApplicationID)
        {
            bool Deleted = false;

            if (ApplicationID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string DeletedQuery = "delete from [Enrollments] where [RetakeTestOrderID] = @ApplicationID";

                    Command = new SqlCommand(DeletedQuery, Connection);

                    Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                    await Connection.OpenAsync();

                    if (await Command.ExecuteNonQueryAsync() > 0)
                    {
                        Deleted = true;
                    }
                }
                catch (Exception ex)
                {
                    clsEventLog.WriteToEventLog(ex.Message, enLogType.Error);
                }
                finally
                {
                    if (Command != null)
                    {
                        Command.Dispose();
                    }

                    if (Connection != null)
                    {
                        Connection.Close();
                        Connection.Dispose();
                    }
                }
            }

            return Deleted;
        }

        public static async Task<bool> IsEnrollmentFoFutureAppointment(int NewLocalLicenseApplicationID, int TestID)
        {
            bool Exist = false;

            if (NewLocalLicenseApplicationID > 0 && TestID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string FindlQuery = @"select [Enrollments].[Enrollment_ID], [Tests_Appointments].[Appointment] from 
                                          [Enrollments] join [Tests_Appointments] on 
                                          [Enrollments].[Appointment_ID] = [Tests_Appointments].[Appointment_ID]
                                          where [New_Local_License_ID] = @NewLocalLicenseApplicationID and [Appointment] > @DateNow and [Test_Result] is null;";

                    Command = new SqlCommand(FindlQuery, Connection);

                    Command.Parameters.AddWithValue("@DateNow", DateTime.Now.Date);
                    Command.Parameters.AddWithValue("@NewLocalLicenseApplicationID", NewLocalLicenseApplicationID);

                    await Connection.OpenAsync();

                    Reader = await Command.ExecuteReaderAsync();

                    if (Reader.HasRows)
                    {
                        Exist = true;
                    }
                }
                catch (Exception ex)
                {
                    clsEventLog.WriteToEventLog(ex.Message, enLogType.Error);
                }
                finally
                {
                    if (Reader != null)
                    {
                        Reader.Close();
                        Reader.Dispose();
                    }

                    if (Command != null)
                    {
                        Command.Dispose();
                    }

                    if (Connection != null)
                    {
                        Connection.Close();
                        Connection.Dispose();
                    }
                }
            }

            return Exist;
        }





    }
}
