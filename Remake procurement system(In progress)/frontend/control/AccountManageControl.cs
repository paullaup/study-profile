using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using frontend.view;

namespace frontend.control
{
    internal class AccountManageControl : PageControl
    {

        public AccountManageControl() : base(new AccountManageUI())
        {
            ((AccountManageUI)base.currentForm).setControl(this);
        }

    }
}
