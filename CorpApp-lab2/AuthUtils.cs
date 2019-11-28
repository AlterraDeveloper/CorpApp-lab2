using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CorpApp_lab2
{
    public class AuthUtils
    {
        public static string GetHash(string s)
        {
            return Encoding.ASCII.GetString(
                new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(s)));
        }
    }
}
