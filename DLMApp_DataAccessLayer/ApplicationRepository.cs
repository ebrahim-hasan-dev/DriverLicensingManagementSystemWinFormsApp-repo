using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;


namespace DLMApp_DataAccessLayer
{
    public class ApplicationRepository
    {
        // ===============================================================================================================

        public static async Task<clsApplicationType> GetApplicationType(enApplicationTypes ApplicationTypeID)
        {
            clsApplicationType applicationType = null;
            
            SqlConnection Connection = null;
            SqlCommand Command = null;
            SqlDataReader Reader = null;

            try
            {
                Connection = new SqlConnection(clsConnectionString.ConnectionString);

                string GetApplicationTypeQuery = "select * from [Services_Types] where [Service_ID] = @ApplicationTypeID;";

                Command = new SqlCommand(GetApplicationTypeQuery, Connection);

                Command.Parameters.AddWithValue("@ApplicationTypeID", (byte)ApplicationTypeID);

                await Connection.OpenAsync();

                Reader = await Command.ExecuteReaderAsync();

                while (await Reader.ReadAsync())
                {
                    applicationType = new clsApplicationType();

                    byte.TryParse(Reader["Service_ID"].ToString(), out byte ID);
                    applicationType.ApplicationTypeID = ID;

                    applicationType.ApplicationTypeName = Reader["Service_Name"] as string ?? "";

                    float.TryParse(Reader["Service_Fees"].ToString(), out float ServiceFees);
                    applicationType.ApplicationTypeFees = ServiceFees;
                }
            }
            catch(Exception ex)
            {
                clsEventLog.WriteToEventLog(ex.Message, enLogType.Error);

                applicationType = null;
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

            return applicationType;
        }

        public static async Task<List<clsApplicationType>> GetAllApplicationTypes()
        {
            List<clsApplicationType> ListOfApplicationTypes = new List<clsApplicationType>();

            SqlConnection Connection = null;
            SqlCommand Command = null;
            SqlDataReader Reader = null;

            try
            {
                Connection = new SqlConnection(clsConnectionString.ConnectionString);

                string GetAllQuery = "select * from [Services_Types];";

                Command = new SqlCommand(GetAllQuery, Connection);

                await Connection.OpenAsync();

                Reader = await Command.ExecuteReaderAsync();

                while (await Reader.ReadAsync())
                {
                    clsApplicationType ApplicationType = new clsApplicationType();

                    byte.TryParse(Reader["Service_ID"].ToString(), out byte ID);
                    ApplicationType.ApplicationTypeID = ID;

                    ApplicationType.ApplicationTypeName = Reader["Service_Name"] as string ?? "";

                    float.TryParse(Reader["Service_Fees"].ToString(), out float ServiceFees);
                    ApplicationType.ApplicationTypeFees = ServiceFees;

                    ListOfApplicationTypes.Add(ApplicationType);
                }
            }
            catch(Exception ex)
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

            return ListOfApplicationTypes;
        }

        public static async Task<bool> UpdateApplicationTypeFees(byte ApplicationTypeID, float ApplicationTypeFees)
        {
            bool Updated = false;

            if (ApplicationTypeID > 0 && ApplicationTypeFees > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string UpdateQuery = "update [Services_Types] set [Service_Fees] = @ApplicationTypeFees where [Service_ID] = @ApplicationTypeID;";

                    Command = new SqlCommand(UpdateQuery, Connection);

                    Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                    Command.Parameters.AddWithValue("@ApplicationTypeFees", ApplicationTypeFees);

                    await Connection.OpenAsync();

                    if (await Command.ExecuteNonQueryAsync() > 0)
                    {
                        Updated = true;
                    }
                }
                catch(Exception ex)
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

            return Updated;
        }


        // ================================================================================================================


        public static async Task<bool> AddNewApplication(clsApplication Application)
        {
            bool Added = false;

            if (Application.IsFull())
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string AddedQuery = @"insert into [Orders] 
                                        (Service_Fees, Last_Status_DateTime, Added_DateTime, Order_Status_ID, Service_ID, CreatedBy_UserID, Person_ID) 
                                        values (@ServiceFees, null, default, @OrderStatusID, @ServiceID, @CreatedByUserID, @PersonID);
                                         select Scope_Identity();";


                    Command = new SqlCommand(AddedQuery, Connection);

                    Command.Parameters.AddWithValue("@ServiceFees", Application.Fees);
                    Command.Parameters.AddWithValue("@OrderStatusID", (byte)Application.StatusID);
                    Command.Parameters.AddWithValue("@ServiceID", (byte)Application.ApplicationTypeID);
                    Command.Parameters.AddWithValue("@CreatedByUserID", Application.CreatedByUserID);
                    Command.Parameters.AddWithValue("@PersonID", Application.PersonID);

                    await Connection.OpenAsync();

                    object ID = await Command.ExecuteScalarAsync();

                    if (ID != null)
                    {
                        if (int.TryParse(ID.ToString(), out int ApplicationID))
                        {
                            Application.ApplicationID = ApplicationID;
                            Added = true;
                        }
                    }
                }
                catch(Exception ex)
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

            return Added;
        }

