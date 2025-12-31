using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Security.Policy;

namespace Bank_Data_Access_Layer
{
    public class clsCurrencyDataAccess
    {
         
        public static bool GetCurrencyInfoByID(int CurrencyID, ref string CurrencyName, ref string CurrencyCode, ref string CountryName, 
           ref float Rate )
        {
            bool isFound = false;

            string query = @"SELECT * from Currencies
                            where CurrencyID = @CurrencyID";

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query,connection);

            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    CurrencyName = (string)reader["CurrencyName"];
                    CurrencyCode = (string)reader["CurrencyCode"];
                    CountryName = (string)reader["CountryName"];
                    Rate = (float)reader["Rate$"];
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
        

        public static bool GetCurrencyInfoByCode(string CurrencyCode, ref int CurrencyID, ref string CurrencyName, ref string CountryName, ref float Rate)
        {
            bool isFound = false;

            string query = @"select * from Currencies where CurrencyCode = @CurrencyCode";

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CurrencyCode", CurrencyCode);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    CurrencyID = (int)reader["CurrencyID"];
                    CurrencyName = (string)reader["CurrencyName"];
                    CountryName = (string)reader["CountryName"];
                    Rate = (float) Convert.ToDouble(reader["Rate$"]);
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


        public static DataTable GetAllCurrencies()
        {
            DataTable dt = new DataTable();

            string query = @"select * from Currencies";

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
        
        public static int AddNewCurrency(string CurrencyName, string CurrencyCode ,string CountryName, float Rate)
        {
            int CurrencyID = -1;

            string query = @"INSERT INTO Currencies (CurrencyName, CurrencyCode, CountryName, Rate$)
                             VALUES (@CurrencyName, @CurrencyCode, @CountryName, @Rate);
                             SELECT SCOPE_IDENTITY();";


            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@CurrencyName", CurrencyName);

            command.Parameters.AddWithValue("@CurrencyCode", CurrencyCode);

            command.Parameters.AddWithValue("@CountryName", CountryName);

            command.Parameters.AddWithValue("@Rate", Rate);


            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    CurrencyID = InsertedID;
                }

            }
            catch (Exception)
            {


            }
            finally
            {
                connection.Close();
            }

            return CurrencyID;
        }

        public static bool UpdateCurrency(int CurrencyID, string NewCurrencyName, string NewCurrencyCode, string NewCountryName, float NewRate)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string query = @"Update Currencies  
                            set CurrencyName = @NewCurrencyName, 
                                CurrencyCode = @NewCurrencyCode,
                                CountryName = @NewCountryName,
                                Rate$ = @NewRate
                                where CurrencyID = @CurrencyID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);

            command.Parameters.AddWithValue("@NewCurrencyName", NewCurrencyName);

            command.Parameters.AddWithValue("@NewCurrencyCode", NewCurrencyCode);

            command.Parameters.AddWithValue("@NewCountryName", NewCountryName);

            command.Parameters.AddWithValue("@NewRate", NewRate);
            

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

        public static bool DeleteCurrency(int CurrencyID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string query = @"Delete Currencies 
                                where CurrencyID = @CurrencyID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);

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
        
        public static bool DoesCurrencyExist(int CurrencyID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Countries WHERE CurrencyID = @CurrencyID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);

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
        
        public static bool DoesCurrencyExist(string CurrencyCode)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Currencies WHERE CurrencyCode = @CurrencyCode";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CurrencyCode", CurrencyCode);

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







