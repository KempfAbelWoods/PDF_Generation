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
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Diagnostics;

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

            MessageBox.Show("hallo3"); 
            Trace.WriteLine("hallo");
            Console.Write("ichbindumm");
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            PdfDocument document = new PdfDocument();

            PdfPage page = document.AddPage();

            XGraphics gfx = XGraphics.FromPdfPage(page);

            XFont font = new XFont("Arial",20);

            gfx.DrawString("Es funktioniert", font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height),
                XStringFormats.Center);

            document.Save("C:\\Users\\Lauritz Abel\\Desktop\\HalloLauritz.pdf"); 
            
            Console.Write("ichbindumm");
        }
    }
}