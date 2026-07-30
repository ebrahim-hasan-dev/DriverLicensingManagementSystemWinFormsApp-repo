using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;


namespace DLMApp_DataAccessLayer
{
    public class LicenseRepository
    {
        // =====================================================================================

        public static async Task<List<clsLicenseClass>> GetAllLicensesClasses()
        {
            List<clsLicenseClass> ListOfLicensesClasses = new List<clsLicenseClass>();

            SqlConnection Connection = null;
            SqlCommand Command = null;
            SqlDataReader Reader = null;

            try
            {
                Connection = new SqlConnection(clsConnectionString.ConnectionString);

                string GetAllQuery = "select * from [License_Categories];";

                Command = new SqlCommand(GetAllQuery, Connection);

                await Connection.OpenAsync();

                Reader = await Command.ExecuteReaderAsync();

                while (await Reader.ReadAsync())
                {
                    clsLicenseClass LicenseClass = new clsLicenseClass();

                    byte.TryParse(Reader["License_Category_ID"].ToString(), out byte ID);
                    LicenseClass.ID = ID;

                    LicenseClass.LicenseClass = Reader["Category_Name"] as string ?? "";
                    LicenseClass.Description = Reader["Category_Description"] as string ?? "";

                    byte.TryParse(Reader["Minimum_Allowed_Age"].ToString(), out byte Age);
                    LicenseClass.MinimumAllowedAge = Age;

                    float.TryParse(Reader["Fees"].ToString(), out float Fees);
                    LicenseClass.Fees = Fees;

                    byte.TryParse(Reader["License_Validity_Period"].ToString(), out byte ValidityPeriod);
                    LicenseClass.ValidityPeriod = ValidityPeriod;

                    ListOfLicensesClasses.Add(LicenseClass);
                }
            }
            catch (Exception ex)
            {
                clsEventLog.WriteToEventLog(ex.Message, enLogType.Error);
                ListOfLicensesClasses.Clear();
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

            return ListOfLicensesClasses;
        }

        public static async Task<(clsLicenseClass, int)> GetLicenseClass(int ApplicationID)
        {
            clsLicenseClass LicenseClass = null;
            int PersonID = 0;

            if (ApplicationID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string GetQuery = $"select * from [vGetLicenseClassInfoByApplicationID] where [Order_ID] = @ApplicationID and [Order_Status_ID] = {(byte)enApplicationStatus.New};";

                    Command = new SqlCommand(GetQuery, Connection);

                    Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                    await Connection.OpenAsync();

                    Reader = await Command.ExecuteReaderAsync();

                    if (await Reader.ReadAsync())
                    {
                        LicenseClass = new clsLicenseClass();

                        byte.TryParse(Reader["License_Category_ID"].ToString(), out byte ID);
                        LicenseClass.ID = ID;

                        int.TryParse(Reader["Person_ID"].ToString(), out int Id);
                        PersonID = Id;

                        LicenseClass.LicenseClass = Reader["Category_Name"] as string ?? "";
                        LicenseClass.Description = Reader["Category_Description"] as string ?? "";

                        byte.TryParse(Reader["Minimum_Allowed_Age"].ToString(), out byte Age);
                        LicenseClass.MinimumAllowedAge = Age;

                        float.TryParse(Reader["Fees"].ToString(), out float Fees);
                        LicenseClass.Fees = Fees;

                        byte.TryParse(Reader["License_Validity_Period"].ToString(), out byte ValidityPeriod);
                        LicenseClass.ValidityPeriod = ValidityPeriod;
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

            return (LicenseClass, PersonID);
        }

        public static async Task<clsLicenseClass> GetLicenseClass(byte LicenseClassID)
        {
            clsLicenseClass LicenseClass = null;

            if (LicenseClassID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string GetQuery = "select * from [License_Categories] where [License_Category_ID] = @LicenseClassID;";

                    Command = new SqlCommand(GetQuery, Connection);

                    Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                    await Connection.OpenAsync();

                    Reader = await Command.ExecuteReaderAsync();

                    if (await Reader.ReadAsync())
                    {
                        LicenseClass = new clsLicenseClass();

                        LicenseClass.ID = LicenseClassID;

                        LicenseClass.LicenseClass = Reader["Category_Name"] as string ?? "";
                        LicenseClass.Description = Reader["Category_Description"] as string ?? "";

                        byte.TryParse(Reader["Minimum_Allowed_Age"].ToString(), out byte Age);
                        LicenseClass.MinimumAllowedAge = Age;

                        float.TryParse(Reader["Fees"].ToString(), out float Fees);
                        LicenseClass.Fees = Fees;

                        byte.TryParse(Reader["License_Validity_Period"].ToString(), out byte ValidityPeriod);
                        LicenseClass.ValidityPeriod = ValidityPeriod;
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

            return LicenseClass;
        }

        public static async Task<bool> UpdateLicenseClass(byte LicenseClassID, float LicenseFees, byte ValidityPeriod, byte MinimumAllowedAge)
        {
            bool Update = false;

            SqlConnection Connection = null;
            SqlCommand Command = null;

            if (LicenseClassID > 0 && LicenseFees > 0 && ValidityPeriod > 0 && MinimumAllowedAge > 0)
            {
                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string UpdateQuery = @"update [License_Categories] set [Fees] = @LicenseFees, [License_Validity_Period] = @ValidityPeriod,
                                           [Minimum_Allowed_Age] = @MinimumAllowedAge where [License_Category_ID] = @LicenseClassID;";

                    Command = new SqlCommand(UpdateQuery, Connection);

                    Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
                    Command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
                    Command.Parameters.AddWithValue("@ValidityPeriod", ValidityPeriod);
                    Command.Parameters.AddWithValue("@LicenseFees", LicenseFees);

                    await Connection.OpenAsync();

                    if (await Command.ExecuteNonQueryAsync() > 0)
                    {
                        Update = true;
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

            return Update;
        }

        // =====================================================================================

        public static async Task<bool> DoesHaveLicenseOfSameClass(int PersonID, byte LicenseClassID)
        {
            bool IsHave = false;

            if (PersonID > 0 && LicenseClassID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string Find = "select * from [vDoesHaveLicenseOfSameClass] where [Person_ID] = @PersonID and [License_Category_ID] = @LicenseClassID;";

                    Command = new SqlCommand(Find, Connection);

                    Command.Parameters.AddWithValue("@PersonID", PersonID);
                    Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                    await Connection.OpenAsync();

                    Reader = await Command.ExecuteReaderAsync();

                    if (Reader.HasRows)
                    {
                        IsHave = true;
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

            return IsHave;
        }

        public static async Task<bool> AddNewLicense(clsLicense license)
        {
            bool Added = false;

            if (license.IsFull())
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string Find = @"insert into [Licenses] ([License_Conditions], [Image_Path], [Release_Date], [End_Date], [Is_Active],
                                    [License_Fees], [Driver_ID], [License_Status_ID], [CreatedBy_UserID], [Order_ID], [License_Category_ID], [Is_Detained]) 
                                   values (@LicenseNotes, @ImagePath, @ReleaseDate, @EndDate, 1, @LicenseFees, @DriverID, @LicenseStatusID,
                                            @CreatedByUserID ,@OrderID, @LicenseCategoryID, 0);
                                             select Scope_Identity();";

                    Command = new SqlCommand(Find, Connection);

                    if (string.IsNullOrWhiteSpace(license.Notes))
                        Command.Parameters.AddWithValue("@LicenseNotes", DBNull.Value);
                    else
                        Command.Parameters.AddWithValue("@LicenseNotes", license.Notes);

                    Command.Parameters.AddWithValue("@ImagePath", license.ImagePath);
                    Command.Parameters.AddWithValue("@ReleaseDate", license.ReleaseDate);
                    Command.Parameters.AddWithValue("@EndDate", license.EndDate);
                    Command.Parameters.AddWithValue("@LicenseFees", license.LicenseFees);
                    Command.Parameters.AddWithValue("@DriverID", license.DriverID);
                    Command.Parameters.AddWithValue("@LicenseStatusID", (byte)license.LicenseStatusID);
                    Command.Parameters.AddWithValue("@CreatedByUserID", license.CreatedByUserID);
                    Command.Parameters.AddWithValue("@OrderID", license.ApplicationID);
                    Command.Parameters.AddWithValue("@LicenseCategoryID", license.LicenseClassID);

                    await Connection.OpenAsync();

                    object LicenseIDobj = await Command.ExecuteScalarAsync();

                    if (LicenseIDobj != null)
                    {
                        license.ID = int.Parse(LicenseIDobj.ToString());
                        Added = true;
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

        public static async Task<clsLicense> Find(int LicenseID)
        {
            clsLicense license = null;

            if (LicenseID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string Find = @"select [Licenses].*, [Category_Name] from [Licenses] join [License_Categories] 
                                   on [Licenses].[License_Category_ID] = [License_Categories].[License_Category_ID] where [License_ID] = @LicenseID";

                    Command = new SqlCommand(Find, Connection);

                    Command.Parameters.AddWithValue("@LicenseID", LicenseID);

                    await Connection.OpenAsync();

                    Reader = await Command.ExecuteReaderAsync();

                    if (await Reader.ReadAsync())
                    {
                        license = new clsLicense();

                        int.TryParse(Reader["License_ID"].ToString(), out int ID);
                        license.ID = ID;

                        DateTime.TryParse(Reader["Release_Date"].ToString(), out DateTime Date);
                        license.ReleaseDate = Date;

                        DateTime.TryParse(Reader["End_Date"].ToString(), out Date);
                        license.EndDate = Date;

                        int.TryParse(Reader["Driver_ID"].ToString(), out int DriverID);
                        license.DriverID = DriverID;

                        license.ImagePath = Reader["Image_Path"] as string ?? "";
                        license.Notes = Reader["License_Conditions"] as string ?? "";
                        license.LicenseClass = Reader["Category_Name"] as string ?? "";

                        int.TryParse(Reader["Order_ID"].ToString(), out int OrderID);
                        license.ApplicationID = OrderID;

                        int.TryParse(Reader["CreatedBy_UserID"].ToString(), out int UserID);
                        license.CreatedByUserID = UserID;

                        license.IsActive = (bool)Reader["Is_Active"];
                        license.IsDetained = (bool)Reader["Is_Detained"];

                        float.TryParse(Reader["License_Fees"].ToString(), out float LicenseFees);
                        license.LicenseFees = LicenseFees;

                        byte.TryParse(Reader["License_Category_ID"].ToString(), out byte LicenseCategoryID);
                        license.LicenseClassID = LicenseCategoryID;

                        byte.TryParse(Reader["License_Status_ID"].ToString(), out byte LicenseStatusID);
                        license.LicenseStatusID = (enLicenseStatus)LicenseStatusID;
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

            return license;
        }

        public static async Task<bool> UpdateActiveLicense(int LicenseID, bool Active)
        {
            bool Updated = false;

            if (LicenseID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string Update = "update [Licenses] set [Is_Active] = @Active where [License_ID] = @LicenseID";

                    Command = new SqlCommand(Update, Connection);
                  
                    Command.Parameters.AddWithValue("@LicenseID", LicenseID);

                    if (Active)
                        Command.Parameters.AddWithValue("@Active", 1);
                    else
                        Command.Parameters.AddWithValue("@Active", 0);


                    await Connection.OpenAsync();

                    if (await Command.ExecuteNonQueryAsync() > 0)
                    {
                        Updated = true;
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

            return Updated;
        }

        public static async Task<clsLicense> FindActiveAndValidLicense(int PersonID, byte LicenseClassID)
        {
            clsLicense license = null;

            if (PersonID > 0 && LicenseClassID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string Find = "select * from [vDoesHaveLicenseOfSameClass] where [Person_ID] = @PersonID and [License_Category_ID] = @LicenseClassID and [Is_Active] = 1 and [End_Date] > @DateNow;";

                    Command = new SqlCommand(Find, Connection);

                    Command.Parameters.AddWithValue("@PersonID", PersonID);
                    Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
                    Command.Parameters.AddWithValue("@DateNow", DateTime.Now.Date);

                    await Connection.OpenAsync();

                    Reader = await Command.ExecuteReaderAsync();

                    if (await Reader.ReadAsync())
                    {
                        license = new clsLicense();

                        int.TryParse(Reader["License_ID"].ToString(), out int ID);
                        license.ID = ID;

                        DateTime.TryParse(Reader["Release_Date"].ToString(), out DateTime Date);
                        license.ReleaseDate = Date;

                        DateTime.TryParse(Reader["End_Date"].ToString(), out Date);
                        license.EndDate = Date;

                        int.TryParse(Reader["Driver_ID"].ToString(), out int DriverID);
                        license.DriverID = DriverID;

                        license.ImagePath = Reader["Image_Path"] as string ?? "";
                        license.Notes = Reader["License_Conditions"] as string ?? "";

                        int.TryParse(Reader["Order_ID"].ToString(), out int OrderID);
                        license.ApplicationID = OrderID;

                        int.TryParse(Reader["CreatedBy_UserID"].ToString(), out int UserID);
                        license.CreatedByUserID = UserID;

                        license.IsActive = (bool)Reader["Is_Active"];
                        license.IsDetained = (bool)Reader["Is_Detained"];

                        float.TryParse(Reader["License_Fees"].ToString(), out float LicenseFees);
                        license.LicenseFees = LicenseFees;

                        byte.TryParse(Reader["License_Category_ID"].ToString(), out byte LicenseCategoryID);
                        license.LicenseClassID = LicenseCategoryID;

                        byte.TryParse(Reader["License_Status_ID"].ToString(), out byte LicenseStatusID);
                        license.LicenseStatusID = (enLicenseStatus)LicenseStatusID;
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

            return license;
        }

        public static async Task<bool> UpdateDetainedLicense(int LicenseID, bool Detained)
        {
            bool Updated = false;

            if (LicenseID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string Update = "update [Licenses] set [Is_Detained] = @Detained where [License_ID] = @LicenseID";

                    Command = new SqlCommand(Update, Connection);

                    Command.Parameters.AddWithValue("@LicenseID", LicenseID);

                    if (Detained)
                        Command.Parameters.AddWithValue("@Detained", 1);
                    else
                        Command.Parameters.AddWithValue("@Detained", 0);


                    await Connection.OpenAsync();

                    if (await Command.ExecuteNonQueryAsync() > 0)
                    {
                        Updated = true;
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

            return Updated;
        }

        public static async Task<List<clsLicense>> GetAllLicenses()
        {
            List<clsLicense> ListOfLicenses = new List<clsLicense>();

            SqlConnection Connection = null;
            SqlCommand Command = null;
            SqlDataReader Reader = null;

            try
            {
                Connection = new SqlConnection(clsConnectionString.ConnectionString);

                string GetAll = "select * from [vLicensesInfo];";

                Command = new SqlCommand(GetAll, Connection);

                await Connection.OpenAsync();

                Reader = await Command.ExecuteReaderAsync();

                while (await Reader.ReadAsync())
                {
                    clsLicense license = new clsLicense();

                    int var;

                    int.TryParse(Reader["License_ID"].ToString(), out var);
                    license.ID = var;

                    DateTime.TryParse(Reader["Release_Date"].ToString(), out DateTime Date);
                    license.ReleaseDate = Date;

                    DateTime.TryParse(Reader["End_Date"].ToString(), out Date);
                    license.EndDate = Date;

                    int.TryParse(Reader["Driver_ID"].ToString(), out var);
                    license.DriverID = var;

                    license.Notes = Reader["License_Conditions"] as string ?? "";
                    license.LicenseClass = Reader["Category_Name"] as string ?? "";
                    license.CreatedByUser = Reader["User_Name"] as string ?? "";

                    int.TryParse(Reader["Order_ID"].ToString(), out var);
                    license.ApplicationID = var;

                    license.IsActive = (bool)Reader["Is_Active"];
                    license.IsDetained = (bool)Reader["Is_Detained"];

                    float.TryParse(Reader["License_Fees"].ToString(), out float LicenseFees);
                    license.LicenseFees = LicenseFees;

                    byte.TryParse(Reader["License_Status_ID"].ToString(), out byte LicenseStatusID);
                    license.LicenseStatusID = (enLicenseStatus)LicenseStatusID;

                    ListOfLicenses.Add(license);
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
           
            return ListOfLicenses;
        }

        public static async Task<List<clsLicense>> FindAllByDriverID(int DriverID)
        {
            List<clsLicense> ListOfLicenses = new List<clsLicense>();

            if (DriverID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string GetAll = "select * from [vLicensesInfo] where [Driver_ID] = @DriverID;";

                    Command = new SqlCommand(GetAll, Connection);

                    Command.Parameters.AddWithValue("@DriverID", DriverID);

                    await Connection.OpenAsync();

                    Reader = await Command.ExecuteReaderAsync();

                    while (await Reader.ReadAsync())
                    {
                        clsLicense license = new clsLicense();

                        int var;

                        int.TryParse(Reader["License_ID"].ToString(), out var);
                        license.ID = var;

                        DateTime.TryParse(Reader["Release_Date"].ToString(), out DateTime Date);
                        license.ReleaseDate = Date;

                        DateTime.TryParse(Reader["End_Date"].ToString(), out Date);
                        license.EndDate = Date;

                        int.TryParse(Reader["Driver_ID"].ToString(), out var);
                        license.DriverID = var;

                        license.Notes = Reader["License_Conditions"] as string ?? "";
                        license.LicenseClass = Reader["Category_Name"] as string ?? "";
                        license.CreatedByUser = Reader["User_Name"] as string ?? "";

                        int.TryParse(Reader["Order_ID"].ToString(), out var);
                        license.ApplicationID = var;

                        license.IsActive = (bool)Reader["Is_Active"];
                        license.IsDetained = (bool)Reader["Is_Detained"];

                        float.TryParse(Reader["License_Fees"].ToString(), out float LicenseFees);
                        license.LicenseFees = LicenseFees;

                        byte.TryParse(Reader["License_Status_ID"].ToString(), out byte LicenseStatusID);
                        license.LicenseStatusID = (enLicenseStatus)LicenseStatusID;

                        ListOfLicenses.Add(license);
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

            return ListOfLicenses;
        }

        public static async Task<List<clsLicense>> FindAllByNationalNumber(string NationalNumber)
        {
            List<clsLicense> ListOfLicenses = new List<clsLicense>();

            if (!string.IsNullOrWhiteSpace(NationalNumber))
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string GetAll = "select * from [vLicensesInfo] where [National_Number] = @NationalNumber;";

                    Command = new SqlCommand(GetAll, Connection);

                    Command.Parameters.AddWithValue("@NationalNumber", NationalNumber);

                    await Connection.OpenAsync();

                    Reader = await Command.ExecuteReaderAsync();

                    while (await Reader.ReadAsync())
                    {
                        clsLicense license = new clsLicense();

                        int var;

                        int.TryParse(Reader["License_ID"].ToString(), out var);
                        license.ID = var;

                        DateTime.TryParse(Reader["Release_Date"].ToString(), out DateTime Date);
                        license.ReleaseDate = Date;

                        DateTime.TryParse(Reader["End_Date"].ToString(), out Date);
                        license.EndDate = Date;

                        int.TryParse(Reader["Driver_ID"].ToString(), out var);
                        license.DriverID = var;

                        license.Notes = Reader["License_Conditions"] as string ?? "";
                        license.LicenseClass = Reader["Category_Name"] as string ?? "";
                        license.CreatedByUser = Reader["User_Name"] as string ?? "";

                        int.TryParse(Reader["Order_ID"].ToString(), out var);
                        license.ApplicationID = var;

                        license.IsActive = (bool)Reader["Is_Active"];
                        license.IsDetained = (bool)Reader["Is_Detained"];

                        float.TryParse(Reader["License_Fees"].ToString(), out float LicenseFees);
                        license.LicenseFees = LicenseFees;

                        byte.TryParse(Reader["License_Status_ID"].ToString(), out byte LicenseStatusID);
                        license.LicenseStatusID = (enLicenseStatus)LicenseStatusID;

                        ListOfLicenses.Add(license);
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

            return ListOfLicenses;
        }



    }
}
