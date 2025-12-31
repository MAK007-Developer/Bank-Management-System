using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_Business_Logic_Layer;
using Bank_Management_System.UserControlsWinForms.Users;

namespace Bank_Management_System.Forms
{
    public partial class frmPermissions : Form
    {

        enum enPermissions
        {
            FullAccess = -1, ClientsManagement = 1, UsersManagement = 2, CurrencyExchange = 4, Transactions = 8

            , AddClient = 16, DeleteClient = 32, UpdateClient = 64, ListClients = 128, FindClient = 256

            , AddUser = 512, DeleteUser = 1024, UpdateUser = 2048, ListUsers = 4096, FindUser = 8192,

            AddCurrency = 16384, UpdateCurrency = 32768, ListCurrencies = 65536, FindCurrency = 131072, ExchangeCurrency = 262144,
            ExchangeLog = 524288,

            Deposit = 1048576, WithDraw = 2097152, ListBalances = 4194304, Transfer = 8388608, TransferLog = 16777216
        }



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
            TransactionsManagementFullAccess = -1, Deposit = 1, WithDraw = 2, ListBalances = 4, Transfer = 8, TransferLog = 16
        }


        public clsPermissionsBLL ObjPermissions { set; get; }


        bool IsMainItemSelected(enPermissions MainItem)
        {
            switch (MainItem)
            {
                
                case enPermissions.ClientsManagement:

                    if (chkbClientsManagement.Checked == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enPermissions.UsersManagement:

                    if (chkbUsersManagement.Checked == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enPermissions.CurrencyExchange:
                    if (chkbCurrencyExchange.Checked == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enPermissions.Transactions:
                    if (chkbTransactionsManagement.Checked == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default:
                    return false;
            }
        }

        void AddAllClientsSectionPermissions()
        {
            this.ObjPermissions.ClientsManagementPermissions = (int)enMainPermissions.ClientsManagement;
        }

        void AddAllUsersSectionPermissions()
        {
            this.ObjPermissions.UsersManagementPermissions = (int)enMainPermissions.UsersManagement;
        }

        void AddAllCurrenciesSectionPermissions()
        {
            this.ObjPermissions.CurrenciesManagementPermissions = (int)enMainPermissions.CurrencyExchange;
        }

        void AddAllTransactionsSectionPermissions()
        {
            this.ObjPermissions.TransactionsManagementPermissions = (int)enMainPermissions.Transactions;

        }




        /*
        private void CalculatePermissions(CheckBox chkb)
        {

            switch ((string)chkb.Tag)
            {
                case "FullAccess":
                    this.ObjPermissions = -1;
                    return;
                case "ClientsManagement":
                    AddAllClientsSectionPermissions();

                    return;
                case "UsersManagement":
                    AddAllUsersSectionPermissions();
                    return;
                case "CurrencyExchange":
                    AddAllCurrenciesSectionPermissions();
                    return;
                case "Transactions":
                    AddAllTransactionsSectionPermissions();
                    return;
                case "AddClient":
                    if (IsMainItemSelected(enPermissions.ClientsManagement))
                        this.ObjPermissions += (int)enPermissions.AddClient;
                    else
                        this.ObjPermissions += (int)enPermissions.AddClient + (int)enPermissions.ClientsManagement;
                    return;
                //AddClient = 16, DeleteClient = 32, UpdateClient = 64, ListClients = 128, FindClient = 256
                case "DeleteClient":

                    if (IsMainItemSelected(enPermissions.ClientsManagement))
                        this.ObjPermissions += (int)enPermissions.DeleteClient;
                    
                    else
                        this.ObjPermissions += (int)enPermissions.DeleteClient + (int)enPermissions.ClientsManagement;
                    
                    return;

                case "UpdateClient":

                    if (IsMainItemSelected(enPermissions.ClientsManagement))
                        this.ObjPermissions += (int)enPermissions.UpdateClient;
                    else
                        this.ObjPermissions += (int)enPermissions.UpdateClient + (int)enPermissions.ClientsManagement;

                    return;

                case "ListClients":

                    if (IsMainItemSelected(enPermissions.ClientsManagement))
                        this.ObjPermissions += (int)enPermissions.ListClients;

                    else
                        this.ObjPermissions += (int)enPermissions.ListClients + (int)enPermissions.ClientsManagement;

                    return;
                case "FindClient":
                    if (IsMainItemSelected(enPermissions.ClientsManagement))
                        this.ObjPermissions += (int)enPermissions.FindClient;

                    else
                        this.ObjPermissions += (int)enPermissions.FindClient + (int)enPermissions.ClientsManagement;
                    return;

                    //AddUser = 512, DeleteUser = 1024, UpdateUser = 2048, ListUsers = 4096, FindUser = 8192,
                case "AddUser":
                    if (IsMainItemSelected(enPermissions.UsersManagement))
                        this.ObjPermissions += (int)enPermissions.AddUser;

                    else
                        this.ObjPermissions += (int)enPermissions.AddUser + (int)enPermissions.UsersManagement;
                    return;

                case "DeleteUser":

                    if (IsMainItemSelected(enPermissions.UsersManagement))
                        this.ObjPermissions += (int)enPermissions.DeleteUser;
                    else
                        this.ObjPermissions += (int)enPermissions.DeleteUser + (int)enPermissions.UsersManagement;

                    return;

                case "UpdateUser":
                    if (IsMainItemSelected(enPermissions.UsersManagement))
                        this.ObjPermissions += (int)enPermissions.UpdateUser;
                    else
                        this.ObjPermissions += (int)enPermissions.UpdateUser + (int)enPermissions.UsersManagement;
                    return;

                case "ListUsers":
                    if (IsMainItemSelected(enPermissions.UsersManagement))
                        this.ObjPermissions += (int)enPermissions.ListUsers;
                    else
                        this.ObjPermissions += (int)enPermissions.ListUsers + (int)enPermissions.UsersManagement;
                    return;

                case "FindUser":
                    if (IsMainItemSelected(enPermissions.UsersManagement))
                        this.ObjPermissions += (int)enPermissions.FindUser;
                    else
                        this.ObjPermissions += (int)enPermissions.FindUser + (int)enPermissions.UsersManagement;
                    return;
                //AddCurrency = 16384, UpdateCurrency = 32768, ListCurrencies = 65536, FindCurrency = 131072, ExchangeCurrency = 262144, 
                //ExchangeLog = 524288,
                case "AddCurrency":
                    if (IsMainItemSelected(enPermissions.CurrencyExchange))
                        this.ObjPermissions += (int)enPermissions.AddCurrency;
                    else
                        this.ObjPermissions += (int)enPermissions.AddCurrency + (int)enPermissions.CurrencyExchange;
                    return;
                case "UpdateCurrency":
                    if (IsMainItemSelected(enPermissions.CurrencyExchange))
                        this.ObjPermissions += (int)enPermissions.UpdateCurrency;
                    else
                        this.ObjPermissions += (int)enPermissions.UpdateCurrency + (int)enPermissions.CurrencyExchange;
                    return;
                case "ListCurrencies":
                    if (IsMainItemSelected(enPermissions.CurrencyExchange))
                        this.ObjPermissions += (int)enPermissions.ListCurrencies;
                    else
                        this.ObjPermissions += (int)enPermissions.ListCurrencies + (int)enPermissions.CurrencyExchange;
                    return;
                case "FindCurrency":
                    if (IsMainItemSelected(enPermissions.CurrencyExchange))
                        this.ObjPermissions += (int)enPermissions.FindCurrency;
                    else
                        this.ObjPermissions += (int)enPermissions.FindCurrency + (int)enPermissions.CurrencyExchange;
                    return;
                case "ExchangeCurrency":
                    if (IsMainItemSelected(enPermissions.CurrencyExchange))
                        this.ObjPermissions += (int)enPermissions.ExchangeCurrency;
                    else
                        this.ObjPermissions += (int)enPermissions.ExchangeCurrency + (int)enPermissions.CurrencyExchange;
                    return;
                case "ExchangeLog":
                    if (IsMainItemSelected(enPermissions.CurrencyExchange))
                        this.ObjPermissions += (int)enPermissions.ExchangeLog;
                    else
                        this.ObjPermissions += (int)enPermissions.ExchangeLog + (int)enPermissions.CurrencyExchange;
                    return;
                //Deposit = 1048576, WithDraw = 2097152, ListBalances = 4194304, Transfer = 8388608, TransferLog = 16777216
                case "Deposit":
                    if (IsMainItemSelected(enPermissions.Transactions))
                        this.ObjPermissions += (int)enPermissions.Deposit;
                    else
                        this.ObjPermissions += (int)enPermissions.Deposit + (int)enPermissions.Transactions;
                    return;
                case "WithDraw":
                    if (IsMainItemSelected(enPermissions.Transactions))
                        this.ObjPermissions += (int)enPermissions.WithDraw;
                    else
                        this.ObjPermissions += (int)enPermissions.WithDraw + (int)enPermissions.Transactions;
                    return;
                case "ListBalances":
                    if (IsMainItemSelected(enPermissions.Transactions))
                        this.ObjPermissions += (int)enPermissions.ListBalances;
                    else
                        this.ObjPermissions += (int)enPermissions.ListBalances + (int)enPermissions.Transactions;
                    return;
                case "Transfer":
                    if (IsMainItemSelected(enPermissions.Transactions))
                        this.ObjPermissions += (int)enPermissions.Transfer;
                    else
                        this.ObjPermissions += (int)enPermissions.Transfer + (int)enPermissions.Transactions;
                    return;
                case "TransferLog":
                    if (IsMainItemSelected(enPermissions.Transactions))
                        this.ObjPermissions += (int)enPermissions.TransferLog;
                    else
                        this.ObjPermissions += (int)enPermissions.TransferLog + (int)enPermissions.Transactions;
                    return;

                default:
                    return;
            }

        }
        */

        private void CheckAllMainChkBoxes()
        {
            chkbClientsManagement.Checked = true;
            chkbUsersManagement.Checked = true;
            chkbTransactionsManagement.Checked = true;
            chkbCurrencyExchange.Checked = true;
            
        }


        private void CheckAllTransactionsChkBoxes()
        {
            chkbDeposit.Checked = true;
            chkbWithdraw.Checked = true;
            chkbTransfer.Checked = true;
            chkbTransferLog.Checked = true;
            chkbListBalances.Checked = true;
        }


        private void CheckAllCurrenciesChkBoxes()
        {
            chkbAddCurrency.Checked = true;
            chkbFindCurrency.Checked = true;
            chkbUpdateCurrency.Checked = true;
            chkbListCurrencies.Checked = true;
            chkbExchange.Checked = true;
            chkbExchangeLog.Checked = true;
        }

        private void CheckAllUsersChkBoxes()
        {
            chkbAddUser.Checked = true;
            chkbDeleteUser.Checked = true;
            chkbFindUser.Checked = true;    
            chkbUpdateUser.Checked = true;
            chkbListUsers.Checked = true;

        }

        private void CheckAllClientsChkBoxes()
        {
            chkbAddClient.Checked = true;
            chkbDeleteClient.Checked = true;
            chkbFindClient.Checked = true;
            chkbUpdateClient.Checked = true;
            chkbListClients.Checked = true;
        }


        private void CheckAllChkBoxes()
        {
            CheckAllMainChkBoxes();
            CheckAllUsersChkBoxes();
            CheckAllClientsChkBoxes();
            CheckAllCurrenciesChkBoxes();
            CheckAllTransactionsChkBoxes();
        }

        private void UnCheckAllChkBoxes()
        {


        }




        private void DisableAllChkBoxesGroups()
        {
            gbClients.Enabled = false;
            gbUsers.Enabled = false;
            gbCurrencies.Enabled = false;
            gbTransactions.Enabled = false;
        }

        private void EnableAllChkBoxesGroups()
        {
            gbClients.Enabled = true;
            gbUsers.Enabled = true;
            gbCurrencies.Enabled = true;
            gbTransactions.Enabled = true;
        }

        public frmPermissions()
        {
            InitializeComponent();
   
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void chkbFullAccess_CheckedChanged(object sender, EventArgs e)
        {
            ObjPermissions.MainPermissions = (int)enMainPermissions.FullAceess; 
            
            CheckBox FullAcceesscheckBox = (CheckBox)sender;

            if (FullAcceesscheckBox.Checked == true)
            {
                CheckAllChkBoxes();
                DisableAllChkBoxesGroups();
            }
            else
            {
                EnableAllChkBoxesGroups();
            }



        }


        private void chkbClientsManagementFullAccess_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbFullAcess.Checked == true)
            {
                return;
            }


            ObjPermissions.ClientsManagementPermissions = (int)enClientsManagementPermissions.ClientsManagementFullAceess;
            CheckAllClientsChkBoxes();
        }

        private void chkbUsersManagementFullAccess_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbFullAcess.Checked == true)
            {
                return;
            }

            ObjPermissions.UsersManagementPermissions = (int)enUsersManagementPermissions.UsersManagementFullAceess;
            CheckAllUsersChkBoxes();
        }

        private void chkbCurrencyExchangeFullAccess_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbFullAcess.Checked == true)
            {
                return;
            }

