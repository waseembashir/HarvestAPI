using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HarvestApi
{
    public interface IAccount
    {
        string GetEncodedCredentials(string username, string password);
        string GetHavestPath(string path);
    }
}
