using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcurementSystem
{
    public partial class MakeRequestUI : Form
    {

        private MakeRequesetControl makeRequesetControl;

        private DataTable itemDT;
        private BindingSource itemBindingSource;
        private DataTable addedItems;


        public MakeRequestUI(object makeRequestControl, DataTable itemDT, DataTable addedItems)
        {
            InitializeComponent();
            this.makeRequesetControl = (MakeRequesetControl)makeRequestControl;
            this.itemDT = itemDT;
            this.addedItems = addedItems;
            itemBindingSource = new BindingSource();
            itemBindingSource.DataSource = itemDT;
            dgvItem.DataSource = itemBindingSource;
            dgvAddedItem.DataSource = addedItems;
            txtItemID.DataBindings.Add("text", itemBindingSource, "itemID");
            dgvAddedItem.ReadOnly = true;
            dgvAddedItem.AllowUserToAddRows = false;
            dgvItem.ReadOnly = true;
            dgvItem.AllowUserToAddRows = false;
            
           
        }

        private void MakeEditRequestUI_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            dgvItem.Columns["categoryID"].Visible = false;
            dgvItem.Columns["supplierID"].Visible = false;
        }

        private void searchItemUI1_Load(object sender, EventArgs e)
        {

        }



        private void btnAddItem_Click(object sender, EventArgs e)
        {
            DataRow[] foundRows = itemDT.Select("itemID= '" + txtItemID.Text + "'");
            if (foundRows.Length == 0)
            {
                MessageBox.Show("error");
                return;
            }
            if (!int.TryParse(txtQuantity.Text, out _))
            {
                MessageBox.Show("error2");
                return;
            }
            DataRow row = addedItems.NewRow();
            row["itemID"] = txtItemID.Text;
            row["quantity"] = int.Parse(txtQuantity.Text);
            addedItems.Rows.Add(row);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Account account = makeRequesetControl.getAccount();
            Request request = new Request(account.getDeptID(), account.getID(), DateTime.Now, dtExpectedDeliveryDate.Value, "Waiting for mapping", richTextBox1.Text);
            RequestItem[] requestitems = new RequestItem[dgvAddedItem.RowCount];
            for(int i = 0; i<dgvAddedItem.RowCount; i++)
            {
                DataRow row = addedItems.Rows[i];
                requestitems[i] = new RequestItem(request.getRequestID(), row["itemID"].ToString(), int.Parse(row["quantity"].ToString()));
            }
            makeRequesetControl.submit(request, requestitems);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow[] foundRows = addedItems.Select("itemID= '" + txtItemID.Text + "'");
            if (MessageBox.Show("Are you sure you want to delete and item with itemID " + txtItemID.Text, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < foundRows.Length; i++)
                {
                    addedItems.Rows.Remove(foundRows[i]);
                }
            }
        }
    }
}
