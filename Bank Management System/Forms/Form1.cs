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
    public partial class Form1 : Form
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

        public clsPermissionsBLL ObjPermissions = new clsPermissionsBLL();
        public Form1()
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
            ObjPermissions.MainPermissions = (int)enMainPermissions.FullAceess;
            ObjPermissions.ClientsManagementPermissions = (int)enClientsManagementPermissions.ClientsManagementFullAceess;
            ObjPermissions.UsersManagementPermissions = (int)enUsersManagementPermissions.UsersManagementFullAceess;
            ObjPermissions.CurrenciesManagementPermissions = (int)enCurrenciesManagementPermissions.CurrenciesManagementFullAceess;
            ObjPermissions.TransactionsManagementPermissions = (int)enTransactionsManagementPermissions.TransactionsManagementFullAccess;
        }

        private void UnSetFullAccessPermissions()
        {
            ObjPermissions.MainPermissions = 0;
            ObjPermissions.ClientsManagementPermissions = 0;
            ObjPermissions.UsersManagementPermissions = 0;
            ObjPermissions.CurrenciesManagementPermissions = 0;
            ObjPermissions.TransactionsManagementPermissions = 0;
        }




        //Clients Specific Sections
        private void SetClientsManagementPermissions()
        {
            ObjPermissions.MainPermissions += (int)enMainPermissions.ClientsManagement;
            ObjPermissions.ClientsManagementPermissions = (int)enClientsManagementPermissions.ClientsManagementFullAceess;
        }

        private void UnSetClientsManagementPermissions()
        {
            ObjPermissions.MainPermissions = 0;
            ObjPermissions.ClientsManagementPermissions = 0;
        }


        private void SetAddClientPermissions()
        {
            ObjPermissions.MainPermissions += (int)enMainPermissions.ClientsManagement;
            ObjPermissions.ClientsManagementPermissions += (int)enClientsManagementPermissions.AddClient;
        }

        private void UnSetAddClientPermissions()
        {
            if (ObjPermissions.ClientsManagementPermissions != 0)
            {
                ObjPermissions.ClientsManagementPermissions -= (int)enClientsManagementPermissions.AddClient;
            }
            else
            {
                ObjPermissions.MainPermissions = 0;
                ObjPermissions.ClientsManagementPermissions = 0;
            }
            
        }


        private void SetDeleteClientPermissions()
        {
            ObjPermissions.MainPermissions = (int)enMainPermissions.ClientsManagement;
            ObjPermissions.ClientsManagementPermissions = (int)enClientsManagementPermissions.DeleteClient;
        }

        private void UnSetDeleteClientPermissions()
        {
            ObjPermissions.MainPermissions = 0;
            ObjPermissions.ClientsManagementPermissions = 0;
        }


        private void SetUpdateClientPermissions()
        {

            ObjPermissions.MainPermissions = (int)enMainPermissions.ClientsManagement;
            ObjPermissions.ClientsManagementPermissions = (int)enClientsManagementPermissions.UpdateClient;

        }

        private void UnSetUpdateClientPermissions()
        {

            ObjPermissions.MainPermissions = 0;
            ObjPermissions.ClientsManagementPermissions = 0;

        }


        private void SetListClientsPermissions()
        {
            ObjPermissions.MainPermissions = (int)enMainPermissions.ClientsManagement;
            ObjPermissions.ClientsManagementPermissions = (int)enClientsManagementPermissions.ListClients;
        }

        private void UnSetListClientsPermissions()
        {
            ObjPermissions.MainPermissions = 0;
            ObjPermissions.ClientsManagementPermissions = 0;
        }


        private void SetFindClientPermissions()
        {
            ObjPermissions.MainPermissions = (int)enMainPermissions.ClientsManagement;
            ObjPermissions.ClientsManagementPermissions = (int)enClientsManagementPermissions.FindClient;
        }

        private void UnSetFindClientPermissions()
        {
            ObjPermissions.MainPermissions = 0;
            ObjPermissions.ClientsManagementPermissions = 0;
        }


        //Users Specific Sections
        private void SetUsersManagementPermissions()
        {
            ObjPermissions.MainPermissions += (int)enMainPermissions.UsersManagement;
            ObjPermissions.UsersManagementPermissions = (int)enUsersManagementPermissions.UsersManagementFullAceess;
        }

        private void UnSetUsersManagementPermissions()
        {
            ObjPermissions.MainPermissions = 0;
            ObjPermissions.UsersManagementPermissions = 0;
        }

        private void SetAddUserPermissions()
        {
            ObjPermissions.MainPermissions = (int)enMainPermissions.UsersManagement;
            ObjPermissions.UsersManagementPermissions = (int)enUsersManagementPermissions.AddUser;
        }

        private void UnSetAddUserPermissions()
        {
            ObjPermissions.MainPermissions = 0;
            ObjPermissions.UsersManagementPermissions = 0;
        }


        private void SetDeleteUserPermissions()
        {
            ObjPermissions.MainPermissions = (int)enMainPermissions.ClientsManagement;
            ObjPermissions.ClientsManagementPermissions = (int)enClientsManagementPermissions.DeleteClient;
        }

        private void UnSetDeleteUserPermissions()
        {
            ObjPermissions.MainPermissions = 0;
            ObjPermissions.ClientsManagementPermissions = 0;
        }


        private void SetUpdateUserPermissions()
        {

            ObjPermissions.MainPermissions = (int)enMainPermissions.ClientsManagement;
            ObjPermissions.ClientsManagementPermissions = (int)enClientsManagementPermissions.UpdateClient;

        }

        private void UnSetUpdateUserPermissions()
        {

            ObjPermissions.MainPermissions = 0;
            ObjPermissions.ClientsManagementPermissions = 0;

        }


        private void SetListUsersPermissions()
        {
            ObjPermissions.MainPermissions = (int)enMainPermissions.ClientsManagement;
            ObjPermissions.ClientsManagementPermissions = (int)enClientsManagementPermissions.ListClients;
        }

        private void UnSetListUsersPermissions()
        {
            ObjPermissions.MainPermissions = 0;
            ObjPermissions.ClientsManagementPermissions = 0;
        }


        private void SetFindUserPermissions()
        {
            ObjPermissions.MainPermissions = (int)enMainPermissions.ClientsManagement;
            ObjPermissions.ClientsManagementPermissions = (int)enClientsManagementPermissions.FindClient;
        }

        private void UnSetFindUserPermissions()
        {
            ObjPermissions.MainPermissions = 0;
            ObjPermissions.ClientsManagementPermissions = 0;
        }



        //Currncies Specific Sections
        private void SetCurrenciesManagementPermissions()
        {
            ObjPermissions.MainPermissions = (int)enMainPermissions.CurrencyExchange;
            ObjPermissions.CurrenciesManagementPermissions = (int)enCurrenciesManagementPermissions.CurrenciesManagementFullAceess;
        }

        private void UnSetCurrenciesManagementPermissions()
        {
            ObjPermissions.MainPermissions = 0;
            ObjPermissions.CurrenciesManagementPermissions = 0;
        }

        private void SetAddCurrencyPermissions()
        {
            ObjPermissions.MainPermissions = (int)enMainPermissions.CurrencyExchange;
            ObjPermissions.CurrenciesManagementPermissions = (int)enCurrenciesManagementPermissions.AddCurrency;
        }

        private void UnSetAddCurrencyPermissions()
        {
            ObjPermissions.MainPermissions = 0;
            ObjPermissions.CurrenciesManagementPermissions = 0;
        }


        private void SetFindCurrencyPermissions()
        {
            ObjPermissions.MainPermissions = (int)enMainPermissions.CurrencyExchange;
            ObjPermissions.CurrenciesManagementPermissions = (int)enCurrenciesManagementPermissions.FindCurrency;
        }

        private void UnSetFindCurrencyPermissions()
        {
            ObjPermissions.MainPermissions = 0;
            ObjPermissions.CurrenciesManagementPermissions = 0;
        }


        private void SetUpdateCurrencyPermissions()
        {

            ObjPermissions.MainPermissions = (int)enMainPermissions.CurrencyExchange;
            ObjPermissions.CurrenciesManagementPermissions = (int)enCurrenciesManagementPermissions.UpdateCurrency;

        }

        private void UnSetUpdateCurrencyPermissions()
        {

            ObjPermissions.MainPermissions = 0;
            ObjPermissions.CurrenciesManagementPermissions = 0;

        }


        private void SetListCurrenciesPermissions()
        {
            ObjPermissions.MainPermissions = (int)enMainPermissions.CurrencyExchange;
            ObjPermissions.CurrenciesManagementPermissions = (int)enCurrenciesManagementPermissions.ListCurrencies;
        }

        private void UnSetListCurrenciesPermissions()
        {
            ObjPermissions.MainPermissions = 0;
            ObjPermissions.CurrenciesManagementPermissions = 0;
        }


        private void SetExchangeCurrencyPermissions()
        {
            ObjPermissions.MainPermissions = (int)enMainPermissions.CurrencyExchange;
            ObjPermissions.CurrenciesManagementPermissions = (int)enCurrenciesManagementPermissions.ExchangeCurrency;
        }

        private void UnSetExchangeCurrencyPermissions()
        {
            ObjPermissions.MainPermissions = 0;
            ObjPermissions.CurrenciesManagementPermissions = 0;
        }

        private void SetExchangeLogPermissions()
        {
            ObjPermissions.MainPermissions = (int)enMainPermissions.CurrencyExchange;
            ObjPermissions.CurrenciesManagementPermissions = (int)enCurrenciesManagementPermissions.ExchangeLog;
        }

        private void UnSetExchangeLogPermissions()
        {
            ObjPermissions.MainPermissions = 0;
            ObjPermissions.CurrenciesManagementPermissions = 0;
        }


        //Transactions Specific Sections
        private void SetTransactionsManagementPermissions()
        {
            ObjPermissions.MainPermissions = (int)enMainPermissions.Transactions;
            ObjPermissions.TransactionsManagementPermissions = (int)enTransactionsManagementPermissions.TransactionsManagementFullAccess;
        }

        private void UnSetTransactionsManagementPermissions()
        {
            ObjPermissions.MainPermissions = 0;
            ObjPermissions.TransactionsManagementPermissions = 0;
        }

        private void SetDepositPermissions()
        {
            ObjPermissions.MainPermissions = (int)enMainPermissions.Transactions;
            ObjPermissions.TransactionsManagementPermissions = (int)enTransactionsManagementPermissions.Deposit;
        }

        private void UnSetDepositPermissions()
        {
            ObjPermissions.MainPermissions = 0;
            ObjPermissions.TransactionsManagementPermissions = 0;
        }

        private void SetWithdrawPermissions()
        {
            ObjPermissions.MainPermissions = (int)enMainPermissions.Transactions;
            ObjPermissions.TransactionsManagementPermissions = (int)enTransactionsManagementPermissions.WithDraw;
        }

        private void UnSetWithdrawPermissions()
        {
            ObjPermissions.MainPermissions = 0;
            ObjPermissions.TransactionsManagementPermissions = 0;
        }

        private void SetListBalancesPermissions()
        {
            ObjPermissions.MainPermissions = (int)enMainPermissions.Transactions;
            ObjPermissions.TransactionsManagementPermissions = (int)enTransactionsManagementPermissions.ListBalances;
        }

        private void UnSetListBalancesPermissions()
        {
            ObjPermissions.MainPermissions = 0;
            ObjPermissions.TransactionsManagementPermissions = 0;
        }

        private void SetTransferPermissions()
        {
            ObjPermissions.MainPermissions = (int)enMainPermissions.Transactions;
            ObjPermissions.TransactionsManagementPermissions = (int)enTransactionsManagementPermissions.Transfer;
        }

        private void UnSetTransferPermissions()
        {
            ObjPermissions.MainPermissions = 0;
            ObjPermissions.TransactionsManagementPermissions = 0;
        }

        private void SetTransferLogPermissions()
        {
            ObjPermissions.MainPermissions = (int)enMainPermissions.Transactions;
            ObjPermissions.TransactionsManagementPermissions = (int)enTransactionsManagementPermissions.TransferLog;
        }

        private void UnSetTransferLogPermissions()
        {
            ObjPermissions.MainPermissions = 0;
            ObjPermissions.TransactionsManagementPermissions = 0;
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

                    ObjPermissions.MainPermissions = (int)enMainPermissions.UsersManagement;
                    ObjPermissions.UsersManagementPermissions = (int)enUsersManagementPermissions.DeleteUser;
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

                    ObjPermissions.MainPermissions = (int)enMainPermissions.UsersManagement;
                    ObjPermissions.UsersManagementPermissions = (int)enUsersManagementPermissions.UpdateUser;
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
                    ObjPermissions.MainPermissions = (int)enMainPermissions.UsersManagement;
                    ObjPermissions.UsersManagementPermissions = (int)enUsersManagementPermissions.ListUsers;
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
                    ObjPermissions.MainPermissions = (int)enMainPermissions.UsersManagement;
                    ObjPermissions.UsersManagementPermissions = (int)enUsersManagementPermissions.FindUser;
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
                    ObjPermissions.MainPermissions = (int)enMainPermissions.CurrencyExchange;
                    ObjPermissions.CurrenciesManagementPermissions = (int)enCurrenciesManagementPermissions.UpdateCurrency;
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


        private void CheckTreeViewNode(TreeNode node, Boolean isChecked)
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
            ObjPermissions.FullPermissionStr = ObjPermissions.MainPermissions.ToString() + "#"
                + ObjPermissions.ClientsManagementPermissions.ToString() + "#" + ObjPermissions.UsersManagementPermissions.ToString()
                + "#" + ObjPermissions.CurrenciesManagementPermissions.ToString() + "#" + ObjPermissions.TransactionsManagementPermissions.ToString();


            MessageBox.Show(ObjPermissions.FullPermissionStr.ToString());
        }
    }
}
