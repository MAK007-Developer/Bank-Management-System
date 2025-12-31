namespace Bank_Management_System.UserControlsWinForms.CurrencyExchange
{
    partial class FindCurrencyControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindCurrencyControl));
            this.pnlFindCurrency = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tbRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCurrencyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCurrencyCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFindCurrency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFindCurrency
            // 
            this.pnlFindCurrency.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlFindCurrency.Controls.Add(this.btnSearch);
            this.pnlFindCurrency.Controls.Add(this.btnBack);
            this.pnlFindCurrency.Controls.Add(this.tbRate);
            this.pnlFindCurrency.Controls.Add(this.label4);
            this.pnlFindCurrency.Controls.Add(this.tbCountry);
            this.pnlFindCurrency.Controls.Add(this.label3);
            this.pnlFindCurrency.Controls.Add(this.tbCurrencyName);
            this.pnlFindCurrency.Controls.Add(this.label1);
            this.pnlFindCurrency.Controls.Add(this.tbCurrencyCode);
            this.pnlFindCurrency.Controls.Add(this.label8);
            this.pnlFindCurrency.Controls.Add(this.label2);
            this.pnlFindCurrency.Controls.Add(this.pictureBox1);
            this.pnlFindCurrency.Controls.Add(this.lblTitle);
            this.pnlFindCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFindCurrency.Location = new System.Drawing.Point(0, 0);
            this.pnlFindCurrency.Name = "pnlFindCurrency";
            this.pnlFindCurrency.Size = new System.Drawing.Size(1000, 789);
            this.pnlFindCurrency.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoEllipsis = true;
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(541, 298);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(31, 30);
            this.btnSearch.TabIndex = 91;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.btnBack.Location = new System.Drawing.Point(60, 631);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 54);
            this.btnBack.TabIndex = 77;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbRate
            // 
            this.tbRate.Enabled = false;
            this.tbRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRate.Location = new System.Drawing.Point(328, 518);
            this.tbRate.Name = "tbRate";
            this.tbRate.Size = new System.Drawing.Size(230, 30);
            this.tbRate.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(79, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 38);
            this.label4.TabIndex = 75;
            this.label4.Text = "Exchange Rate($):";
            // 
            // tbCountry
            // 
            this.tbCountry.Enabled = false;
            this.tbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCountry.Location = new System.Drawing.Point(219, 439);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(461, 30);
            this.tbCountry.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(79, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 38);
            this.label3.TabIndex = 73;
            this.label3.Text = "Country:";
            // 
            // tbCurrencyName
            // 
            this.tbCurrencyName.Enabled = false;
            this.tbCurrencyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrencyName.Location = new System.Drawing.Point(299, 368);
            this.tbCurrencyName.Name = "tbCurrencyName";
            this.tbCurrencyName.Size = new System.Drawing.Size(230, 30);
            this.tbCurrencyName.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(79, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 38);
            this.label1.TabIndex = 71;
            this.label1.Text = "Currency Name:";
            // 
            // tbCurrencyCode
            // 
            this.tbCurrencyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrencyCode.Location = new System.Drawing.Point(299, 298);
            this.tbCurrencyCode.Name = "tbCurrencyCode";
            this.tbCurrencyCode.Size = new System.Drawing.Size(230, 30);
            this.tbCurrencyCode.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label8.Location = new System.Drawing.Point(79, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 38);
            this.label8.TabIndex = 68;
            this.label8.Text = "Currency Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(198, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(594, 41);
            this.label2.TabIndex = 66;
            this.label2.Text = "Search for Currency info by Name or Code";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(167, 57);
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
            this.lblTitle.Location = new System.Drawing.Point(414, 97);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(283, 54);
            this.lblTitle.TabIndex = 64;
            this.lblTitle.Text = "Find Currency";
            // 
            // FindCurrencyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlFindCurrency);
            this.Name = "FindCurrencyControl";
            this.Size = new System.Drawing.Size(1000, 789);
            this.Tag = "131072";
            this.Load += new System.EventHandler(this.FindCurrencyControl_Load);
            this.pnlFindCurrency.ResumeLayout(false);
            this.pnlFindCurrency.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFindCurrency;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbCurrencyCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCurrencyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
    }
}
