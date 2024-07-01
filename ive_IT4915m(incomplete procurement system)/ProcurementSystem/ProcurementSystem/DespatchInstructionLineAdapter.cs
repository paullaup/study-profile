using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSystem
{
    internal class DespatchInstructionLineAdapter : EntityAdapter
    {

        public DespatchInstructionLineAdapter() : base()
        {

        }

        public void addDespatchInstructionLine(DespatchInstructionLine despatchInstructionLine)
        {
            string sql = "SELECT * FROM DespatchInstructionLine";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, new OleDbConnection(connStr));
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow row = dt.NewRow();
            row["instructionID"] = despatchInstructionLine.GetInstructionID();
            row["itemID"] = despatchInstructionLine.GetItemID();
            row["quantity"] = despatchInstructionLine.GetQuantity();
            row["remark"] = despatchInstructionLine.GetRemark();
            dt.Rows.Add(row);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.Update(dt);
        }

        public DataTable getInstructionItems(int instructionID)
        {
            string sql = "SELECT itemName, quantity, remark FROM DespatchInstructionLine, Item WHERE DespatchInstructionLine.itemID = Item.itemID AND instructionID = @instructionID";
            OleDbCommand cmd = new OleDbCommand(sql, new OleDbConnection(connStr));
            cmd.Parameters.AddWithValue("@instructionID", instructionID);
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);  
            return dt;
        }

    }
}
