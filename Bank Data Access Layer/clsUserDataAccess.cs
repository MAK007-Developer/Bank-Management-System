using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Data_Access_Layer
{
    public class clsUserDataAccess
    {

        private static int GetUserPersonID(int ID)
        {
            int PersonID = -1;

            string query = "Select PersonID from Users where UserID = @UserID";

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
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

        public static bool GetUserInfoByID(int UserID, ref int PersonID, ref string UserName, ref string Password, ref string FirstName, ref string LastName,
            ref string Email, ref string Phone, ref string PermissionsStringString)
        {
            bool isFound = false;

            

            string query = @"SELECT * from Users 
                            where UserID = @UserID";

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    PermissionsStringString = (string)reader["PermissionsStringString"];
                    clsPersonDataAccess.GetPersonInfoByID(PersonID, ref FirstName, ref LastName, ref Email, ref Phone);
                    isFound = true;
                }

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

        public static bool GetUserInfoByUserName(string UserName, ref int UserID, ref int PersonID, ref string Password, ref string FirstName, ref string LastName,
            ref string Email, ref string Phone, ref string PermissionsString)
        {
            bool isFound = false;
            
            string query = @"SELECT * from Users 
                            where UserName = @UserName";
            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    Password = (string)reader["Password"];
                    PermissionsString = (string)reader["PermissionsString"];
                    clsPersonDataAccess.GetPersonInfoByID(PersonID, ref FirstName, ref LastName, ref Email, ref Phone);

                }

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


        public static bool GetUserInfoByUserNameAndPassword(string UserName, string Password, ref int UserID, ref int PersonID, ref string FirstName, ref string LastName,
            ref string Email, ref string Phone, ref string PermissionsString)
        {
            bool isFound = false;

            string query = @"SELECT * from Users 
                            where UserName = @UserName and Password = @Password";

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    Password = (string)reader["Password"];
                    PermissionsString = (string)reader["PermissionsString"];
                    clsPersonDataAccess.GetPersonInfoByID(PersonID, ref FirstName, ref LastName, ref Email, ref Phone);
                }

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


        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            string query = @"SELECT Users.UserID, Users.UserName, Users.Password, Persons.FirstName, Persons.LastName, Persons.Email, Persons.Phone, Users.PermissionsString
                                FROM     Users INNER JOIN
                                Persons ON Users.PersonID = Persons.PersonID";

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

        public static int AddNewUser(string FirstName, string LastName, string Email, string Phone, string UserName,
             string Password, string PermissionsString)
        {
            int UserID = -1, PersonID = -1;

            PersonID = clsPersonDataAccess.AddNewPerson(FirstName, LastName, Email, Phone);

            //
            string query = @"INSERT INTO Users (PersonID ,UserName, Password, PermissionsString)
                             VALUES (@PersonID, @UserName, @Password, @PermissionsString);
                             SELECT SCOPE_IDENTITY();";


            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            command.Parameters.AddWithValue("@UserName", UserName);

            command.Parameters.AddWithValue("@Password", Password);

            command.Parameters.AddWithValue("@PermissionsString", PermissionsString);


            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    UserID = InsertedID;
                }

            }
            catch (Exception)
            {


            }
            finally
            {
                connection.Close();
            }

            return UserID;
        }

        public static bool UpdateUser(int UserID, string NewFirstName, string NewLastName, string NewEmail, string NewPhone,
        string Password, float PermissionsString)
        {
            int rowsAffected = 0, PersonID = -1;
            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            PersonID = GetUserPersonID(UserID);

            clsPersonDataAccess.UpdatePerson(PersonID, NewFirstName, NewLastName, NewEmail, NewPhone);


            string query = @"Update Users  
                            set Password = @Password, 
                                PermissionsString = @PermissionsString
                                where UserID = @UserID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            command.Parameters.AddWithValue("@Password", Password);

            command.Parameters.AddWithValue("@PermissionsString", PermissionsString);


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

        public static bool DeleteUser(int UserID)
        {
            int rowsAffected = 0, PersonID = -1;

            PersonID = GetUserPersonID(UserID);

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string query = @"Delete Users 
                                where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

                clsPersonDataAccess.DeletePerson(PersonID);
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

        public static bool DoesUserExist(int UserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

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

        public static bool DoesUserExist(string UserName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Users WHERE UserName = @UserName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

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

        public static int GetUsersCountInSystem()
        {
            int UsersCount = 0;

            string query = "Select  Count(*) as UsersCount from Users";


            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);


            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    UsersCount = (int)reader["UsersCount"];
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

            return UsersCount;
        }

    }
}
