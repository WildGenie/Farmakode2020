using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmaKode.Client.Model.Response;
using FarmaKode.Client.Properties;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace FarmaKode.Client.Util
{
    public class Printer
    {
        private static Printer instance = null;
          public static Printer GetInstance()
        {
            if (instance == null)
            {
  
                instance = new Printer();
                return instance;
            }

            return instance;
        }

        private void Process(string printerName, string filePath)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo(filePath);
                info.Arguments = "\"" + printerName + "\"";
                info.CreateNoWindow = true;
                info.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                info.UseShellExecute = true;
                info.Verb = "PrintTo";
                System.Diagnostics.Process.Start(info);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Print(string filePath)
        {
            if(Settings.Default.ShowPrinterDilaog)
            {
                PrintWithDialog(filePath);
            }
            else
            {
                Process(Settings.Default.DefaultBarcodePrinter, filePath);
            }
        }
        
        private void PrintWithDialog(string filePath)
        {
            using (PrintDialog printDialog1 = new PrintDialog())
            {                
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    Process(printDialog1.PrinterSettings.PrinterName, filePath); 
                }
            }
        }


        public string CreatePDF(ResponseBarcode barcode)
        {
            try
            {
                byte[] pdf;
                var cssText = File.ReadAllText(Settings.Default.DestinationFolder + "\\ReportTemplate\\barcode.css");
                var htmlTemplate = File.ReadAllText(Settings.Default.DestinationFolder + "\\ReportTemplate\\barcode.html");

                StringBuilder sb = new StringBuilder();

                foreach (var item in barcode.Data.Drugs)
                {
                    if (item.IsPrint)
                    {
                        string content = string.Format(htmlTemplate,
                            item.Drug_name,
                            DateTime.Now.ToString("dd.MM.yyyy"),
                            item.Diagnosis,
                            item.Suggestions,
                            item.Warnings,
                            barcode.Data.Patient_name,
                            item.Expiration_date.ToString("dd.MM.yyyy"),
                            barcode.Data.Pharmacy_name,
                            barcode.Data.Pharmacy_phone);

                        sb.AppendLine(content);

                    }
                }

                using (var memoryStream = new MemoryStream())
                {
                    Size paperSize = Common.GetBarcodePaperSize();
                    Margins paperMargins = Common.GetBarcodePaperMargins();
                    float width = (float)Math.Ceiling((float)paperSize.Width * 0.039370078740158 * 72);
                    float height = (float)Math.Ceiling((float)paperSize.Height * 0.039370078740158 * 72);

                    iTextSharp.text.Rectangle rectangle = new iTextSharp.text.Rectangle(width, height);
                    var document = new Document(rectangle,
                        paperMargins.Left,
                        paperMargins.Right,
                        paperMargins.Top,
                        paperMargins.Bottom);
                    var writer = PdfWriter.GetInstance(document, memoryStream);
                    document.Open();

                    using (var cssMemoryStream = new MemoryStream(Encoding.UTF8.GetBytes(cssText)))
                    {
                        using (var htmlMemoryStream = new MemoryStream(Encoding.UTF8.GetBytes(sb.ToString())))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, document, htmlMemoryStream, cssMemoryStream);
                        }
                    }

                    document.Close();

                    pdf = memoryStream.ToArray();
                }

                string path = Settings.Default.DestinationFolder + "\\Barcods\\" + barcode.ReceteNo + "_Barcode.pdf";
                FileStream fs = new FileStream(path, FileMode.Create);
                fs.Write(pdf, 0, pdf.Length);
                fs.Flush();
                fs.Close();

                return path;
            }
            catch (Exception ex)
            {
                throw ex;
            }
          
        }
    }
}
