using System.Configuration;

namespace DLMApp_DataAccessLayer
{
    internal class clsConnectionString
    {
        // This connection string contains a test password, not the real one, as it was changed after the project was completed.
        
        //public static string ConnectionString = "Server=.;DataBase=MyDLM;User ID =sa;Password=123456;";

        // The best practice here is to use the Windows Authentication method already implemented in the project code,
        // or to use the Environment Variables method with the dotenv.net library to read variables from the .env text file and
        // write the name of this file inside the .gitignore file so that it is not uploaded to GitHub.


        public static string ConnectionString = ConfigurationManager.ConnectionStrings["DLMConnectionString"]?.ConnectionString ?? "Server=.;DataBase=MyDLM;Integrated Security=True;";
    }
}
