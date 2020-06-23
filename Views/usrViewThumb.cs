using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileManager.Models;
using System.IO;
using FileManager.Controllers;
using System.Diagnostics;

namespace FileManager.Views
{
    public partial class usrViewThumb : UserControl
    {
        List<FileM> fileM;
        //BindingSource source = new BindingSource();
        //DataGridView dataFileM;
        //FlowLayoutPanel flpanel;

        public usrViewThumb()
        {
            InitializeComponent();
            picNewIcon.Parent = picFile;


            // Cập nhật lại Data Grid View
            //BindingSource source = new BindingSource();
            //source.DataSource = FileController.getListFile();
            //dataFileM.DataSource = source;

            //if (flpanel.Controls.Count > 0)
            //{
            //    flpanel.Controls.Clear();
            //}
            //for (int i = 1; i <= FileController.getListFile().Count; i++)
            //{
            //    usrViewThumb listView = new usrViewThumb();
            //    FileM file1 = FileController.getFileM(i);
            //    listView.Title = file1.sTitle;
            //    listView.Category = file1.sCategory;
            //    listView.FileCode = file1.iFileCode.ToString();
            //    listView.RecentlyRead = file1.dtRecentlyRead.ToString();
            //    listView.Note = file1.sNote;
            //    listView.LinkFile = file1.sLinkFile;
            //    using (FileStream stream = new FileStream(String.Format(file1.sLinkPic), FileMode.Open, FileAccess.Read))
            //    {
            //        listView.PictureFile.Image = Image.FromStream(stream);
            //    }
            //    Graphics G = Graphics.FromImage(listView.PictureFile.Image);
            //    flpanel.Controls.Add(listView);
            //}
        }


        #region Properties

        private string _title;
        private string _category;
        private string _filecode;
        private string _recentlyread;
        private string _note;
        private string _linkfile;

        [Category("File Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lbTitle.Text = value; }
        }

        [Category("File Props")]
        public string Category
        {
            get { return _category; }
            set { _category = value; lbCategory.Text = value; }
        }
        [Category("File Props")]
        public string FileCode
        {
            get { return _filecode; }
            set { _filecode = value; lbFileCode.Text = value; }
        }

        [Category("File Props")]
        public string RecentlyRead
        {
            get { return _recentlyread; }
            set { _recentlyread = value; lbRecentlyRead.Text = value; }
        }

        [Category("File Props")]
        public PictureBox PictureFile
        {
            get { return picFile; }
            set { picFile = value; }
        }

        [Category("File Props")]
        public PictureBox PictureNewIcon
        {
            get { return picNewIcon; }
            set { picNewIcon = value; }
        }

        [Category("File Props")]
        public string Note
        {
            get { return _note; }
            set { _note = value; }
        }

        [Category("File Props")]
        public string LinkFile
        {
            get { return _linkfile; }
            set { _linkfile = value; }
        }

        #endregion

        // Đọc file bằng đúp chuột
        #region DoubleClick_MouseEnter_MouseLeave    
        private void listViewThumb_DoubleClick(object sender, EventArgs e)
        {
            frmRead read = new frmRead(ref fileM, int.Parse(this.FileCode));
            read.Text = this.Title;
            read.ShowDialog();
        }

        private void listViewThumb_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void listViewThumb_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }


        private void picFile_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void picFile_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void picFile_DoubleClick(object sender, EventArgs e)
        {
            frmRead read = new frmRead(ref fileM, int.Parse(this.FileCode));
            read.Text = this.Title;
            read.ShowDialog();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void lbNgayDocGanNhat_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void lbNgayDocGanNhat_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void lbID_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void lbID_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void lbTenFile_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void lbTenFile_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void lbTheLoai_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void lbTheLoai_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
        #endregion 

        // Xóa File
        private void toolDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn xóa file này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FileM file = FileController.getFileM(int.Parse(this.FileCode));
                FileController.DeleteFile(file);

                // Cập nhật lại Data Grid View
                //BindingSource source = new BindingSource();
                //source.DataSource = FileController.getListFile();
                //dataFileM.DataSource = source;

                //if (flpanel.Controls.Count > 0)
                //{
                //    flpanel.Controls.Clear();
                //}
                //for (int i = 1; i <= FileController.getListFile().Count; i++)
                //{
                //    usrViewThumb listView = new usrViewThumb();
                //    FileM file1 = FileController.getFileM(i);
                //    listView.Title = file1.sTitle;
                //    listView.Category = file1.sCategory;
                //    listView.FileCode = file1.iFileCode.ToString();
                //    listView.RecentlyRead = file1.dtRecentlyRead.ToString();
                //    listView.Note = file1.sNote;
                //    listView.LinkFile = file1.sLinkFile;
                //    using (FileStream stream = new FileStream(String.Format(file1.sLinkPic), FileMode.Open, FileAccess.Read))
                //    {
                //        listView.PictureFile.Image = Image.FromStream(stream);
                //    }
                //    Graphics G = Graphics.FromImage(listView.PictureFile.Image);
                //    flpanel.Controls.Add(listView);
                //}
            }  
        }

        // Mở chi tiết file
        private void toolProperties_Click(object sender, EventArgs e)
        {
            frmProperties fproperties = new frmProperties(ref fileM , int.Parse(this.FileCode));
            fproperties.ShowDialog();
        }

        // Đọc trực tiếp bằng ứng dụng
        private void toolReadWithReaderriver_Click(object sender, EventArgs e)
        {
            frmRead read = new frmRead(ref fileM, int.Parse(this.FileCode));
            read.Text = this.Title;
            read.ShowDialog();
        }

        // Đọc bằng PDF
        private void toolReadWithPDF_Click(object sender, EventArgs e)
        {
            string target = Path.GetDirectoryName(LinkFile); // Lấy đường dẫn thư mục chứa file đó

            if (Directory.Exists(target))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = LinkFile,
                    FileName = "explorer.exe"
                };
                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show(string.Format("Đường dẫn {0} không tồn tại!", target));
            }
        }

        // Đọc bằng Notepad
        private void toolReadWithNotepad_Click(object sender, EventArgs e)
        {
            string target = Path.GetDirectoryName(LinkFile); // Lấy đường dẫn thư mục chứa file đó
            if (Directory.Exists(target))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = LinkFile,
                    FileName = "explorer.exe"
                };
                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show(string.Format("Đường dẫn {0} không tồn tại!", target));
            }
        }

        // File pdf thì hiện đọc với pdf, txt thì hiện đọc với notepad
        private void toolRead_MouseHover(object sender, EventArgs e)
        {
            if (Path.GetExtension(LinkFile) == ".pdf")
            {
                toolReadWithPDF.Visible = true;
            }
            else toolReadWithPDF.Visible = false;
            if (Path.GetExtension(LinkFile) == ".txt")
            {
                toolReadWithNotepad.Visible = true;
            }
            else toolReadWithNotepad.Visible = false;
        }
    }
}
