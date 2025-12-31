namespace Bank_Management_System.UserControlsWinForms.CurrencyExchange
{
    partial class ListCurrenciesControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListCurrenciesControl));
            this.pnlListCurrencies = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvListCurrencies = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlListCurrencies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCurrencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlListCurrencies
            // 
            this.pnlListCurrencies.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlListCurrencies.Controls.Add(this.btnBack);
            this.pnlListCurrencies.Controls.Add(this.dgvListCurrencies);
            this.pnlListCurrencies.Controls.Add(this.pictureBox1);
            this.pnlListCurrencies.Controls.Add(this.lblTitle);
            this.pnlListCurrencies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListCurrencies.Location = new System.Drawing.Point(0, 0);
            this.pnlListCurrencies.Name = "pnlListCurrencies";
            this.pnlListCurrencies.Size = new System.Drawing.Size(1000, 789);
            this.pnlListCurrencies.TabIndex = 1;
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
            this.btnBack.Location = new System.Drawing.Point(63, 668);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 54);
            this.btnBack.TabIndex = 79;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvListCurrencies
            // 
            this.dgvListCurrencies.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvListCurrencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCurrencies.Location = new System.Drawing.Point(3, 220);
            this.dgvListCurrencies.Name = "dgvListCurrencies";
            this.dgvListCurrencies.RowHeadersWidth = 51;
            this.dgvListCurrencies.RowTemplate.Height = 24;
            this.dgvListCurrencies.Size = new System.Drawing.Size(997, 395);
            this.dgvListCurrencies.TabIndex = 66;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 54);
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
            this.lblTitle.Location = new System.Drawing.Point(394, 87);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(296, 54);
            this.lblTitle.TabIndex = 64;
            this.lblTitle.Text = "Currencies List";
            // 
            // ListCurrenciesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlListCurrencies);
            this.Name = "ListCurrenciesControl";
            this.Size = new System.Drawing.Size(1000, 789);
            this.Tag = "65536";
            this.Load += new System.EventHandler(this.ListCurrenciesControl_Load);
            this.pnlListCurrencies.ResumeLayout(false);
            this.pnlListCurrencies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCurrencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlListCurrencies;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvListCurrencies;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
    }
}
