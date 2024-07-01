using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class ViewDepartmentControl
    {

        private DepartmentAdapter departmentAdapter;

        public ViewDepartmentControl()
        {
            departmentAdapter = new DepartmentAdapter();
        }

        public DataTable getDepartmentDT()
        {
            return departmentAdapter.getDepartmentDT();
        }

    }
}
