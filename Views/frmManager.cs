using FileManager.Controllers;
using FileManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager.Views
{
    public partial class frmManager : Form
    {
        //List<FileM> listFileM;
        List<FileM> fileM;
        public frmManager(ref List<FileM> fileM)
        {
            InitializeComponent();
            //this.listFileM = fileM;
            this.cFileCode.DataPropertyName = nameof(FileM.sFileCode);
            this.cTitle.DataPropertyName = nameof(FileM.sTitle);
            this.cCategory.DataPropertyName = nameof(FileM.sCategory);
            this.cDateUpdate.DataPropertyName = nameof(FileM.dtDateUpdate);

            // Hiển thị lên Data Grid View
            BindingSource source = new BindingSource();
            source.DataSource = FileController.getListUsers();
            dataFileM.DataSource = source;
            
            // Ẩn cột Ghi chú, Link Pic, Link File
            this.dataFileM.Columns[4].Visible = false;
            this.dataFileM.Columns[5].Visible = false;
            this.dataFileM.Columns[6].Visible = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.helpProvider1.SetShowHelp(this.txtSearch, true);
            this.helpProvider1.SetHelpString(this.txtSearch, "Nhap ten file ban muon tim");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thêmFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddFile frmAdd = new frmAddFile(ref fileM);
            frmAdd.ShowDialog();
            if(frmAdd.AcceptButton.DialogResult == DialogResult.OK)
            {
                // Cập nhật lại Data Grid View
                BindingSource source = new BindingSource();
                source.DataSource = FileController.getListUsers();
                dataFileM.DataSource = source;
            }
        }
    }
}
