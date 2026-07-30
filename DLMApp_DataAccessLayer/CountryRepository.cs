
using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;


namespace DLMApp_DataAccessLayer
{
    public class CountryRepository
    {
        public static async Task<List<clsCountry>> GetAllCountries()
        {
            List <clsCountry> ListOfCountries = new List<clsCountry>();

            SqlConnection Connection = null;
            SqlCommand Command = null;
            SqlDataReader Reader = null;

            try
            {
                Connection = new SqlConnection(clsConnectionString.ConnectionString);
                
                string GetAllQuery = "select * from [Countries];";

                Command = new SqlCommand(GetAllQuery, Connection);

                await Connection.OpenAsync();

                Reader = await Command.ExecuteReaderAsync();

                while (await Reader.ReadAsync())
                {
                    clsCountry country = new clsCountry();

                    int.TryParse(Reader["Country_ID"].ToString(), out int result);
                    country.ID = result;

                    country.Name = Reader["Country_Name"] as string ?? "";

                    ListOfCountries.Add(country);
                }
            }
            catch (Exception ex)
            {
                clsEventLog.WriteToEventLog(ex.Message, enLogType.Error);

                ListOfCountries.Clear();
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

            return ListOfCountries;
        }


    }
}
