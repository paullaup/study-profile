using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class ViewBPAControl
    {

        private BPAAdapter bPAAdapter;

        public ViewBPAControl()
        {
            bPAAdapter = new BPAAdapter();
        }

        public DataTable getBPADT(string name, string condition)
        {
            return bPAAdapter.getBPAdt("BPA", condition);
        }

    }
}
