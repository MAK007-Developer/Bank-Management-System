using Bank_Management_System.UserControlsWinForms.Clients;
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
using Bank_Management_System.Properties;

namespace Bank_Management_System.UserControlsWinForms
{
    public partial class ClientMangementControl : UserControl
    {
        clsUserControlUtil ClientControl = new clsUserControlUtil();
        clsUserBusinessLogic LoginUser = new clsUserBusinessLogic();

        public ClientMangementControl()
        {
            InitializeComponent();   
            ClientControl.CurrentPanel = pnlClientManagement;
        }

        public ClientMangementControl(clsUserBusinessLogic User)
        {
            InitializeComponent();
            ClientControl.CurrentPanel = pnlClientManagement;
            LoginUser = User;

            
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            ClientControl.ShowUserControl(new AddClientControl(LoginUser));
        }

      
        private void btnFindClient_Click(object sender, EventArgs e)
        {
            ClientControl.ShowUserControl(new FindClientControl(LoginUser));
        }

        private void btnListClients_Click(object sender, EventArgs e)
        {
            ClientControl.ShowUserControl(new ListClientsControl(LoginUser));
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            ClientControl.ShowUserControl(new UpdateClientControl(LoginUser));
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            ClientControl.ShowUserControl(new DeleteClientControl(LoginUser));
        }

        private void ClientMangementControl_Load(object sender, EventArgs e)
        {

            if (!clsUserControlUtil.PermissionsDict["HasClientsScreenAccess"])
            {
                this.Enabled = false;
                MessageBox.Show("You don't have permission to access this section contact your admin", "No Permission Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        
    }
}
