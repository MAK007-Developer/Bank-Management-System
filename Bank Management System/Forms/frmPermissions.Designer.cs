namespace Bank_Management_System.Forms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("AddClient");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("DeleteClient");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("UpdateClient");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("ListClients");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("FindClient");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("ClientsManagement", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("AddUser");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("DeleteUser");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("UpdateUser");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("ListUsers");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("FindUser");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("UsersManagement", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("AddCurrency");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("UpdateCurrency");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("ListCurrencies");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("FindCurrency");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("ExchangeCurrency");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("ExchangeLog");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("CurrencyExchange", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Deposit");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Withdraw");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("ListBalances");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Transfer");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("TransferLog");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Transactions", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("FullAccess", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode12,
            treeNode19,
            treeNode25});
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
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
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
            treeNode1.Name = "ndAddClient";
            treeNode1.Tag = "1";
            treeNode1.Text = "AddClient";
            treeNode2.ImageKey = "Delete User Client Icon Ready.png";
            treeNode2.Name = "ndDeleteClient";
            treeNode2.Tag = "2";
            treeNode2.Text = "DeleteClient";
            treeNode3.ImageKey = "Update Client or User Ready Icon.png";
            treeNode3.Name = "ndUpdateClient";
            treeNode3.Tag = "4";
            treeNode3.Text = "UpdateClient";
            treeNode4.ImageKey = "List Clients. Icon Readypng.png";
            treeNode4.Name = "ndListClients";
            treeNode4.Tag = "8";
            treeNode4.Text = "ListClients";
            treeNode5.ImageKey = "Find Client.png";
            treeNode5.Name = "ndFindClient";
            treeNode5.Tag = "16";
            treeNode5.Text = "FindClient";
            treeNode6.ImageKey = "User Client Management Icon Ready.png";
            treeNode6.Name = "ndClientsManagement";
            treeNode6.Tag = "-1";
            treeNode6.Text = "ClientsManagement";
            treeNode7.Name = "ndAddUser";
            treeNode7.Tag = "1";
            treeNode7.Text = "AddUser";
            treeNode8.ImageKey = "Delete User Client Icon Ready.png";
            treeNode8.Name = "ndDeleteUser";
            treeNode8.Tag = "2";
            treeNode8.Text = "DeleteUser";
            treeNode9.ImageKey = "Update Client or User Ready Icon.png";
            treeNode9.Name = "ndUpdateUser";
            treeNode9.Tag = "4";
            treeNode9.Text = "UpdateUser";
            treeNode10.ImageKey = "List Clients. Icon Readypng.png";
            treeNode10.Name = "ndListUsers";
            treeNode10.Tag = "8";
            treeNode10.Text = "ListUsers";
            treeNode11.ImageKey = "Find Client.png";
            treeNode11.Name = "ndFindUser";
            treeNode11.Tag = "16";
            treeNode11.Text = "FindUser";
            treeNode12.ImageIndex = 24;
            treeNode12.Name = "ndUsersManagement";
            treeNode12.Tag = "-1";
            treeNode12.Text = "UsersManagement";
            treeNode13.ImageKey = "AddNewCurrency icon.png";
            treeNode13.Name = "ndAddCurrency";
            treeNode13.Tag = "1";
            treeNode13.Text = "AddCurrency";
            treeNode14.ImageKey = "Currency Update Icon Colored.png";
            treeNode14.Name = "ndUpdateCurrency";
            treeNode14.Tag = "2";
            treeNode14.Text = "UpdateCurrency";
            treeNode15.ImageKey = "List Currencies Icon.png";
            treeNode15.Name = "ndListCurrencies";
            treeNode15.Tag = "4";
            treeNode15.Text = "ListCurrencies";
            treeNode16.ImageKey = "Find Client.png";
            treeNode16.Name = "ndFindCurrency";
            treeNode16.Tag = "8";
            treeNode16.Text = "FindCurrency";
            treeNode17.ImageKey = "Currency Exchange Icon Ready.png";
            treeNode17.Name = "ndExchangeCurrency";
            treeNode17.Tag = "16";
            treeNode17.Text = "ExchangeCurrency";
            treeNode18.ImageKey = "Transfer Log Icon Colored BW.png";
            treeNode18.Name = "ndExchangeLog";
            treeNode18.Tag = "32";
            treeNode18.Text = "ExchangeLog";
            treeNode19.ImageIndex = 4;
            treeNode19.Name = "ndCurrencyExchange";
            treeNode19.Tag = "-1";
            treeNode19.Text = "CurrencyExchange";
            treeNode20.ImageKey = "Deposit1 icon.png";
            treeNode20.Name = "ndDeposit";
            treeNode20.Tag = "1";
            treeNode20.Text = "Deposit";
            treeNode21.ImageKey = "Withdraw Icon.png";
            treeNode21.Name = "ndWithdraw";
            treeNode21.Tag = "2";
            treeNode21.Text = "Withdraw";
            treeNode22.ImageKey = "List Balances Icon.png";
            treeNode22.Name = "ndListBalances";
            treeNode22.Tag = "4";
            treeNode22.Text = "ListBalances";
            treeNode23.ImageKey = "Transfer icon Colored.png";
            treeNode23.Name = "ndTransfer";
            treeNode23.Tag = "8";
            treeNode23.Text = "Transfer";
            treeNode24.ImageKey = "Transfer Log Icon Colored BW.png";
            treeNode24.Name = "ndTransferLog";
            treeNode24.Tag = "16";
            treeNode24.Text = "TransferLog";
            treeNode25.ImageKey = "Transfer butt Icon.png";
            treeNode25.Name = "ndTransactions";
            treeNode25.Tag = "-1";
            treeNode25.Text = "Transactions";
            treeNode26.ImageKey = "Bank Logo.ico";
            treeNode26.Name = "ndFullAccess";
            treeNode26.Tag = "-1";
            treeNode26.Text = "FullAccess";
            this.trvPermissions.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode26});
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 740);
            this.Controls.Add(this.pnlUserPermissions);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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