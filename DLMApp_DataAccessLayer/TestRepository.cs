using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLMApp_DataAccessLayer
{
    public class TestRepository
    {
        public static List<clsTest> GetAllTests()
        {
            List<clsTest> ListOfTests = new List<clsTest>();

            SqlConnection Connection = null;
            SqlCommand Command = null;
            SqlDataReader Reader = null;

            try
            {
                Connection = new SqlConnection(clsConnectionString.ConnectionString);

                string GetAllQuery = "select * from [Tests];";

                Command = new SqlCommand(GetAllQuery, Connection);

                Connection.Open();

                Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    clsTest test = new clsTest();

                    byte.TryParse(Reader["Test_ID"].ToString(), out byte ID);
                    test.ID = ID;

                    short.TryParse(Reader["MaxNumberOfPeople"].ToString(), out short MaxNumber);
                    test.MaxNumberOfPeople = MaxNumber;

                    float.TryParse(Reader["Test_Fees"].ToString(), out float Fees);
                    test.Fees = Fees;

                    test.Test = Reader["Test_Name"] as string ?? "";
                    test.Description = Reader["Test_Description"] as string ?? "";


                    ListOfTests.Add(test);
                }
            }
            catch
            {
                ListOfTests.Clear();
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

            return ListOfTests;
        }

        public static short GetMaxNumberOfPeople(byte TestID)
        {
            short MaxNumberOfPeople = 0;

            SqlConnection Connection = null;
            SqlCommand Command = null;

            if (TestID > 0)
            {
                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string GetAllQuery = "select [MaxNumberOfPeople] from [Tests] where [Test_ID] = @TestID;";

                    Command = new SqlCommand(GetAllQuery, Connection);

                    Command.Parameters.AddWithValue("@TestID", TestID);

                    Connection.Open();

                    short.TryParse(Command.ExecuteScalar().ToString(), out MaxNumberOfPeople);
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

            return MaxNumberOfPeople;
        }

        public static bool UpdateTest(byte TestID, float TestFees, short MaxNumberOfPeople)
        {
            bool Updated = false;

            SqlConnection Connection = null;
            SqlCommand Command = null;

            if (TestID > 0 && TestFees > 0 && MaxNumberOfPeople > 0) 
            {
                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string UpdateQuery = "update [Tests] set [Test_Fees] = @TestFees, [MaxNumberOfPeople] = @MaxNumberOfPeople where [Test_ID] = @TestID;";

                    Command = new SqlCommand(UpdateQuery, Connection);

                    Command.Parameters.AddWithValue("@TestID", TestID);
                    Command.Parameters.AddWithValue("@TestFees", TestFees);
                    Command.Parameters.AddWithValue("@MaxNumberOfPeople", MaxNumberOfPeople);

                    Connection.Open();

                    if (Command.ExecuteNonQuery() > 0)
                    {
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
