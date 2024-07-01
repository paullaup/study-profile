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
    public partial class MakeScheduleReleaseUI : Form
    {

        private MakeScheduleReleaseControl makeScheduleReleaseControl;
        private DataTable PPO;
        private BindingSource PPOBindingSource;

        public MakeScheduleReleaseUI(object makeScheduleReleaseControl, DataTable PPO)
        {
            InitializeComponent();
            this.makeScheduleReleaseControl = (MakeScheduleReleaseControl)makeScheduleReleaseControl;
            this.PPO = PPO;
            PPOBindingSource = new BindingSource();
            PPOBindingSource.DataSource = PPO;
            dgvPPO.DataSource = PPOBindingSource;
            txtPPOID.DataBindings.Add("text", PPOBindingSource, "PPOID");
            dgvPPO.ReadOnly = true;
            dgvPPO.AllowUserToAddRows = false;
        }

        private void MakeScheduleReleaseUI_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            dgvPPO.Columns["supplierID"].Visible = false;
            dgvPPO.Columns["buyerID"].Visible = false;
        }

        private void btnViewPPOItems_Click(object sender, EventArgs e)
        {
            makeScheduleReleaseControl.viewPPOItems(txtPPOID.Text);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            makeScheduleReleaseControl.submit(new ScheduleRelease(txtPPOID.Text, dtpExpectedDeliveryDate.Value));;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
