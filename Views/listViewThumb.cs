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

        private string _namefile;
        private string _theloai;
        private string _id;
        private string _dateread;
        private string _text;
        private string _note;
        private string _linkfile;

        [Category("File Props")]
        public string NameFile
        {
            get { return _namefile; }
            set { _namefile = value; lbTenFile.Text = value; }
        }

        [Category("File Props")]
        public string TheLoai
        {
            get { return _theloai; }
            set { _theloai = value; lbTheLoai.Text = value; }
        }
        [Category("File Props")]
        public string ID
        {
            get { return _id; }
            set { _id = value; lbID.Text = value; }
        }

        [Category("File Props")]
        public string DateRead
        {
            get { return _dateread; }
            set { _dateread = value; lbNgayDocGanNhat.Text = value; }
        }

        [Category("File Props")]
        public PictureBox PictureFile
        {
            get { return picFile; }
            set { picFile = value; }
        }

        [Category("File Props")]
        public string Text
        {
            get { return _text; }
            set { _text = value; }
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
            frmRead read = new frmRead(ref fileM, int.Parse(this.ID));
            read.Text = this.Text;
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
            frmRead read = new frmRead(ref fileM, int.Parse(this.ID));
            read.Text = this.Text;
            read.Show();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            frmRead read = new frmRead(ref fileM, int.Parse(this.ID));
            read.Text = this.Text;
            read.Show();
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {
            frmRead read = new frmRead(ref fileM, int.Parse(this.ID));
            read.Text = this.Text;
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
            frmRead read = new frmRead(ref fileM, int.Parse(this.ID));
            read.Text = this.Text;
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
            frmRead read = new frmRead(ref fileM, int.Parse(this.ID));
            read.Text = this.Text;
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
            frmRead read = new frmRead(ref fileM, int.Parse(this.ID));
            read.Text = this.Text;
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
            frmRead read = new frmRead(ref fileM, int.Parse(this.ID));
            read.Text = this.Text;
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
            frmRead read = new frmRead(ref fileM, int.Parse(this.ID));
            read.Text = this.Text;
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
            frmRead read = new frmRead(ref fileM, int.Parse(this.ID));
            read.Text = this.Text;
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
    }
}
