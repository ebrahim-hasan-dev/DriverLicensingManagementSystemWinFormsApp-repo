using DLMApp_ModulesLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace DLMApp_DataAccessLayer
{
    public class DriverRepository
    {
        public static int AddNewDriver(int PersonID, int CreatedByUserID)
        {
            int DriverID = 0;

            if (PersonID > 0 && CreatedByUserID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string AddQuery = @"insert into [Drivers] ([Created_Date], [Person_ID], [CreatedBy_UserID]) 
                                       values (default, @PersonID, @CreatedByUserID);
                                       select Scope_Identity();";


                    Command = new SqlCommand(AddQuery, Connection);

                  
                    Command.Parameters.AddWithValue("@PersonID", PersonID);
                    Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    Connection.Open();

                    object objPersonID = Command.ExecuteScalar();

                    if (objPersonID != null)
                    {
                        DriverID = int.Parse(objPersonID.ToString());
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

            return DriverID;
        }

        public static int GetDriverID(int PersonID)
        {
            int DriverID = 0;

            if (PersonID > 0)
            {
                SqlConnection Connection = null;
                SqlCommand Command = null;

                try
                {
                    Connection = new SqlConnection(clsConnectionString.ConnectionString);

                    string AddQuery = "select [Driver_ID] from [Drivers] where [Person_ID] = @PersonID;";

                    Command = new SqlCommand(AddQuery, Connection);

                    Command.Parameters.AddWithValue("@PersonID", PersonID);

                    Connection.Open();

                    object objPersonID = Command.ExecuteScalar();

                    if (objPersonID != null)
                    {
                        DriverID = int.Parse(objPersonID.ToString());
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

            return DriverID;
        }

        

    }
}
