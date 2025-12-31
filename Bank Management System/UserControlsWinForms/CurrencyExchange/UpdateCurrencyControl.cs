using Bank_Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Management_System.UserControlsWinForms.Transactions
{
    public partial class UpdateCurrencyControl : UserControl
    {

        clsUserControlUtil controlUtil = new clsUserControlUtil();

        clsCurrencyBusinessLogic CurrencyToUpdate = new clsCurrencyBusinessLogic();

        clsUserBusinessLogic LoginUser;
        public UpdateCurrencyControl()
        {
            InitializeComponent();

            controlUtil.CurrentPanel = pnlUpdateCurrency;
        }

        public UpdateCurrencyControl(clsUserBusinessLogic LoginUser)
        {
            InitializeComponent();

            controlUtil.CurrentPanel = pnlUpdateCurrency;

            this.LoginUser = LoginUser; 
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            controlUtil.ShowUserControl(new CurrencyExchangeControl(LoginUser));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CurrencyToUpdate = clsCurrencyBusinessLogic.Find(tbCurrencyCode.Text);

            if (CurrencyToUpdate != null)
            {
                tbCurrencyName.Text = CurrencyToUpdate.CurrencyName;
                tbCountry.Text = CurrencyToUpdate.CountryName;
                tbRate.Text = CurrencyToUpdate.Rate.ToString();

            }
            else
            {
                MessageBox.Show("Couldn't find Currency try different Currency Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CurrencyToUpdate.CurrencyName = tbCurrencyName.Text;
            CurrencyToUpdate.CurrencyCode = tbCurrencyCode.Text;
            CurrencyToUpdate.CountryName = tbCountry.Text;

            if (float.TryParse(tbRate.Text, out float ExchangeRate))
            {
                CurrencyToUpdate.Rate = ExchangeRate;
            }

            if (CurrencyToUpdate.Save())
            {
                MessageBox.Show("Currency was updated successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Something went wrong try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void UpdateCurrencyControl_Load(object sender, EventArgs e)
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
