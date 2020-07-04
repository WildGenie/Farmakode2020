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
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.btnMobil = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
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
            this.lblMsg.Size = new System.Drawing.Size(301, 69);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "Message Text";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoruntule.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoruntule.ForeColor = System.Drawing.Color.White;
            this.btnGoruntule.Location = new System.Drawing.Point(129, 72);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(84, 23);
            this.btnGoruntule.TabIndex = 4;
            this.btnGoruntule.Text = "GÖRÜNTÜLE";
            this.btnGoruntule.UseVisualStyleBackColor = true;
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
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
            // btnEnglish
            // 
            this.btnEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnglish.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEnglish.ForeColor = System.Drawing.Color.White;
            this.btnEnglish.Location = new System.Drawing.Point(328, 72);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(33, 22);
            this.btnEnglish.TabIndex = 7;
            this.btnEnglish.Text = "EN";
            this.btnEnglish.UseVisualStyleBackColor = true;
            this.btnEnglish.Visible = false;
            // 
            // btnMobil
            // 
            this.btnMobil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMobil.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMobil.ForeColor = System.Drawing.Color.White;
            this.btnMobil.Location = new System.Drawing.Point(271, 72);
            this.btnMobil.Name = "btnMobil";
            this.btnMobil.Size = new System.Drawing.Size(51, 22);
            this.btnMobil.TabIndex = 8;
            this.btnMobil.Text = "Mobil";
            this.btnMobil.UseVisualStyleBackColor = true;
            this.btnMobil.Visible = false;
            // 
            // btnYazdir
            // 
            this.btnYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazdir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.ForeColor = System.Drawing.Color.White;
            this.btnYazdir.Location = new System.Drawing.Point(68, 71);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(55, 23);
            this.btnYazdir.TabIndex = 9;
            this.btnYazdir.Text = "YAZDIR";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // FormNotification
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(400, 100);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnMobil);
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnGoruntule);
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
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.Button btnMobil;
        private System.Windows.Forms.Button btnYazdir;
    }
}