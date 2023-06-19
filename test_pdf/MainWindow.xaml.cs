using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;
using System.Diagnostics;
using System.IO;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using static System.Windows.Shapes.Path;
using Path = System.Windows.Shapes.Path;


namespace test_pdf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {











        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {

            // MessageBox.Show("hallo3"); 
            Trace.WriteLine("hallo");
            Console.Write("ichbindumm");
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            PdfDocument document = PdfReader.Open("C:\\Users\\Lauritz Abel\\Desktop\\TestPDF\\TestVorlage.pdf",
                PdfDocumentOpenMode.Import);
            PdfDocument outputDocument = new PdfDocument();
            int count = Math.Max(document.PageCount, document.PageCount);
            for (int idx = 0; idx < count; idx++)
            {
                // Get page from 1st document
                PdfPage page1 = document.PageCount > idx ? document.Pages[idx] : new PdfPage();
                page1 = outputDocument.AddPage(page1); 
                
                XGraphics gfx = XGraphics.FromPdfPage(page1);
                                                       
                // Create a font
                XFont font = new XFont("Verdana", 10);
                                                       
                // Position
                gfx.DrawString("Zeile 1", font, XBrushes.Black, new XRect(-225, -25, page1.Width, page1.Height), XStringFormats.Center);
                gfx.DrawString("Zeile 2", font, XBrushes.Black, new XRect(-225, -10, page1.Width, page1.Height), XStringFormats.Center);
                gfx.DrawString("Zeile 3", font, XBrushes.Black, new XRect(-225, 5, page1.Width, page1.Height), XStringFormats.Center);
                gfx.DrawString("Zeile 4", font, XBrushes.Black, new XRect(-225, 20, page1.Width, page1.Height), XStringFormats.Center);
                gfx.DrawString("Zeile 5", font, XBrushes.Black, new XRect(-225, 35, page1.Width, page1.Height), XStringFormats.Center);   
                gfx.DrawString("Zeile 6", font, XBrushes.Black, new XRect(-225, 50, page1.Width, page1.Height), XStringFormats.Center);
                gfx.DrawString("Zeile 7", font, XBrushes.Black, new XRect(-225, 65, page1.Width, page1.Height), XStringFormats.Center);
                gfx.DrawString("Zeile 8", font, XBrushes.Black, new XRect(-225, 80, page1.Width, page1.Height), XStringFormats.Center); 
                gfx.DrawString("Zeile 9", font, XBrushes.Black, new XRect(-225, 95, page1.Width, page1.Height), XStringFormats.Center);
                gfx.DrawString("Zeile 10",font, XBrushes.Black, new XRect(-225, 110, page1.Width, page1.Height), XStringFormats.Center);
                
                
                // Menge
                gfx.DrawString("1", font, XBrushes.Black, new XRect(20, -25, page1.Width, page1.Height), XStringFormats.Center);
                gfx.DrawString("2", font, XBrushes.Black, new XRect(20, -10, page1.Width, page1.Height), XStringFormats.Center);
                gfx.DrawString("3", font, XBrushes.Black, new XRect(20, 5, page1.Width, page1.Height), XStringFormats.Center);
                gfx.DrawString("4", font, XBrushes.Black, new XRect(20, 20, page1.Width, page1.Height), XStringFormats.Center);
                gfx.DrawString("5", font, XBrushes.Black, new XRect(20, 35, page1.Width, page1.Height), XStringFormats.Center);   
                gfx.DrawString("6", font, XBrushes.Black, new XRect(20, 50, page1.Width, page1.Height), XStringFormats.Center);
                gfx.DrawString("7", font, XBrushes.Black, new XRect(20, 65, page1.Width, page1.Height), XStringFormats.Center);
                gfx.DrawString("8", font, XBrushes.Black, new XRect(20, 80, page1.Width, page1.Height), XStringFormats.Center); 
                gfx.DrawString("9", font, XBrushes.Black, new XRect(20, 95, page1.Width, page1.Height), XStringFormats.Center);
                gfx.DrawString("10",font, XBrushes.Black, new XRect(20, 110, page1.Width, page1.Height), XStringFormats.Center);  
                
                
            }
           
            outputDocument.Save("C:\\Users\\Lauritz Abel\\Desktop\\TestPDF\\Output.pdf");
        }
    }
}
           