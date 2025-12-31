using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Security.Policy;



namespace Bank_Data_Access_Layer
{
    public class clsClientDataAccess
    {

        private static int GetClientPersonID(int ClientID)
        {
            int PersonID = -1;

            string query = "Select PersonID from Clients where ClientID = @ClientID";

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection); 

            command.Parameters.AddWithValue("@ClientID", ClientID);

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

        public static bool GetClientInfoByID(int ClientID, ref int PersonID, ref string FirstName, ref string LastName, ref string Email,
            ref string Phone, ref string AccountNumber, ref string PinCode, ref double Balance)
        {
            bool isFound = false;

            

            string query = @"SELECT * from Clients 
                            where ClientID = @ClientID";

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    AccountNumber = (string)reader["AccountNumber"];
                    PinCode = (string)reader["PinCode"];
                    Balance = (float)reader["Balance"];

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

        public static bool GetClientInfoByAccountNumber(string AccountNumber, ref int ClientID, ref int PersonID, ref string FirstName, ref string LastName, 
            ref string Email, ref string Phone, ref string PinCode, ref double Balance)
        {
            bool isFound = false;
            

            string query = @"SELECT * from Clients 
                            where AccountNumber = @AccountNumber";
            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ClientID = (int)reader["ClientID"];
                    PersonID = (int)reader["PersonID"];
                    PinCode = (string)reader["PinCode"];
                    Balance = (double)reader["Balance"];

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

        public static DataTable GetAllClients()
        {
            DataTable dt = new DataTable();

            string query = @"SELECT Clients.ClientID, Persons.FirstName, Persons.LastName, Clients.AccountNumber, Clients.Balance, 
                                Clients.PinCode, Persons.Email, Persons.Phone
                                FROM     Clients INNER JOIN
                                Persons ON Clients.PersonID = Persons.PersonID";

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

        public static DataTable ListBalances()
        {
            DataTable dt = new DataTable();

            string query = @"SELECT ClientID, AccountNumber, Balance, PinCode FROM Clients";

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


        public static int AddNewClient(string FirstName, string LastName, string Email, string Phone, string AccountNumber, 
             string PinCode, double Balance)
        {
            int ClientID = -1 , PersonID = -1;

            PersonID = clsPersonDataAccess.AddNewPerson(FirstName, LastName, Email, Phone);

            //
            string query = @"INSERT INTO Clients (PersonID ,AccountNumber, PinCode, Balance)
                             VALUES (@PersonID, @AccountNumber, @PinCode, @Balance);
                             SELECT SCOPE_IDENTITY();";


            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            command.Parameters.AddWithValue("@PinCode", PinCode);

            command.Parameters.AddWithValue("@Balance", Balance);


            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    ClientID = InsertedID;
                }

            }
            catch (Exception)
            {


            }
            finally
            {
                connection.Close();
            }

            return ClientID;
        }

        public static bool UpdateClient(int ClientID, string NewFirstName, string NewLastName, string NewEmail, string NewPhone,
        string PinCode, double Balance)
        {
            int rowsAffected = 0,  PersonID = -1;
            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            PersonID = GetClientPersonID(ClientID);

            clsPersonDataAccess.UpdatePerson(PersonID, NewFirstName, NewLastName, NewEmail, NewPhone);


            string query = @"Update Clients  
                            set PinCode = @PinCode, 
                                Balance = @Balance
                                where ClientID = @ClientID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

            command.Parameters.AddWithValue("@PinCode", PinCode);

            command.Parameters.AddWithValue("@Balance", Balance);


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

        public static bool DeleteClient(int ClientID)
        {
            int rowsAffected = 0, PersonID = -1;

            PersonID = GetClientPersonID(ClientID);

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string query = @"Delete Clients 
                                where ClientID = @ClientID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

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

        public static bool DoesClientExist(int ClientID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Clients WHERE ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

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

        public static bool DoesClientExist(string AccountNumber)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Clients WHERE AccountNumber = @AccountNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

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


        public static int GetClientsCountInSystem()
        {
            int ClientCount = 0;

            string query = "Select  Count(*) as ClientCount from Clients";


            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);


            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ClientCount = (int)reader["ClientCount"];
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

            return ClientCount;
        }

        public static double GetTotalBalancesInSystem()
        {
            double TotalBalances = 0;

            string query = "Select Sum(Balance) as TotalBalances from Clients";


            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);


            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    TotalBalances = (double)reader["TotalBalances"];
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

            return TotalBalances;
        }





    }
}
