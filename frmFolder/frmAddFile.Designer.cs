namespace FileManager.frmFolder
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
            this.rNote = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bUploadFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rSummary = new System.Windows.Forms.RichTextBox();
            this.bSave = new System.Windows.Forms.Button();
            this.picUpload = new System.Windows.Forms.PictureBox();
            this.bPicUpload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picUpload)).BeginInit();
            this.SuspendLayout();
            // 
            // rNote
            // 
            this.rNote.Location = new System.Drawing.Point(91, 303);
            this.rNote.Name = "rNote";
            this.rNote.Size = new System.Drawing.Size(345, 96);
            this.rNote.TabIndex = 0;
            this.rNote.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ghi Chú";
            // 
            // bUploadFile
            // 
            this.bUploadFile.Location = new System.Drawing.Point(91, 453);
            this.bUploadFile.Name = "bUploadFile";
            this.bUploadFile.Size = new System.Drawing.Size(125, 32);
            this.bUploadFile.TabIndex = 2;
            this.bUploadFile.Text = "Tải lên File";
            this.bUploadFile.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên File";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(91, 19);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(345, 22);
            this.txtTitle.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thể Loại";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(345, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tóm Tắt";
            // 
            // rSummary
            // 
            this.rSummary.Location = new System.Drawing.Point(91, 117);
            this.rSummary.Name = "rSummary";
            this.rSummary.Size = new System.Drawing.Size(345, 127);
            this.rSummary.TabIndex = 9;
            this.rSummary.Text = "";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(361, 453);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 32);
            this.bSave.TabIndex = 10;
            this.bSave.Text = "Lưu";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // picUpload
            // 
            this.picUpload.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.picUpload.Location = new System.Drawing.Point(699, 66);
            this.picUpload.Name = "picUpload";
            this.picUpload.Size = new System.Drawing.Size(326, 333);
            this.picUpload.TabIndex = 11;
            this.picUpload.TabStop = false;
            // 
            // bPicUpload
            // 
            this.bPicUpload.Location = new System.Drawing.Point(759, 442);
            this.bPicUpload.Name = "bPicUpload";
            this.bPicUpload.Size = new System.Drawing.Size(182, 43);
            this.bPicUpload.TabIndex = 12;
            this.bPicUpload.Text = "Tải lên ảnh bìa";
            this.bPicUpload.UseVisualStyleBackColor = true;
            // 
            // frmAddFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 573);
            this.Controls.Add(this.bPicUpload);
            this.Controls.Add(this.picUpload);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.rSummary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bUploadFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rNote);
            this.Name = "frmAddFile";
            this.Text = "AddFile";
            ((System.ComponentModel.ISupportInitialize)(this.picUpload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bUploadFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rSummary;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.PictureBox picUpload;
        private System.Windows.Forms.Button bPicUpload;
    }
}