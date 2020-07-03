using FileManager.Controllers;
using FileManager.Models;
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

namespace FileManager.Views
{
    public partial class frmAddReadIndex : Form
    {
        public bool save = false;
        List<int> selected = new List<int>();

        public frmAddReadIndex(ref List<FileM> fileMs)
        {
            InitializeComponent();
            List<FileM> lF = new List<FileM>();
            lF = FileController.getListFile();
            foreach (var f in lF)
            {
                this.cbCurrentFile.Items.Add(f.sTitle);
            }
            this.cbReadPreview.Enabled = false;
        }

        private void frmAddReadIndex_Load(object sender, EventArgs e)
        {
            this.helpProvider1.SetShowHelp(this.cbCurrentFile, true);
            this.helpProvider1.SetHelpString(this.cbCurrentFile, "Chon file ban muon thiet lap thu tu doc file");
            this.helpProvider1.SetShowHelp(this.cbReadPreview, true);
            this.helpProvider1.SetHelpString(this.cbReadPreview, "Chon file can doc truoc cho file hien tai");
            this.helpProvider1.SetShowHelp(this.rtbShowFileReadPreview, true);
            this.helpProvider1.SetHelpString(this.rtbShowFileReadPreview, "Noi hien thi file can doc truoc cho file hien tai");
        }

        private void cbCurrentFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentFile = this.cbCurrentFile.SelectedItem.ToString();
            this.cbReadPreview.SelectedIndex = -1;
            this.cbReadPreview.Items.Clear();
            this.cbReadPreview.Enabled = true;


            List<FileM> lF = new List<FileM>();
            lF = FileController.getListFile();
            foreach (var c in lF)
            {
                this.cbReadPreview.Items.Add(c.sTitle);
            }
            foreach (var f in lF)
            {
                
                if (currentFile == f.sTitle)
                {
                    this.cbReadPreview.Items.Remove(f.sTitle);
                    if (f.sFilePreview is null)
                    {
                        this.rtbShowFileReadPreview.Text = "";
                    }
                    else
                    {
                        string[] a = f.sFilePreview.Split(',');
                        foreach (var obj in a)
                        {
                            this.cbReadPreview.Items.Remove(obj.Trim());
                        }
                        this.rtbShowFileReadPreview.Text = f.sFilePreview;
                    }
                }
                else
                {

                }
            }
        }

        // Thêm File cần đọc trước
        private void btnAddReadPreview_Click(object sender, EventArgs e)
        {
            if (checkError() == true)
            {
                return;
            }
            if (rtbShowFileReadPreview.Text.Length <= 0) 
            {
                this.rtbShowFileReadPreview.Text = this.cbReadPreview.SelectedItem.ToString();
            }
            else
            {
                this.rtbShowFileReadPreview.Text += ", " + this.cbReadPreview.SelectedItem.ToString();
            }
            this.cbReadPreview.Text = "";
            this.cbReadPreview.Items.RemoveAt(this.cbReadPreview.SelectedIndex);
            this.cbReadPreview.SelectedIndex = -1;
        }

        // Kiểm tra lỗi chưa chọn File
        private bool checkError()
        {
            if (this.cbReadPreview.Text.Length <= 0)
            {
                MessageBox.Show("Chưa chọn File!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            if (this.cbCurrentFile.Text.Length <= 0)
            {
                MessageBox.Show("Chưa chọn File!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        // Lưu thứ tự đọc File
        private void btnSaveReadIndex_Click(object sender, EventArgs e)
        {
            List<FileM> lF = new List<FileM>();
            lF = FileController.getListFile();
            foreach (var f in lF)
            {
                if (f.sTitle == this.cbCurrentFile.SelectedItem.ToString()) // Nếu tên file trong danh sách file bằng với file hiện tại người dùng chọn
                {
                    FileM file = new FileM(); // Khởi tạo object file của lớp FileM và gán các giá trị của file hiện tại người dùng chọn vào object file
                    file.iFileCode = f.iFileCode; 
                    file.iRead = f.iRead; 
                    file.sCategory = f.sCategory;
                    file.sFilePreview = this.rtbShowFileReadPreview.Text; // Gán file cần đọc trước do người dùng chọn vào sFilePreview
                    file.sLinkFile = f.sLinkFile;
                    file.sLinkPic = f.sLinkPic;
                    file.sTitle = f.sTitle;
                    file.sNote = f.sNote;
                    file.dtDateUpdate = f.dtDateUpdate;
                    file.dtRecentlyRead = f.dtRecentlyRead;
                    FileController.updateFile(file); // Xử lý yêu cầu cập nhật lại file trong database
                    MessageBox.Show("Lưu thành công!"); // Thông báo cho người dùng.
                    // Gán về giá trị ban đầu là ""
                    this.cbCurrentFile.Text = ""; 
                    this.rtbShowFileReadPreview.Text = "";
                }
            }
        }

        // Đóng form 
        private void frmReadIndex_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.save = true;
        }

        private void btnDeleteReadIndex_Click(object sender, EventArgs e)
        {
            this.rtbShowFileReadPreview.Text = "";
        }

        
    }
}
