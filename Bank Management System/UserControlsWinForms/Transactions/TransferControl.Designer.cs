namespace Bank_Management_System.UserControlsWinForms.Transactions
{
    partial class TransferControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferControl));
            this.pnlTransfer = new System.Windows.Forms.Panel();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbTransferAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbReceiverBalance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbReceiverLastName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbReceiverFirstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSenderBalance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSenderLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSenderFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbAccountTo = new System.Windows.Forms.TextBox();
            this.btnSearchReceiver = new System.Windows.Forms.Button();
            this.tbAccountFrom = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTransfer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTransfer
            // 
            this.pnlTransfer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlTransfer.Controls.Add(this.btnTransfer);
            this.pnlTransfer.Controls.Add(this.label11);
            this.pnlTransfer.Controls.Add(this.tbTransferAmount);
            this.pnlTransfer.Controls.Add(this.label10);
            this.pnlTransfer.Controls.Add(this.tbReceiverBalance);
            this.pnlTransfer.Controls.Add(this.label7);
            this.pnlTransfer.Controls.Add(this.tbReceiverLastName);
            this.pnlTransfer.Controls.Add(this.label8);
            this.pnlTransfer.Controls.Add(this.tbReceiverFirstName);
            this.pnlTransfer.Controls.Add(this.label9);
            this.pnlTransfer.Controls.Add(this.tbSenderBalance);
            this.pnlTransfer.Controls.Add(this.label6);
            this.pnlTransfer.Controls.Add(this.tbSenderLastName);
            this.pnlTransfer.Controls.Add(this.label4);
            this.pnlTransfer.Controls.Add(this.tbSenderFirstName);
            this.pnlTransfer.Controls.Add(this.label5);
            this.pnlTransfer.Controls.Add(this.panel2);
            this.pnlTransfer.Controls.Add(this.label1);
            this.pnlTransfer.Controls.Add(this.btnBack);
            this.pnlTransfer.Controls.Add(this.pictureBox1);
            this.pnlTransfer.Controls.Add(this.lblTitle);
            this.pnlTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransfer.Location = new System.Drawing.Point(0, 0);
            this.pnlTransfer.Name = "pnlTransfer";
            this.pnlTransfer.Size = new System.Drawing.Size(1000, 789);
            this.pnlTransfer.TabIndex = 0;
            // 
            // btnTransfer
            // 
            this.btnTransfer.AutoEllipsis = true;
            this.btnTransfer.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnTransfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTransfer.Image = ((System.Drawing.Image)(resources.GetObject("btnTransfer.Image")));
            this.btnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.Location = new System.Drawing.Point(708, 676);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(187, 54);
            this.btnTransfer.TabIndex = 102;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label11.Location = new System.Drawing.Point(65, 611);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(588, 23);
            this.label11.TabIndex = 101;
            this.label11.Text = "Transfer amount must be positive and should not exceed Accounts balance!";
            // 
            // tbTransferAmount
            // 
            this.tbTransferAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTransferAmount.Location = new System.Drawing.Point(65, 553);
            this.tbTransferAmount.Name = "tbTransferAmount";
            this.tbTransferAmount.Size = new System.Drawing.Size(231, 30);
            this.tbTransferAmount.TabIndex = 100;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label10.Location = new System.Drawing.Point(62, 502);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 38);
            this.label10.TabIndex = 99;
            this.label10.Text = "Transfer Amount:";
            // 
            // tbReceiverBalance
            // 
            this.tbReceiverBalance.Enabled = false;
            this.tbReceiverBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReceiverBalance.Location = new System.Drawing.Point(697, 445);
            this.tbReceiverBalance.Name = "tbReceiverBalance";
            this.tbReceiverBalance.Size = new System.Drawing.Size(231, 30);
            this.tbReceiverBalance.TabIndex = 98;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(534, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 38);
            this.label7.TabIndex = 97;
            this.label7.Text = "Balance:";
            // 
            // tbReceiverLastName
            // 
            this.tbReceiverLastName.Enabled = false;
            this.tbReceiverLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReceiverLastName.Location = new System.Drawing.Point(697, 386);
            this.tbReceiverLastName.Name = "tbReceiverLastName";
            this.tbReceiverLastName.Size = new System.Drawing.Size(231, 30);
            this.tbReceiverLastName.TabIndex = 96;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label8.Location = new System.Drawing.Point(534, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 38);
            this.label8.TabIndex = 95;
            this.label8.Text = "Last Name:";
            // 
            // tbReceiverFirstName
            // 
            this.tbReceiverFirstName.BackColor = System.Drawing.Color.AliceBlue;
            this.tbReceiverFirstName.Enabled = false;
            this.tbReceiverFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReceiverFirstName.Location = new System.Drawing.Point(697, 332);
            this.tbReceiverFirstName.Name = "tbReceiverFirstName";
            this.tbReceiverFirstName.Size = new System.Drawing.Size(231, 30);
            this.tbReceiverFirstName.TabIndex = 94;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label9.Location = new System.Drawing.Point(534, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 38);
            this.label9.TabIndex = 93;
            this.label9.Text = "First Name:";
            // 
            // tbSenderBalance
            // 
            this.tbSenderBalance.Enabled = false;
            this.tbSenderBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSenderBalance.Location = new System.Drawing.Point(207, 447);
            this.tbSenderBalance.Name = "tbSenderBalance";
            this.tbSenderBalance.Size = new System.Drawing.Size(231, 30);
            this.tbSenderBalance.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Location = new System.Drawing.Point(44, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 38);
            this.label6.TabIndex = 91;
            this.label6.Text = "Balance:";
            // 
            // tbSenderLastName
            // 
            this.tbSenderLastName.Enabled = false;
            this.tbSenderLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSenderLastName.Location = new System.Drawing.Point(207, 389);
            this.tbSenderLastName.Name = "tbSenderLastName";
            this.tbSenderLastName.Size = new System.Drawing.Size(231, 30);
            this.tbSenderLastName.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(44, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 38);
            this.label4.TabIndex = 89;
            this.label4.Text = "Last Name:";
            // 
            // tbSenderFirstName
            // 
            this.tbSenderFirstName.BackColor = System.Drawing.Color.AliceBlue;
            this.tbSenderFirstName.Enabled = false;
            this.tbSenderFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSenderFirstName.Location = new System.Drawing.Point(207, 331);
            this.tbSenderFirstName.Name = "tbSenderFirstName";
            this.tbSenderFirstName.Size = new System.Drawing.Size(231, 30);
            this.tbSenderFirstName.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(44, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 38);
            this.label5.TabIndex = 87;
            this.label5.Text = "First Name:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Controls.Add(this.tbAccountTo);
            this.panel2.Controls.Add(this.btnSearchReceiver);
            this.panel2.Controls.Add(this.tbAccountFrom);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(3, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 71);
            this.panel2.TabIndex = 86;
            // 
            // tbAccountTo
            // 
            this.tbAccountTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccountTo.Location = new System.Drawing.Point(746, 23);
            this.tbAccountTo.MaxLength = 4;
            this.tbAccountTo.Name = "tbAccountTo";
            this.tbAccountTo.Size = new System.Drawing.Size(109, 30);
            this.tbAccountTo.TabIndex = 91;
            // 
            // btnSearchReceiver
            // 
            this.btnSearchReceiver.AutoEllipsis = true;
            this.btnSearchReceiver.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSearchReceiver.FlatAppearance.BorderSize = 0;
            this.btnSearchReceiver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchReceiver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchReceiver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchReceiver.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchReceiver.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearchReceiver.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchReceiver.Image")));
            this.btnSearchReceiver.Location = new System.Drawing.Point(869, 23);
            this.btnSearchReceiver.Name = "btnSearchReceiver";
            this.btnSearchReceiver.Size = new System.Drawing.Size(31, 30);
            this.btnSearchReceiver.TabIndex = 90;
            this.btnSearchReceiver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchReceiver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchReceiver.UseVisualStyleBackColor = false;
            this.btnSearchReceiver.Click += new System.EventHandler(this.btnSearchReceiver_Click);
            // 
            // tbAccountFrom
            // 
            this.tbAccountFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccountFrom.Location = new System.Drawing.Point(238, 22);
            this.tbAccountFrom.MaxLength = 4;
            this.tbAccountFrom.Name = "tbAccountFrom";
            this.tbAccountFrom.Size = new System.Drawing.Size(109, 30);
            this.tbAccountFrom.TabIndex = 89;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoEllipsis = true;
            this.btnSearch.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(361, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(31, 30);
            this.btnSearch.TabIndex = 88;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearchSender_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(23, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 41);
            this.label2.TabIndex = 87;
            this.label2.Text = "Account From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(567, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 41);
            this.label3.TabIndex = 86;
            this.label3.Text = "Account To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(232, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 41);
            this.label1.TabIndex = 83;
            this.label1.Text = "Transfer money between Accounts";
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
            this.btnBack.Location = new System.Drawing.Point(101, 676);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 54);
            this.btnBack.TabIndex = 82;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(274, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTitle.Location = new System.Drawing.Point(520, 59);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(176, 54);
            this.lblTitle.TabIndex = 80;
            this.lblTitle.Text = "Transfer";
            // 
            // TransferControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTransfer);
            this.Name = "TransferControl";
            this.Size = new System.Drawing.Size(1000, 789);
            this.Tag = "8388608";
            this.Load += new System.EventHandler(this.TransferControl_Load);
            this.pnlTransfer.ResumeLayout(false);
            this.pnlTransfer.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTransfer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAccountFrom;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbAccountTo;
        private System.Windows.Forms.Button btnSearchReceiver;
        private System.Windows.Forms.TextBox tbReceiverBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbReceiverLastName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbReceiverFirstName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSenderBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSenderLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSenderFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbTransferAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnTransfer;
    }
}
