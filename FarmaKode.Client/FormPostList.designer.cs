namespace FarmaKode.Client
{
    partial class FormPostList
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
            this.splitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLastPost = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnYazdir = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSelectAll = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1.Panel1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1.Panel2)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(5, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new System.Drawing.Size(349, 201);
            this.splitContainer1.SplitterDistance = 116;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 201);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Controls.Add(this.btnLastPost, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnYazdir, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectAll, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(215, 201);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnLastPost
            // 
            this.btnLastPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLastPost.Location = new System.Drawing.Point(3, 3);
            this.btnLastPost.Name = "btnLastPost";
            this.btnLastPost.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btnLastPost.Size = new System.Drawing.Size(64, 29);
            this.btnLastPost.TabIndex = 0;
            this.btnLastPost.Values.Image = global::FarmaKode.Client.Properties.Resources.door_out1;
            this.btnLastPost.Values.Text = "Son İşlemler";
            this.btnLastPost.Click += new System.EventHandler(this.btnLastPost_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(209, 160);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnYazdir.Location = new System.Drawing.Point(143, 3);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btnYazdir.Size = new System.Drawing.Size(69, 29);
            this.btnYazdir.TabIndex = 12;
            this.btnYazdir.Values.Image = global::FarmaKode.Client.Properties.Resources.printer;
            this.btnYazdir.Values.Text = "YAZDIR";
            this.btnYazdir.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Checked = true;
            this.btnSelectAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectAll.Location = new System.Drawing.Point(73, 3);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btnSelectAll.Size = new System.Drawing.Size(64, 29);
            this.btnSelectAll.TabIndex = 13;
            this.btnSelectAll.Values.Text = "Temizle";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_CheckedChanged);
            // 
            // FormPostList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 211);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(375, 250);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(375, 250);
            this.Name = "FormPostList";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Son İşlemler";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.FormPostList_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1.Panel1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1.Panel2)).EndInit();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLastPost;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnYazdir;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnSelectAll;
    }
}