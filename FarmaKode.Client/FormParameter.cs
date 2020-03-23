using FarmaKode.Client.Business;
using FarmaKode.Client.Model;
using FastMember;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaKode.Client
{
    public partial class FormParameter : Form
    {
        Parameter selectedParameter = null;
        public FormParameter()
        {
            InitializeComponent();
            bindGrid();
        }

        void bindGrid()
        {
            IEnumerable<Parameter> data = CacheBL.parameterList;
            DataTable table = new DataTable();
            using (var reader = ObjectReader.Create(data))
            {
                table.Load(reader);
            }
            grid.DataSource = table;


        }

        void fillParameter()
        {
            if (selectedParameter != null)
            {
                lblSelectedId.Text = selectedParameter.Id.ToString();
                txtGroup.Text = selectedParameter.Group;
                txtLabel.Text = selectedParameter.Label;
                txtVariableName.Text = selectedParameter.VariableName;
                txtXPath.Text = selectedParameter.XPath;
                chkCombobox.Checked = selectedParameter.IsCombobox;
                chkIsRecursive.Checked = selectedParameter.IsRecursive;
                spinRecursiveCount.Value = selectedParameter.RecursiveCount;
                chkParameterEnabled.Checked = selectedParameter.Enabled;
                chkEditable.Checked = selectedParameter.IsEditable;

                btnAddNew.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }

        }

        void setParameter()
        {
            Parameter currentParameter = null;

            if (selectedParameter != null)
            {
                currentParameter = CacheBL.parameterList.Where(p => p.Id == selectedParameter.Id).SingleOrDefault();

                currentParameter.Enabled = chkParameterEnabled.Checked;
                currentParameter.IsEditable = chkEditable.Checked;
                currentParameter.Group = txtGroup.Text;
                currentParameter.Label = txtLabel.Text;
                currentParameter.VariableName = txtVariableName.Text;
                currentParameter.XPath = txtXPath.Text;
                currentParameter.IsCombobox = chkCombobox.Checked;
                currentParameter.IsRecursive = chkIsRecursive.Checked;
                currentParameter.RecursiveCount = Convert.ToInt32(spinRecursiveCount.Value);
            }
            else
            {
                currentParameter = new Parameter();
                currentParameter.Id = CacheBL.parameterList.Select(p => p.Id).Max() + 1;
                currentParameter.Enabled = chkParameterEnabled.Checked;
                currentParameter.IsEditable = chkEditable.Checked;
                currentParameter.Group = txtGroup.Text;
                currentParameter.Label = txtLabel.Text;
                currentParameter.VariableName = txtVariableName.Text;
                currentParameter.XPath = txtXPath.Text;
                currentParameter.IsCombobox = chkCombobox.Checked;
                currentParameter.IsRecursive = chkIsRecursive.Checked;
                currentParameter.RecursiveCount = Convert.ToInt32(spinRecursiveCount.Value);
                CacheBL.parameterList.Add(currentParameter);

            }


            bindGrid();
        }

        void clear()
        {
            selectedParameter = null;
            grid.ClearSelection();
            lblSelectedId.Text =            
            txtGroup.Text =
            txtLabel.Text =
            txtVariableName.Text =
            txtXPath.Text = string.Empty;
            chkCombobox.Checked = false;
            chkIsRecursive.Checked = false;
            spinRecursiveCount.Value = 0;
            chkParameterEnabled.Checked = true;
            chkEditable.Checked = false;

            btnAddNew.Text = "Add Parameter";
            btnAddNew.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

        }


        private void grid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected)
                return;

            DataRowView row = e.Row.DataBoundItem as DataRowView;
            selectedParameter = new Parameter();
            selectedParameter.Enabled = Convert.ToBoolean(row["Enabled"]);
            selectedParameter.IsCombobox = Convert.ToBoolean(row["IsCombobox"]);
            selectedParameter.IsRecursive = Convert.ToBoolean(row["IsRecursive"]);
            selectedParameter.IsEditable = Convert.ToBoolean(row["IsEditable"]);
            selectedParameter.RecursiveCount = Convert.ToInt32(row["RecursiveCount"]);
            selectedParameter.Group = row["Group"].ToString();
            selectedParameter.Id = Convert.ToInt32(row["Id"]);
            selectedParameter.Label = row["Label"].ToString();
            selectedParameter.VariableName = row["VariableName"].ToString();
            selectedParameter.XPath = row["XPath"].ToString();

            fillParameter();


        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            selectedParameter = null;
            setParameter();
            clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            setParameter();
            clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void chkParameterEnabled_CheckedChanged(object sender, EventArgs e)
        {
          lblSelectedId.Enabled =
          chkEditable.Enabled =
          txtGroup.Enabled =
          txtLabel.Enabled =
          txtVariableName.Enabled =
          txtXPath.Enabled =
          chkCombobox.Enabled =
          chkIsRecursive.Enabled =
          spinRecursiveCount.Enabled = chkParameterEnabled.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CacheBL.parameterList != null)
            {
                ParameterBL.GetInstance().SetParameters(CacheBL.parameterList);
                MessageBox.Show("Değişiklikler kayıt edildi", "Başarılı", MessageBoxButtons.OK);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedParameter != null)
            {
                DialogResult result = MessageBox.Show("Parametreyi silmek istediğinden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Parameter _selected = CacheBL.parameterList.Where(p => p.Id == selectedParameter.Id).SingleOrDefault();
                    CacheBL.parameterList.Remove(_selected);
                    bindGrid();
                }
            }
        }
    }
}
