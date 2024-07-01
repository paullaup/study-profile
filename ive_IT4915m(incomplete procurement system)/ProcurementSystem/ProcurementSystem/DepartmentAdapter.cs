using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class DepartmentAdapter : EntityAdapter
    {

        public DepartmentAdapter() : base()
        {

        }

        public DataTable getDepartmentDT()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM Department";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, new OleDbConnection(connStr));
            adapter.Fill(dt);
            return dt;
        }

    }
}
