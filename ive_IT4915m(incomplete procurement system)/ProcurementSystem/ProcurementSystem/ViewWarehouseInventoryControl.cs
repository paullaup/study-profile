using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class ViewWarehouseInventoryControl
    {

        private WarehouseInventoryAdapter inventoryAdapter;

        public ViewWarehouseInventoryControl()
        {
            inventoryAdapter = new WarehouseInventoryAdapter();
        }

        public DataTable getWarehouseInventoryDT()
        {
            return inventoryAdapter.getWarehouseInventorySum();
        }

    }
}
