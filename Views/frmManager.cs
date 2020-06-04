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
        List<FileM> listFileM;
        
        public frmManager(ref List<FileM> fileM)
        {
            InitializeComponent();
            this.listFileM = fileM;
            this.cID.DataPropertyName = nameof(FileM.iID);
            this.cTitle.DataPropertyName = nameof(FileM.sTitle);
            this.cNotes.DataPropertyName = nameof(FileM.sNote);
            this.cCategory.DataPropertyName = nameof(FileM.sCategory);
            this.cDateUpdate.DataPropertyName = nameof(FileM.dtDateUpdate);

            // Hiển thị lên Data Grid View
            BindingSource source = new BindingSource();
            source.DataSource = listFileM;
            dataFileM.DataSource = source;
            
            // Ẩn cột Ghi chú, Link Pic, Link File
            this.dataFileM.Columns[4].Visible = true;
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
            //string searchValue = txtSearch.Text;

            //dataFileM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //try
            //{
            //    foreach (DataGridViewRow row in dataFileM.Rows)
            //    {
            //        if (row.Cells[1].Value.ToString().Equals(searchValue)) // Tìm tên file
            //        {
            //            row.Selected = true;
            //            break;
            //        }
            //    }
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show(exc.Message);
            //}
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thêmFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddFile frmAdd = new frmAddFile(ref listFileM);
            frmAdd.ShowDialog();
            if(frmAdd.AcceptButton.DialogResult == DialogResult.OK)
            {
                // Cập nhật lại Data Grid View
                BindingSource source = new BindingSource();
                source.DataSource = listFileM;
                dataFileM.DataSource = source;
            }
            
        }
    }
}
