using System;
using System.Net.Http;
using System.Windows.Forms;

namespace frontend.model
{
    internal class LoginBase
    {

        public async string Trylogin(string id, string password)
        {
            try
            {
                HttpResponseMessage httpMsg = await httpClient.GetAsync("http://127.0.0.2/login?staffID=S001&password=123");
                string msg = await httpMsg.Content.ReadAsStringAsync();
                MessageBox.Show(msg);
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}