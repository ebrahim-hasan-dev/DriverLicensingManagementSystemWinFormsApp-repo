using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;


namespace DLMApp_DataAccessLayer
{
    public class TestRepository
    {
        public static async Task<List<clsTest>> GetAllTests()
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

                await Connection.OpenAsync();

                Reader = await Command.ExecuteReaderAsync();

                while (await Reader.ReadAsync())
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
            catch (Exception ex)
            {
                clsEventLog.WriteToEventLog(ex.Message, enLogType.Error);
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

        public static async Task<short> GetMaxNumberOfPeople(byte TestID)
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

                    await Connection.OpenAsync();

                    object obj = await Command.ExecuteScalarAsync();

                    if (obj != null)
                    {
                        short.TryParse(obj.ToString(), out MaxNumberOfPeople);
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

            return MaxNumberOfPeople;
        }

        public static async Task<bool> UpdateTest(byte TestID, float TestFees, short MaxNumberOfPeople)
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



    }
    
}
