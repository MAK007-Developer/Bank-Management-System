namespace Bank_Management_System.UserControlsWinForms
{
    partial class ClientMangementControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientMangementControl));
            this.pnlClientManagement = new System.Windows.Forms.Panel();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.btnFindClient = new System.Windows.Forms.Button();
            this.btnListClients = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlClientManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlClientManagement
            // 
            this.pnlClientManagement.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlClientManagement.Controls.Add(this.guna2TextBox1);
            this.pnlClientManagement.Controls.Add(this.btnDeleteClient);
            this.pnlClientManagement.Controls.Add(this.btnUpdateClient);
            this.pnlClientManagement.Controls.Add(this.btnFindClient);
            this.pnlClientManagement.Controls.Add(this.btnListClients);
            this.pnlClientManagement.Controls.Add(this.btnAddClient);
            this.pnlClientManagement.Controls.Add(this.pictureBox1);
            this.pnlClientManagement.Controls.Add(this.lblTitle);
            this.pnlClientManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClientManagement.Location = new System.Drawing.Point(0, 0);
            this.pnlClientManagement.Name = "pnlClientManagement";
            this.pnlClientManagement.Size = new System.Drawing.Size(1072, 703);
            this.pnlClientManagement.TabIndex = 49;
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDeleteClient.FlatAppearance.BorderSize = 0;
            this.btnDeleteClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClient.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClient.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteClient.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteClient.Image")));
            this.btnDeleteClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteClient.Location = new System.Drawing.Point(544, 495);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(443, 102);
            this.btnDeleteClient.TabIndex = 55;
            this.btnDeleteClient.Text = "Delete Client";
            this.btnDeleteClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnUpdateClient.FlatAppearance.BorderSize = 0;
            this.btnUpdateClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateClient.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClient.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateClient.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateClient.Image")));
            this.btnUpdateClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateClient.Location = new System.Drawing.Point(68, 495);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(443, 102);
            this.btnUpdateClient.TabIndex = 54;
            this.btnUpdateClient.Text = "Update Client";
            this.btnUpdateClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateClient.UseVisualStyleBackColor = false;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // btnFindClient
            // 
            this.btnFindClient.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnFindClient.FlatAppearance.BorderSize = 0;
            this.btnFindClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnFindClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindClient.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindClient.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFindClient.Image = ((System.Drawing.Image)(resources.GetObject("btnFindClient.Image")));
            this.btnFindClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindClient.Location = new System.Drawing.Point(544, 212);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(443, 102);
            this.btnFindClient.TabIndex = 53;
            this.btnFindClient.Text = "Find Client";
            this.btnFindClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindClient.UseVisualStyleBackColor = false;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // btnListClients
            // 
            this.btnListClients.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnListClients.FlatAppearance.BorderSize = 0;
            this.btnListClients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnListClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListClients.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListClients.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnListClients.Image = ((System.Drawing.Image)(resources.GetObject("btnListClients.Image")));
            this.btnListClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListClients.Location = new System.Drawing.Point(68, 354);
            this.btnListClients.Name = "btnListClients";
            this.btnListClients.Size = new System.Drawing.Size(919, 102);
            this.btnListClients.TabIndex = 52;
            this.btnListClients.Text = "List Clients";
            this.btnListClients.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListClients.UseVisualStyleBackColor = false;
            this.btnListClients.Click += new System.EventHandler(this.btnListClients_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAddClient.FlatAppearance.BorderSize = 0;
            this.btnAddClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddClient.Image = ((System.Drawing.Image)(resources.GetObject("btnAddClient.Image")));
            this.btnAddClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddClient.Location = new System.Drawing.Point(68, 212);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(443, 102);
            this.btnAddClient.TabIndex = 51;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTitle.Location = new System.Drawing.Point(336, 106);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(395, 54);
            this.lblTitle.TabIndex = 49;
            this.lblTitle.Text = "Client Management";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.AutoRoundedCorners = true;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconLeft = global::Bank_Management_System.Properties.Resources.HiddenPassword;
            this.guna2TextBox1.IconLeftSize = new System.Drawing.Size(30, 30);
            this.guna2TextBox1.Location = new System.Drawing.Point(758, 124);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(229, 48);
            this.guna2TextBox1.TabIndex = 58;
            this.guna2TextBox1.Tag = "h";
            this.guna2TextBox1.IconLeftClick += new System.EventHandler(this.guna2TextBox1_IconLeftClick);
            // 
            // ClientMangementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlClientManagement);
            this.Name = "ClientMangementControl";
            this.Size = new System.Drawing.Size(1072, 703);
            this.Tag = "1";
            this.Load += new System.EventHandler(this.ClientMangementControl_Load);
            this.pnlClientManagement.ResumeLayout(false);
            this.pnlClientManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlClientManagement;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.Button btnListClients;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
