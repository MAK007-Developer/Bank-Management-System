using Bank_Management_System.UserControlsWinForms.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_Management_System;
using Bank_Business_Logic_Layer;

namespace Bank_Management_System.UserControlsWinForms
{
    public partial class UsersManagementControl : UserControl
    {
        clsUserControlUtil CustomUserControl = new clsUserControlUtil();


        public UsersManagementControl()
        {
            InitializeComponent();
            CustomUserControl.CurrentPanel = pnlUserManagement;
            
        }

        public UsersManagementControl(clsUserBusinessLogic User)
        {
            InitializeComponent();
            CustomUserControl.CurrentPanel = pnlUserManagement;
            
        }

        private void btnListUsers_Click(object sender, EventArgs e)
        {
            CustomUserControl.ShowUserControl(new ListUsersControl(clsUserControlUtil.LoginUser));
            //ShowUserControl(new ListClientsControl());
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            CustomUserControl.ShowUserControl(new AddUserControl(clsUserControlUtil.LoginUser));
            
        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            CustomUserControl.ShowUserControl(new FindUserControl(clsUserControlUtil.LoginUser));
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            CustomUserControl.ShowUserControl(new UpdateUserControl());
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            CustomUserControl.ShowUserControl(new DeleteUserControl(clsUserControlUtil.LoginUser));
        }

        private void UsersManagementControl_Load(object sender, EventArgs e)
        {
            if (!clsUserControlUtil.DoesUserHavePermissions(clsUserControlUtil.LoginUser, this))
            {
                this.Enabled = false;
                MessageBox.Show("You don't have permission to access this section contact your admin", "No Permission Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUsersLogins_Click(object sender, EventArgs e)
        {
            CustomUserControl.ShowUserControl(new UserLoginsControl());
        }
    }
}
