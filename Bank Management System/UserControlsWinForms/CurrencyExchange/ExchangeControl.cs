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
    public partial class ExchangeControl : UserControl
    {

        clsUserControlUtil clsUserControlUtil = new clsUserControlUtil();

        clsUserBusinessLogic LoginUser;


        clsCurrencyBusinessLogic CurrencyFrom, CurrencyTo;

        float Amount = 0, ExchangedAmount = 0;

        public ExchangeControl()
        {
            InitializeComponent();

            clsUserControlUtil.CurrentPanel = pnlExchange;
        }

        public ExchangeControl(clsUserBusinessLogic LoginUser)
        {
            InitializeComponent();

            clsUserControlUtil.CurrentPanel = pnlExchange;

            this.LoginUser = LoginUser;
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            clsUserControlUtil.ShowUserControl(new CurrencyExchangeControl(LoginUser));
        }

        private void btnSearchFrom_Click(object sender, EventArgs e)
        {
            CurrencyFrom = clsCurrencyBusinessLogic.Find(tbCurrencyFromCode.Text);

            if (CurrencyFrom != null)
            {
                tbRateFrom.Text = CurrencyFrom.Rate.ToString();                
            }

        }

        private void btnSearchTo_Click(object sender, EventArgs e)
        {
            CurrencyTo = clsCurrencyBusinessLogic.Find(tbCurrencyToCode.Text);

            if (CurrencyTo != null)
            {
                tbRateTo.Text = CurrencyTo.Rate.ToString();
            }



        }

       

        private void ExchangeControl_Load(object sender, EventArgs e)
        {
            if (!clsUserControlUtil.DoesUserHavePermissions(LoginUser, this))
            {
                this.Enabled = false;
                MessageBox.Show("You don't have permission to access this section contact your admin", "No Permission Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        void Exchange()
        {
            Amount = (float)Convert.ToDouble(tbAmount.Text);

            bool Success;

            if (CurrencyFrom.CurrencyCode == CurrencyTo.CurrencyCode)
            {
                MessageBox.Show("Can't exchange to the same currency! choose different currencies", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            if (CurrencyFrom.CurrencyCode == "USD")
            {
                Success = clsCurrencyBusinessLogic.ExchangeDollarsToCurrency(CurrencyTo, Amount, ref ExchangedAmount);

                lblExchangedAmount.Text = ExchangedAmount.ToString() + " " + CurrencyTo.CurrencyCode;

                
                return;
            }
            if (CurrencyTo.CurrencyCode == "USD")
            {
                Success = clsCurrencyBusinessLogic.ExchangeCurrencyToDollars(CurrencyFrom, Amount, ref ExchangedAmount);

                lblExchangedAmount.Text = ExchangedAmount.ToString() + " " + CurrencyTo.CurrencyCode;

                
                return;
            }
            else
            {
                Success = CurrencyFrom.ExchangeToCurrency(CurrencyTo, Amount, ref ExchangedAmount);

                lblExchangedAmount.Text = ExchangedAmount.ToString() + " " + CurrencyTo.CurrencyCode;

                return;

            }
        }



        private void btnExchange_Click(object sender, EventArgs e)
        {
            Exchange();

            DateTime ExchangeDate = DateTime.Now;

            if (clsCurrencyBusinessLogic.AddNewExchangeRecord(LoginUser.UserID, CurrencyFrom.CurrencyID, CurrencyTo.CurrencyID, Amount, ExchangedAmount, ExchangeDate))
            {
                MessageBox.Show("Exchange is done successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Something went wrong try again later!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }




    }
}
