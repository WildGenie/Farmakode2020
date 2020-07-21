namespace FarmaKode.Client
{
    partial class FormNotification
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMsg = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGoruntule = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnYazdir = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPaletteOffice2010Black = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btnMobil = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEnglish = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoEllipsis = true;
            this.lblMsg.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMsg.ForeColor = System.Drawing.Color.White;
            this.lblMsg.Location = new System.Drawing.Point(62, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(301, 63);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "Message Text";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::FarmaKode.Client.Properties.Resources.icons8_cancel_25px;
            this.pictureBox2.Location = new System.Drawing.Point(363, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::FarmaKode.Client.Properties.Resources.success;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.Location = new System.Drawing.Point(144, 66);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btnGoruntule.Size = new System.Drawing.Size(99, 32);
            this.btnGoruntule.TabIndex = 10;
            this.btnGoruntule.Values.Text = "GÖRÜNTÜLE";
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(66, 66);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btnYazdir.Size = new System.Drawing.Size(72, 32);
            this.btnYazdir.TabIndex = 11;
            this.btnYazdir.Values.Text = "YAZDIR";
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // kryptonPaletteOffice2010Black
            // 
            this.kryptonPaletteOffice2010Black.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            // 
            // btnMobil
            // 
            this.btnMobil.Location = new System.Drawing.Point(322, 66);
            this.btnMobil.Name = "btnMobil";
            this.btnMobil.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btnMobil.Size = new System.Drawing.Size(41, 32);
            this.btnMobil.TabIndex = 12;
            this.btnMobil.Values.Image = global::FarmaKode.Client.Properties.Resources.phone1;
            this.btnMobil.Values.Text = "";
            // 
            // btnEnglish
            // 
            this.btnEnglish.Location = new System.Drawing.Point(278, 66);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btnEnglish.Size = new System.Drawing.Size(41, 32);
            this.btnEnglish.TabIndex = 13;
            this.btnEnglish.Values.Image = global::FarmaKode.Client.Properties.Resources.flag_usa1;
            this.btnEnglish.Values.Text = "";
            // 
            // FormNotification
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(400, 100);
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.btnMobil);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnGoruntule);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNotification";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormNotification";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnGoruntule;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnYazdir;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPaletteOffice2010Black;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnMobil;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEnglish;
    }
}