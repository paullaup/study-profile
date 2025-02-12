using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class WarehouseClerkControl : MainUIControl
    {

        public WarehouseClerkControl(LoginUI loginUI, Account loginAccount) : base(loginAccount, loginUI)
        {
            setApplicationForm(new WarehouseClerkUI(this));
            loginUI.Hide();
        }

        public void receiveDespatchInstruction()
        {
            new ReceiveDespatchInstructionControl(this);
        }

        public void updateDeliveryNoteStatus()
        {
            new UpdateDeliveryNoteStatusControl(this);
        }



    }
}
