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
    public partial class MapRequestUI : Form
    {

        private MapRequestControl mapRequestControl;
        private DataTable requestQueue;
        private DataTable mappingOption;
        private BindingSource requestBindingSource;
        private BindingSource mappingOptionBindingSource;


        public MapRequestUI(object mapRequestControl, DataTable requestQueue, DataTable warehouseInventory)
        {
            InitializeComponent();

            requestBindingSource = new BindingSource();
            mappingOptionBindingSource = new BindingSource();
            requestBindingSource.DataSource = requestQueue;
            mappingOptionBindingSource.DataSource = warehouseInventory;

            this.mapRequestControl = (MapRequestControl)mapRequestControl;  

            this.requestQueue = requestQueue;
            mappingOption = warehouseInventory;

            dgvRequest.DataSource = requestBindingSource;
            dgvMapType.DataSource = mappingOptionBindingSource;

            dgvRequest.ReadOnly = true;
            dgvRequest.AllowUserToAddRows = false;

            dgvMapType.ReadOnly = true;
            dgvMapType.AllowUserToAddRows = false;

            dgvRequest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            rbWarehouse.Checked = true;
        }

        private void dgvRequest_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mapRequestControl.startViewRequestItem(requestQueue.Rows[requestBindingSource.Position]);
        }

        private void MapRequestUI_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            dgvRequest.Columns["restaurantID"].Visible = false;
        }

        private void rbWarehouse_CheckedChanged(object sender, EventArgs e)
        {
            if(rbWarehouse.Checked)
            {
                DataTable dt = mapRequestControl.getWarehouseInventory(null);
                dt.Columns[2].ColumnName = "Item stock quantity";
                mappingOptionBindingSource.DataSource = dt;
                mappingOption = dt;

            }
        }

        private void rbBPA_CheckedChanged(object sender, EventArgs e)
        {
            if(rbBPA.Checked)
            {
                DataTable dt = mapRequestControl.getBPA(null);
                mappingOptionBindingSource.DataSource = dt;
                mappingOption = dt;
                dgvMapType.Columns["supplierID"].Visible=false;
                dgvMapType.Columns["buyerID"].Visible = false;
            }

        }

        private void rbCPA_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCPA.Checked)
            {
                DataTable dt = mapRequestControl.getCPA(null);
                mappingOptionBindingSource.DataSource = dt;
                mappingOption = dt;
            }
        }

        private void rbPPO_CheckedChanged(object sender, EventArgs e)
        {
            if(rbPPO.Checked)
            {
                DataTable dt = mapRequestControl.getPPO(null);
                mappingOptionBindingSource.DataSource = dt;
                mappingOption = dt;
            }
        }

        private void dgvMapType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(rbBPA.Checked)
            {
                mapRequestControl.startViewBPAItems(mappingOption.Rows[mappingOptionBindingSource.Position]);
            }
            else if(rbPPO.Checked)
            {
                mapRequestControl.startViewPPOItems(mappingOption.Rows[mappingOptionBindingSource.Position]);
            }
        }

        private void btnVIewRequestItem_Click(object sender, EventArgs e)   // same as dgvRequest_CellDoubleClick
        {
            mapRequestControl.startViewRequestItem(requestQueue.Rows[requestBindingSource.Position]);
        }

        private void btnBPAMap_Click(object sender, EventArgs e)
        {
            /*foreach (DataRow row in requestQueue.Rows)
            {
                if (row["requestID"].Equals(txtRequestID.Text))
                {
                    mapRequestControl.startMakeBlanketRelease(txtRequestID.Text);
                    return;
                }
            }*/
            mapRequestControl.startMakeBlanketRelease(txtRequestID.Text);

        }

        private void dgvRequest_SelectionChanged(object sender, EventArgs e)
        {
            txtRequestID.Text = requestQueue.Rows[requestBindingSource.Position]["requestID"].ToString();
        }

        private void btnInventoryMap_Click(object sender, EventArgs e)
        {
            mapRequestControl.MakeDespatchInstruction(txtRequestID.Text);
        }

        private void btnCPAMap_Click(object sender, EventArgs e)
        {
            mapRequestControl.mapToContract(txtRequestID.Text);
        }
    }
}
