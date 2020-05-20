using FarmaKode.Client.Business;
using FarmaKode.Client.Model;
using iTextSharp.text.pdf;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static FarmaKode.Client.Util.Constants;

namespace FarmaKode.Client
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            //DirectoryInfo ornekFolder = new DirectoryInfo(Path.Combine(Application.StartupPath, "Data", "OrnekHtm"));

            //FileInfo[] files = ornekFolder.GetFiles("*.htm");

            //listBox1.DataSource = files;
            //listBox1.DisplayMember = "Name";
            //listBox1.ValueMember = "FullName";

            

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
            FormNotification frm = new FormNotification();
            frm.ShowAlert("Ahmet YAĞBASAN reçetesi hazır", NotificationType.Success);
            //var xmdock = CreateToast();
            //ToastNotification toast = new ToastNotification(xmdock);

            //toast.Activated += ToastNotification_Activated;
            //toast.Dismissed += ToastNotification_Dismissed;
            //Toast.Failed += ToastNotification_Failed;
            //ToastNotificationManager.CreateToastNotifier().Show(toast);

            //var notifi = ToastNotificationManager.CreateToastNotifier();
            //notifi.Show(toast);

            //popupNotifier1.TitleText = "Title";
            //popupNotifier1.ContentText = "Context" + DateTime.Now.Second;
            //popupNotifier1.ShowCloseButton = true;
            //popupNotifier1.ShowOptionsButton = true;
            //popupNotifier1.ShowGrip = true;
            //popupNotifier1.Delay = 2000;
            //popupNotifier1.AnimationInterval = 1;
            //popupNotifier1.AnimationDuration = 300;
            //popupNotifier1.TitlePadding = new Padding(0);
            //popupNotifier1.ContentPadding = new Padding(0);
            //popupNotifier1.ImagePadding = new Padding(0);
            //popupNotifier1.Scroll = false;
            //popupNotifier1.Size = new Size(200, 100);
            ////popupNotifier1.p
            //popupNotifier1.Popup();// show  
            //                       //System.Diagnostics.Process pro = System.Diagnostics.Process.GetCurrentProcess();
            //                       // ToastNotificationManager.CreateToastNotifier(pro.ProcessName).Show(toast);

            //// toast.Activated += toast_Activated;




            //FormNotification bil = new FormNotification();
            //bil.lblBildirim.Text = "FarmaKode Aktif";
            //bil.ShowDialog();


            // ToastTemplateType toastTemplate = ToastTemplateType.ToastImageAndText01;
            // Windows.Data.Xml.Dom.XmlDocument toastXml = ToastNotificationManager.GetTemplateContent(toastTemplate);
            // Windows.Data.Xml.Dom.XmlNodeList toastTextElements = toastXml.GetElementsByTagName("text");
            // toastTextElements[0].AppendChild(toastXml.CreateTextNode("Hello!I am an awesome cat… Awesome cats make Windows 8 awesomer!!"));
            // XmlElement tileImage = toastXml.GetElementsByTagName("image")[0] as XmlElement;
            // tileImage.SetAttribute("src","http://placekitten.com/256/256");
            // tileImage.SetAttribute("alt", "awesome cat");
            // // Display the toast for 25 seconds
            // Windows.Data.Xml.Dom.XmlElement toastNode = (Windows.Data.Xml.Dom.XmlElement)toastXml.SelectSingleNode("/ toast");
            // toastNode.SetAttribute("duration", "long");
            // // Add a looping sound
            // Windows.Data.Xml.Dom.XmlElement audio = toastXml.CreateElement("audio");
            // audio.SetAttribute("src", "ms - winsoundevent:Notification.Looping.Call");
            // audio.SetAttribute("loop", "true");
            // toastNode.AppendChild(audio);
            // ToastNotification toast = new ToastNotification(toastXml);
            // // ToastNotification events
            //// toast.Activated += ToastNotification_Activated;
            // //toast.Dismissed += ToastNotification_Dismissed;
            // //toast.Failed += ToastNotification_Failed;
            // ToastNotificationManager.CreateToastNotifier().Show(toast);



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
             
                string fileNameExisting = @"C:\Users\Ahmet\Desktop\1234.pdf";
                string fileNameNew = @"C:\Users\Ahmet\Desktop\abc.pdf";

                using (var existingFileStream = new FileStream(fileNameExisting, FileMode.Open))
                using (var newFileStream = new FileStream(fileNameNew, FileMode.Create))
                {
                    // Open existing PDF
                    var pdfReader = new PdfReader(existingFileStream);

                
                PdfDictionary root = pdfReader.Catalog;
                PdfDictionary form = root.GetAsDict(PdfName.ACROFORM);
                PdfArray fields = form.GetAsArray(PdfName.FIELDS);

                PdfDictionary page;
                PdfArray annots;
                for (int i = 1; i <= pdfReader.NumberOfPages; i++)
                {
                    page = pdfReader.GetPageN(i);
                    annots = page.GetAsArray(PdfName.ANNOTS);
                    for (int j = 0; j < annots.Size; j++)
                    {
                        fields.Add(annots.GetAsIndirectObject(j));
                    }
                }
                

                // PdfStamper, which will create
                var stamper = new PdfStamper(pdfReader, newFileStream);

                    var form1 = stamper.AcroFields;
                    var fieldKeys = form1.Fields.Keys;

                    foreach (string fieldKey in fieldKeys)
                    {
                        form1.SetField(fieldKey, "REPLACED!");
                    }

                    // "Flatten" the form so it wont be editable/usable anymore
                    stamper.FormFlattening = true;

                    // You can also specify fields to be flattened, which
                    // leaves the rest of the form still be editable/usable
                    stamper.PartialFormFlattening("field1");

                    stamper.Close();
                    pdfReader.Close();
                }
            


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
