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
        List<FileM> fileM;
        BindingSource source = new BindingSource();

        public frmManager(ref List<FileM> fileM)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.cFileCode.DataPropertyName = nameof(FileM.iFileCode);
            this.cTitle.DataPropertyName = nameof(FileM.sTitle);
            this.cCategory.DataPropertyName = nameof(FileM.sCategory);
            this.cDateUpdate.DataPropertyName = nameof(FileM.dtDateUpdate);
            this.cRecentlyRead.DataPropertyName = nameof(FileM.dtRecentlyRead);
            // Hiển thị lên Data Grid View
            
            source.DataSource = FileController.getListUsers();
            dataFileM.DataSource = source;
            
            // Ẩn cột Ghi chú, Link Pic, Link File, Read
            this.dataFileM.Columns[5].Visible = false;
            this.dataFileM.Columns[6].Visible = false;
            this.dataFileM.Columns[7].Visible = false;
            this.dataFileM.Columns[8].Visible = false;

            // Chưa chọn file đọc
            if(this.dataFileM.RowCount <= 0)
            {
                btnReadFile.Enabled = false;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.helpProvider1.SetShowHelp(this.txtSearch, true);
            this.helpProvider1.SetHelpString(this.txtSearch, "Nhap ma so hoac ten file ban muon tim");
            if (this.dataFileM.RowCount <= 0)
            {
                btnReadFile.Enabled = false;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddFileToolStripMenuItem_Click(object sender, EventArgs e) // Thêm file
        {
            frmAddFile frmAdd = new frmAddFile(ref fileM);
            frmAdd.ShowDialog();
            if (frmAdd.AcceptButton.DialogResult == DialogResult.OK)
            {
                // Cập nhật lại Data Grid View
                //BindingSource source = new BindingSource();
                source.DataSource = FileController.getListUsers();
                dataFileM.DataSource = source;
            }
        }

        private void dataFileM_CellContentClick(object sender, DataGridViewCellEventArgs e) // Xóa file
        {
            //if(e.RowIndex == this.dataFileM.CurrentCell.RowIndex)
            if(this.dataFileM.Columns[e.ColumnIndex].Name == "cDelete")
            {
                if(MessageBox.Show("Bạn chắc chắn xóa file này?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FileM file = FileController.getFileM(int.Parse(this.dataFileM.Rows[e.RowIndex].Cells[1].Value.ToString()));
                    FileController.DeleteFile(file);
                }    
                // Cập nhật lại Data Grid View
                //BindingSource source = new BindingSource();
                source.DataSource = FileController.getListUsers();
                dataFileM.DataSource = source;
            }  
        }

        private void btnSearch_Click(object sender, EventArgs e) // Tìm kiếm tên file hoặc thể loại
        {
            //BindingSource source = new BindingSource();
            if (this.txtSearch.Text.Length <= 0)
            {
                MessageBox.Show("Chưa điền mã số hoặc tên File!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                source.DataSource = FileController.getListUsers();
            }
            else
            {
                source.DataSource = FileController.SearchFile(this.txtSearch.Text.Trim());
                if (source.DataSource == null)
                {
                    MessageBox.Show("Không có tên file cần tìm!", "Thông báo", MessageBoxButtons.OK);
                    source.DataSource = FileController.getListUsers();
                }
            }
            dataFileM.DataSource = source;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (this.txtSearch.Text.Length <= 0)
            {
                //BindingSource source = new BindingSource();
                source.DataSource = FileController.getListUsers();
                dataFileM.DataSource = source;
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e) // Mở đọc file
        {
            frmRead read = new frmRead(ref fileM, int.Parse(this.dataFileM.CurrentRow.Cells[1].Value.ToString()));
            read.Text = this.dataFileM.CurrentRow.Cells[2].Value.ToString();
            read.Show();
        }

        private void dataFileM_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.btnReadFile.Enabled = true;
        }

        private void dataFileM_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.btnReadFile.Enabled = false;
        }
    }
}
