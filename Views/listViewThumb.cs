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



        #endregion

        private void listViewThumb_DoubleClick(object sender, EventArgs e)
        { 
        //    frmRead read = new frmRead(ref fileM, int.Parse(ID));
        //    read.Text = NameFile;
        //    read.Show();
        }
    }
}
