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
        bool isChanged = false;
        public FormSettings()
        {
            InitializeComponent();
            Settings.Default.SettingChanging += Default_SettingChanging;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
            isChanged = false;
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

        private void Default_SettingChanging(object sender, System.Configuration.SettingChangingEventArgs e)
        {
            isChanged = true;
        }
    }
}
