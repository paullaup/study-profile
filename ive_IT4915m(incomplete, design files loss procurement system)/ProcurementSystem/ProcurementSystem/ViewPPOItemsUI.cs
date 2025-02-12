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
    public partial class ViewPPOItemsUI : Form
    {

        private ViewPPOItemsControl viewPPOControl;
        private DataTable PPOItems;
        private BindingSource bindingSource;

        public ViewPPOItemsUI(object viewPPOControl, DataTable PPOItems)
        {
            this.Show();
            InitializeComponent();
            this.viewPPOControl = (ViewPPOItemsControl)viewPPOControl;
            this.PPOItems = PPOItems;
            bindingSource = new BindingSource();
            bindingSource.DataSource = this.PPOItems;
            dataGridView1.DataSource = bindingSource;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
