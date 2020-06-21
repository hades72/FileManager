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
using FileManager.Controllers;

namespace FileManager.Views
{
    public partial class frmAddFile : Form
    {
        OpenFileDialog openFile = new OpenFileDialog();
        SaveFileDialog saveLinkFile = new SaveFileDialog();
        OpenFileDialog openIMG = new OpenFileDialog();
        List<FileM> listFileM;
        private bool clickPicUpload;
        private string pathOriginalIMG;
        private string category = "";
        public bool save = false;
        private bool error = false;

        public frmAddFile(ref List<FileM> listfilems)
        {
            InitializeComponent();
            this.listFileM = listfilems;
            this.txtFileCode.Text = FileController.getFileCodeFromDB().ToString();
            WindowState = FormWindowState.Maximized; // Full màn hình
        }

        private void frmAddFile_Load(object sender, EventArgs e)
        {
            pathOriginalIMG = "..//..//Pictures//OriginalIMG.jpg";
            this.picUpload.Image = new Bitmap(pathOriginalIMG);
            clickPicUpload = false;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (this.txtLinkFolder.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Chưa tải file lên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            if (this.txtTitle.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Chưa nhập tiêu đề!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            if (this.cbCategory.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Chưa chọn thể loại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            if (this.txtFileCode.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Chưa nhập mã số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            if (error == false)
            {
                FileM file = new FileM();
                file.iFileCode = FileController.getFileCodeFromDB();
                file.sTitle = this.txtTitle.Text.Trim();
                if (category == "")
                {
                    file.sCategory = this.cbCategory.GetItemText(this.cbCategory.SelectedItem);
                }
                else
                {
                    file.sCategory = category;
                }
                file.dtDateUpdate = DateTime.Now.Date;
                file.iRead = 0; // chưa đọc
                file.dtRecentlyRead = null; // chưa đọc
                if (clickPicUpload == true)
                {
                    file.sLinkPic = openIMG.FileName;  // gán vào linkPic trong list FileM

                }
                else
                {
                    file.sLinkPic = pathOriginalIMG;
                }
                // Lưu link file
                file.sLinkFile = openFile.FileName; // gán vào linkFile trong list FileM
                save = true;
                if (FileController.AddFile(file) == false) // thêm file vào csdl
                {
                    error = true;
                    save = false;
                }
            }
            this.Close();
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            this.openFile.RestoreDirectory = true;
            this.openFile.FileName = string.Empty;
            this.openFile.Filter = "PDF Files|*.pdf|Text Document|*.txt|All Files|*.*";
            this.openFile.FilterIndex = 1;
            this.openFile.Multiselect = false;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                this.txtLinkFolder.Text = openFile.FileName;
                this.txtTitle.Text = Path.GetFileNameWithoutExtension(openFile.FileName); // Lấy tên file không có đuôi file

                if (Path.GetExtension(openFile.FileName) == ".pdf")
                {
                    using (PdfReader reader = new PdfReader(openFile.FileName))
                    {
                        // hiện các dòng trang đầu tiên để xem trước
                        LocationTextExtractionStrategy strategy = new LocationTextExtractionStrategy();
                        string line = PdfTextExtractor.GetTextFromPage(reader, 1, strategy);
                        //line = Encoding.UTF8.GetString(
                        //        Encoding.Convert(
                        //        Encoding.Default,
                        //        Encoding.UTF8,
                        //        Encoding.Default.GetBytes(line)));
                        this.rtbPreview.Text += line;
                    }
                }

                if (Path.GetExtension(openFile.FileName) == ".txt")
                {
                    using (FileStream fs = new FileStream(openFile.FileName, FileMode.Open))
                    {
                        StreamReader rd = new StreamReader(fs, Encoding.Unicode);
                        this.rtbPreview.Text = rd.ReadToEnd();
                    }
                }

            }
        }

        private void btnDuongDan_Click(object sender, EventArgs e) 
            // Chọn đường dẫn để lưu file ở Folder khác, nếu thích
        {
            this.saveLinkFile.Filter = "PDF Files|*.pdf|All Files|*.*";
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
            this.openIMG.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|All Files|*.*";
            this.openIMG.FilterIndex = 1;
            this.openIMG.Multiselect = false;
            if (this.openIMG.ShowDialog() == DialogResult.OK)
            {
                // Xử lí Tải ảnh bìa ở đây
                this.picUpload.Image = new Bitmap(openIMG.FileName);
                this.picUpload.SizeMode = PictureBoxSizeMode.StretchImage;
                this.clickPicUpload = true;
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if(category == "")
            {
                category = this.cbCategory.GetItemText(this.cbCategory.SelectedItem);
            }
            else
            {
                category = category +", "+ this.cbCategory.GetItemText(this.cbCategory.SelectedItem);
            }
        }

        private void frmAddFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(error == true)
            {
                error = false;
                e.Cancel = true;
            }
            else
            {
                save = true;
                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
