namespace FileManager.Views
{
    partial class listViewThumb
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbTenFile = new System.Windows.Forms.Label();
            this.lbTheLoai = new System.Windows.Forms.Label();
            this.lbNgayDocGanNhat = new System.Windows.Forms.Label();
            this.picFile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFile)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã số :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thể loại : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày đọc gần nhất : ";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(184, 18);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(0, 17);
            this.lbID.TabIndex = 5;
            // 
            // lbTenFile
            // 
            this.lbTenFile.AutoSize = true;
            this.lbTenFile.Location = new System.Drawing.Point(170, 44);
            this.lbTenFile.Name = "lbTenFile";
            this.lbTenFile.Size = new System.Drawing.Size(0, 17);
            this.lbTenFile.TabIndex = 6;
            // 
            // lbTheLoai
            // 
            this.lbTheLoai.AutoSize = true;
            this.lbTheLoai.Location = new System.Drawing.Point(202, 105);
            this.lbTheLoai.Name = "lbTheLoai";
            this.lbTheLoai.Size = new System.Drawing.Size(0, 17);
            this.lbTheLoai.TabIndex = 7;
            // 
            // lbNgayDocGanNhat
            // 
            this.lbNgayDocGanNhat.AutoSize = true;
            this.lbNgayDocGanNhat.Location = new System.Drawing.Point(131, 145);
            this.lbNgayDocGanNhat.Name = "lbNgayDocGanNhat";
            this.lbNgayDocGanNhat.Size = new System.Drawing.Size(0, 17);
            this.lbNgayDocGanNhat.TabIndex = 8;
            // 
            // picFile
            // 
            this.picFile.BackColor = System.Drawing.Color.White;
            this.picFile.Location = new System.Drawing.Point(3, 18);
            this.picFile.Name = "picFile";
            this.picFile.Size = new System.Drawing.Size(121, 160);
            this.picFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFile.TabIndex = 0;
            this.picFile.TabStop = false;
            // 
            // listViewThumb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbNgayDocGanNhat);
            this.Controls.Add(this.lbTheLoai);
            this.Controls.Add(this.lbTenFile);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picFile);
            this.Name = "listViewThumb";
            this.Size = new System.Drawing.Size(367, 193);
            this.DoubleClick += new System.EventHandler(this.listViewThumb_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.picFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbTenFile;
        private System.Windows.Forms.Label lbTheLoai;
        private System.Windows.Forms.Label lbNgayDocGanNhat;
    }
}
