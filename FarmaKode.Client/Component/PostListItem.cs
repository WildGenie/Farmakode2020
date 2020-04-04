using FarmaKode.Client.Model;
using FarmaKode.Client.Properties;
using FarmaKode.Client.Util;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static FarmaKode.Client.Util.Constants;

namespace FarmaKode.Client.Component
{
    public partial class PostListItem : UserControl
    {
        public List<ParsedData> Data { get; set; }

        public PostListItem()
        {
            InitializeComponent();
        }

        public PostListItem(int orderNo, List<ParsedData> Data)
        {
            InitializeComponent();
            this.Data = Data;
            load(orderNo);
        }

        void load(int orderNo)
        {
            string CustomerName = Data.Where(p => p.VariableName == "CustomerName").SingleOrDefault().Value;
            string CustomerSurname = Data.Where(p => p.VariableName == "CustomerSurname").SingleOrDefault().Value;
            lblName.Text = string.Format("{0} {1}", CustomerName, CustomerSurname);
            lblNo.Text = orderNo.ToString();
        }

        private void btnGoToWeb_Click(object sender, EventArgs e)
        {
            string link = "http://www.farmakode.com/panel/tickets/show/3934e077746c102b6ad7ee587bf413bf";
            string browserName = "iexplore";
            if (Settings.Default.NotificationBrowser == BrowseType.InternetExplorer)
            {
                browserName = "iexplore";
            }
            else if (Settings.Default.NotificationBrowser == BrowseType.Chrome)
            {
                browserName = "chrome";
            }
            else if (Settings.Default.NotificationBrowser == BrowseType.Firefox)
            {
                browserName = "firefox";
            }
            else if (Settings.Default.NotificationBrowser == BrowseType.Opera)
            {
                browserName = "opera";
            }

            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Clients\StartMenuInternet");
            var browsers = key.GetSubKeyNames();

            bool isInstalledBrowser = false;
            foreach (var item in browsers)
            {
                if (item.ToLower().Contains(browserName))
                {
                    isInstalledBrowser = true;
                    break;
                }
            }

            if (isInstalledBrowser)
            {
                Process.Start(browserName, link);
            }
            else
            {
                MessageBox.Show(browserName + " tarayıcısı yüklü olmadığı için varsayılan tarayıcı açılacaktır. Ayarlar ekranından tarayıcı türünü değiştirebilirsiniz", "Uyarı");
                Process.Start(link);
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ReportData data = new ReportData();
            data.Date = DateTime.Now;
            data.Diagnosis = "Demir Eksikliği - Kansızlık";
            data.DrugName = "MALTOFER 5 ML.20 FLAKON";
            data.Suggestion = "Günde 1 defa aç veya tok karnına 1 tüp içilecek. 1 tüp[kaşık] tek kullanımlıktır. Tamamını içiniz. Çay ve süt ürünleriyle beraber kullanmayın. C vitamini yüksek besinler tüketmeniz tedavinize yardımcı olur";
            data.ExpirationDate = DateTime.Now.Date;
            data.PatientName = "Derya Çelik";
            data.PharmacyName = "Test Eczanesi / 0 216 123 45 66";

            List<ReportData> dataList = new List<ReportData>();
            dataList.Add(data);

            LocalReport report = new LocalReport();
            string exeFolder = Application.StartupPath;
            string reportPath = Path.Combine(exeFolder, @"Data\Report\rptDrugBarcode.rdlc");
            report.ReportPath = reportPath;
            report.DataSources.Add(new ReportDataSource("dsReportData", dataList));
            LocalReportExtensions.PrintToPrinter(report);
        }
    }
}
