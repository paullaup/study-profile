using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcurementSystem
{
    internal class RestaurantManagerControl : MainUIControl
    {

        public RestaurantManagerControl(LoginUI loginUI, Account loginAccount) : base(loginAccount, loginUI)
        {
            setApplicationForm((Form) new RestaurantManagerUI(this));
            loginUI.Hide();
        }

        public void startMakeEditRequest()
        {
            new MakeRequesetControl(this);
        }



    }
}
