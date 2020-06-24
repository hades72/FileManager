using FileManager.Controllers;
using FileManager.Models;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Path = System.IO.Path;

namespace FileManager.Views
{
    public partial class frmRead : Form
    {
        private DrawNote drawNote;
        Graphics G;
        private bool checkDraw = false; // kiểm tra xem có vẽ mới hay k
        private int fileCode; // lấy mã số file
        private string linkFile;
        private int currentPage; // trang hiện tại đang xem
        private int maxPage; // số trang cao nhất đã xem
        private int numberOfPage; // tổng số trang
        public bool exit = false; // kiểm tra đã thoát đọc chưa

        public frmRead(ref List<FileM> fileM, int filecode)
        {
            InitializeComponent();
            drawNote = new DrawNote();
            FileM file = FileController.getFileM(filecode);
            fileCode = filecode;
            linkFile = file.sLinkFile;
            if(file.iRead == 0)
            {
                file.iRead += 1;
                FileController.updateFile(file);
            }
            currentPage = file.iRead;
            maxPage = file.iRead;
            if (file.sNote != null)
            {
                rtbNote.Text = file.sNote;
                btnDeleteNote.Enabled = true; // nếu tồn tại ghi chú thì bật nút xóa
            }
            cbbWidth.Text = cbbWidth.GetItemText(cbbWidth.Items[0]).ToString();
        }

        private void frmRead_Load(object sender, EventArgs e)
        {
            this.helpProvider1.SetShowHelp(this.rtbNote, true);
            this.helpProvider1.SetHelpString(this.rtbNote, "Nhap noi dung ban can ghi chu!");
            this.helpProvider1.SetShowHelp(this.ptbNote, true);
            this.helpProvider1.SetHelpString(this.ptbNote, "Ve ghi chu vao day!");
            if (Path.GetExtension(linkFile) == ".pdf")
            {
                using (PdfReader reader = new PdfReader(linkFile))
                {
                    numberOfPage = reader.NumberOfPages;
                }
            }
            if (Path.GetExtension(linkFile) == ".txt")
            {
                numberOfPage = 1;
            }
            ReadByPageNumber(currentPage); // đọc file theo trang
            // checkdraw vẫn false vì chưa vẽ gì mới mà chỉ load hình vẽ đã có
            try // load hình vẽ đã lưu lên
            {
                if (G == null)
                {
                    G = ptbNote.CreateGraphics();
                    Bitmap bm = new Bitmap(ptbNote.ClientSize.Width, ptbNote.ClientSize.Height);
                    ptbNote.Image = bm;
                    G = Graphics.FromImage(bm);
                    G.Clear(Color.White);
                }
                using (FileStream fileStream = new FileStream(String.Format("{0}.jpg", fileCode), FileMode.Open, FileAccess.ReadWrite))
                {
                    ptbNote.Image = Image.FromStream(fileStream);
                    fileStream.Close();
                    G = Graphics.FromImage(ptbNote.Image);
                    btnDeleteDrawNote.Enabled = true;
                }
            }
            catch // nếu không có hình vẽ thì thôi
            {
                G = null;
            }
        }

        // Nhấn xem trang tiếp theo
        private void ptbNextPage_Click(object sender, EventArgs e)
        {
            currentPage += 1;
            if(currentPage > maxPage)
            {
                maxPage = currentPage;
            }
            ReadByPageNumber(currentPage);
        }

        // Nhấn xem trang trước đó
        private void ptbBackPage_Click(object sender, EventArgs e)
        {
            currentPage -= 1;
            ReadByPageNumber(currentPage);
        }

        // Đọc theo trang pagenumber
        private void ReadByPageNumber(int pagenumber) 
        {
            this.rtbRead.Text = null;
            txtCurrentPage.Text = "Trang " + pagenumber.ToString();
            if (Path.GetExtension(linkFile) == ".pdf")
            {
                using (PdfReader reader = new PdfReader(linkFile))
                {
                    LocationTextExtractionStrategy strategy = new LocationTextExtractionStrategy();
                    string line = PdfTextExtractor.GetTextFromPage(reader, pagenumber, strategy);
                    this.rtbRead.Text += line;
                }
            }
            if (Path.GetExtension(linkFile) == ".txt")
            {
                using (FileStream fs = new FileStream(linkFile, FileMode.Open))
                {
                    StreamReader rd = new StreamReader(fs, Encoding.Unicode);
                    this.rtbRead.Text = rd.ReadToEnd();
                }
            }
            if (currentPage + 1 > numberOfPage) // trang sau lớn hơn trang của file thì ẩn
                ptbNextPage.Visible = false;
            else ptbNextPage.Visible = true;
            if (currentPage - 1 < 1) // trang trước nhỏ hơn bằng 0 thì ẩn
                ptbBackPage.Visible = false;
            else ptbBackPage.Visible = true;
        }

