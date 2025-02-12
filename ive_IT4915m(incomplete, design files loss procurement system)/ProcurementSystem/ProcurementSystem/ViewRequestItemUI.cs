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
    public partial class ViewRequestItemUI : Form
    {

        private ViewRequestItemControl viewRequestItemControl;
        private DataTable requestItem;
        private BindingSource bindingSource;

        public ViewRequestItemUI(object viewRequestItemControl, DataTable requestItem)
        {
            InitializeComponent();
            this.viewRequestItemControl = (ViewRequestItemControl)viewRequestItemControl;
            this.requestItem = requestItem;
            bindingSource = new BindingSource();
            bindingSource.DataSource = requestItem;
            dgvRequestItem.DataSource = bindingSource;
            dgvRequestItem.AllowUserToAddRows = false;
            dgvRequestItem.ReadOnly = true;
            dgvRequestItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ViewRequestItemUI_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
