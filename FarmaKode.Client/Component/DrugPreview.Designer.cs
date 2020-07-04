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
            this.drug_name = new System.Windows.Forms.TextBox();
            this.warnings = new System.Windows.Forms.TextBox();
            this.suggestions = new System.Windows.Forms.TextBox();
            this.diagnosis = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkIsPrint = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drug_name
            // 
            this.drug_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drug_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drug_name.Location = new System.Drawing.Point(80, 3);
            this.drug_name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.drug_name.Name = "drug_name";
            this.drug_name.Size = new System.Drawing.Size(271, 19);
            this.drug_name.TabIndex = 1;
            this.drug_name.TextChanged += new System.EventHandler(this.drug_name_TextChanged);
            // 
            // warnings
            // 
            this.warnings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.warnings.Location = new System.Drawing.Point(80, 71);
            this.warnings.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.warnings.Multiline = true;
            this.warnings.Name = "warnings";
            this.warnings.Size = new System.Drawing.Size(271, 65);
            this.warnings.TabIndex = 1;
            this.warnings.TextChanged += new System.EventHandler(this.warnings_TextChanged);
            // 
            // suggestions
            // 
            this.suggestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suggestions.Location = new System.Drawing.Point(80, 49);
            this.suggestions.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.suggestions.Name = "suggestions";
            this.suggestions.Size = new System.Drawing.Size(271, 19);
            this.suggestions.TabIndex = 1;
            this.suggestions.TextChanged += new System.EventHandler(this.suggestions_TextChanged);
            // 
            // diagnosis
            // 
            this.diagnosis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagnosis.Location = new System.Drawing.Point(80, 26);
            this.diagnosis.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.diagnosis.Name = "diagnosis";
            this.diagnosis.Size = new System.Drawing.Size(271, 19);
            this.diagnosis.TabIndex = 1;
            this.diagnosis.TextChanged += new System.EventHandler(this.diagnosis_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.drug_name, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.warnings, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.suggestions, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.diagnosis, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkIsPrint, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(353, 139);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.tableLayoutPanel1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(19, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 71);
            this.label4.TabIndex = 5;
            this.label4.Text = "Uyarılar";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(19, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kullanım";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(19, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Endikasyon";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkIsPrint
            // 
            this.chkIsPrint.AutoSize = true;
            this.chkIsPrint.Location = new System.Drawing.Point(2, 3);
            this.chkIsPrint.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkIsPrint.Name = "chkIsPrint";
            this.chkIsPrint.Size = new System.Drawing.Size(13, 16);
            this.chkIsPrint.TabIndex = 6;
            this.chkIsPrint.Text = "checkPrint";
            this.chkIsPrint.UseVisualStyleBackColor = true;
            this.chkIsPrint.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(19, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "İlaç Adı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DrugPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "DrugPreview";
            this.Size = new System.Drawing.Size(353, 139);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox drug_name;
        private System.Windows.Forms.TextBox warnings;
        private System.Windows.Forms.TextBox suggestions;
        private System.Windows.Forms.TextBox diagnosis;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox chkIsPrint;
    }
}
