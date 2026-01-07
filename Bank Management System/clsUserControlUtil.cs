using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_Business_Logic_Layer;

namespace Bank_Management_System
{
    internal class clsUserControlUtil
    {

        public static Dictionary<string, bool> PermissionsDict = new Dictionary<string, bool>();

        public UserControl CurrentControl;

        public Panel CurrentPanel;

        public static clsUserBusinessLogic LoginUser;


        public void ShowUserControl(UserControl newControl)
        {
            // Clear any existing controls from the content panel
            CurrentPanel.Controls.Clear();

            // Add the new User Control to the panel
            newControl.Dock = DockStyle.Fill; // Make the control fill the panel
            CurrentPanel.Controls.Add(newControl);

            CurrentControl = newControl; // Keep a reference to the current control
        }
        
        private static void GrantFullAccess()
        {
            /*
             Dictionary Structure:
            
             PermissionsDict is a Dictionary<string, bool> where:
             - Key: Permission name as string (e.g., "HasFullAccess", "HasAddClient")
             - Value: Boolean indicating if permission is granted (true) or denied (false)
            
             Keys include:
             "HasFullAccess", "HasClientsFullAccess", "HasUsersFullAccess", "HasTransactionsFullAccess", 
             "HasCurrenciesFullAccess", "HasAddClient", "HasDeleteClient", "HasUpdateClient", 
             "HasListClients", "HasFindClient", "HasAddUser", "HasDeleteUser", "HasUpdateUser", 
             "HasListUsers", "HasFindUser", "HasAddCurrency", "HasUpdateCurrency", "HasListCurrencies", 
             "HasFindCurrency", "HasExchangeLog", "HasExchangeCurrency", "HasDeposit", "HasWithdraw", 
             "HasTransfer", "HasListBalances", "HasTransferLog"
            */

            foreach (var item in PermissionsDict)
            {
                PermissionsDict[item.Key] = true;
            }

            //PermissionsDict["HasFullAccess"] = true;

        }

        private static void GrantClientsFullAccess()
        {
            // HasAddClient, HasDeleteClient, HasUpdateClient, HasListClients, HasFindClient, 
            PermissionsDict["HasClientsFullAccess"] = true;
            PermissionsDict["HasAddClient"] = true;
            PermissionsDict["HasDeleteClient"] = true;
            PermissionsDict["HasUpdateClient"] = true;
            PermissionsDict["HasListClients"] = true;
            PermissionsDict["HasFindClient"] = true;

        }

        private static void GrantUsersFullAccess()
        {
            // HasAddClient, HasDeleteClient, HasUpdateClient, HasListUsers, HasFindClient, 
            PermissionsDict["HasUsersFullAccess"] = true;
            PermissionsDict["HasAddUser"] = true;
            PermissionsDict["HasDeleteUser"] = true;
            PermissionsDict["HasUpdateUser"] = true;
            PermissionsDict["HasListUsers"] = true;
            PermissionsDict["HasFindUser"] = true;

        }

        private static void GrantCurrenciesFullAccess()
        {
            // HasAddClient, HasDeleteClient, HasUpdateClient, HasListCurrencies, HasFindClient, 
            PermissionsDict["HasCurrenciesFullAccess"] = true;
            PermissionsDict["HasAddCurrency"] = true;
            PermissionsDict["HasDeleteCurrency"] = true;
            PermissionsDict["HasUpdateCurrency"] = true;
            PermissionsDict["HasListCurrencies"] = true;
            PermissionsDict["HasFindCurrency"] = true;

        }

        private static void GrantTransactionsFullAccess()
        {
            // HasAddClient, HasDeleteClient, HasUpdateClient, HasListTransactions, HasFindClient, 
            PermissionsDict["HasTransactionsFullAccess"] = true;
            PermissionsDict["HasDeposit"] = true;
            PermissionsDict["HasWithdraw"] = true;
            PermissionsDict["HasTransfer"] = true;
            PermissionsDict["HasListBalances"] = true;
            PermissionsDict["HasTransferLog"] = true;

        }

        private static void InitializePermissionsDict()
        {
            PermissionsDict.Add("HasFullAccess", false);
            PermissionsDict.Add("HasClientsFullAccess", false);
            PermissionsDict.Add("HasUsersFullAccess", false);
            PermissionsDict.Add("HasCurrenciesFullAccess", false);
            PermissionsDict.Add("HasTransactionsFullAccess", false);

            PermissionsDict.Add("HasAddClient", false);
            PermissionsDict.Add("HasDeleteClient", false);
            PermissionsDict.Add("HasUpdateClient", false);
            PermissionsDict.Add("HasListClients", false);
            PermissionsDict.Add("HasFindClient", false);

            PermissionsDict.Add("HasAddUser", false);
            PermissionsDict.Add("HasDeleteUser", false);
            PermissionsDict.Add("HasUpdateUser", false);
            PermissionsDict.Add("HasListUsers", false);
            PermissionsDict.Add("HasFindUser", false);

            PermissionsDict.Add("HasAddCurrency", false);
            PermissionsDict.Add("HasUpdateCurrency", false);
            PermissionsDict.Add("HasListCurrencies", false);
            PermissionsDict.Add("HasFindCurrency", false);
            PermissionsDict.Add("HasExchangeLog", false);
            PermissionsDict.Add("HasExchangeCurrency", false);

            PermissionsDict.Add("HasDeposit", false);
            PermissionsDict.Add("HasWithdraw", false);
            PermissionsDict.Add("HasTransfer", false);
            PermissionsDict.Add("HasListBalances", false);
            PermissionsDict.Add("HasTransferLog", false);
        }


