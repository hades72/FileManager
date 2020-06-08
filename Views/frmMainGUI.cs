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
        frmAddFile fAdd;
        frmManager fManager;
        List<FileM> listFileM;
        public frmMainGUI()
        {
            InitializeComponent();
            listFileM = new List<FileM>();
            WindowState = FormWindowState.Maximized;

        }

        private void tabAddFile_Click(object sender, EventArgs e)
        {
            if(this.fAdd is null || this.fAdd.IsDisposed)
            {
                this.fAdd = new frmAddFile(ref listFileM);
                //this.fAdd.MdiParent = this;
                this.fAdd.Show();
            }    
            else
            {
                this.fAdd.Select();
            }    
        }

        private void tabReadFile_Click(object sender, EventArgs e)
        {
            if(this.fManager is null || this.fManager.IsDisposed)
            {
                this.fManager = new frmManager(ref listFileM);
                this.fManager.MdiParent = this;
                this.fManager.Show();
            }    
            else
            {
                this.fManager.Select();
            }    
        }

        private void frmMainGUI_MdiChildActivate(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild == null)
            {
                return;
            }
            this.ActiveMdiChild.WindowState = FormWindowState.Maximized;
            if(this.ActiveMdiChild.Tag == null)
            {
                TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                tp.Tag = this.ActiveMdiChild;
                tp.Parent = this.tabMain;
                this.tabMain.SelectedTab = tp;
                this.ActiveMdiChild.Tag = tp;
                this.ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed;
            }    
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void txtNameOfFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
