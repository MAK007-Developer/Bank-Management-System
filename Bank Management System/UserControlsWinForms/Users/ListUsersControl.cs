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

namespace Bank_Management_System.UserControlsWinForms
{
    public partial class ListUsersControl : UserControl
    {
        clsUserControlUtil CustomUserControl = new clsUserControlUtil();

        clsUserBusinessLogic LoginUser;

        public ListUsersControl(clsUserBusinessLogic LoginUser)
        { 
            InitializeComponent();
            CustomUserControl.CurrentPanel = pnlListUsers;
            this.LoginUser = LoginUser;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomUserControl.ShowUserControl(new UsersManagementControl(LoginUser));
        }


        void LoadUsersData()
        {
            dgvListUsers.DataSource = clsUserBusinessLogic.GetAllUsers();
        }


        private void ListUsersControl_Load(object sender, EventArgs e)
        {
            if (!clsUserControlUtil.DoesUserHavePermissions(LoginUser, this))
            {
                this.Enabled = false;
                MessageBox.Show("You don't have permission to access this section contact your admin", "No Permission Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            LoadUsersData();
        }

        private void dgvListUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
