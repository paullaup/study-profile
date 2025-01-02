using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;
using System.Text.Json;

using frontend.model.data;
using System.Security.Cryptography;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using frontend.control;
using Newtonsoft.Json.Linq;

namespace frontend.model
{
    internal class AccountApp
    {

        private string ip;

        public AccountApp()
        {
            ip = "http://127.0.0.2:80";
        }

        public string[] getEmployeeData(Account account) 
        {
            using(HttpClient client = new HttpClient())
            { 
                Uri uri = new Uri(ip+"/verify");
                AccountVerificationData postData = new AccountVerificationData()
                {
                    id = account.id,
                    password = account.password
                };
                string postDataJson = JsonConvert.SerializeObject(postData);
                StringContent payload = new StringContent(postDataJson, Encoding.UTF8, "application/json");
                string result = client.PostAsync(uri, payload).Result.Content.ReadAsStringAsync().Result;
                JObject data = JObject.Parse(result);
                string[] accountData = new string[3];
                if ((string)data["success"] == "true")
                {
                    accountData[0] = (string)data["positionName"];
                    accountData[1] = (string)data["staffName"];
                    accountData[2] = (string)data["emailAddress"];
                }
                else
                {
                    accountData[0] = "unauthorized";
                    accountData[1] = "";
                    accountData[2] = "";
                }
                return accountData;
            }
        }

        public string[] getPermissionName(string position)
        {
            using(HttpClient client = new HttpClient())
            {
                string url = ip + "/account/getpermission?position=" + position;
                string result = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
                JObject data = JObject.Parse(result);
                JArray permissions = (JArray)data["permissions"];
                string[] functions = new string[permissions.Count];
                for(int i = 0; i< functions.Length; i++)
                {
                    functions[i] = (string)permissions[i];
                }
                return functions;
            }            
        }

    }
}
