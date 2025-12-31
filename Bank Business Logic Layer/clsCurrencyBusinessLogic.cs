using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Data_Access_Layer;


namespace Bank_Business_Logic_Layer
{
    public class clsCurrencyBusinessLogic
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int CurrencyID { set; get; }
        public string CurrencyCode { set; get; }
        public string CurrencyName { set; get; }
        public string CountryName { set; get; }
        public float Rate { set; get; }


        private bool _AddNewCurrency()
        {
            //call DataAccess Layer 

            this.CurrencyID = clsCurrencyDataAccess.AddNewCurrency(this.CurrencyName, this.CurrencyCode, this.CountryName, this.Rate);

            return (this.CurrencyID != -1);
        }


        private bool _UpdateCurrency()
        {
            //call DataAccess Layer 

            return clsCurrencyDataAccess.UpdateCurrency(this.CurrencyID, this.CurrencyName, this.CurrencyCode, 
                this.CountryName, this.Rate);

        }


        public static clsCurrencyBusinessLogic Find(int CurrencyID)
        {

            string CurrencyName = "", CurrencyCode = "", CountryName = "";
            
            float Rate = 0.0f;

            if (clsCurrencyDataAccess.GetCurrencyInfoByID(CurrencyID, ref CurrencyName, ref CurrencyCode, ref CountryName,ref Rate))

                return new clsCurrencyBusinessLogic(CurrencyID, CurrencyName, CurrencyCode, CountryName , Rate);
            else
                return null;

        }

        public static clsCurrencyBusinessLogic Find(string CurrencyCode)
        {
            int CurrencyID = -1;

            string CurrencyName = "", CountryName = "";

            float Rate = 0.0f;

            if (clsCurrencyDataAccess.GetCurrencyInfoByCode(CurrencyCode, ref CurrencyID, ref CurrencyName, ref CountryName, ref Rate))
                return new clsCurrencyBusinessLogic(CurrencyID, CurrencyName, CurrencyCode, CountryName, Rate);
            else
                return null;

        }

        public clsCurrencyBusinessLogic() 
        {
            this.CurrencyID = -1;
            this.CurrencyName = string.Empty;
            this.CurrencyCode = string.Empty;
            this.CountryName = string.Empty;
            this.Rate = 0.0f;

            Mode = enMode.AddNew;
        }

        private clsCurrencyBusinessLogic( int CurrencyID, string CurrencyName, string CurrencyCode, string CountryName, float Rate)
        {
            this.CurrencyID = CurrencyID;
            this.CurrencyName= CurrencyName;    
            this.CurrencyCode= CurrencyCode;    
            this.CountryName= CountryName;
            this.Rate = Rate;
            
            Mode = enMode.Update;

        }


        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCurrency())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateCurrency();

            }

            return false;
        }


        public static DataTable GetAllCurrencies()
        {
            return clsCurrencyDataAccess.GetAllCurrencies();
        }


        public static bool DeleteCurrency(int ID)
        {
            return clsCurrencyDataAccess.DeleteCurrency(ID);
        }


        public static bool DoesCurrencyExist(int ID)
        {
            return clsCurrencyDataAccess.DoesCurrencyExist(ID);
        }

        public static bool DoesCurrencyExist(string CurrencyCode)
        {
            return clsCurrencyDataAccess.DoesCurrencyExist(CurrencyCode);
        }

        public static bool ExchangeCurrencyToDollars(clsCurrencyBusinessLogic Currency, float Amount , ref float ExchangedAmount)
        {
            /*Exchanges any Currency to US Dollars*/
            if (Amount < 0)
            {
                return false;
            }
            else
            {
                ExchangedAmount = Amount / Currency.Rate;
                return true;
            }

        }

        public static bool ExchangeDollarsToCurrency(clsCurrencyBusinessLogic Currency, float DollarAmount, ref float ExchangedAmount)
        {
            if (DollarAmount < 0)
            {
                return false;
            }
            else
            {
                ExchangedAmount = DollarAmount * Currency.Rate;
                return true;
            }

        }


        public bool ExchangeToCurrency(clsCurrencyBusinessLogic CurrencyTo, float Amount, ref float ExchangedAmount)
        {
            if (ExchangeCurrencyToDollars(this, Amount, ref ExchangedAmount))
            {
                if (ExchangeDollarsToCurrency(CurrencyTo, ExchangedAmount, ref ExchangedAmount))
                {
                    return true;
                }
            }


            return false;
        }



        public static bool AddNewExchangeRecord(int UserID, int CurrencyFromID, 
            int CurrencyToID, float AmountFrom, float AmountTo, DateTime ExchangeDate)
        {
            //call DataAccess Layer 

            int ExchangeID = -1;

            ExchangeID = clsExchangeDataAccess.AddNewExchange(UserID, CurrencyFromID, CurrencyToID, AmountFrom
                , AmountTo, ExchangeDate);

            return (ExchangeID != -1);
        }



        public static DataTable GetAllExchanges()
        {
            return clsExchangeDataAccess.GetAllExchanges();
        }





    }
}
