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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemOpenSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAppStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblManuelBarcode = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowPostList
            // 
            this.btnShowPostList.BackgroundImage = global::FarmaKode.Client.Properties.Resources.logo;
            this.btnShowPostList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowPostList.ContextMenuStrip = this.contextMenuStrip1;
            this.btnShowPostList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowPostList.Location = new System.Drawing.Point(0, 0);
            this.btnShowPostList.Name = "btnShowPostList";
            this.btnShowPostList.Size = new System.Drawing.Size(50, 50);
            this.btnShowPostList.TabIndex = 0;
            this.btnShowPostList.UseVisualStyleBackColor = true;
            this.btnShowPostList.Click += new System.EventHandler(this.btnShowPostList_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOpenSettings,
            this.menuItemAppStatus,
            this.toolStripSeparator1,
            this.menuItemExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(188, 76);
            this.contextMenuStrip1.Text = "Arayüzü Aç";
            // 
            // menuItemOpenSettings
            // 
            this.menuItemOpenSettings.Name = "menuItemOpenSettings";
            this.menuItemOpenSettings.Size = new System.Drawing.Size(187, 22);
            this.menuItemOpenSettings.Text = "Ayarlar";
            this.menuItemOpenSettings.Click += new System.EventHandler(this.menuItemOpenSettings_Click);
            // 
            // menuItemAppStatus
            // 
            this.menuItemAppStatus.Name = "menuItemAppStatus";
            this.menuItemAppStatus.Size = new System.Drawing.Size(187, 22);
            this.menuItemAppStatus.Text = "Uygulamayı Pasif Yap";
            this.menuItemAppStatus.Click += new System.EventHandler(this.menuItemAppStatus_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(187, 22);
            this.menuItemExit.Text = "Çıkış";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "FarmaKode";
            this.notifyIcon1.Visible = true;
            // 
            // lblManuelBarcode
            // 
            this.lblManuelBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblManuelBarcode.BackColor = System.Drawing.Color.Red;
            this.lblManuelBarcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblManuelBarcode.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblManuelBarcode.ForeColor = System.Drawing.Color.White;
            this.lblManuelBarcode.Location = new System.Drawing.Point(24, 0);
            this.lblManuelBarcode.Name = "lblManuelBarcode";
            this.lblManuelBarcode.Padding = new System.Windows.Forms.Padding(2);
            this.lblManuelBarcode.Size = new System.Drawing.Size(26, 22);
            this.lblManuelBarcode.TabIndex = 1;
            this.lblManuelBarcode.Text = "5";
            this.lblManuelBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblManuelBarcode.Click += new System.EventHandler(this.lblManuelBarcode_Click);
            // 
            // FormButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(50, 50);
            this.Controls.Add(this.lblManuelBarcode);
            this.Controls.Add(this.btnShowPostList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(50, 50);
            this.Name = "FormButton";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormButton";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormButton_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button btnShowPostList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpenSettings;
        private System.Windows.Forms.ToolStripMenuItem menuItemAppStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lblManuelBarcode;
    }
}