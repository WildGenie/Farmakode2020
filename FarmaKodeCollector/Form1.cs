using FarmaKodeCollector.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Diagnostics;
using log4net;

namespace FarmaKodeCollector
{
    public partial class Form1 : Form
    {
        ILog log = log4net.LogManager.GetLogger(typeof(Form1));
        List<MyWatchDog> myDogList = null;

        public Form1()
        {
           
            InitializeComponent();
            log4net.Config.BasicConfigurator.Configure();
            log.Info("Uygulama açıldı");
            ayarlariYukle();

        }
        void ayarlariYukle()
        {
            listKaynakKlasor.Items.Clear();
            if(Settings.Default.FolderList!=null)
            foreach (string item in Settings.Default.FolderList)
                listKaynakKlasor.Items.Add(item);
        }
        void kaydet()
        {
            Settings.Default.FolderList = new System.Collections.Specialized.StringCollection();
            foreach (string item in listKaynakKlasor.Items)
                Settings.Default.FolderList.Add(item);

            Settings.Default.FileExtension = txtUzanti.Text;
            Settings.Default.DestinationPath = txtHedefKlasor.Text;

            Settings.Default.Save();
        }
        private void btnKlasorEkle_Click(object sender, EventArgs e)
        {
            string path = txtKlasor.Text.Trim();
            if (listKaynakKlasor.Items.IndexOf(path) == -1)
            {
                listKaynakKlasor.Items.Add(path);
                kaydet();
            }

            else
                MessageBox.Show("Uyarı", "Seçilen klasör listede bulunmaktadır");

        }

        private void btnKaynakKlasorSec_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.RootFolder = Environment.SpecialFolder.DesktopDirectory;
            folder.ShowDialog();
            string path = folder.SelectedPath;
            if (listKaynakKlasor.Items.IndexOf(path) == -1)
            {
                listKaynakKlasor.Items.Add(path);
                kaydet();
            }
            else
                MessageBox.Show("Uyarı", "Seçilen klasör listede bulunmaktadır");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }

        private void btnKlasorSil_Click(object sender, EventArgs e)
        {
            if (listKaynakKlasor.SelectedIndex > -1)
            {
                listKaynakKlasor.Items.RemoveAt(listKaynakKlasor.SelectedIndex);
                kaydet();
            }
        }

        private void btnHedefKlasorSec_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.RootFolder = Environment.SpecialFolder.DesktopDirectory;
            folder.ShowDialog();
            txtHedefKlasor.Text = folder.SelectedPath;
            kaydet();
        }

        private void btnHedefKlasorAc_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHedefKlasor.Text))
                Process.Start("explorer.exe", txtHedefKlasor.Text);

        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            if (myDogList == null)
            {
                myDogList = new List<MyWatchDog>();
                MyWatchDog dog = null;
                foreach (string item in listKaynakKlasor.Items)
                {
                    dog = new MyWatchDog(item, txtHedefKlasor.Text, txtUzanti.Text);                   
                    myDogList.Add(dog);
                }
            }

            myDogList.ForEach(p => p.baslat());

        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            if (myDogList == null)
            {
                myDogList.ForEach(p => p.durdur());
            }
        }
    }
}
