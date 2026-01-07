using Bank_Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bank_Management_System.Forms
{
    public partial class frmPermissions : Form
    {
        // 1. Add [Flags] to enums to indicate they can be combined
        [Flags]
        enum enMainPermissions
        {
            None = 0, FullAccess = -1, ClientsManagement = 1, UsersManagement = 2, CurrencyExchange = 4, Transactions = 8
        }

        [Flags]
        enum enClientsManagementPermissions
        {
            None = 0, ClientsManagementFullAceess = -1, AddClient = 1, DeleteClient = 2, UpdateClient = 4, ListClients = 8, FindClient = 16
        }

        [Flags]
        enum enUsersManagementPermissions
        {
            UsersManagementFullAceess = -1, AddUser = 1, DeleteUser = 2, UpdateUser = 4, ListUsers = 8, FindUser = 16
        }

        [Flags]
        enum enCurrenciesManagementPermissions
        {
            CurrenciesManagementFullAceess = -1, AddCurrency = 1, UpdateCurrency = 2, ListCurrencies = 4, FindCurrency = 8, ExchangeCurrency = 16,
            ExchangeLog = 32
        }

        [Flags]
        enum enTransactionsManagementPermissions
        {
            TransactionsManagementFullAccess = -1, Deposit = 1, WithDraw = 2, ListBalances = 4, Transfer = 8, TransferLog = 16
        }

        // ... (Assume other Enums are defined here with [Flags] as well) ...

        public clsPermissionsBLL PermissionsInfo = new clsPermissionsBLL();

        // 2. Define a delegate (a blueprint for a function) that updates the permissions
        private delegate void PermissionAction(bool isChecked);


        // 3. The Dictionary acts as our lookup table
        private Dictionary<string, PermissionAction> _permissionMap;

        public frmPermissions()
        {
            InitializeComponent();
            InitializePermissionMap(); // Build the map when form starts
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trvPermissions.ExpandAll();



            // Optional: If this form is editing an existing user, 
            // you would load their current permissions into the checkboxes here.
        }

        // 4. This method maps the "Text" of the tree node to the logic it performs.
        // If you want to change logic, you only edit this list.
        private void InitializePermissionMap()
        {
            _permissionMap = new Dictionary<string, PermissionAction>();

            
            // --- Main Permissions ---
            _permissionMap.Add("FullAccess", (isChecked) => ToggleMainPermission((int)enMainPermissions.FullAccess, isChecked));

            // --- Clients Section ---
            // Note: We use a helper 'UpdateClientBit' to reuse logic
            _permissionMap.Add("ClientsManagement", (isChecked) =>
            {
                // Handle the Main bit
                UpdateMainBit((int)enMainPermissions.ClientsManagement, isChecked);
                // Handle the specific full access bit
                PermissionsInfo.ClientsManagementPermissions = isChecked ? -1 : 0;
            });

            _permissionMap.Add("AddClient", (c) => UpdateClientBit((int)enClientsManagementPermissions.AddClient, c));
            _permissionMap.Add("DeleteClient", (c) => UpdateClientBit((int)enClientsManagementPermissions.DeleteClient, c));
            _permissionMap.Add("UpdateClient", (c) => UpdateClientBit((int)enClientsManagementPermissions.UpdateClient, c));
            _permissionMap.Add("ListClients", (c) => UpdateClientBit((int)enClientsManagementPermissions.ListClients, c));
            _permissionMap.Add("FindClient", (c) => UpdateClientBit((int)enClientsManagementPermissions.FindClient, c));

            // --- Users Section (Example) ---
            // You can easily follow the pattern above for Users, Currencies, etc.
            _permissionMap.Add("UsersManagement", (isChecked) =>
            {
                UpdateMainBit((int)enMainPermissions.UsersManagement, isChecked);
                PermissionsInfo.UsersManagementPermissions = isChecked ? -1 : 0;
            });

            _permissionMap.Add("AddUser", (c) => UpdateUserBit((int)enUsersManagementPermissions.AddUser, c));
            _permissionMap.Add("DeleteUser", (c) => UpdateUserBit((int)enUsersManagementPermissions.DeleteUser, c));
            _permissionMap.Add("UpdateUser", (c) => UpdateUserBit((int)enUsersManagementPermissions.UpdateUser, c));
            _permissionMap.Add("ListUsers", (c) => UpdateUserBit((int)enUsersManagementPermissions.ListUsers, c));
            _permissionMap.Add("FindUser", (c) => UpdateUserBit((int)enUsersManagementPermissions.FindUser, c));


            // --- Currencies Section ---

            _permissionMap.Add("CurrencyExchange", (isChecked) =>
            {
                UpdateMainBit((int)enMainPermissions.CurrencyExchange, isChecked);
                PermissionsInfo.CurrenciesManagementPermissions = isChecked ? -1 : 0;
            });

            _permissionMap.Add("AddCurrency", (c) => UpdateCurrencyBit((int)enCurrenciesManagementPermissions.AddCurrency, c));
            _permissionMap.Add("UpdateCurrency", (c) => UpdateCurrencyBit((int)enCurrenciesManagementPermissions.UpdateCurrency, c));
            _permissionMap.Add("ListCurrencies", (c) => UpdateUserBit((int)enCurrenciesManagementPermissions.ListCurrencies, c));
            _permissionMap.Add("FindCurrency", (c) => UpdateUserBit((int)enCurrenciesManagementPermissions.FindCurrency, c));
            _permissionMap.Add("ExchangeLog", (c) => UpdateUserBit((int)enCurrenciesManagementPermissions.ExchangeLog, c));
            _permissionMap.Add("ExchangeCurrency", (c) => UpdateCurrencyBit((int)enCurrenciesManagementPermissions.ExchangeCurrency, c));


            _permissionMap.Add("Transactions", (isChecked) =>
            {
                UpdateMainBit((int)enMainPermissions.Transactions, isChecked);
                PermissionsInfo.TransactionsManagementPermissions = isChecked ? -1 : 0;
            });

            _permissionMap.Add("Deposit", (c) => UpdateTransactionBit((int)enTransactionsManagementPermissions.Deposit, c));
            _permissionMap.Add("WithDraw", (c) => UpdateTransactionBit((int)enTransactionsManagementPermissions.WithDraw, c));
            _permissionMap.Add("ListBalances", (c) => UpdateUserBit((int)enTransactionsManagementPermissions.ListBalances, c));
            _permissionMap.Add("Transfer", (c) => UpdateUserBit((int)enTransactionsManagementPermissions.Transfer, c));
            _permissionMap.Add("TransferLog", (c) => UpdateUserBit((int)enTransactionsManagementPermissions.TransferLog, c));
            



            // ... Add mappings for AddUser, DeleteUser, etc.
        }

        // 5. Generic Helpers to handle the Bitwise Math safely
        // This replaces the 50+ Set/Unset methods

        private void UpdateMainBit(int flag, bool isChecked)
        {
            if (isChecked)
                PermissionsInfo.MainPermissions |= flag; // Bitwise OR (Add)
            else
                PermissionsInfo.MainPermissions &= ~flag; // Bitwise AND NOT (Remove)
        }

        private void UpdateClientBit(int flag, bool isChecked)
        {
            // Ensure the parent "Main" permission is updated if a child is checked
            if (isChecked) UpdateMainBit((int)enMainPermissions.ClientsManagement, true);

            if (isChecked)
                PermissionsInfo.ClientsManagementPermissions |= flag;
            else
                PermissionsInfo.ClientsManagementPermissions &= ~flag;
        }

        private void UpdateUserBit(int flag, bool isChecked)
        {
            // Ensure the parent "Main" permission is updated if a child is checked
            if (isChecked) UpdateMainBit((int)enMainPermissions.UsersManagement, true);

            if (isChecked)
                PermissionsInfo.UsersManagementPermissions |= flag;
            else
                PermissionsInfo.UsersManagementPermissions &= ~flag;
        }

        private void UpdateCurrencyBit(int flag, bool isChecked)
        {
            // Ensure the parent "Main" permission is updated if a child is checked
            if (isChecked) UpdateMainBit((int)enMainPermissions.CurrencyExchange, true);

            if (isChecked)
                PermissionsInfo.CurrenciesManagementPermissions |= flag;
            else
                PermissionsInfo.CurrenciesManagementPermissions &= ~flag;
        }

        private void UpdateTransactionBit(int flag, bool isChecked)
        {
            // Ensure the parent "Main" permission is updated if a child is checked
            if (isChecked) UpdateMainBit((int)enMainPermissions.Transactions, true);

            if (isChecked)
                PermissionsInfo.TransactionsManagementPermissions |= flag;
            else
                PermissionsInfo.TransactionsManagementPermissions &= ~flag;
        }


        // Special handler for Full Access as it affects everything
        /// <summary>
        /// Toggles all main permission flags to either fully enabled or fully disabled based on the checked state.
        /// </summary>
        /// <param name="flag">An integer flag parameter (currently unused in the implementation).</param>
        /// <param name="isChecked">A boolean value indicating whether permissions should be enabled (true) or disabled (false).
        /// When true, all permissions are set to -1 (fully enabled/granted).
        /// When false, all permissions are set to 0 (fully disabled/denied).</param>
        /// <remarks>
        /// This method performs a bulk operation that affects the following permission categories:
        /// - MainPermissions
        /// - ClientsManagementPermissions
        /// - UsersManagementPermissions
        /// - CurrenciesManagementPermissions
        /// - TransactionsManagementPermissions
        /// 
        /// All permissions are synchronized to the same state with this operation.
        /// </remarks>
        private void ToggleMainPermission(int flag, bool isChecked)
        {
            PermissionsInfo.MainPermissions = isChecked ? -1 : 0;
            PermissionsInfo.ClientsManagementPermissions = isChecked ? -1 : 0;
            PermissionsInfo.UsersManagementPermissions = isChecked ? -1 : 0;
            PermissionsInfo.CurrenciesManagementPermissions = isChecked ? -1 : 0;
            PermissionsInfo.TransactionsManagementPermissions = isChecked ? -1 : 0;
        }

        // 6. The Event Handler becomes incredibly simple
        private void trvPermissions_AfterCheck(object sender, TreeViewEventArgs e)
        {
            // Temporarily detach event handler to prevent infinite loops during recursion
            trvPermissions.AfterCheck -= trvPermissions_AfterCheck;

            try
            {
                // 1. Handle Visuals (Check/Uncheck children)
                CheckTreeViewNode(e.Node, e.Node.Checked);

                // 2. Handle Logic (Update BLL)
                // Look up the node text in our dictionary
                if (_permissionMap.ContainsKey(e.Node.Text))
                {
                    // Execute the stored action
                    _permissionMap[e.Node.Text].Invoke(e.Node.Checked);
                }
            }
            finally
            {
                // Re-attach event
                trvPermissions.AfterCheck += trvPermissions_AfterCheck;
            }
        }

        private void CheckTreeViewNode(TreeNode node, bool isChecked)
        {
            foreach (TreeNode item in node.Nodes)
            {
                item.Checked = isChecked;
                // Recursive call (visual only)
                if (item.Nodes.Count > 0) CheckTreeViewNode(item, isChecked);

                // IMPORTANT: When we visually check a child via code, we must also trigger 
                // the logic for that child.
                if (_permissionMap.ContainsKey(item.Text))
                {
                    _permissionMap[item.Text].Invoke(isChecked);
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