using frontend.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontend.control
{
    internal class MainControl
    {

        public static MainUI mainUI;

        public MainControl()
        {
            MainControl.mainUI = new MainUI(this);
            mainUI.Show();
            mainUI.addFunction(LoginControl.account.getPermissions());
        }

        public void startFunctionByName(string function)
        {
            Type type = Type.GetType($"frontend.control.{function}Control");
            Activator.CreateInstance(type);
        }

    }
}
