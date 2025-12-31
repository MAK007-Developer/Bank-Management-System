using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_Business_Logic_Layer;

namespace Bank_Management_System
{
    internal class clsUserControlUtil
    {
        public UserControl CurrentControl;

        public Panel CurrentPanel;

        public static clsUserBusinessLogic LoginUser;

        public int Permissions { set; get; }    

        public void ShowUserControl(UserControl newControl)
        {
            // Clear any existing controls from the content panel
            CurrentPanel.Controls.Clear();

            // Add the new User Control to the panel
            newControl.Dock = DockStyle.Fill; // Make the control fill the panel
            CurrentPanel.Controls.Add(newControl);

            CurrentControl = newControl; // Keep a reference to the current control
        }


        public static bool DoesUserHavePermissions( clsUserBusinessLogic User, UserControl CurrentControl)
        {
            
            int ControlPermissionsTag = Convert.ToInt32( CurrentControl.Tag); 

            if (User.Permissions == -1)
            {
                return true;
            }

            if ( (User.Permissions & ControlPermissionsTag)  == ControlPermissionsTag)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public static bool DoesUserHavePermissionOnThisUserCtrlOrForm(object CurrentControlTag)
        {

            int ControlPermissionsTag = Convert.ToInt32(CurrentControlTag);

            if (LoginUser.Permissions == -1)
            {
                return true;
            }

            if ((LoginUser.Permissions & ControlPermissionsTag) == ControlPermissionsTag)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool[] CalculateUserPermissionsArr()
        {
            /*
             Indecies and thier meaning:
            
            bool[] arrPermissions {HasFullAccess, HasClientsFullAccess, HasUsersFullAccess, HasTransactionsFullAccess, HasCurrenciesFullAccess, 
            HasAddClient, HasDeleteClient, HasUpdateClient, HasListClients, HasFindClient, 
            HasAddUser, HasDeleteUser, HasUpdateUser, HasListUsers, HasFindUser, 
            HasAddCurrency, HasUpdateCurrency, HasListCurrencies, HasFindCurrency, HasExchangeLog, HasExchangeCurrency,             
            HasDeposit, HasWithdraw, HasTransfer, HasListBalances, HasTransferLog}

            [0]: HasFullAccess
            [1]: HasClientsFullAccess

            */


            bool[] arrPermissions = new bool[26];






            return arrPermissions;
        }






    }
}
