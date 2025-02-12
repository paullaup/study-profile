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
    public partial class ViewBPAItemsUI : Form
    {

        private ViewBPAItemsControl viewBPAItemsControl;
        private DataTable viewBPAItemsDataTable;
        private BindingSource bindingSource;

        public ViewBPAItemsUI(object viewBPAItemsControl, DataTable BPAItems)
        {
            this.Show();
            InitializeComponent();
            this.viewBPAItemsControl = (ViewBPAItemsControl)viewBPAItemsControl;
            this.viewBPAItemsDataTable = BPAItems;
            bindingSource = new BindingSource();
            bindingSource.DataSource = this.viewBPAItemsDataTable;
            dgvBPAItems.DataSource = bindingSource;
            dgvBPAItems.AllowUserToAddRows = false;
            dgvBPAItems.ReadOnly = true;
            dgvBPAItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ViewBPAItemsUI_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
