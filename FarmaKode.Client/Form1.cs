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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kryptonNavigator1_CloseAction(object sender, ComponentFactory.Krypton.Navigator.CloseActionEventArgs e)
        {
            this.Close();
        }

        private void kryptonHeader1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
