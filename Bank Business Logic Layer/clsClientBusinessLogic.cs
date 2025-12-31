using Bank_Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Business_Logic_Layer
{
    public class clsClientBusinessLogic : clsPersonBusinessLogic
    {

        public int ClientID { set; get; }
        public string AccountNumber { set; get; }
        public string PinCode { set; get; }
        public double Balance { set; get; }


        private bool _AddNewClient()
        {
            
            this.ClientID = clsClientDataAccess.AddNewClient(this.FirstName, this.LastName, this.Email, this.Phone, this.AccountNumber,
                this.PinCode, this.Balance);

            return (this.ClientID != -1);
        }

        private bool _UpdateClient()
        {
            //call DataAccess Layer 

            return clsClientDataAccess.UpdateClient(this.ClientID, this.FirstName, this.LastName, this.Email,
                this.Phone, this.PinCode, this.Balance);

        }


        public clsClientBusinessLogic() 
        {
            ClientID = -1;
            PersonID = -1;
            FirstName = string.Empty;
            LastName = string.Empty;    
            Email = string.Empty;   
            Phone = string.Empty;
            AccountNumber = string.Empty;
            PinCode = string.Empty;
            Balance = 0;

            Mode = enMode.AddNew;
 
        } 

        private clsClientBusinessLogic(int ClientID, int PersonID, string FirstName, string LastName, string Email, string Phone, 
            string AccountNumber,  string PinCode, double Balance)
        {

            this.ClientID = ClientID;
            this.PersonID = PersonID;   
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.AccountNumber = AccountNumber;
            this.PinCode = PinCode;
            this.Balance = Balance;

            Mode = enMode.Update;

        }

        public override bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewClient())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateClient();

            }

            return false;
        }

        public new static clsClientBusinessLogic Find(int ClientID)
        {

            string FirstName = "", LastName = "", Email = "", Phone = "", AccountNumber = "", PinCode = "";
            double Balance = 0; 
            int PersonID = -1;

            if (clsClientDataAccess.GetClientInfoByID(ClientID, ref PersonID, ref FirstName, ref LastName, ref Email,
                ref Phone, ref AccountNumber, ref PinCode, ref Balance))

                return new clsClientBusinessLogic(ClientID, PersonID, FirstName, LastName, Email,
                Phone, AccountNumber, PinCode, Balance);
            else
                return null;

        }

        public static clsClientBusinessLogic Find(string AccountNumber)
        {

            string FirstName = "", LastName = "", Email = "", Phone = "", PinCode = "";
            double Balance = 0;
            int PersonID = -1, ClientID = -1;

            if (clsClientDataAccess.GetClientInfoByAccountNumber( AccountNumber,ref ClientID, ref PersonID, ref FirstName, ref LastName, ref Email,
                ref Phone, ref PinCode, ref Balance))

                return new clsClientBusinessLogic(ClientID, PersonID, FirstName, LastName, Email,
                Phone, AccountNumber, PinCode, Balance);
            else
                return null;

        }


        public static DataTable GetAllClients()
        {
            return clsClientDataAccess.GetAllClients();
        }


        public static bool DeleteClient(int ClientID)
        {
            return clsClientDataAccess.DeleteClient(ClientID);
        }


        public static bool DoesClientExist(int ClientID)
        {
            return clsClientDataAccess.DoesClientExist(ClientID);
        }

        public static bool DoesClientExist(string AccountNumber)
        {
            return clsClientDataAccess.DoesClientExist(AccountNumber);
        }


        public bool Withdraw(double Amount)
        {
            if (Amount > this.Balance)
            {
                return false;
            }

            if (Amount < 0)
            {
                return false;
            }

            else
            {
                this.Balance -= Amount;                
            }

            return Save();
        }

        public bool Deposit(double Amount)
        {
            if (Amount < 0)
            {
                return false;
            }


            this.Balance += Amount;
            return Save();
        }

        public bool TransferTo(clsClientBusinessLogic ReceiverClient, double Amount)
        {

            if (Amount < 0)
            {
                return false;
            }

            if (Amount > this.Balance)
            {
                return false;
            }

            else
            {
                ReceiverClient.Balance += Amount;
                this.Balance -= Amount;
            }


            return Save() && ReceiverClient.Save();
        }

        public static DataTable ListBalances()
        {
            return clsClientDataAccess.ListBalances();
        }

        public static DataTable GetTransferLog()
        {
            return clsTransferDataAccess.GetAllTransfers();
        }


        public static void AddNewTransferRecord(int UserID, int ClientSenderID, int ClientReceiverID, double Amount, DateTime TransferDate)
        {
            clsTransferDataAccess.AddNewTransfer(UserID, ClientSenderID, ClientReceiverID, Amount, TransferDate);
        }



        public static int GetClientsCountInSystem()
        {

            return clsClientDataAccess.GetClientsCountInSystem();

        }

        public static double GetTotalBalancesCountInSystem()
        {

            return clsClientDataAccess.GetTotalBalancesInSystem();

        }



    }
}
