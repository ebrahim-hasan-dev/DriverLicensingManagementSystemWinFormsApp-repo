using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLMApp_DataAccessLayer
{
    public class AppointmentRepository
    {
        public static bool AddNewAppointment(clsAppointment Appointment)
        {
            bool IsAdded = false;

            if (Appointment.IsFull())
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string AddQuery = @"insert into [Tests_Appointments] ([Appointment], [Is_Completed], [CreatedBy_UserID],
                                       [Added_DateTime], [NumberOfPeople])
                                       values (@Appointment, @IsCompleted, @CreatedByUserID, default, @NumberOfPeople);
                                       select Scope_Identity();";


                    Command = new SqlCommand(AddQuery, Connection);

                    Command.Parameters.AddWithValue("@Appointment", Appointment.Appointment);
                    Command.Parameters.AddWithValue("@IsCompleted", Appointment.IsCompleted);
                    Command.Parameters.AddWithValue("@CreatedByUserID", Appointment.CreatedByUserID);
                    Command.Parameters.AddWithValue("@NumberOfPeople", Appointment.NumberOfPeople);

                    Connection.Open();

                    object objAppointmentID = Command.ExecuteScalar();

                    if (objAppointmentID != null)
                    {
                        Appointment.ID = int.Parse(objAppointmentID.ToString());
                        IsAdded = true;
                    }
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

        public static short GetNumberOfPeopleRegistered(int AppointmentID)
        {
            short NumberOfPeople = -1;

            if (AppointmentID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string AddQuery = @"select [NumberOfPeople] from [Tests_Appointments] where [Appointment_ID] = @AppointmentID;";

                    Command = new SqlCommand(AddQuery, Connection);

                    Command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

                    Connection.Open();

                    short.TryParse(Command.ExecuteScalar().ToString(), out NumberOfPeople);
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

            return NumberOfPeople;
        }

        public static bool SetAppointmentComplete(int AppointmentID)
        {
            bool IsUpdated = false;

            if (AppointmentID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string AddQuery = "update [Tests_Appointments] set [Is_Completed] = 1 where [Appointment_ID] = @AppointmentID;";

                    Command = new SqlCommand(AddQuery, Connection);

                    Command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

                    Connection.Open();

                    if (Command.ExecuteNonQuery() > 0)
                    {
                        IsUpdated = true;
                    }
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

            return IsUpdated;
        }

        public static bool IncreaseNumberOfPeople(int AppointmentID)
        {
            bool IsUpdated = false;

            if (AppointmentID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string AddQuery = "update [Tests_Appointments] set [NumberOfPeople] += 1 where [Appointment_ID] = @AppointmentID;";

                    Command = new SqlCommand(AddQuery, Connection);

                    Command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

                    Connection.Open();

                    if (Command.ExecuteNonQuery() > 0)
                    {
                        IsUpdated = true;
                    }
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

            return IsUpdated;
        }

        public static bool IsExist(clsAppointment Appointment)
        {
            bool Exist = false;

            if (Appointment.Appointment != default(DateTime))
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string GetAllQuery = "select [Tests_Appointments].*, [User_Name] from [Tests_Appointments] join [Users] on [Tests_Appointments].[CreatedBy_UserID] = [Users].[User_ID] where [Appointment] = @Appointment;";

                    Command = new SqlCommand(GetAllQuery, Connection);

                    Command.Parameters.AddWithValue("@Appointment", Appointment.Appointment.Date);

                    Connection.Open();

                    Reader = Command.ExecuteReader();

                    if (Reader.Read())
                    {
                        Appointment.NumberOfPeople = short.Parse(Reader["NumberOfPeople"].ToString());

                        Appointment.ID = int.Parse(Reader["Appointment_ID"].ToString());
                        Appointment.IsCompleted = (bool)Reader["Is_Completed"];

                        DateTime.TryParse(Reader["Appointment"].ToString(), out DateTime appointment);
                        Appointment.Appointment = appointment;

                        Appointment.CreatedByUser = Reader["User_Name"] as string ?? "";

                        Exist = true;
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

            return Exist;
        }





    }
}
