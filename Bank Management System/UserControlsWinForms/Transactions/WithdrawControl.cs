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
    public partial class WithdrawControl : UserControl
    {


        clsUserControlUtil clsUserControlUtil = new clsUserControlUtil();

        clsUserBusinessLogic LoginUser = new clsUserBusinessLogic();

        clsClientBusinessLogic Client;


        public WithdrawControl()
        {
            InitializeComponent();

            clsUserControlUtil.CurrentPanel = pnlWithdraw;

            
        }


        public WithdrawControl(clsUserBusinessLogic LogedInUser)
        {
            InitializeComponent();

            clsUserControlUtil.CurrentPanel = pnlWithdraw;

            this.LoginUser = LogedInUser;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            clsUserControlUtil.ShowUserControl(new TransactionsControl());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Client = clsClientBusinessLogic.Find(tbAccountNumber.Text);

            if (Client != null)
            {
                tbFirstName.Text = Client.FirstName;
                tbLastName.Text = Client.LastName;
                tbEmail.Text = Client.Email;
                tbPhone.Text = Client.Phone;
                tbPinCode.Text = Client.PinCode;
                tbBalance.Text = Client.Balance.ToString();

            }
            else
            {
                MessageBox.Show("Couldn't Find Client try a different AccountNumber", "Not Found", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbWithdrawAmount.Text, out double dblWithdrawAmount))
            {
                if (Client.Withdraw(dblWithdrawAmount))
                {
                    
                    MessageBox.Show("Withdraw is done successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Withdraw Amount Exceeds Balance or Amount is negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Withdraw Amount is not Valid", "Not Valid Entry", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


        }

        private void WithdrawControl_Load(object sender, EventArgs e)
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
