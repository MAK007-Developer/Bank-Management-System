namespace Bank_Management_System.UserControlsWinForms
{
    partial class ListClientsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListClientsControl));
            this.pnlListClients = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClientsList = new System.Windows.Forms.DataGridView();
            this.pnlListClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlListClients
            // 
            this.pnlListClients.Controls.Add(this.btnBack);
            this.pnlListClients.Controls.Add(this.pictureBox2);
            this.pnlListClients.Controls.Add(this.label1);
            this.pnlListClients.Controls.Add(this.dgvClientsList);
            this.pnlListClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListClients.Location = new System.Drawing.Point(0, 0);
            this.pnlListClients.Name = "pnlListClients";
            this.pnlListClients.Size = new System.Drawing.Size(1000, 789);
            this.pnlListClients.TabIndex = 0;
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
            this.btnBack.TabIndex = 64;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(218, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(236, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(460, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 54);
            this.label1.TabIndex = 47;
            this.label1.Text = "Clients List";
            // 
            // dgvClientsList
            // 
            this.dgvClientsList.AllowUserToAddRows = false;
            this.dgvClientsList.AllowUserToDeleteRows = false;
            this.dgvClientsList.AllowUserToOrderColumns = true;
            this.dgvClientsList.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvClientsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientsList.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvClientsList.Location = new System.Drawing.Point(0, 164);
            this.dgvClientsList.Name = "dgvClientsList";
            this.dgvClientsList.ReadOnly = true;
            this.dgvClientsList.RowHeadersWidth = 51;
            this.dgvClientsList.RowTemplate.Height = 24;
            this.dgvClientsList.Size = new System.Drawing.Size(997, 466);
            this.dgvClientsList.TabIndex = 46;
            // 
            // ListClientsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.pnlListClients);
            this.Name = "ListClientsControl";
            this.Size = new System.Drawing.Size(1000, 789);
            this.Tag = "128";
            this.Load += new System.EventHandler(this.ListClientsControl_Load);
            this.pnlListClients.ResumeLayout(false);
            this.pnlListClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlListClients;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClientsList;
        private System.Windows.Forms.Button btnBack;
    }
}
