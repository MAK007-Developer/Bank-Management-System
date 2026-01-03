using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Bank_Data_Access_Layer;

namespace Bank_Business_Logic_Layer
{
    public class clsUserBusinessLogic : clsPersonBusinessLogic
    {
        public int UserID { set; get; }

        public string UserName { set; get; }

        public string Password { set; get; }
        public string PermissionsString { set; get; }
        public clsPermissionsBLL ObjPermissions { set; get; }

        private bool _AddNewUser()
        {
            //call DataAccess Layer 
            //PersonID = clsPersonDataAccess.AddNewPerson(FirstName, LastName, Email, Phone);

            this.UserID = clsUserDataAccess.AddNewUser(this.FirstName, this.LastName, this.Email, this.Phone, this.UserName, 
                this.Password, PermissionsString);

            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
            //call DataAccess Layer 

            return clsUserDataAccess.UpdateUser(this.UserID, this.FirstName, this.LastName, this.Email, 
                this.Phone, this.Password, PermissionsString);

        }


        public clsUserBusinessLogic() 
        { 
            this.UserID = -1;
            this.PersonID = -1;

            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = "";
            this.UserName = string.Empty;
            this.Password = string.Empty;   
            this.PermissionsString = "";

            ObjPermissions = new clsPermissionsBLL();
            Mode = enMode.AddNew;
        } 
        
        private clsUserBusinessLogic(int UserID, int PersonID, string FirstName, string LastName, string Email, string Phone, 
            string UserName, string Password, string PermissionsStr)
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.Password = Password;
            this.PermissionsString = PermissionsStr;
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;

            string[] arrPermissionsSplitted = SplitPermissionsString();

            ObjPermissions.MainPermissions = Convert.ToInt32(arrPermissionsSplitted[0]);
            ObjPermissions.ClientsManagementPermissions = Convert.ToInt32(arrPermissionsSplitted[1]);
            ObjPermissions.UsersManagementPermissions = Convert.ToInt32(arrPermissionsSplitted[2]);
            ObjPermissions.CurrenciesManagementPermissions = Convert.ToInt32(arrPermissionsSplitted[3]);
            ObjPermissions.TransactionsManagementPermissions = Convert.ToInt32(arrPermissionsSplitted[4]);

            Mode = enMode.Update;
        }


        private string[] SplitPermissionsString()
        {
            string[] PermissionsSplited = { };

            if (string.IsNullOrEmpty(this.PermissionsString))
            {
                // Return an empty array if there is no data to split
                return new string[0];
            }


            PermissionsSplited = this.PermissionsString.Split('#');

            return PermissionsSplited;
        }


        public override bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateUser();

            }

            return false;
        }


        public new static clsUserBusinessLogic Find(int UserID)
        {

            string FirstName = "", LastName = "", Email = "", Phone = "", UserName = "", Password = "", PermissionsStr = "";

            int PersonID = -1;

            if (clsUserDataAccess.GetUserInfoByID(UserID, ref PersonID, ref UserName, ref Password, ref FirstName, ref LastName, ref Email, ref Phone, ref PermissionsStr))

                return new clsUserBusinessLogic(UserID, PersonID ,FirstName,  LastName, Email,
                Phone, UserName, Password, PermissionsStr);
            else
                return null;

        }

        public static clsUserBusinessLogic Find(string UserName)
        {

            string FirstName = "", LastName = "", Email = "", Phone = "", Password = "", PermissionsStr = "";

            int PersonID = -1, UserID = -1;

            if (clsUserDataAccess.GetUserInfoByUserName(UserName, ref UserID, ref PersonID, ref FirstName, ref LastName, ref Email,
                ref Phone, ref Password, ref PermissionsStr))
            {
                return new clsUserBusinessLogic(UserID, PersonID, FirstName, LastName, Email,
                Phone, UserName, Password, PermissionsStr);

            }
            else
                return null;

        }

        public static clsUserBusinessLogic Find(string UserName, string Password)
        {

            string FirstName = "", LastName = "", Email = "", Phone = "", PermissionsStr = "";

            int PersonID = -1, UserID = -1;

            if (clsUserDataAccess.GetUserInfoByUserNameAndPassword(UserName, Password, ref UserID, ref PersonID, ref FirstName, ref LastName, ref Email,
                ref Phone, ref PermissionsStr))
                return new clsUserBusinessLogic(UserID, PersonID, FirstName, LastName, Email,
                                                    Phone, UserName, Password, PermissionsStr);
            else
                return null;

        }




        public static DataTable GetAllUsers()
        {
            return clsUserDataAccess.GetAllUsers();
        }


        public static bool DeleteUser(int UserID)
        {
            return clsUserDataAccess.DeleteUser(UserID);
        }


        public static bool DoesUserExist(int UserID)
        {
            return clsUserDataAccess.DoesUserExist(UserID);
        }

        public static bool DoesUserExist(string UserName)
        {
            return clsUserDataAccess.DoesUserExist(UserName);
        }

        public static int GetUsersCountInSystem()
        {

            return clsUserDataAccess.GetUsersCountInSystem();

        }


        public static DataTable GetAllLogins()
        {
            return clsLoginDataAccess.GetAllLogins();
        }

        public static int CountLogins()
        {
            return clsLoginDataAccess.CountLogins();
        }

        public bool RegisterLogin()
        {
            return clsLoginDataAccess.AddNewLogin(this.UserID, DateTime.Now) != -1;
        }



    }
}
