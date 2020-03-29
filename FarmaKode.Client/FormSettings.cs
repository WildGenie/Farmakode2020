using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmaKode.Client.Properties;

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

            if(string.IsNullOrEmpty(Settings.Default.SourceFolder))
            {
                Settings.Default.SourceFolder = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
                Settings.Default.Save();
            }

            comboCahce.SelectedIndex = Settings.Default.ClearCacheType;
            comboNotificationBrowser.SelectedIndex= Settings.Default.NotificationBrowser;
            comboNotificationPosition.SelectedIndex= Settings.Default.NotificationPosition;
        }

 
        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
            isChanged = false;
            MessageBox.Show("Ayarlar kayıt edilmiştir", "Farmakode", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

        }

        private void btnSelectSourceFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.RootFolder = Environment.SpecialFolder.DesktopDirectory;
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
            this.Close();
        }

        private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FormSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormButton.notifyIcon.ShowBalloonTip(1000, "FarmaKode", "Uygulama çalışıyor", ToolTipIcon.Info);
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

        private void comboNotificationBrowser_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.NotificationBrowser = comboNotificationBrowser.SelectedIndex;
        }

        private void comboNotificationPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.NotificationPosition = comboNotificationPosition.SelectedIndex;
        }
    }
}
