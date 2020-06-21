namespace FileManager.Views
{
    partial class usrViewThumb
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbFileCode = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbRecentlyRead = new System.Windows.Forms.Label();
            this.picFile = new System.Windows.Forms.PictureBox();
            this.ctmenuProperties = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolRead = new System.Windows.Forms.ToolStripMenuItem();
            this.toolReadWithReaderriver = new System.Windows.Forms.ToolStripMenuItem();
            this.toolReadWithWord = new System.Windows.Forms.ToolStripMenuItem();
            this.toolProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.picNewIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFile)).BeginInit();
            this.ctmenuProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNewIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã số:";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên: ";
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thể loại: ";
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lần đọc gần nhất";
            this.label4.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // lbFileCode
            // 
            this.lbFileCode.AutoSize = true;
            this.lbFileCode.Location = new System.Drawing.Point(143, 15);
            this.lbFileCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFileCode.Name = "lbFileCode";
            this.lbFileCode.Size = new System.Drawing.Size(0, 13);
            this.lbFileCode.TabIndex = 5;
            this.lbFileCode.MouseEnter += new System.EventHandler(this.lbID_MouseEnter);
            this.lbFileCode.MouseLeave += new System.EventHandler(this.lbID_MouseLeave);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(133, 36);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(0, 13);
            this.lbTitle.TabIndex = 6;
            this.lbTitle.MouseEnter += new System.EventHandler(this.lbTenFile_MouseEnter);
            this.lbTitle.MouseLeave += new System.EventHandler(this.lbTenFile_MouseLeave);
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(152, 78);
            this.lbCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(0, 13);
            this.lbCategory.TabIndex = 7;
            this.lbCategory.MouseEnter += new System.EventHandler(this.lbTheLoai_MouseEnter);
            this.lbCategory.MouseLeave += new System.EventHandler(this.lbTheLoai_MouseLeave);
            // 
            // lbRecentlyRead
            // 
            this.lbRecentlyRead.AutoSize = true;
            this.lbRecentlyRead.Location = new System.Drawing.Point(107, 132);
            this.lbRecentlyRead.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRecentlyRead.Name = "lbRecentlyRead";
            this.lbRecentlyRead.Size = new System.Drawing.Size(0, 13);
            this.lbRecentlyRead.TabIndex = 8;
            this.lbRecentlyRead.MouseEnter += new System.EventHandler(this.lbNgayDocGanNhat_MouseEnter);
            this.lbRecentlyRead.MouseLeave += new System.EventHandler(this.lbNgayDocGanNhat_MouseLeave);
            // 
            // picFile
            // 
            this.picFile.BackColor = System.Drawing.Color.White;
            this.picFile.Location = new System.Drawing.Point(8, 11);
            this.picFile.Margin = new System.Windows.Forms.Padding(2);
            this.picFile.Name = "picFile";
            this.picFile.Size = new System.Drawing.Size(95, 134);
            this.picFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFile.TabIndex = 0;
            this.picFile.TabStop = false;
            this.picFile.DoubleClick += new System.EventHandler(this.picFile_DoubleClick);
            this.picFile.MouseEnter += new System.EventHandler(this.picFile_MouseEnter);
            this.picFile.MouseLeave += new System.EventHandler(this.picFile_MouseLeave);
            // 
            // ctmenuProperties
            // 
            this.ctmenuProperties.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctmenuProperties.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolRead,
            this.toolProperties,
            this.toolDelete});
            this.ctmenuProperties.Name = "ctmenuProperties";
            this.ctmenuProperties.Size = new System.Drawing.Size(136, 70);
            // 
            // toolRead
            // 
            this.toolRead.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolReadWithReaderriver,
            this.toolReadWithWord});
            this.toolRead.Name = "toolRead";
            this.toolRead.Size = new System.Drawing.Size(135, 22);
            this.toolRead.Text = "&Đoc File với";
            // 
            // toolReadWithReaderriver
            // 
            this.toolReadWithReaderriver.Name = "toolReadWithReaderriver";
            this.toolReadWithReaderriver.Size = new System.Drawing.Size(136, 22);
            this.toolReadWithReaderriver.Text = "&ReaderRiver";
            // 
            // toolReadWithWord
            // 
            this.toolReadWithWord.Name = "toolReadWithWord";
            this.toolReadWithWord.Size = new System.Drawing.Size(136, 22);
            this.toolReadWithWord.Text = "&Word";
            // 
            // toolProperties
            // 
            this.toolProperties.Name = "toolProperties";
            this.toolProperties.Size = new System.Drawing.Size(135, 22);
            this.toolProperties.Text = "&Chi tiết File";
            this.toolProperties.Click += new System.EventHandler(this.toolProperties_Click);
            // 
            // toolDelete
            // 
            this.toolDelete.Name = "toolDelete";
            this.toolDelete.Size = new System.Drawing.Size(135, 22);
            this.toolDelete.Text = "&Xóa File";
            this.toolDelete.Click += new System.EventHandler(this.toolDelete_Click);
            // 
            // picNewIcon
            // 
            this.picNewIcon.BackColor = System.Drawing.Color.Transparent;
            this.picNewIcon.Image = global::FileManager.Properties.Resources.long_banner_png_2;
            this.picNewIcon.Location = new System.Drawing.Point(-6, -6);
            this.picNewIcon.Margin = new System.Windows.Forms.Padding(2);
            this.picNewIcon.Name = "picNewIcon";
            this.picNewIcon.Size = new System.Drawing.Size(78, 67);
            this.picNewIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNewIcon.TabIndex = 9;
            this.picNewIcon.TabStop = false;
            // 
            // usrViewThumb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ContextMenuStrip = this.ctmenuProperties;
            this.Controls.Add(this.picNewIcon);
            this.Controls.Add(this.lbRecentlyRead);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbFileCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picFile);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "usrViewThumb";
            this.Size = new System.Drawing.Size(261, 164);
            this.DoubleClick += new System.EventHandler(this.listViewThumb_DoubleClick);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewThumb_MouseClick);
            this.MouseEnter += new System.EventHandler(this.listViewThumb_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.listViewThumb_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picFile)).EndInit();
            this.ctmenuProperties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picNewIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbFileCode;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbRecentlyRead;
        private System.Windows.Forms.ContextMenuStrip ctmenuProperties;
        private System.Windows.Forms.ToolStripMenuItem toolRead;
        private System.Windows.Forms.ToolStripMenuItem toolReadWithReaderriver;
        private System.Windows.Forms.ToolStripMenuItem toolReadWithWord;
        private System.Windows.Forms.ToolStripMenuItem toolProperties;
        private System.Windows.Forms.ToolStripMenuItem toolDelete;
        private System.Windows.Forms.PictureBox picNewIcon;
    }
}
