using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Runtime.InteropServices;
using System.Net;
using FarmaKode.Client.Properties;
using FarmaKode.Client.Component;
using FarmaKode.Client.Model;
using FarmaKode.Client.Business;
using FarmaKode.Client.Util;

namespace FarmaKode.Client
{
    public partial class FormPostList : Form
    {
        public FormPostList()
        {
           
            InitializeComponent();
            initializeForm();
            locationForm();

        }

        void initializeForm()
        {
            DirectoryInfo di = new DirectoryInfo(Path.Combine(Application.StartupPath, Settings.Default.LatestPostPath));
            List<FileInfo> latestFiles = di.GetFiles("*.json").ToList().OrderByDescending(p => p.CreationTime).ToList();

            PostListItem postListItem = null;
            List<ParsedData> tmpParsedData = null;
            try
            {
                panel1.Controls.Clear();
                int i = 1;
                foreach (var item in latestFiles)
                {
                    tmpParsedData = ParserBL.GetInstance().ParseFromFile(item.FullName);
                    if(tmpParsedData!=null)
                    {
                        postListItem = new PostListItem(i,tmpParsedData);                        
                        postListItem.Dock = DockStyle.Top;
                        postListItem.Name = item.Name;
                        postListItem.Height = 28;
                        //postListItem.Width = 315;
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
                FormButton.notifyIcon.ShowBalloonTip(1000, ",Hata", "Son işlem yapılan reçete dosyaları okunamadı", ToolTipIcon.Error);
                this.Close();
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


    }
}
