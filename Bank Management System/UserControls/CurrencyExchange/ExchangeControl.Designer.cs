namespace Bank_Management_System.UserControlsWinForms.CurrencyExchange
{
    partial class ExchangeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExchangeControl));
            this.pnlExchange = new System.Windows.Forms.Panel();
            this.btnExchange = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCurrencyToCode = new System.Windows.Forms.TextBox();
            this.tbCurrencyFromCode = new System.Windows.Forms.TextBox();
            this.btnSearchTo = new System.Windows.Forms.Button();
            this.btnSearchFrom = new System.Windows.Forms.Button();
            this.lblExchangedAmount = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.tbRateTo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRateFrom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlExchange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlExchange
            // 
            this.pnlExchange.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlExchange.Controls.Add(this.btnExchange);
            this.pnlExchange.Controls.Add(this.label9);
            this.pnlExchange.Controls.Add(this.tbCurrencyToCode);
            this.pnlExchange.Controls.Add(this.tbCurrencyFromCode);
            this.pnlExchange.Controls.Add(this.btnSearchTo);
            this.pnlExchange.Controls.Add(this.btnSearchFrom);
            this.pnlExchange.Controls.Add(this.lblExchangedAmount);
            this.pnlExchange.Controls.Add(this.btnBack);
            this.pnlExchange.Controls.Add(this.tbRateTo);
            this.pnlExchange.Controls.Add(this.label6);
            this.pnlExchange.Controls.Add(this.tbRateFrom);
            this.pnlExchange.Controls.Add(this.label7);
            this.pnlExchange.Controls.Add(this.label5);
            this.pnlExchange.Controls.Add(this.label4);
            this.pnlExchange.Controls.Add(this.tbAmount);
            this.pnlExchange.Controls.Add(this.label3);
            this.pnlExchange.Controls.Add(this.label2);
            this.pnlExchange.Controls.Add(this.label1);
            this.pnlExchange.Controls.Add(this.pictureBox1);
            this.pnlExchange.Controls.Add(this.lblTitle);
            this.pnlExchange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExchange.Location = new System.Drawing.Point(0, 0);
            this.pnlExchange.Name = "pnlExchange";
            this.pnlExchange.Size = new System.Drawing.Size(998, 787);
            this.pnlExchange.TabIndex = 0;
            // 
            // btnExchange
            // 
            this.btnExchange.AutoEllipsis = true;
            this.btnExchange.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnExchange.FlatAppearance.BorderSize = 0;
            this.btnExchange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnExchange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnExchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExchange.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExchange.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExchange.Image = ((System.Drawing.Image)(resources.GetObject("btnExchange.Image")));
            this.btnExchange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExchange.Location = new System.Drawing.Point(717, 679);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(187, 54);
            this.btnExchange.TabIndex = 97;
            this.btnExchange.Text = "Exchange";
            this.btnExchange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExchange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExchange.UseVisualStyleBackColor = false;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label9.Location = new System.Drawing.Point(148, 606);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(285, 23);
            this.label9.TabIndex = 96;
            this.label9.Text = "Exchange Amount must be positive!";
            // 
            // tbCurrencyToCode
            // 
            this.tbCurrencyToCode.BackColor = System.Drawing.Color.AliceBlue;
            this.tbCurrencyToCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrencyToCode.Location = new System.Drawing.Point(634, 314);
            this.tbCurrencyToCode.Name = "tbCurrencyToCode";
            this.tbCurrencyToCode.Size = new System.Drawing.Size(173, 30);
            this.tbCurrencyToCode.TabIndex = 95;
            // 
            // tbCurrencyFromCode
            // 
            this.tbCurrencyFromCode.BackColor = System.Drawing.Color.AliceBlue;
            this.tbCurrencyFromCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrencyFromCode.Location = new System.Drawing.Point(152, 314);
            this.tbCurrencyFromCode.Name = "tbCurrencyFromCode";
            this.tbCurrencyFromCode.Size = new System.Drawing.Size(173, 30);
            this.tbCurrencyFromCode.TabIndex = 94;
            // 
            // btnSearchTo
            // 
            this.btnSearchTo.AutoEllipsis = true;
            this.btnSearchTo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchTo.FlatAppearance.BorderSize = 0;
            this.btnSearchTo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchTo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchTo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearchTo.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchTo.Image")));
            this.btnSearchTo.Location = new System.Drawing.Point(821, 314);
            this.btnSearchTo.Name = "btnSearchTo";
            this.btnSearchTo.Size = new System.Drawing.Size(31, 30);
            this.btnSearchTo.TabIndex = 93;
            this.btnSearchTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchTo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchTo.UseVisualStyleBackColor = false;
            this.btnSearchTo.Click += new System.EventHandler(this.btnSearchTo_Click);
            // 
            // btnSearchFrom
            // 
            this.btnSearchFrom.AutoEllipsis = true;
            this.btnSearchFrom.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchFrom.FlatAppearance.BorderSize = 0;
            this.btnSearchFrom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchFrom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFrom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearchFrom.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchFrom.Image")));
            this.btnSearchFrom.Location = new System.Drawing.Point(340, 314);
            this.btnSearchFrom.Name = "btnSearchFrom";
            this.btnSearchFrom.Size = new System.Drawing.Size(31, 30);
            this.btnSearchFrom.TabIndex = 92;
            this.btnSearchFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchFrom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchFrom.UseVisualStyleBackColor = false;
            this.btnSearchFrom.Click += new System.EventHandler(this.btnSearchFrom_Click);
            // 
            // lblExchangedAmount
            // 
            this.lblExchangedAmount.AutoSize = true;
            this.lblExchangedAmount.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblExchangedAmount.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExchangedAmount.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblExchangedAmount.Location = new System.Drawing.Point(629, 527);
            this.lblExchangedAmount.Name = "lblExchangedAmount";
            this.lblExchangedAmount.Size = new System.Drawing.Size(73, 40);
            this.lblExchangedAmount.TabIndex = 80;
            this.lblExchangedAmount.Text = "????";
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
            this.btnBack.Location = new System.Drawing.Point(92, 680);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 54);
            this.btnBack.TabIndex = 79;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbRateTo
            // 
            this.tbRateTo.BackColor = System.Drawing.Color.AliceBlue;
            this.tbRateTo.Enabled = false;
            this.tbRateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRateTo.Location = new System.Drawing.Point(634, 423);
            this.tbRateTo.Name = "tbRateTo";
            this.tbRateTo.Size = new System.Drawing.Size(173, 30);
            this.tbRateTo.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Location = new System.Drawing.Point(627, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 41);
            this.label6.TabIndex = 77;
            this.label6.Text = "Exchange Rate ($)";
            // 
            // tbRateFrom
            // 
            this.tbRateFrom.BackColor = System.Drawing.Color.AliceBlue;
            this.tbRateFrom.Enabled = false;
            this.tbRateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRateFrom.Location = new System.Drawing.Point(152, 420);
            this.tbRateFrom.Name = "tbRateFrom";
            this.tbRateFrom.Size = new System.Drawing.Size(173, 30);
            this.tbRateFrom.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(123, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(253, 41);
            this.label7.TabIndex = 75;
            this.label7.Text = "Exchange Rate ($)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(282, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(443, 41);
            this.label5.TabIndex = 74;
            this.label5.Text = "Choose a currency to exchange";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(627, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 41);
            this.label4.TabIndex = 72;
            this.label4.Text = "Exchanged Amount";
            // 
            // tbAmount
            // 
            this.tbAmount.BackColor = System.Drawing.Color.AliceBlue;
            this.tbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmount.Location = new System.Drawing.Point(152, 532);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(173, 30);
            this.tbAmount.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(176, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 41);
            this.label3.TabIndex = 70;
            this.label3.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(627, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 41);
            this.label2.TabIndex = 67;
            this.label2.Text = "Currency To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(123, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 41);
            this.label1.TabIndex = 66;
            this.label1.Text = "Currency From";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(152, 53);
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
            this.lblTitle.Location = new System.Drawing.Point(406, 89);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(380, 54);
            this.lblTitle.TabIndex = 64;
            this.lblTitle.Text = "Currency Exchange";
            // 
            // ExchangeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlExchange);
            this.Name = "ExchangeControl";
            this.Size = new System.Drawing.Size(998, 787);
            this.Tag = "262144";
            this.Load += new System.EventHandler(this.ExchangeControl_Load);
            this.pnlExchange.ResumeLayout(false);
            this.pnlExchange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlExchange;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRateTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbRateFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblExchangedAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCurrencyToCode;
        private System.Windows.Forms.TextBox tbCurrencyFromCode;
        private System.Windows.Forms.Button btnSearchTo;
        private System.Windows.Forms.Button btnSearchFrom;
        private System.Windows.Forms.Button btnExchange;
    }
}
