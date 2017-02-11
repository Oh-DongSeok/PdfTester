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
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace PdfLibTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pdfSaveFileDialog.Filter = "PDF File|*.pdf";
            pdfSaveFileDialog.Title = "Save an PDF File";
            pdfSaveFileDialog.ShowDialog();
            if(pdfSaveFileDialog.FileName != "")
            {
                PdfWriter writer = new PdfWriter(pdfSaveFileDialog.FileName);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);
                document.Add(new Paragraph(textBox1.Text));
                document.Close();
            }
        }
    }
}
