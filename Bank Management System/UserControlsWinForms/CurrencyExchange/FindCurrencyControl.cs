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
    public partial class FindCurrencyControl : UserControl
    {
        clsUserControlUtil UserControlUtil = new clsUserControlUtil();

        clsCurrencyBusinessLogic CurrencyToFind = new clsCurrencyBusinessLogic();

        clsUserBusinessLogic LoginUser = new clsUserBusinessLogic();    

        public FindCurrencyControl()
        {
            InitializeComponent();

            UserControlUtil.CurrentPanel = pnlFindCurrency;
        }


        public FindCurrencyControl(clsUserBusinessLogic LoginUser)
        {
            InitializeComponent();

            UserControlUtil.CurrentPanel = pnlFindCurrency;

            this.LoginUser = LoginUser;
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            UserControlUtil.ShowUserControl(new CurrencyExchangeControl(this.LoginUser));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            CurrencyToFind = clsCurrencyBusinessLogic.Find(tbCurrencyCode.Text);

            if (CurrencyToFind != null)
            {
                tbCurrencyName.Text = CurrencyToFind.CurrencyName;
                tbCountry.Text = CurrencyToFind.CountryName;
                tbRate.Text = CurrencyToFind.Rate.ToString();
                
            }
            else
            {
                MessageBox.Show("Couldn't find Currency try different Currency Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FindCurrencyControl_Load(object sender, EventArgs e)
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
