using FarmaKode.Client.Business;
using FarmaKode.Client.Model;
using FarmaKode.Client.Properties;
using FarmaKode.Client.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaKode.Client
{
    public partial class FormButton : Form
    {

        #region SCREEN TOP
        static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
        static readonly IntPtr HWND_TOP = new IntPtr(0);
        static readonly IntPtr HWND_BOTTOM = new IntPtr(1);
        const UInt32 SWP_NOSIZE = 0x0001;
        const UInt32 SWP_NOMOVE = 0x0002;
        const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        #endregion


        #region VARIABLES

        public static NotifyIcon notifyIcon;
        public WatchDogBL watchDog = null;

        #endregion

        public FormButton()

        {
            InitializeComponent();

            notifyIcon = notifyIcon1;

            initializeWatchDog();

        }

        void initializeWatchDog()
        {
            watchDog = new WatchDogBL(Settings.Default.SourceFolder,
               Settings.Default.DestinationFolder,
               Settings.Default.FileExtension,
               Settings.Default.IsCopyFileToDestination);
            watchDog.ParseFileEvent += WatchDog_ParseFileEvent;

            if (!Settings.Default.AppIsEnabled)
            {
                menuItemAppStatus.Text = "Uygulamayı AKTİF yap";
                notifyIcon.ShowBalloonTip(1000, "FarmaKode", "Uygulama pasif modda başladı" +
                    "", ToolTipIcon.Info);

            }
            else
            {
                menuItemAppStatus.Text = "Uygulamayı pasif yap";
                notifyIcon.ShowBalloonTip(1000, "FarmaKode", "Uygulama aktif modda başladı", ToolTipIcon.Info);
                watchDog.Start();
            }
        }


        private void FormButton_Load(object sender, EventArgs e)
        {
            this.Size = new Size(50, 50);

            foreach (var scrn in Screen.AllScreens)
            {
                if (scrn.Bounds.Contains(this.Location))
                {
                    this.Location = new Point(scrn.Bounds.Right - 60, scrn.Bounds.Height - this.Height - 350);
                    SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
                    return;
                }
            }


        }

        private void btnShowPostList_Click(object sender, EventArgs e)
        {
            new FormPostList().ShowDialog();
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Control.MousePosition);


        }

        private void menuItemOpenSettings_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            formSettings.FormClosed += (x, y) =>
            {
                initializeWatchDog();
            };

            formSettings.ShowDialog();
        }

        private void menuItemCache_Click(object sender, EventArgs e)
        {

        }

        private void menuItemCheckUpdate_Click(object sender, EventArgs e)
        {

        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Farmakode uygulamasından çıkmak istediğinizden emim misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                notifyIcon.ShowBalloonTip(1000, "FarmaKode", "Uygulama Kapatıldı", ToolTipIcon.Info);
                Application.Exit();
            }


        }

        private void menuItemAppStatus_Click(object sender, EventArgs e)
        {
            if (Settings.Default.AppIsEnabled)
            {
                notifyIcon.ShowBalloonTip(1000, "FarmaKode", "Uygulama pasif edildi", ToolTipIcon.Info);
                Settings.Default.AppIsEnabled = false;
                menuItemAppStatus.Text = "Uygulamayı AKTİF yap";

                if (watchDog != null)
                    watchDog.Stop();
            }
            else
            {
                notifyIcon.ShowBalloonTip(1000, "FarmaKode", "Uygulama aktif edildi", ToolTipIcon.Info);
                Settings.Default.AppIsEnabled = true;
                menuItemAppStatus.Text = "Uygulamayı pasif yap";
                if (watchDog != null)
                    watchDog.Start();
            }


            Settings.Default.Save();
        }


        private void WatchDog_ParseFileEvent(object sender, ParseEventArgs e)
        {
            try
            {
                string content = File.ReadAllText(e.FilePath, Encoding.Default);

                if (content.Contains(Settings.Default.IsParseableKeyword))
                {
                    List<ParsedData> parsedData = ParserBL.GetInstance().Parse(content);

                    string latestPostFolder = Path.Combine(Application.StartupPath, Settings.Default.LatestPostPath);
                    ParserBL.GetInstance().SavePost(latestPostFolder, parsedData);

                    notifyIcon.ShowBalloonTip(1000, "FarmaKode Reçete", "Reçete hazır", ToolTipIcon.Info);

                    if (Settings.Default.ClearCacheType == Constants.ClearCahceType.AfterParse)
                    {
                        File.Delete(e.FilePath);
                    }
                }

            }
            catch (Exception ex)
            {

                notifyIcon.ShowBalloonTip(1000, "FarmaKode Hata", ex.Message, ToolTipIcon.Error);
            }

        }




    }
}
