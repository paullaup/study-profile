using frontend.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontend.control
{
    internal abstract class PageControl
    {

        protected object previousPageControl;
        protected Form currentForm;

        public PageControl(Form currentForm,  object previousPageControl = null)
        {
            this.currentForm = currentForm;
            this.previousPageControl = previousPageControl;
            this.currentForm.MdiParent = MainControl.mainUI;
            currentForm.Dock = DockStyle.Fill;
            currentForm.WindowState = FormWindowState.Maximized;
            currentForm.Show();
        }

    }
}
