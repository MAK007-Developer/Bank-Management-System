namespace Bank_Management_System.Forms
{
    partial class frmPermissions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPermissions));
            this.pnlUserPermissions = new System.Windows.Forms.Panel();
            this.chkbFullAcess = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbTransactions = new System.Windows.Forms.GroupBox();
            this.chkbListBalances = new System.Windows.Forms.CheckBox();
            this.chkbWithdraw = new System.Windows.Forms.CheckBox();
            this.chkbTransfer = new System.Windows.Forms.CheckBox();
            this.chkbTransferLog = new System.Windows.Forms.CheckBox();
            this.chkbDeposit = new System.Windows.Forms.CheckBox();
            this.chkbTransactionsManagement = new System.Windows.Forms.CheckBox();
            this.gbCurrencies = new System.Windows.Forms.GroupBox();
            this.chkbExchange = new System.Windows.Forms.CheckBox();
            this.chkbListCurrencies = new System.Windows.Forms.CheckBox();
            this.chkbFindCurrency = new System.Windows.Forms.CheckBox();
            this.chkbUpdateCurrency = new System.Windows.Forms.CheckBox();
            this.chkbExchangeLog = new System.Windows.Forms.CheckBox();
            this.chkbAddCurrency = new System.Windows.Forms.CheckBox();
            this.chkbCurrencyExchange = new System.Windows.Forms.CheckBox();
            this.gbUsers = new System.Windows.Forms.GroupBox();
            this.chkbListUsers = new System.Windows.Forms.CheckBox();
            this.chkbFindUser = new System.Windows.Forms.CheckBox();
            this.chkbUpdateUser = new System.Windows.Forms.CheckBox();
            this.chkbDeleteUser = new System.Windows.Forms.CheckBox();
            this.chkbAddUser = new System.Windows.Forms.CheckBox();
            this.chkbUsersManagement = new System.Windows.Forms.CheckBox();
            this.gbClients = new System.Windows.Forms.GroupBox();
            this.chkbListClients = new System.Windows.Forms.CheckBox();
            this.chkbFindClient = new System.Windows.Forms.CheckBox();
            this.chkbUpdateClient = new System.Windows.Forms.CheckBox();
            this.chkbDeleteClient = new System.Windows.Forms.CheckBox();
            this.chkbAddClient = new System.Windows.Forms.CheckBox();
            this.chkbClientsManagement = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlUserPermissions.SuspendLayout();
            this.gbTransactions.SuspendLayout();
            this.gbCurrencies.SuspendLayout();
            this.gbUsers.SuspendLayout();
            this.gbClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUserPermissions
            // 
            this.pnlUserPermissions.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlUserPermissions.Controls.Add(this.chkbFullAcess);
            this.pnlUserPermissions.Controls.Add(this.btnBack);
            this.pnlUserPermissions.Controls.Add(this.gbTransactions);
            this.pnlUserPermissions.Controls.Add(this.gbCurrencies);
            this.pnlUserPermissions.Controls.Add(this.gbUsers);
            this.pnlUserPermissions.Controls.Add(this.gbClients);
            this.pnlUserPermissions.Controls.Add(this.btnSave);
            this.pnlUserPermissions.Controls.Add(this.pictureBox1);
            this.pnlUserPermissions.Controls.Add(this.lblTitle);
            this.pnlUserPermissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserPermissions.Location = new System.Drawing.Point(0, 0);
            this.pnlUserPermissions.Name = "pnlUserPermissions";
            this.pnlUserPermissions.Size = new System.Drawing.Size(886, 751);
            this.pnlUserPermissions.TabIndex = 0;
            // 
            // chkbFullAcess
            // 
            this.chkbFullAcess.AutoSize = true;
            this.chkbFullAcess.BackColor = System.Drawing.Color.SteelBlue;
            this.chkbFullAcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbFullAcess.ForeColor = System.Drawing.Color.GhostWhite;
            this.chkbFullAcess.Location = new System.Drawing.Point(378, 166);
            this.chkbFullAcess.Name = "chkbFullAcess";
            this.chkbFullAcess.Size = new System.Drawing.Size(135, 29);
            this.chkbFullAcess.TabIndex = 74;
            this.chkbFullAcess.Tag = "-1";
            this.chkbFullAcess.Text = "Full Access";
            this.chkbFullAcess.UseVisualStyleBackColor = false;
            this.chkbFullAcess.CheckedChanged += new System.EventHandler(this.chkbFullAccess_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.AutoEllipsis = true;
            this.btnBack.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(103, 654);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 54);
            this.btnBack.TabIndex = 73;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbTransactions
            // 
            this.gbTransactions.Controls.Add(this.chkbListBalances);
            this.gbTransactions.Controls.Add(this.chkbWithdraw);
            this.gbTransactions.Controls.Add(this.chkbTransfer);
            this.gbTransactions.Controls.Add(this.chkbTransferLog);
            this.gbTransactions.Controls.Add(this.chkbDeposit);
            this.gbTransactions.Controls.Add(this.chkbTransactionsManagement);
            this.gbTransactions.Location = new System.Drawing.Point(456, 429);
            this.gbTransactions.Name = "gbTransactions";
            this.gbTransactions.Size = new System.Drawing.Size(382, 194);
            this.gbTransactions.TabIndex = 72;
            this.gbTransactions.TabStop = false;
            // 
            // chkbListBalances
            // 
            this.chkbListBalances.AutoSize = true;
            this.chkbListBalances.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbListBalances.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chkbListBalances.Location = new System.Drawing.Point(170, 107);
            this.chkbListBalances.Name = "chkbListBalances";
            this.chkbListBalances.Size = new System.Drawing.Size(134, 24);
            this.chkbListBalances.TabIndex = 5;
            this.chkbListBalances.Tag = "ListBalances";
            this.chkbListBalances.Text = "List Balances";
            this.chkbListBalances.UseVisualStyleBackColor = true;
            this.chkbListBalances.CheckedChanged += new System.EventHandler(this.chkbTransactionsItems_CheckedChanged);
            // 
            // chkbWithdraw
            // 
            this.chkbWithdraw.AutoSize = true;
            this.chkbWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbWithdraw.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chkbWithdraw.Location = new System.Drawing.Point(170, 67);
            this.chkbWithdraw.Name = "chkbWithdraw";
            this.chkbWithdraw.Size = new System.Drawing.Size(101, 24);
            this.chkbWithdraw.TabIndex = 4;
            this.chkbWithdraw.Tag = "Withdraw";
            this.chkbWithdraw.Text = "Withdraw";
            this.chkbWithdraw.UseVisualStyleBackColor = true;
            this.chkbWithdraw.CheckedChanged += new System.EventHandler(this.chkbTransactionsItems_CheckedChanged);
            // 
            // chkbTransfer
            // 
            this.chkbTransfer.AutoSize = true;
            this.chkbTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbTransfer.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chkbTransfer.Location = new System.Drawing.Point(25, 107);
            this.chkbTransfer.Name = "chkbTransfer";
            this.chkbTransfer.Size = new System.Drawing.Size(94, 24);
            this.chkbTransfer.TabIndex = 3;
            this.chkbTransfer.Tag = "Transfer";
            this.chkbTransfer.Text = "Transfer";
            this.chkbTransfer.UseVisualStyleBackColor = true;
            this.chkbTransfer.CheckedChanged += new System.EventHandler(this.chkbTransactionsItems_CheckedChanged);
            // 
            // chkbTransferLog
            // 
            this.chkbTransferLog.AutoSize = true;
            this.chkbTransferLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbTransferLog.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chkbTransferLog.Location = new System.Drawing.Point(25, 147);
            this.chkbTransferLog.Name = "chkbTransferLog";
            this.chkbTransferLog.Size = new System.Drawing.Size(127, 24);
            this.chkbTransferLog.TabIndex = 2;
            this.chkbTransferLog.Tag = "TransferLog";
            this.chkbTransferLog.Text = "Transfer Log";
            this.chkbTransferLog.UseVisualStyleBackColor = true;
            this.chkbTransferLog.CheckedChanged += new System.EventHandler(this.chkbTransactionsItems_CheckedChanged);
            // 
            // chkbDeposit
            // 
            this.chkbDeposit.AutoSize = true;
            this.chkbDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbDeposit.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chkbDeposit.Location = new System.Drawing.Point(25, 67);
            this.chkbDeposit.Name = "chkbDeposit";
            this.chkbDeposit.Size = new System.Drawing.Size(89, 24);
            this.chkbDeposit.TabIndex = 1;
            this.chkbDeposit.Tag = "Deposit";
            this.chkbDeposit.Text = "Deposit";
            this.chkbDeposit.UseVisualStyleBackColor = true;
            this.chkbDeposit.CheckedChanged += new System.EventHandler(this.chkbTransactionsItems_CheckedChanged);
            // 
            // chkbTransactionsManagement
            // 
            this.chkbTransactionsManagement.AutoSize = true;
            this.chkbTransactionsManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbTransactionsManagement.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chkbTransactionsManagement.Location = new System.Drawing.Point(25, 27);
            this.chkbTransactionsManagement.Name = "chkbTransactionsManagement";
            this.chkbTransactionsManagement.Size = new System.Drawing.Size(229, 24);
            this.chkbTransactionsManagement.TabIndex = 0;
            this.chkbTransactionsManagement.Tag = "-1";
            this.chkbTransactionsManagement.Text = "Transactions Management";
            this.chkbTransactionsManagement.UseVisualStyleBackColor = true;
            this.chkbTransactionsManagement.CheckedChanged += new System.EventHandler(this.chkbTransactionsManagementFullAccess_CheckedChanged);
            // 
            // gbCurrencies
            // 
            this.gbCurrencies.Controls.Add(this.chkbExchange);
            this.gbCurrencies.Controls.Add(this.chkbListCurrencies);
            this.gbCurrencies.Controls.Add(this.chkbFindCurrency);
            this.gbCurrencies.Controls.Add(this.chkbUpdateCurrency);
            this.gbCurrencies.Controls.Add(this.chkbExchangeLog);
            this.gbCurrencies.Controls.Add(this.chkbAddCurrency);
            this.gbCurrencies.Controls.Add(this.chkbCurrencyExchange);
            this.gbCurrencies.Location = new System.Drawing.Point(41, 429);
            this.gbCurrencies.Name = "gbCurrencies";
            this.gbCurrencies.Size = new System.Drawing.Size(382, 194);
            this.gbCurrencies.TabIndex = 71;
            this.gbCurrencies.TabStop = false;
            // 
            // chkbExchange
            // 
            this.chkbExchange.AutoSize = true;
            this.chkbExchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbExchange.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chkbExchange.Location = new System.Drawing.Point(189, 147);
            this.chkbExchange.Name = "chkbExchange";
            this.chkbExchange.Size = new System.Drawing.Size(177, 24);
            this.chkbExchange.TabIndex = 6;
            this.chkbExchange.Tag = "ExchangeCurrency";
            this.chkbExchange.Text = "Exchange Currency";
            this.chkbExchange.UseVisualStyleBackColor = true;
            this.chkbExchange.CheckedChanged += new System.EventHandler(this.chkbCurrenciesItems_CheckedChanged);
            // 
            // chkbListCurrencies
            // 
            this.chkbListCurrencies.AutoSize = true;
            this.chkbListCurrencies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbListCurrencies.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chkbListCurrencies.Location = new System.Drawing.Point(189, 107);
            this.chkbListCurrencies.Name = "chkbListCurrencies";
            this.chkbListCurrencies.Size = new System.Drawing.Size(146, 24);
            this.chkbListCurrencies.TabIndex = 5;
            this.chkbListCurrencies.Tag = "ListCurrencies";
            this.chkbListCurrencies.Text = "List Currencies";
            this.chkbListCurrencies.UseVisualStyleBackColor = true;
            this.chkbListCurrencies.CheckedChanged += new System.EventHandler(this.chkbCurrenciesItems_CheckedChanged);
            // 
            // chkbFindCurrency
            // 
            this.chkbFindCurrency.AutoSize = true;
            this.chkbFindCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbFindCurrency.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chkbFindCurrency.Location = new System.Drawing.Point(189, 67);
            this.chkbFindCurrency.Name = "chkbFindCurrency";
            this.chkbFindCurrency.Size = new System.Drawing.Size(136, 24);
            this.chkbFindCurrency.TabIndex = 4;
            this.chkbFindCurrency.Tag = "FindCurrency";
            this.chkbFindCurrency.Text = "Find Currency";
            this.chkbFindCurrency.UseVisualStyleBackColor = true;
            this.chkbFindCurrency.CheckedChanged += new System.EventHandler(this.chkbCurrenciesItems_CheckedChanged);
            // 
            // chkbUpdateCurrency
            // 
            this.chkbUpdateCurrency.AutoSize = true;
            this.chkbUpdateCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbUpdateCurrency.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chkbUpdateCurrency.Location = new System.Drawing.Point(25, 107);
            this.chkbUpdateCurrency.Name = "chkbUpdateCurrency";
            this.chkbUpdateCurrency.Size = new System.Drawing.Size(157, 24);
            this.chkbUpdateCurrency.TabIndex = 3;
            this.chkbUpdateCurrency.Tag = "UpdateCurrency";
            this.chkbUpdateCurrency.Text = "Update Currency";
            this.chkbUpdateCurrency.UseVisualStyleBackColor = true;
            this.chkbUpdateCurrency.CheckedChanged += new System.EventHandler(this.chkbCurrenciesItems_CheckedChanged);
            // 
            // chkbExchangeLog
            // 
            this.chkbExchangeLog.AutoSize = true;
            this.chkbExchangeLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbExchangeLog.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chkbExchangeLog.Location = new System.Drawing.Point(25, 147);
            this.chkbExchangeLog.Name = "chkbExchangeLog";
            this.chkbExchangeLog.Size = new System.Drawing.Size(137, 24);
            this.chkbExchangeLog.TabIndex = 2;
            this.chkbExchangeLog.Tag = "ExchangeLog";
            this.chkbExchangeLog.Text = "Exchange Log";
            this.chkbExchangeLog.UseVisualStyleBackColor = true;
            this.chkbExchangeLog.CheckedChanged += new System.EventHandler(this.chkbCurrenciesItems_CheckedChanged);
            // 
            // chkbAddCurrency
            // 
            this.chkbAddCurrency.AutoSize = true;
            this.chkbAddCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbAddCurrency.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chkbAddCurrency.Location = new System.Drawing.Point(25, 67);
            this.chkbAddCurrency.Name = "chkbAddCurrency";
            this.chkbAddCurrency.Size = new System.Drawing.Size(133, 24);
            this.chkbAddCurrency.TabIndex = 1;
            this.chkbAddCurrency.Tag = "AddCurrency";
            this.chkbAddCurrency.Text = "Add Currency";
            this.chkbAddCurrency.UseVisualStyleBackColor = true;
            this.chkbAddCurrency.CheckedChanged += new System.EventHandler(this.chkbCurrenciesItems_CheckedChanged);
            // 
            // chkbCurrencyExchange
            // 
            this.chkbCurrencyExchange.AutoSize = true;
            this.chkbCurrencyExchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbCurrencyExchange.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chkbCurrencyExchange.Location = new System.Drawing.Point(25, 27);
            this.chkbCurrencyExchange.Name = "chkbCurrencyExchange";
            this.chkbCurrencyExchange.Size = new System.Drawing.Size(177, 24);
            this.chkbCurrencyExchange.TabIndex = 0;
            this.chkbCurrencyExchange.Tag = "-1";
            this.chkbCurrencyExchange.Text = "Currency Exchange";
            this.chkbCurrencyExchange.UseVisualStyleBackColor = true;
            this.chkbCurrencyExchange.CheckedChanged += new System.EventHandler(this.chkbCurrencyExchangeFullAccess_CheckedChanged);
            // 
            // gbUsers
            // 
            this.gbUsers.Controls.Add(this.chkbListUsers);
            this.gbUsers.Controls.Add(this.chkbFindUser);
            this.gbUsers.Controls.Add(this.chkbUpdateUser);
            this.gbUsers.Controls.Add(this.chkbDeleteUser);
            this.gbUsers.Controls.Add(this.chkbAddUser);
            this.gbUsers.Controls.Add(this.chkbUsersManagement);
            this.gbUsers.Location = new System.Drawing.Point(456, 209);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Size = new System.Drawing.Size(382, 194);
            this.gbUsers.TabIndex = 70;
            this.gbUsers.TabStop = false;
            // 
            // chkbListUsers
            // 
            this.chkbListUsers.AutoSize = true;
            this.chkbListUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbListUsers.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chkbListUsers.Location = new System.Drawing.Point(170, 107);
            this.chkbListUsers.Name = "chkbListUsers";
            this.chkbListUsers.Size = new System.Drawing.Size(109, 24);
            this.chkbListUsers.TabIndex = 5;
            this.chkbListUsers.Tag = "ListUsers";
            this.chkbListUsers.Text = "List Users";
            this.chkbListUsers.UseVisualStyleBackColor = true;
            this.chkbListUsers.CheckedChanged += new System.EventHandler(this.chkbUsersItems_CheckedChanged);
            // 
            // chkbFindUser
            // 
            this.chkbFindUser.AutoSize = true;
            this.chkbFindUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbFindUser.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chkbFindUser.Location = new System.Drawing.Point(170, 67);
            this.chkbFindUser.Name = "chkbFindUser";
            this.chkbFindUser.Size = new System.Drawing.Size(104, 24);
            this.chkbFindUser.TabIndex = 4;
            this.chkbFindUser.Tag = "FindUser";
            this.chkbFindUser.Text = "Find User";
            this.chkbFindUser.UseVisualStyleBackColor = true;
            this.chkbFindUser.CheckedChanged += new System.EventHandler(this.chkbUsersItems_CheckedChanged);
            // 
            // chkbUpdateUser
            // 
            this.chkbUpdateUser.AutoSize = true;
            this.chkbUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbUpdateUser.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chkbUpdateUser.Location = new System.Drawing.Point(25, 107);
            this.chkbUpdateUser.Name = "chkbUpdateUser";
            this.chkbUpdateUser.Size = new System.Drawing.Size(125, 24);
            this.chkbUpdateUser.TabIndex = 3;
            this.chkbUpdateUser.Tag = "UpdateUser";
            this.chkbUpdateUser.Text = "Update User";
            this.chkbUpdateUser.UseVisualStyleBackColor = true;
            this.chkbUpdateUser.CheckedChanged += new System.EventHandler(this.chkbUsersItems_CheckedChanged);
            // 
            // chkbDeleteUser
            // 
            this.chkbDeleteUser.AutoSize = true;
            this.chkbDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbDeleteUser.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chkbDeleteUser.Location = new System.Drawing.Point(25, 147);
            this.chkbDeleteUser.Name = "chkbDeleteUser";
            this.chkbDeleteUser.Size = new System.Drawing.Size(121, 24);
            this.chkbDeleteUser.TabIndex = 2;
            this.chkbDeleteUser.Tag = "DeleteUser";
            this.chkbDeleteUser.Text = "Delete User";
            this.chkbDeleteUser.UseVisualStyleBackColor = true;
            this.chkbDeleteUser.CheckedChanged += new System.EventHandler(this.chkbUsersItems_CheckedChanged);
            // 
            // chkbAddUser
            // 
            this.chkbAddUser.AutoSize = true;
            this.chkbAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbAddUser.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chkbAddUser.Location = new System.Drawing.Point(25, 67);
            this.chkbAddUser.Name = "chkbAddUser";
            this.chkbAddUser.Size = new System.Drawing.Size(101, 24);
            this.chkbAddUser.TabIndex = 1;
            this.chkbAddUser.Tag = "AddUser";
            this.chkbAddUser.Text = "Add User";
            this.chkbAddUser.UseVisualStyleBackColor = true;
            this.chkbAddUser.CheckedChanged += new System.EventHandler(this.chkbUsersItems_CheckedChanged);
            // 
            // chkbUsersManagement
            // 
            this.chkbUsersManagement.AutoSize = true;
            this.chkbUsersManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbUsersManagement.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chkbUsersManagement.Location = new System.Drawing.Point(25, 27);
            this.chkbUsersManagement.Name = "chkbUsersManagement";
            this.chkbUsersManagement.Size = new System.Drawing.Size(177, 24);
            this.chkbUsersManagement.TabIndex = 0;
            this.chkbUsersManagement.Tag = "-1";
            this.chkbUsersManagement.Text = "Users Management";
            this.chkbUsersManagement.UseVisualStyleBackColor = true;
            this.chkbUsersManagement.CheckedChanged += new System.EventHandler(this.chkbUsersManagementFullAccess_CheckedChanged);
            // 
            // gbClients
            // 
            this.gbClients.Controls.Add(this.chkbListClients);
            this.gbClients.Controls.Add(this.chkbFindClient);
            this.gbClients.Controls.Add(this.chkbUpdateClient);
            this.gbClients.Controls.Add(this.chkbDeleteClient);
            this.gbClients.Controls.Add(this.chkbAddClient);
            this.gbClients.Controls.Add(this.chkbClientsManagement);
            this.gbClients.Location = new System.Drawing.Point(41, 209);
            this.gbClients.Name = "gbClients";
            this.gbClients.Size = new System.Drawing.Size(382, 194);
            this.gbClients.TabIndex = 69;
            this.gbClients.TabStop = false;
            // 
            // chkbListClients
            // 
            this.chkbListClients.AutoSize = true;
            this.chkbListClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbListClients.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chkbListClients.Location = new System.Drawing.Point(170, 107);
            this.chkbListClients.Name = "chkbListClients";
            this.chkbListClients.Size = new System.Drawing.Size(116, 24);
            this.chkbListClients.TabIndex = 5;
            this.chkbListClients.Tag = "ListClients";
            this.chkbListClients.Text = "List Clients";
            this.chkbListClients.UseVisualStyleBackColor = true;
            this.chkbListClients.CheckedChanged += new System.EventHandler(this.chkbClientsItems_CheckedChanged);
            // 
            // chkbFindClient
            // 
            this.chkbFindClient.AutoSize = true;
            this.chkbFindClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbFindClient.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chkbFindClient.Location = new System.Drawing.Point(170, 67);
            this.chkbFindClient.Name = "chkbFindClient";
            this.chkbFindClient.Size = new System.Drawing.Size(111, 24);
            this.chkbFindClient.TabIndex = 4;
            this.chkbFindClient.Tag = "FindClient";
            this.chkbFindClient.Text = "Find Client";
            this.chkbFindClient.UseVisualStyleBackColor = true;
            this.chkbFindClient.CheckedChanged += new System.EventHandler(this.chkbClientsItems_CheckedChanged);
            // 
            // chkbUpdateClient
            // 
            this.chkbUpdateClient.AutoSize = true;
            this.chkbUpdateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbUpdateClient.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chkbUpdateClient.Location = new System.Drawing.Point(25, 107);
            this.chkbUpdateClient.Name = "chkbUpdateClient";
            this.chkbUpdateClient.Size = new System.Drawing.Size(132, 24);
            this.chkbUpdateClient.TabIndex = 3;
            this.chkbUpdateClient.Tag = "UpdateClient";
            this.chkbUpdateClient.Text = "Update Client";
            this.chkbUpdateClient.UseVisualStyleBackColor = true;
            this.chkbUpdateClient.CheckedChanged += new System.EventHandler(this.chkbClientsItems_CheckedChanged);
            // 
            // chkbDeleteClient
            // 
            this.chkbDeleteClient.AutoSize = true;
            this.chkbDeleteClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbDeleteClient.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chkbDeleteClient.Location = new System.Drawing.Point(25, 147);
            this.chkbDeleteClient.Name = "chkbDeleteClient";
            this.chkbDeleteClient.Size = new System.Drawing.Size(128, 24);
            this.chkbDeleteClient.TabIndex = 2;
            this.chkbDeleteClient.Tag = "DeleteClient";
            this.chkbDeleteClient.Text = "Delete Client";
            this.chkbDeleteClient.UseVisualStyleBackColor = true;
            this.chkbDeleteClient.CheckedChanged += new System.EventHandler(this.chkbClientsItems_CheckedChanged);
            // 
            // chkbAddClient
            // 
            this.chkbAddClient.AutoSize = true;
            this.chkbAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbAddClient.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chkbAddClient.Location = new System.Drawing.Point(25, 67);
            this.chkbAddClient.Name = "chkbAddClient";
            this.chkbAddClient.Size = new System.Drawing.Size(108, 24);
            this.chkbAddClient.TabIndex = 1;
            this.chkbAddClient.Tag = "AddClient";
            this.chkbAddClient.Text = "Add Client";
            this.chkbAddClient.UseVisualStyleBackColor = true;
            this.chkbAddClient.CheckedChanged += new System.EventHandler(this.chkbClientsItems_CheckedChanged);
            // 
            // chkbClientsManagement
            // 
            this.chkbClientsManagement.AutoSize = true;
            this.chkbClientsManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbClientsManagement.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.chkbClientsManagement.Location = new System.Drawing.Point(25, 27);
            this.chkbClientsManagement.Name = "chkbClientsManagement";
            this.chkbClientsManagement.Size = new System.Drawing.Size(184, 24);
            this.chkbClientsManagement.TabIndex = 0;
            this.chkbClientsManagement.Tag = "-1";
            this.chkbClientsManagement.Text = "Clients Management";
            this.chkbClientsManagement.UseVisualStyleBackColor = true;
            this.chkbClientsManagement.CheckedChanged += new System.EventHandler(this.chkbClientsManagementFullAccess_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.AutoEllipsis = true;
            this.btnSave.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(626, 654);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 54);
            this.btnSave.TabIndex = 67;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(133, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTitle.Location = new System.Drawing.Point(379, 58);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(342, 54);
            this.lblTitle.TabIndex = 64;
            this.lblTitle.Text = "User Permissions";
            // 
            // frmPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 751);
            this.Controls.Add(this.pnlUserPermissions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPermissions";
            this.Text = "Permissions";
            this.pnlUserPermissions.ResumeLayout(false);
            this.pnlUserPermissions.PerformLayout();
            this.gbTransactions.ResumeLayout(false);
            this.gbTransactions.PerformLayout();
            this.gbCurrencies.ResumeLayout(false);
            this.gbCurrencies.PerformLayout();
            this.gbUsers.ResumeLayout(false);
            this.gbUsers.PerformLayout();
            this.gbClients.ResumeLayout(false);
            this.gbClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUserPermissions;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbClients;
        private System.Windows.Forms.CheckBox chkbAddClient;
        private System.Windows.Forms.CheckBox chkbClientsManagement;
        private System.Windows.Forms.GroupBox gbUsers;
        private System.Windows.Forms.CheckBox chkbListUsers;
        private System.Windows.Forms.CheckBox chkbFindUser;
        private System.Windows.Forms.CheckBox chkbUpdateUser;
        private System.Windows.Forms.CheckBox chkbDeleteUser;
        private System.Windows.Forms.CheckBox chkbAddUser;
        private System.Windows.Forms.CheckBox chkbUsersManagement;
        private System.Windows.Forms.CheckBox chkbListClients;
        private System.Windows.Forms.CheckBox chkbFindClient;
        private System.Windows.Forms.CheckBox chkbUpdateClient;
        private System.Windows.Forms.CheckBox chkbDeleteClient;
        private System.Windows.Forms.GroupBox gbTransactions;
        private System.Windows.Forms.CheckBox chkbListBalances;
        private System.Windows.Forms.CheckBox chkbWithdraw;
        private System.Windows.Forms.CheckBox chkbTransfer;
        private System.Windows.Forms.CheckBox chkbTransferLog;
        private System.Windows.Forms.CheckBox chkbDeposit;
        private System.Windows.Forms.CheckBox chkbTransactionsManagement;
        private System.Windows.Forms.GroupBox gbCurrencies;
        private System.Windows.Forms.CheckBox chkbListCurrencies;
        private System.Windows.Forms.CheckBox chkbFindCurrency;
        private System.Windows.Forms.CheckBox chkbUpdateCurrency;
        private System.Windows.Forms.CheckBox chkbExchangeLog;
        private System.Windows.Forms.CheckBox chkbAddCurrency;
        private System.Windows.Forms.CheckBox chkbCurrencyExchange;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox chkbFullAcess;
        private System.Windows.Forms.CheckBox chkbExchange;
    }
}