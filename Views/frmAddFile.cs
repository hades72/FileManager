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
using System;

namespace FileManager.Views
{
    public partial class frmAddFile : Form
    {
        
        SaveFileDialog saveLinkFile = new SaveFileDialog();
        OpenFileDialog openIMG = new OpenFileDialog();

        public frmAddFile()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized; // Full màn hình
        }

        private void frmAddFile_Load(object sender, EventArgs e)
        {
            
        }

        private void bSave_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.RestoreDirectory = true;
            openFile.FileName = string.Empty;
            openFile.Filter = "Pdf Files (.pdf)|*.pdf|All Files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.Multiselect = false;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                this.txtLinkFolder.Text = openFile.FileName;
                this.txtCategory.Clear();
                this.rtbPreview.Clear();
                this.rtbNote.Clear();

                using (PdfReader reader = new PdfReader(openFile.FileName))
                {
                    // hiện các dòng trang đầu tiên để xem trước
                    LocationTextExtractionStrategy strategy = new LocationTextExtractionStrategy();
                    string line = PdfTextExtractor.GetTextFromPage(reader, 1);
                    line = Encoding.UTF8.GetString(
                            Encoding.Convert(
                            Encoding.Default,
                            Encoding.UTF8,
                            Encoding.Default.GetBytes(line)));
                    this.rtbPreview.Text += line;
                }
            }
        }

        private void btnDuongDan_Click(object sender, EventArgs e) 
            // Chọn đường dẫn để lưu file ở Folder khác, nếu thích
        {
            this.saveLinkFile.Filter = "Pdf Files (.pdf)|*.pdf|All Files (*.*)|*.*";
            this.saveLinkFile.Title = "Save a PDF File";
            this.saveLinkFile.FileName = txtTitle.Text;
            if (this.saveLinkFile.ShowDialog() == DialogResult.OK)
            {
                this.txtLinkFolder.Text = this.saveLinkFile.FileName;
            }
        }

        private void btnPicUpload_Click(object sender, EventArgs e)
        {
            this.openIMG.FileName = string.Empty;
            this.openIMG.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            this.openIMG.FilterIndex = 1;
            this.openIMG.Multiselect = false;
            if (this.openIMG.ShowDialog() == DialogResult.OK)
            {
                // Xử lí Tải ảnh bìa ở đây
                picUpload.Image = System.Drawing.Image.FromFile(this.openIMG.FileName);
                picUpload.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }
    }
}
