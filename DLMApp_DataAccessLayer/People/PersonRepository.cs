using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace DLMApp_DataAccessLayer
{
    public class PersonRepository
    {
        static bool AddPersonPhones(string Phone1, string Phone2, int PersonID, SqlConnection Connection, SqlCommand Command)
        {
            bool IsAdded = false;

            string AddedQuery = "";

            if (!string.IsNullOrWhiteSpace(Phone1))
            {
                AddedQuery = "insert into [Phones] ([Phone_Number], [Person_ID]) values (@PhoneNumber1, @PersonID);";
            }

            if (!string.IsNullOrWhiteSpace(Phone2))
            {
                AddedQuery += "insert into [Phones] ([Phone_Number], [Person_ID]) values (@PhoneNumber2, @PersonID);";
            }

            Command = new SqlCommand(AddedQuery, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            if (!string.IsNullOrWhiteSpace(Phone1))
            {
                Command.Parameters.AddWithValue("@PhoneNumber1", Phone1);
            }

            if (!string.IsNullOrWhiteSpace(Phone2))
            {
                Command.Parameters.AddWithValue("@PhoneNumber2", Phone2);
            }

            byte NumberOfRowsAffected = (byte)Command.ExecuteNonQuery();

            if (NumberOfRowsAffected > 0)
            {
                IsAdded = true;
            }

            return IsAdded;
        }

        public static bool AddNewPerson(clsPerson Person)
        {
            bool IsAdded = false;

            if (Person.IsFull())
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string AddQuery = @"insert into [People] ([First_Name], [Second_Name], [Third_Name], [Last_Name],
                                       [Image_Path], [DateOfBirth], [Address], [Email], [National_Number],
                                       [Added_DateTime], [Gender], [Nationality_Country_ID], [CreatedBy_UserID])
                                        values (@FirstName, @SecondName, @ThirdName, @LastName, @ImagePath, 
                                                @DateOfBirth, @Address, @Email, @NationalNumber, 
                                                default, @Gender, @CountryID, @CreatedByUserID);
                                                 select Scope_Identity();";


                    Command = new SqlCommand(AddQuery, Connection);

                    Command.Parameters.AddWithValue("@FirstName", Person.FirstName);
                    Command.Parameters.AddWithValue("@SecondName", Person.SecondName);
                    Command.Parameters.AddWithValue("@ThirdName", Person.ThirdName);
                    Command.Parameters.AddWithValue("@LastName", Person.LastName);
                    Command.Parameters.AddWithValue("@ImagePath", Person.ImagePath);
                    Command.Parameters.AddWithValue("@DateOfBirth", Person.DateOfBirth);
                    Command.Parameters.AddWithValue("@Address", Person.Address);
                    Command.Parameters.AddWithValue("@NationalNumber", Person.NationalNumber);
                    Command.Parameters.AddWithValue("@Gender", Person.Gender);
                    Command.Parameters.AddWithValue("@CountryID", Person.NationalityCountryID);
                    Command.Parameters.AddWithValue("@CreatedByUserID", Person.CreatedByUserID);

                    if (string.IsNullOrWhiteSpace(Person.Email))
                    {
                        Command.Parameters.AddWithValue("@Email", DBNull.Value);
                    }
                    else
                    {
                        Command.Parameters.AddWithValue("@Email", Person.Email);
                    }

                    Connection.Open();

                    object objPersonID = Command.ExecuteScalar();

                    if (objPersonID != null)
                    {
                        Command.Dispose();

                        Person.PersonID = int.Parse(objPersonID.ToString());

                        if (AddPersonPhones(Person.Phone1, Person.Phone2, Person.PersonID, Connection, Command))
                        {
                            IsAdded = true;
                        }
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

        public static bool NationalNubmerExist(string NationalNumber)
        {
            bool Exist = false;

            if (!string.IsNullOrWhiteSpace(NationalNumber))
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string GetAllQuery = "select [Person_ID] from [People] where [National_Number] = @NationalNumber;";

                    Command = new SqlCommand(GetAllQuery, Connection);

                    Command.Parameters.AddWithValue("@NationalNumber", NationalNumber);

                    Connection.Open();

                    Reader = Command.ExecuteReader();

                    if (Reader.HasRows)
                    {
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

        public static bool PhoneNumberExist(string PhoneNumber)
        {
            bool Exist = false;

            if (!string.IsNullOrWhiteSpace(PhoneNumber))
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string GetAllQuery = "select [Phone_ID] from [Phones] where [Phone_Number] = @PhoneNumber;";

                    Command = new SqlCommand(GetAllQuery, Connection);

                    Command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

                    Connection.Open();

                    Reader = Command.ExecuteReader();

                    if (Reader.HasRows)
                    {
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

        public static bool EmailExist(string Email)
        {
            bool Exist = false;

            if (!string.IsNullOrWhiteSpace(Email))
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string GetAllQuery = "select [Person_ID] from [People] where [Email] = @Email;";

                    Command = new SqlCommand(GetAllQuery, Connection);

                    Command.Parameters.AddWithValue("@Email", Email);

                    Connection.Open();

                    Reader = Command.ExecuteReader();

                    if (Reader.HasRows)
                    {
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

        public static bool GetPeoplePhonesHelper(int PersonID, ref string Phone1, ref string Phone2, SqlConnection Connection)
        {
            SqlCommand Command = null;
            SqlDataReader Reader = null;

            bool Success = false;

            if (PersonID > 0 && Connection != null)
            {
                try
                {
                    string Query = "select [Phone_Number] from [Phones] where [Person_ID] = @PersonID;";

                    Command = new SqlCommand(Query, Connection);

                    Command.Parameters.AddWithValue("@PersonID", PersonID);

                    Reader = Command.ExecuteReader();

                    List<string> ListOfPhones = new List<string>();

                    while (Reader.Read())
                    {
                        ListOfPhones.Add(Reader["Phone_Number"].ToString());
                    }

                    Phone1 = ListOfPhones[0];

                    if (ListOfPhones.Count > 1)
                    {
                        Phone2 = ListOfPhones[1];
                    }
                    else
                    {
                        Phone2 = "";
                    }

                    Success = true;
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
                }
            }

            return Success;
        }

        static public clsPerson FindByApplicationID(int ApplicationID)
        {
            clsPerson Person = null;

            if (ApplicationID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string FindQuery = @"select [People].*, [Country_Name], [Orders].[Order_ID], [User_Name] from
                                        [People] join [Orders] on [People].[Person_ID] = [Orders].[Person_ID]
                                        join [Countries] on [People].[Nationality_Country_ID] = [Countries].[Country_ID]
                                        join [Users] on [People].[CreatedBy_UserID] = [Users].[User_ID]
                                        where [Order_ID] = @OrderID;";

                    Command = new SqlCommand(FindQuery, Connection);

                    Command.Parameters.AddWithValue("@OrderID", ApplicationID);

                    Connection.Open();

                    Reader = Command.ExecuteReader();

                    if (Reader.Read())
                    {
                        Person = new clsPerson();

                        int.TryParse(Reader["Person_ID"].ToString(), out int ID);
                        Person.PersonID = ID;

                        Person.FirstName = Reader["First_Name"] as string ?? "";
                        Person.SecondName = Reader["Second_Name"] as string ?? "";
                        Person.ThirdName = Reader["Third_Name"] as string ?? "";
                        Person.LastName = Reader["Last_Name"] as string ?? "";
                        Person.Address = Reader["Address"] as string ?? "";
                        Person.Country = Reader["Country_Name"] as string ?? "";

                        if (Reader["Email"] == DBNull.Value)
                            Person.Email = "";
                        else
                            Person.Email = Reader["Email"] as string ?? "";

                        Person.ImagePath = Reader["Image_Path"] as string ?? "";
                        Person.Gender = Reader["Gender"] as string ?? "";
                        Person.NationalNumber = Reader["National_Number"] as string ?? "";
                        Person.CreatedByUser = Reader["User_Name"] as string ?? "";

                        DateTime.TryParse(Reader["DateOfBirth"].ToString(), out DateTime Date);
                        Person.DateOfBirth = Date;

                        DateTime.TryParse(Reader["Added_DateTime"].ToString(), out Date);
                        Person.AddedDate = Date;

                        int.TryParse(Reader["CreatedBy_UserID"].ToString(), out int CreatedByUserID);
                        Person.CreatedByUserID = CreatedByUserID;
                    }
                }
                catch
                {
                    Person = null;
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

                    if (Person != null)
                    {
                        string Phone1 = "";
                        string Phone2 = "";

                        GetPeoplePhonesHelper(Person.PersonID, ref Phone1, ref Phone2, Connection);

                        Person.Phone1 = Phone1;
                        Person.Phone2 = Phone2;
                    }

                    if (Connection != null)
                    {
                        Connection.Close();
                        Connection.Dispose();
                    }

                }
            }

            return Person;
        }

        static public clsPerson FindByNationalNumber(string NationalNumber)
        {
            clsPerson Person = null;

            if (!string.IsNullOrWhiteSpace(NationalNumber))
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string FindQuery = @"select [People].*, [Country_Name], [User_Name] from 
                                        [People] join [Countries] on [People].[Nationality_Country_ID] = [Countries].Country_ID
                                        join [Users] on [People].[CreatedBy_UserID] = [Users].[User_ID]
                                        where [National_Number] = @NationalNumber;";

                    Command = new SqlCommand(FindQuery, Connection);

                    Command.Parameters.AddWithValue("@NationalNumber", NationalNumber);

                    Connection.Open();

                    Reader = Command.ExecuteReader();

                    if (Reader.Read())
                    {
                        Person = new clsPerson();

                        int.TryParse(Reader["Person_ID"].ToString(), out int ID);
                        Person.PersonID = ID;

                        Person.FirstName = Reader["First_Name"] as string ?? "";
                        Person.SecondName = Reader["Second_Name"] as string ?? "";
                        Person.ThirdName = Reader["Third_Name"] as string ?? "";
                        Person.LastName = Reader["Last_Name"] as string ?? "";
                        Person.Address = Reader["Address"] as string ?? "";

                        if (Reader["Email"] == DBNull.Value)
                            Person.Email = "";
                        else
                            Person.Email = Reader["Email"] as string ?? "";

                        Person.ImagePath = Reader["Image_Path"] as string ?? "";
                        Person.Gender = Reader["Gender"] as string ?? "";
                        Person.NationalNumber = Reader["National_Number"] as string ?? "";
                        Person.CreatedByUser = Reader["User_Name"] as string ?? "";

                        DateTime.TryParse(Reader["DateOfBirth"].ToString(), out DateTime Date);
                        Person.DateOfBirth = Date;

                        DateTime.TryParse(Reader["Added_DateTime"].ToString(), out Date);
                        Person.AddedDate = Date;

                        Person.Country = Reader["Country_Name"] as string ?? "";
                    }
                }
                catch
                {
                    Person = null;
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

                    if (Person != null)
                    {
                        string Phone1 = "";
                        string Phone2 = "";

                        GetPeoplePhonesHelper(Person.PersonID, ref Phone1, ref Phone2, Connection);

                        Person.Phone1 = Phone1;
                        Person.Phone2 = Phone2;
                    }

                    if (Connection != null)
                    {
                        Connection.Close();
                        Connection.Dispose();
                    }
                }
            }

            return Person;
        }

        static public clsPerson FindByPersonID(int PersonID)
        {
            clsPerson Person = null;

            if (PersonID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string FindQuery = @"select [People].*, [Country_Name], [User_Name] from 
                                         [People] join [Countries] on [People].[Nationality_Country_ID] = [Countries].Country_ID
                                         join [Users] on [People].[CreatedBy_UserID] = [Users].[User_ID]
                                         where [People].[Person_ID] = @PersonID;";

                    Command = new SqlCommand(FindQuery, Connection);

                    Command.Parameters.AddWithValue("@PersonID", PersonID);

                    Connection.Open();

                    Reader = Command.ExecuteReader();

                    if (Reader.Read())
                    {
                        Person = new clsPerson();

                        int.TryParse(Reader["Person_ID"].ToString(), out int ID);
                        Person.PersonID = ID;

                        Person.FirstName = Reader["First_Name"] as string ?? "";
                        Person.SecondName = Reader["Second_Name"] as string ?? "";
                        Person.ThirdName = Reader["Third_Name"] as string ?? "";
                        Person.LastName = Reader["Last_Name"] as string ?? "";
                        Person.Address = Reader["Address"] as string ?? "";

                        if (Reader["Email"] == DBNull.Value)
                            Person.Email = "";
                        else
                            Person.Email = Reader["Email"] as string ?? "";

                        Person.ImagePath = Reader["Image_Path"] as string ?? "";
                        Person.Gender = Reader["Gender"] as string ?? "";
                        Person.NationalNumber = Reader["National_Number"] as string ?? "";
                        Person.CreatedByUser = Reader["User_Name"] as string ?? "";

                        DateTime.TryParse(Reader["DateOfBirth"].ToString(), out DateTime Date);
                        Person.DateOfBirth = Date;

                        DateTime.TryParse(Reader["Added_DateTime"].ToString(), out Date);
                        Person.AddedDate = Date;

                        Person.Country = Reader["Country_Name"] as string ?? "";

                        int.TryParse(Reader["CreatedBy_UserID"].ToString(), out ID);
                        Person.CreatedByUserID = ID;
                    }
                }
                catch
                {
                    Person = null;
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

                    if (Person != null)
                    {
                        string Phone1 = "";
                        string Phone2 = "";

                        GetPeoplePhonesHelper(Person.PersonID, ref Phone1, ref Phone2, Connection);

                        Person.Phone1 = Phone1;
                        Person.Phone2 = Phone2;
                    }

                    if (Connection != null)
                    {
                        Connection.Close();
                        Connection.Dispose();
                    }
                }
            }

            return Person;
        }

        static public clsPerson FindByLicenseID(int LicenseID)
        {
            clsPerson Person = null;

            if (LicenseID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string FindQuery = "select * from [vFindPersonByLicenseID] where [License_ID] = @LicenseID;";

                    Command = new SqlCommand(FindQuery, Connection);

                    Command.Parameters.AddWithValue("@LicenseID", LicenseID);

                    Connection.Open();

                    Reader = Command.ExecuteReader();

                    if (Reader.Read())
                    {
                        Person = new clsPerson();

                        int.TryParse(Reader["Person_ID"].ToString(), out int ID);
                        Person.PersonID = ID;

                        Person.FirstName = Reader["First_Name"] as string ?? "";
                        Person.SecondName = Reader["Second_Name"] as string ?? "";
                        Person.ThirdName = Reader["Third_Name"] as string ?? "";
                        Person.LastName = Reader["Last_Name"] as string ?? "";
                        Person.Address = Reader["Address"] as string ?? "";

                        if (Reader["Email"] == DBNull.Value)
                            Person.Email = "";
                        else
                            Person.Email = Reader["Email"] as string ?? "";

                        Person.ImagePath = Reader["Image_Path"] as string ?? "";
                        Person.Gender = Reader["Gender"] as string ?? "";
                        Person.NationalNumber = Reader["National_Number"] as string ?? "";
                        Person.CreatedByUser = Reader["User_Name"] as string ?? "";

                        DateTime.TryParse(Reader["DateOfBirth"].ToString(), out DateTime Date);
                        Person.DateOfBirth = Date;

                        DateTime.TryParse(Reader["Added_DateTime"].ToString(), out Date);
                        Person.AddedDate = Date;
                    }
                }
                catch
                {
                    Person = null;
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

                    if (Person != null)
                    {
                        string Phone1 = "";
                        string Phone2 = "";

                        GetPeoplePhonesHelper(Person.PersonID, ref Phone1, ref Phone2, Connection);

                        Person.Phone1 = Phone1;
                        Person.Phone2 = Phone2;
                    }

                    if (Connection != null)
                    {
                        Connection.Close();
                        Connection.Dispose();
                    }
                }
            }

            return Person;
        }

        static public clsPerson FindByDriverID(int DriverID)
        {
            clsPerson Person = null;

            if (DriverID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;
                SqlDataReader Reader = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string FindQuery = @"select [People].*, [Country_Name], [User_Name] from 
                                        [Drivers] join [People] on [Drivers].[Person_ID] = [People].[Person_ID]
                                        join [Countries] on [People].[Nationality_Country_ID] = [Countries].[Country_ID]
                                        join [Users] on [People].[CreatedBy_UserID] = [Users].[User_ID]
                                        where [Driver_ID] = @DriverID;";

                    Command = new SqlCommand(FindQuery, Connection);

                    Command.Parameters.AddWithValue("@DriverID", DriverID);

                    Connection.Open();

                    Reader = Command.ExecuteReader();

                    if (Reader.Read())
                    {
                        Person = new clsPerson();

                        int.TryParse(Reader["Person_ID"].ToString(), out int ID);
                        Person.PersonID = ID;

                        Person.FirstName = Reader["First_Name"] as string ?? "";
                        Person.SecondName = Reader["Second_Name"] as string ?? "";
                        Person.ThirdName = Reader["Third_Name"] as string ?? "";
                        Person.LastName = Reader["Last_Name"] as string ?? "";
                        Person.Address = Reader["Address"] as string ?? "";

                        if (Reader["Email"] == DBNull.Value)
                            Person.Email = "";
                        else
                            Person.Email = Reader["Email"] as string ?? "";

                        Person.ImagePath = Reader["Image_Path"] as string ?? "";
                        Person.Gender = Reader["Gender"] as string ?? "";
                        Person.NationalNumber = Reader["National_Number"] as string ?? "";
                        Person.CreatedByUser = Reader["User_Name"] as string ?? "";

                        DateTime.TryParse(Reader["DateOfBirth"].ToString(), out DateTime Date);
                        Person.DateOfBirth = Date;

                        DateTime.TryParse(Reader["Added_DateTime"].ToString(), out Date);
                        Person.AddedDate = Date;

                        Person.Country = Reader["Country_Name"] as string ?? "";
                    }
                }
                catch
                {
                    Person = null;
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

                    if (Person != null)
                    {
                        string Phone1 = "";
                        string Phone2 = "";

                        GetPeoplePhonesHelper(Person.PersonID, ref Phone1, ref Phone2, Connection);

                        Person.Phone1 = Phone1;
                        Person.Phone2 = Phone2;
                    }

                    if (Connection != null)
                    {
                        Connection.Close();
                        Connection.Dispose();
                    }
                }
            }

            return Person;
        }

        static bool DeletePersonPhones(int PersonID, SqlConnection Connection)
        {
            bool Deleted = false;

            if (PersonID > 0)
            {
                SqlCommand Command = null;

                try
                {
                    string DeletedQuery = "delete from [Phones] where [Person_ID] = @PersonID;";

                    Command = new SqlCommand(DeletedQuery, Connection);

                    Command.Parameters.AddWithValue("@PersonID", PersonID);

                    Connection.Open();

                    if (Command.ExecuteNonQuery() > 0)
                    {
                        Deleted = true;
                    }
                }
                finally
                {
                    if (Command != null)
                    {
                        Command.Dispose();
                    }
                }
            }

            return Deleted;
        }

        static public bool DeleteByID(int PersonID)
        {
            bool Deleted = false;

            if (PersonID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    DeletePersonPhones(PersonID, Connection);

                    string DeletedQuery = "delete from [People] where [Person_ID] = @PersonID;";

                    Command = new SqlCommand(DeletedQuery, Connection);

                    Command.Parameters.AddWithValue("@PersonID", PersonID);

                    if (Command.ExecuteNonQuery() > 0)
                    {
                       Deleted = true;
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

            return Deleted;
        }

        static void SetPeoplePhones(List<clsPerson> ListOfPeople, SqlConnection Connection)
        {
            string Phone1 = "";
            string Phone2 = "";

            for (int i = 0; i < ListOfPeople.Count; i++)
            {
                GetPeoplePhonesHelper(ListOfPeople[i].PersonID, ref Phone1, ref Phone2, Connection);

                ListOfPeople[i].Phone1 = Phone1;
                ListOfPeople[i].Phone2 = Phone2;
            }
        }

        static public List<clsPerson> GetAllPeople()
        {
            List<clsPerson> ListOfPeople = new List<clsPerson>();

            SqlConnection Connection = null;
            SqlCommand Command = null;
            SqlDataReader Reader = null;

            try
            {
                Connection = new SqlConnection(clsConnectionString.ConnectionString);

                string FindQuery = @"select [People].*, [Country_Name], [User_Name] from 
                                         [People] join [Countries] on [People].[Nationality_Country_ID] = [Countries].Country_ID
                                         join [Users] on [People].[CreatedBy_UserID] = [Users].[User_ID];";


                Command = new SqlCommand(FindQuery, Connection);

                Connection.Open();

                Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    clsPerson Person = new clsPerson();

                    int.TryParse(Reader["Person_ID"].ToString(), out int ID);
                    Person.PersonID = ID;

                    Person.FirstName = Reader["First_Name"] as string ?? "";
                    Person.SecondName = Reader["Second_Name"] as string ?? "";
                    Person.ThirdName = Reader["Third_Name"] as string ?? "";
                    Person.LastName = Reader["Last_Name"] as string ?? "";
                    Person.Address = Reader["Address"] as string ?? "";

                    if (Reader["Email"] == DBNull.Value)
                        Person.Email = "";
                    else
                        Person.Email = Reader["Email"] as string ?? "";

                    Person.ImagePath = Reader["Image_Path"] as string ?? "";
                    Person.Gender = Reader["Gender"] as string ?? "";
                    Person.NationalNumber = Reader["National_Number"] as string ?? "";
                    Person.CreatedByUser = Reader["User_Name"] as string ?? "";

                    DateTime.TryParse(Reader["DateOfBirth"].ToString(), out DateTime Date);
                    Person.DateOfBirth = Date;

                    DateTime.TryParse(Reader["Added_DateTime"].ToString(), out Date);
                    Person.AddedDate = Date;

                    Person.Country = Reader["Country_Name"] as string ?? "";

                    ListOfPeople.Add(Person);
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

                if (ListOfPeople.Count > 0)
                {
                    SetPeoplePhones(ListOfPeople, Connection);
                }

                if (Connection != null)
                {
                    Connection.Close();
                    Connection.Dispose();
                }
            }

            return ListOfPeople;
        }

        static bool UpdatePersonPhones(string NewPhone1, string NewPhone2, string OldPhone1, string OldPhone2, int PersonID, SqlConnection Connection, SqlCommand Command)
        {
            bool Updated = false;

            if ((!string.IsNullOrWhiteSpace(NewPhone1) && NewPhone1 != OldPhone1) || (!string.IsNullOrWhiteSpace(NewPhone2) && NewPhone2 != OldPhone2))
            {
                string UpdatedQuery = "";

                if (!string.IsNullOrWhiteSpace(NewPhone1))
                {
                    if (NewPhone1 != OldPhone1)
                    {
                        UpdatedQuery = "update [Phones] set [Phone_Number] = @NewPhone1 where [Phone_Number] = @OldPhone1;";
                    }
                }

                if (!string.IsNullOrWhiteSpace(NewPhone2))
                {
                    if (NewPhone2 != OldPhone2)
                    {
                        UpdatedQuery += "update [Phones] set [Phone_Number] = @NewPhone2 where [Phone_Number] = @OldPhone2;";
                    }
                }

                Command = new SqlCommand(UpdatedQuery, Connection);

                Command.Parameters.AddWithValue("@PersonID", PersonID);


                if (!string.IsNullOrWhiteSpace(NewPhone1))
                {
                    if (NewPhone1 != OldPhone1)
                    {
                        Command.Parameters.AddWithValue("@NewPhone1", NewPhone1);
                        Command.Parameters.AddWithValue("@OldPhone1", OldPhone1);
                    }
                }

                if (!string.IsNullOrWhiteSpace(OldPhone2))
                {
                    if (NewPhone2 != OldPhone2)
                    {
                        Command.Parameters.AddWithValue("@NewPhone2", NewPhone2);
                        Command.Parameters.AddWithValue("@OldPhone2", OldPhone2);
                    }
                }


                if (Command.ExecuteNonQuery() > 0)
                {
                    Updated = true;
                }
            }

            return Updated;
        }

        public static bool UpdatePerson(int PersonID, string OldPhone1, string OldPhone2, clsPerson Person)
        {
            bool Updated = false;

            if (PersonID > 0 && Person.IsFull())
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string AddQuery = @"update [People] set [First_Name] = @FirstName, [Second_Name] = @SecondName, [Third_Name] = @ThirdName, 
                                       [Last_Name] = @LastName, [Image_Path] = @ImagePath, [DateOfBirth] = @DateOfBirth, [Address] = @Address,
                                       [Email] = @Email, [National_Number] = @NationalNumber, [Gender] = @Gender, [Nationality_Country_ID] = @CountryID
                                       where [Person_ID] = @PersonID;";


                    Command = new SqlCommand(AddQuery, Connection);

                    Command.Parameters.AddWithValue("@FirstName", Person.FirstName);
                    Command.Parameters.AddWithValue("@SecondName", Person.SecondName);
                    Command.Parameters.AddWithValue("@ThirdName", Person.ThirdName);
                    Command.Parameters.AddWithValue("@LastName", Person.LastName);
                    Command.Parameters.AddWithValue("@ImagePath", Person.ImagePath);
                    Command.Parameters.AddWithValue("@DateOfBirth", Person.DateOfBirth);
                    Command.Parameters.AddWithValue("@Address", Person.Address);
                    Command.Parameters.AddWithValue("@NationalNumber", Person.NationalNumber);
                    Command.Parameters.AddWithValue("@Gender", Person.Gender);
                    Command.Parameters.AddWithValue("@CountryID", Person.NationalityCountryID);

                    if (string.IsNullOrWhiteSpace(Person.Email))
                    {
                        Command.Parameters.AddWithValue("@Email", DBNull.Value);
                    }
                    else
                    {
                        Command.Parameters.AddWithValue("@Email", Person.Email);
                    }

                    Command.Parameters.AddWithValue("@PersonID", PersonID);

                    Connection.Open();

                    if (Command.ExecuteNonQuery() > 0)
                    {
                        Command.Dispose();

                        UpdatePersonPhones(Person.Phone1, Person.Phone2, OldPhone1, OldPhone2, Person.PersonID, Connection, Command);

                        Updated = true;
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

            return Updated;
        }


    }
}
