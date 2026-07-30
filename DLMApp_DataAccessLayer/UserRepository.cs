using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;


namespace DLMApp_DataAccessLayer
{
    public class UserRepository
    {
        static public async Task<clsUser> Find(string UserName)
        {
            clsUser User = null;

            if (!string.IsNullOrWhiteSpace(UserName))
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string FindQuery = "select * from [Users] where [User_Name] = @UserName;";

                    Command = new SqlCommand(FindQuery, Connection);

                    Command.Parameters.Add("@UserName", System.Data.SqlDbType.NVarChar).Value = UserName;

                    //Command.Parameters.AddWithValue("@UserName", UserName);

                    await Connection.OpenAsync();

                    Reader = await Command.ExecuteReaderAsync();

                    if (await Reader.ReadAsync())
                    {
                        User = new clsUser();

                        int.TryParse(Reader["User_ID"].ToString(), out int ID);
                        User.UserID = ID;

                        int.TryParse(Reader["Person_ID"].ToString(), out ID);
                        User.PersonID = ID;

                        User.IsActive = (bool)Reader["Is_Active"];

                        User.UserName = Reader["User_Name"] as string ?? "";
                        User.Password = Reader["Password"] as string ?? "";
                    }
                }
                catch (Exception ex)
                {
                    clsEventLog.WriteToEventLog(ex.Message, enLogType.Error);
                    User = null;
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

            return User;
        }

