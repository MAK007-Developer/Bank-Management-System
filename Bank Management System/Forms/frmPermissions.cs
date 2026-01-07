using Bank_Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Management_System.Forms
{
    public partial class frmPermissions : Form
    {

        byte OneTimeSetPermissions = 1;
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

        public clsPermissionsBLL PermissionsInfo = new clsPermissionsBLL();

        public frmPermissions()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trvPermissions.ExpandAll();
            trvPermissions.Focus();

        }

        private void SetFullAccessPermissions()
        {
            PermissionsInfo.MainPermissions = (int)enMainPermissions.FullAceess;
            PermissionsInfo.ClientsManagementPermissions = (int)enClientsManagementPermissions.ClientsManagementFullAceess;
            PermissionsInfo.UsersManagementPermissions = (int)enUsersManagementPermissions.UsersManagementFullAceess;
            PermissionsInfo.CurrenciesManagementPermissions = (int)enCurrenciesManagementPermissions.CurrenciesManagementFullAceess;
            PermissionsInfo.TransactionsManagementPermissions = (int)enTransactionsManagementPermissions.TransactionsManagementFullAccess;
        }

        private void UnSetFullAccessPermissions()
        {
            PermissionsInfo.MainPermissions = 0;
            PermissionsInfo.ClientsManagementPermissions = 0;
            PermissionsInfo.UsersManagementPermissions = 0;
            PermissionsInfo.CurrenciesManagementPermissions = 0;
            PermissionsInfo.TransactionsManagementPermissions = 0;
        }




        //Clients Specific Sections
        private void SetClientsManagementPermissions()
        {
            PermissionsInfo.MainPermissions += (int)enMainPermissions.ClientsManagement;
            PermissionsInfo.ClientsManagementPermissions = (int)enClientsManagementPermissions.ClientsManagementFullAceess;
        }

        private void UnSetClientsManagementPermissions()
        {
            PermissionsInfo.MainPermissions = 0;
            PermissionsInfo.ClientsManagementPermissions = 0;
        }


        private void SetAddClientPermissions()
        {
            PermissionsInfo.MainPermissions += (int)enMainPermissions.ClientsManagement;
            PermissionsInfo.ClientsManagementPermissions += (int)enClientsManagementPermissions.AddClient;
        }

        private void UnSetAddClientPermissions()
        {
            if (PermissionsInfo.ClientsManagementPermissions != 0)
            {
                PermissionsInfo.ClientsManagementPermissions -= (int)enClientsManagementPermissions.AddClient;
            }
            else
            {
                PermissionsInfo.MainPermissions = 0;
                PermissionsInfo.ClientsManagementPermissions = 0;
            }
            
        }


        private void SetDeleteClientPermissions()
        {
            PermissionsInfo.MainPermissions = (int)enMainPermissions.ClientsManagement;
            PermissionsInfo.ClientsManagementPermissions = (int)enClientsManagementPermissions.DeleteClient;
        }

        private void UnSetDeleteClientPermissions()
        {
            PermissionsInfo.MainPermissions = 0;
            PermissionsInfo.ClientsManagementPermissions = 0;
        }


        private void SetUpdateClientPermissions()
        {

            PermissionsInfo.MainPermissions = (int)enMainPermissions.ClientsManagement;
            PermissionsInfo.ClientsManagementPermissions = (int)enClientsManagementPermissions.UpdateClient;

        }

        private void UnSetUpdateClientPermissions()
        {

            PermissionsInfo.MainPermissions = 0;
            PermissionsInfo.ClientsManagementPermissions = 0;

        }


        private void SetListClientsPermissions()
        {
            PermissionsInfo.MainPermissions = (int)enMainPermissions.ClientsManagement;
            PermissionsInfo.ClientsManagementPermissions = (int)enClientsManagementPermissions.ListClients;
        }

        private void UnSetListClientsPermissions()
        {
            PermissionsInfo.MainPermissions = 0;
            PermissionsInfo.ClientsManagementPermissions = 0;
        }


        private void SetFindClientPermissions()
        {
            PermissionsInfo.MainPermissions = (int)enMainPermissions.ClientsManagement;
            PermissionsInfo.ClientsManagementPermissions = (int)enClientsManagementPermissions.FindClient;
        }

        private void UnSetFindClientPermissions()
        {
            PermissionsInfo.MainPermissions = 0;
            PermissionsInfo.ClientsManagementPermissions = 0;
        }


        //Users Specific Sections
        private void SetUsersManagementPermissions()
        {
            PermissionsInfo.MainPermissions += (int)enMainPermissions.UsersManagement;
            PermissionsInfo.UsersManagementPermissions = (int)enUsersManagementPermissions.UsersManagementFullAceess;
        }

        private void UnSetUsersManagementPermissions()
        {
            PermissionsInfo.MainPermissions = 0;
            PermissionsInfo.UsersManagementPermissions = 0;
        }

        private void SetAddUserPermissions()
        {
            PermissionsInfo.MainPermissions = (int)enMainPermissions.UsersManagement;
            PermissionsInfo.UsersManagementPermissions = (int)enUsersManagementPermissions.AddUser;
        }

        private void UnSetAddUserPermissions()
        {
            PermissionsInfo.MainPermissions = 0;
            PermissionsInfo.UsersManagementPermissions = 0;
        }


        private void SetDeleteUserPermissions()
        {
            PermissionsInfo.MainPermissions = (int)enMainPermissions.ClientsManagement;
            PermissionsInfo.ClientsManagementPermissions = (int)enClientsManagementPermissions.DeleteClient;
        }

        private void UnSetDeleteUserPermissions()
        {
            PermissionsInfo.MainPermissions = 0;
            PermissionsInfo.ClientsManagementPermissions = 0;
        }


        private void SetUpdateUserPermissions()
        {

            PermissionsInfo.MainPermissions = (int)enMainPermissions.ClientsManagement;
            PermissionsInfo.ClientsManagementPermissions = (int)enClientsManagementPermissions.UpdateClient;

        }

        private void UnSetUpdateUserPermissions()
        {

            PermissionsInfo.MainPermissions = 0;
            PermissionsInfo.ClientsManagementPermissions = 0;

        }


        private void SetListUsersPermissions()
        {
            PermissionsInfo.MainPermissions = (int)enMainPermissions.ClientsManagement;
            PermissionsInfo.ClientsManagementPermissions = (int)enClientsManagementPermissions.ListClients;
        }

        private void UnSetListUsersPermissions()
        {
            PermissionsInfo.MainPermissions = 0;
            PermissionsInfo.ClientsManagementPermissions = 0;
        }


        private void SetFindUserPermissions()
        {
            PermissionsInfo.MainPermissions = (int)enMainPermissions.ClientsManagement;
            PermissionsInfo.ClientsManagementPermissions = (int)enClientsManagementPermissions.FindClient;
        }

        private void UnSetFindUserPermissions()
        {
            PermissionsInfo.MainPermissions = 0;
            PermissionsInfo.ClientsManagementPermissions = 0;
        }



        //Currncies Specific Sections
        private void SetCurrenciesManagementPermissions()
        {
            PermissionsInfo.MainPermissions = (int)enMainPermissions.CurrencyExchange;
            PermissionsInfo.CurrenciesManagementPermissions = (int)enCurrenciesManagementPermissions.CurrenciesManagementFullAceess;
        }

        private void UnSetCurrenciesManagementPermissions()
        {
            PermissionsInfo.MainPermissions = 0;
            PermissionsInfo.CurrenciesManagementPermissions = 0;
        }

        private void SetAddCurrencyPermissions()
        {
            PermissionsInfo.MainPermissions = (int)enMainPermissions.CurrencyExchange;
            PermissionsInfo.CurrenciesManagementPermissions = (int)enCurrenciesManagementPermissions.AddCurrency;
        }

        private void UnSetAddCurrencyPermissions()
        {
            PermissionsInfo.MainPermissions = 0;
            PermissionsInfo.CurrenciesManagementPermissions = 0;
        }


        private void SetFindCurrencyPermissions()
        {
            PermissionsInfo.MainPermissions = (int)enMainPermissions.CurrencyExchange;
            PermissionsInfo.CurrenciesManagementPermissions = (int)enCurrenciesManagementPermissions.FindCurrency;
        }

        private void UnSetFindCurrencyPermissions()
        {
            PermissionsInfo.MainPermissions = 0;
            PermissionsInfo.CurrenciesManagementPermissions = 0;
        }


        private void SetUpdateCurrencyPermissions()
        {

            PermissionsInfo.MainPermissions = (int)enMainPermissions.CurrencyExchange;
            PermissionsInfo.CurrenciesManagementPermissions = (int)enCurrenciesManagementPermissions.UpdateCurrency;

        }

        private void UnSetUpdateCurrencyPermissions()
        {

            PermissionsInfo.MainPermissions = 0;
            PermissionsInfo.CurrenciesManagementPermissions = 0;

        }


        private void SetListCurrenciesPermissions()
        {
            PermissionsInfo.MainPermissions = (int)enMainPermissions.CurrencyExchange;
            PermissionsInfo.CurrenciesManagementPermissions = (int)enCurrenciesManagementPermissions.ListCurrencies;
        }

        private void UnSetListCurrenciesPermissions()
        {
            PermissionsInfo.MainPermissions = 0;
            PermissionsInfo.CurrenciesManagementPermissions = 0;
        }


        private void SetExchangeCurrencyPermissions()
        {
            PermissionsInfo.MainPermissions = (int)enMainPermissions.CurrencyExchange;
            PermissionsInfo.CurrenciesManagementPermissions = (int)enCurrenciesManagementPermissions.ExchangeCurrency;
        }

        private void UnSetExchangeCurrencyPermissions()
        {
            PermissionsInfo.MainPermissions = 0;
            PermissionsInfo.CurrenciesManagementPermissions = 0;
        }

        private void SetExchangeLogPermissions()
        {
            PermissionsInfo.MainPermissions = (int)enMainPermissions.CurrencyExchange;
            PermissionsInfo.CurrenciesManagementPermissions = (int)enCurrenciesManagementPermissions.ExchangeLog;
        }

        private void UnSetExchangeLogPermissions()
        {
            PermissionsInfo.MainPermissions = 0;
            PermissionsInfo.CurrenciesManagementPermissions = 0;
        }


        //Transactions Specific Sections
        private void SetTransactionsManagementPermissions()
        {
            PermissionsInfo.MainPermissions = (int)enMainPermissions.Transactions;
            PermissionsInfo.TransactionsManagementPermissions = (int)enTransactionsManagementPermissions.TransactionsManagementFullAccess;
        }

        private void UnSetTransactionsManagementPermissions()
        {
            PermissionsInfo.MainPermissions = 0;
            PermissionsInfo.TransactionsManagementPermissions = 0;
        }

        private void SetDepositPermissions()
        {
            PermissionsInfo.MainPermissions = (int)enMainPermissions.Transactions;
            PermissionsInfo.TransactionsManagementPermissions = (int)enTransactionsManagementPermissions.Deposit;
        }

        private void UnSetDepositPermissions()
        {
            PermissionsInfo.MainPermissions = 0;
            PermissionsInfo.TransactionsManagementPermissions = 0;
        }

        private void SetWithdrawPermissions()
        {
            PermissionsInfo.MainPermissions = (int)enMainPermissions.Transactions;
            PermissionsInfo.TransactionsManagementPermissions = (int)enTransactionsManagementPermissions.WithDraw;
        }

        private void UnSetWithdrawPermissions()
        {
            PermissionsInfo.MainPermissions = 0;
            PermissionsInfo.TransactionsManagementPermissions = 0;
        }

        private void SetListBalancesPermissions()
        {
            PermissionsInfo.MainPermissions = (int)enMainPermissions.Transactions;
            PermissionsInfo.TransactionsManagementPermissions = (int)enTransactionsManagementPermissions.ListBalances;
        }

        private void UnSetListBalancesPermissions()
        {
            PermissionsInfo.MainPermissions = 0;
            PermissionsInfo.TransactionsManagementPermissions = 0;
        }

        private void SetTransferPermissions()
        {
            PermissionsInfo.MainPermissions = (int)enMainPermissions.Transactions;
            PermissionsInfo.TransactionsManagementPermissions = (int)enTransactionsManagementPermissions.Transfer;
        }

        private void UnSetTransferPermissions()
        {
            PermissionsInfo.MainPermissions = 0;
            PermissionsInfo.TransactionsManagementPermissions = 0;
        }

        private void SetTransferLogPermissions()
        {
            PermissionsInfo.MainPermissions = (int)enMainPermissions.Transactions;
            PermissionsInfo.TransactionsManagementPermissions = (int)enTransactionsManagementPermissions.TransferLog;
        }

        private void UnSetTransferLogPermissions()
        {
            PermissionsInfo.MainPermissions = 0;
            PermissionsInfo.TransactionsManagementPermissions = 0;
        }





        private void SetPermissions(TreeNode CheckedNode)
        {
            switch (CheckedNode.Text)
            {
                //Main Permissions
                case "FullAccess":
                    if (CheckedNode.Checked == false)
                    {
                        UnSetFullAccessPermissions();
                        return;
                    }
                    SetFullAccessPermissions();
                    return;

                case "ClientsManagement":
                    if (CheckedNode.Parent.Checked == true)
                    {
                        return;
                    }
                    if (CheckedNode.Checked == false)
                    {
                        UnSetClientsManagementPermissions();
                        return;
                    }

                    SetClientsManagementPermissions();
                    return;

                case "UsersManagement":
                    if (CheckedNode.Parent.Checked == true)
                    {
                        return;
                    }
                    if (CheckedNode.Checked == false)
                    {
                        UnSetUsersManagementPermissions();
                        return;
                    }
                    SetUsersManagementPermissions();
                    return;

                case "CurrencyExchange":
                    if (CheckedNode.Parent.Checked == true)
                    {
                        return;
                    }
                    if (CheckedNode.Checked == false)
                    {
                        UnSetCurrenciesManagementPermissions();
                        return;
                    }
                    SetCurrenciesManagementPermissions();
                    return;

                case "Transactions":
                    if (CheckedNode.Parent.Checked == true)
                    {
                        return;
                    }
                    if (CheckedNode.Checked == false)
                    {
                        UnSetTransactionsManagementPermissions();
                        return;
                    }
                    SetTransactionsManagementPermissions();
                    return;


                //Underlying Sections

                //Clients
                case "AddClient":
                    if (CheckedNode.Parent.Checked == true)
                    {
                        return;
                    }
                    if (CheckedNode.Checked == false)
                    {
                        UnSetAddClientPermissions();
                        return;
                    }
                    SetAddClientPermissions();
                    return;

                case "DeleteClient":
                    if (CheckedNode.Parent.Checked == true )
                    {
                        return;
                    }
                    if (CheckedNode.Checked == false)
                    {
                        UnSetDeleteClientPermissions();
                        return;
                    }
                    SetDeleteClientPermissions();
                    return;

                case "UpdateClient":
                    if (CheckedNode.Parent.Checked == true)
                    {
                        return;
                    }
                    if (CheckedNode.Checked == false)
                    {
                        UnSetUpdateClientPermissions();
                        return;
                    }
                    SetUpdateClientPermissions();
                    return;

                case "ListClients":
                    if (CheckedNode.Parent.Checked == true)
                    {
                        return;
                    }
                    if (CheckedNode.Checked == false)
                    {
                        UnSetListClientsPermissions();
                        return;
                    }
                    SetListClientsPermissions();

                    
                    return;

                case "FindClient":
                    if (CheckedNode.Parent.Checked == true)
                    {
                        return;
                    }
                    if (CheckedNode.Checked == false)
                    {
                        UnSetFindClientPermissions();
                        return;
                    }
                    SetFindClientPermissions();
                    return;



                //Users
                case "AddUser":
                    if (CheckedNode.Parent.Checked == true)
                    {
                        return;
                    }
                    if (CheckedNode.Checked == false)
                    {
                        UnSetAddUserPermissions();
                        return;
                    }
                    SetAddUserPermissions();
                    return;

                case "DeleteUser":
                    if (CheckedNode.Parent.Checked == true)
                    {
                        return;
                    }
                    if (CheckedNode.Checked == false)
                    {
                        UnSetDeleteUserPermissions();
                        return;
                    }
                    SetDeleteUserPermissions();

                    PermissionsInfo.MainPermissions = (int)enMainPermissions.UsersManagement;
                    PermissionsInfo.UsersManagementPermissions = (int)enUsersManagementPermissions.DeleteUser;
                    return;

                case "UpdateUser":
                    if (CheckedNode.Parent.Checked == true)
                    {
                        return;
                    }
                    if (CheckedNode.Checked == false)
                    {
                        UnSetUpdateUserPermissions();
                        return;
                    }
                    SetUpdateUserPermissions();

                    PermissionsInfo.MainPermissions = (int)enMainPermissions.UsersManagement;
                    PermissionsInfo.UsersManagementPermissions = (int)enUsersManagementPermissions.UpdateUser;
                    return;

                case "ListUsers":
                    if (CheckedNode.Parent.Checked == true)
                    {
                        return;
                    }
                    if (CheckedNode.Checked == false)
                    {
                        UnSetListUsersPermissions();
                        return;
                    }
                    SetListUsersPermissions();
                    PermissionsInfo.MainPermissions = (int)enMainPermissions.UsersManagement;
                    PermissionsInfo.UsersManagementPermissions = (int)enUsersManagementPermissions.ListUsers;
                    return;

                case "FindUser":
                    if (CheckedNode.Parent.Checked == true)
                    {
                        return;
                    }
                    if (CheckedNode.Checked == false)
                    {
                        UnSetFindUserPermissions();
                        return;
                    }
                    SetFindUserPermissions();
                    PermissionsInfo.MainPermissions = (int)enMainPermissions.UsersManagement;
                    PermissionsInfo.UsersManagementPermissions = (int)enUsersManagementPermissions.FindUser;
                    return;


                //Currencies
                case "AddCurrency":
                    if (CheckedNode.Parent.Checked == true)
                    {
                        return;
                    }
                    if (CheckedNode.Checked == false)
                    {
                        UnSetAddCurrencyPermissions();
                        return;
                    }
                    SetAddCurrencyPermissions();
                    
                    return;

                case "ExchangeCurrency":
                    if (CheckedNode.Parent.Checked == true)
                    {
                        return;
                    }
                    if (CheckedNode.Checked == false)
                    {
                        UnSetExchangeCurrencyPermissions();
                        return;
                    }
                    SetExchangeCurrencyPermissions();
                    
                    return;

                case "UpdateCurrency":
                    if (CheckedNode.Parent.Checked == true)
                    {
                        return;
                    }
                    if (CheckedNode.Checked == false)
                    {
                        UnSetUpdateCurrencyPermissions();
                        return;
                    }
                    SetUpdateCurrencyPermissions();
                    PermissionsInfo.MainPermissions = (int)enMainPermissions.CurrencyExchange;
                    PermissionsInfo.CurrenciesManagementPermissions = (int)enCurrenciesManagementPermissions.UpdateCurrency;
                    return;

                case "ListCurrencies":
                    if (CheckedNode.Parent.Checked == true)
                    {
                        return;
                    }
                    if (CheckedNode.Checked == false)
                    {
                        UnSetListCurrenciesPermissions();
                        return;
                    }
                    SetListCurrenciesPermissions();
                    
                    return;

                case "FindCurrency":
                    if (CheckedNode.Parent.Checked == true)
                    {
                        return;
                    }
                    if (CheckedNode.Checked == false)
                    {
                        UnSetFindCurrencyPermissions();
                        return;
                    }
                    SetFindCurrencyPermissions();
                    
                    return;

                case "ExchangeLog":
                    if (CheckedNode.Parent.Checked == true)
                    {
                        return;
                    }
                    if (CheckedNode.Checked == false)
                    {
                        UnSetExchangeLogPermissions();
                        return;
                    }
                    SetExchangeLogPermissions();
                    
                    return;

                 //Transactions
                case "Deposit":
                    if (CheckedNode.Parent.Checked == true)
                    {
                        return;
                    }
                    if (CheckedNode.Checked == false)
                    {
                        UnSetDepositPermissions();
                        return;
                    }
                    SetDepositPermissions();
                    
                    return;

                case "Withdraw":
                    if (CheckedNode.Parent.Checked == true)
                    {
                        return;
                    }
                    if (CheckedNode.Checked == false)
                    {
                        UnSetWithdrawPermissions();
                        return;
                    }
                    SetWithdrawPermissions();
                    
                    return;

                case "ListBalances":
                    if (CheckedNode.Parent.Checked == true)
                    {
                        return;
                    }
                    if (CheckedNode.Checked == false)
                    {
                        UnSetListBalancesPermissions();
                        return;
                    }
                    SetListBalancesPermissions();
                    
                    return;

                case "Transfer":
                    if (CheckedNode.Parent.Checked == true)
                    {
                        return;
                    }
                    if (CheckedNode.Checked == false)
                    {
                        UnSetTransferPermissions();
                        return;
                    }
                    SetTransferPermissions();
                    
                    return;

                case "TransferLog":
                    if (CheckedNode.Parent.Checked == true)
                    {
                        return;
                    }
                    if (CheckedNode.Checked == false)
                    {
                        UnSetTransferLogPermissions();
                        return;
                    }
                    SetTransferLogPermissions();
                    
                    return;


                default:
                    return;
            }

        }

        private void trvPermissions_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeNode Checkednode = e.Node;
            //Checkednode.Text;

            SetPermissions(Checkednode);
            
            CheckTreeViewNode(e.Node, e.Node.Checked);  
        }


        private void CheckTreeViewNode(TreeNode node, bool isChecked)
        {
            foreach (TreeNode item in node.Nodes)
            {
                item.Checked = isChecked;

                if (item.Nodes.Count > 0)
                {
                    this.CheckTreeViewNode(item, isChecked);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PermissionsInfo.UpdatePermissionsString();

            MessageBox.Show(PermissionsInfo.FullPermissionStr.ToString());
        }
    }
}
