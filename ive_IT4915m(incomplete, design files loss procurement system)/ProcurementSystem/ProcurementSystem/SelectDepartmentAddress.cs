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
    public partial class SelectDepartmentAddress : Form
    {

        private ViewDepartmentControl departmentControl;
        private BindingSource departmentBindingSource;
        public RichTextBox txtAddress;

        public SelectDepartmentAddress()
        {
            InitializeComponent();
            ViewDepartmentControl departmentControl = new ViewDepartmentControl();
            departmentBindingSource = new BindingSource();
            departmentBindingSource.DataSource = departmentControl.getDepartmentDT();
            txtDepartmentID.DataBindings.Add("text", departmentBindingSource, "deptID");
            txtDepartmentName.DataBindings.Add("text", departmentBindingSource, "deptName");
            richTxtAddress.DataBindings.Add("text", departmentBindingSource, "Address");
            dataGridView1.DataSource = departmentBindingSource;
            txtAddress = richTxtAddress;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectDepartmentAddress_Load(object sender, EventArgs e)
        {

        }
    }
}
