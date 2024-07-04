using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontend.model
{
    internal class async : LoginBase
    {

        private HttpClient httpClient;


        public async()
        {
            httpClient = new HttpClient();
        }

        public async string get(string url)
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(url);
                string msg = await response.Content.ReadAsStringAsync();
                return msg;
            } catch (Exception ex)
            {
                return null;
            }
            
        }
    }
}
