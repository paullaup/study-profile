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
    public partial class MakeBlanketReleaseUI : Form
    {

        private MakeBlanketReleaseControl makeBlanketReleaseControl;

        private DataTable BPA;
        private BindingSource bindingSource;


        public MakeBlanketReleaseUI(object makeBlanketReleaseControl, string requestID, string remark, DataTable BPA, DateTime expectedDeliveryDate)
        {
            InitializeComponent();
            this.makeBlanketReleaseControl = (MakeBlanketReleaseControl) makeBlanketReleaseControl;
            txtRequestID.Text = requestID;
            richTextBox1.Text = remark;
            this.BPA = BPA;
            bindingSource = new BindingSource();
            bindingSource.DataSource = BPA;
            dgvBPA.DataSource = bindingSource;
            txtBPAID.DataBindings.Add("text", bindingSource, "BPAID");
            dtExpectedDeliveryDate.Value = expectedDeliveryDate;
        }

        private void MakeBlanketReleaseUI_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            makeBlanketReleaseControl.cancel();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblAlert.Text = string.Empty;
            if (!int.TryParse(txtAmount.Text, out _) && !double.TryParse(txtAmount.Text, out _) )
            {
                lblAlert.Text = "Please input integer for the Amount";
                return;
            }
            if (!int.TryParse(txtQuantity.Text, out _) && !double.TryParse(txtQuantity.Text, out _))
            {
                lblAlert.Text = "Please input integer for the quantity";
                return;
            }
            BlanketRelease blanketRelease = new BlanketRelease(txtBPAID.Text, DateTime.Now, txtShipAddress.Text, dtExpectedDeliveryDate.Value, int.Parse(txtAmount.Text), int.Parse(txtQuantity.Text));
            RequestLine requestLine = new RequestLine(int.Parse(txtRequestID.Text), blanketRelease, richTxtOtherShipmentInformation.Text);
            makeBlanketReleaseControl.submit(blanketRelease, requestLine);
        }

        private void btnViewRequestItem_Click(object sender, EventArgs e)
        {
            makeBlanketReleaseControl.viewRequestItem();
        }

        private void btnViewBPAItem_Click(object sender, EventArgs e)
        {
            makeBlanketReleaseControl.viewBPAItems(txtBPAID.Text);
        }

        private void dgvBPA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            makeBlanketReleaseControl.viewBPAItems(txtBPAID.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSelectAddress_Click(object sender, EventArgs e)
        {
            txtShipAddress.Text = makeBlanketReleaseControl.selectDepartmentAddress();
        }
    }
}
