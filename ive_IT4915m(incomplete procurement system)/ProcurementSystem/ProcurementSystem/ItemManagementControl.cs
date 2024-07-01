using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class ItemManagementControl
    {

        private ItemAdapter adapter;
        private MainUIControl mainUIControl;

        public ItemManagementControl(MainUIControl mainUIControl)
        {
            this.mainUIControl = mainUIControl;
            adapter = new ItemAdapter();
            
        }

    }
}
