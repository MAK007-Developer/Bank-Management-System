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

namespace Bank_Management_System.UserControlsWinForms.Users
{
    public partial class DeleteUserControl : UserControl
    {
        clsUserControlUtil controlUtil = new clsUserControlUtil();

        clsUserBusinessLogic UserToDelete;

        clsUserBusinessLogic LoginUser;

        public DeleteUserControl(clsUserBusinessLogic loginUser)
        {
            InitializeComponent();

            controlUtil.CurrentPanel = pnlDeleteUser;
            LoginUser = loginUser;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            controlUtil.ShowUserControl(new UsersManagementControl(LoginUser));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            UserToDelete = clsUserBusinessLogic.Find(tbUserName.Text);

            if (UserToDelete != null)
            {
                tbFirstName.Text = UserToDelete.FirstName;
                tbLastName.Text = UserToDelete.LastName;
                tbEmail.Text = UserToDelete.Email;
                tbPhone.Text = UserToDelete.Phone;
                tbPermissions.Text = UserToDelete.Permissions.ToString();
                tbPassword.Text = UserToDelete.Password;

            }
            else
            {
                MessageBox.Show("Couldn't find user try different UserName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (clsUserBusinessLogic.DeleteUser(UserToDelete.UserID))
            {
                MessageBox.Show("The user was deleted successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Couldn't delete user some error occured try again later", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }

           
        }

        private void DeleteUserControl_Load(object sender, EventArgs e)
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
