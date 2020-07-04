using FarmaKode.Client.Model.Response;
using FarmaKode.Client.Properties;
using FarmaKode.Client.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FarmaKode.Client.Util.Constants;

namespace FarmaKode.Client
{


    public partial class FormNotification : Form
    {
        private NotificationAction action;
        private int x, y;
        ResponseBarcode selectedResponseBarcode;

        public FormNotification()
        {
            InitializeComponent();

            btnEnglish.Visible = false;
            btnMobil.Visible = false;
            btnGoruntule.Visible = false;
        }

        public FormNotification(ResponseBarcode responseBarcode)
        {
            InitializeComponent();
            btnGoruntule.Visible = true;
            btnEnglish.Visible = responseBarcode.Data.Supported_multi_lang || false;
            btnMobil.Visible = responseBarcode.Data.Has_mobile_app || false;

            selectedResponseBarcode = responseBarcode;

            TopMost = true;
            Opacity = 0.0;
            StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                FormNotification frm = (FormNotification)Application.OpenForms[fname];

                if (frm == null)
                {
                    Name = fname;
                    x = Screen.PrimaryScreen.WorkingArea.Width - Width + 15;
                    y = Screen.PrimaryScreen.WorkingArea.Height - Height * i - 5 * i;
                    Location = new Point(x, y);
                    break;

                }

            }
            x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;




            string messsage = string.Format("{0} reçetesi hazır", responseBarcode.Data.Patient_name);
            pictureBox1.Image = Resources.success;
            BackColor = Color.SeaGreen;
            lblMsg.Text = messsage;
            action = NotificationAction.start;
            timer1.Interval = 1;
            timer1.Start();
        }

        public FormNotification(string messsage, NotificationType type)
        {
            InitializeComponent();
            btnGoruntule.Visible = false;
            btnEnglish.Visible = false;
            btnMobil.Visible = false;


            TopMost = true;
            Opacity = 0.0;
            StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                FormNotification frm = (FormNotification)Application.OpenForms[fname];

                if (frm == null)
                {
                    Name = fname;
                    x = Screen.PrimaryScreen.WorkingArea.Width - Width + 15;
                    y = Screen.PrimaryScreen.WorkingArea.Height - Height * i - 5 * i;
                    Location = new Point(x, y);
                    break;

                }

            }
            x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;


            switch (type)
            {
                case NotificationType.Success:
                    pictureBox1.Image = Resources.success;
                    BackColor = Color.SeaGreen;
                    break;
                case NotificationType.Error:
                    pictureBox1.Image = Resources.error;
                    BackColor = Color.DarkRed;
                    break;
                case NotificationType.Info:
                    pictureBox1.Image = Resources.info;
                    BackColor = Color.RoyalBlue;
                    break;
                case NotificationType.Warning:
                    pictureBox1.Image = Resources.warning;
                    BackColor = Color.DarkOrange;
                    break;
            }



            lblMsg.Text = messsage;
            action = NotificationAction.start;
            timer1.Interval = 1;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (action)
            {
                case NotificationAction.wait:
                    timer1.Interval = 5000;
                    action = NotificationAction.close;
                    break;
                case NotificationAction.start:
                    timer1.Interval = 1;
                    Opacity += 0.1;
                    if (x < Location.X)
                    {
                        Left--;
                    }
                    else
                    {
                        if (Opacity == 1.0)
                        {
                            action = NotificationAction.wait;
                        }
                    }
                    break;
                case NotificationAction.close:
                    timer1.Interval = 1;
                    Opacity -= 0.1;

                    Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = NotificationAction.close;
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            new FormPostList(selectedResponseBarcode).ShowDialog();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
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

         

        //public void ShowAlert(string msg, NotificationType type)
        //{
        //    Opacity = 0.0;
        //    StartPosition = FormStartPosition.Manual;
        //    string fname;
        //    TopMost = true;
        //    for (int i = 1; i < 10; i++)
        //    {
        //        fname = "alert" + i.ToString();
        //        FormNotification frm = (FormNotification)Application.OpenForms[fname];

        //        if (frm == null)
        //        {
        //            Name = fname;
        //            x = Screen.PrimaryScreen.WorkingArea.Width - Width + 15;
        //            y = Screen.PrimaryScreen.WorkingArea.Height - Height * i - 5 * i;
        //            Location = new Point(x, y);
        //            break;

        //        }

        //    }
        //    x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

        //    switch (type)
        //    {
        //        case NotificationType.Success:
        //            pictureBox1.Image = Resources.success;
        //            BackColor = Color.SeaGreen;
        //            break;
        //        case NotificationType.Error:
        //            pictureBox1.Image = Resources.error;
        //            BackColor = Color.DarkRed;
        //            break;
        //        case NotificationType.Info:
        //            pictureBox1.Image = Resources.info;
        //            BackColor = Color.RoyalBlue;
        //            break;
        //        case NotificationType.Warning:
        //            pictureBox1.Image = Resources.warning;
        //            BackColor = Color.DarkOrange;
        //            break;
        //    }


        //    lblMsg.Text = msg;

        //    Show();
        //    action = NotificationAction.start;
        //    timer1.Interval = 1;
        //    timer1.Start();
        //}

    }
}
