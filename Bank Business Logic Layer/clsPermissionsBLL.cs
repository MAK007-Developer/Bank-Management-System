using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Business_Logic_Layer
{
    public class clsPermissionsBLL
    {

        enum enMainPermissions
        {
            FullAceess = -1, ClientsManagement = 1, UsersManagement = 2, CurrencyExchange = 4, Transactions = 8
        }

        enum enClientsManagementPermissions
        {
            ClientsManagementFullAceess = -1, AddClient = 1, DeleteClient = 2, UpdateClient = 4, ListClients = 8, FindClient = 16
        }

        enum enUsersManagementPermissions
        {
            UsersManagementFullAceess = -1, AddUser = 1, DeleteUser = 2, UpdateUser = 4, ListUsers = 8, FindUser = 16
        }

        enum enCurrenciesManagementPermissions
        {
            CurrenciesManagementFullAceess = -1, AddCurrency = 1, UpdateCurrency = 2, ListCurrencies = 4, FindCurrency = 8, ExchangeCurrency = 16,
            ExchangeLog = 32
        }


        enum enTransactionsManagementPermissions
        {
            TransactionsManagement = -1, Deposit = 1, WithDraw = 2, ListBalances = 4, Transfer = 8, TransferLog = 16
        }

        public int MainPermissions { set; get; }
        public int ClientsManagementPermissions { set; get; }
        public int UsersManagementPermissions { set; get; }
        public int CurrenciesManagementPermissions { set; get; }
        public int TransactionsManagementPermissions { set; get; }

        public string FullPermissionStr { set; get; }


        public clsPermissionsBLL()
        {
            this.MainPermissions = 0;
            this.ClientsManagementPermissions = 0;
            this.UsersManagementPermissions = 0;
            this.CurrenciesManagementPermissions = 0;
            this.TransactionsManagementPermissions = 0;
            this.FullPermissionStr = string.Empty;
        }

        public clsPermissionsBLL(int MainPer, int ClientPer, int UserPer, int CurrencyPer, int TransactionPer)
        {
            this.MainPermissions = MainPer;
            this.ClientsManagementPermissions = ClientPer;
            this.UsersManagementPermissions = UserPer;
            this.CurrenciesManagementPermissions = CurrencyPer;
            this.TransactionsManagementPermissions = TransactionPer;
            this.FullPermissionStr = MainPer.ToString() + "#" + ClientPer.ToString() + "#" + 
                UserPer.ToString() + "#" + CurrencyPer.ToString() + "#" + TransactionPer.ToString();
        }

        public clsPermissionsBLL( clsPermissionsBLL ObjPermission )
        {
            ObjPermission = new clsPermissionsBLL(ObjPermission.MainPermissions, ObjPermission.ClientsManagementPermissions, ObjPermission.UsersManagementPermissions, 
                ObjPermission.CurrenciesManagementPermissions, ObjPermission.TransactionsManagementPermissions);
        }



    }
}
