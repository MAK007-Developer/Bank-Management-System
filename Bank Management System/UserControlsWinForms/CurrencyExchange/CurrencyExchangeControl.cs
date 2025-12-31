using Bank_Management_System.UserControlsWinForms.CurrencyExchange;
using Bank_Management_System.UserControlsWinForms.Transactions;
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

namespace Bank_Management_System.UserControlsWinForms
{
    public partial class CurrencyExchangeControl : UserControl
    {
        clsUserControlUtil ControlUtil = new clsUserControlUtil();


        clsUserBusinessLogic LoginUser = new clsUserBusinessLogic();



        public CurrencyExchangeControl()
        {
            InitializeComponent();

            ControlUtil.CurrentPanel = pnlCurrencyExchange;
        }

        public CurrencyExchangeControl(clsUserBusinessLogic User)
        {
            InitializeComponent();

            ControlUtil.CurrentPanel = pnlCurrencyExchange;

            LoginUser = User;

        }






        private void btnFindCurrency_Click(object sender, EventArgs e)
        {
            ControlUtil.ShowUserControl(new FindCurrencyControl(this.LoginUser));
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            ControlUtil.ShowUserControl(new ExchangeControl(this.LoginUser));
        }

        private void btnListCurrencies_Click(object sender, EventArgs e)
        {
            ControlUtil.ShowUserControl(new ListCurrenciesControl(this.LoginUser));
        }

        private void btnUpdateCurrency_Click(object sender, EventArgs e)
        {
            ControlUtil.ShowUserControl(new UpdateCurrencyControl(this.LoginUser));
        }

        private void btnExchangeLog_Click(object sender, EventArgs e)
        {
            ControlUtil.ShowUserControl(new ExchangeLogControl(this.LoginUser));
        }

        private void btnAddCurrency_Click(object sender, EventArgs e)
        {
            ControlUtil.ShowUserControl(new AddCurrencyControl(this.LoginUser));
        }

        private void CurrencyExchangeControl_Load(object sender, EventArgs e)
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
