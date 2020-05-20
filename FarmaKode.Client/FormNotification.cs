using FarmaKode.Client.Model.Response;
using FarmaKode.Client.Properties;
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

        public FormNotification()
        {
            InitializeComponent();

            btnEnglish.Visible = false;
            btnMobil.Visible = false;
        }

        public FormNotification(ResponseBarcode responseBarcode)
        {
            InitializeComponent();

            btnEnglish.Visible = responseBarcode.Data.Supported_multi_lang;
            btnMobil.Visible = responseBarcode.Data.Has_mobile_app;


            TopMost = true;
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                FormNotification frm = (FormNotification)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;

                }

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            string messsage = string.Format("{0} reçetesi hazır", responseBarcode.Data.Patient_name);
            this.pictureBox1.Image = Resources.success;
            this.BackColor = Color.SeaGreen;
            this.lblMsg.Text = messsage;
            this.action = NotificationAction.start;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case NotificationAction.wait:
                    timer1.Interval = 5000;
                    action = NotificationAction.close;
                    break;
                case NotificationAction.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = NotificationAction.wait;
                        }
                    }
                    break;
                case NotificationAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
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

        private void btnBarkod_Click(object sender, EventArgs e)
        {

        }

        public void ShowAlert(string msg, NotificationType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;
            TopMost = true;
            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                FormNotification frm = (FormNotification)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;

                }

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case NotificationType.Success:
                    this.pictureBox1.Image = Resources.success;
                    this.BackColor = Color.SeaGreen;
                    break;
                case NotificationType.Error:
                    this.pictureBox1.Image = Resources.error;
                    this.BackColor = Color.DarkRed;
                    break;
                case NotificationType.Info:
                    this.pictureBox1.Image = Resources.info;
                    this.BackColor = Color.RoyalBlue;
                    break;
                case NotificationType.Warning:
                    this.pictureBox1.Image = Resources.warning;
                    this.BackColor = Color.DarkOrange;
                    break;
            }


            this.lblMsg.Text = msg;

            this.Show();
            this.action = NotificationAction.start;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }

    }
}
