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
    public partial class frmReadIndex : Form
    {
        public bool save = false;
        public frmReadIndex(ref List<FileM> fileMs)
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

        private void cbCurrentFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentFile = this.cbCurrentFile.SelectedItem.ToString();
            this.cbReadPreview.SelectedIndex = -1;
            this.cbReadPreview.Items.Clear();
            this.cbReadPreview.Enabled = true;
            
            
            List<FileM> lF = new List<FileM>();
            lF = FileController.getListFile();
            foreach (var f in lF)
            {
                if(f.sTitle != currentFile)
                this.cbReadPreview.Items.Add(f.sTitle);
                if(currentFile == f.sTitle)
                {
                    this.rtbShowFileReadPreview.Text = f.sFilePreview;
                }
            }
            //this.rtbShowFileReadPreview.Clear();
        }

        private void btnAddReadPreview_Click(object sender, EventArgs e)
        {
            if (checkError() == true)

            {
                return;
            }
            if(rtbShowFileReadPreview.Text.Length <= 0)
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
        private bool checkError()
        {
            if (this.cbReadPreview.Text.Length <= 0)
            {
                MessageBox.Show("Chưa chọn File !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            if(this.cbCurrentFile.Text.Length <= 0)
            {
                MessageBox.Show("Chưa chọn File !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void btnSaveReadIndex_Click(object sender, EventArgs e)
        {
            List<FileM> lF = new List<FileM>();
            lF = FileController.getListFile();
            foreach (var f in lF)
            {
                if (f.sTitle == this.cbCurrentFile.SelectedItem.ToString())
                {
                    FileM file = new FileM();
                    file.iFileCode = f.iFileCode;
                    file.iRead = f.iRead;
                    file.sCategory = f.sCategory;
                    file.sFilePreview = this.rtbShowFileReadPreview.Text;
                    file.sLinkFile = f.sLinkFile;
                    file.sLinkPic = f.sLinkPic;
                    file.sTitle = f.sTitle;
                    file.sNote = f.sNote;
                    file.dtDateUpdate = f.dtDateUpdate;
                    file.dtRecentlyRead = f.dtRecentlyRead;
                    FileController.UpdateFile(file);
                    MessageBox.Show("Success");
                    this.cbCurrentFile.Text = "";
                    this.rtbShowFileReadPreview.Text = "";
                    
                }
            }
        }

        private void frmReadIndex_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.save = true;
        }
    }
}
