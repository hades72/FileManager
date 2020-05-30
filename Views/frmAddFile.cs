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
using FileManager.Models;
using Path = System.IO.Path;

namespace FileManager.Views
{
    public partial class frmAddFile : Form
    {
        OpenFileDialog openFile = new OpenFileDialog();
        SaveFileDialog saveLinkFile = new SaveFileDialog();
        OpenFileDialog openIMG = new OpenFileDialog();
        bool clickPicUpload;
        string pathOriginalIMG;
        public frmAddFile()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized; // Full màn hình
        }

        private void frmAddFile_Load(object sender, EventArgs e)
        {
            pathOriginalIMG = @"E:\TienGiang\Năm 2 - Kỳ 2\Lập trình trên Windows\FileManager\Pictures\OriginalIMG.jpg";
            this.picUpload.Image = new Bitmap(pathOriginalIMG);
            clickPicUpload = false;
            
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (this.txtLinkFolder.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Chưa tải file lên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileM file = new FileM();
            file.iID += 1;
            file.sTitle = this.txtTitle.Text.Trim();
            file.sCategory = this.txtCategory.Text.Trim();
            file.sNote = this.rtbNote.Text.Trim();
            file.dtUpdateDay = DateTime.Now.Date;
            // Lưu picUpload
            if(clickPicUpload == true)
            {
                File.Copy(openIMG.FileName, Path.Combine(@"E:\TienGiang\Năm 2 - Kỳ 2\Lập trình trên Windows\FileManager\Pictures\", Path.GetFileName(file.sTitle + Path.GetExtension(openIMG.FileName))));
            }
            else
            {
                File.Copy(pathOriginalIMG, Path.Combine(@"E:\TienGiang\Năm 2 - Kỳ 2\Lập trình trên Windows\FileManager\Pictures\", Path.GetFileName(file.sTitle + Path.GetExtension(pathOriginalIMG))));
            }
            // Lưu file
            File.Copy(openFile.FileName, Path.Combine(@"E:\TienGiang\Năm 2 - Kỳ 2\Lập trình trên Windows\FileManager\Documents\", Path.GetFileName(file.sTitle + Path.GetExtension(openFile.FileName))));
            file.sLinkFile = Path.Combine(@"E:\TienGiang\Năm 2 - Kỳ 2\Lập trình trên Windows\FileManager\Documents\", Path.GetFileName(file.sTitle + Path.GetExtension(openFile.FileName)));
            // Thông báo save thành công (test)
            MessageBox.Show("Đã lưu!", "Thông báo");
            // Sau khi save thì quay về mặc định
            this.txtTitle.Clear();
            this.txtCategory.Clear();
            this.rtbNote.Clear();
            this.rtbPreview.Clear();
            this.txtLinkFolder.Clear();
            this.picUpload.Image = new Bitmap(pathOriginalIMG);
            clickPicUpload = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtTitle.Clear();
            this.txtCategory.Clear();
            this.rtbNote.Clear();
            this.rtbPreview.Clear();
            this.txtLinkFolder.Clear();
            this.picUpload.Image = new Bitmap(pathOriginalIMG);
            clickPicUpload = false;
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            this.openFile.RestoreDirectory = true;
            this.openFile.FileName = string.Empty;
            this.openFile.Filter = "Pdf Files (.pdf)|*.pdf|All Files (*.*)|*.*";
            this.openFile.FilterIndex = 1;
            this.openFile.Multiselect = false;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                this.txtLinkFolder.Text = openFile.FileName;
                this.txtTitle.Text = Path.GetFileNameWithoutExtension(openFile.FileName); // Lấy tên file không có đuôi file
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
                picUpload.Image = new Bitmap(openIMG.FileName);
                //picUpload.Image = System.Drawing.Image.FromFile(this.openIMG.FileName);
                picUpload.SizeMode = PictureBoxSizeMode.StretchImage;
                clickPicUpload = true;
            }
        }

        
    }
}
