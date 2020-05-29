using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaKode.Client.Util
{
    public class Common
    {
       
        public static string GetPublicIp(string serviceUrl = "https://ipinfo.io/ip")
        {
            try
            {                
                return new System.Net.WebClient().DownloadString(serviceUrl).Replace("\n",string.Empty);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
         
       
    }
}
