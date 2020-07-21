namespace FarmaKode.Client.Component
{
    partial class DrugPreview
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
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.drug_name = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.diagnosis = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.suggestions = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.warnings = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.chkIsPrint = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(48, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(54, 20);
            this.kryptonLabel1.TabIndex = 7;
            this.kryptonLabel1.Values.Text = "İlaç Adı";
            // 
            // drug_name
            // 
            this.drug_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drug_name.Location = new System.Drawing.Point(108, 3);
            this.drug_name.Name = "drug_name";
            this.drug_name.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.drug_name.Size = new System.Drawing.Size(187, 23);
            this.drug_name.TabIndex = 3;
            // 
            // diagnosis
            // 
            this.diagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diagnosis.Location = new System.Drawing.Point(108, 28);
            this.diagnosis.Name = "diagnosis";
            this.diagnosis.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.diagnosis.Size = new System.Drawing.Size(187, 23);
            this.diagnosis.TabIndex = 3;
            // 
            // suggestions
            // 
            this.suggestions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.suggestions.Location = new System.Drawing.Point(108, 52);
            this.suggestions.Multiline = true;
            this.suggestions.Name = "suggestions";
            this.suggestions.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.suggestions.Size = new System.Drawing.Size(187, 37);
            this.suggestions.TabIndex = 3;
            // 
            // warnings
            // 
            this.warnings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.warnings.Location = new System.Drawing.Point(108, 90);
            this.warnings.Multiline = true;
            this.warnings.Name = "warnings";
            this.warnings.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.warnings.Size = new System.Drawing.Size(187, 61);
            this.warnings.TabIndex = 4;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(26, 28);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(76, 20);
            this.kryptonLabel2.TabIndex = 7;
            this.kryptonLabel2.Values.Text = "Endikasyon";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(40, 52);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(62, 20);
            this.kryptonLabel3.TabIndex = 7;
            this.kryptonLabel3.Values.Text = "Kullanım";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(46, 90);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(56, 20);
            this.kryptonLabel4.TabIndex = 7;
            this.kryptonLabel4.Values.Text = "Uyarılar";
            // 
            // chkIsPrint
            // 
            this.chkIsPrint.Location = new System.Drawing.Point(3, 4);
            this.chkIsPrint.Name = "chkIsPrint";
            this.chkIsPrint.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.chkIsPrint.Size = new System.Drawing.Size(19, 13);
            this.chkIsPrint.TabIndex = 8;
            this.chkIsPrint.Values.Text = "";
            this.chkIsPrint.CheckedChanged += new System.EventHandler(this.chkIsPrint_CheckedChanged);
            // 
            // DrugPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.chkIsPrint);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.warnings);
            this.Controls.Add(this.suggestions);
            this.Controls.Add(this.diagnosis);
            this.Controls.Add(this.drug_name);
            this.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "DrugPreview";
            this.Size = new System.Drawing.Size(304, 158);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox drug_name;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox diagnosis;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox suggestions;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox warnings;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        public ComponentFactory.Krypton.Toolkit.KryptonCheckBox chkIsPrint;
    }
}
