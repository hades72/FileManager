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
        private bool DarkMode;

        public frmProperties(ref List<FileM> fileM, int filecode, bool darkmode)
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
            if(file.sFilePreview == null)
            {
                this.lbReadPreview.Text = "";
            }
            else
                this.lbReadPreview.Text = file.sFilePreview.ToString();
            using (FileStream stream = new FileStream(String.Format(file.sLinkPic), FileMode.Open, FileAccess.Read))
            {
                picFile.Image = Image.FromStream(stream);
            }
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

        // Chế độ tối
        private void darkMode()
        {
            this.BackColor = ColorTranslator.FromHtml("#1C1C1C");
            label5.ForeColor = Color.White;
            lbLinkFile.ForeColor = Color.White;
        }

        // Chế độ sáng
        private void lightMode()
        {
            this.BackColor = DefaultBackColor;
            this.ForeColor = DefaultForeColor;
        }

        // Nhấn chuột vào mũi tên đường dẫn đổi màu
        private void picLinkFile_MouseEnter(object sender, EventArgs e)
        {
            picLinkFile.BackColor = Color.LightSkyBlue;
        }

        // Chuột rời đi thì để lại màu mặc định
        private void picLinkFile_MouseLeave(object sender, EventArgs e)
        {
            if (DarkMode == true)
                picLinkFile.BackColor = ColorTranslator.FromHtml("#1C1C1C");
            else
                picLinkFile.BackColor = Color.AliceBlue;
        }

        // Nhấn vào mũi tên đường dẫn hiện thư mục chứa đường dẫn file
        private void picLinkFile_Click(object sender, EventArgs e)
        {
            string target = Path.GetDirectoryName(linkFile); // Lấy đường dẫn thư mục chứa file đó
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
