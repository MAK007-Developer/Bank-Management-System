using Bank_Management_System.Forms;
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

namespace Bank_Management_System.UserControlsWinForms.Users
{
    public partial class AddUserControl : UserControl
    {
        clsUserControlUtil CustomUserControl = new clsUserControlUtil();

        clsUserBusinessLogic NewUser = new clsUserBusinessLogic();

        clsUserBusinessLogic LoginUser;

        public string PermissionsStr = string.Empty;

        string PermissionsStr;

        public AddUserControl(clsUserBusinessLogic LoginUser)
        {
            InitializeComponent();
            CustomUserControl.CurrentPanel = pnlAddUser;

            this.LoginUser = LoginUser; 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            CustomUserControl.ShowUserControl(new UsersManagementControl(LoginUser));

        }


        private void btnPermissions_Click(object sender, EventArgs e)
        {
            
            using (frmPermissions frmGetUserPermissions = new frmPermissions()) 
            {
                

                if (frmGetUserPermissions.ShowDialog() == DialogResult.OK)
                {
                    this.PermissionsStr = frmGetUserPermissions.PermissionsInfo.FullPermissionStr;

                    PermissionsStr = frmGetUserPermissions.PermissionsInfo.FullPermissionStr;

                    lblPermissions.Text = "Permissions: " + frmGetUserPermissions.PermissionsInfo.FullPermissionStr;
                }
                else
                {
                    lblPermissions.Text = "Permissions:";
                }


            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NewUser.FirstName = tbFirstName.Text;
            NewUser.LastName = tbLastName.Text;
            NewUser.Email = tbEmail.Text;
            NewUser.Phone = tbPhone.Text;
            NewUser.UserName = tbUserName.Text;
            NewUser.Password = tbPassword.Text;
            NewUser.PermissionsString = this.PermissionsStr;

            
            if (clsUserBusinessLogic.DoesUserExist(NewUser.UserName))
            {
                MessageBox.Show("The UserName already Exists choose another one", "UserName Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (NewUser.Save())
                {
                    MessageBox.Show("User Added Sucessfully", "User Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("an Error Has Occured Try Again Later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }

        private void AddUserControl_Load(object sender, EventArgs e)
        {
            if (!clsUserControlUtil.PermissionsDict["HasAddUser"])
            {
                this.Enabled = false;
                MessageBox.Show("You don't have permission to access this section contact your admin", "No Permission Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
