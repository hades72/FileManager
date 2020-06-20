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

namespace FileManager.Views
{
    public partial class listViewThumb : UserControl
    {
        List<FileM> fileM;
        public listViewThumb()
        {
            InitializeComponent();
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
        private void listViewThumb_DoubleClick(object sender, EventArgs e)
        {
            frmRead read = new frmRead(ref fileM, int.Parse(this.FileCode));
            read.Text = this.Title;
            read.Show();
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
            read.Show();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            frmRead read = new frmRead(ref fileM, int.Parse(this.FileCode));
            read.Text = this.Title;
            read.Show();
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {
            frmRead read = new frmRead(ref fileM, int.Parse(this.FileCode));
            read.Text = this.Title;
            read.Show();
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void label3_DoubleClick(object sender, EventArgs e)
        {
            frmRead read = new frmRead(ref fileM, int.Parse(this.FileCode));
            read.Text = this.Title;
            read.Show();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void label4_DoubleClick(object sender, EventArgs e)
        {
            frmRead read = new frmRead(ref fileM, int.Parse(this.FileCode));
            read.Text = this.Title;
            read.Show();
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void lbNgayDocGanNhat_DoubleClick(object sender, EventArgs e)
        {
            frmRead read = new frmRead(ref fileM, int.Parse(this.FileCode));
            read.Text = this.Title;
            read.Show();
        }

        private void lbNgayDocGanNhat_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void lbNgayDocGanNhat_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void lbID_DoubleClick(object sender, EventArgs e)
        {
            frmRead read = new frmRead(ref fileM, int.Parse(this.FileCode));
            read.Text = this.Title;
            read.Show();
        }

        private void lbID_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void lbID_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void lbTenFile_DoubleClick(object sender, EventArgs e)
        {
            frmRead read = new frmRead(ref fileM, int.Parse(this.FileCode));
            read.Text = this.Title;
            read.Show();
        }

        private void lbTenFile_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void lbTenFile_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void lbTheLoai_DoubleClick(object sender, EventArgs e)
        {
            frmRead read = new frmRead(ref fileM, int.Parse(this.FileCode));
            read.Text = this.Title;
            read.Show();
        }

        private void lbTheLoai_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void lbTheLoai_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void listViewThumb_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DetailTable detail = new DetailTable();
                detail.Show();
            }                
        }
    }
}
