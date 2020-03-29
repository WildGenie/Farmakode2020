namespace FarmaKode.Client
{
    partial class FormButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormButton));
            this.btnShowPostList = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemOpenSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAppStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemCache = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemCheckUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowPostList
            // 
            this.btnShowPostList.BackgroundImage = global::FarmaKode.Client.Properties.Resources.logo;
            this.btnShowPostList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowPostList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowPostList.Location = new System.Drawing.Point(0, 0);
            this.btnShowPostList.Name = "btnShowPostList";
            this.btnShowPostList.Size = new System.Drawing.Size(50, 50);
            this.btnShowPostList.TabIndex = 0;
            this.btnShowPostList.UseVisualStyleBackColor = true;
            this.btnShowPostList.Click += new System.EventHandler(this.btnShowPostList_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "FarmaKode";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOpenSettings,
            this.menuItemAppStatus,
            this.toolStripSeparator3,
            this.menuItemCache,
            this.toolStripSeparator2,
            this.menuItemCheckUpdate,
            this.toolStripSeparator1,
            this.menuItemExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(205, 154);
            this.contextMenuStrip1.Text = "Arayüzü Aç";
            // 
            // menuItemOpenSettings
            // 
            this.menuItemOpenSettings.Name = "menuItemOpenSettings";
            this.menuItemOpenSettings.Size = new System.Drawing.Size(204, 22);
            this.menuItemOpenSettings.Text = "Arayüzü Aç";
            this.menuItemOpenSettings.Click += new System.EventHandler(this.menuItemOpenSettings_Click);
            // 
            // menuItemAppStatus
            // 
            this.menuItemAppStatus.Name = "menuItemAppStatus";
            this.menuItemAppStatus.Size = new System.Drawing.Size(204, 22);
            this.menuItemAppStatus.Text = "Uygulamayı Pasif Yap";
            this.menuItemAppStatus.Click += new System.EventHandler(this.menuItemAppStatus_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(201, 6);
            // 
            // menuItemCache
            // 
            this.menuItemCache.Name = "menuItemCache";
            this.menuItemCache.Size = new System.Drawing.Size(204, 22);
            this.menuItemCache.Text = "Perakende Önbellek";
            this.menuItemCache.Click += new System.EventHandler(this.menuItemCache_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(201, 6);
            // 
            // menuItemCheckUpdate
            // 
            this.menuItemCheckUpdate.Name = "menuItemCheckUpdate";
            this.menuItemCheckUpdate.Size = new System.Drawing.Size(204, 22);
            this.menuItemCheckUpdate.Text = "Güncellemeleri Kontol Et";
            this.menuItemCheckUpdate.Click += new System.EventHandler(this.menuItemCheckUpdate_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(204, 22);
            this.menuItemExit.Text = "Çıkış";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // FormButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(50, 50);
            this.Controls.Add(this.btnShowPostList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormButton";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormButton";
            this.Load += new System.EventHandler(this.FormButton_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button btnShowPostList;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpenSettings;
        private System.Windows.Forms.ToolStripMenuItem menuItemAppStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuItemCache;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuItemCheckUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
    }
}