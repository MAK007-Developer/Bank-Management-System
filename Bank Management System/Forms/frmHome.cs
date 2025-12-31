using Bank_Management_System.UserControlsWinForms;
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
using Bank_Management_System.Forms;

namespace Bank_Management_System
{
    public partial class frmHome : Form
    {
        private UserControl CurrentControl;

        public clsUserBusinessLogic LoginUser;

        public frmHome()
        {
            InitializeComponent();
        }



        private void DateTimeTimer_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("F");
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            lblLogedInUser.Text = LoginUser.UserName;
        }

        private void ShowUserControl(UserControl newControl)
        {
            // Clear any existing controls from the content panel
            pnlContent.Controls.Clear();

            // Add the new User Control to the panel
            newControl.Dock = DockStyle.Fill; // Make the control fill the panel
            pnlContent.Controls.Add(newControl);

            CurrentControl = newControl; // Keep a reference to the current control
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowUserControl(new HomeControl());
        }

        private void btnClientsMangement_Click(object sender, EventArgs e)
        {
            ShowUserControl(new ClientMangementControl(this.LoginUser));
        }

        private void btnUsersMangement_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UsersManagementControl(this.LoginUser));
        }

        private void btnTransactionsManagement_Click(object sender, EventArgs e)
        {
            ShowUserControl(new TransactionsControl(this.LoginUser));
        }

        private void btnCurrencyExchange_Click(object sender, EventArgs e)
        {
            ShowUserControl(new CurrencyExchangeControl(this.LoginUser));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LnkLblDevelopedBy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }
    }
}
