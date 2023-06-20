﻿using System;
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
                for (int i = 0; i < 11; i++)
                {
                    gfx.DrawString("Position"+i.ToString(), font, XBrushes.Black, new XRect(page1.Width/12, -490+(i*15), page1.Width, page1.Height), XStringFormats.BottomLeft);
                }
                
               
                
                
                
                
                MessageBox.Show("PDF wurde erstellt");
              

            }
           
            outputDocument.Save("C:\\Users\\Lauritz Abel\\Desktop\\TestPDF\\Output.pdf");
        }
    }
}
           