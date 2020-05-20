using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Runtime.InteropServices;
using System.Net;
using FarmaKode.Client.Properties;
using FarmaKode.Client.Component;
using FarmaKode.Client.Model;
using FarmaKode.Client.Business;
using FarmaKode.Client.Util;
using FarmaKode.Client.Model.Request;
using FarmaKode.Client.Model.Response;
using Microsoft.Reporting.WinForms;

namespace FarmaKode.Client
{
    public partial class FormShowPreview : Form
    {
        public FormShowPreview(ResponseBarcode responseBarcode)
        {

            InitializeComponent();
            initializeForm(responseBarcode);
            locationForm();

        }

        void initializeForm(ResponseBarcode responseBarcode)
        {

            if (responseBarcode.Result == "success")
            {
                List<ReportData> dataList = new List<ReportData>();
                foreach (var drug in responseBarcode.Data.Drugs)
                {
                    ReportData data = new ReportData();
                    data.Date = DateTime.Now;
                    data.Diagnosis = drug.Diagnosis;
                    data.DrugName = drug.Drug_name;
                    data.Suggestion = drug.Suggestions;
                    data.ExpirationDate = drug.Expiration_date;
                    data.PatientName = responseBarcode.Name_surname;
                    data.PharmacyName = responseBarcode.Data.Pharmacy_name + " / " + responseBarcode.Data.Pharmacy_phone;
                    dataList.Add(data);
                } 

                string exeFolder = Application.StartupPath;
                string reportPath = Path.Combine(exeFolder, @"Data\Report\rptDrugBarcode.rdlc");

                reportViewer1.LocalReport.ReportPath = reportPath;
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsReportData", dataList));
                reportViewer1.RefreshReport();
            }
        }


        private void locationForm()
        {
            StartPosition = FormStartPosition.Manual;
            foreach (var scrn in Screen.AllScreens)
            {
                if (scrn.Bounds.Contains(this.Location))
                {
                    Location = new Point(scrn.Bounds.Right - 410, scrn.Bounds.Height - Height - 150);
                    return;
                }
            }
        }

        private void FormPostList_Deactivate(object sender, EventArgs e)
        {
            Close();
        }

        private void FormShowPreview_Load(object sender, EventArgs e)
        {

        }
    }
}
