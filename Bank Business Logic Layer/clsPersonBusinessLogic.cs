using Bank_Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Business_Logic_Layer
{
    public class clsPersonBusinessLogic
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public int PersonID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }


        private bool _AddNewPerson()
        {
            //call DataAccess Layer 

            this.PersonID = clsPersonDataAccess.AddNewPerson(this.FirstName, this.LastName, this.Email, this.Phone);

            return (this.PersonID != -1);
        }


        private bool _UpdatePerson()
        {
            //call DataAccess Layer 

            return clsPersonDataAccess.UpdatePerson(this.PersonID, this.FirstName, this.LastName,
                this.Email, this.Phone);

        }


        public static clsPersonBusinessLogic Find(int PersonID)
        {

            string FirstName = "", LastName = "", Email = "", Phone = "";

            

            if (clsPersonDataAccess.GetPersonInfoByID(PersonID, ref FirstName, ref LastName, ref Email, ref Phone))

                return new clsPersonBusinessLogic(PersonID, FirstName, LastName, Email, Phone);
            else
                return null;

        }

        public clsPersonBusinessLogic()
        {
            this.PersonID = -1;
            this.LastName = string.Empty;
            this.FirstName = string.Empty;
            this.Email = string.Empty;
            this.Phone = string.Empty;

            Mode = enMode.AddNew;
        }

        private clsPersonBusinessLogic(int PersonID, string FirstName, string LastName, string Email, string Phone)
        {
            this.PersonID = PersonID;
            this.LastName = FirstName;
            this.FirstName = LastName;
            this.Email = Email;
            this.Phone = Phone;

            Mode = enMode.Update;

        }


        public virtual bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePerson();

            }

            return false;
        }


        public static DataTable GetAllPersons()
        {
            return clsPersonDataAccess.GetAllPersons();
        }


        public static bool DeletePerson(int PersonID)
        {
            return clsPersonDataAccess.DeletePerson(PersonID);
        }


        public static bool DoesPersonExist(int PersonID)
        {
            return clsPersonDataAccess.DoesPersonExist(PersonID);
        }





    }
}
