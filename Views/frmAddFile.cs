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
        List<int> selected = new List<int>();
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
            if (this.cbCategory.SelectedIndex == -1)
            {
                this.btnAddCategory.Enabled = false;
            }
            List<Category> lctg = new List<Category>();
            lctg = CategoryController.getListCategory();
            foreach (var c in lctg)
            {
                this.cbCategory.Items.Add(c.sCategoryName);
            }

        }

        private void frmAddFile_Load(object sender, EventArgs e)
        {
            pathOriginalIMG = "..//..//Pictures//OriginalIMG.jpg";
            this.picUpload.Image = new Bitmap(pathOriginalIMG);
            clickPicUpload = false;
               
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            checkError();
            if (error == false)
            {
                FileM file = new FileM();
                file.iFileCode = FileController.getFileCodeFromDB();
                file.sTitle = this.txtTitle.Text.Trim();
                if (category == "")
                {
                    //file.sCategory = this.cbCategory.GetItemText(this.cbCategory.SelectedItem);
                    MessageBox.Show("Chưa chọn thể loại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error = true;
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

        private void frmAddFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            //checkError();
            // nếu có lỗi thì cancel , save = 
            if (error == true)
            {
                error = false;
                e.Cancel = true;
            }
            else if (error == false && save == true)
            {
                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else if (txtTitle != null || txtCurrentCategory != null || txtLinkFolder != null)
            {
                if (MessageBox.Show("Bạn có chắc chắn đóng không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                    e.Cancel = true;
            }
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
           
            if (selected.Count == 0)
            {
                category = this.cbCategory.SelectedItem.ToString();
                selected.Add(this.cbCategory.SelectedIndex);
                this.txtCurrentCategory.Text = category;
            }
            else
            {
                if (checkSelected(this.cbCategory.SelectedIndex))
                {
                    category = category + ", " + this.cbCategory.SelectedItem.ToString();
                    selected.Add(this.cbCategory.SelectedIndex);
                    this.txtCurrentCategory.Text = category;
                }
                else
                {
                    MessageBox.Show("Giang đẹp trai !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool checkSelected(int number)
        {

            for (int i = 0; i < selected.Count; i++)
            {
                if (selected[i] == number)
                {
                    return false;
                }
            }
            return true;
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            this.txtCurrentCategory.Clear();
            category = "";
            selected.Clear();
        }

        private void txtCurrentCategory_TextChanged(object sender, EventArgs e)
        {
            if(txtCurrentCategory.Text.Length > 0)
            {
                this.btnRemoveCategory.Enabled = true;
            }
            else
            {
                this.btnRemoveCategory.Enabled = false;
            }
        }

        

        private void checkError()
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
            List<FileM> lF = new List<FileM>();
            lF = FileController.getListFile();
            foreach (var f in lF)
            {
                if (f.sTitle == txtTitle.Text.Trim())
                {
                    MessageBox.Show("Tên file vừa nhập đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error = true;
                }
            }
            if (this.txtCurrentCategory.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Chưa chọn thể loại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            if (this.txtFileCode.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Chưa nhập mã số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbCategory.SelectedIndex != -1)
            {
                this.btnAddCategory.Enabled = true;
                return;
            }
        }
    }
}
