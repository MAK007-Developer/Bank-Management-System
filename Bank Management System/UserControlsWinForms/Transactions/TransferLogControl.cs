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

namespace Bank_Management_System.UserControlsWinForms.Transactions
{
    public partial class TransferLogControl : UserControl
    {

        clsUserControlUtil clsUserControlUtil = new clsUserControlUtil();

        clsUserBusinessLogic LoginUser = new clsUserBusinessLogic();

        public TransferLogControl()
        {
            InitializeComponent();

            clsUserControlUtil.CurrentPanel = pnlTransferLog;
            
        }


        public TransferLogControl(clsUserBusinessLogic logedInUser)
        {
            InitializeComponent();

            clsUserControlUtil.CurrentPanel = pnlTransferLog;
            this.LoginUser = logedInUser;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            clsUserControlUtil.ShowUserControl(new TransactionsControl());
        }

        private void TransferLogControl_Load(object sender, EventArgs e)
        {
            if (!clsUserControlUtil.DoesUserHavePermissions(LoginUser, this))
            {
                this.Enabled = false;
                MessageBox.Show("You don't have permission to access this section contact your admin", "No Permission Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvTransferLog.DataSource = clsClientBusinessLogic.GetTransferLog();
        }



    }
}
