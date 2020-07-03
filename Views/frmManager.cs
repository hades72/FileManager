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
using System.Data.SqlClient;

namespace FileManager.Views
{
    public partial class frmManager : Form
    {
        List<FileM> fileM;
        List<Category> categories;
        BindingSource source = new BindingSource();
        Graphics G = null;
        private DateTime dtLast = DateTime.MinValue;
        public bool darkmode = false; // ban đầu mặc định là chế độ sáng
        //Ẩn button close
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ClassStyle = param.ClassStyle | 0x200;
                return param;
            }
        }

        public frmManager(ref List<FileM> fileM, List<Category> categories)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.cFileCode.DataPropertyName = nameof(FileM.iFileCode);
            this.cTitle.DataPropertyName = nameof(FileM.sTitle);
            this.cCategory.DataPropertyName = nameof(FileM.sCategory);
            this.cDateUpdate.DataPropertyName = nameof(FileM.dtDateUpdate);
            this.cRecentlyRead.DataPropertyName = nameof(FileM.dtRecentlyRead);
            this.cReadIndex.DataPropertyName = nameof(FileM.sFilePreview);
            dataFileM.AutoGenerateColumns = false;
        }

      

        private void frmManager_Load(object sender, EventArgs e)
        {
            this.helpProvider1.SetShowHelp(this.txtSearch, true);
            this.helpProvider1.SetHelpString(this.txtSearch, "Nhap ten file ban muon tim");
            if (tabView.SelectedTab == tabDataGV)
            {
                btnReadFile.Visible = true;
            }
            if (tabView.SelectedTab == tabThumb)
            {
                btnReadFile.Visible = false;
            }
            if (this.dataFileM.RowCount <= 0)
            {
                btnReadFile.Enabled = false;
            }
            if (FileController.getListFile().Count <= 1)
            {
                addReadIndex.Enabled = false; // Nếu không có file hoặc có 1 file thì ẩn thêm thứ tự đọc
            }
            loadData();
            this.lbShowDanhMuc.Text = "TẤT CẢ";
        }

        // Cập nhật thể loại ở Danh mục
        public void UpdateCategory()
        {
            List<Category> lctg = new List<Category>();
            lctg = CategoryController.getListCategory();
            if (lctg.Count <= 0)
            {
                this.cbCategory.Enabled = false;
                this.addFile.Enabled = false;
            }
            else
            {
                this.addFile.Enabled = true;
                this.cbCategory.Enabled = true;
                this.cbCategory.Items.Clear();
                foreach (var i in lctg)
                {
                    this.cbCategory.Items.Add(i.sCategoryName.ToUpper());
                }
            }
        }

        // Cập nhật toàn bộ frmManager
        public void loadData()
        {
            source.DataSource = FileController.getListFile();
            dataFileM.DataSource = source;
            if (FileController.getListFile().Count <= 1)
            {
                addReadIndex.Enabled = false;
            }
            else
            {
                addReadIndex.Enabled = true;
            }
            // Kiểm tra LastRead 
            dtLast = DateTime.MinValue;
            for (int i = 0; i < FileController.getListFile().Count; i++)
            {
                FileM file = FileController.getFileM(int.Parse(this.dataFileM.Rows[i].Cells[0].Value.ToString()));
                try
                {
                    if (DateTime.Compare(file.dtRecentlyRead.Value, dtLast) > 0) // Gần nhất
                    {
                        dtLast = file.dtRecentlyRead.Value;
                        lbFileCode.Text = file.iFileCode.ToString();
                    }
                }
                catch
                {

                }
            }
            if (lbFileCode.Text != "")
            {
                lastRead(lbFileCode.Text.ToString().Trim()); // Khởi tạo nếu có file đọc gần nhất
            }
            else
            {
                picLastFile.Dispose();
                lbTitle.Text = "";
            }
            showThumb();
            this.UpdateCategory();
        }

        // Hiển thị dạng lưới
        private void showThumb()
        {
            if (flpnlThumb.Controls.Count > 0)
            {
                flpnlThumb.Controls.Clear(); // Xóa các control trên flowlayoutpanel để không bị hiện lặp lại
            }
            for (int i = 0; i < dataFileM.RowCount; i++)
            {
                usrViewThumb listView1 = new usrViewThumb();
                FileM file = FileController.getFileM(int.Parse(this.dataFileM.Rows[i].Cells[0].Value.ToString()));
                listView1.Title = file.sTitle;
                listView1.Category = file.sCategory;
                listView1.FileCode = file.iFileCode.ToString();
                listView1.RecentlyRead = file.dtRecentlyRead.ToString();
                listView1.Note = file.sNote;
                listView1.LinkFile = file.sLinkFile;
                try
                {
                    using (FileStream stream = new FileStream(String.Format(file.sLinkPic), FileMode.Open, FileAccess.Read))
                    {
                        listView1.PictureFile.Image = Image.FromStream(stream);
                    }
                }
                catch
                {
                    // Trường hợp đường dẫn hình ảnh không còn tồn tại
                    listView1.PictureFile.Image = Image.FromFile("..//..//Pictures//ErrorIMG.jpeg");
                }
                G = Graphics.FromImage(listView1.PictureFile.Image);
                flpnlThumb.Controls.Add(listView1);
                //Mới thêm vào + chưa đọc thì hiện icon New
                if (file.dtDateUpdate.ToString("dd/MM/yyyy") == DateTime.Now.ToString("dd/MM/yyyy") && file.iRead == 0)
                {
                    listView1.PictureNewIcon.Visible = true;
                }
                else listView1.PictureNewIcon.Visible = false;
            }
        }

        // Chọn dạng hiển thị lưới thì ẩn btnReadFile
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

        // File Menu Item: Thêm file
        private void addFile_Click(object sender, EventArgs e)
        {
            frmAddFile frmAdd = new frmAddFile(ref fileM, darkmode);
            frmAdd.ShowDialog();
            if (frmAdd.save == true)
            {
                loadData();
            }
        }

        // File Menu Item: Thêm thể loại
        private void addCategory_Click(object sender, EventArgs e)
        {
            frmAddCategory catg = new frmAddCategory(ref categories);
            catg.ShowDialog();
            if(catg.exit == true)
            {
                loadData();
            }
        }

        // File Menu Item: Thêm thứ tự đọc file
        private void addReadIndex_Click(object sender, EventArgs e)
        {
            frmAddReadIndex ri = new frmAddReadIndex(ref fileM);
            ri.ShowDialog();
            if (ri.save == true)
            {
                loadData();
            }
        }

        // Hiển thị file đọc gần nhất
        private void lastRead(string filecode)
        {
            lbFileCode.Text = filecode;
            if (filecode != "")
            {
                btnReadLastFile.Enabled = true;
                FileM file = FileController.getFileM(int.Parse(lbFileCode.Text.ToString()));
                if(file is null) {
                    this.lbTitle.Text = "";
                    picLastFile.Image.Dispose();
                    return; 
                }
                lbTitle.Text = file.sTitle;
                using (FileStream stream = new FileStream(String.Format(file.sLinkPic), FileMode.Open, FileAccess.Read))
                {
                    picLastFile.Image = Image.FromStream(stream);
                }
                G = Graphics.FromImage(picLastFile.Image);
            }
            else btnReadLastFile.Enabled = false;
        }

        // Đọc file gần nhất bằng Double Click
        private void pnlLastRead_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbFileCode.Text != "")
            {
                FileM file = FileController.getFileM(int.Parse(lbFileCode.Text.ToString()));
                frmRead read = new frmRead(ref fileM, file.iFileCode);
                read.Text = this.dataFileM.CurrentRow.Cells[1].Value.ToString();
                read.ShowDialog();
                if (read.exit == true)
                {
                    loadData();
                }
            }
        }

        // Đọc file gần nhất bằng Button
        private void btnReadLastFile_Click(object sender, EventArgs e)
        {
            if (lbFileCode.Text != "")
            {
                FileM file = FileController.getFileM(int.Parse(lbFileCode.Text.ToString()));
                if(file is null) { return; }
                frmRead read = new frmRead(ref fileM, file.iFileCode);
                read.Text = file.sTitle;
                read.ShowDialog();
                if (read.exit == true)
                {
                    loadData();
                }
            }
        }

        // Tìm kiếm file
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.txtSearch.Text.Length <= 0)
            {
                MessageBox.Show("Chưa điền mã số hoặc tên File!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                source.DataSource = FileController.getListFile();
            }
            else
            {
                source.DataSource = FileController.searchFile(this.txtSearch.Text.Trim());
                if (source.DataSource == null)
                {
                    MessageBox.Show("Không có tên file cần tìm!", "Thông báo", MessageBoxButtons.OK);
                    source.DataSource = FileController.getListFile();
                }
            }
            dataFileM.DataSource = source;
            showThumb();
        }

        // Khi nội dung trong ô tìm kiếm trở về rỗng thì cập nhật lại
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (this.txtSearch.Text.Length <= 0)
            {
                loadData();
            }
        }

        // Dạng danh sách: Cho phép chọn btnReadFile khi chọn vào hàng
        private void dataFileM_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.btnReadFile.Enabled = true;
        }
       
        // Dạng danh sách: Xóa File
        private void dataFileM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataFileM.Columns[e.ColumnIndex].Name == "cDelete")
            {
                if (MessageBox.Show("Bạn chắc chắn xóa file này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FileM file = FileController.getFileM(int.Parse(this.dataFileM.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    FileController.deleteFile(file);
                    try // nếu đã tồn tại hình vẽ thì xóa (nghĩa là hình vẽ đã được lưu)
                    {
                        File.Delete(String.Format("{0}.jpg", int.Parse(this.dataFileM.Rows[e.RowIndex].Cells[0].Value.ToString())));
                    }
                    catch
                    {
                       // không có hình vẽ thì thôi
                    }
                }
                loadData();
            }
        }

        // Dạng danh sách: Đọc File
        private void btnReadFile_Click(object sender, EventArgs e)
        {
            frmRead read = new frmRead(ref fileM, int.Parse(this.dataFileM.CurrentRow.Cells[0].Value.ToString()));
            read.Text = this.dataFileM.CurrentRow.Cells[1].Value.ToString();
            read.ShowDialog();
            if (read.exit == true)
            {
                loadData();
            }
        }

        // Làm mới 
        private void toolStripRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        // Hiển thị tất cả
        private void btnAllFile_Click(object sender, EventArgs e)
        {
            loadData();
            this.lbShowDanhMuc.Text = "TẤT CẢ";
            this.cbCategory.Text = "THỂ LOẠI";
        }

        // Hiển thị lịch sử thêm file
        private void btnRecentlyAdd_Click(object sender, EventArgs e)
        {
            source.DataSource = FileController.showAddRecently();
            dataFileM.DataSource = source;
            showThumb();
            this.lbShowDanhMuc.Text = "FILE THÊM GẦN ĐÂY ";
            this.cbCategory.Text = "THỂ LOẠI";
        }

        // Hiển thị lịch sử đọc
        private void btnRecentlyRead_Click(object sender, EventArgs e)
        {
            List<FileM> lF = new List<FileM>();
            List<FileM> lFileRead = new List<FileM>();
            lF = FileController.getListFile();
            foreach(var i in lF)
            {
                if(i.iRead > 0)
                {
                    lFileRead.Add(i);
                }
            }
            dataFileM.DataSource = lFileRead;
            showThumb();
            this.lbShowDanhMuc.Text = "LỊCH SỬ ĐỌC";
            this.cbCategory.Text = "THỂ LOẠI";
        }

        // Hiển thị theo thể loại được chọn
        private void cbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            List<FileM> lF = new List<FileM>();
            lF = FileController.getListFile();
            List<FileM> lFileCategory = new List<FileM>();
            foreach (var i in lF)
            {
                string[] a = i.sCategory.Split(',');
                if(a is null)
                {

                }
                else
                {
                    foreach (var obj in a)
                    {
                        if (obj.Trim() == this.cbCategory.Text)
                        {
                                lFileCategory.Add(i);
                        }
                    }
                }
            }
            lbShowDanhMuc.Text = cbCategory.Text; 
            dataFileM.DataSource = lFileCategory;
            showThumb();
        }

        // Thoát ứng dụng
        private void exitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region MouseEnter_MouseLeave
        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.SkyBlue;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.Gainsboro;
        }

        private void btnReadFile_MouseEnter(object sender, EventArgs e)
        {
            btnReadFile.BackColor = Color.SkyBlue;
        }

        private void btnReadFile_MouseLeave(object sender, EventArgs e)
        {
            btnReadFile.BackColor = Color.Gainsboro;
        }
        #endregion

        // Chọn chế độ tối
        private void darkMode_Click(object sender, EventArgs e)
        {
            darkmode = true;
            // Viết code chỉnh tối ở đây
        }

        private void lightMode_Click(object sender, EventArgs e)
        {
            darkmode = false;
            // Viết code chỉnh sáng
        }
    }
}
