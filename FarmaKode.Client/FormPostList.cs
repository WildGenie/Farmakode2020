using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FarmaKode.Client.Business;
using FarmaKode.Client.Component;
using FarmaKode.Client.Model;
using FarmaKode.Client.Model.Response;
using FarmaKode.Client.Properties;
using FarmaKode.Client.Util;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Newtonsoft.Json;
using static FarmaKode.Client.Util.Constants;

namespace FarmaKode.Client
{
    public partial class FormPostList : Form
    {
        ResponseBarcode selectedResponseBarcode = null;
        public FormPostList()
        {
            InitializeComponent();
            initializeForm();
            locationForm();
        }

        public FormPostList(ResponseBarcode selectedResponseBarcode)
        {

            InitializeComponent();
            initializeForm();
            locationForm();
            this.selectedResponseBarcode = selectedResponseBarcode;
            ShowResponseDetails();

        }

        void initializeForm()
        {
            DirectoryInfo di = new DirectoryInfo(Path.Combine(Application.StartupPath, Settings.Default.LatestPostPath));
            List<FileInfo> latestFiles = di.GetFiles("*_Response.json").ToList().OrderByDescending(p => p.CreationTime).ToList();

            PostListItem postListItem = null;
            ResponseBarcode tmpParsedData = null;
            try
            {
                panel1.Controls.Clear();
                int i = 1;
                JsonSerializerSettings serializerSettings = new JsonSerializerSettings();
                serializerSettings.Culture = new System.Globalization.CultureInfo("tr-TR");
                serializerSettings.DateFormatString = "dd.MM.YYYY";

                foreach (var item in latestFiles)
                {
                    tmpParsedData = ParserBL.GetInstance().GetObjectFromJsonFile<ResponseBarcode>(item.FullName, serializerSettings);
                    if (tmpParsedData != null)
                    {
                        postListItem = new PostListItem(i, tmpParsedData);
                        postListItem.Dock = DockStyle.Top;
                        postListItem.Name = item.Name;
                        postListItem.Height = 28;
                        postListItem.Width = 315;
                        postListItem.PosItemDetailClicked += PostListItem_PosItemDetailClicked;
                        panel1.Controls.Add(postListItem);

                    }
                    else
                    {
                        Logger.GetInstance().Info(item.FullName + " dosyası convert edilemedi");
                    }


                    if (i >= Settings.Default.NotificationMaxCount)
                        break;

                    i++;
                }
            }
            catch (Exception ex)
            {
                Logger.GetInstance().Error("Son işlem yapılan reçete dosyaları okunamadı", ex);
                new FormNotification("Son işlem yapılan reçete dosyaları okunamadı", NotificationType.Error).ShowDialog();
                this.Close();
            }
        }

        private void PostListItem_PosItemDetailClicked(object sender, EventArgs e)
        {
            selectedResponseBarcode = sender as ResponseBarcode;
            ShowResponseDetails();
        }

        private void locationForm(int widht = 355, int height = 250)
        {
            StartPosition = FormStartPosition.Manual;
            MaximumSize = new Size(widht, height);
            this.Width = widht;
            this.Height = height;
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

        private void btnLastPost_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = true;
            splitContainer1.Panel1Collapsed = false;
            locationForm();
            flowLayoutPanel1.Controls.Clear();
            this.Text = "Son İşlemler";
        }



        private void btnPrint_Click(object sender, EventArgs e)
        {

            try
            {
                string tmpPDFPath = Printer.GetInstance().CreatePDF(selectedResponseBarcode);
                Printer.GetInstance().Print(tmpPDFPath);
            }
            catch (Exception)
            {

                throw;
            }




        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DrugPreview item in flowLayoutPanel1.Controls)
            {
                item.Drug.IsPrint = true;
                item.chkIsPrint.Checked = true;
            }
        }


        void ShowResponseDetails()
        {
            if (selectedResponseBarcode.Result == "success")
            {
                List<ReportData> dataList = new List<ReportData>();
                int width = selectedResponseBarcode.Data.Drugs.Count > 2 ? 320 : 340;

                foreach (var drug in selectedResponseBarcode.Data.Drugs)
                {
                    DrugPreview drugPreview = new DrugPreview(drug);
                    drugPreview.Width = width;
                    flowLayoutPanel1.Controls.Add(drugPreview); 
                }

                locationForm(380, 450);
                splitContainer1.Panel1Collapsed = true;
                splitContainer1.Panel2Collapsed = false;
                this.Text = "Reçete Detayları";
            }

            
        }
    }
}