        private static bool HasPermissionFlag(clsPermissionsBLL.enMainPermissions enMainPermissions)
        {
            return (LoginUser.PermissionsInfo.MainPermissions & (int)enMainPermissions) == (int)enMainPermissions;
        }

        private static void SetMainBoolFlags()
        {
            InitializePermissionsDict();

            if (LoginUser.PermissionsInfo.MainPermissions == 0)
                return;


            if (LoginUser.PermissionsInfo.MainPermissions == (int)clsPermissionsBLL.enMainPermissions.FullAceess)
            {
                GrantFullAccess();
                return;
            }

            if (HasPermissionFlag(clsPermissionsBLL.enMainPermissions.ClientsManagement))
                GrantClientsFullAccess();
            

            if (HasPermissionFlag(clsPermissionsBLL.enMainPermissions.UsersManagement))
                GrantUsersFullAccess();
            

            if (HasPermissionFlag(clsPermissionsBLL.enMainPermissions.CurrencyExchange))
                GrantCurrenciesFullAccess();
            

            if (HasPermissionFlag(clsPermissionsBLL.enMainPermissions.Transactions))
                GrantTransactionsFullAccess();
            


        }


        private static bool HasPermissionFlag(clsPermissionsBLL.enClientsManagementPermissions enClientsPermission)
        {
            return (LoginUser.PermissionsInfo.ClientsManagementPermissions & (int)enClientsPermission) == (int)enClientsPermission;
        }

        private static void SetClientsBoolFlags()
        {

            if (LoginUser.PermissionsInfo.ClientsManagementPermissions == 0)
                return;

            if (PermissionsDict["HasClientsFullAccess"])
                return;
            
            if (HasPermissionFlag(clsPermissionsBLL.enClientsManagementPermissions.AddClient))
                PermissionsDict["HasAddClient"] = true;
            
            if (HasPermissionFlag(clsPermissionsBLL.enClientsManagementPermissions.UpdateClient))
                PermissionsDict["HasUpdateClient"] = true;
            
            if (HasPermissionFlag(clsPermissionsBLL.enClientsManagementPermissions.DeleteClient))
                PermissionsDict["HasDeleteClient"] = true;
            
            if (HasPermissionFlag(clsPermissionsBLL.enClientsManagementPermissions.ListClients))
                PermissionsDict["HasListClients"] = true;
            
            if (HasPermissionFlag(clsPermissionsBLL.enClientsManagementPermissions.FindClient))
                PermissionsDict["HasFindClient"] = true;
            

            // 


        }


        private static bool HasPermissionFlag(clsPermissionsBLL.enUsersManagementPermissions enUsersPermission)
        {
            return (LoginUser.PermissionsInfo.UsersManagementPermissions & (int)enUsersPermission) == (int)enUsersPermission;
        }

        private static void SetUsersBoolFlags()
        {
            if (LoginUser.PermissionsInfo.UsersManagementPermissions == 0)
                return;

            if (PermissionsDict["HasUsersFullAccess"])
                return;

            if (HasPermissionFlag(clsPermissionsBLL.enUsersManagementPermissions.AddUser))
                PermissionsDict["HasAddUser"] = true;
            
            if (HasPermissionFlag(clsPermissionsBLL.enUsersManagementPermissions.UpdateUser))
                PermissionsDict["HasUpdateUser"] = true;
            
            if (HasPermissionFlag(clsPermissionsBLL.enUsersManagementPermissions.DeleteUser))
                PermissionsDict["HasDeleteUser"] = true;
            
            if (HasPermissionFlag(clsPermissionsBLL.enUsersManagementPermissions.ListUsers))
                PermissionsDict["HasListUsers"] = true;
            
            if (HasPermissionFlag(clsPermissionsBLL.enUsersManagementPermissions.FindUser))
                PermissionsDict["HasFindUser"] = true;
            

            // 


        }


        private static bool HasPermissionFlag(clsPermissionsBLL.enCurrenciesManagementPermissions enCurrenciesPermission)
        {
            return (LoginUser.PermissionsInfo.CurrenciesManagementPermissions & (int)enCurrenciesPermission) == (int)enCurrenciesPermission;
        }

