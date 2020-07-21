namespace FarmaKode.Client.Component
{
    partial class PostListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblNo = new System.Windows.Forms.Label();
            this.btnPrint = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDetail = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // lblNo
            // 
            this.lblNo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNo.ForeColor = System.Drawing.Color.DarkGray;
            this.lblNo.Location = new System.Drawing.Point(0, 0);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(20, 26);
            this.lblNo.TabIndex = 5;
            this.lblNo.Text = "1";
            this.lblNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrint.Location = new System.Drawing.Point(224, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btnPrint.Size = new System.Drawing.Size(64, 26);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Values.Image = global::FarmaKode.Client.Properties.Resources.printer;
            this.btnPrint.Values.Text = "Yazdır";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDetail.Location = new System.Drawing.Point(288, 0);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btnDetail.Size = new System.Drawing.Size(74, 26);
            this.btnDetail.TabIndex = 8;
            this.btnDetail.Values.Image = global::FarmaKode.Client.Properties.Resources.magnifier;
            this.btnDetail.Values.Text = "Detaylar";
            this.btnDetail.Click += new System.EventHandler(this.btnGoToWeb_Click);
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblName.Location = new System.Drawing.Point(20, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(204, 26);
            this.lblName.TabIndex = 9;
            this.lblName.Values.Text = "kryptonLabel1";
            // 
            // PostListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.btnDetail);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PostListItem";
            this.Size = new System.Drawing.Size(362, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblNo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPrint;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDetail;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPaletteOffice2010Black;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblName;
    }
}
