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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPermissions));
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("AddClient");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("DeleteClient");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("UpdateClient");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("ListClients");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("FindClient");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("ClientsManagement", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31});
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("AddUser");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("DeleteUser");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("UpdateUser");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("ListUsers");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("FindUser");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("UsersManagement", new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode34,
            treeNode35,
            treeNode36,
            treeNode37});
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("AddCurrency");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("UpdateCurrency");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("ListCurrencies");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("FindCurrency");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("ExchangeCurrency");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("ExchangeLog");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("CurrencyExchange", new System.Windows.Forms.TreeNode[] {
            treeNode39,
            treeNode40,
            treeNode41,
            treeNode42,
            treeNode43,
            treeNode44});
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Deposit");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Withdraw");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("ListBalances");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Transfer");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("TransferLog");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Transactions", new System.Windows.Forms.TreeNode[] {
            treeNode46,
            treeNode47,
            treeNode48,
            treeNode49,
            treeNode50});
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("FullAccess", new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode38,
            treeNode45,
            treeNode51});
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlUserPermissions = new System.Windows.Forms.Panel();
            this.trvPermissions = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlUserPermissions.SuspendLayout();
            this.SuspendLayout();
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
            this.btnBack.Text = "Close";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlUserPermissions
            // 
            this.pnlUserPermissions.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlUserPermissions.Controls.Add(this.trvPermissions);
            this.pnlUserPermissions.Controls.Add(this.btnBack);
            this.pnlUserPermissions.Controls.Add(this.btnSave);
            this.pnlUserPermissions.Controls.Add(this.pictureBox1);
            this.pnlUserPermissions.Controls.Add(this.lblTitle);
            this.pnlUserPermissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserPermissions.Location = new System.Drawing.Point(0, 0);
            this.pnlUserPermissions.Name = "pnlUserPermissions";
            this.pnlUserPermissions.Size = new System.Drawing.Size(950, 740);
            this.pnlUserPermissions.TabIndex = 1;
            // 
            // trvPermissions
            // 
            this.trvPermissions.BackColor = System.Drawing.Color.LightSteelBlue;
            this.trvPermissions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trvPermissions.CheckBoxes = true;
            this.trvPermissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvPermissions.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.trvPermissions.ImageIndex = 0;
            this.trvPermissions.ImageList = this.imageList1;
            this.trvPermissions.Location = new System.Drawing.Point(210, 162);
            this.trvPermissions.Name = "trvPermissions";
            treeNode27.Name = "ndAddClient";
            treeNode27.Tag = "1";
            treeNode27.Text = "AddClient";
            treeNode28.ImageKey = "Delete User Client Icon Ready.png";
            treeNode28.Name = "ndDeleteClient";
            treeNode28.Tag = "2";
            treeNode28.Text = "DeleteClient";
            treeNode29.ImageKey = "Update Client or User Ready Icon.png";
            treeNode29.Name = "ndUpdateClient";
            treeNode29.Tag = "4";
            treeNode29.Text = "UpdateClient";
            treeNode30.ImageKey = "List Clients. Icon Readypng.png";
            treeNode30.Name = "ndListClients";
            treeNode30.Tag = "8";
            treeNode30.Text = "ListClients";
            treeNode31.ImageKey = "Find Client.png";
            treeNode31.Name = "ndFindClient";
            treeNode31.Tag = "16";
            treeNode31.Text = "FindClient";
            treeNode32.ImageKey = "User Client Management Icon Ready.png";
            treeNode32.Name = "ndClientsManagement";
            treeNode32.Tag = "-1";
            treeNode32.Text = "ClientsManagement";
            treeNode33.Name = "ndAddUser";
            treeNode33.Tag = "1";
            treeNode33.Text = "AddUser";
            treeNode34.ImageKey = "Delete User Client Icon Ready.png";
            treeNode34.Name = "ndDeleteUser";
            treeNode34.Tag = "2";
            treeNode34.Text = "DeleteUser";
            treeNode35.ImageKey = "Update Client or User Ready Icon.png";
            treeNode35.Name = "ndUpdateUser";
            treeNode35.Tag = "4";
            treeNode35.Text = "UpdateUser";
            treeNode36.ImageKey = "List Clients. Icon Readypng.png";
            treeNode36.Name = "ndListUsers";
            treeNode36.Tag = "8";
            treeNode36.Text = "ListUsers";
            treeNode37.ImageKey = "Find Client.png";
            treeNode37.Name = "ndFindUser";
            treeNode37.Tag = "16";
            treeNode37.Text = "FindUser";
            treeNode38.ImageIndex = 24;
            treeNode38.Name = "ndUsersManagement";
            treeNode38.Tag = "-1";
            treeNode38.Text = "UsersManagement";
            treeNode39.ImageKey = "AddNewCurrency icon.png";
            treeNode39.Name = "ndAddCurrency";
            treeNode39.Tag = "1";
            treeNode39.Text = "AddCurrency";
            treeNode40.ImageKey = "Currency Update Icon Colored.png";
            treeNode40.Name = "ndUpdateCurrency";
            treeNode40.Tag = "2";
            treeNode40.Text = "UpdateCurrency";
            treeNode41.ImageKey = "List Currencies Icon.png";
            treeNode41.Name = "ndListCurrencies";
            treeNode41.Tag = "4";
            treeNode41.Text = "ListCurrencies";
            treeNode42.ImageKey = "Find Client.png";
            treeNode42.Name = "ndFindCurrency";
            treeNode42.Tag = "8";
            treeNode42.Text = "FindCurrency";
            treeNode43.ImageKey = "Currency Exchange Icon Ready.png";
            treeNode43.Name = "ndExchangeCurrency";
            treeNode43.Tag = "16";
            treeNode43.Text = "ExchangeCurrency";
            treeNode44.ImageKey = "Transfer Log Icon Colored BW.png";
            treeNode44.Name = "ndExchangeLog";
            treeNode44.Tag = "32";
            treeNode44.Text = "ExchangeLog";
            treeNode45.ImageIndex = 4;
            treeNode45.Name = "ndCurrencyExchange";
            treeNode45.Tag = "-1";
            treeNode45.Text = "CurrencyExchange";
            treeNode46.ImageKey = "Deposit1 icon.png";
            treeNode46.Name = "ndDeposit";
            treeNode46.Tag = "1";
            treeNode46.Text = "Deposit";
            treeNode47.ImageKey = "Withdraw Icon.png";
            treeNode47.Name = "ndWithdraw";
            treeNode47.Tag = "2";
            treeNode47.Text = "Withdraw";
            treeNode48.ImageKey = "List Balances Icon.png";
            treeNode48.Name = "ndListBalances";
            treeNode48.Tag = "4";
            treeNode48.Text = "ListBalances";
            treeNode49.ImageKey = "Transfer icon Colored.png";
            treeNode49.Name = "ndTransfer";
            treeNode49.Tag = "8";
            treeNode49.Text = "Transfer";
            treeNode50.ImageKey = "Transfer Log Icon Colored BW.png";
            treeNode50.Name = "ndTransferLog";
            treeNode50.Tag = "16";
            treeNode50.Text = "TransferLog";
            treeNode51.ImageKey = "Transfer butt Icon.png";
            treeNode51.Name = "ndTransactions";
            treeNode51.Tag = "-1";
            treeNode51.Text = "Transactions";
            treeNode52.ImageKey = "Bank Logo.ico";
            treeNode52.Name = "ndFullAccess";
            treeNode52.Tag = "-1";
            treeNode52.Text = "FullAccess";
            this.trvPermissions.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode52});
            this.trvPermissions.SelectedImageIndex = 0;
            this.trvPermissions.Size = new System.Drawing.Size(497, 473);
            this.trvPermissions.TabIndex = 75;
            this.trvPermissions.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trvPermissions_AfterCheck);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Add New Client or User Icon Ready.png");
            this.imageList1.Images.SetKeyName(1, "AddNewCurrency icon.png");
            this.imageList1.Images.SetKeyName(2, "Bank Logo.ico");
            this.imageList1.Images.SetKeyName(3, "Colored Stack of Money Icon Ready.png");
            this.imageList1.Images.SetKeyName(4, "Currency Exchange Icon Ready.png");
            this.imageList1.Images.SetKeyName(5, "Delete User Client Icon Ready.png");
            this.imageList1.Images.SetKeyName(6, "Deposit1 icon smaller.png");
            this.imageList1.Images.SetKeyName(7, "Deposit1 icon.png");
            this.imageList1.Images.SetKeyName(8, "ExposedPassword.png");
            this.imageList1.Images.SetKeyName(9, "Find Client.png");
            this.imageList1.Images.SetKeyName(10, "HiddenPassword.png");
            this.imageList1.Images.SetKeyName(11, "List Balances Icon.png");
            this.imageList1.Images.SetKeyName(12, "List Clients. Icon Readypng.png");
            this.imageList1.Images.SetKeyName(13, "List Currencies Icon.png");
            this.imageList1.Images.SetKeyName(14, "logout new icon.png");
            this.imageList1.Images.SetKeyName(15, "Permissions+ Icon edit.png");
            this.imageList1.Images.SetKeyName(16, "Permissions+ Icon.png");
            this.imageList1.Images.SetKeyName(17, "Permissions+.ico");
            this.imageList1.Images.SetKeyName(18, "Save icon small.png");
            this.imageList1.Images.SetKeyName(19, "Transfer butt Icon.png");
            this.imageList1.Images.SetKeyName(20, "Transfer icon Colored.png");
            this.imageList1.Images.SetKeyName(21, "Transfer Log Icon.png");
            this.imageList1.Images.SetKeyName(22, "Update Client or User Ready Icon.png");
            this.imageList1.Images.SetKeyName(23, "User Client Management Icon Ready.png");
            this.imageList1.Images.SetKeyName(24, "User Client Management Logo1.png");
            this.imageList1.Images.SetKeyName(25, "Withdraw Icon small.png");
            this.imageList1.Images.SetKeyName(26, "Withdraw Icon.png");
            this.imageList1.Images.SetKeyName(27, "Currency Update Icon Colored.png");
            this.imageList1.Images.SetKeyName(28, "Transfer Log Icon Colored BW.png");
            // 
            // frmPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 740);
            this.Controls.Add(this.pnlUserPermissions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPermissions";
            this.Text = "Permissions";
            this.Load += new System.EventHandler(this.frmPermissions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlUserPermissions.ResumeLayout(false);
            this.pnlUserPermissions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlUserPermissions;
        private System.Windows.Forms.TreeView trvPermissions;
        private System.Windows.Forms.ImageList imageList1;
    }
}