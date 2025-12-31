using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Data_Access_Layer;

namespace Bank_Business_Logic_Layer
{
    public class clsTransferBusinessLogic
    {

        public static int GetTransfersCountInSystem()
        {
            return clsTransferDataAccess.GetTranfersCountInSystem();
        }



    }
}
