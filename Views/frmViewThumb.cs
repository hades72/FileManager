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
using FileManager.Controllers;
using FileManager.Models;

namespace FileManager.Views
{
    public partial class frmViewThumb : Form
    {
        List<FileM> fileM;
        BindingSource source = new BindingSource();
        Graphics G = null;
        public frmViewThumb(ref List<FileM> fileM)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.cFileCode.DataPropertyName = nameof(FileM.iFileCode);
            this.cTitle.DataPropertyName = nameof(FileM.sTitle);
            this.cCategory.DataPropertyName = nameof(FileM.sCategory);
            this.cDateUpdate.DataPropertyName = nameof(FileM.dtDateUpdate);
            this.cRecentlyRead.DataPropertyName = nameof(FileM.dtRecentlyRead);
            // Hiển thị lên Data Grid View

            source.DataSource = FileController.getListFile();
            dataFileM.DataSource = source;

            // Ẩn cột Ghi chú, Link Pic, Link File, Read
            this.dataFileM.Columns[5].Visible = false;
            this.dataFileM.Columns[6].Visible = false;
            this.dataFileM.Columns[7].Visible = false;
            this.dataFileM.Columns[8].Visible = false;

            if (flpnlThumb.Controls.Count > 0)
            {
                flpnlThumb.Controls.Clear();
            }

            showThumb();

            if (tabView.SelectedTab == tabDataGV)
            {
                btnReadFile.Visible = true;
            }
            if (tabView.SelectedTab == tabThumb)
            {
                btnReadFile.Visible = false;
            }
        }

        private void showThumb()
        {
            if (flpnlThumb.Controls.Count > 0)
            {
                flpnlThumb.Controls.Clear();
            }
            for (int i = 1; i <= FileController.getListFile().Count; i++)
            {
                listViewThumb listView1 = new listViewThumb();
                FileM file = FileController.getFileM(i);
                listView1.Title = file.sTitle;
                listView1.Category = file.sCategory;
                listView1.FileCode = file.iFileCode.ToString();
                listView1.RecentlyRead = file.dtRecentlyRead.ToString();
                listView1.Note = file.sNote;
                listView1.LinkFile = file.sLinkFile;
                using (FileStream stream = new FileStream(String.Format(file.sLinkPic), FileMode.Open, FileAccess.Read))
                {
                    listView1.PictureFile.Image = Image.FromStream(stream);
                }
                G = Graphics.FromImage(listView1.PictureFile.Image);
                flpnlThumb.Controls.Add(listView1);
            }
        }

        private void frmViewThumb_Load(object sender, EventArgs e)
        {
            this.helpProvider1.SetShowHelp(this.txtSearch, true);
            this.helpProvider1.SetHelpString(this.txtSearch, "Nhap ma so hoac ten file ban muon tim");
            
            if (this.dataFileM.RowCount <= 0)
            {
                btnReadFile.Enabled = false;
            }
        }


        private void tabAddFile_Click(object sender, EventArgs e)
        {
            frmAddFile frmAdd = new frmAddFile(ref fileM);
            frmAdd.ShowDialog();
            if (frmAdd.AcceptButton.DialogResult == DialogResult.OK)
            {
                // Cập nhật lại Data Grid View
                //BindingSource source = new BindingSource();
                source.DataSource = FileController.getListFile();
                dataFileM.DataSource = source;

                showThumb();
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.txtSearch.Text.Length <= 0)
            {
                MessageBox.Show("Chưa điền mã số hoặc tên File!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                source.DataSource = FileController.getListFile();
            }
            else
            {
                source.DataSource = FileController.SearchFile(this.txtSearch.Text.Trim());
                if (source.DataSource == null)
                {
                    MessageBox.Show("Không có tên file cần tìm!", "Thông báo", MessageBoxButtons.OK);
                    source.DataSource = FileController.getListFile();
                }
            }
            dataFileM.DataSource = source;
        }


        private void dataFileM_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.btnReadFile.Enabled = true;
        }

        private void dataFileM_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.btnReadFile.Enabled = false;
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (this.txtSearch.Text.Length <= 0)
            {
                //BindingSource source = new BindingSource();
                source.DataSource = FileController.getListFile();
                dataFileM.DataSource = source;

                showThumb();
            }
        }

        private void btnReadFile_Click_1(object sender, EventArgs e)
        {
            frmRead read = new frmRead(ref fileM, int.Parse(this.dataFileM.CurrentRow.Cells[1].Value.ToString()));
            read.Text = this.dataFileM.CurrentRow.Cells[2].Value.ToString();
            read.Show();

            //lastFile lastfile = new lastFile();
            //lastfile.Name = file.sTitle;
            //lastfile.TheLoai = file.sCategory;
            //lastfile.ID = file.iFileCode.ToString();
            //lastfile.DateReadLast = file.dtRecentlyRead.ToString();
            //lastfile.Text = this.dataFileM.CurrentRow.Cells[2].Value.ToString();
            //lastfile.Note = file.sNote;
            //lastfile.LinkFile = file.sLinkFile;
            //using (FileStream stream = new FileStream(String.Format(file.sLinkPic), FileMode.Open, FileAccess.Read))
            //{
            //    lastfile.PictureLast.Image = Image.FromStream(stream);
            //}
            //G = Graphics.FromImage(lastfile.PictureLast.Image);


        }


        private void dataFileM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(e.RowIndex == this.dataFileM.CurrentCell.RowIndex)
            if (this.dataFileM.Columns[e.ColumnIndex].Name == "cDelete")
            {
                if (MessageBox.Show("Bạn chắc chắn xóa file này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FileM file = FileController.getFileM(int.Parse(this.dataFileM.Rows[e.RowIndex].Cells[1].Value.ToString()));
                    FileController.DeleteFile(file);
                }
                // Cập nhật lại Data Grid View
                //BindingSource source = new BindingSource();
                source.DataSource = FileController.getListFile();
                dataFileM.DataSource = source;
                showThumb();
            }
        }

        private void tabView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabView.SelectedTab == tabView.TabPages["tabThumb"])
            {
                btnReadFile.Visible = false;
            }
            if (tabView.SelectedTab == tabView.TabPages["tabDataGV"])
            {
                btnReadFile.Visible = true;
            }
        }
    }
}
