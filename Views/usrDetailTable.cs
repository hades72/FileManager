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
    public partial class usrDetailTable : UserControl
    {
        List<FileM> fileM;
 
        public usrDetailTable()
        {
            InitializeComponent();
        }

        private string _title;
        private string _filecode;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string FileCode
        {
            get { return _filecode; }
            set { _filecode = value; }
        }

        private void btRead_MouseEnter(object sender, EventArgs e)
        {
            btRead.BackColor = Color.AliceBlue;
        }

        private void btRead_MouseLeave(object sender, EventArgs e)
        {
            btRead.BackColor = Color.White;
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            frmRead read = new frmRead(ref fileM, int.Parse(this.FileCode));
            read.Text = this.Title;
            read.Show();
        }

        private void btDelete_MouseEnter(object sender, EventArgs e)
        {
            btDelete.BackColor = Color.AliceBlue;
        }

        private void btDelete_MouseLeave(object sender, EventArgs e)
        {
            btDelete.BackColor = Color.White;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {

        }

        private void btProperties_MouseEnter(object sender, EventArgs e)
        {
            btProperties.BackColor = Color.AliceBlue;
        }

        private void btProperties_MouseLeave(object sender, EventArgs e)
        {
            btProperties.BackColor = Color.White;
        }

        private void btProperties_Click(object sender, EventArgs e)
        {

        }

       
    }
}
