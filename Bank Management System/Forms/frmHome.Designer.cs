namespace Bank_Management_System
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.DateTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.LnkLblDevelopedBy = new System.Windows.Forms.LinkLabel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCurrencyExchange = new System.Windows.Forms.Button();
            this.btnTransactionsManagement = new System.Windows.Forms.Button();
            this.btnUsersMangement = new System.Windows.Forms.Button();
            this.btnClientsMangement = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlShowContent = new System.Windows.Forms.Panel();
            this.pnlUserAndDateTime = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblLogedInUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlShowContent.SuspendLayout();
            this.pnlUserAndDateTime.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTimeTimer
            // 
            this.DateTimeTimer.Enabled = true;
            this.DateTimeTimer.Tick += new System.EventHandler(this.DateTimeTimer_Tick);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSidebar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnlSidebar.Controls.Add(this.LnkLblDevelopedBy);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnHome);
            this.pnlSidebar.Controls.Add(this.btnCurrencyExchange);
            this.pnlSidebar.Controls.Add(this.btnTransactionsManagement);
            this.pnlSidebar.Controls.Add(this.btnUsersMangement);
            this.pnlSidebar.Controls.Add(this.btnClientsMangement);
            this.pnlSidebar.Controls.Add(this.pictureBox2);
            this.pnlSidebar.Controls.Add(this.label2);
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(413, 1005);
            this.pnlSidebar.TabIndex = 29;
            // 
            // LnkLblDevelopedBy
            // 
            this.LnkLblDevelopedBy.AutoSize = true;
            this.LnkLblDevelopedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkLblDevelopedBy.LinkColor = System.Drawing.Color.Lavender;
            this.LnkLblDevelopedBy.Location = new System.Drawing.Point(35, 912);
            this.LnkLblDevelopedBy.Name = "LnkLblDevelopedBy";
            this.LnkLblDevelopedBy.Size = new System.Drawing.Size(134, 25);
            this.LnkLblDevelopedBy.TabIndex = 32;
            this.LnkLblDevelopedBy.TabStop = true;
            this.LnkLblDevelopedBy.Text = "Developed By";
            this.LnkLblDevelopedBy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblDevelopedBy_LinkClicked);
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(6, 776);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(401, 96);
            this.btnLogout.TabIndex = 31;
            this.btnLogout.Text = "Log out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(6, 214);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(401, 96);
            this.btnHome.TabIndex = 30;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCurrencyExchange
            // 
            this.btnCurrencyExchange.AutoSize = true;
            this.btnCurrencyExchange.FlatAppearance.BorderSize = 0;
            this.btnCurrencyExchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrencyExchange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCurrencyExchange.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCurrencyExchange.Image = ((System.Drawing.Image)(resources.GetObject("btnCurrencyExchange.Image")));
            this.btnCurrencyExchange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurrencyExchange.Location = new System.Drawing.Point(6, 662);
            this.btnCurrencyExchange.Name = "btnCurrencyExchange";
            this.btnCurrencyExchange.Size = new System.Drawing.Size(401, 96);
            this.btnCurrencyExchange.TabIndex = 29;
            this.btnCurrencyExchange.Text = "Currency Exchange";
            this.btnCurrencyExchange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCurrencyExchange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCurrencyExchange.UseVisualStyleBackColor = true;
            this.btnCurrencyExchange.Click += new System.EventHandler(this.btnCurrencyExchange_Click);
            // 
            // btnTransactionsManagement
            // 
            this.btnTransactionsManagement.AutoSize = true;
            this.btnTransactionsManagement.FlatAppearance.BorderSize = 0;
            this.btnTransactionsManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionsManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnTransactionsManagement.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTransactionsManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnTransactionsManagement.Image")));
            this.btnTransactionsManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactionsManagement.Location = new System.Drawing.Point(6, 548);
            this.btnTransactionsManagement.Name = "btnTransactionsManagement";
            this.btnTransactionsManagement.Size = new System.Drawing.Size(401, 96);
            this.btnTransactionsManagement.TabIndex = 28;
            this.btnTransactionsManagement.Text = "Transactions Management";
            this.btnTransactionsManagement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransactionsManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransactionsManagement.UseVisualStyleBackColor = true;
            this.btnTransactionsManagement.Click += new System.EventHandler(this.btnTransactionsManagement_Click);
            // 
            // btnUsersMangement
            // 
            this.btnUsersMangement.FlatAppearance.BorderSize = 0;
            this.btnUsersMangement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsersMangement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUsersMangement.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUsersMangement.Image = ((System.Drawing.Image)(resources.GetObject("btnUsersMangement.Image")));
            this.btnUsersMangement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsersMangement.Location = new System.Drawing.Point(6, 438);
            this.btnUsersMangement.Name = "btnUsersMangement";
            this.btnUsersMangement.Size = new System.Drawing.Size(401, 96);
            this.btnUsersMangement.TabIndex = 27;
            this.btnUsersMangement.Text = "Users Management";
            this.btnUsersMangement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsersMangement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsersMangement.UseVisualStyleBackColor = true;
            this.btnUsersMangement.Click += new System.EventHandler(this.btnUsersMangement_Click);
            // 
            // btnClientsMangement
            // 
            this.btnClientsMangement.FlatAppearance.BorderSize = 0;
            this.btnClientsMangement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientsMangement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClientsMangement.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClientsMangement.Image = ((System.Drawing.Image)(resources.GetObject("btnClientsMangement.Image")));
            this.btnClientsMangement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientsMangement.Location = new System.Drawing.Point(6, 328);
            this.btnClientsMangement.Name = "btnClientsMangement";
            this.btnClientsMangement.Size = new System.Drawing.Size(401, 96);
            this.btnClientsMangement.TabIndex = 26;
            this.btnClientsMangement.Text = "Clients Management";
            this.btnClientsMangement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientsMangement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientsMangement.UseVisualStyleBackColor = true;
            this.btnClientsMangement.Click += new System.EventHandler(this.btnClientsMangement_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(72, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(236, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(106, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 45);
            this.label2.TabIndex = 23;
            this.label2.Text = "Welcome";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlMain.Controls.Add(this.pnlShowContent);
            this.pnlMain.Controls.Add(this.pnlSidebar);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1491, 1005);
            this.pnlMain.TabIndex = 28;
            // 
            // pnlShowContent
            // 
            this.pnlShowContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlShowContent.Controls.Add(this.pnlUserAndDateTime);
            this.pnlShowContent.Controls.Add(this.pnlContent);
            this.pnlShowContent.Location = new System.Drawing.Point(413, 0);
            this.pnlShowContent.Name = "pnlShowContent";
            this.pnlShowContent.Size = new System.Drawing.Size(1078, 1005);
            this.pnlShowContent.TabIndex = 30;
            // 
            // pnlUserAndDateTime
            // 
            this.pnlUserAndDateTime.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlUserAndDateTime.Controls.Add(this.lblDateTime);
            this.pnlUserAndDateTime.Controls.Add(this.lblLogedInUser);
            this.pnlUserAndDateTime.Controls.Add(this.label3);
            this.pnlUserAndDateTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserAndDateTime.Location = new System.Drawing.Point(0, 0);
            this.pnlUserAndDateTime.Name = "pnlUserAndDateTime";
            this.pnlUserAndDateTime.Size = new System.Drawing.Size(1078, 80);
            this.pnlUserAndDateTime.TabIndex = 30;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDateTime.Location = new System.Drawing.Point(544, 22);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(119, 32);
            this.lblDateTime.TabIndex = 25;
            this.lblDateTime.Text = "DateTime";
            // 
            // lblLogedInUser
            // 
            this.lblLogedInUser.AutoSize = true;
            this.lblLogedInUser.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogedInUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLogedInUser.Location = new System.Drawing.Point(195, 22);
            this.lblLogedInUser.Name = "lblLogedInUser";
            this.lblLogedInUser.Size = new System.Drawing.Size(63, 32);
            this.lblLogedInUser.TabIndex = 27;
            this.lblLogedInUser.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(20, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 32);
            this.label3.TabIndex = 26;
            this.label3.Text = "Current User:";
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContent.Controls.Add(this.pictureBox1);
            this.pnlContent.Location = new System.Drawing.Point(51, 105);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(985, 789);
            this.pnlContent.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(86, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(819, 769);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 1005);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.Text = "Bank System";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlShowContent.ResumeLayout(false);
            this.pnlUserAndDateTime.ResumeLayout(false);
            this.pnlUserAndDateTime.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer DateTimeTimer;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.LinkLabel LnkLblDevelopedBy;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCurrencyExchange;
        private System.Windows.Forms.Button btnTransactionsManagement;
        private System.Windows.Forms.Button btnUsersMangement;
        private System.Windows.Forms.Button btnClientsMangement;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlShowContent;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlUserAndDateTime;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblLogedInUser;
        private System.Windows.Forms.Label label3;
    }
}