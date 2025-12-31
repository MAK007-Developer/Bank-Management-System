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

namespace Bank_Management_System.UserControlsWinForms.Clients
{
    public partial class UpdateClientControl : UserControl
    {

        clsUserControlUtil clsUserControlUtil = new clsUserControlUtil();

        clsClientBusinessLogic ToBeUpdatedClient = new clsClientBusinessLogic();

        clsUserBusinessLogic LoginUser = new clsUserBusinessLogic(); 


        public UpdateClientControl(clsUserBusinessLogic LoginUser)
        {
            InitializeComponent();
            clsUserControlUtil.CurrentPanel = pnlUpdateClient;
            this.LoginUser = LoginUser; 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            clsUserControlUtil.ShowUserControl(new ClientMangementControl(LoginUser));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ToBeUpdatedClient = clsClientBusinessLogic.Find(tbAccountNumber.Text);

            if (ToBeUpdatedClient != null)
            {
                tbFirstName.Text = ToBeUpdatedClient.FirstName;
                tbLastName.Text = ToBeUpdatedClient.LastName;
                tbEmail.Text = ToBeUpdatedClient.Email;
                tbPhone.Text = ToBeUpdatedClient.Phone;
                tbPinCode.Text = ToBeUpdatedClient.PinCode;
                tbBalance.Text = ToBeUpdatedClient.Balance.ToString();
            }
            else
            {
                MessageBox.Show("Couldn't find Client try different Account Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ToBeUpdatedClient.FirstName = tbFirstName.Text;
            ToBeUpdatedClient.LastName = tbLastName.Text;
            ToBeUpdatedClient.Email = tbEmail.Text;
            ToBeUpdatedClient.Phone = tbPhone.Text;
            ToBeUpdatedClient.PinCode = tbPinCode.Text;
            ToBeUpdatedClient.Balance = Convert.ToDouble(tbBalance.Text);

            if (ToBeUpdatedClient.Save())
            {
                MessageBox.Show("Client Updated Sucessfully", "Client Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("an Error Has Occured Try Again Later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UpdateClientControl_Load(object sender, EventArgs e)
        {
            if (!clsUserControlUtil.DoesUserHavePermissions(LoginUser, this))
            {
                this.Enabled = false;
                MessageBox.Show("You don't have permission to access this section contact your admin", "No Permission Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
