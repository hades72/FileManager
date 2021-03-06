﻿using FileManager.Controllers;
using FileManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager.Views
{
    public partial class frmAddCategory : Form
    {
        BindingSource source = new BindingSource();
        private bool error = false;
        public bool exit = false;
        private bool DarkMode;

        public frmAddCategory(ref List<Category> categories , bool darkmode)
        {
            InitializeComponent();
            this.cCategoryCode.DataPropertyName = nameof(Category.iCategoryCode);
            this.cCategoryName.DataPropertyName = nameof(Category.sCategoryName);
            source.DataSource = CategoryController.getListCategory();
            dataCategory.AutoGenerateColumns = false;
            dataCategory.DataSource = source;

            // Xử lý chế độ sáng tối
            if (darkmode == true)
            {
                DarkMode = darkmode;
                darkMode();
            }
            else
            {
                DarkMode = darkmode;
                lightMode();
            }
        }

        private void frmAddCategory_Load(object sender, EventArgs e)
        {
            this.helpProvider1.SetShowHelp(this.txtCategoryName, true);
            this.helpProvider1.SetHelpString(this.txtCategoryName, "Nhap ten the loai ban muon");
        }

        // Chế độ tối
        private void darkMode()
        {
            panel1.BackColor = ColorTranslator.FromHtml("#1C1C1C");
            panel1.ForeColor = Color.White;
            btnAddCategory.BackColor = ColorTranslator.FromHtml("#1C1C1C");
            txtCategoryName.BackColor = ColorTranslator.FromHtml("#1C1C1C");
            txtCategoryName.ForeColor = Color.White;
            dataCategory.BackgroundColor = ColorTranslator.FromHtml("#1C1C1C");
            dataCategory.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#1C1C1C");
            dataCategory.DefaultCellStyle.ForeColor = Color.White;
        }

        // Chế độ sáng
        private void lightMode()
        {
            this.BackColor = DefaultBackColor;
            this.ForeColor = DefaultForeColor;
        }

        // Cập nhật lại dataCategory
        private void loadDataCategory()
        {
            source.DataSource = CategoryController.getListCategory();
            dataCategory.DataSource = source;
        }

        // Thêm thể loại
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            checkError();
            if(error == false)
            {
                Category ctg = new Category(); // Khởi tạo object ctg của lớp Category
                ctg.iCategoryCode = CategoryController.getCategoryCodeFromDB(); // Sinh mã số thể loại tự động
                ctg.sCategoryName = this.txtCategoryName.Text.Trim().ToUpper(); // Gán tên thể loại do người dùng nhập
                CategoryController.addCategory(ctg); // Xử lý yêu cầu thêm thể loại truyền xuống database
                loadDataCategory(); // Load lại form để hiển thị lên data grid view
                txtCategoryName.Text = null; // Gán ô điền tên thể loại thành null như ban đầu
            }
            error = false;
        }

        // Kiếm tra lỗi chưa nhập thể loại hoặc thể loại trùng
        private void checkError()
        {
            if(txtCategoryName.Text.Length <= 0)
            {
                MessageBox.Show("Chưa nhập tên thể loại", "Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
                error = true;
            }
            else
            {
                List<Category> lctg = new List<Category>();
                lctg = CategoryController.getListCategory();
                foreach (Category c in lctg)
                {
                    if(c.sCategoryName == txtCategoryName.Text.Trim())
                    {
                        MessageBox.Show("Thể loại vừa nhập đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCategoryName.Text = null;
                        error = true;
                    }
                }
            }
        }

        // Xóa thể loại
        private void dataCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataCategory.Columns[e.ColumnIndex].Name == "cDeleteCategory")
            {
                if (MessageBox.Show("Bạn chắc chắn xóa mục này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Category ctg = CategoryController.getCategory(int.Parse(this.dataCategory.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    CategoryController.deleteCategory(ctg);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                loadDataCategory();
            }
        }

        // Sửa thể loại
        private void dataCategory_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            List<Category> lctg = new List<Category>();
            lctg = CategoryController.getListCategory();
            foreach (var c in lctg)
            {
                if (c.sCategoryName == this.dataCategory.CurrentRow.Cells[e.ColumnIndex].Value.ToString().Trim())
                {
                    string flagString = this.dataCategory.CurrentRow.Cells[e.ColumnIndex].Value.ToString().Trim();
                    MessageBox.Show("Thể loại vừa nhập đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.dataCategory.CurrentRow.Cells[e.ColumnIndex].Value = flagString ;
                    loadDataCategory();
                    return;
                }
                if(c.iCategoryCode == int.Parse(this.dataCategory.CurrentRow.Cells[e.ColumnIndex - 1].Value.ToString().Trim())){
                    Category ctg = new Category();
                    ctg.iCategoryCode = c.iCategoryCode;
                    ctg.sCategoryName = this.dataCategory.CurrentRow.Cells[e.ColumnIndex].Value.ToString().Trim();
                    CategoryController.updateCategory(ctg);
                    MessageBox.Show("Sửa thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Chỉnh màu nền khi chuột nhấn và rời đi
        #region Mode-MouseEnter&Leave
        private void frmAddCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            exit = true;
        }

        private void btnAddCategory_MouseEnter(object sender, EventArgs e)
        {
            if (DarkMode == true)
                btnAddCategory.BackColor = Color.DimGray;
            else
                btnAddCategory.BackColor = Color.Transparent;
        }

        private void btnAddCategory_MouseLeave(object sender, EventArgs e)
        {
            if (DarkMode == true)
                btnAddCategory.BackColor = ColorTranslator.FromHtml("#1C1C1C");
            else
                btnAddCategory.BackColor = Color.AliceBlue;
        }
        #endregion
    }
}
