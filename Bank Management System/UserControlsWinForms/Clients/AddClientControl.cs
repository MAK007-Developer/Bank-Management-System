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

namespace Bank_Management_System.UserControlsWinForms.Clients
{
    public partial class AddClientControl : UserControl
    {

        clsUserControlUtil controlUtil = new clsUserControlUtil();

        clsClientBusinessLogic newClient = new clsClientBusinessLogic();

        clsUserBusinessLogic LoginUser;

        public AddClientControl()
        {
            InitializeComponent();

            controlUtil.CurrentPanel = pnlAddClient;

        }

        public AddClientControl(clsUserBusinessLogic loginUser)
        {
            InitializeComponent();

            controlUtil.CurrentPanel = pnlAddClient;
            LoginUser = loginUser;
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            controlUtil.ShowUserControl(new ClientMangementControl(LoginUser));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsClientBusinessLogic.DoesClientExist(tbAccountNumber.Text))
            {
                MessageBox.Show("This AccountNumber is taken try another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            newClient.FirstName = tbFirstName.Text;
            newClient.LastName = tbLastName.Text;
            newClient.Email = tbEmail.Text;
            newClient.Phone = tbPhone.Text;
            newClient.AccountNumber = tbAccountNumber.Text;
            newClient.Balance = Convert.ToDouble(tbBalance.Text);
            newClient.PinCode = tbPinCode.Text;

            if (newClient.Save())
            {
                MessageBox.Show("The Client was added successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Something went wrong try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void AddClientControl_Load(object sender, EventArgs e)
        {
            if (!clsUserControlUtil.DoesUserHavePermissions(LoginUser, this))
            {
                this.Enabled = false;
                MessageBox.Show("You don't have permission to access this section contact your admin", "No Permission Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlAddClient_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonColorButton1_SelectedColorChanged(object sender, Krypton.Toolkit.ColorEventArgs e)
        {

        }
    }
}
