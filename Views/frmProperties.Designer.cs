﻿namespace FileManager.Views
{
    partial class frmProperties
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProperties));
            this.picFile = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFileCode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDateAdd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbRecentlyRead = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbLinkFile = new System.Windows.Forms.Label();
            this.picLinkFile = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLinkFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picFile
            // 
            this.picFile.BackColor = System.Drawing.Color.White;
            this.picFile.Location = new System.Drawing.Point(35, 81);
            this.picFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picFile.Name = "picFile";
            this.picFile.Size = new System.Drawing.Size(161, 203);
            this.picFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFile.TabIndex = 0;
            this.picFile.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.LightGray;
            this.lbTitle.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(29, 30);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(78, 28);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(209, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã số : ";
            // 
            // lbFileCode
            // 
            this.lbFileCode.AutoSize = true;
            this.lbFileCode.BackColor = System.Drawing.Color.LightGray;
            this.lbFileCode.Location = new System.Drawing.Point(275, 91);
            this.lbFileCode.Name = "lbFileCode";
            this.lbFileCode.Size = new System.Drawing.Size(46, 17);
            this.lbFileCode.TabIndex = 3;
            this.lbFileCode.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(209, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thể loại : ";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.BackColor = System.Drawing.Color.LightGray;
            this.lbCategory.Location = new System.Drawing.Point(277, 124);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(46, 17);
            this.lbCategory.TabIndex = 5;
            this.lbCategory.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(209, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày thêm vào : ";
            // 
            // lbDateAdd
            // 
            this.lbDateAdd.AutoSize = true;
            this.lbDateAdd.BackColor = System.Drawing.Color.LightGray;
            this.lbDateAdd.Location = new System.Drawing.Point(229, 188);
            this.lbDateAdd.Name = "lbDateAdd";
            this.lbDateAdd.Size = new System.Drawing.Size(46, 17);
            this.lbDateAdd.TabIndex = 7;
            this.lbDateAdd.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(212, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày đọc gần nhất : ";
            // 
            // lbRecentlyRead
            // 
            this.lbRecentlyRead.AutoSize = true;
            this.lbRecentlyRead.BackColor = System.Drawing.Color.LightGray;
            this.lbRecentlyRead.Location = new System.Drawing.Point(233, 255);
            this.lbRecentlyRead.Name = "lbRecentlyRead";
            this.lbRecentlyRead.Size = new System.Drawing.Size(46, 17);
            this.lbRecentlyRead.TabIndex = 9;
            this.lbRecentlyRead.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Location";
            // 
            // lbLinkFile
            // 
            this.lbLinkFile.AutoSize = true;
            this.lbLinkFile.Font = new System.Drawing.Font("Franklin Gothic Demi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLinkFile.Location = new System.Drawing.Point(29, 357);
            this.lbLinkFile.Name = "lbLinkFile";
            this.lbLinkFile.Size = new System.Drawing.Size(50, 20);
            this.lbLinkFile.TabIndex = 11;
            this.lbLinkFile.Text = "label6";
            // 
            // picLinkFile
            // 
            this.picLinkFile.Image = ((System.Drawing.Image)(resources.GetObject("picLinkFile.Image")));
            this.picLinkFile.Location = new System.Drawing.Point(369, 316);
            this.picLinkFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLinkFile.Name = "picLinkFile";
            this.picLinkFile.Size = new System.Drawing.Size(29, 25);
            this.picLinkFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLinkFile.TabIndex = 12;
            this.picLinkFile.TabStop = false;
            this.picLinkFile.Click += new System.EventHandler(this.picLinkFile_Click);
            this.picLinkFile.MouseEnter += new System.EventHandler(this.picLinkFile_MouseEnter);
            this.picLinkFile.MouseLeave += new System.EventHandler(this.picLinkFile_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 298);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(493, 411);
            this.Controls.Add(this.picLinkFile);
            this.Controls.Add(this.lbLinkFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbRecentlyRead);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbDateAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbFileCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.picFile);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProperties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết File";
            ((System.ComponentModel.ISupportInitialize)(this.picFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLinkFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFile;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFileCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDateAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbRecentlyRead;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbLinkFile;
        private System.Windows.Forms.PictureBox picLinkFile;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}