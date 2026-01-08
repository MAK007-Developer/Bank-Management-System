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
    public partial class HomeControl : UserControl
    {



        public HomeControl()
        {
            InitializeComponent();
        }


        void UpdateStatsLabels()
        {
            lblTransfersInSystem.Text = clsTransferBusinessLogic.GetTransfersCountInSystem().ToString();
            lblClientsInSystem.Text = clsClientBusinessLogic.GetClientsCountInSystem().ToString();
            lblUsersInSystem.Text = clsUserBusinessLogic.GetUsersCountInSystem().ToString();
            lblLoginsToSystem.Text = clsUserBusinessLogic.CountLogins().ToString();
            double TotBalance = clsClientBusinessLogic.GetTotalBalancesCountInSystem();
            lblTotBalances.Text = "$"+ TotBalance.ToString();

        }


        private void HomeControl_Load(object sender, EventArgs e)
        {
            UpdateStatsLabels();


        }




    }
}
