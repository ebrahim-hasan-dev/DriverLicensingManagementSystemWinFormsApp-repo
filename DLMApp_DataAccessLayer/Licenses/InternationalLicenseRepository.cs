using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLMApp_DataAccessLayer
{
    public class InternationalLicenseRepository
    {
        public static bool AddNewInternationalLicense(clsInternationalLicense InternationalLicense)
        {
            bool Added = false;

            if (InternationalLicense.IsFull())
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string Insert = @"insert into [International_Licenses] 
                                    ([Release_Date], [End_Date], [Is_Active], [Order_ID], [Local_License_ID], [Driver_ID], [CreatedBy_UserID]) 
                                    values (@ReleaseDate, @EndDate, 1, @OrderID, @LocalLicenseID, @DriverID, @CreatedByUserID);
                                     select Scope_Identity();";

                    Command = new SqlCommand(Insert, Connection);
                  

                    Command.Parameters.AddWithValue("@ReleaseDate", InternationalLicense.ReleaseDate);
                    Command.Parameters.AddWithValue("@EndDate", InternationalLicense.EndDate);
                    Command.Parameters.AddWithValue("@OrderID", InternationalLicense.ApplicationID);
                    Command.Parameters.AddWithValue("@LocalLicenseID", InternationalLicense.LocalLicenseID);
                    Command.Parameters.AddWithValue("@DriverID", InternationalLicense.DriverID);
                    Command.Parameters.AddWithValue("@CreatedByUserID", InternationalLicense.CreatedByUserID);

                    Connection.Open();

                    object InternationalLicenseobj = Command.ExecuteScalar();

                    if (InternationalLicenseobj != null)
                    {
                        InternationalLicense.InternationalLicenseID = int.Parse(InternationalLicenseobj.ToString());
                        Added = true;
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

            return Added;
        }

        public static bool UpdateInternationalLicneseToInactive(int DriverID)
        {
            bool Update = false;

            if (DriverID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string Find = "update [International_Licenses] set [Is_Active] = 0 where [Driver_ID] = @DriverID and [Is_Active] = 1;";

                    Command = new SqlCommand(Find, Connection);

                    Command.Parameters.AddWithValue("@DriverID", DriverID);
                    Command.Parameters.AddWithValue("@DateNow", DateTime.Now);

                    Connection.Open();

                    if (Command.ExecuteNonQuery() > 0)
                    {
                        Update = true;
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

            return Update;
        }

        public static List<clsInternationalLicense> GetInternationalLicnesesForDriver(int DriverID)
        {
            List <clsInternationalLicense> ListOfclsInternationalLicenses = new List<clsInternationalLicense>();

            if (DriverID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string Find = @"select [International_Licenses].*, [User_Name] from [International_Licenses] join [Users]
                                    on [International_Licenses].[CreatedBy_UserID] = [Users].[User_ID] where [Driver_ID] = @DriverID;";


                    Command = new SqlCommand(Find, Connection);

                    Command.Parameters.AddWithValue("@DriverID", DriverID);

                    Connection.Open();

                    Reader = Command.ExecuteReader();

                    while (Reader.Read())
                    {
                       clsInternationalLicense internationalLicense = new clsInternationalLicense();

                        int var;

                        int.TryParse(Reader["International_License_ID"].ToString(), out var);
                        internationalLicense.InternationalLicenseID = var;

                        int.TryParse(Reader["Order_ID"].ToString(), out var);
                        internationalLicense.ApplicationID = var;

                        internationalLicense.DriverID = DriverID;
                        internationalLicense.IsActive = (bool)Reader["Is_Active"];
                        internationalLicense.CreatedByUser = Reader["User_Name"] as string ?? "";

                        int.TryParse(Reader["Local_License_ID"].ToString(), out var);
                        internationalLicense.LocalLicenseID = var;

                        DateTime.TryParse(Reader["Release_Date"].ToString(), out DateTime Date);
                        internationalLicense.ReleaseDate = Date;

                        DateTime.TryParse(Reader["End_Date"].ToString(), out Date);
                        internationalLicense.EndDate = Date;

                        ListOfclsInternationalLicenses.Add(internationalLicense);
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

            return ListOfclsInternationalLicenses;
        }




    }
}
