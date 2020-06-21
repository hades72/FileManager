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
    public partial class frmProperties : Form
    {
        public frmProperties()
        {
            InitializeComponent();
        }



        private void picLocation_MouseEnter(object sender, EventArgs e)
        {
            picLocation.BackColor = Color.LightSkyBlue;
        }

        private void picLocation_MouseLeave(object sender, EventArgs e)
        {
            picLocation.BackColor = Color.AliceBlue;
        }
    }
}
