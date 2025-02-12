using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class EntityAdapter
    {

        protected string connStr;

        public EntityAdapter()
        {
            connStr = ConfigurationManager.AppSettings["dbConnStr"];
        }

    }
}
