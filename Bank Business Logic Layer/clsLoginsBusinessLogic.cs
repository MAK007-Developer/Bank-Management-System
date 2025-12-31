using Bank_Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Business_Logic_Layer
{
    public class clsLoginsBusinessLogic
    {
       

        public int UserID { set; get; }

        public static int x;
        public static DataTable GetAllLogins()
        {
            return clsLoginDataAccess.GetAllLogins();
        }


        public static DataTable GetAllUsers()
        {
            return clsUserDataAccess.GetAllUsers();
        }


    }
}
