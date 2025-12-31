namespace Bank_Management_System.UserControlsWinForms
{
    partial class UsersManagementControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersManagementControl));
            this.pnlUserManagement = new System.Windows.Forms.Panel();
            this.btnUsersLogins = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnFindUser = new System.Windows.Forms.Button();
            this.btnListUsers = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlUserManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUserManagement
            // 
            this.pnlUserManagement.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlUserManagement.Controls.Add(this.btnUsersLogins);
            this.pnlUserManagement.Controls.Add(this.btnDeleteUser);
            this.pnlUserManagement.Controls.Add(this.btnUpdateUser);
            this.pnlUserManagement.Controls.Add(this.btnFindUser);
            this.pnlUserManagement.Controls.Add(this.btnListUsers);
            this.pnlUserManagement.Controls.Add(this.btnAddUser);
            this.pnlUserManagement.Controls.Add(this.pictureBox1);
            this.pnlUserManagement.Controls.Add(this.lblTitle);
            this.pnlUserManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserManagement.Location = new System.Drawing.Point(0, 0);
            this.pnlUserManagement.Name = "pnlUserManagement";
            this.pnlUserManagement.Size = new System.Drawing.Size(1059, 703);
            this.pnlUserManagement.TabIndex = 50;
            // 
            // btnUsersLogins
            // 
            this.btnUsersLogins.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnUsersLogins.FlatAppearance.BorderSize = 0;
            this.btnUsersLogins.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnUsersLogins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsersLogins.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsersLogins.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUsersLogins.Image = ((System.Drawing.Image)(resources.GetObject("btnUsersLogins.Image")));
            this.btnUsersLogins.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsersLogins.Location = new System.Drawing.Point(623, 354);
            this.btnUsersLogins.Name = "btnUsersLogins";
            this.btnUsersLogins.Size = new System.Drawing.Size(358, 102);
            this.btnUsersLogins.TabIndex = 49;
            this.btnUsersLogins.Text = "Users Logins";
            this.btnUsersLogins.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsersLogins.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsersLogins.UseVisualStyleBackColor = false;
            this.btnUsersLogins.Click += new System.EventHandler(this.btnUsersLogins_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteUser.Image")));
            this.btnDeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUser.Location = new System.Drawing.Point(538, 487);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(443, 102);
            this.btnDeleteUser.TabIndex = 48;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnUpdateUser.FlatAppearance.BorderSize = 0;
            this.btnUpdateUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateUser.Image")));
            this.btnUpdateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateUser.Location = new System.Drawing.Point(62, 487);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(443, 102);
            this.btnUpdateUser.TabIndex = 47;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnFindUser
            // 
            this.btnFindUser.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnFindUser.FlatAppearance.BorderSize = 0;
            this.btnFindUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnFindUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindUser.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFindUser.Image = ((System.Drawing.Image)(resources.GetObject("btnFindUser.Image")));
            this.btnFindUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindUser.Location = new System.Drawing.Point(538, 220);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Size = new System.Drawing.Size(443, 102);
            this.btnFindUser.TabIndex = 46;
            this.btnFindUser.Text = "Find User";
            this.btnFindUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindUser.UseVisualStyleBackColor = false;
            this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
            // 
            // btnListUsers
            // 
            this.btnListUsers.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnListUsers.FlatAppearance.BorderSize = 0;
            this.btnListUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnListUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListUsers.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListUsers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnListUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnListUsers.Image")));
            this.btnListUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListUsers.Location = new System.Drawing.Point(62, 354);
            this.btnListUsers.Name = "btnListUsers";
            this.btnListUsers.Size = new System.Drawing.Size(532, 102);
            this.btnListUsers.TabIndex = 44;
            this.btnListUsers.Text = "List Users";
            this.btnListUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListUsers.UseVisualStyleBackColor = false;
            this.btnListUsers.Click += new System.EventHandler(this.btnListUsers_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(62, 220);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(443, 102);
            this.btnAddUser.TabIndex = 43;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(88, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTitle.Location = new System.Drawing.Point(330, 114);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(371, 54);
            this.lblTitle.TabIndex = 41;
            this.lblTitle.Text = "User Management";
            // 
            // UsersManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlUserManagement);
            this.Name = "UsersManagementControl";
            this.Size = new System.Drawing.Size(1059, 703);
            this.Tag = "2";
            this.Load += new System.EventHandler(this.UsersManagementControl_Load);
            this.pnlUserManagement.ResumeLayout(false);
            this.pnlUserManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUserManagement;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnListUsers;
        private System.Windows.Forms.Button btnFindUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnUsersLogins;
    }
}
