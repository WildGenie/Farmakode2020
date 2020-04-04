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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelectSourceFolder = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPharmacyID = new System.Windows.Forms.TextBox();
            this.txtDestinationFolder = new System.Windows.Forms.TextBox();
            this.comboDefaultBarcodePrinter = new System.Windows.Forms.ComboBox();
            this.txtSourceFolder = new System.Windows.Forms.TextBox();
            this.comboNotificationPosition = new System.Windows.Forms.ComboBox();
            this.chkCopyDestinationFolder = new System.Windows.Forms.CheckBox();
            this.spinNotificationCount = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.spinNotificationDuration = new System.Windows.Forms.NumericUpDown();
            this.comboCahce = new System.Windows.Forms.ComboBox();
            this.txtApiURL = new System.Windows.Forms.TextBox();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.comboNotificationBrowser = new System.Windows.Forms.ComboBox();
            this.btnSelectDestinationFolder = new System.Windows.Forms.Button();
            this.chkNotificationEnable = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAppStatus = new System.Windows.Forms.Label();
            this.btnIsAppEnabled = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAdmin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinNotificationCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNotificationDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eczane ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(94, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Uzantı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(89, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kaynak";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(95, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hedef";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Max Bildirim Adeti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Bildirim Tarayıcısı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Bildirim Konumu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Bildirim Bekleme Süresi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(39, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cache Temizleme";
            // 
            // btnSelectSourceFolder
            // 
            this.btnSelectSourceFolder.Location = new System.Drawing.Point(419, 84);
            this.btnSelectSourceFolder.Name = "btnSelectSourceFolder";
            this.btnSelectSourceFolder.Size = new System.Drawing.Size(28, 22);
            this.btnSelectSourceFolder.TabIndex = 2;
            this.btnSelectSourceFolder.Text = "...";
            this.btnSelectSourceFolder.UseVisualStyleBackColor = true;
            this.btnSelectSourceFolder.Click += new System.EventHandler(this.btnSelectSourceFolder_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(447, 466);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(63, 26);
            this.btnHide.TabIndex = 2;
            this.btnHide.Text = "Gizle";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(328, 466);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 26);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Barkod Yazıcısı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPharmacyID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtDestinationFolder);
            this.groupBox1.Controls.Add(this.comboDefaultBarcodePrinter);
            this.groupBox1.Controls.Add(this.txtSourceFolder);
            this.groupBox1.Controls.Add(this.comboNotificationPosition);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.chkCopyDestinationFolder);
            this.groupBox1.Controls.Add(this.spinNotificationCount);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.spinNotificationDuration);
            this.groupBox1.Controls.Add(this.comboCahce);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtApiURL);
            this.groupBox1.Controls.Add(this.txtExtension);
            this.groupBox1.Controls.Add(this.comboNotificationBrowser);
            this.groupBox1.Controls.Add(this.btnSelectSourceFolder);
            this.groupBox1.Controls.Add(this.btnSelectDestinationFolder);
            this.groupBox1.Controls.Add(this.chkNotificationEnable);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::FarmaKode.Client.Properties.Settings.Default, "AppIsEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.Enabled = global::FarmaKode.Client.Properties.Settings.Default.AppIsEnabled;
            this.groupBox1.Location = new System.Drawing.Point(28, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 415);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // txtPharmacyID
            // 
            this.txtPharmacyID.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FarmaKode.Client.Properties.Settings.Default, "PharmacyID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPharmacyID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPharmacyID.Location = new System.Drawing.Point(140, 26);
            this.txtPharmacyID.Name = "txtPharmacyID";
            this.txtPharmacyID.Size = new System.Drawing.Size(128, 22);
            this.txtPharmacyID.TabIndex = 0;
            this.txtPharmacyID.Text = global::FarmaKode.Client.Properties.Settings.Default.PharmacyID;
            // 
            // txtDestinationFolder
            // 
            this.txtDestinationFolder.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::FarmaKode.Client.Properties.Settings.Default, "IsCopyFileToDestination", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDestinationFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FarmaKode.Client.Properties.Settings.Default, "DestinationFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDestinationFolder.Enabled = global::FarmaKode.Client.Properties.Settings.Default.IsCopyFileToDestination;
            this.txtDestinationFolder.Location = new System.Drawing.Point(140, 145);
            this.txtDestinationFolder.Name = "txtDestinationFolder";
            this.txtDestinationFolder.Size = new System.Drawing.Size(273, 22);
            this.txtDestinationFolder.TabIndex = 4;
            this.txtDestinationFolder.Text = global::FarmaKode.Client.Properties.Settings.Default.DestinationFolder;
            // 
            // comboDefaultBarcodePrinter
            // 
            this.comboDefaultBarcodePrinter.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FarmaKode.Client.Properties.Settings.Default, "DefaultBarcodePrinter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboDefaultBarcodePrinter.FormattingEnabled = true;
            this.comboDefaultBarcodePrinter.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3"});
            this.comboDefaultBarcodePrinter.Location = new System.Drawing.Point(140, 346);
            this.comboDefaultBarcodePrinter.Name = "comboDefaultBarcodePrinter";
            this.comboDefaultBarcodePrinter.Size = new System.Drawing.Size(307, 21);
            this.comboDefaultBarcodePrinter.TabIndex = 0;
            this.comboDefaultBarcodePrinter.Text = global::FarmaKode.Client.Properties.Settings.Default.DefaultBarcodePrinter;
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FarmaKode.Client.Properties.Settings.Default, "SourceFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtSourceFolder.Location = new System.Drawing.Point(140, 86);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.Size = new System.Drawing.Size(273, 22);
            this.txtSourceFolder.TabIndex = 1;
            this.txtSourceFolder.Text = global::FarmaKode.Client.Properties.Settings.Default.SourceFolder;
            // 
            // comboNotificationPosition
            // 
            this.comboNotificationPosition.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::FarmaKode.Client.Properties.Settings.Default, "IsEnableNotification", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboNotificationPosition.Enabled = global::FarmaKode.Client.Properties.Settings.Default.IsEnableNotification;
            this.comboNotificationPosition.FormattingEnabled = true;
            this.comboNotificationPosition.Items.AddRange(new object[] {
            "Sağ üst",
            "Sağ alt",
            "Sol alt",
            "Sol üst"});
            this.comboNotificationPosition.Location = new System.Drawing.Point(371, 303);
            this.comboNotificationPosition.Name = "comboNotificationPosition";
            this.comboNotificationPosition.Size = new System.Drawing.Size(76, 21);
            this.comboNotificationPosition.TabIndex = 3;
            this.comboNotificationPosition.SelectedIndexChanged += new System.EventHandler(this.comboNotificationPosition_SelectedIndexChanged);
            // 
            // chkCopyDestinationFolder
            // 
            this.chkCopyDestinationFolder.AutoSize = true;
            this.chkCopyDestinationFolder.Checked = global::FarmaKode.Client.Properties.Settings.Default.IsCopyFileToDestination;
            this.chkCopyDestinationFolder.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::FarmaKode.Client.Properties.Settings.Default, "IsCopyFileToDestination", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkCopyDestinationFolder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkCopyDestinationFolder.Location = new System.Drawing.Point(140, 122);
            this.chkCopyDestinationFolder.Name = "chkCopyDestinationFolder";
            this.chkCopyDestinationFolder.Size = new System.Drawing.Size(190, 17);
            this.chkCopyDestinationFolder.TabIndex = 3;
            this.chkCopyDestinationFolder.Text = "Dosyaları hedef klasöre kopyala";
            this.chkCopyDestinationFolder.UseVisualStyleBackColor = true;
            // 
            // spinNotificationCount
            // 
            this.spinNotificationCount.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::FarmaKode.Client.Properties.Settings.Default, "IsEnableNotification", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.spinNotificationCount.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::FarmaKode.Client.Properties.Settings.Default, "NotificationMaxCount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.spinNotificationCount.Enabled = global::FarmaKode.Client.Properties.Settings.Default.IsEnableNotification;
            this.spinNotificationCount.Location = new System.Drawing.Point(371, 268);
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
            this.spinNotificationCount.Size = new System.Drawing.Size(76, 22);
            this.spinNotificationCount.TabIndex = 4;
            this.spinNotificationCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.spinNotificationCount.Value = global::FarmaKode.Client.Properties.Settings.Default.NotificationMaxCount;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(86, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Api URL";
            // 
            // spinNotificationDuration
            // 
            this.spinNotificationDuration.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::FarmaKode.Client.Properties.Settings.Default, "IsEnableNotification", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.spinNotificationDuration.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::FarmaKode.Client.Properties.Settings.Default, "NotificationDuration", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.spinNotificationDuration.Enabled = global::FarmaKode.Client.Properties.Settings.Default.IsEnableNotification;
            this.spinNotificationDuration.Location = new System.Drawing.Point(140, 268);
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
            this.spinNotificationDuration.Size = new System.Drawing.Size(42, 22);
            this.spinNotificationDuration.TabIndex = 1;
            this.spinNotificationDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.spinNotificationDuration.Value = global::FarmaKode.Client.Properties.Settings.Default.NotificationDuration;
            // 
            // comboCahce
            // 
            this.comboCahce.FormattingEnabled = true;
            this.comboCahce.Items.AddRange(new object[] {
            "Okuma işlemi bittikten sonra sil",
            "Günde 1 kere sil",
            "Silme işlemi yapma"});
            this.comboCahce.Location = new System.Drawing.Point(140, 174);
            this.comboCahce.Name = "comboCahce";
            this.comboCahce.Size = new System.Drawing.Size(307, 21);
            this.comboCahce.TabIndex = 6;
            this.comboCahce.SelectedIndexChanged += new System.EventHandler(this.comboCahce_SelectedIndexChanged);
            // 
            // txtApiURL
            // 
            this.txtApiURL.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FarmaKode.Client.Properties.Settings.Default, "ApiURL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtApiURL.Location = new System.Drawing.Point(140, 201);
            this.txtApiURL.Name = "txtApiURL";
            this.txtApiURL.Size = new System.Drawing.Size(307, 22);
            this.txtApiURL.TabIndex = 0;
            this.txtApiURL.Text = global::FarmaKode.Client.Properties.Settings.Default.ApiURL;
            // 
            // txtExtension
            // 
            this.txtExtension.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FarmaKode.Client.Properties.Settings.Default, "FileExtension", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtExtension.Location = new System.Drawing.Point(140, 58);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(128, 22);
            this.txtExtension.TabIndex = 0;
            this.txtExtension.Text = global::FarmaKode.Client.Properties.Settings.Default.FileExtension;
            // 
            // comboNotificationBrowser
            // 
            this.comboNotificationBrowser.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::FarmaKode.Client.Properties.Settings.Default, "IsEnableNotification", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboNotificationBrowser.Enabled = global::FarmaKode.Client.Properties.Settings.Default.IsEnableNotification;
            this.comboNotificationBrowser.FormattingEnabled = true;
            this.comboNotificationBrowser.Items.AddRange(new object[] {
            "Internet Explorer",
            "Chrome",
            "Firefox",
            "Opera"});
            this.comboNotificationBrowser.Location = new System.Drawing.Point(140, 303);
            this.comboNotificationBrowser.Name = "comboNotificationBrowser";
            this.comboNotificationBrowser.Size = new System.Drawing.Size(120, 21);
            this.comboNotificationBrowser.TabIndex = 2;
            this.comboNotificationBrowser.SelectedIndexChanged += new System.EventHandler(this.comboNotificationBrowser_SelectedIndexChanged);
            // 
            // btnSelectDestinationFolder
            // 
            this.btnSelectDestinationFolder.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::FarmaKode.Client.Properties.Settings.Default, "IsEnableNotification", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnSelectDestinationFolder.Enabled = global::FarmaKode.Client.Properties.Settings.Default.IsEnableNotification;
            this.btnSelectDestinationFolder.Location = new System.Drawing.Point(419, 143);
            this.btnSelectDestinationFolder.Name = "btnSelectDestinationFolder";
            this.btnSelectDestinationFolder.Size = new System.Drawing.Size(28, 22);
            this.btnSelectDestinationFolder.TabIndex = 5;
            this.btnSelectDestinationFolder.Text = "...";
            this.btnSelectDestinationFolder.UseVisualStyleBackColor = true;
            this.btnSelectDestinationFolder.Click += new System.EventHandler(this.btnSelectDestinationFolder_Click);
            // 
            // chkNotificationEnable
            // 
            this.chkNotificationEnable.AutoSize = true;
            this.chkNotificationEnable.Checked = global::FarmaKode.Client.Properties.Settings.Default.IsEnableNotification;
            this.chkNotificationEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNotificationEnable.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::FarmaKode.Client.Properties.Settings.Default, "IsEnableNotification", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkNotificationEnable.Location = new System.Drawing.Point(140, 246);
            this.chkNotificationEnable.Name = "chkNotificationEnable";
            this.chkNotificationEnable.Size = new System.Drawing.Size(225, 17);
            this.chkNotificationEnable.TabIndex = 0;
            this.chkNotificationEnable.Text = "İşlem tamamlandığında bildirim göster";
            this.chkNotificationEnable.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(25, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Uygulama Durumu:";
            // 
            // lblAppStatus
            // 
            this.lblAppStatus.AutoSize = true;
            this.lblAppStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblAppStatus.Location = new System.Drawing.Point(132, 22);
            this.lblAppStatus.Name = "lblAppStatus";
            this.lblAppStatus.Size = new System.Drawing.Size(36, 13);
            this.lblAppStatus.TabIndex = 0;
            this.lblAppStatus.Text = "AKTİF";
            // 
            // btnIsAppEnabled
            // 
            this.btnIsAppEnabled.Location = new System.Drawing.Point(360, 17);
            this.btnIsAppEnabled.Name = "btnIsAppEnabled";
            this.btnIsAppEnabled.Size = new System.Drawing.Size(148, 23);
            this.btnIsAppEnabled.TabIndex = 15;
            this.btnIsAppEnabled.Text = "Uygulamayı Pasif Yap";
            this.btnIsAppEnabled.UseVisualStyleBackColor = true;
            this.btnIsAppEnabled.Click += new System.EventHandler(this.btnIsAppEnabled_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(28, 466);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(91, 26);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 504);
            this.Controls.Add(this.btnIsAppEnabled);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.lblAppStatus);
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSettings_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinNotificationCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNotificationDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.ComboBox comboCahce;
        private System.Windows.Forms.CheckBox chkNotificationEnable;
        private System.Windows.Forms.NumericUpDown spinNotificationDuration;
        private System.Windows.Forms.NumericUpDown spinNotificationCount;
        private System.Windows.Forms.ComboBox comboNotificationBrowser;
        private System.Windows.Forms.ComboBox comboNotificationPosition;
        private System.Windows.Forms.ComboBox comboDefaultBarcodePrinter;
        private System.Windows.Forms.Button btnSelectDestinationFolder;
        private System.Windows.Forms.Button btnSelectSourceFolder;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblAppStatus;
        private System.Windows.Forms.Button btnIsAppEnabled;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnAdmin;
    }
}