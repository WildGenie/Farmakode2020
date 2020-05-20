using FarmaKode.Client.Model;
using FarmaKode.Client.Model.Request;
using FarmaKode.Client.Model.Response;
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
        public ResponseBarcode Data { get; set; }

        public PostListItem()
        {
            InitializeComponent();
        }

        public PostListItem(int orderNo, ResponseBarcode Data)
        {
            InitializeComponent();
            this.Data = Data;
            load(orderNo);
        }

        void load(int orderNo)
        { 
            lblName.Text = Data.Name_surname;
            lblNo.Text = orderNo.ToString();
        }

        private void btnGoToWeb_Click(object sender, EventArgs e)
        {
           

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
          

            new FormShowPreview(Data).ShowDialog();
            //ReportData data = new ReportData();
            //data.Date = DateTime.Now;
            //data.Diagnosis = "Demir Eksikliği - Kansızlık";
            //data.DrugName = "MALTOFER 5 ML.20 FLAKON";
            //data.Suggestion = "Günde 1 defa aç veya tok karnına 1 tüp içilecek. 1 tüp[kaşık] tek kullanımlıktır. Tamamını içiniz. Çay ve süt ürünleriyle beraber kullanmayın. C vitamini yüksek besinler tüketmeniz tedavinize yardımcı olur";
            //data.ExpirationDate = DateTime.Now.Date;
            //data.PatientName = "Derya Çelik";
            //data.PharmacyName = "Test Eczanesi / 0 216 123 45 66";

            //List<ReportData> dataList = new List<ReportData>();
            //dataList.Add(data);

            //LocalReport report = new LocalReport();
            //string exeFolder = Application.StartupPath;
            //string reportPath = Path.Combine(exeFolder, @"Data\Report\rptDrugBarcode.rdlc");
            //report.ReportPath = reportPath;
            //report.DataSources.Add(new ReportDataSource("dsReportData", dataList));
            //LocalReportExtensions.PrintToPrinter(report);
        }
    }
}
