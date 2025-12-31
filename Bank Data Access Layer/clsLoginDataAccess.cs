using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Data_Access_Layer
{
    public class clsLoginDataAccess
    {
        public static DataTable GetAllLogins()
        {
            DataTable dt = new DataTable();

            string query = @"SELECT * from ListLogins";

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

        public static int CountLogins()
        {
            int LoginsCount = 0;

            string query = @"SELECT Count(*) as Logins from ListLogins";

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    LoginsCount = (int)reader["Logins"];
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



            return LoginsCount;
        }

        public static int AddNewLogin(int UserID, DateTime LoginDate)
        {
            int LoginID = -1;

            string query = @"Insert into Logins(UserID, LoginDate)
                            Values(@UserID, @LoginDate);
                            SELECT SCOPE_IDENTITY();";

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@LoginDate", LoginDate);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ResultID))
                {
                    LoginID = ResultID;
                }

            }
            catch (Exception)
            {

                return -1;
            }
            finally
            {
                connection.Close();
            }

            return LoginID;
        }

    }
}
