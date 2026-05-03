
using System.Collections.Generic;
using System.Data.SqlClient;
using DLMApp_ModulesLayer;



namespace DLMApp_DataAccessLayer
{
    public class CountryRepository
    {
        public static List<clsCountry> GetAllCountries()
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

                Connection.Open();

                Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    clsCountry country = new clsCountry();

                    int.TryParse(Reader["Country_ID"].ToString(), out int result);
                    country.ID = result;

                    country.Name = Reader["Country_Name"] as string ?? "";

                    ListOfCountries.Add(country);
                }
            }
            catch
            {
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
