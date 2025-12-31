using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;


namespace Bank_Data_Access_Layer
{
    public class clsCountryDataAccess
    {
        public static bool GetCountryInfoByID( int ID, ref string CountryName)
        {
            bool isFound = false;

            string query = @"Select * from Countries where CountryID = @CountryID";

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query,connection);

            command.Parameters.AddWithValue("@CountryID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    CountryName = (string)reader["CountryName"];
                }

                isFound = true;
                reader.Close();

            }
            catch (Exception)
            {

                isFound = false;
            }
            finally 
            { 
                connection.Close(); 
            }


            return isFound;
        }

        public static bool GetCountryInfoByName(ref int ID, string CountryName)
        {
            bool isFound = false;

            string query = @"Select * from Countries where CountryName = @CountryName";

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ID = (int)reader["CountryID"];
                }

                isFound = true;
                reader.Close();

            }
            catch (Exception)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }


            return isFound;
        }

        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();

            string query = @"Select * from Countries";

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();

            }
            catch (Exception)
            {

                
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static int AddNewCountry(string CountryName)
        {
            int CountryID = -1;

            string query = @"INSERT INTO Countries (CountryName)
                             VALUES (@CountryName);
                             SELECT SCOPE_IDENTITY();";


            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();
                object Result = command.ExecuteNonQuery();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    CountryID = InsertedID;
                }

            }
            catch (Exception)
            {


            }
            finally
            {
                connection.Close();
            }

            return CountryID;
        }

        public static bool UpdateCountry(int ID, string NewCountryName)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string query = @"Update Countries  
                            set CountryName = @NewCountryName,
                                where CountryID = @CountryID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryID", ID);
            command.Parameters.AddWithValue("@NewCountryName", NewCountryName);
            

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool DeleteCountry(int ID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string query = @"Delete Countries 
                                where CountryID = @CountryID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryID", ID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);
        }

        public static bool DoesCountryExist(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Countries WHERE CountryID = @CountryID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool DoesCountryExist(string CountryName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Countries WHERE CountryName = @CountryName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


    }
}
