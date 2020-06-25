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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddFile));
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPicUpload = new System.Windows.Forms.Button();
            this.txtLinkFolder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpateLink = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbPreview = new System.Windows.Forms.RichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtFileCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.picUpload = new System.Windows.Forms.PictureBox();
            this.txtCurrentCategory = new System.Windows.Forms.TextBox();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpload)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.Location = new System.Drawing.Point(618, 676);
            this.btnUploadFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(125, 32);
            this.btnUploadFile.TabIndex = 3;
            this.btnUploadFile.Text = "Tải lên File";
            this.btnUploadFile.UseVisualStyleBackColor = true;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên File";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(109, 68);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(631, 22);
            this.txtTitle.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(762, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thể Loại";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(853, 579);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(289, 63);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPicUpload
            // 
            this.btnPicUpload.Location = new System.Drawing.Point(917, 495);
            this.btnPicUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPicUpload.Name = "btnPicUpload";
            this.btnPicUpload.Size = new System.Drawing.Size(129, 32);
            this.btnPicUpload.TabIndex = 4;
            this.btnPicUpload.Text = "Tải lên ảnh bìa";
            this.btnPicUpload.UseVisualStyleBackColor = true;
            this.btnPicUpload.Click += new System.EventHandler(this.btnPicUpload_Click);
            // 
            // txtLinkFolder
            // 
            this.txtLinkFolder.Location = new System.Drawing.Point(109, 681);
            this.txtLinkFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLinkFolder.Name = "txtLinkFolder";
            this.txtLinkFolder.ReadOnly = true;
            this.txtLinkFolder.Size = new System.Drawing.Size(444, 22);
            this.txtLinkFolder.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 686);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Đường Dẫn";
            // 
            // btnUpateLink
            // 
            this.btnUpateLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpateLink.Location = new System.Drawing.Point(558, 676);
            this.btnUpateLink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpateLink.Name = "btnUpateLink";
            this.btnUpateLink.Size = new System.Drawing.Size(37, 32);
            this.btnUpateLink.TabIndex = 15;
            this.btnUpateLink.Text = "...";
            this.btnUpateLink.UseVisualStyleBackColor = true;
            this.btnUpateLink.Click += new System.EventHandler(this.btnDuongDan_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Xem Trước";
            // 
            // rtbPreview
            // 
            this.rtbPreview.BackColor = System.Drawing.Color.White;
            this.rtbPreview.Location = new System.Drawing.Point(109, 121);
            this.rtbPreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbPreview.Name = "rtbPreview";
            this.rtbPreview.ReadOnly = true;
            this.rtbPreview.Size = new System.Drawing.Size(631, 521);
            this.rtbPreview.TabIndex = 17;
            this.rtbPreview.Text = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtFileCode
            // 
            this.txtFileCode.BackColor = System.Drawing.Color.White;
            this.txtFileCode.Location = new System.Drawing.Point(109, 24);
            this.txtFileCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFileCode.Name = "txtFileCode";
            this.txtFileCode.ReadOnly = true;
            this.txtFileCode.Size = new System.Drawing.Size(125, 22);
            this.txtFileCode.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã Số";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(834, 24);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(181, 24);
            this.cbCategory.TabIndex = 2;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddCategory.Location = new System.Drawing.Point(1048, 21);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(75, 28);
            this.btnAddCategory.TabIndex = 20;
            this.btnAddCategory.Text = "Chọn";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // picUpload
            // 
            this.picUpload.BackColor = System.Drawing.Color.Transparent;
            this.picUpload.Location = new System.Drawing.Point(834, 121);
            this.picUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picUpload.Name = "picUpload";
            this.picUpload.Size = new System.Drawing.Size(289, 357);
            this.picUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUpload.TabIndex = 11;
            this.picUpload.TabStop = false;
            // 
            // txtCurrentCategory
            // 
            this.txtCurrentCategory.Location = new System.Drawing.Point(834, 68);
            this.txtCurrentCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCurrentCategory.Name = "txtCurrentCategory";
            this.txtCurrentCategory.ReadOnly = true;
            this.txtCurrentCategory.Size = new System.Drawing.Size(181, 22);
            this.txtCurrentCategory.TabIndex = 21;
            this.txtCurrentCategory.TextChanged += new System.EventHandler(this.txtCurrentCategory_TextChanged);
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.Enabled = false;
            this.btnRemoveCategory.Location = new System.Drawing.Point(1048, 64);
            this.btnRemoveCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(75, 30);
            this.btnRemoveCategory.TabIndex = 22;
            this.btnRemoveCategory.Text = "Xóa";
            this.btnRemoveCategory.UseVisualStyleBackColor = true;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
            // 
            // frmAddFile
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1159, 750);
            this.Controls.Add(this.btnRemoveCategory);
            this.Controls.Add(this.txtCurrentCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.txtFileCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbPreview);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpateLink);
            this.Controls.Add(this.txtLinkFolder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPicUpload);
            this.Controls.Add(this.picUpload);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUploadFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm File";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddFile_FormClosing);
            this.Load += new System.EventHandler(this.frmAddFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picUpload;
        private System.Windows.Forms.Button btnPicUpload;
        private System.Windows.Forms.TextBox txtLinkFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpateLink;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbPreview;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtFileCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox txtCurrentCategory;
        private System.Windows.Forms.Button btnRemoveCategory;
    }
}