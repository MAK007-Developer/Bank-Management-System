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
    public partial class ListCurrenciesControl : UserControl
    {
        clsUserControlUtil clsUserControlUtil = new clsUserControlUtil();

        clsUserBusinessLogic LoginUser;


        public ListCurrenciesControl()
        {
            InitializeComponent();

            clsUserControlUtil.CurrentPanel = pnlListCurrencies;

        }

        public ListCurrenciesControl(clsUserBusinessLogic LoginUser)
        {
            InitializeComponent();

            clsUserControlUtil.CurrentPanel = pnlListCurrencies;

            this.LoginUser = LoginUser;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            clsUserControlUtil.ShowUserControl(new CurrencyExchangeControl(LoginUser));
        }

        private void ListCurrenciesControl_Load(object sender, EventArgs e)
        {
            if (!clsUserControlUtil.DoesUserHavePermissions(LoginUser, this))
            {
                this.Enabled = false;
                MessageBox.Show("You don't have permission to access this section contact your admin", "No Permission Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            dgvListCurrencies.DataSource = clsCurrencyBusinessLogic.GetAllCurrencies();
        }
    }
}