        // Lưu ghi chú
        private void btnSave_Click(object sender, EventArgs e)
        {
            FileM file = FileController.getFileM(fileCode);
            if (rtbNote.Text.Length > 0) // có ghi chú mới lưu
            {
                file.sNote = rtbNote.Text.Trim();
            }
            if (checkDraw == true) // vẽ thì lưu
            {
                using (FileStream fileStream = new FileStream(String.Format("{0}.jpg", fileCode), FileMode.Create))
                {
                    ptbNote.Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
            checkDraw = false;
            FileController.updateFile(file); // cập nhật xuống dtb
            MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK);
        }

        // Chuột không nhấn vào ptbNote
        private void ptbNote_MouseUp(object sender, MouseEventArgs e)
        {
            drawNote.isDraw = false;
        }

        // Chuột nhấn vào ptbNote
        private void ptbNote_MouseDown(object sender, MouseEventArgs e)
        {
            drawNote.isDraw = true;
            checkDraw = true; // kiểm tra nhấn chuột vẽ
            btnDeleteDrawNote.Enabled = true; // có nhấn chuột để vẽ nên mở button xóa hình 
            drawNote.X = e.X;
            drawNote.Y = e.Y;
        }
        
        // Chuột có nhấn và di chuyển để vẽ
        private void ptbNote_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawNote.isDraw == true)
            {
                if (G == null)
                {
                    G = ptbNote.CreateGraphics();
                    Bitmap bm = new Bitmap(ptbNote.ClientSize.Width, ptbNote.ClientSize.Height);
                    ptbNote.Image = bm;
                    G = Graphics.FromImage(bm);
                    G.Clear(Color.White);
                }
                G.DrawLine(drawNote.pen, drawNote.X, drawNote.Y, e.X, e.Y);
                G.Flush();
                G.Save();
                ptbNote.Refresh();
                drawNote.X = e.X;
                drawNote.Y = e.Y;
            }
        }

        // Thay đổi kích thước ptb
        private void ptbNote_Resize(object sender, EventArgs e)
        {
            if (G is null) return;
            G.Dispose();
            this.ptbNote.CreateGraphics().Clear(Color.White);
            Bitmap bm = new Bitmap(ptbNote.ClientSize.Width, ptbNote.ClientSize.Height, ptbNote.CreateGraphics());
        }

        // Xóa hình vẽ
        private void btnDeleteDrawNote_Click(object sender, EventArgs e)
        {
            try // nếu đã tồn tại hình vẽ thì xóa (nghĩa là hình vẽ đã được lưu)
            {
                var fs = File.OpenRead(String.Format("{0}.jpg", fileCode));
                ptbNote.Image = Image.FromStream(fs);
                fs.Close();
                File.Delete(String.Format("{0}.jpg", fileCode));
            }
            catch
            {
                // nếu hình vẽ chưa được lưu thì chỉ khởi tạo lại ptb ban đầu
            }
            G = null;
            G = ptbNote.CreateGraphics();
            Bitmap bm = new Bitmap(ptbNote.ClientSize.Width, ptbNote.ClientSize.Height);
            ptbNote.Image = bm;
            G = Graphics.FromImage(bm);
            G.Clear(Color.White);
            btnDeleteDrawNote.Enabled = false; // xóa rồi thì tắt button xóa
            checkDraw = false; // chuyển về chưa vẽ
        }

        // Xóa ghi chú
        private void btnDeleteNote_Click(object sender, EventArgs e)
        {
            rtbNote = null; // xóa nội dung ghi chú
            btnDeleteNote.Enabled = false; 
        }

        // Tạo mới ghi chú và hình ảnh
        private void btnNew_Click(object sender, EventArgs e)
        {
            if(btnDeleteNote.Enabled == true)
            {
                btnDeleteNote_Click(sender, e);
            }
            if(btnDeleteDrawNote.Enabled == true)
            {
                btnDeleteDrawNote_Click(sender, e);
            }
        }

        // Khi note có nội dung thì bật nút xóa, nếu không có thì ẩn
        private void rtbNote_TextChanged(object sender, EventArgs e)
        {
            if (rtbNote.Text.Length > 0)
            {
                btnDeleteNote.Enabled = true;
            }
            else
            {
                btnDeleteNote.Enabled = false;
            }
        }

        // Lưu những thay đổi trước khi đóng hoặc hủy không đóng nữa
        private void frmRead_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileM file = FileController.getFileM(fileCode);
            file.iRead = maxPage;
            file.dtRecentlyRead = DateTime.Now;
            if (file.sNote != rtbNote.Text.Trim() && rtbNote.Text.Length > 0 || checkDraw == true)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn lưu các thay đổi cho " + file.sTitle + "?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    file.sNote = rtbNote.Text.Trim();
                    if(checkDraw == true)
                    {
                        using (FileStream fileStream = new FileStream(String.Format("{0}.jpg", fileCode), FileMode.Create))
                        {
                            ptbNote.Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                    }
                }
                else if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true; // Không đóng form
                }    
            }
            FileController.updateFile(file); // cập nhật xuống dtb
            exit = true;
        }

        // Chọn màu bút vẽ
        private void btnColorPen_Click(object sender, EventArgs e)
        {
            DialogResult dlgresult = colorDialog.ShowDialog();
            if (dlgresult == DialogResult.OK) //Nếu nhấp vào nút OK trên hộp thoại
            {
                drawNote.color = colorDialog.Color; //Trả lại tên của màu đã lựa chọn
                drawNote.pen = new Pen(drawNote.color, float.Parse(cbbWidth.SelectedItem.ToString()));
            }
        } 

        // Chỉnh độ rộng bút
        private void cbbWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            drawNote.pen = new Pen(drawNote.color, float.Parse(cbbWidth.SelectedItem.ToString()));
        }
    }

    // Lớp Vẽ ghi chú
    public class DrawNote
    {
        public int X { set; get; }
        public int Y { set; get; }
        public Color color { set; get; } // màu
        public Pen pen { set; get; } // bút vẽ
        public bool isDraw { set; get; }
        public float width { get; set; } // chiều rộng của nét bút

        public DrawNote()
        {
            isDraw = false;
            // màu sắc và chiều rộng của nét bút
            color = Color.Black;
            width = 2;
            pen = new Pen(color, width);
        }
    }
}
