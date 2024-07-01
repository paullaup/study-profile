using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcurementSystem
{
    internal class LoginControl
    {

        private AccountAdapter entityAccount;
        private LoginUI loginUI;
        private MainUIControl applicationFormControl;


        public LoginControl(LoginUI loginUI)
        {
            entityAccount = new AccountAdapter();
            this.loginUI = loginUI;
        }

       

        public bool Login(string ID, string password)
        {
            string position = entityAccount.verify(ID, password);
            switch (position)
            {
                case "":
                    return false;
                case "Restaurant Manager":
                    applicationFormControl = new RestaurantManagerControl(loginUI, new Account(ID, password, entityAccount.getEmpDepartment(ID)));
                    Logger.writeLog($"ID : {ID}, Restaurant Manager login to the system");
                    break;
                case "Purchase Manager":
                    applicationFormControl = new PurchaseManagerControl(loginUI, new Account(ID, password, entityAccount.getEmpDepartment(ID)));
                    Logger.writeLog($"ID : {ID}, Purchase Manager login to the system");
                    break;
                case "Category Manager":
                    applicationFormControl = new CategoryManagerControl(loginUI, new Account(ID, password, entityAccount.getEmpDepartment(ID)));
                    Logger.writeLog($"ID : {ID}, Category Manager login to the system");
                    break;
                case "Warehouse Clerk":
                    applicationFormControl = new WarehouseClerkControl(loginUI, new Account(ID, password, entityAccount.getEmpDepartment(ID)));
                    Logger.writeLog($"ID : {ID}, Warehouse Clerk login to the system");
                    break;
                default:
                    return false;              
            }
            return true;
        }

        public void startRegister()
        {
            new RegisterControl(loginUI);
        }

        public void startFindPassword()
        {
            new FindPasswordControl(loginUI);
        }

    }
}