            ObjPermissions.CurrenciesManagementPermissions = (int)enCurrenciesManagementPermissions.CurrenciesManagementFullAceess;
            CheckAllCurrenciesChkBoxes();
        }

        private void chkbTransactionsManagementFullAccess_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbFullAcess.Checked == true)
            {
                return;
            }

            ObjPermissions.TransactionsManagementPermissions = (int)enTransactionsManagementPermissions.TransactionsManagementFullAccess;
            CheckAllTransactionsChkBoxes();
        }


        private void chkbClientsItems_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbFullAcess.Checked == true || chkbClientsManagement.Checked == true)
            {
                return;
            }

            CheckBox chkb = (CheckBox)sender;
            

        }

        private void chkbUsersItems_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbFullAcess.Checked == true || chkbUsersManagement.Checked == true)
            {
                return;
            }

            CheckBox chkb = (CheckBox)sender;
           
        }

        private void chkbCurrenciesItems_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbFullAcess.Checked == true || chkbCurrencyExchange.Checked == true)
            {
                return;
            }

            CheckBox chkb = (CheckBox)sender;
            
        }


        private void chkbTransactionsItems_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbFullAcess.Checked == true || chkbTransactionsManagement.Checked == true)
            {
                return;
            }

            CheckBox chkb = (CheckBox)sender;
            
        }

        
    }
}
