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

        private void loadData()
        {
            source.DataSource = CategoryController.getListCategory();
            dataCategory.DataSource = source;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            checkError();
            if(error == false)
            {
                Category ctg = new Category();
                ctg.iCategoryCode = CategoryController.getCategoryCodeFromDB();
                ctg.sCategoryName = this.txtCategoryName.Text.Trim();
                CategoryController.AddCategory(ctg);
                loadData();
            }
            error = false;
        }
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
                        error = true;
                    }
                }
            }
            
            
        }

        private void dataCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataCategory.Columns[e.ColumnIndex].Name == "cDeleteCategory")
            {
                if (MessageBox.Show("Bạn chắc chắn xóa mục này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Category ctg = CategoryController.getCategory(int.Parse(this.dataCategory.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    CategoryController.DeleteCategory(ctg);
                }
                // Cập nhật lại Data Grid View và Thumb
                loadData();
            }
        }

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
                    loadData();
                    return;
                }
                if(c.iCategoryCode == int.Parse(this.dataCategory.CurrentRow.Cells[e.ColumnIndex - 1].Value.ToString().Trim())){
                    Category ctg = new Category();

                    ctg.iCategoryCode = c.iCategoryCode;
                    ctg.sCategoryName = this.dataCategory.CurrentRow.Cells[e.ColumnIndex].Value.ToString().Trim();
                    CategoryController.UpdateCategory(ctg);
                }
            }
            
        }
    }
}
