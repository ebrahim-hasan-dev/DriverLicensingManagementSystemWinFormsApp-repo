using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLMApp_DataAccessLayer
{
    public class PeopleRegisteredInAppointmentDTORepository
    {
        public static List<clsPeopleRegisteredInAppointmentDTO> GetAllRegisteredPeopleInAppointment(byte TestID, ref string CreatedByUser)
        {
            List<clsPeopleRegisteredInAppointmentDTO> ListOfRegisteredPeople = new List<clsPeopleRegisteredInAppointmentDTO>();

            if (TestID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string GetAllQuery = @"select * from [vPeopleRegisteredInAppointment] where [Test_ID] = @TestID and [Is_Completed] = 0
                                        and [Appointment] > @DateNow;";

                    Command = new SqlCommand(GetAllQuery, Connection);

                    Command.Parameters.AddWithValue("@TestID", TestID);
                    Command.Parameters.AddWithValue("@DateNow", DateTime.Now);

                    Connection.Open();

                    Reader = Command.ExecuteReader();


                    while (Reader.Read())
                    {
                        clsPeopleRegisteredInAppointmentDTO PeopleRegisteredInAppointmentDTO = new clsPeopleRegisteredInAppointmentDTO();

                        int.TryParse(Reader["Person_ID"].ToString(), out int PersonID);
                        PeopleRegisteredInAppointmentDTO.PersonID = PersonID;

                        int.TryParse(Reader["Order_ID"].ToString(), out int ID);
                        PeopleRegisteredInAppointmentDTO.ApplicationID = ID;

                        int.TryParse(Reader["New_Local_License_ID"].ToString(), out ID);
                        PeopleRegisteredInAppointmentDTO.LocalLicenseApplicationID = ID;

                        PeopleRegisteredInAppointmentDTO.FirstName = Reader["First_Name"] as string ?? "";
                        PeopleRegisteredInAppointmentDTO.SecondName = Reader["Second_Name"] as string ?? "";
                        PeopleRegisteredInAppointmentDTO.ThirdName = Reader["Third_Name"] as string ?? "";
                        PeopleRegisteredInAppointmentDTO.LastName = Reader["Last_Name"] as string ?? "";
                        PeopleRegisteredInAppointmentDTO.NationalNumber = Reader["National_Number"] as string ?? "";
                        CreatedByUser = Reader["AppointmentCreatedByUserName"] as string ?? "";


                        if (Reader["Notes"] == DBNull.Value)
                            PeopleRegisteredInAppointmentDTO.Notes = "";
                        else
                            PeopleRegisteredInAppointmentDTO.Notes = Reader["Notes"] as string ?? "";

                        if (Reader["Test_Result"] == DBNull.Value)
                            PeopleRegisteredInAppointmentDTO.Result = null;
                        else
                            PeopleRegisteredInAppointmentDTO.Result = (bool)Reader["Test_Result"];

                        DateTime.TryParse(Reader["Appointment"].ToString(), out DateTime appointment);
                        PeopleRegisteredInAppointmentDTO.Appointment = appointment;

                        short.TryParse(Reader["NumberOfPeople"].ToString(), out short NumberOfPeopleRegisteredInAppointment);
                        PeopleRegisteredInAppointmentDTO.NumberOfPeopleRegisteredInAppointment = NumberOfPeopleRegisteredInAppointment;

                        int.TryParse(Reader["Appointment_ID"].ToString(), out int AppointmentID);
                        PeopleRegisteredInAppointmentDTO.AppointmentID = AppointmentID;


                        Enum.TryParse(Reader["License_Category_ID"].ToString(), out enLicenseClasses LicenseClass);
                        PeopleRegisteredInAppointmentDTO.LicenseClass = LicenseClass;


                        ListOfRegisteredPeople.Add(PeopleRegisteredInAppointmentDTO);
                    }
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

            return ListOfRegisteredPeople;
        }

        public static List<clsPeopleRegisteredInAppointmentDTO> GetAllRegisteredPeopleInAppointmentTestDay(byte TestID, ref string CreatedByUser, DateTime Appointment)
        {
            List<clsPeopleRegisteredInAppointmentDTO> ListOfRegisteredPeople = new List<clsPeopleRegisteredInAppointmentDTO>();

            if (TestID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string GetAllQuery = "select * from [vPeopleRegisteredInAppointment] where [Test_ID] = @TestID and [Appointment] = @Appointment;";

                    Command = new SqlCommand(GetAllQuery, Connection);

                    Command.Parameters.AddWithValue("@TestID", TestID);
                    Command.Parameters.AddWithValue("@Appointment", Appointment.Date);

                    Connection.Open();

                    Reader = Command.ExecuteReader();


                    while (Reader.Read())
                    {
                        clsPeopleRegisteredInAppointmentDTO PeopleRegisteredInAppointmentDTO = new clsPeopleRegisteredInAppointmentDTO();

                        int.TryParse(Reader["Person_ID"].ToString(), out int PersonID);
                        PeopleRegisteredInAppointmentDTO.PersonID = PersonID;

                        int.TryParse(Reader["Order_ID"].ToString(), out int ID);
                        PeopleRegisteredInAppointmentDTO.ApplicationID = ID;

                        int.TryParse(Reader["New_Local_License_ID"].ToString(), out ID);
                        PeopleRegisteredInAppointmentDTO.LocalLicenseApplicationID = ID;

                        PeopleRegisteredInAppointmentDTO.FirstName = Reader["First_Name"] as string ?? "";
                        PeopleRegisteredInAppointmentDTO.SecondName = Reader["Second_Name"] as string ?? "";
                        PeopleRegisteredInAppointmentDTO.ThirdName = Reader["Third_Name"] as string ?? "";
                        PeopleRegisteredInAppointmentDTO.LastName = Reader["Last_Name"] as string ?? "";
                        PeopleRegisteredInAppointmentDTO.NationalNumber = Reader["National_Number"] as string ?? "";
                        CreatedByUser = Reader["AppointmentCreatedByUserName"] as string ?? "";

                        if (Reader["Notes"] == DBNull.Value)
                            PeopleRegisteredInAppointmentDTO.Notes = "";
                        else
                            PeopleRegisteredInAppointmentDTO.Notes = Reader["Notes"] as string ?? "";

                        if (Reader["Test_Result"] == DBNull.Value)
                            PeopleRegisteredInAppointmentDTO.Result = null;
                        else
                            PeopleRegisteredInAppointmentDTO.Result = (bool)Reader["Test_Result"];
                       

                        short.TryParse(Reader["NumberOfPeople"].ToString(), out short NumberOfPeopleRegisteredInAppointment);
                        PeopleRegisteredInAppointmentDTO.NumberOfPeopleRegisteredInAppointment = NumberOfPeopleRegisteredInAppointment;



                        Enum.TryParse(Reader["License_Category_ID"].ToString(), out enLicenseClasses LicenseClass);
                        PeopleRegisteredInAppointmentDTO.LicenseClass = LicenseClass;

                        ListOfRegisteredPeople.Add(PeopleRegisteredInAppointmentDTO);
                    }
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

            return ListOfRegisteredPeople;
        }

        public static List<clsPeopleRegisteredInAppointmentDTO> GetAllRegisteredPeopleInAppointmentTestDayRenewLicenseTestDay(byte TestID, ref string CreatedByUse, DateTime Appointment)
        {
            List<clsPeopleRegisteredInAppointmentDTO> ListOfRegisteredPeople = new List<clsPeopleRegisteredInAppointmentDTO>();

            if (TestID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string GetAllQuery = "select * from [vPeopleRegisteredInAppointmentRenewLicense] where [Test_ID] = @TestID and [Appointment] = @Appointment;";

                    Command = new SqlCommand(GetAllQuery, Connection);

                    Command.Parameters.AddWithValue("@TestID", TestID);
                    Command.Parameters.AddWithValue("@Appointment", Appointment.Date);

                    Connection.Open();

                    Reader = Command.ExecuteReader();

                    while (Reader.Read())
                    {
                        clsPeopleRegisteredInAppointmentDTO PeopleRegisteredInAppointmentDTO = new clsPeopleRegisteredInAppointmentDTO();

                        int.TryParse(Reader["Person_ID"].ToString(), out int PersonID);
                        PeopleRegisteredInAppointmentDTO.PersonID = PersonID;

                        int.TryParse(Reader["Order_ID"].ToString(), out int ApplicationID);
                        PeopleRegisteredInAppointmentDTO.ApplicationID = ApplicationID;

                        PeopleRegisteredInAppointmentDTO.FirstName = Reader["First_Name"] as string ?? "";
                        PeopleRegisteredInAppointmentDTO.SecondName = Reader["Second_Name"] as string ?? "";
                        PeopleRegisteredInAppointmentDTO.ThirdName = Reader["Third_Name"] as string ?? "";
                        PeopleRegisteredInAppointmentDTO.LastName = Reader["Last_Name"] as string ?? "";
                        PeopleRegisteredInAppointmentDTO.NationalNumber = Reader["National_Number"] as string ?? "";
                        CreatedByUse = Reader["AppointmentCreatedByUserName"] as string ?? "";

                        if (Reader["Notes"] == DBNull.Value)
                            PeopleRegisteredInAppointmentDTO.Notes = "";
                        else
                            PeopleRegisteredInAppointmentDTO.Notes = Reader["Notes"] as string ?? "";

                        if (Reader["Test_Result"] == DBNull.Value)
                            PeopleRegisteredInAppointmentDTO.Result = null;
                        else
                            PeopleRegisteredInAppointmentDTO.Result = (bool)Reader["Test_Result"];

                        short.TryParse(Reader["NumberOfPeople"].ToString(), out short NumberOfPeopleRegisteredInAppointment);
                        PeopleRegisteredInAppointmentDTO.NumberOfPeopleRegisteredInAppointment = NumberOfPeopleRegisteredInAppointment;


                        ListOfRegisteredPeople.Add(PeopleRegisteredInAppointmentDTO);
                    }
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

            return ListOfRegisteredPeople;
        }

        public static List<clsPeopleRegisteredInAppointmentDTO> GetAllRegisteredPeopleInAppointmentTestDayRenewLicense(byte TestID, ref string CreatedByUser)
        {
            List<clsPeopleRegisteredInAppointmentDTO> ListOfRegisteredPeople = new List<clsPeopleRegisteredInAppointmentDTO>();

            if (TestID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string GetAllQuery = @"select * from [vPeopleRegisteredInAppointmentRenewLicense] where [Test_ID] = @TestID and [Is_Completed] = 0
                                        and [Appointment] > @DateNow;";

                    Command = new SqlCommand(GetAllQuery, Connection);

                    Command.Parameters.AddWithValue("@TestID", TestID);
                    Command.Parameters.AddWithValue("@DateNow", DateTime.Now);

                    Connection.Open();

                    Reader = Command.ExecuteReader();


                    while (Reader.Read())
                    {
                        clsPeopleRegisteredInAppointmentDTO PeopleRegisteredInAppointmentDTO = new clsPeopleRegisteredInAppointmentDTO();

                        int.TryParse(Reader["Person_ID"].ToString(), out int PersonID);
                        PeopleRegisteredInAppointmentDTO.PersonID = PersonID;

                        int.TryParse(Reader["Order_ID"].ToString(), out int ApplicationID);
                        PeopleRegisteredInAppointmentDTO.ApplicationID = ApplicationID;

                        PeopleRegisteredInAppointmentDTO.FirstName = Reader["First_Name"] as string ?? "";
                        PeopleRegisteredInAppointmentDTO.SecondName = Reader["Second_Name"] as string ?? "";
                        PeopleRegisteredInAppointmentDTO.ThirdName = Reader["Third_Name"] as string ?? "";
                        PeopleRegisteredInAppointmentDTO.LastName = Reader["Last_Name"] as string ?? "";
                        PeopleRegisteredInAppointmentDTO.NationalNumber = Reader["National_Number"] as string ?? "";
                        CreatedByUser = Reader["AppointmentCreatedByUserName"] as string ?? "";

                        if (Reader["Notes"] == DBNull.Value)
                            PeopleRegisteredInAppointmentDTO.Notes = "";
                        else
                            PeopleRegisteredInAppointmentDTO.Notes = Reader["Notes"] as string ?? "";

                        if (Reader["Test_Result"] == DBNull.Value)
                            PeopleRegisteredInAppointmentDTO.Result = null;
                        else
                            PeopleRegisteredInAppointmentDTO.Result = (bool)Reader["Test_Result"];

                        DateTime.TryParse(Reader["Appointment"].ToString(), out DateTime appointment);
                        PeopleRegisteredInAppointmentDTO.Appointment = appointment;

                        short.TryParse(Reader["NumberOfPeople"].ToString(), out short NumberOfPeopleRegisteredInAppointment);
                        PeopleRegisteredInAppointmentDTO.NumberOfPeopleRegisteredInAppointment = NumberOfPeopleRegisteredInAppointment;

                        int.TryParse(Reader["Appointment_ID"].ToString(), out int AppointmentID);
                        PeopleRegisteredInAppointmentDTO.AppointmentID = AppointmentID;

                        ListOfRegisteredPeople.Add(PeopleRegisteredInAppointmentDTO);
                    }
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

            return ListOfRegisteredPeople;
        }






    }
}
