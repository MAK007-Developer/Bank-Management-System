using Bank_Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Management_System.UserControlsWinForms.Transactions
{
    public partial class TransferControl : UserControl
    {

        clsUserControlUtil clsUserControlUtil = new clsUserControlUtil();

        clsUserBusinessLogic LoginUser = new clsUserBusinessLogic();

        clsClientBusinessLogic SenderClient = new clsClientBusinessLogic();

        clsClientBusinessLogic ReceiverClient = new clsClientBusinessLogic();

        public TransferControl(clsUserBusinessLogic logedInUser)
        {
            InitializeComponent();

            clsUserControlUtil.CurrentPanel = pnlTransfer;
            this.LoginUser = logedInUser;
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            clsUserControlUtil.ShowUserControl(new TransactionsControl(this.LoginUser));
        }

        private void btnSearchSender_Click(object sender, EventArgs e)
        {

            
            SenderClient = clsClientBusinessLogic.Find(tbAccountFrom.Text);

            if (SenderClient != null)
            {
                tbSenderFirstName.Text = SenderClient.FirstName;
                tbSenderLastName.Text = SenderClient.LastName;
                tbSenderBalance.Text = SenderClient.Balance.ToString();
                
            }
            else
            {
                MessageBox.Show("Couldn't Find Client try a different AccountNumber", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


        private void btnSearchReceiver_Click(object sender, EventArgs e)
        {
            ReceiverClient = clsClientBusinessLogic.Find(tbAccountTo.Text);

            if (ReceiverClient != null)
            {
                tbReceiverFirstName.Text = ReceiverClient.FirstName;
                tbReceiverLastName.Text = ReceiverClient.LastName;
                tbReceiverBalance.Text = ReceiverClient.Balance.ToString();

            }
            else
            {
                MessageBox.Show("Couldn't Find Client try a different AccountNumber", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {

            if (double.TryParse(tbTransferAmount.Text, out double dblTransferAmount))
            {
                if (SenderClient.TransferTo(ReceiverClient, dblTransferAmount))
                {
                    clsClientBusinessLogic.AddNewTransferRecord(LoginUser.UserID, SenderClient.ClientID, 
                        ReceiverClient.ClientID, dblTransferAmount, DateTime.Now);

                    MessageBox.Show("Transfer is done successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Amount exceeds balance or negative amount try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Transfer Amount is not Valid", "Not Valid Entry", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void TransferControl_Load(object sender, EventArgs e)
        {
            if (!clsUserControlUtil.DoesUserHavePermissions(LoginUser, this))
            {
                this.Enabled = false;
                MessageBox.Show("You don't have permission to access this section contact your admin", "No Permission Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
