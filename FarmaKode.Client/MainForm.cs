using FarmaKode.Client.Business;
using FarmaKode.Client.Model;
using FarmaKode.Client.Util;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
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

            DirectoryInfo ornekFolder = new DirectoryInfo(Path.Combine(Application.StartupPath, "Data", "OrnekHtm"));

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
            //popupNotifier1.ContentText = "Context" + DateTime.Now.Second;
            //popupNotifier1.ShowCloseButton = true;
            //popupNotifier1.ShowOptionsButton = false;
            //popupNotifier1.ShowGrip = true;
            //popupNotifier1.Delay = 2000;
            //popupNotifier1.AnimationInterval = 1;
            //popupNotifier1.AnimationDuration = 300;
            //popupNotifier1.TitlePadding = new Padding(0);
            //popupNotifier1.ContentPadding = new Padding(0);
            //popupNotifier1.ImagePadding = new Padding(0);
            //popupNotifier1.Scroll = true;
            //popupNotifier1.Size = new Size(200, 100);
            //popupNotifier1.Popup();// show  


            //FormNotification bil = new FormNotification();
            //bil.lblBildirim.Text = "FarmaKode Aktif";
            //bil.ShowDialog();

          

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

        private void MainForm_Load(object sender, EventArgs e)
        {


            this.reportViewer1.RefreshReport();
        }

        private void button4_Click(object sender, EventArgs e)
        {

           

        }


        private static List<Stream> m_streams;
        private static int m_currentPageIndex = 0;


        public static void PrintToPrinter(LocalReport report)
        {
            Export(report);

        }

        public static void Export(LocalReport report, bool print = true)
        {
            string deviceInfo =
             @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>3in</PageWidth>
                <PageHeight>8.3in</PageHeight>
                <MarginTop>0in</MarginTop>
                <MarginLeft>0.1in</MarginLeft>
                <MarginRight>0.1in</MarginRight>
                <MarginBottom>0in</MarginBottom>
            </DeviceInfo>";
            Warning[] warnings;
            m_streams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateStream, out warnings);
            foreach (Stream stream in m_streams)
                stream.Position = 0;

            if (print)
            {
                Print();
            }
        }

        public static void Print()
        {
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: no stream to print.");
            PrintDocument printDoc = new PrintDocument();
            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: cannot find the default printer.");
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }
        }

        public static Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        public static void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new
               Metafile(m_streams[m_currentPageIndex]);

            // Adjust rectangular area with printer margins.
            Rectangle adjustedRect = new Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                ev.PageBounds.Width,
                ev.PageBounds.Height);

            // Draw a white background for the report
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            // Draw the report content
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            // Prepare for the next page. Make sure we haven't hit the end.
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }

        public static void DisposePrint()
        {
            if (m_streams != null)
            {
                foreach (Stream stream in m_streams)
                    stream.Close();
                m_streams = null;
            }
        }

    }
}
