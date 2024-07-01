using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class CategoryManagerControl : MainUIControl
    {

        public CategoryManagerControl(LoginUI loginUI, Account loginAccount) : base(loginAccount, loginUI)
        {
            setApplicationForm(new CategoryManagerUI(this));

        }


    }
}
