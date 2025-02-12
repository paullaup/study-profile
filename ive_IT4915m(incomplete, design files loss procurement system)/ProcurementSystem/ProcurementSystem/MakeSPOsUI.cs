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
    public partial class MakeSPOsUI : Form
    {

        private MakeSPOsControl makeSPOsControl;

        public MakeSPOsUI(object makeSPOsControl, string requestID, string remark)
        {
            InitializeComponent();
            txtRequestID.Text = requestID;
            richTxtRequestRemark.Text = remark;
            this.makeSPOsControl = (MakeSPOsControl)makeSPOsControl;
        }

        private void MakeSPOsUI_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private void btnSearchRequestItem_Click(object sender, EventArgs e)
        {
            new ViewRequestItemControl(txtRequestID.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            makeSPOsControl.cancel();
        }
    }
}
