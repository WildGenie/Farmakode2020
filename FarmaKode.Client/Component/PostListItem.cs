using System;
using System.ComponentModel;
using System.Windows.Forms;
using FarmaKode.Client.Model.Response;

namespace FarmaKode.Client.Component
{
    public partial class PostListItem : UserControl
    {
        [Browsable(true)]
        [Category("Olaylar")]
        [Description("Son ilaç listesindeki item tıklandığı zaman")]
        public event EventHandler PosItemDetailClicked;
        public ResponseBarcode Data { get; set; }

        public PostListItem()
        {
            InitializeComponent();
        }

        public PostListItem(int orderNo, ResponseBarcode Data)
        {
            InitializeComponent();
            this.Data = Data;
            load(orderNo);
        }

        void load(int orderNo)
        { 
            lblName.Text = Data.Name_surname;
            lblNo.Text = orderNo.ToString();
        }

        private void btnGoToWeb_Click(object sender, EventArgs e)
        {
            PosItemDetailClicked?.Invoke(this.Data,e);
        }

      
    }
}
