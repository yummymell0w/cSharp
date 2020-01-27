
using System.Text;

namespace Problems
{
    public class DefangingIpAddress
    {
        /*
        // v1
        public static string DefangIPaddr(string address) {
            string defangIp = address.Replace(".","[.]");
            return defangIp;
            }
        }
        */

        // v2
        public static string DefangIPaddr(string ipAddress)
        {
            StringBuilder sb = new StringBuilder();
            char[] arrayAddress = new char[ipAddress.Length];
            arrayAddress = ipAddress.ToCharArray();
            for (int i = 0; i < ipAddress.Length; i++)
            {
                if (arrayAddress[i] == '.')
                {
                    sb.Append("[.]");
                }
                else
                {
                    sb.Append(arrayAddress[i]);
                }
            }
            string defangIP = sb.ToString();
            return defangIP;
        }
    }
}