        public static async Task<bool> AddNewLocalLisenceApplication(clsNewLocalLicenseApplication NewLocalLicenseApplication)
        {
           bool Added = false;

            SqlConnection Connection = null;
            SqlCommand Command = null;

            if (NewLocalLicenseApplication.IsFull())
            {
                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string AddedQuery = @"insert into [New_Local_Licenses_Order] ([Order_ID], [License_Category_ID], [Passed_Tests]) 
                                                    values (@OrderID, @LicenseCategoryID, 0);
                                                     select Scope_Identity();";

                    Command = new SqlCommand(AddedQuery, Connection);

                    Command.Parameters.AddWithValue("@OrderID", NewLocalLicenseApplication.ApplicationInfo.ApplicationID);
                    Command.Parameters.AddWithValue("@LicenseCategoryID", NewLocalLicenseApplication.LicenseClassID);

                    await Connection.OpenAsync();

                    object ID = await Command.ExecuteScalarAsync();

                    if (ID != null)
                    {
                        if (int.TryParse(ID.ToString(), out int NewLocalLicenseApplicationID))
                        {
                            NewLocalLicenseApplication.NewLocalLicenseApplicationID = NewLocalLicenseApplicationID;
                            Added = true;
                        }
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

            return Added;
        }

        public static async Task<int> FindNewLocalLicenseID(int ApplicationID)
        {
            int NewLocalLicenseID = 0;

            if (ApplicationID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string FindQuery = "select [New_Local_License_ID] from [New_Local_Licenses_Order] where [Order_ID] = @OrderID;";

                    Command = new SqlCommand(FindQuery, Connection);

                    Command.Parameters.AddWithValue("@OrderID", ApplicationID);

                    await Connection.OpenAsync();

                    object ID = await Command.ExecuteScalarAsync();

                    if (ID != null)
                    {
                        int.TryParse(ID.ToString(), out NewLocalLicenseID);
                    }
                }
                catch(Exception ex)
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

            return NewLocalLicenseID;
        }

        public static async Task<bool> Delete(int ApplicationID)
        {
            bool Delete = false;

            if (ApplicationID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string DeleteQuery = "delete from [Orders] where [Order_ID] = @ApplicationID;";

                    Command = new SqlCommand(DeleteQuery, Connection);

                    Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                    await Connection.OpenAsync();

                    if (await Command.ExecuteNonQueryAsync() > 0)
                    {
                        Delete = true;
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

            return Delete;
        }

        public static async Task<bool> UpdateApplicationStatus(int ApplicationID, enApplicationStatus ApplicationStatus)
        {
            bool Success = false;

            SqlConnection Connection = null;
            SqlCommand Command = null;

            if (ApplicationID > 0)
            {
                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string AddedQuery = $"update [Orders] set [Order_Status_ID] = {(byte)ApplicationStatus}, [Last_Status_DateTime] = @DateTimeNow where [Order_ID] = @ApplicationID;";

                    Command = new SqlCommand(AddedQuery, Connection);

                    Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                    Command.Parameters.AddWithValue("@DateTimeNow", DateTime.Now);

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

        public static async Task<clsApplication> Find(int ApplicationID)
        {
            clsApplication Application = null;

            if (ApplicationID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string FindQuery = @"select [Orders].*, [User_Name] from [Orders] join [Users] on [Orders].[CreatedBy_UserID] = [Users].[User_ID]
                                            where [Order_ID] = @ApplicationID;";

                    Command = new SqlCommand(FindQuery, Connection);

                    Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                    await Connection.OpenAsync();

                    Reader = await Command.ExecuteReaderAsync();

                    if (await Reader.ReadAsync())
                    {
                        Application = new clsApplication();

                        Application.ApplicationID = ApplicationID;

                        Enum.TryParse(Reader["Order_Status_ID"].ToString(), out enApplicationStatus ApplicationStatus);
                        Application.StatusID = ApplicationStatus;

                        Enum.TryParse(Reader["Service_ID"].ToString(), out enApplicationTypes ApplicationTypes);
                        Application.ApplicationTypeID = ApplicationTypes;

                        float.TryParse(Reader["Service_Fees"].ToString(), out float fees);
                        Application.Fees = fees;

                        DateTime.TryParse(Reader["Added_DateTime"].ToString(), out DateTime Date);
                        Application.AddedDateTme = Date;

                        if (Reader["Last_Status_DateTime"] == DBNull.Value)
                        {
                            Application.LastUpdateDate = default(DateTime);
                        }
                        else
                        {
                            DateTime.TryParse(Reader["Last_Status_DateTime"].ToString(), out Date);
                            Application.LastUpdateDate = Date;
                        }

                        int.TryParse(Reader["Person_ID"].ToString(), out int PersonID);
                        Application.PersonID = PersonID;

                        Application.CreatedByUser = Reader["User_Name"] as string ?? "";
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

            return Application;
        }

        public static async Task<List<clsNewLocalLicenseApplication>> FindAllNewLocalLicensesApplications()
        {
            List<clsNewLocalLicenseApplication> ListOfNewLocalLicenseApplications = new List<clsNewLocalLicenseApplication>();

            SqlConnection Connection = null;
            SqlCommand Command = null;
            SqlDataReader Reader = null;

            try
            {
                Connection = new SqlConnection(clsConnectionString.ConnectionString);

                string GetAllQuery = "select * from [vNewLocalLicensesOrders] where [Service_ID] = 1;";

                Command = new SqlCommand(GetAllQuery, Connection);

                await Connection.OpenAsync();

                Reader = await Command.ExecuteReaderAsync();

                while (await Reader.ReadAsync())
                {
                    clsNewLocalLicenseApplication NewLocalLicenseApplication = new clsNewLocalLicenseApplication();

                    int.TryParse(Reader["Order_ID"].ToString(), out int ID);
                    NewLocalLicenseApplication.ApplicationInfo.ApplicationID = ID;

                    Enum.TryParse(Reader["Order_Status_ID"].ToString(), out enApplicationStatus ApplicationStatus);
                    NewLocalLicenseApplication.ApplicationInfo.StatusID = ApplicationStatus;

                    Enum.TryParse(Reader["Service_ID"].ToString(), out enApplicationTypes ApplicationTypes);
                    NewLocalLicenseApplication.ApplicationInfo.ApplicationTypeID = ApplicationTypes;

                    float.TryParse(Reader["Service_Fees"].ToString(), out float fees);
                    NewLocalLicenseApplication.ApplicationInfo.Fees = fees;

                    DateTime.TryParse(Reader["Added_DateTime"].ToString(), out DateTime Date);
                    NewLocalLicenseApplication.ApplicationInfo.AddedDateTme = Date;

                    if (Reader["Last_Status_DateTime"] == DBNull.Value)
                    {
                        NewLocalLicenseApplication.ApplicationInfo.LastUpdateDate = default(DateTime);
                    }
                    else
                    {
                        DateTime.TryParse(Reader["Last_Status_DateTime"].ToString(), out Date);
                        NewLocalLicenseApplication.ApplicationInfo.LastUpdateDate = Date;
                    }

                    int.TryParse(Reader["Person_ID"].ToString(), out int PersonID);
                    NewLocalLicenseApplication.ApplicationInfo.PersonID = PersonID;

                    NewLocalLicenseApplication.ApplicationInfo.CreatedByUser = Reader["User_Name"] as string ?? "";

                    byte.TryParse(Reader["Passed_Tests"].ToString(), out byte PassedTests);
                    NewLocalLicenseApplication.PassedTests = PassedTests;


                    Enum.TryParse(Reader["License_Category_ID"].ToString(), out enLicenseClasses LicenseClassID);
                    NewLocalLicenseApplication.LicenseClassID = LicenseClassID;


                    ListOfNewLocalLicenseApplications.Add(NewLocalLicenseApplication);
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

            return ListOfNewLocalLicenseApplications;
        }

        public static async Task<List<clsNewLocalLicenseApplication>> FindAllNewLocalLicensesApplications(DateTime AddedDateTime)
        {
            List<clsNewLocalLicenseApplication> ListOfNewLocalLicenseApplications = new List<clsNewLocalLicenseApplication>();

            if (AddedDateTime != default(DateTime))
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string GetAllQuery = @"select * from [vNewLocalLicensesOrders] where ([Added_DateTime] between @AddedDateTime and @NextDate)
                                            and [Service_ID] = 1;";

                    Command = new SqlCommand(GetAllQuery, Connection);

                    Command.Parameters.AddWithValue("@AddedDateTime", AddedDateTime.Date);
                    Command.Parameters.AddWithValue("@NextDate", AddedDateTime.AddDays(1).Date);

                    await Connection.OpenAsync();

                    Reader = await Command.ExecuteReaderAsync();

                    while (await Reader.ReadAsync())
                    {
                        clsNewLocalLicenseApplication NewLocalLicenseApplication = new clsNewLocalLicenseApplication();

                        int.TryParse(Reader["Order_ID"].ToString(), out int ID);
                        NewLocalLicenseApplication.ApplicationInfo.ApplicationID = ID;

                        Enum.TryParse(Reader["Order_Status_ID"].ToString(), out enApplicationStatus ApplicationStatus);
                        NewLocalLicenseApplication.ApplicationInfo.StatusID = ApplicationStatus;

                        Enum.TryParse(Reader["Service_ID"].ToString(), out enApplicationTypes ApplicationTypes);
                        NewLocalLicenseApplication.ApplicationInfo.ApplicationTypeID = ApplicationTypes;

                        float.TryParse(Reader["Service_Fees"].ToString(), out float fees);
                        NewLocalLicenseApplication.ApplicationInfo.Fees = fees;

                        DateTime.TryParse(Reader["Added_DateTime"].ToString(), out DateTime Date);
                        NewLocalLicenseApplication.ApplicationInfo.AddedDateTme = Date;

                        if (Reader["Last_Status_DateTime"] == DBNull.Value)
                        {
                            NewLocalLicenseApplication.ApplicationInfo.LastUpdateDate = default(DateTime);
                        }
                        else
                        {
                            DateTime.TryParse(Reader["Last_Status_DateTime"].ToString(), out Date);
                            NewLocalLicenseApplication.ApplicationInfo.LastUpdateDate = Date;
                        }

                        int.TryParse(Reader["Person_ID"].ToString(), out int PersonID);
                        NewLocalLicenseApplication.ApplicationInfo.PersonID = PersonID;

                        NewLocalLicenseApplication.ApplicationInfo.CreatedByUser = Reader["User_Name"] as string ?? "";

                        byte.TryParse(Reader["Passed_Tests"].ToString(), out byte PassedTests);
                        NewLocalLicenseApplication.PassedTests = PassedTests;


                        Enum.TryParse(Reader["License_Category_ID"].ToString(), out enLicenseClasses LicenseClassID);
                        NewLocalLicenseApplication.LicenseClassID = LicenseClassID;

                        ListOfNewLocalLicenseApplications.Add(NewLocalLicenseApplication);
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

            return ListOfNewLocalLicenseApplications;
        }

        public static async Task<List<clsApplication>> FindAllRenewLicensesApplications()
        {
            List<clsApplication> ListOfApplications = new List<clsApplication>();

            SqlConnection Connection = null;
            SqlCommand Command = null;
            SqlDataReader Reader = null;

            try
            {
                Connection = new SqlConnection(clsConnectionString.ConnectionString);

                string GetAllQuery = "select * from [vRenewLicensesOrders] where [Service_ID] = 2;";

                Command = new SqlCommand(GetAllQuery, Connection);

                await Connection.OpenAsync();

                Reader = await Command.ExecuteReaderAsync();

                while (await Reader.ReadAsync())
                {
                    clsApplication Application = new clsApplication();

                    int.TryParse(Reader["Order_ID"].ToString(), out int ID);
                    Application.ApplicationID = ID;

                    Enum.TryParse(Reader["Order_Status_ID"].ToString(), out enApplicationStatus ApplicationStatus);
                    Application.StatusID = ApplicationStatus;

                    Enum.TryParse(Reader["Service_ID"].ToString(), out enApplicationTypes ApplicationTypes);
                    Application.ApplicationTypeID = ApplicationTypes;

                    float.TryParse(Reader["Service_Fees"].ToString(), out float fees);
                    Application.Fees = fees;

                    DateTime.TryParse(Reader["Added_DateTime"].ToString(), out DateTime Date);
                    Application.AddedDateTme = Date;

                    if (Reader["Last_Status_DateTime"] == DBNull.Value)
                    {
                        Application.LastUpdateDate = default(DateTime);
                    }
                    else
                    {
                        DateTime.TryParse(Reader["Last_Status_DateTime"].ToString(), out Date);
                        Application.LastUpdateDate = Date;
                    }

                    int.TryParse(Reader["Person_ID"].ToString(), out int PersonID);
                    Application.PersonID = PersonID;

                    Application.CreatedByUser = Reader["User_Name"] as string ?? "";

                    if (Reader["Test_Result"] == DBNull.Value || (bool)Reader["Test_Result"] == false)
                    {
                        Application.PassedInVisionTest = false;
                    }
                    else
                    {
                        Application.PassedInVisionTest = true;
                    }

                 
                    ListOfApplications.Add(Application);
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

            return ListOfApplications;
        }

        public static async Task<List<clsApplication>> FindAllRenewLicensesApplications(DateTime AddedDateTime)
        {
            List<clsApplication> ListOfApplications = new List<clsApplication>();

            if (AddedDateTime != default(DateTime))
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string GetAllQuery = @"select * from [vRenewLicensesOrders] where ([Added_DateTime] between @AddedDateTime and @NextDay)
                                            and [Service_ID] = 2;";

                    Command = new SqlCommand(GetAllQuery, Connection);

                    Command.Parameters.AddWithValue("@AddedDateTime", AddedDateTime.Date);
                    Command.Parameters.AddWithValue("@NextDay", AddedDateTime.AddDays(1).Date);

                    await Connection.OpenAsync();

                    Reader = await Command.ExecuteReaderAsync();

                    while (await Reader.ReadAsync())
                    {
                        clsApplication Application = new clsApplication();

                        int.TryParse(Reader["Order_ID"].ToString(), out int ID);
                        Application.ApplicationID = ID;

                        Enum.TryParse(Reader["Order_Status_ID"].ToString(), out enApplicationStatus ApplicationStatus);
                        Application.StatusID = ApplicationStatus;

                        Enum.TryParse(Reader["Service_ID"].ToString(), out enApplicationTypes ApplicationTypes);
                        Application.ApplicationTypeID = ApplicationTypes;

                        float.TryParse(Reader["Service_Fees"].ToString(), out float fees);
                        Application.Fees = fees;

                        DateTime.TryParse(Reader["Added_DateTime"].ToString(), out DateTime Date);
                        Application.AddedDateTme = Date;

                        if (Reader["Last_Status_DateTime"] == DBNull.Value)
                        {
                            Application.LastUpdateDate = default(DateTime);
                        }
                        else
                        {
                            DateTime.TryParse(Reader["Last_Status_DateTime"].ToString(), out Date);
                            Application.LastUpdateDate = Date;
                        }

                        int.TryParse(Reader["Person_ID"].ToString(), out int PersonID);
                        Application.PersonID = PersonID;

                        Application.CreatedByUser = Reader["User_Name"] as string ?? "";

                        if (Reader["Test_Result"] == DBNull.Value || (bool)Reader["Test_Result"] == false)
                        {
                            Application.PassedInVisionTest = false;
                        }
                        else
                        {
                            Application.PassedInVisionTest = true;
                        }

                        
                        ListOfApplications.Add(Application);
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

            return ListOfApplications;
        }

        public static async Task<bool> UpdateNumberOfPassedTests(List<clsPeopleRegisteredInAppointmentDTO> ListOfRegisteredPeople)
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
                            stringBuilder.Append($"update [New_Local_Licenses_Order] set [Passed_Tests] += 1 where [New_Local_License_ID] = @{ListOfRegisteredPeople[i].LocalLicenseApplicationID};");
                        }
                    }

                    if (stringBuilder.Length > 0)
                    {
                        Command = new SqlCommand(stringBuilder.ToString(), Connection);

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
                    else
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

        public static async Task<bool> IsStatusNew(int ApplicationID)
        {
            bool StatusNew = false;

            if (ApplicationID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string GetAllQuery = "select [Order_ID] from [Orders] where [Order_ID] = @ApplicationID and [Order_Status_ID] = 1;";

                    Command = new SqlCommand(GetAllQuery, Connection);

                    Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                    await Connection.OpenAsync();

                    Reader = await Command.ExecuteReaderAsync();

                    if (Reader.HasRows)
                    {
                        StatusNew = true;
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

            return StatusNew;
        }

        public static async Task<int> DoesHaveApplicationOfSameLicenseClassForNewLocalLicenseStatusNew(int PersonID, byte LicneseClass)
        {
            int ApplicationID = 0;

            if (PersonID > 0 && LicneseClass > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string FindQuery = @"select [Orders].[Order_ID], [License_Category_ID] from [Orders] join [New_Local_Licenses_Order] 
                                        on [Orders].[Order_ID] = [New_Local_Licenses_Order].[Order_ID]
                                        where [Person_ID] = @PersonID and [Service_ID] = 1 and [Order_Status_ID] = 1 and [License_Category_ID] = @LicneseClass;";

                    Command = new SqlCommand(FindQuery, Connection);

                    Command.Parameters.AddWithValue("@PersonID", PersonID);
                    Command.Parameters.AddWithValue("@LicneseClass", LicneseClass);

                    await Connection.OpenAsync();

                    Reader = await Command.ExecuteReaderAsync();

                    if (await Reader.ReadAsync())
                    {
                        int.TryParse(Reader["Order_ID"].ToString(), out int ID);
                        ApplicationID = ID;
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

            return ApplicationID;
        }

        public static async Task<List<clsApplication>> FindAllRenewLicenseApplicationsForNationalNumber(string NationalNumber)
        {
            List<clsApplication> ListOfApplications = new List<clsApplication>();

            if (!string.IsNullOrWhiteSpace(NationalNumber))
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string GetAllQuery = "select * from [vRenewLicensesOrdersForNationalNumber] where [National_Number] = @NationalNumber and [Service_ID] = 2;";

                    Command = new SqlCommand(GetAllQuery, Connection);

                    Command.Parameters.AddWithValue("@NationalNumber", NationalNumber);

                    await Connection.OpenAsync();

                    Reader = await Command.ExecuteReaderAsync();

                    while (await Reader.ReadAsync())
                    {
                        clsApplication Application = new clsApplication();

                        int.TryParse(Reader["Order_ID"].ToString(), out int ID);
                        Application.ApplicationID = ID;

                        Enum.TryParse(Reader["Order_Status_ID"].ToString(), out enApplicationStatus ApplicationStatus);
                        Application.StatusID = ApplicationStatus;

                        Enum.TryParse(Reader["Service_ID"].ToString(), out enApplicationTypes ApplicationTypes);
                        Application.ApplicationTypeID = ApplicationTypes;

                        float.TryParse(Reader["Service_Fees"].ToString(), out float fees);
                        Application.Fees = fees;

                        DateTime.TryParse(Reader["Added_DateTime"].ToString(), out DateTime Date);
                        Application.AddedDateTme = Date;

                        if (Reader["Last_Status_DateTime"] == DBNull.Value)
                        {
                            Application.LastUpdateDate = default(DateTime);
                        }
                        else
                        {
                            DateTime.TryParse(Reader["Last_Status_DateTime"].ToString(), out Date);
                            Application.LastUpdateDate = Date;
                        }

                        int.TryParse(Reader["Person_ID"].ToString(), out int PersonID);
                        Application.PersonID = PersonID;

                        Application.CreatedByUser = Reader["User_Name"] as string ?? "";


                        if (Reader["Test_Result"] == DBNull.Value || (bool)Reader["Test_Result"] == false)
                        {
                            Application.PassedInVisionTest = false;
                        }
                        else
                        {
                            Application.PassedInVisionTest = true;
                        }


                        ListOfApplications.Add(Application);
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

            return ListOfApplications;
        }

        public static async Task<List<clsNewLocalLicenseApplication>> FindAllNewLocalLicensesApplicationsForNationalNumber(string NationalNumber)
        {
            List<clsNewLocalLicenseApplication> ListOfNewLocalLicenseApplications = new List<clsNewLocalLicenseApplication>();

            if (!string.IsNullOrWhiteSpace(NationalNumber))
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string GetAllQuery = "select * from [vNewLocalLicensesOrdersForNationalNumber] where [National_Number] = @NationalNumber and [Service_ID] = 1;";

                    Command = new SqlCommand(GetAllQuery, Connection);

                    Command.Parameters.AddWithValue("@NationalNumber", NationalNumber);

                    await Connection.OpenAsync();

                    Reader = await Command.ExecuteReaderAsync();

                    while (await Reader.ReadAsync())
                    {
                        clsNewLocalLicenseApplication NewLocalLicenseApplication = new clsNewLocalLicenseApplication();

                        int.TryParse(Reader["Order_ID"].ToString(), out int ID);
                        NewLocalLicenseApplication.ApplicationInfo.ApplicationID = ID;

                        Enum.TryParse(Reader["Order_Status_ID"].ToString(), out enApplicationStatus ApplicationStatus);
                        NewLocalLicenseApplication.ApplicationInfo.StatusID = ApplicationStatus;

                        Enum.TryParse(Reader["Service_ID"].ToString(), out enApplicationTypes ApplicationTypes);
                        NewLocalLicenseApplication.ApplicationInfo.ApplicationTypeID = ApplicationTypes;

                        float.TryParse(Reader["Service_Fees"].ToString(), out float fees);
                        NewLocalLicenseApplication.ApplicationInfo.Fees = fees;

                        DateTime.TryParse(Reader["Added_DateTime"].ToString(), out DateTime Date);
                        NewLocalLicenseApplication.ApplicationInfo.AddedDateTme = Date;

                        if (Reader["Last_Status_DateTime"] == DBNull.Value)
                        {
                            NewLocalLicenseApplication.ApplicationInfo.LastUpdateDate = default(DateTime);
                        }
                        else
                        {
                            DateTime.TryParse(Reader["Last_Status_DateTime"].ToString(), out Date);
                            NewLocalLicenseApplication.ApplicationInfo.LastUpdateDate = Date;
                        }

                        int.TryParse(Reader["Person_ID"].ToString(), out int PersonID);
                        NewLocalLicenseApplication.ApplicationInfo.PersonID = PersonID;

                        NewLocalLicenseApplication.ApplicationInfo.CreatedByUser = Reader["User_Name"] as string ?? "";

                        byte.TryParse(Reader["Passed_Tests"].ToString(), out byte PassedTests);
                        NewLocalLicenseApplication.PassedTests = PassedTests;


                        Enum.TryParse(Reader["License_Category_ID"].ToString(), out enLicenseClasses LicenseClassID);
                        NewLocalLicenseApplication.LicenseClassID = LicenseClassID;

                        ListOfNewLocalLicenseApplications.Add(NewLocalLicenseApplication);
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

            return ListOfNewLocalLicenseApplications;
        }

        public static async Task<bool> MakeFaildRenewLicenseApplicationsIsCompleted(List<clsPeopleRegisteredInAppointmentDTO> ListOfRegisteredPeopleRenewLicense)
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
                        if (ListOfRegisteredPeopleRenewLicense[i]?.Result == false)
                        {
                            stringBuilder.Append($"update [Orders] set [Order_Status_ID] = 3 where [Order_ID] = @{ListOfRegisteredPeopleRenewLicense[i].ApplicationID};");
                        }
                    }

                    if (stringBuilder.Length > 0)
                    {
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
                    else
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





    }
}
