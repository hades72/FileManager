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
        private int ID;
        
        public frmManager(ref List<FileM> fileMs)
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.ID = 0;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           
        }
        
    }
}
