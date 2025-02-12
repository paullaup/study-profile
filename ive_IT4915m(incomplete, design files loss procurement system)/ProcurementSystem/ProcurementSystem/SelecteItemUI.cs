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
    public partial class SelecteItemUI : Form
    {

        private MakeRequesetControl makeEditRequesetControl;
        private ItemAdapter itemAdapter;

        public SelecteItemUI(object makeEditRequesetControl)
        {
            InitializeComponent();
            itemAdapter = new ItemAdapter();
            this.makeEditRequesetControl = (MakeRequesetControl)makeEditRequesetControl;
        }

        private void SelecteItemUI_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            


        }
    }
}
