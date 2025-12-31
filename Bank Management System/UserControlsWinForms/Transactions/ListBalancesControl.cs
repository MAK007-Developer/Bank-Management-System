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
    public partial class ListBalancesControl : UserControl
    {

        clsUserControlUtil clsUserControlUtil = new clsUserControlUtil();   

        clsUserBusinessLogic LoginUser = new clsUserBusinessLogic();

        public ListBalancesControl()
        {
            InitializeComponent();

            clsUserControlUtil.CurrentPanel = pnlListBalances;
            
        }



        public ListBalancesControl(clsUserBusinessLogic logedInUser)
        {
            InitializeComponent();

            clsUserControlUtil.CurrentPanel = pnlListBalances;
            this.LoginUser = logedInUser;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            clsUserControlUtil.ShowUserControl(new TransactionsControl());
        }

        private void dgvListBalances_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListBalancesControl_Load(object sender, EventArgs e)
        {
            if (!clsUserControlUtil.DoesUserHavePermissions(LoginUser, this))
            {
                this.Enabled = false;
                MessageBox.Show("You don't have permission to access this section contact your admin", "No Permission Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }



            dgvListBalances.DataSource = clsClientBusinessLogic.ListBalances();
        }
    }
}
