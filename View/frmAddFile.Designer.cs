namespace FileManager.View
{
    partial class frmAddFile
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
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbSummary = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.picUpload = new System.Windows.Forms.PictureBox();
            this.btnPicUpload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picUpload)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbNote
            // 
            this.rtbNote.Location = new System.Drawing.Point(68, 246);
            this.rtbNote.Margin = new System.Windows.Forms.Padding(2);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(260, 79);
            this.rtbNote.TabIndex = 0;
            this.rtbNote.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 246);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ghi Chú";
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.Location = new System.Drawing.Point(68, 363);
            this.btnUploadFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(94, 26);
            this.btnUploadFile.TabIndex = 2;
            this.btnUploadFile.Text = "Tải lên File";
            this.btnUploadFile.UseVisualStyleBackColor = true;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên File";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(68, 15);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(260, 20);
            this.txtTitle.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thể Loại";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(68, 54);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(260, 20);
            this.txtCategory.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tóm Tắt";
            // 
            // rtbSummary
            // 
            this.rtbSummary.Location = new System.Drawing.Point(68, 95);
            this.rtbSummary.Margin = new System.Windows.Forms.Padding(2);
            this.rtbSummary.Name = "rtbSummary";
            this.rtbSummary.Size = new System.Drawing.Size(260, 104);
            this.rtbSummary.TabIndex = 9;
            this.rtbSummary.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(272, 363);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 26);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // picUpload
            // 
            this.picUpload.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.picUpload.Location = new System.Drawing.Point(512, 44);
            this.picUpload.Margin = new System.Windows.Forms.Padding(2);
            this.picUpload.Name = "picUpload";
            this.picUpload.Size = new System.Drawing.Size(244, 271);
            this.picUpload.TabIndex = 11;
            this.picUpload.TabStop = false;
            // 
            // btnPicUpload
            // 
            this.btnPicUpload.Location = new System.Drawing.Point(569, 359);
            this.btnPicUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnPicUpload.Name = "btnPicUpload";
            this.btnPicUpload.Size = new System.Drawing.Size(136, 35);
            this.btnPicUpload.TabIndex = 12;
            this.btnPicUpload.Text = "Tải lên ảnh bìa";
            this.btnPicUpload.UseVisualStyleBackColor = true;
            // 
            // frmAddFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 466);
            this.Controls.Add(this.btnPicUpload);
            this.Controls.Add(this.picUpload);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtbSummary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUploadFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbNote);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddFile";
            this.Text = "AddFile";
            this.Load += new System.EventHandler(this.frmAddFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUpload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbSummary;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picUpload;
        private System.Windows.Forms.Button btnPicUpload;
    }
}