        static public async Task<List<clsUser>> GetAllUsers()
        {
            List<clsUser> ListOfUsers = new List<clsUser>();

            SqlConnection Connection = null;
            SqlCommand Command = null;
            SqlDataReader Reader = null;

            try
            {
                Connection = new SqlConnection(clsConnectionString.ConnectionString);

                string FindQuery = "select * from [Users];";

                Command = new SqlCommand(FindQuery, Connection);

                await Connection.OpenAsync();

                Reader = await Command.ExecuteReaderAsync();

                while (await Reader.ReadAsync())
                {
                    clsUser User = new clsUser();

                    int.TryParse(Reader["User_ID"].ToString(), out int ID);
                    User.UserID = ID;

                    int.TryParse(Reader["Person_ID"].ToString(), out ID);
                    User.PersonID = ID;

                    User.IsActive = (bool)Reader["Is_Active"];

                    User.UserName = Reader["User_Name"] as string ?? "";
                    //User.Password = Reader["Password"] as string ?? "";

                    ListOfUsers.Add(User);
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

            return ListOfUsers;
        }

        public static async Task<bool> UpdateActiveUser(int UserID, bool Active)
        {
            bool Updated = false;

            if (UserID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string Update = "update [Users] set [Is_Active] = @Active where [User_ID] = @UserID";

                    Command = new SqlCommand(Update, Connection);

                    Command.Parameters.AddWithValue("@UserID", UserID);

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

        public static async Task<bool> ChangePassword(int UserID, string NewPassword)
        {
            bool Updated = false;

            if (UserID > 0 && !string.IsNullOrWhiteSpace(NewPassword))
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string Update = "update [Users] set [Password] = @NewPassword where [User_ID] = @UserID";

                    Command = new SqlCommand(Update, Connection);

                    Command.Parameters.AddWithValue("@UserID", UserID);
                    Command.Parameters.AddWithValue("@NewPassword", NewPassword);

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

        public static async Task<bool> AddNewUser(clsUser User)
        {
            bool Added = false;

            if (User.IsFull())
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string Add = @"insert into [Users] ([User_Name], [Password], [Is_Active], [Person_ID]) values (@UserName, @Password, @IsActive, @PersonID);
                                   Select Scope_Identity()";

                    Command = new SqlCommand(Add, Connection);

                    Command.Parameters.AddWithValue("@UserName", User.UserName);
                    Command.Parameters.AddWithValue("@Password", User.Password);


                    if (User.IsActive)
                        Command.Parameters.AddWithValue("@IsActive", 1);
                    else
                        Command.Parameters.AddWithValue("@IsActive", 0);


                    Command.Parameters.AddWithValue("@PersonID", User.PersonID);

                    await Connection.OpenAsync();

                    object UserIDobj = await Command.ExecuteScalarAsync();

                    if (UserIDobj != null)
                    {
                        User.UserID = int.Parse(UserIDobj.ToString());
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

        public static async Task<bool> UserNameExist(string UserName)
        {
            bool Exist = false;

            if (!string.IsNullOrWhiteSpace(UserName))
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string GetAllQuery = "select [User_ID] from [Users] where [User_Name] = @UserName;";

                    Command = new SqlCommand(GetAllQuery, Connection);

                    Command.Parameters.AddWithValue("@UserName", UserName);

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

        static public async Task<clsUser> FindWithoutPass(string UserName)
        {
            clsUser User = null;

            if (!string.IsNullOrWhiteSpace(UserName))
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string FindQuery = "select * from [Users] where [User_Name] = @UserName;";

                    Command = new SqlCommand(FindQuery, Connection);

                    Command.Parameters.Add("@UserName", System.Data.SqlDbType.NVarChar).Value = UserName;

                    //Command.Parameters.AddWithValue("@UserName", UserName);

                    await Connection.OpenAsync();

                    Reader = await Command.ExecuteReaderAsync();

                    if (await Reader.ReadAsync())
                    {
                        User = new clsUser();

                        int.TryParse(Reader["User_ID"].ToString(), out int ID);
                        User.UserID = ID;

                        int.TryParse(Reader["Person_ID"].ToString(), out ID);
                        User.PersonID = ID;

                        User.IsActive = (bool)Reader["Is_Active"];

                        User.UserName = Reader["User_Name"] as string ?? "";
                        //User.Password = Reader["Password"] as string ?? "";
                    }
                }
                catch (Exception ex)
                {
                    clsEventLog.WriteToEventLog(ex.Message, enLogType.Error);
                    User = null;
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

            return User;
        }

        static public async Task<clsUser> Find(int UserID)
        {
            clsUser User = null;

            if (UserID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string FindQuery = "select * from [Users] where [User_ID] = @UserID;";

                    Command = new SqlCommand(FindQuery, Connection);

                    Command.Parameters.AddWithValue("@UserID", UserID);

                    await Connection.OpenAsync();

                    Reader = await Command.ExecuteReaderAsync();

                    if (await Reader.ReadAsync())
                    {
                        User = new clsUser();

                        int.TryParse(Reader["User_ID"].ToString(), out int ID);
                        User.UserID = ID;

                        int.TryParse(Reader["Person_ID"].ToString(), out ID);
                        User.PersonID = ID;

                        User.IsActive = (bool)Reader["Is_Active"];

                        User.UserName = Reader["User_Name"] as string ?? "";
                        User.Password = Reader["Password"] as string ?? "";
                    }
                }
                catch (Exception ex)
                {
                    clsEventLog.WriteToEventLog(ex.Message, enLogType.Error);
                    User = null;
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

            return User;
        }

        static public async Task<clsUser> FindByNationalNumber(string NationalNumber)
        {
            clsUser User = null;

            if (!string.IsNullOrWhiteSpace(NationalNumber))
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string FindQuery = @"select [Users].*, [National_Number] from
                                       [Users] join [People] on [Users].[Person_ID] = [People].[Person_ID] where [National_Number] = @NationalNumber;";

                    Command = new SqlCommand(FindQuery, Connection);

                    Command.Parameters.AddWithValue("@NationalNumber", NationalNumber);

                    await Connection.OpenAsync();

                    Reader = await Command.ExecuteReaderAsync();

                    if (await Reader.ReadAsync())
                    {
                        User = new clsUser();

                        int.TryParse(Reader["User_ID"].ToString(), out int ID);
                        User.UserID = ID;

                        int.TryParse(Reader["Person_ID"].ToString(), out ID);
                        User.PersonID = ID;

                        User.IsActive = (bool)Reader["Is_Active"];

                        User.UserName = Reader["User_Name"] as string ?? "";
                        //User.Password = Reader["Password"] as string ?? "";
                    }
                }
                catch (Exception ex)
                {
                    clsEventLog.WriteToEventLog(ex.Message, enLogType.Error);
                    User = null;
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

            return User;
        }

        static public async Task<bool> PersonIDExist(int PersonID)
        {
            bool Exist = false;

            if (PersonID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string FindQuery = "select [User_ID] from [Users] where [Person_ID] = @PersonID;";

                    Command = new SqlCommand(FindQuery, Connection);

                    Command.Parameters.AddWithValue("@PersonID", PersonID);

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
