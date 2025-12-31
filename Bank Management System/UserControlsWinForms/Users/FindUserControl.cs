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
    public partial class FindUserControl : UserControl
    {
        clsUserControlUtil controlUtil = new clsUserControlUtil();

        clsUserBusinessLogic UserToFind;

        clsUserBusinessLogic LoginUser;

        public FindUserControl(clsUserBusinessLogic loginUser)
        {
            InitializeComponent();
            controlUtil.CurrentPanel = pnlFindUser;
            LoginUser = loginUser;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            controlUtil.ShowUserControl(new UsersManagementControl(LoginUser));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            UserToFind = clsUserBusinessLogic.Find(tbUserName.Text);

            if (UserToFind != null)
            {
                tbFirstName.Text = UserToFind.FirstName;
                tbLastName.Text = UserToFind.LastName;
                tbEmail.Text = UserToFind.Email;
                tbPhone.Text = UserToFind.Phone;
                tbPermissions.Text = UserToFind.Permissions.ToString();
                tbPassword.Text = UserToFind.Password;

            }
            else
            {
                MessageBox.Show("Couldn't find user try different UserName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void FindUserControl_Load(object sender, EventArgs e)
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
