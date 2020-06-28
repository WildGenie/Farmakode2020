using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Printing;
using System.Windows.Forms;
using FarmaKode.Client.Business;
using FarmaKode.Client.Properties;
using FarmaKode.Client.Util;

namespace FarmaKode.Client
{
    public partial class FormSettings : Form
    {
        public bool isChanged = false;

        public FormSettings()
        {
            InitializeComponent();
            Settings.Default.SettingChanging += Default_SettingChanging;

            if (!Settings.Default.AppIsEnabled)
            {
                btnIsAppEnabled.Text = "Uygulamayı AKTİF yap";
                lblAppStatus.Text = "PASİF";
                lblAppStatus.ForeColor = Color.Red;
            }
            else
            {
                btnIsAppEnabled.Text = "Uygulamayı PASİF yap";
                lblAppStatus.Text = "AKTİF";
                lblAppStatus.ForeColor = Color.Green;
            }

            if (string.IsNullOrEmpty(Settings.Default.SourceFolder))
            {
                Settings.Default.SourceFolder = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
                Settings.Default.Save();
            }

            if (string.IsNullOrEmpty(Settings.Default.DestinationFolder))
            {
                Settings.Default.DestinationFolder = Path.Combine(Application.StartupPath, Settings.Default.LatestPostPath);
                if (!Directory.Exists(Settings.Default.DestinationFolder))
                    Directory.CreateDirectory(Settings.Default.DestinationFolder); 
                Settings.Default.Save();
            }

            comboCahce.SelectedIndex = Settings.Default.ClearCacheType;
            comboNotificationPosition.SelectedIndex = Settings.Default.NotificationPosition;


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

            var values = Enum.GetValues(typeof(Keys));
            foreach (var item in values)
            {
                comboManuelKey.Items.Add(item.ToString());
            }

        }


        bool validation()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(txtPharmacyID.Text.Trim()))
            {
                errorProvider1.SetError(txtPharmacyID, "Bu alan boş geçilemez");
                isValid = false;
            }


            if (string.IsNullOrEmpty(txtExtension.Text.Trim()))
            {
                errorProvider1.SetError(txtExtension, "Bu alan boş geçilemez");
                isValid = false;
            }


            if (string.IsNullOrEmpty(txtSourceFolder.Text.Trim()))
            {
                errorProvider1.SetError(txtSourceFolder, "Bu alan boş geçilemez");
                isValid = false;
            }



            return isValid;


        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                Settings.Default.Save();
                isChanged = false;
                MessageBox.Show("Ayarlar kayıt edilmiştir. Uygulama yeniden başlatılacaktır", "Farmakode", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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

        private void btnSelectDestinationFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.RootFolder = Environment.SpecialFolder.DesktopDirectory;
            folder.ShowDialog();
            txtDestinationFolder.Text = folder.SelectedPath;
        }

        private void Default_SettingChanging(object sender, System.Configuration.SettingChangingEventArgs e)
        {
            object oldValue = Settings.Default[e.SettingName];
            if (!e.NewValue.Equals(oldValue))
                isChanged = true;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                this.Close();
            }
        }

        private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (validation())
            {
                if (isChanged)
                {
                    DialogResult r = MessageBox.Show("Değişiklik var", "Uyarı", MessageBoxButtons.YesNo);
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
                MessageBox.Show("Gerekli alanlar girilmediği için uygulama çalışmayacaktır", "Uyarı");
                Application.Exit();
                //e.Cancel = true;
            }
        }

        private void FormSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            //FormButton.notifyIcon.ShowBalloonTip(1000, "FarmaKode", "Uygulama çalışıyor", ToolTipIcon.Info);
        }

        private void btnIsAppEnabled_Click(object sender, EventArgs e)
        {
            if (Settings.Default.AppIsEnabled)
            {
                btnIsAppEnabled.Text = "Uygulamayı AKTİF yap";
                Settings.Default.AppIsEnabled = false;
                lblAppStatus.Text = "PASİF";
                lblAppStatus.ForeColor = Color.Red;
            }
            else
            {
                btnIsAppEnabled.Text = "Uygulamayı PASİF yap";
                Settings.Default.AppIsEnabled = true;
                lblAppStatus.Text = "AKTİF";
                lblAppStatus.ForeColor = Color.Green;
            }
        }

        private void comboCahce_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.ClearCacheType = comboCahce.SelectedIndex;
        }

        private void comboNotificationPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.NotificationPosition = comboNotificationPosition.SelectedIndex;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            new FormParameter().ShowDialog();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            this.Text = "Ayarlar | " + CacheBL.IPAddress;
        }

        private void comboDefaultBarcodePrinter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboDefaultBarcodePrinter.SelectedIndex > -1)
                Settings.Default.DefaultBarcodePrinter = comboDefaultBarcodePrinter.SelectedItem.ToString();
        }

        private void chkCopyDestinationFolder_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
