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
    public partial class frmAddCategory : Form
    {
        BindingSource source = new BindingSource();
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
            Category ctg = new Category();
            ctg.iCategoryCode = CategoryController.getCategoryCodeFromDB();
            ctg.sCategoryName = this.txtCategoryName.Text.Trim();
            CategoryController.AddCategory(ctg);
            loadData();
        }

        private void dataCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
