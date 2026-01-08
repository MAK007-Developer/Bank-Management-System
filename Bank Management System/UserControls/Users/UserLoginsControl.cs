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

namespace Bank_Management_System.UserControlsWinForms.Users
{
    public partial class UserLoginsControl : UserControl
    {
        clsUserControlUtil controlUtil = new clsUserControlUtil();  

        public UserLoginsControl()
        {
            InitializeComponent();
            controlUtil.CurrentPanel = pnlListUsersLogins;
            
        }

        void LoadData()
        {
            dgvUsersLogins.DataSource = clsUserBusinessLogic.GetAllLogins();
        }



        private void UserLoginsControl_Load(object sender, EventArgs e)
        {
            LoadData();
           

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            controlUtil.ShowUserControl(new UsersManagementControl());
        }
    }
}
