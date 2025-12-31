using Bank_Business_Logic_Layer;
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

namespace Bank_Management_System.UserControlsWinForms
{
    public partial class TransactionsControl : UserControl
    {

        clsUserControlUtil clsUserControlUtil = new clsUserControlUtil();

        clsUserBusinessLogic LoginUser = new clsUserBusinessLogic();

        public TransactionsControl()
        {

            InitializeComponent();
            clsUserControlUtil.CurrentPanel = pnlTransactions;

        }

        public TransactionsControl(clsUserBusinessLogic LogedInUser)
        {
            InitializeComponent();
            clsUserControlUtil.CurrentPanel = pnlTransactions;

            this.LoginUser = LogedInUser;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            clsUserControlUtil.ShowUserControl(new DepositControl(this.LoginUser));
        }

        private void btnListBalances_Click(object sender, EventArgs e)
        {
            clsUserControlUtil.ShowUserControl(new ListBalancesControl(this.LoginUser));
        }

        private void btnTransferLog_Click(object sender, EventArgs e)
        {
            clsUserControlUtil.ShowUserControl(new TransferLogControl(this.LoginUser));
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            clsUserControlUtil.ShowUserControl(new WithdrawControl(this.LoginUser));
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            clsUserControlUtil.ShowUserControl(new TransferControl(this.LoginUser));
        }

        private void TransactionsControl_Load(object sender, EventArgs e)
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
