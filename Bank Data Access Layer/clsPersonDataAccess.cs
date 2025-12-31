using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Security.Policy;

namespace Bank_Data_Access_Layer
{
    public class clsPersonDataAccess
    {
        
         
        public static bool GetPersonInfoByID(int ID, ref string FirstName, ref string LastName, ref string Email, ref string Phone)
        {
            bool isFound = false;

            string query = @"SELECT * from Persons 
                            where PersonID = @PersonID";

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query,connection);

            command.Parameters.AddWithValue("@PersonID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];

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
        
        public static bool GetPersonInfoBy1stName(string FirstName, ref int ID, ref string LastName, ref string Email, ref string Phone)
        {
            bool isFound = false;

            string query = @"Select * from Persons 
                             where FirstName = @FirstName";
            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ID = (int)reader["PersonID"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
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

        public static bool GetPersonInfoByLastName(string LastName, ref int ID, ref string FirstName, ref string Email, ref string Phone)
        {
            bool isFound = false;

            string query = @"Select * from Persons 
                             where LastName = @LastName";
            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LastName", LastName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
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
        
        public static DataTable GetAllPersons()
        {
            DataTable dt = new DataTable();

            string query = @"SELECT * FROM Persons";

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
        
        public static int AddNewPerson(string FirstName, string LastName ,string Email, string Phone)
        {
            int PersonID = -1;

            string query = @"INSERT INTO Persons (FirstName, LastName, Email, Phone)
                             VALUES (@FirstName, @LastName, @Email, @Phone);
                             SELECT SCOPE_IDENTITY();";


            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@FirstName", FirstName);

            command.Parameters.AddWithValue("@LastName", LastName);

            command.Parameters.AddWithValue("@Email", Email);

            command.Parameters.AddWithValue("@Phone", Phone);


            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    PersonID = InsertedID;
                }

            }
            catch (Exception)
            {


            }
            finally
            {
                connection.Close();
            }

            return PersonID;
        }

        public static bool UpdatePerson(int ID, string NewFirstName, string NewLastName, string NewEmail, string NewPhone)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string query = @"Update Persons  
                            set FirstName = @NewFirstName, 
                                LastName = @NewLastName,
                                Email = @NewEmail,
                                Phone = @NewPhone
                                where PersonID = @PersonID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", ID);

            command.Parameters.AddWithValue("@NewFirstName", NewFirstName);

            command.Parameters.AddWithValue("@NewLastName", NewLastName);

            command.Parameters.AddWithValue("@NewEmail", NewEmail);

            command.Parameters.AddWithValue("@NewPhone", NewPhone);
            

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

        public static bool DeletePerson(int ID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string query = @"Delete Persons 
                                where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", ID);

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

        public static bool DoesPersonExist(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Persons WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", ID);

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
        
        public static bool DoesPersonExist(string FirstName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Persons WHERE FirstName = @FirstName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;
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

        public static bool DoesPersonExistByLastName(string LastName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Persons WHERE LastName = @LastName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LastName", LastName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;
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


    }









}
