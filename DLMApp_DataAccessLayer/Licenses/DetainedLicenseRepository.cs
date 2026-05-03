using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DLMApp_DataAccessLayer
{
    public class DetainedLicenseRepository
    {
        public static bool AddDetainedLicense(int LicenseID, float Fine, string Reason, DateTime DetainedDate, int CreatedByUserID)
        {
            bool Detained = false;

            if (LicenseID > 0 && Fine > 0 && !string.IsNullOrWhiteSpace(Reason) && CreatedByUserID > 0 && DetainedDate != default(DateTime))
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string AddedQuery = @"insert into [Release_Licenses_Reservation_Order]
                                        ([Fine], [Reason], [Reservation_Date], [Paid], [Added_DateTime], [License_ID], [CreatedBy_UserID]) 
                                        values (@Fine, @Reason, @ReservationDate, 0, default, @LicenseID, @CreatedByUserID);";


                    Command = new SqlCommand(AddedQuery, Connection);

                    Command.Parameters.AddWithValue("@Fine", Fine);
                    Command.Parameters.AddWithValue("@Reason", Reason);
                    Command.Parameters.AddWithValue("@ReservationDate", DetainedDate);
                    Command.Parameters.AddWithValue("@LicenseID", LicenseID);
                    Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    Connection.Open();

                    if (Command.ExecuteNonQuery() > 0)
                    {
                        Detained = true;
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

            return Detained;
        }

        public static bool IsDetained(int LicenseID)
        {
            bool IsDetained = false;

            if (LicenseID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string AddedQuery = "select [License_ID] from [Release_Licenses_Reservation_Order] where [License_ID] = @LicenseID and [Paid] = 0";

                    Command = new SqlCommand(AddedQuery, Connection);

                    Command.Parameters.AddWithValue("@LicenseID", LicenseID);

                    Connection.Open();

                    Reader = Command.ExecuteReader();

                    if (Reader.HasRows)
                    {
                        IsDetained = true;
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

            return IsDetained;
        }

        public static clsDetainedLicenseInfo GetDetainedLicenseInfo(int LicenseID)
        {
            clsDetainedLicenseInfo DetainedLicenseInfo = null;

            if (LicenseID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string Find = @"select [Release_Licenses_Reservation_Order].*, [User_Name] from 
                                    [Release_Licenses_Reservation_Order] join [Users] on 
                                    [Release_Licenses_Reservation_Order].[CreatedBy_UserID] = [Users].[User_ID]
                                    where [License_ID] = @LicenseID and [Paid] = 0";

                    Command = new SqlCommand(Find, Connection);

                    Command.Parameters.AddWithValue("@LicenseID", LicenseID);

                    Connection.Open();

                    Reader = Command.ExecuteReader();

                    if (Reader.Read())
                    {
                        DetainedLicenseInfo = new clsDetainedLicenseInfo();

                        float.TryParse(Reader["Fine"].ToString(), out float fine);
                        DetainedLicenseInfo.Fine = fine;

                        DetainedLicenseInfo.Reasson = Reader["Reason"] as string ?? "";
                        DetainedLicenseInfo.CreatedByUser = Reader["User_Name"] as string ?? "";

                        DateTime.TryParse(Reader["Reservation_Date"].ToString(), out DateTime DetainedDate);
                        DetainedLicenseInfo.DetainedDate = DetainedDate;
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

            return DetainedLicenseInfo;
        }

        public static bool ReleaseDetainedLicense(int LicenseID, int ReleasedByUserID, int ApplicationID)
        {
            bool Released = false;

            if (LicenseID > 0 && ReleasedByUserID > 0 && ApplicationID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string Update = @"update [Release_Licenses_Reservation_Order] set [Paid] = 1, [Payment_Date] = @DateNow,
                                    [ReleasedBy_UserID] = @ReleasedByUserID, [Order_ID] = @OrderID
                                    where [License_ID] = @LicenseID and [Paid] = 0";

                    Command = new SqlCommand(Update, Connection);

                    Command.Parameters.AddWithValue("@LicenseID", LicenseID);
                    Command.Parameters.AddWithValue("@DateNow", DateTime.Now);
                    Command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
                    Command.Parameters.AddWithValue("@OrderID", ApplicationID);

                    Connection.Open();

                    if (Command.ExecuteNonQuery() > 0)
                    {
                        Released = true;
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

            return Released;
        }



    }
}
