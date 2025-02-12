using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class ViewCPAControl
    {

        private CPAAdapter adapter;

        public ViewCPAControl()
        {
            adapter = new CPAAdapter();
        }

        public DataTable getCPADT(string name, string condition)
        {
            return adapter.getCPAdt("CPA", condition);
        }

    }
}
