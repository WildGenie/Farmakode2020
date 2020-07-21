using ComponentFactory.Krypton.Toolkit;
using FarmaKode.Client.Business;
using FarmaKode.Client.Model.Request;
using FarmaKode.Client.Model.Response;
using FarmaKode.Client.Util;
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
    public partial class FormManuelBarcode : KryptonForm
    {
        List<string> manuelBarcodes = null;
        public ParserBL BL = ParserBL.GetInstance();
        public FormManuelBarcode()
        {
            InitializeComponent();
        }

        public FormManuelBarcode(List<string> _manuelBarcodes)
        {
            InitializeComponent();
            manuelBarcodes = new List<string>();
            manuelBarcodes = _manuelBarcodes;
            foreach (var item in manuelBarcodes)
            {
                listBarcodes.Items.Add(item);
            }
           
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            manuelBarcodes.Clear();
            listBarcodes.Items.Clear();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            List<string> selected = new List<string>();
            foreach (var item in listBarcodes.SelectedItems)
                selected.Add(item.ToString());

            Logger.GetInstance().Info("Web Servise gönderilen perakende barkodları" + string.Join("\n", selected));
            RequestBarcode requestBarcode = BL.CreatRetailRequest(selected);
            ResponseBarcode responseBarcode = BL.PostRetailRequest(requestBarcode);
            responseBarcode.ReceteNo = requestBarcode.HeaderSection.ReceteNo;

            new FormNotification(responseBarcode).ShowDialog(); 
            selected.Clear();
        }
    }
}
