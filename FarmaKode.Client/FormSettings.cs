using ComponentFactory.Krypton.Toolkit;
using FarmaKode.Client.Business;
using FarmaKode.Client.Properties;
using FarmaKode.Client.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaKode.Client
{
    public partial class FormSettings : KryptonForm
    {
        public bool isChanged = false;

        public FormSettings()
        {
            InitializeComponent();

            Settings.Default.SettingChanging += Default_SettingChanging;

            
            


            #region Uygulama Durumu
            if (!Settings.Default.AppIsEnabled)
            {
                btnIsAppEnabled.Text = "AKTİF yap";
                lblAppStatus.Text = "Uygulama PASİF";
                pictureBoxAppStatus.Image = Resources.delete;
            }
            else
            {
                btnIsAppEnabled.Text = "PASİF yap";
                lblAppStatus.Text = "Uygulama AKTİF";
                pictureBoxAppStatus.Image = Resources.accept;
            }
            #endregion

            #region Kaynak ve Hedef Klasör Ayarları
            if (string.IsNullOrEmpty(Settings.Default.SourceFolder))
            {
                Settings.Default.SourceFolder = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
                Settings.Default.Save();
            }

            if (string.IsNullOrEmpty(Settings.Default.DestinationFolder))
            {
                Settings.Default.DestinationFolder = Path.Combine(@"C:\Program Files\Farmakode", Settings.Default.LatestPostFolderName);
                CacheBL.CheckSettings();
                Settings.Default.Save();
            }
            #endregion

            #region Yazıcı ayarları
            System.Drawing.Printing.PrinterSettings.StringCollection printerList = System.Drawing.Printing.PrinterSettings.InstalledPrinters;
            List<string> _printerList = new List<string>();

            foreach (string printer in printerList)
            {
                _printerList.Add(printer);
                comboDefaultBarcodePrinter.Items.Add(printer);
            }

            if (!_printerList.Contains(Settings.Default.DefaultBarcodePrinter))
            {
                comboDefaultBarcodePrinter.SelectedItem = LocalPrintServer.GetDefaultPrintQueue().FullName;
            }
            #endregion


            comboPCNO.Items.Clear();
            foreach (var item in Common.GetPcNumberList())            
                comboPCNO.Items.Add(item);             

            if(!string.IsNullOrEmpty( Settings.Default.PharmacyPCNO))
            {
                comboPCNO.SelectedItem = Settings.Default.PharmacyPCNO;
            }

            this.Text = "Ayarlar | " + CacheBL.IPAddress;

            comboNotificationPosition.SelectedIndex = Settings.Default.NotificationPosition;


        }

        private void Default_SettingChanging(object sender, System.Configuration.SettingChangingEventArgs e)
        {
            object oldValue = Settings.Default[e.SettingName];
            if (!e.NewValue.Equals(oldValue))
                isChanged = true;
        }
        
        bool validation()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(txtPharmacyID.Text.Trim()))
            {
                errorProvider1.SetError(txtPharmacyID, "Bu alan boş geçilemez");                
                txtPharmacyID.Focus();
            }

            //if (string.IsNullOrEmpty(txtExtension.Text.Trim()))
            //{
            //    errorProvider1.SetError(txtExtension, "Bu alan boş geçilemez");
            //    isValid = false;
            //}


            if (string.IsNullOrEmpty(txtSourceFolder.Text.Trim()))
            {
                errorProvider1.SetError(txtSourceFolder, "Bu alan boş geçilemez");
                isValid = false;
                txtSourceFolder.Focus();
            }



            return isValid;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                Settings.Default.Save();
                isChanged = false;
                KryptonMessageBox.Show("Ayarlar kayıt edilmiştir. Uygulama yeniden başlatılacaktır", "Farmakode", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                errorProvider1.Clear();

                Application.Exit();
                Process.Start(Application.ExecutablePath, "/restart" + Process.GetCurrentProcess().Id);
               
            }

        }
        
        private void btnSelectSourceFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (string.IsNullOrEmpty(txtSourceFolder.Text))
                folder.RootFolder = Environment.SpecialFolder.DesktopDirectory;
            else
                folder.SelectedPath = txtSourceFolder.Text;

            folder.ShowDialog();
            txtSourceFolder.Text = folder.SelectedPath;
        }

        private void btnOpenSourceFolder_Click(object sender, EventArgs e)
        {
            Process.Start(txtSourceFolder.Text);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                this.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (validation())
            {
                if (isChanged)
                {
                    DialogResult r = KryptonMessageBox.Show("Değişiklik var. Değişiklikleri kayıt etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
                    if (r == DialogResult.No)
                    {
                        Settings.Default.Reload();
                    }
                    else
                    {
                        Settings.Default.Save();
                    }
                }
                else
                {
                    Settings.Default.Save();
                }
            }
            else
            {
                KryptonMessageBox.Show("Gerekli alanlar girilmediği için uygulama çalışmayacaktır", "Uyarı");
                //Application.Exit();
                //e.Cancel = true;
            }
        }

        private void btnIsAppEnabled_Click(object sender, EventArgs e)
        {
            if (Settings.Default.AppIsEnabled)
            {
                btnIsAppEnabled.Text = "AKTİF yap";
                Settings.Default.AppIsEnabled = false;
                lblAppStatus.Text = "Uygulama PASİF";
                pictureBoxAppStatus.Image = Resources.delete;
            }
            else
            {
                btnIsAppEnabled.Text = "PASİF yap";
                Settings.Default.AppIsEnabled = true;
                lblAppStatus.Text = "Uygulama AKTİF";
                pictureBoxAppStatus.Image = Resources.accept;
            }
        }

        private void btnOpenEReceteParameterScreen_Click(object sender, EventArgs e)
        {
            new FormParameter().ShowDialog();
        }

        private void comboPCNO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.PharmacyPCNO = comboPCNO.SelectedItem != null ? comboPCNO.SelectedItem.ToString() : "# BOŞ #";
        }

        private void comboDefaultBarcodePrinter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboDefaultBarcodePrinter.SelectedIndex > -1)
                    Settings.Default.DefaultBarcodePrinter = comboDefaultBarcodePrinter.SelectedText.ToString();
             
        }

        private void comboNotificationPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.NotificationPosition = comboNotificationPosition.SelectedIndex;
        }
    }
}
