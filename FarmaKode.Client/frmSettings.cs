using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FarmaKode.Client.Properties;

namespace FarmaKode.Client
{
    public partial class frmSettings : DevExpress.XtraEditors.XtraForm
    {
        bool isChanged = false;
        string keyLastChangedProperty = string.Empty;
        public frmSettings()
        {
            InitializeComponent();
            Settings.Default.SettingChanging += Default_SettingChanging;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
            isChanged = false;
        }

        private void txtSourceFolder_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.RootFolder = Environment.SpecialFolder.DesktopDirectory;
            folder.ShowDialog();
            txtSourceFolder.Text = folder.SelectedPath;
        }

        private void txtDestinationFolder_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.RootFolder = Environment.SpecialFolder.DesktopDirectory;
            folder.ShowDialog();
            txtDestinationFolder.Text = folder.SelectedPath;
        }

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Default_SettingChanging(object sender, System.Configuration.SettingChangingEventArgs e)
        {           
            isChanged = true;
        }
    }
}