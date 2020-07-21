using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
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
    public partial class FormPostList : KryptonForm
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
            DirectoryInfo di = new DirectoryInfo(Path.Combine(Settings.Default.DestinationFolder, Settings.Default.LatestPostFolderName));
            List<FileInfo> latestFiles = di.GetFiles("*_Response.json").ToList().OrderByDescending(p => p.LastWriteTime).ToList();

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
                    try
                    {
                        tmpParsedData = ParserBL.GetInstance().GetObjectFromJsonFile<ResponseBarcode>(item.FullName, serializerSettings);

                        if (tmpParsedData != null)
                        {
                            postListItem = new PostListItem(i, tmpParsedData);
                            postListItem.Dock = DockStyle.Top;
                            postListItem.Name = item.Name;
                            postListItem.Height = 28;
                            postListItem.Width = 315;
                            postListItem.PostItemDetailClicked += PostListItem_PostItemDetailClicked;
                            postListItem.PostItemPrint += PostListItem_PostItemPrint;
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
                    catch (Exception ex)
                    {
                        Logger.GetInstance().Error(item.FullName +" dosyası parse edilemedi", ex);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.GetInstance().Error("Son işlem yapılan reçete dosyaları okunamadı", ex);
                new FormNotification("Son işlem yapılan reçete dosyaları okunamadı", NotificationType.Error).ShowDialog();                
            }
        }

        private void PostListItem_PostItemPrint(object sender, EventArgs e)
        {
            try
            {
                selectedResponseBarcode = sender as ResponseBarcode;
                if (selectedResponseBarcode.Data != null)
                {
                    string tmpPDFPath = Printer.GetInstance().CreatePDF(selectedResponseBarcode);
                    Printer.GetInstance().Print(tmpPDFPath);
                }
                else
                {
                    KryptonMessageBox.Show("Aradığınız ilaç için veriler henüz eklenmedi. En kısa sürede eklenecektir", "Uyarı");
                }

            }
            catch (Exception ex)
            {
                Logger.GetInstance().Error("Barkod yazdırılamadı", ex);
            }

        }

        private void PostListItem_PostItemDetailClicked(object sender, EventArgs e)
        {

            selectedResponseBarcode = sender as ResponseBarcode;
            if (selectedResponseBarcode.Data != null)
            {
                ShowResponseDetails();
            }
            else
            {
                KryptonMessageBox.Show("Aradığınız ilaç için veriler henüz eklenmedi. En kısa sürede eklenecektir", "Uyarı");
            }
        }

        private void locationForm(int height = 250)
        {
            StartPosition = FormStartPosition.Manual;
            //MaximumSize = new Size(widht, height);
            MaximumSize = new Size(375, height > 250 ? height : 250);
            MinimumSize = new Size(375, 250);
            Width = 375;
            Height = height;
            foreach (var scrn in Screen.AllScreens)
            {
                if (scrn.Bounds.Contains(this.Location))
                {
                    Location = new Point(scrn.Bounds.Right - 440, scrn.Bounds.Height-Height-150);
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
            catch (Exception ex)
            {
                Logger.GetInstance().Error("Barkod yazdırılamadı", ex);
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

                locationForm(450);
                splitContainer1.Panel1Collapsed = true;
                splitContainer1.Panel2Collapsed = false;
                this.Text = "Reçete Detayları";
            }


        }

        private void btnSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DrugPreview item in flowLayoutPanel1.Controls)
            {
                item.Drug.IsPrint = btnSelectAll.Checked;
                item.chkIsPrint.Checked = btnSelectAll.Checked;
            }

            btnSelectAll.Text = btnSelectAll.Checked ? "Temizle" : "Tümünü Seç";
            btnSelectAll.Values.Image = btnSelectAll.Checked ? Resources.delete : Resources.check_box;

        }
    }
}
