using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class ViewPPOItemsControl
    {

        private PPOAdapter adapter;
        private ViewPPOItemsUI viewPPOItemsUI;

        public ViewPPOItemsControl(string PPOID)
        {
            adapter = new PPOAdapter();
            viewPPOItemsUI = new ViewPPOItemsUI(this, adapter.getPPOItemsDT("PPOItems", PPOID, null));
        }

    }
}
