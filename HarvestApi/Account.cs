using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarvestApi
{
    class Account:IAccount
    {
        public string GetHavestPath(string path)
        {
            return String.Format("https://{0}.harvestapp.com/", path);
        }

        public string GetEncodedCredentials(string username, string password)
        {
             var usernamePassword = username + ":" + password;
             return  Convert.ToBase64String(new ASCIIEncoding().GetBytes(usernamePassword));

        }
    }
}
