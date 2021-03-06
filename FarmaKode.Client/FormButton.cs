﻿using ComponentFactory.Krypton.Toolkit;
using FarmaKode.Client.Business;
using FarmaKode.Client.Model;
using FarmaKode.Client.Model.Request;
using FarmaKode.Client.Model.Response;
using FarmaKode.Client.Properties;
using FarmaKode.Client.Util;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FarmaKode.Client.Util.Constants;



namespace FarmaKode.Client
{

    public partial class FormButton : Form
    {


        #region VARIABLES

        public ParserBL BL = ParserBL.GetInstance();
        public WatchDogBL watchDog = null;
        RequestBarcode lastRequestBarcode = null;
        System.Windows.Forms.Timer manuelModeTimer = null;
        System.Windows.Forms.Timer manuelBarcodePostTimer = null;
        System.Windows.Forms.Timer manuelBarcodeCleanTimer = null;
        DateTime _lastKeystroke = new DateTime(0);
        List<char> _barcode = new List<char>();
        List<string> manuelBarcods = new List<string>();

        #endregion

        public FormButton()
        {
            InitializeComponent();

            if (!CacheBL.CheckSettings())
            {
                KryptonMessageBox.Show("Lütfen öncelikle uygulama için gereki olan bilgileri giriniz", "Uyarı");
                new FormSettings().ShowDialog();
            }

            InitializeWatchDog();
            LocationForm();
            CatchManuelBarcode();
            CheckForIllegalCrossThreadCalls = false;

        }




        #region Alt Yordamlar

        void CatchManuelBarcode()
        {
            manuelBarcodeCleanTimer = new System.Windows.Forms.Timer();
            manuelBarcodeCleanTimer.Enabled = true;
            manuelBarcodeCleanTimer.Interval = 1000 * (int)Settings.Default.BarcodeClearDuration;
            manuelBarcodeCleanTimer.Tick += ManuelBarcodeCleanTimer_Tick; ;

            KeyboardListener.s_KeyEventHandler += new EventHandler(KeyboardListener_s_KeyEventHandler);

        }

        private void LocationForm()
        {
            TopMost = true;
            StartPosition = FormStartPosition.Manual;
            this.Size = new Size(50, 50);

            foreach (var scrn in Screen.AllScreens)
            {
                if (scrn.Bounds.Contains(this.Location))
                {
                    this.Location = new Point(scrn.Bounds.Right - 60, scrn.Bounds.Height - this.Height - 350);
                    return;
                }
            }
        }

        private void InitializeWatchDog()
        {
            watchDog = new WatchDogBL(Settings.Default.SourceFolder,
               Settings.Default.DestinationFolder,
               Settings.Default.FileExtension);
            watchDog.ParseFileEvent += WatchDog_ParseFileEvent;

            if (!Settings.Default.AppIsEnabled)
            {
                menuItemAppStatus.Text = "Uygulamayı AKTİF yap";
                new FormNotification("Uygulama pasif modda başladı", NotificationType.Info).ShowDialog(); ;

            }
            else
            {
                menuItemAppStatus.Text = "Uygulamayı pasif yap";
                // new FormNotification().ShowAlert("FarmaKode uygulaması başladı", NotificationType.Info);
                watchDog.Start();
            }
        }

        #endregion

        private void KeyboardListener_s_KeyEventHandler(object sender, EventArgs e)
        {
            KeyboardListener.UniversalKeyEventArgs eventArgs = (KeyboardListener.UniversalKeyEventArgs)e;

            if (eventArgs.m_Msg == 256)
            {
                //Console.Out.WriteLine(string.Format("Key = {0}  Msg = {1}  Text = {2}", eventArgs.m_Key, eventArgs.m_Msg, eventArgs.KeyData));
                TimeSpan elapsed = (DateTime.Now - _lastKeystroke);
                if (elapsed.TotalMilliseconds > (int)Settings.Default.BarcodeSpeed)
                    _barcode.Clear();


                if (Settings.Default.BarcodeOnlyNumber)
                {
                    if (char.IsNumber((char)eventArgs.KeyData))
                    {
                        _barcode.Add((char)eventArgs.KeyData);
                    }
                }
                else
                {
                    if (char.IsNumber((char)eventArgs.KeyData) || char.IsLetter((char)eventArgs.KeyData))
                    {
                        _barcode.Add((char)eventArgs.KeyData);
                    }
                }

                string barcode = new string(_barcode.ToArray());

                if (eventArgs.m_Key == 13 && _barcode.Count > 0 && barcode.Length >= Settings.Default.BarcodeMinlength)
                {
                    foreach (var item in Settings.Default.QRCodeIgnore)
                    {
                        if (barcode.StartsWith(item))
                            barcode = barcode.Replace(item, string.Empty);
                    }

                    manuelBarcods.Add(barcode);
                    lblManuelBarcode.Text = manuelBarcods.Count.ToString();
                    lblManuelBarcode.Visible = true;
                    Logger.GetInstance().Info("Okunan Perakende Barkodu: " + barcode);
                    _barcode.Clear();


                }

                _lastKeystroke = DateTime.Now;

            }


        }

        private void ManuelBarcodeCleanTimer_Tick(object sender, EventArgs e)
        {
            _barcode.Clear();
            manuelBarcods.Clear();
            lblManuelBarcode.Text = string.Empty;
            lblManuelBarcode.Visible = false;
            // new FormNotification().ShowAlert("Perakende önbellek temizlendi",NotificationType.Info);
        }

