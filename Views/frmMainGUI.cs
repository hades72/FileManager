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

        private void frmMainGUI_MdiChildActivate(object sender, EventArgs e)
        {
            //if (this.ActiveMdiChild == null)
            //{
            //    return;
            //}
            //this.ActiveMdiChild.WindowState = FormWindowState.Maximized;
            //if (this.ActiveMdiChild.Tag == null)
            //{
            //    TabPage tp = new TabPage(this.ActiveMdiChild.Text);
            //    tp.Tag = this.ActiveMdiChild;
            //    tp.Parent = this.tabMain;
            //    this.tabMain.SelectedTab = tp;
            //    this.ActiveMdiChild.Tag = tp;
            //    this.ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed;
            //}
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            //((sender as Form).Tag as TabPage).Dispose();
        }

        private void frmMainGUI_Load(object sender, EventArgs e)
        {
            this.fView = new frmManager(ref listFileM,listCategory);
            this.fView.MdiParent = this;
            this.fView.Show();
        }
    }
}
