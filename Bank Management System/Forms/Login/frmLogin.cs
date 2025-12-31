using Bank_Management_System.Properties;
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

namespace Bank_Management_System
{
    public partial class frmLogin : Form
    {

        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void ToggleHideShowPassword( bool HideShowPasswordToggle)
        {

            if (!HideShowPasswordToggle)
            {
                btnToggleRevealPassword.Image = Resources.ExposedPassword;
                btnToggleRevealPassword.Tag = "Expose";
                tbPassword.PasswordChar = '\0';

            }
            else
            {
                btnToggleRevealPassword.Image = Resources.HiddenPassword;
                btnToggleRevealPassword.Tag = "Hide";
                tbPassword.PasswordChar = '*';

            }

        }

        private void btnToggleRevealPassword_Click(object sender, EventArgs e)
        {
            
            bool HideShowPasswordToggle = ((string)btnToggleRevealPassword.Tag == "Hide" ) ? false : true;
            ToggleHideShowPassword(HideShowPasswordToggle);

        }

        private void DateTimeTimer_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("F");
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            clsUserControlUtil.LoginUser = clsUserBusinessLogic.Find(tbUserName.Text, tbPassword.Text);

            if (clsUserControlUtil.LoginUser != null)
            {

                clsUserControlUtil.LoginUser.RegisterLogin();
                frmHome frmHomeBank = new frmHome();
                frmHomeBank.ShowDialog();

            }
            else
            {
                MessageBox.Show("Wrong UserName or Password! try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
    }
}
