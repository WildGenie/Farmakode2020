namespace FarmaKode.Client
{
    partial class FormManuelBarcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManuelBarcode));
            this.btnGonder = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnTemizle = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.listBarcodes = new ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox();
            this.SuspendLayout();
            // 
            // btnGonder
            // 
            this.btnGonder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGonder.Location = new System.Drawing.Point(215, 358);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(107, 41);
            this.btnGonder.TabIndex = 1;
            this.btnGonder.Values.Image = global::FarmaKode.Client.Properties.Resources.world_go;
            this.btnGonder.Values.Text = "GÖNDER";
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTemizle.Location = new System.Drawing.Point(12, 358);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(92, 41);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Values.Image = global::FarmaKode.Client.Properties.Resources.filter_clear;
            this.btnTemizle.Values.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Black;
            // 
            // listBarcodes
            // 
            this.listBarcodes.CheckOnClick = true;
            this.listBarcodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBarcodes.Location = new System.Drawing.Point(0, 0);
            this.listBarcodes.Name = "listBarcodes";
            this.listBarcodes.Size = new System.Drawing.Size(334, 411);
            this.listBarcodes.TabIndex = 3;
            // 
            // FormManuelBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.listBarcodes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(350, 450);
            this.MinimumSize = new System.Drawing.Size(350, 450);
            this.Name = "FormManuelBarcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Perakende";
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnGonder;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTemizle;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox listBarcodes;
    }
}