using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FarmaKode.Client.Model;
using FarmaKode.Client.Model.Response;

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
