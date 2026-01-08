namespace Bank_Management_System.UserControlsWinForms.Users
{
    partial class UserLoginsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLoginsControl));
            this.pnlListUsersLogins = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsersLogins = new System.Windows.Forms.DataGridView();
            this.pnlListUsersLogins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersLogins)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlListUsersLogins
            // 
            this.pnlListUsersLogins.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlListUsersLogins.Controls.Add(this.btnBack);
            this.pnlListUsersLogins.Controls.Add(this.pictureBox2);
            this.pnlListUsersLogins.Controls.Add(this.label1);
            this.pnlListUsersLogins.Controls.Add(this.dgvUsersLogins);
            this.pnlListUsersLogins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListUsersLogins.Location = new System.Drawing.Point(0, 0);
            this.pnlListUsersLogins.Name = "pnlListUsersLogins";
            this.pnlListUsersLogins.Size = new System.Drawing.Size(1000, 789);
            this.pnlListUsersLogins.TabIndex = 1;
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
            this.btnBack.Location = new System.Drawing.Point(68, 677);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 54);
            this.btnBack.TabIndex = 63;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(154, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(236, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(396, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 54);
            this.label1.TabIndex = 61;
            this.label1.Text = "Users Logins";
            // 
            // dgvUsersLogins
            // 
            this.dgvUsersLogins.AllowUserToAddRows = false;
            this.dgvUsersLogins.AllowUserToDeleteRows = false;
            this.dgvUsersLogins.AllowUserToOrderColumns = true;
            this.dgvUsersLogins.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvUsersLogins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersLogins.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvUsersLogins.Location = new System.Drawing.Point(0, 175);
            this.dgvUsersLogins.Name = "dgvUsersLogins";
            this.dgvUsersLogins.ReadOnly = true;
            this.dgvUsersLogins.RowHeadersWidth = 51;
            this.dgvUsersLogins.RowTemplate.Height = 24;
            this.dgvUsersLogins.Size = new System.Drawing.Size(1001, 477);
            this.dgvUsersLogins.TabIndex = 60;
            // 
            // UserLoginsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlListUsersLogins);
            this.Name = "UserLoginsControl";
            this.Size = new System.Drawing.Size(1000, 789);
            this.Load += new System.EventHandler(this.UserLoginsControl_Load);
            this.pnlListUsersLogins.ResumeLayout(false);
            this.pnlListUsersLogins.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersLogins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlListUsersLogins;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUsersLogins;
    }
}
