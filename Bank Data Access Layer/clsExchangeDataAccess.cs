using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Data_Access_Layer
{
    public class clsExchangeDataAccess
    {
        public static int AddNewExchange(int UserID, int CurrencyIDFrom, int CurrencyIDTo, float AmountFrom, float AmountTo, DateTime ExchangeDate)
        {
            int ExchangeID = -1;

            string query = @"Insert into Exchanges(UserID, CurrencyIDFrom, CurrencyIDTo, AmountFrom, AmountTo, ExchangeDate)
                            Values(@UserID, @CurrencyIDFrom, @CurrencyIDTo, @AmountFrom, @AmountTo, @ExchangeDate);
                            SELECT SCOPE_IDENTITY();";

            SqlConnection connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@CurrencyIDFrom", CurrencyIDFrom);

            command.Parameters.AddWithValue("@CurrencyIDTo", CurrencyIDTo);
            command.Parameters.AddWithValue("@AmountFrom", AmountFrom);

            command.Parameters.AddWithValue("@AmountTo", AmountTo);
            command.Parameters.AddWithValue("@ExchangeDate", ExchangeDate);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if ( result != null && int.TryParse(result.ToString(), out int ResultID))
                {
                    ExchangeID = ResultID;
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




            return ExchangeID;
        }

        public static DataTable GetAllExchanges()
        {
            DataTable dt = new DataTable();

            string query = @"SELECT Exchanges.ExchangeID, Users.UserName, Users.Permissions, CurrenciesFrom.CurrencyCode AS CurrencyFrom, 
                            Exchanges.AmountFrom, CurrenciesFrom.Rate$ as RateFrom
                            ,CurrenciesTo.CurrencyCode AS CurrencyTo, CurrenciesTo.Rate$ AS RateTo, Exchanges.AmountTo, Exchanges.ExchangeDate
                  FROM     Exchanges INNER JOIN
                  Users ON Exchanges.UserID = Users.UserID INNER JOIN
                  Currencies AS CurrenciesFrom ON Exchanges.CurrencyIDFrom = CurrenciesFrom.CurrencyID INNER JOIN
                  Currencies AS CurrenciesTo ON Exchanges.CurrencyIDTo = CurrenciesTo.CurrencyID";

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



    }
}
