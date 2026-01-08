namespace Bank_Management_System.UserControlsWinForms
{
    partial class TransactionsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionsControl));
            this.pnlTransactions = new System.Windows.Forms.Panel();
            this.btnTransferLog = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnListBalances = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTransactions
            // 
            this.pnlTransactions.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlTransactions.Controls.Add(this.btnTransferLog);
            this.pnlTransactions.Controls.Add(this.btnTransfer);
            this.pnlTransactions.Controls.Add(this.btnListBalances);
            this.pnlTransactions.Controls.Add(this.btnWithdraw);
            this.pnlTransactions.Controls.Add(this.btnDeposit);
            this.pnlTransactions.Controls.Add(this.pictureBox1);
            this.pnlTransactions.Controls.Add(this.lblTitle);
            this.pnlTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransactions.Location = new System.Drawing.Point(0, 0);
            this.pnlTransactions.Name = "pnlTransactions";
            this.pnlTransactions.Size = new System.Drawing.Size(1000, 789);
            this.pnlTransactions.TabIndex = 51;
            // 
            // btnTransferLog
            // 
            this.btnTransferLog.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnTransferLog.FlatAppearance.BorderSize = 0;
            this.btnTransferLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnTransferLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferLog.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferLog.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTransferLog.Image = ((System.Drawing.Image)(resources.GetObject("btnTransferLog.Image")));
            this.btnTransferLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransferLog.Location = new System.Drawing.Point(516, 523);
            this.btnTransferLog.Name = "btnTransferLog";
            this.btnTransferLog.Size = new System.Drawing.Size(443, 102);
            this.btnTransferLog.TabIndex = 56;
            this.btnTransferLog.Text = "Transfer Log";
            this.btnTransferLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransferLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransferLog.UseVisualStyleBackColor = false;
            this.btnTransferLog.Click += new System.EventHandler(this.btnTransferLog_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTransfer.Image = ((System.Drawing.Image)(resources.GetObject("btnTransfer.Image")));
            this.btnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.Location = new System.Drawing.Point(40, 523);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(443, 102);
            this.btnTransfer.TabIndex = 55;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnListBalances
            // 
            this.btnListBalances.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnListBalances.FlatAppearance.BorderSize = 0;
            this.btnListBalances.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnListBalances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListBalances.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListBalances.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnListBalances.Image = ((System.Drawing.Image)(resources.GetObject("btnListBalances.Image")));
            this.btnListBalances.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListBalances.Location = new System.Drawing.Point(40, 387);
            this.btnListBalances.Name = "btnListBalances";
            this.btnListBalances.Size = new System.Drawing.Size(919, 102);
            this.btnListBalances.TabIndex = 54;
            this.btnListBalances.Text = "List Balances";
            this.btnListBalances.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListBalances.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListBalances.UseVisualStyleBackColor = false;
            this.btnListBalances.Click += new System.EventHandler(this.btnListBalances_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnWithdraw.FlatAppearance.BorderSize = 0;
            this.btnWithdraw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnWithdraw.Image = ((System.Drawing.Image)(resources.GetObject("btnWithdraw.Image")));
            this.btnWithdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdraw.Location = new System.Drawing.Point(516, 252);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(443, 102);
            this.btnWithdraw.TabIndex = 53;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWithdraw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDeposit.FlatAppearance.BorderSize = 0;
            this.btnDeposit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeposit.Image = ((System.Drawing.Image)(resources.GetObject("btnDeposit.Image")));
            this.btnDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeposit.Location = new System.Drawing.Point(40, 252);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(443, 102);
            this.btnDeposit.TabIndex = 52;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeposit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
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
            this.lblTitle.Size = new System.Drawing.Size(520, 54);
            this.lblTitle.TabIndex = 41;
            this.lblTitle.Text = "Transactions Management";
            // 
            // TransactionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTransactions);
            this.Name = "TransactionsControl";
            this.Size = new System.Drawing.Size(1000, 789);
            this.Tag = "8";
            this.Load += new System.EventHandler(this.TransactionsControl_Load);
            this.pnlTransactions.ResumeLayout(false);
            this.pnlTransactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTransactions;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnListBalances;
        private System.Windows.Forms.Button btnTransferLog;
    }
}
