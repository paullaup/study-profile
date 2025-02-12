using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProcurementSystem
{
    internal class BlanketReleaseAdapter : EntityAdapter
    {

        public BlanketReleaseAdapter() : base()
        {

        }

        public int getLatestReleaseNumber()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT MAX(releaseNumber) FROM BlanketRelease";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, new OleDbConnection(connStr));
            adapter.Fill(dt);
            return (dt.Rows.Count == 0) ? 0 : int.Parse(dt.Rows[0][0].ToString());
        }

        public bool addBlanketRelease(BlanketRelease blanketRelease)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM BlanketRelease";
                OleDbDataAdapter adapter = new OleDbDataAdapter(sql, new OleDbConnection(connStr));
                adapter.Fill(dt);
                DataRow row = dt.NewRow();
                row["releaseNumber"] = blanketRelease.getPONumber();
                row["BPAID"] = blanketRelease.GetBPAID();
                row["createdDate"] = blanketRelease.GetCreatedDate();
                row["shipAddress"] = blanketRelease.GetShipAddress();
                row["expectedDeliveryDate"] = blanketRelease.GetExpectedDeliveryDate();
                row["account"] = blanketRelease.GetAccount().getID();
                row["actualAmount"] = blanketRelease.GetActualAmount();
                row["actualQuantity"] = blanketRelease.GetActualQuantity();
                dt.Rows.Add(row);
                OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
                adapter.Update(dt);
            } catch(Exception ex)
            {
                MessageBox.Show("Error in creating blanket release");
                return false;
            }
            return true;
}

    }
}
