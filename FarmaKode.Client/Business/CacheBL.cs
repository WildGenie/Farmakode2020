using FarmaKode.Client.Model;
using FarmaKode.Client.Properties;
using FarmaKode.Client.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaKode.Client.Business
{
    public class CacheBL
    {
        public static List<Parameter> parameterList = null;
        public static string IPAddress = string.Empty;


        public static void LoadCache()
        {
            parameterList = ParameterBL.GetInstance().GetParameters();
            IPAddress = Common.GetPublicIp(Settings.Default.IPAddressServer);
        }


        public static bool CheckSettings()
        {
            if (string.IsNullOrEmpty(Settings.Default.PharmacyID))
                return false;
            if (string.IsNullOrEmpty(Settings.Default.SourceFolder))
                return false;
            if (string.IsNullOrEmpty(Settings.Default.FileExtension))
                return false;

            return true;
        }
    }
}
