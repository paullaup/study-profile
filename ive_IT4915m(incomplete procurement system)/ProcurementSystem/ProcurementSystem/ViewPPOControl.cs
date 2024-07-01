using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class ViewPPOControl
    {

        private PPOAdapter adapter;

        public ViewPPOControl()
        {
            adapter = new PPOAdapter();
        }

        public DataTable getPPODT(string name, string condition)
        {
            return adapter.getPPOdt(name, condition);
        } 


    }
}
