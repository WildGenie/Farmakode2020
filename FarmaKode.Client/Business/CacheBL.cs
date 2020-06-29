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

            try
            {
                string Barcods = Path.Combine(Settings.Default.DestinationFolder, "Barcods");
                string LatestPost = Path.Combine(Settings.Default.DestinationFolder, "LatestPost");
                string ReportTemplate = Path.Combine(Settings.Default.DestinationFolder, "ReportTemplate");
                string path_barcode_css = Path.Combine(Settings.Default.DestinationFolder, "ReportTemplate", "barcode.css");
                string path_barcode_html = Path.Combine(Settings.Default.DestinationFolder, "ReportTemplate", "barcode.html");
                string XPathConfig = Path.Combine(Settings.Default.DestinationFolder, "XPathConfig.json");

                if (!Directory.Exists(Settings.Default.DestinationFolder))
                    Directory.CreateDirectory(Settings.Default.DestinationFolder);

                if (!Directory.Exists(Barcods))
                    Directory.CreateDirectory(Barcods);

                if (!Directory.Exists(LatestPost))
                    Directory.CreateDirectory(LatestPost);

                if (!Directory.Exists(ReportTemplate))
                    Directory.CreateDirectory(Path.Combine(Settings.Default.DestinationFolder, "ReportTemplate"));

                if (!File.Exists(path_barcode_css))
                    File.WriteAllText(path_barcode_css, Resources.barcode_css);

                if (!File.Exists(path_barcode_html))
                    File.WriteAllText(path_barcode_html, Resources.barcode_html);

                if (!File.Exists(XPathConfig))
                {
                    File.WriteAllText(XPathConfig, Resources.XPathConfig);
                    parameterList = ParameterBL.GetInstance().GetParameters();
                }
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Uygulama ayar dosyaları klasörü oluşturulamadı","Hata");
                Logger.GetInstance().Error("Uygulama ayar dosyaları klasörü oluşturulamadı", ex);
                return false;
            }




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
