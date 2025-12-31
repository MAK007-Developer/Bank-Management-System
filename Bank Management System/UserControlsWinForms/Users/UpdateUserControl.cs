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
    public partial class UpdateUserControl : UserControl
    {
        clsUserControlUtil controlUtil = new clsUserControlUtil();

        clsUserBusinessLogic ToBeUpdatedUser;

        public int Permissions = 0;

        public UpdateUserControl()
        {
            InitializeComponent();
            controlUtil.CurrentPanel = pnlUpdateUser;
   
        }

        
        private void btnBack_Click(object sender, EventArgs e)
        {
            controlUtil.ShowUserControl(new UsersManagementControl(clsUserControlUtil.LoginUser));
        }

        private void btnPermissions_Click(object sender, EventArgs e)
        {
            using (frmPermissions frmGetUserPermissions = new frmPermissions())
            {
                frmGetUserPermissions.ObjPermissions.MainPermissions = Permissions;
                if (frmGetUserPermissions.ShowDialog() == DialogResult.OK)
                {
                    this.Permissions = frmGetUserPermissions.ObjPermissions.MainPermissions;
                    lblPermissions.Text = "Permissions: " + frmGetUserPermissions.ObjPermissions.ToString();
                }
                else
                {
                    lblPermissions.Text = "Permissions:";
                }


            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ToBeUpdatedUser.FirstName = tbFirstName.Text;
            ToBeUpdatedUser.LastName = tbLastName.Text;
            ToBeUpdatedUser.Email = tbEmail.Text;
            ToBeUpdatedUser.Phone = tbPhone.Text;
            ToBeUpdatedUser.Password = tbPassword.Text;
            ToBeUpdatedUser.Permissions = this.Permissions;

            if (ToBeUpdatedUser.Save())
            {
                MessageBox.Show("User Updated Sucessfully", "User Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("an Error Has Occured Try Again Later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ToBeUpdatedUser = clsUserBusinessLogic.Find(tbUserName.Text);

            if (ToBeUpdatedUser != null)
            {
                tbFirstName.Text = ToBeUpdatedUser.FirstName;
                tbLastName.Text = ToBeUpdatedUser.LastName;
                tbEmail.Text = ToBeUpdatedUser.Email;
                tbPhone.Text = ToBeUpdatedUser.Phone;
                tbPassword.Text = ToBeUpdatedUser.Password;
                lblPermissions.Text = "Permissions: " + ToBeUpdatedUser.Permissions.ToString();
            }
            else
            {
                MessageBox.Show("Couldn't find user try different UserName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UpdateUserControl_Load(object sender, EventArgs e)
        {
            if (!clsUserControlUtil.DoesUserHavePermissionOnThisUserCtrlOrForm(this.Tag))
            {
                this.Enabled = false;
                MessageBox.Show("You don't have permission to access this section contact your admin", "No Permission Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



    }
}
