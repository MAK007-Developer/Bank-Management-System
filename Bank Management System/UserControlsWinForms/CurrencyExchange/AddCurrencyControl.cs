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

namespace Bank_Management_System.UserControlsWinForms.CurrencyExchange
{
    public partial class AddCurrencyControl : UserControl
    {

        clsUserControlUtil clsUserControlUtil = new clsUserControlUtil();

        clsCurrencyBusinessLogic NewCurrency = new clsCurrencyBusinessLogic();

        clsUserBusinessLogic LoginUser;


        public AddCurrencyControl(clsUserBusinessLogic loginUser)
        {
            InitializeComponent();

            clsUserControlUtil.CurrentPanel = pnlAddCurrency;
            LoginUser = loginUser;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            clsUserControlUtil.ShowUserControl(new CurrencyExchangeControl(LoginUser));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsCurrencyBusinessLogic.DoesCurrencyExist(tbCurrencyCode.Text))
            {
                MessageBox.Show("Currency already exsits in the system! add a new one", "Already exsits", MessageBoxButtons.OK, MessageBoxIcon.Error);    
                return;
            }

            NewCurrency.CurrencyName = tbCurrencyName.Text;
            NewCurrency.CurrencyCode = tbCurrencyCode.Text;
            NewCurrency.CountryName  = tbCountry.Text;

            if (float.TryParse(tbRate.Text, out float ExchangeRate))
            {
                NewCurrency.Rate = ExchangeRate;
            }

            

            if (NewCurrency.Save())
            {
                MessageBox.Show("Currency was added successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Something went wrong try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void AddCurrencyControl_Load(object sender, EventArgs e)
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
