using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class ViewBPAItemsControl
    {

        private BPAAdapter adapter;
        private ViewBPAItemsUI viewBPAItemsUI;

        public ViewBPAItemsControl(string BPAID)
        {
            adapter = new BPAAdapter();
            viewBPAItemsUI = new ViewBPAItemsUI(this, adapter.getBPAItemsDT("BPAItems", BPAID, null));
        }

    }
}
