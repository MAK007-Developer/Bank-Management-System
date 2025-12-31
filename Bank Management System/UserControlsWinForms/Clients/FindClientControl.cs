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
    public partial class FindClientControl : UserControl
    {
        clsUserControlUtil controlUtil = new clsUserControlUtil();

        clsClientBusinessLogic ToBeFoundClient = new clsClientBusinessLogic();
        
        clsUserBusinessLogic LoginUser = new clsUserBusinessLogic();


        public FindClientControl()
        {
            InitializeComponent();
            controlUtil.CurrentPanel = pnlFindClient;
        }

        public FindClientControl(clsUserBusinessLogic LoginUser)
        {
            InitializeComponent();
            controlUtil.CurrentPanel = pnlFindClient;

            this.LoginUser = LoginUser; 
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            controlUtil.ShowUserControl(new ClientMangementControl(LoginUser));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            ToBeFoundClient = clsClientBusinessLogic.Find(tbAccountNumber.Text);

            if (ToBeFoundClient != null)
            {
                tbFirstName.Text = ToBeFoundClient.FirstName;
                tbLastName.Text = ToBeFoundClient.LastName;
                tbEmail.Text = ToBeFoundClient.Email;
                tbPhone.Text = ToBeFoundClient.Phone;
                tbPinCode.Text = ToBeFoundClient.PinCode;
                tbBalance.Text = ToBeFoundClient.Balance.ToString();
            }
            else
            {
                MessageBox.Show("Couldn't find Client try different Account Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FindClientControl_Load(object sender, EventArgs e)
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
