using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_Business_Logic_Layer;

namespace Bank_Management_System.UserControlsWinForms.Transactions
{
    public partial class DepositControl : UserControl
    {
        clsUserControlUtil clsUserControlUtil = new clsUserControlUtil();

        clsUserBusinessLogic LoginUser = new clsUserBusinessLogic();

        clsClientBusinessLogic Client;


        public DepositControl()
        {
            InitializeComponent();
            clsUserControlUtil.CurrentPanel = pnlDeposit;
            
        }

        public DepositControl(clsUserBusinessLogic logedInUser)
        {
            InitializeComponent();
            clsUserControlUtil.CurrentPanel = pnlDeposit;
            this.LoginUser = logedInUser;
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
                tbPhone.Text = Client.Phone;
                tbEmail.Text = Client.Email;
                tbPinCode.Text = Client.PinCode;
                tbBalane.Text = Client.Balance.ToString();
            }
            else
            {
                MessageBox.Show("Couldn't Find Client try different AccountNumber", "Not Found", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }


        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {


            if (double.TryParse(tbDeposit.Text, out double Amount))
            {
                if (Client.Deposit(Amount))
                {
                    MessageBox.Show("Deposit was done sucessfuly", "Done", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Deposit Amount is not Valid", "Not Valid Entry", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }

            }
            else 
            {
                MessageBox.Show("Deposit Amount is not Valid", "Not Valid Entry", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            
            
        }

        private void DepositControl_Load(object sender, EventArgs e)
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