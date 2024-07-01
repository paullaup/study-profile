using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProcurementSystem
{
    internal class DeliveryNoteAdapter : EntityAdapter
    {

        public DeliveryNoteAdapter() : base()
        {

        }

        public int getLatestDeliveryNoteNumber()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT MAX(deliveryNoteNumber) AS MaxDeliveryNoteNumber FROM DeliveryNote";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, new OleDbConnection(connStr));
            adapter.Fill(dt);
            return (dt.Rows.Count == 0 || dt.Rows[0]["MaxDeliveryNoteNumber"] == DBNull.Value) ? 0 : Convert.ToInt32(dt.Rows[0]["MaxDeliveryNoteNumber"]);
        }

        public bool addDeliveryNote(DeliveryNote deliveryNote)
        {
            try
            {
                DataTable dt = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM DeliveryNote", new OleDbConnection(connStr));
                adapter.Fill(dt);
                DataRow row = dt.NewRow();
                row["deliveryNoteNumber"] = deliveryNote.GetDeliveryNoteNumber();
                row["warehouseID"] = deliveryNote.GetWarehouseID();
                row["status"] = deliveryNote.GetStatus();
                row["remark"] = deliveryNote.GetRemark();
                row["deliveryAddress"] = deliveryNote.GetShipAddress();
                dt.Rows.Add(row);
                OleDbCommandBuilder cmdBuilder = new OleDbCommandBuilder(adapter);
                adapter.Update(dt);
            } catch (Exception ex)
            {
                MessageBox.Show("Error in creating Delivery Note");
                return false;
            }
            return true;
        }

        public DataTable getDeliveryNoteDT(string name, string condition)
        {
            DataTable dt = new DataTable(name);
            string sql = "SELECT * FROM DeliveryNote WHERE 1=1";
            sql += (condition != null) ? " AND " + condition : "";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, new OleDbConnection(connStr));
            adapter.Fill(dt);
            return dt;
        }

        public void modifyDeliveryNoteStatus(int deliveryNoteNumber,  string status)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM DeliveryNote WHERE deliveryNoteNumber = ?";
            OleDbCommand cmd = new OleDbCommand(sql, new OleDbConnection(connStr));
            cmd.Parameters.Add("@deliveryNoteNumber", OleDbType.Integer).Value = deliveryNoteNumber;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            dt.Rows[0]["status"] = status;
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.Update(dt);
        }

    }
}
