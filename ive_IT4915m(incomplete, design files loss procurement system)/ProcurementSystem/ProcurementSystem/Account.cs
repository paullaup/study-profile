using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class Account
    {
        private string ID;
        private string password;
        private string deptID;

        public Account(string ID, string password, string deptID)
        {
            this.ID = ID;
            this.password = password;
            this.deptID = deptID;
        }

        public string getID()
        {
            return this.ID;
        }


        public string getDeptID()
        {
            return deptID;
        }
    }
}
