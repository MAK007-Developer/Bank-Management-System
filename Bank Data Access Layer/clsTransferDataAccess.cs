using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Data_Access_Layer
{
    public class clsTransferDataAccess
    {
        private static int GetClientPersonID(int ID)
        {
            int PersonID = -1;

            string query = "Select PersonID from Clients where ClientID = @ClientID";

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ID);

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

        public static bool GetTransferInfoByID(int TransferID, ref string UserName, ref int Permissions, ref string SenderAccountNumber,
            ref double SenderBalance, ref string ReceiverAccountNumber, ref double ReceiverBalance, 
            ref double TransferAmount, DateTime TransferDate)
        {
            bool isFound = false;

            
            string query = @"SELECT * from TransfersInfo 
                            where TransferID = @TransferID";

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TransferID", TransferID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    UserName = (string)reader["UserName"];
                    Permissions = (int)reader["Permissions"];

                    SenderAccountNumber = (string)reader["SenderAccNumber"];
                    SenderBalance = (float)reader["SenderBalance"];

                    ReceiverAccountNumber = (string)reader["ReceiverAccNumber"];
                    ReceiverBalance = (float)reader["ReceiverBalance"];

                    TransferAmount = (float)reader["Amount"];


                    //DateTime transferDate;
                    if (reader.IsDBNull(reader.GetOrdinal("TransferDate")))
                    {
                        // Handle NULL case: e.g., assign DateTime.MinValue, null (if nullable DateTime), or skip
                        TransferDate = DateTime.MinValue; // Or DateTime? transferDate = null;
                    }
                    else
                    {
                        TransferDate = (DateTime)reader["TransferDate"];
                    }

                    //TransferDate = (string)reader["TransferDate"].ToString();

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


        public static DataTable GetAllTransfers()
        {
            DataTable dt = new DataTable();

            string query = @"SELECT * from TransfersInfo";

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

        public static int AddNewTransfer(int UserID, int ClientSenderID, int ClientReceiverID, double Amount, DateTime TransferDate)
        {
            int TransferID = -1;

            
            //
            string query = @"INSERT INTO Transfers (UserID ,ClientSenderID, ClientReceiverID, Amount, TransferDate)
                             VALUES (@UserID, @ClientSenderID, @ClientReceiverID, @Amount, @TransferDate);
                             SELECT SCOPE_IDENTITY();";


            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            command.Parameters.AddWithValue("@ClientSenderID", ClientSenderID);

            command.Parameters.AddWithValue("@ClientReceiverID", ClientReceiverID);

            command.Parameters.AddWithValue("@Amount", Amount);

            command.Parameters.AddWithValue("@TransferDate", TransferDate);


            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    TransferID = InsertedID;
                }

            }
            catch (Exception)
            {


            }
            finally
            {
                connection.Close();
            }

            return TransferID;
        }

        public static bool UpdateTransfer(int TransferID, int NewClientSenderID, string NewClientReceiverID, 
        double NewAmount, DateTime NewTransferDate)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            
            string query = @"Update Transfers  
                            set ClientSenderID = @NewClientSenderID, 
                                ClientReceiverID = @NewClientReceiverID,
                                Amount = @NewAmount,
                                TransferDate = @NewTransferDate
                                where TransferID = @TransferID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TransferID", TransferID);

            command.Parameters.AddWithValue("@NewClientSenderID", NewClientSenderID);

            command.Parameters.AddWithValue("@NewClientReceiverID", NewClientReceiverID);

            command.Parameters.AddWithValue("@NewAmount", NewAmount);

            command.Parameters.AddWithValue("@NewTransferDate", NewTransferDate);


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

        public static bool DeleteTransfer(int TransferID)
        {
            int rowsAffected = 0;

            
            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string query = @"Delete Transfers 
                                where TransferID = @CTransferID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TransferID", TransferID);

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

        public static bool DoesTransferExist(int TransferID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Clients WHERE ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", TransferID);

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

        public static int GetTranfersCountInSystem()
        {
            int TransferCount = 0;

            string query = "Select  Count(*) as TransferCount from Transfers";


            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);


            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    TransferCount = (int)reader["TransferCount"];
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

            return TransferCount;
        }



    }





}
