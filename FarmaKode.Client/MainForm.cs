using FarmaKode.Client.Business;
using FarmaKode.Client.Model;
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
    public partial class MainForm : Form
    {
        private const string FilePath = @"C:\Users\ay1438\Desktop\Farmakode2020\OrnekHTM\637201676841973771_KarekodIslem[4].htm";

        public MainForm()
        {
            InitializeComponent();
        }


       

        

        private void button1_Click(object sender, EventArgs e)
        {
            new FormSettings().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormParameter().ShowDialog();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Section section =  ParserBL.GetInstance().Parse(FilePath);

            List<string> itemList = new List<string>();

            itemList.Clear();
            foreach (var item in section.HeaderSection)
            {
                itemList.Add(string.Format("\"{0}\":\"{1}\"", item.VariableName,item.Value));
            }
            string header = string.Format("\"HeaderSection\": {{{0}}}", string.Join(",",itemList));

            itemList.Clear();
            foreach (var item in section.DrugSection)
            {
                itemList.Add(string.Format("\"{0}{1}\":\"{2}\"", item.VariableName,item.LoopId, item.Value));
            }
            string drug = string.Format("\"DrugSection\": {{{0}}}", string.Join(",", itemList));


        }
    }
}
