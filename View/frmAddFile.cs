using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
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

namespace FileManager.frmFolder
{
    public partial class frmAddFile : Form
    {
        OpenFileDialog openFile = new OpenFileDialog();
        public frmAddFile()
        {
            InitializeComponent();
            btnUploadFile.Click += btnUploadFile_Click;
            Load += frmAddFile_Load;
        }

        private void frmAddFile_Load(object sender, EventArgs e)
        {
            this.openFile.RestoreDirectory = true;
            this.openFile.FileName = string.Empty;
            this.openFile.Filter = "Pdf Files (.pdf)|*.pdf|All Files (*.*)|*.*";
            this.openFile.FilterIndex = 1;
            this.openFile.Multiselect = false;
        }

        private void bSave_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                txtTitle.Text = openFile.FileName;
                txtCategory.Clear();
                rtbSummary.Clear();
                rtbNote.Clear();

                using (PdfReader reader = new PdfReader(openFile.FileName))
                {
                    // chọn vài dòng đầu trong trang đầu tiên
                    LocationTextExtractionStrategy strategy = new LocationTextExtractionStrategy();
                    string line = PdfTextExtractor.GetTextFromPage(reader, 1);
                    line = Encoding.UTF8.GetString(
                            Encoding.Convert(
                            Encoding.Default,
                            Encoding.UTF8,
                            Encoding.Default.GetBytes(line)));
                    rtbSummary.Text += line;
                }
            }
        }

        
    }
}
