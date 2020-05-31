namespace FileManager.Views
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
            this.components = new System.ComponentModel.Container();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.picUpload = new System.Windows.Forms.PictureBox();
            this.btnPicUpload = new System.Windows.Forms.Button();
            this.txtLinkFolder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpateLink = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbPreview = new System.Windows.Forms.RichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbNote
            // 
            this.rtbNote.Location = new System.Drawing.Point(60, 53);
            this.rtbNote.Margin = new System.Windows.Forms.Padding(2);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(260, 79);
            this.rtbNote.TabIndex = 0;
            this.rtbNote.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ghi Chú";
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.Location = new System.Drawing.Point(375, 319);
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
            this.label2.Location = new System.Drawing.Point(10, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên File";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(60, 21);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(260, 20);
            this.txtTitle.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thể Loại";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(391, 20);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(143, 20);
            this.txtCategory.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(568, 387);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(217, 51);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // picUpload
            // 
            this.picUpload.BackColor = System.Drawing.Color.White;
            this.picUpload.Location = new System.Drawing.Point(568, 21);
            this.picUpload.Margin = new System.Windows.Forms.Padding(2);
            this.picUpload.Name = "picUpload";
            this.picUpload.Size = new System.Drawing.Size(217, 284);
            this.picUpload.TabIndex = 11;
            this.picUpload.TabStop = false;
            // 
            // btnPicUpload
            // 
            this.btnPicUpload.Location = new System.Drawing.Point(632, 317);
            this.btnPicUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnPicUpload.Name = "btnPicUpload";
            this.btnPicUpload.Size = new System.Drawing.Size(97, 26);
            this.btnPicUpload.TabIndex = 12;
            this.btnPicUpload.Text = "Tải lên ảnh bìa";
            this.btnPicUpload.UseVisualStyleBackColor = true;
            this.btnPicUpload.Click += new System.EventHandler(this.btnPicUpload_Click);
            // 
            // txtLinkFolder
            // 
            this.txtLinkFolder.Location = new System.Drawing.Point(61, 323);
            this.txtLinkFolder.Margin = new System.Windows.Forms.Padding(2);
            this.txtLinkFolder.Name = "txtLinkFolder";
            this.txtLinkFolder.ReadOnly = true;
            this.txtLinkFolder.Size = new System.Drawing.Size(260, 20);
            this.txtLinkFolder.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 326);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Đường Dẫn";
            // 
            // btnUpateLink
            // 
            this.btnUpateLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpateLink.Location = new System.Drawing.Point(325, 323);
            this.btnUpateLink.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpateLink.Name = "btnUpateLink";
            this.btnUpateLink.Size = new System.Drawing.Size(28, 22);
            this.btnUpateLink.TabIndex = 15;
            this.btnUpateLink.Text = "...";
            this.btnUpateLink.UseVisualStyleBackColor = true;
            this.btnUpateLink.Click += new System.EventHandler(this.btnDuongDan_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Xem Trước";
            // 
            // rtbPreview
            // 
            this.rtbPreview.Location = new System.Drawing.Point(60, 145);
            this.rtbPreview.Margin = new System.Windows.Forms.Padding(2);
            this.rtbPreview.Name = "rtbPreview";
            this.rtbPreview.ReadOnly = true;
            this.rtbPreview.Size = new System.Drawing.Size(478, 160);
            this.rtbPreview.TabIndex = 17;
            this.rtbPreview.Text = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddFile
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(796, 466);
            this.Controls.Add(this.rtbPreview);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpateLink);
            this.Controls.Add(this.txtLinkFolder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPicUpload);
            this.Controls.Add(this.picUpload);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUploadFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbNote);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddFile";
            this.Text = "Thêm File";
            this.Load += new System.EventHandler(this.frmAddFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picUpload;
        private System.Windows.Forms.Button btnPicUpload;
        private System.Windows.Forms.TextBox txtLinkFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpateLink;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbPreview;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}