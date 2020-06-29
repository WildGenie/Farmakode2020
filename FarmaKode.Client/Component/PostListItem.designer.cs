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
            this.lblName = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnGoToWeb = new System.Windows.Forms.Button();
            this.lblNo = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(20, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(205, 26);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "#Hasta Adı#";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGoToWeb
            // 
            this.btnGoToWeb.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGoToWeb.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGoToWeb.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(161)))), ((int)(((byte)(19)))));
            this.btnGoToWeb.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(161)))), ((int)(((byte)(19)))));
            this.btnGoToWeb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(161)))), ((int)(((byte)(19)))));
            this.btnGoToWeb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.btnGoToWeb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoToWeb.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold);
            this.btnGoToWeb.ForeColor = System.Drawing.Color.White;
            this.btnGoToWeb.Location = new System.Drawing.Point(225, 0);
            this.btnGoToWeb.Name = "btnGoToWeb";
            this.btnGoToWeb.Size = new System.Drawing.Size(75, 26);
            this.btnGoToWeb.TabIndex = 3;
            this.btnGoToWeb.Text = "GÖRÜNTÜLE";
            this.toolTip1.SetToolTip(this.btnGoToWeb, "Web\'de görüntüle");
            this.btnGoToWeb.UseVisualStyleBackColor = false;
            this.btnGoToWeb.Click += new System.EventHandler(this.btnGoToWeb_Click);
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
            this.btnPrint.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(161)))), ((int)(((byte)(19)))));
            this.btnPrint.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(161)))), ((int)(((byte)(19)))));
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(161)))), ((int)(((byte)(19)))));
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(150, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 26);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "YAZDIR";
            this.toolTip1.SetToolTip(this.btnPrint, "Web\'de görüntüle");
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // PostListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.btnGoToWeb);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PostListItem";
            this.Size = new System.Drawing.Size(300, 26);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Button btnGoToWeb;
        private System.Windows.Forms.Button btnPrint;
    }
}
