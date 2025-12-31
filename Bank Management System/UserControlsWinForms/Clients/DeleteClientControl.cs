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
    public partial class DeleteClientControl : UserControl
    {

        clsUserControlUtil controlUtil = new clsUserControlUtil();

        clsClientBusinessLogic ToBeDeletedClient = new clsClientBusinessLogic();

        clsUserBusinessLogic LoginUser = new clsUserBusinessLogic();

        public DeleteClientControl(clsUserBusinessLogic LoginUser)
        {
            InitializeComponent();

            controlUtil.CurrentPanel = pnlDeleteClient;

            this.LoginUser = LoginUser;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            controlUtil.ShowUserControl(new ClientMangementControl(LoginUser));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            ToBeDeletedClient = clsClientBusinessLogic.Find(tbAccountNumber.Text);

            if (ToBeDeletedClient != null)
            {
                tbFirstName.Text = ToBeDeletedClient.FirstName;
                tbLastName.Text = ToBeDeletedClient.LastName;
                tbEmail.Text = ToBeDeletedClient.Email;
                tbPhone.Text = ToBeDeletedClient.Phone;
                tbPinCode.Text = ToBeDeletedClient.PinCode;
                tbBalance.Text = ToBeDeletedClient.Balance.ToString();
            }
            else
            {
                MessageBox.Show("Couldn't find Client try different Account Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (clsClientBusinessLogic.DeleteClient(ToBeDeletedClient.ClientID))
            {
                MessageBox.Show("The Client was deleted successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Couldn't delete client some error occured try again later", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void DeleteClientControl_Load(object sender, EventArgs e)
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
