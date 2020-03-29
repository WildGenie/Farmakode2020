using FarmaKode.Client.Business;
using FarmaKode.Client.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace FarmaKode.Client
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            DirectoryInfo ornekFolder = new DirectoryInfo(Path.Combine(Application.StartupPath, "Data","OrnekHtm"));

            FileInfo[] files = ornekFolder.GetFiles("*.htm");

            listBox1.DataSource = files;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "FullName";

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

            //PopupNotifier popupNotifier1 = new PopupNotifier();
            //popupNotifier1.TitleText = "Title";
            //popupNotifier1.ContentText ="Context" + DateTime.Now.Second;
            //popupNotifier1.ShowCloseButton = true;
            //popupNotifier1.ShowOptionsButton = false;
            //popupNotifier1.ShowGrip =true;
            //popupNotifier1.Delay = 2000;
            //popupNotifier1.AnimationInterval = 1;
            //popupNotifier1.AnimationDuration = 300;
            //popupNotifier1.TitlePadding = new Padding(0);
            //popupNotifier1.ContentPadding = new Padding(0);
            //popupNotifier1.ImagePadding = new Padding(0);
            //popupNotifier1.Scroll = true;
            //popupNotifier1.Size = new Size(200, 100);             
            //popupNotifier1.Popup();// show  


            FormNotification bil = new FormNotification();
            bil.lblBildirim.Text = "FarmaKode Aktif";
            bil.ShowDialog();


        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string selectedPath = listBox1.SelectedValue.ToString();
           List<ParsedData> section = ParserBL.GetInstance().Parse(selectedPath);

            //List<string> itemList = new List<string>();

            //itemList.Clear();
            //foreach (var item in section.HeaderSection)
            //{
            //    itemList.Add(string.Format("\"{0}\":\"{1}\"", item.VariableName, item.Value));
            //}
            //string header = string.Format("\"HeaderSection\": {{{0}}}", string.Join(",", itemList));

            //itemList.Clear();
            //foreach (var item in section.DrugSection)
            //{
            //    itemList.Add(string.Format("\"{0}{1}\":\"{2}\"", item.VariableName, item.GroupId, item.Value));
            //}
            //string drug = string.Format("\"DrugSection\": {{{0}}}", string.Join(",", itemList));
        }
    }
}
