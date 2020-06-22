using FileManager.Controllers;
using FileManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager.Views
{
    public partial class frmProperties : Form
    {
        private int fileCode;
        private string linkFile;
        public frmProperties(ref List<FileM> fileM, int filecode)
        {
            InitializeComponent();

            FileM file = FileController.getFileM(filecode);
            fileCode = filecode;
            linkFile = file.sLinkFile;

            this.lbTitle.Text = file.sTitle;
            this.lbFileCode.Text = file.iFileCode.ToString();
            this.lbCategory.Text = file.sCategory;
            this.lbDateAdd.Text = file.dtDateUpdate.ToString();
            this.lbRecentlyRead.Text = file.dtRecentlyRead.ToString();
            this.lbLinkFile.Text = file.sLinkFile;
            using (FileStream stream = new FileStream(String.Format(file.sLinkPic), FileMode.Open, FileAccess.Read))
            {
                picFile.Image = Image.FromStream(stream);
            }

        }



        private void picLocation_MouseEnter(object sender, EventArgs e)
        {
            picLinkFile.BackColor = Color.LightSkyBlue;
        }

        private void picLocation_MouseLeave(object sender, EventArgs e)
        {
            picLinkFile.BackColor = Color.AliceBlue;
        }

        private void picLinkFile_Click(object sender, EventArgs e)
        {
            string target = Path.GetDirectoryName(linkFile); // Lấy đường dẫn thư mục chứa file đ

            if (Directory.Exists(target))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = target,
                    FileName = "explorer.exe"
                };

                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show(string.Format("{0} Thư mục không tồn tại!", target));
            }
        }
    }
}
