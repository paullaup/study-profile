using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class DeliveryNoteLineAdapter : EntityAdapter
    {

        public DeliveryNoteLineAdapter() : base()
        {

        }

        public void addDeliveryNoteLine(DeliveryNoteLine deliveryNoteLine)
        {
            string sql = "SELECT * FROM DeliveryNoteLine";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, new OleDbConnection(connStr));
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow row = dt.NewRow();
            row["deliveryNoteNumber"] = deliveryNoteLine.GetDeliveryNoteNumber();
            row["instructionID"] = deliveryNoteLine.GetInstructionID();
            dt.Rows.Add(row);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.Update(dt);
        }

        public DataTable getDeliveryNoteLineDT(int deliveryNoteNum)
        {
            string sql = "SELECT * FROM DeliveryNoteLine WHERE deliveryNoteNumber = ?";
            OleDbCommand cmd = new OleDbCommand(sql, new OleDbConnection(connStr));
            cmd.Parameters.Add("@deliveryNoteNumber", OleDbType.Integer).Value = deliveryNoteNum;
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            return dt;  
        }

    }
}
