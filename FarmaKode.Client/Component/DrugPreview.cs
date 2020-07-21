using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmaKode.Client.Model;

namespace FarmaKode.Client.Component
{
    public partial class DrugPreview : UserControl
    {
        public ResponseDrug Drug { get; set; }


        public DrugPreview()
        {
            InitializeComponent();
           
        }
        public DrugPreview(ResponseDrug responseDrug)
        {
            InitializeComponent();
            Drug = responseDrug;
            chkIsPrint.Checked = responseDrug.IsPrint;

            drug_name.Text = Drug.Drug_name;
            diagnosis.Text = Drug.Diagnosis;
            suggestions.Text = Drug.Suggestions;
            warnings.Text = Drug.Warnings; 
        }

        private void drug_name_TextChanged(object sender, EventArgs e)
        {
            this.Drug.Drug_name = drug_name.Text.Trim();
        }

        private void diagnosis_TextChanged(object sender, EventArgs e)
        {
            this.Drug.Diagnosis = diagnosis.Text.Trim();
        }

        private void warnings_TextChanged(object sender, EventArgs e)
        {
            this.Drug.Warnings = warnings.Text.Trim();
        }

        private void suggestions_TextChanged(object sender, EventArgs e)
        {
            this.Drug.Suggestions = suggestions.Text.Trim();

        }

        

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            chkIsPrint.Checked = !chkIsPrint.Checked;
        }

        private void chkIsPrint_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = chkIsPrint.Checked ? Color.Yellow : Color.DarkGray;
            this.Drug.IsPrint = chkIsPrint.Checked;
        }
    }
}