        private static void SetCurrenciesBoolFlags()
        {
            if (LoginUser.PermissionsInfo.CurrenciesManagementPermissions == 0)
                return;

            if (PermissionsDict["HasCurrenciesFullAccess"])
                return;

            if (LoginUser.PermissionsInfo.CurrenciesManagementPermissions == (int)clsPermissionsBLL.enCurrenciesManagementPermissions.CurrenciesManagementFullAceess)
            {
                GrantCurrenciesFullAccess();
                return;
            }
            if (HasPermissionFlag(clsPermissionsBLL.enCurrenciesManagementPermissions.AddCurrency))
                PermissionsDict["HasAddCurrency"] = true;

            if (HasPermissionFlag(clsPermissionsBLL.enCurrenciesManagementPermissions.UpdateCurrency))
                PermissionsDict["HasUpdateCurrency"] = true;

            if (HasPermissionFlag(clsPermissionsBLL.enCurrenciesManagementPermissions.ExchangeCurrency))
                PermissionsDict["HasExchangeCurrency"] = true;

            if (HasPermissionFlag(clsPermissionsBLL.enCurrenciesManagementPermissions.ListCurrencies))
                PermissionsDict["HasListCurrencies"] = true;

            if (HasPermissionFlag(clsPermissionsBLL.enCurrenciesManagementPermissions.FindCurrency))
                PermissionsDict["HasFindCurrency"] = true;

            if (HasPermissionFlag(clsPermissionsBLL.enCurrenciesManagementPermissions.ExchangeLog))
                PermissionsDict["HasExchangeLog"] = true;


            // HasAddCurrency, HasUpdateCurrency, HasListCurrencies, HasFindCurrency, HasExchangeLog, HasExchangeCurrency, 


        }


        private static bool HasPermissionFlag(clsPermissionsBLL.enTransactionsManagementPermissions enTransactionsPermission)
        {
            return (LoginUser.PermissionsInfo.TransactionsManagementPermissions & (int)enTransactionsPermission) == (int)enTransactionsPermission;
        }

        private static void SetTransactionsBoolFlags()
        {
            if (LoginUser.PermissionsInfo.TransactionsManagementPermissions == 0)
                return;

            if (PermissionsDict["HasTransactionsFullAccess"])
                return;


            if (LoginUser.PermissionsInfo.TransactionsManagementPermissions == (int)clsPermissionsBLL.enTransactionsManagementPermissions.TransactionsManagement)
            {
                GrantTransactionsFullAccess();
                return;
            }
            if (HasPermissionFlag(clsPermissionsBLL.enTransactionsManagementPermissions.Deposit))
                PermissionsDict["HasDeposit"] = true;

            if (HasPermissionFlag(clsPermissionsBLL.enTransactionsManagementPermissions.WithDraw))
                PermissionsDict["HasWithdraw"] = true;

            if (HasPermissionFlag(clsPermissionsBLL.enTransactionsManagementPermissions.Transfer))
                PermissionsDict["HasTransfer"] = true;

            if (HasPermissionFlag(clsPermissionsBLL.enTransactionsManagementPermissions.ListBalances))
                PermissionsDict["HasListBalances"] = true;

            if (HasPermissionFlag(clsPermissionsBLL.enTransactionsManagementPermissions.TransferLog))
                PermissionsDict["HasTransferLog"] = true;


            // HasDeposit, HasWithdraw, HasTransfer, HasListBalances, HasTransferLog


        }


        /*
             Permissions Dictionary Structure:
            
             PermissionsDict is a Dictionary<string, bool> where:
             - Key: Permission name as string (e.g., "HasFullAccess", "HasAddClient")
             - Value: Boolean indicating if permission is granted (true) or denied (false)
            
             Keys include:
             "HasFullAccess", "HasClientsFullAccess", "HasUsersFullAccess", "HasTransactionsFullAccess", 
             "HasCurrenciesFullAccess", "HasAddClient", "HasDeleteClient", "HasUpdateClient", 
             "HasListClients", "HasFindClient", "HasAddUser", "HasDeleteUser", "HasUpdateUser", 
             "HasListUsers", "HasFindUser", "HasAddCurrency", "HasUpdateCurrency", "HasListCurrencies", 
             "HasFindCurrency", "HasExchangeLog", "HasExchangeCurrency", "HasDeposit", "HasWithdraw", 
             "HasTransfer", "HasListBalances", "HasTransferLog"
            */



        public static void SetUserPermissionsDict()
        {
            /*
            Test Cases:

            m c  u C t
            1#-1#0#0#0

            */

            SetMainBoolFlags();

            if (!PermissionsDict["HasFullAccess"])
            {
                SetClientsBoolFlags();
                SetUsersBoolFlags();
                SetCurrenciesBoolFlags();
                SetTransactionsBoolFlags();

            }

        }






    }
}