        private void ManuelBarcodePostTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (manuelBarcods.Count > 0)
                {
                    Logger.GetInstance().Info("Web Servise gönderilen perakende barkodları" + string.Join("\n", manuelBarcods));
                    RequestBarcode requestBarcode = BL.CreatRetailRequest(manuelBarcods);
                    ResponseBarcode responseBarcode = BL.PostRetailRequest(requestBarcode);
                    responseBarcode.ReceteNo = requestBarcode.HeaderSection.ReceteNo;

                    new FormNotification(responseBarcode).ShowDialog();

                    _barcode.Clear();
                    manuelBarcods.Clear();
                }
            }
            catch (Exception ex)
            {
                _barcode.Clear();
                manuelBarcods.Clear();
                Logger.GetInstance().Error("Perakende işlemine ait barkod işlemi web servisten okunamadı", ex);
                new FormNotification("Perakende işlemine ait barkod işlemi web servisten okunamadı", NotificationType.Error).ShowDialog();
            }


        }

        private void ManuelModeTimer_Tick(object sender, EventArgs e)
        {
            lastRequestBarcode = null;
        }

        private void btnShowPostList_Click(object sender, EventArgs e)
        {
            //new FormPostList().ShowDialog();

            List<string> barcodes = new List<string>(); 
            barcodes.Add("8699522521456");
            barcodes.Add("8699525590435");
            barcodes.Add("8699717010093");
            barcodes.Add("8699580510027");

            RequestBarcode requestBarcode = BL.CreatRetailRequest(barcodes);
            ResponseBarcode responseBarcode = BL.PostRetailRequest(requestBarcode);
            responseBarcode.ReceteNo = requestBarcode.HeaderSection.ReceteNo;

            
            new Thread(() => ShowNotification(responseBarcode,true)).Start();

        }

        private void menuItemOpenSettings_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            formSettings.FormClosed += (x, y) =>
            {
                InitializeWatchDog();
            };

            formSettings.ShowDialog();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = KryptonMessageBox.Show("Farmakode uygulamasından çıkmak istediğinizden emim misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                // new FormNotification("Uygulama kapatıldı", NotificationType.Info).ShowDialog();
                Application.Exit();
            }


        }

        private void menuItemAppStatus_Click(object sender, EventArgs e)
        {
            if (Settings.Default.AppIsEnabled)
            {
                new FormNotification("Uygulama pasif moda geçti", NotificationType.Info).ShowDialog();

                Settings.Default.AppIsEnabled = false;
                menuItemAppStatus.Text = "Uygulamayı AKTİF yap";

                if (watchDog != null)
                    watchDog.Stop();
            }
            else
            {
                new FormNotification("Uygulama aktif moda geçti", NotificationType.Info).ShowDialog();
                Settings.Default.AppIsEnabled = true;
                menuItemAppStatus.Text = "Uygulamayı pasif yap";
                if (watchDog != null)
                    watchDog.Start();
            }


            Settings.Default.Save();
        }


        private void WatchDog_ParseFileEvent(object sender, ParseEventArgs e)
        {
            Logger.GetInstance().Info(e.FilePath + " dosyası okunacak");
            try
            {
                if (File.Exists(e.FilePath))
                {
                    using (FileStream fs = new FileStream(e.FilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            string content = sr.ReadToEnd();
                            if (BL.IsValidHTML(content))
                            {
                                List<ParsedData> parsedData = BL.Parse(content);
                                RequestBarcode requestBarcode = BL.CreateRequestModel(parsedData);



                                lastRequestBarcode = requestBarcode;
                                if (!Settings.Default.IsManuelMode)
                                {
                                    ResponseBarcode responseBarcode = BL.PostRequest(requestBarcode);
                                    if (responseBarcode.Data != null)
                                    {
                                        new Thread(() => ShowNotification(responseBarcode)).Start();
                                    }

                                    else
                                        new FormNotification("Aradığınız ilaç için veriler henüz eklenmedi. En kısa sürede eklenecektir", NotificationType.Warning).ShowDialog();
                                }
                            }
                            else
                            {
                                Logger.GetInstance().Info(e.FilePath + " dosyasının içeriğinde \"" + Settings.Default.IsParseableKeyword + "\" geçemediği için ya da Recete No=0 olduğu için okunamadı");
                            }
                        }
                        fs.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.GetInstance().Error("Dosya okunurken hata oluştu", ex);
                new FormNotification("FarmaKode hata. " + ex.Message, NotificationType.Error).ShowDialog();
            }

        }

        private void FormButton_FormClosing(object sender, FormClosingEventArgs e)
        {
            watchDog = null;
            lastRequestBarcode = null;
            manuelModeTimer = null;
            manuelBarcodePostTimer = null;
            manuelBarcodeCleanTimer = null;
        }

        private void lblManuelBarcode_Click(object sender, EventArgs e)
        {
            new FormManuelBarcode(manuelBarcods).ShowDialog();
        }

        private void ShowNotification(ResponseBarcode responseBarcode, bool isRetail=false)
        {
            FormNotification fn = new FormNotification(responseBarcode, isRetail);
            fn.TopLevel = true;
            fn.TopMost = true;
            fn.ShowDialog();
        }
    }
}
