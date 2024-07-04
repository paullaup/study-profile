using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.model.data
{
    internal class Account
    {

        public string id;
        public string password;

        private string position;
        private string name;
        private string email;

        private string[] permissions;

        public Account(string id, string password)
        {
            this.id = id;
            this.password = password;
        }

        public void setStaffData(string position, string name, string email)
        {
            this.position = position;
            this.name = name;
            this.email = email;
        }

        public void setPermission(string[] permissions)
        {
            this.permissions = permissions;
        }

        public string getPosition() { return position; }
        public string getName() { return name; }
        public string getEmail() { return email; }
        public string[] getPermissions() { return permissions;}

    }

    internal class AccountVerificationData
    {
        public string id;
        public string password;
    }
}
