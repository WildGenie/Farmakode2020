namespace FarmaKode.Client
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.spinNotificationCount = new System.Windows.Forms.NumericUpDown();
            this.comboNotificationBrowser = new System.Windows.Forms.ComboBox();
            this.comboNotificationPosition = new System.Windows.Forms.ComboBox();
            this.comboDefaultBarcodePrinter = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSelectSourceFolder = new System.Windows.Forms.Button();
            this.btnSelectDestinationFolder = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.chkCopyDestinationFolder = new System.Windows.Forms.CheckBox();
            this.txtSourceFolder = new System.Windows.Forms.TextBox();
            this.txtDestinationFolder = new System.Windows.Forms.TextBox();
            this.txtApiURL = new System.Windows.Forms.TextBox();
            this.spinNotificationDuration = new System.Windows.Forms.NumericUpDown();
            this.chkNotificationEnable = new System.Windows.Forms.CheckBox();
            this.txtPharmacyID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.spinNotificationCount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinNotificationDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eczane ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(61, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Uzantı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(56, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kaynak";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(62, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hedef";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Max Adet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tarayıcı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Konum";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Bekleme Süresi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cache Temizleme";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Okuma işlemi bittikten sonra sil",
            "Günde 1 kere sil",
            "Silme işlemi yapma"});
            this.comboBox1.Location = new System.Drawing.Point(102, 141);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // spinNotificationCount
            // 
            this.spinNotificationCount.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::FarmaKode.Client.Properties.Settings.Default, "NotificationMaxCount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.spinNotificationCount.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::FarmaKode.Client.Properties.Settings.Default, "IsEnableNotification", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.spinNotificationCount.Enabled = global::FarmaKode.Client.Properties.Settings.Default.IsEnableNotification;
            this.spinNotificationCount.Location = new System.Drawing.Point(197, 116);
            this.spinNotificationCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinNotificationCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinNotificationCount.Name = "spinNotificationCount";
            this.spinNotificationCount.Size = new System.Drawing.Size(56, 22);
            this.spinNotificationCount.TabIndex = 4;
            this.spinNotificationCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.spinNotificationCount.Value = global::FarmaKode.Client.Properties.Settings.Default.NotificationMaxCount;
            // 
            // comboNotificationBrowser
            // 
            this.comboNotificationBrowser.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FarmaKode.Client.Properties.Settings.Default, "NotificationBrowser", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboNotificationBrowser.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::FarmaKode.Client.Properties.Settings.Default, "IsEnableNotification", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboNotificationBrowser.Enabled = global::FarmaKode.Client.Properties.Settings.Default.IsEnableNotification;
            this.comboNotificationBrowser.FormattingEnabled = true;
            this.comboNotificationBrowser.Items.AddRange(new object[] {
            "Okuma işlemi bittikten sonra sil",
            "Günde 1 kere sil",
            "Silme işlemi yapma"});
            this.comboNotificationBrowser.Location = new System.Drawing.Point(197, 74);
            this.comboNotificationBrowser.Name = "comboNotificationBrowser";
            this.comboNotificationBrowser.Size = new System.Drawing.Size(120, 21);
            this.comboNotificationBrowser.TabIndex = 2;
            this.comboNotificationBrowser.Text = global::FarmaKode.Client.Properties.Settings.Default.NotificationBrowser;
            this.comboNotificationBrowser.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboNotificationPosition
            // 
            this.comboNotificationPosition.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FarmaKode.Client.Properties.Settings.Default, "NotificationBrowser", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboNotificationPosition.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::FarmaKode.Client.Properties.Settings.Default, "IsEnableNotification", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboNotificationPosition.Enabled = global::FarmaKode.Client.Properties.Settings.Default.IsEnableNotification;
            this.comboNotificationPosition.FormattingEnabled = true;
            this.comboNotificationPosition.Items.AddRange(new object[] {
            "Okuma işlemi bittikten sonra sil",
            "Günde 1 kere sil",
            "Silme işlemi yapma"});
            this.comboNotificationPosition.Location = new System.Drawing.Point(31, 117);
            this.comboNotificationPosition.Name = "comboNotificationPosition";
            this.comboNotificationPosition.Size = new System.Drawing.Size(120, 21);
            this.comboNotificationPosition.TabIndex = 3;
            this.comboNotificationPosition.Text = global::FarmaKode.Client.Properties.Settings.Default.NotificationBrowser;
            this.comboNotificationPosition.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboDefaultBarcodePrinter
            // 
            this.comboDefaultBarcodePrinter.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FarmaKode.Client.Properties.Settings.Default, "DefaultBarcodePrinter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboDefaultBarcodePrinter.FormattingEnabled = true;
            this.comboDefaultBarcodePrinter.Items.AddRange(new object[] {
            "Okuma işlemi bittikten sonra sil",
            "Günde 1 kere sil",
            "Silme işlemi yapma"});
            this.comboDefaultBarcodePrinter.Location = new System.Drawing.Point(27, 25);
            this.comboDefaultBarcodePrinter.Name = "comboDefaultBarcodePrinter";
            this.comboDefaultBarcodePrinter.Size = new System.Drawing.Size(307, 21);
            this.comboDefaultBarcodePrinter.TabIndex = 0;
            this.comboDefaultBarcodePrinter.Text = global::FarmaKode.Client.Properties.Settings.Default.DefaultBarcodePrinter;
            this.comboDefaultBarcodePrinter.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spinNotificationDuration);
            this.groupBox1.Controls.Add(this.spinNotificationCount);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.chkNotificationEnable);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboNotificationPosition);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboNotificationBrowser);
            this.groupBox1.Location = new System.Drawing.Point(20, 358);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 155);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bildirim";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboDefaultBarcodePrinter);
            this.groupBox2.Location = new System.Drawing.Point(20, 519);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 58);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Barkod Yazıcısı";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtApiURL);
            this.groupBox3.Location = new System.Drawing.Point(20, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 53);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Api URL";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSelectDestinationFolder);
            this.groupBox4.Controls.Add(this.btnSelectSourceFolder);
            this.groupBox4.Controls.Add(this.txtExtension);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.chkCopyDestinationFolder);
            this.groupBox4.Controls.Add(this.txtSourceFolder);
            this.groupBox4.Controls.Add(this.txtDestinationFolder);
            this.groupBox4.Location = new System.Drawing.Point(20, 77);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(347, 184);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dosya Okuma";
            // 
            // btnSelectSourceFolder
            // 
            this.btnSelectSourceFolder.Location = new System.Drawing.Point(306, 53);
            this.btnSelectSourceFolder.Name = "btnSelectSourceFolder";
            this.btnSelectSourceFolder.Size = new System.Drawing.Size(28, 22);
            this.btnSelectSourceFolder.TabIndex = 2;
            this.btnSelectSourceFolder.Text = "...";
            this.btnSelectSourceFolder.UseVisualStyleBackColor = true;
            this.btnSelectSourceFolder.Click += new System.EventHandler(this.btnSelectSourceFolder_Click);
            // 
            // btnSelectDestinationFolder
            // 
            this.btnSelectDestinationFolder.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::FarmaKode.Client.Properties.Settings.Default, "IsCopyFileToDestination", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnSelectDestinationFolder.Enabled = global::FarmaKode.Client.Properties.Settings.Default.IsCopyFileToDestination;
            this.btnSelectDestinationFolder.Location = new System.Drawing.Point(306, 112);
            this.btnSelectDestinationFolder.Name = "btnSelectDestinationFolder";
            this.btnSelectDestinationFolder.Size = new System.Drawing.Size(28, 22);
            this.btnSelectDestinationFolder.TabIndex = 5;
            this.btnSelectDestinationFolder.Text = "...";
            this.btnSelectDestinationFolder.UseVisualStyleBackColor = true;
            this.btnSelectDestinationFolder.Click += new System.EventHandler(this.btnSelectDestinationFolder_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(304, 589);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(63, 26);
            this.btnHide.TabIndex = 2;
            this.btnHide.Text = "Gizle";
            this.btnHide.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(207, 589);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 26);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtExtension
            // 
            this.txtExtension.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FarmaKode.Client.Properties.Settings.Default, "FileExtension", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtExtension.Location = new System.Drawing.Point(102, 25);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(69, 22);
            this.txtExtension.TabIndex = 0;
            this.txtExtension.Text = global::FarmaKode.Client.Properties.Settings.Default.FileExtension;
            // 
            // chkCopyDestinationFolder
            // 
            this.chkCopyDestinationFolder.AutoSize = true;
            this.chkCopyDestinationFolder.Checked = global::FarmaKode.Client.Properties.Settings.Default.IsCopyFileToDestination;
            this.chkCopyDestinationFolder.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::FarmaKode.Client.Properties.Settings.Default, "IsCopyFileToDestination", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkCopyDestinationFolder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkCopyDestinationFolder.Location = new System.Drawing.Point(102, 89);
            this.chkCopyDestinationFolder.Name = "chkCopyDestinationFolder";
            this.chkCopyDestinationFolder.Size = new System.Drawing.Size(190, 17);
            this.chkCopyDestinationFolder.TabIndex = 3;
            this.chkCopyDestinationFolder.Text = "Dosyaları hedef klasöre kopyala";
            this.chkCopyDestinationFolder.UseVisualStyleBackColor = true;
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FarmaKode.Client.Properties.Settings.Default, "SourceFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtSourceFolder.Location = new System.Drawing.Point(102, 53);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.Size = new System.Drawing.Size(201, 22);
            this.txtSourceFolder.TabIndex = 1;
            this.txtSourceFolder.Text = global::FarmaKode.Client.Properties.Settings.Default.SourceFolder;
            // 
            // txtDestinationFolder
            // 
            this.txtDestinationFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FarmaKode.Client.Properties.Settings.Default, "DestinationFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDestinationFolder.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::FarmaKode.Client.Properties.Settings.Default, "IsCopyFileToDestination", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDestinationFolder.Enabled = global::FarmaKode.Client.Properties.Settings.Default.IsCopyFileToDestination;
            this.txtDestinationFolder.Location = new System.Drawing.Point(102, 112);
            this.txtDestinationFolder.Name = "txtDestinationFolder";
            this.txtDestinationFolder.Size = new System.Drawing.Size(201, 22);
            this.txtDestinationFolder.TabIndex = 4;
            this.txtDestinationFolder.Text = global::FarmaKode.Client.Properties.Settings.Default.DestinationFolder;
            // 
            // txtApiURL
            // 
            this.txtApiURL.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FarmaKode.Client.Properties.Settings.Default, "ApiURL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtApiURL.Location = new System.Drawing.Point(27, 21);
            this.txtApiURL.Name = "txtApiURL";
            this.txtApiURL.Size = new System.Drawing.Size(307, 22);
            this.txtApiURL.TabIndex = 0;
            this.txtApiURL.Text = global::FarmaKode.Client.Properties.Settings.Default.ApiURL;
            // 
            // spinNotificationDuration
            // 
            this.spinNotificationDuration.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::FarmaKode.Client.Properties.Settings.Default, "NotificationDuration", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.spinNotificationDuration.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::FarmaKode.Client.Properties.Settings.Default, "IsEnableNotification", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.spinNotificationDuration.Enabled = global::FarmaKode.Client.Properties.Settings.Default.IsEnableNotification;
            this.spinNotificationDuration.Location = new System.Drawing.Point(34, 73);
            this.spinNotificationDuration.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinNotificationDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinNotificationDuration.Name = "spinNotificationDuration";
            this.spinNotificationDuration.Size = new System.Drawing.Size(81, 22);
            this.spinNotificationDuration.TabIndex = 1;
            this.spinNotificationDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.spinNotificationDuration.Value = global::FarmaKode.Client.Properties.Settings.Default.NotificationDuration;
            // 
            // chkNotificationEnable
            // 
            this.chkNotificationEnable.AutoSize = true;
            this.chkNotificationEnable.Checked = global::FarmaKode.Client.Properties.Settings.Default.IsEnableNotification;
            this.chkNotificationEnable.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::FarmaKode.Client.Properties.Settings.Default, "IsEnableNotification", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkNotificationEnable.Location = new System.Drawing.Point(29, 25);
            this.chkNotificationEnable.Name = "chkNotificationEnable";
            this.chkNotificationEnable.Size = new System.Drawing.Size(225, 17);
            this.chkNotificationEnable.TabIndex = 0;
            this.chkNotificationEnable.Text = "İşlem tamamlandığında bildirim göster";
            this.chkNotificationEnable.UseVisualStyleBackColor = true;
            // 
            // txtPharmacyID
            // 
            this.txtPharmacyID.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FarmaKode.Client.Properties.Settings.Default, "PharmacyID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPharmacyID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPharmacyID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPharmacyID.Location = new System.Drawing.Point(79, 26);
            this.txtPharmacyID.Multiline = true;
            this.txtPharmacyID.Name = "txtPharmacyID";
            this.txtPharmacyID.Size = new System.Drawing.Size(288, 31);
            this.txtPharmacyID.TabIndex = 0;
            this.txtPharmacyID.Text = global::FarmaKode.Client.Properties.Settings.Default.PharmacyID;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 647);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPharmacyID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximumSize = new System.Drawing.Size(410, 686);
            this.MinimumSize = new System.Drawing.Size(410, 686);
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.spinNotificationCount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinNotificationDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPharmacyID;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.TextBox txtSourceFolder;
        private System.Windows.Forms.TextBox txtDestinationFolder;
        private System.Windows.Forms.TextBox txtApiURL;
        private System.Windows.Forms.CheckBox chkCopyDestinationFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox chkNotificationEnable;
        private System.Windows.Forms.NumericUpDown spinNotificationDuration;
        private System.Windows.Forms.NumericUpDown spinNotificationCount;
        private System.Windows.Forms.ComboBox comboNotificationBrowser;
        private System.Windows.Forms.ComboBox comboNotificationPosition;
        private System.Windows.Forms.ComboBox comboDefaultBarcodePrinter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSelectDestinationFolder;
        private System.Windows.Forms.Button btnSelectSourceFolder;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnSave;
    }
}