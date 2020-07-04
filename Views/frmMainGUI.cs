using FileManager.Models;
using FileManager.Views;
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
    public partial class frmMainGUI : Form
    {
        frmManager fView;
        List<FileM> listFileM;
        List<Category> listCategory;

        public frmMainGUI()
        {
            InitializeComponent();
            listFileM = new List<FileM>();
            listCategory = new List<Category>();
            WindowState = FormWindowState.Maximized;
        }

        private void frmMainGUI_Load(object sender, EventArgs e)
        {
            mFuntion.BackColor = ColorTranslator.FromHtml("#C0C0C0");
            this.fView = new frmManager(ref listFileM,listCategory);
            this.fView.MdiParent = this;
            this.fView.Show();
        }
    }
}
