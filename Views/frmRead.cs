using FileManager.Controllers;
using FileManager.Models;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager.Views
{
    public partial class frmRead : Form
    {
        string linkFile;
        public frmRead(ref List<FileM> fileM, string filecode)
        {
            InitializeComponent();
            FileM file = FileController.getFileM(filecode);
            linkFile = file.sLinkFile;
        }

        private void frmRead_Load(object sender, EventArgs e)
        {
                using (PdfReader reader = new PdfReader(linkFile))
                {
                    // hiện các dòng trang đầu tiên để xem trước
                    LocationTextExtractionStrategy strategy = new LocationTextExtractionStrategy();
                    string line = PdfTextExtractor.GetTextFromPage(reader, 1);
                    line = Encoding.UTF8.GetString(
                            Encoding.Convert(
                            Encoding.Default,
                            Encoding.UTF8,
                            Encoding.Default.GetBytes(line)));
                    this.rtbRead.Text += line;
                }
           
        }
    }
}
