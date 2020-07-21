using FarmaKode.Client.Properties;
using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
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
                return new System.Net.WebClient().DownloadString(serviceUrl).Replace("\n", string.Empty);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static List<string> GetPcNumberList()
        {
            List<string> pCNumbersList = new List<string>();


            pCNumbersList.Add("# BOŞ #");
            for (int i = 1; i < 6; i++)
                pCNumbersList.Add(string.Format("PC-{0:##}", i));

            return pCNumbersList;
        }

        public static Size GetBarcodePaperSize()
        {
            Size paperSize = new Size(60, 40);

            try
            {
                if (!string.IsNullOrEmpty(Settings.Default.BarcodePaperSize))
                {
                    string[] values = Settings.Default.BarcodePaperSize.Split('-');

                    if (values.Length == 2)
                    {
                        paperSize.Width = Convert.ToInt32(values[0]);
                        paperSize.Height = Convert.ToInt32(values[1]);
                        Logger.GetInstance().Info("BarcodePaperSize değeri set edildi" + paperSize.ToString());
                    }
                    else
                    {
                        Logger.GetInstance().Info("BarcodePaperSize değeri varsayılan olarak set edildi");
                    }
                }
                else
                {
                    Logger.GetInstance().Info("BarcodePaperSize değeri varsayılan olarak set edildi");
                }

                return paperSize;

            }
            catch (Exception ex)
            {
                Logger.GetInstance().Error("BarcodePaperSize değeri alınamadı.", ex);
                return paperSize;
            }

        }

        public static Margins GetBarcodePaperMargins()
        {
            Margins paperMargins = new Margins(0, 0, 0, 0);

            try
            {
                if (!string.IsNullOrEmpty(Settings.Default.BarcodePaperMargins))
                {
                    string[] values = Settings.Default.BarcodePaperMargins.Split('-');

                    if (values.Length == 4)
                    {
                        paperMargins.Left = Convert.ToInt32(values[0]);
                        paperMargins.Right = Convert.ToInt32(values[1]);
                        paperMargins.Top = Convert.ToInt32(values[2]);
                        paperMargins.Bottom = Convert.ToInt32(values[3]);
                        Logger.GetInstance().Info("BarcodePaperMargins değeri set edildi" + paperMargins.ToString());
                    }
                    else
                    {
                        Logger.GetInstance().Info("BarcodePaperMargins değeri varsayılan olarak set edildi");
                    }
                }
                else
                {
                    Logger.GetInstance().Info("BarcodePaperMargins değeri varsayılan olarak set edildi");
                }

                return paperMargins;

            }
            catch (Exception ex)
            {
                Logger.GetInstance().Error("BarcodePaperMargins değeri alınamadı.", ex);
                return paperMargins;
            }

        }

        public static void AddShortcutToStartup()
        {
            string publisherName = "Farmakode";
            string productName = "FarmaKode.Client";
            if (ApplicationDeployment.IsNetworkDeployed && ApplicationDeployment.CurrentDeployment.IsFirstRun)
            {
                string startupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                startupPath = Path.Combine(startupPath, productName) + ".appref-ms";

                if (!File.Exists(startupPath))
                {
                    string allProgramsPath = Environment.GetFolderPath(Environment.SpecialFolder.Programs);
                    string shortcutPath = Path.Combine(allProgramsPath, publisherName);
                    if (!Directory.Exists(shortcutPath))
                        Directory.CreateDirectory(shortcutPath);
                    shortcutPath = Path.Combine(shortcutPath, productName) + ".appref-ms";
                    File.Copy(shortcutPath, startupPath);
                }

            }

        }

    }
}
