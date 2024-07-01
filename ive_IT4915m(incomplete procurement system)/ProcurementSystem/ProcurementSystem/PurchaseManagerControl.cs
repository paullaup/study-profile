using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcurementSystem
{
    internal class PurchaseManagerControl : MainUIControl
    {


        public PurchaseManagerControl(LoginUI loginUI, Account loginAccount) : base(loginAccount, loginUI)
        {
            setApplicationForm(new PurchaseManagerUI(this));
            loginUI.Hide();
        }

        public void startMapRequest()
        {
            new MapRequestControl(this);
        }

        public void makeScheduleRelease()
        {
            new MakeScheduleReleaseControl(this);
        }

    }
}
