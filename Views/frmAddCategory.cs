using FileManager.Controllers;
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

        public frmAddCategory(ref List<Category> categories)
        {
            InitializeComponent();
            this.cCategoryCode.DataPropertyName = nameof(Category.iCategoryCode);
            this.cCategoryName.DataPropertyName = nameof(Category.sCategoryName);
            
            source.DataSource = CategoryController.getListCategory();
            dataCategory.AutoGenerateColumns = false;
            dataCategory.DataSource = source;
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
                Category ctg = new Category();
                ctg.iCategoryCode = CategoryController.getCategoryCodeFromDB();
                ctg.sCategoryName = this.txtCategoryName.Text.Trim();
                CategoryController.addCategory(ctg);
                loadDataCategory();
                MessageBox.Show("Thêm thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCategoryName.Text = null;
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
                    MessageBox.Show("Xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Sửa thể thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
