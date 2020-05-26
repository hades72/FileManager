namespace FileManager.frmFolder
{
    partial class frmFixFile
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bSave = new System.Windows.Forms.Button();
            this.rSummary = new System.Windows.Forms.RichTextBox();
            this.rNote = new System.Windows.Forms.RichTextBox();
            this.txtKind = new System.Windows.Forms.TextBox();
            this.bUploadFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel1.Controls.Add(this.bSave);
            this.splitContainer1.Panel1.Controls.Add(this.rSummary);
            this.splitContainer1.Panel1.Controls.Add(this.rNote);
            this.splitContainer1.Panel1.Controls.Add(this.txtKind);
            this.splitContainer1.Panel1.Controls.Add(this.bUploadFile);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtTitle);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1165, 681);
            this.splitContainer1.SplitterDistance = 253;
            this.splitContainer1.TabIndex = 0;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(386, 203);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(97, 39);
            this.bSave.TabIndex = 19;
            this.bSave.Text = "Lưu";
            this.bSave.UseVisualStyleBackColor = true;
            // 
            // rSummary
            // 
            this.rSummary.Location = new System.Drawing.Point(740, 12);
            this.rSummary.Name = "rSummary";
            this.rSummary.Size = new System.Drawing.Size(402, 211);
            this.rSummary.TabIndex = 18;
            this.rSummary.Text = "";
            // 
            // rNote
            // 
            this.rNote.Location = new System.Drawing.Point(81, 101);
            this.rNote.Name = "rNote";
            this.rNote.Size = new System.Drawing.Size(402, 96);
            this.rNote.TabIndex = 17;
            this.rNote.Text = "";
            this.rNote.TextChanged += new System.EventHandler(this.rNote_TextChanged);
            // 
            // txtKind
            // 
            this.txtKind.Location = new System.Drawing.Point(81, 57);
            this.txtKind.Name = "txtKind";
            this.txtKind.Size = new System.Drawing.Size(402, 22);
            this.txtKind.TabIndex = 16;
            // 
            // bUploadFile
            // 
            this.bUploadFile.Location = new System.Drawing.Point(81, 203);
            this.bUploadFile.Name = "bUploadFile";
            this.bUploadFile.Size = new System.Drawing.Size(127, 39);
            this.bUploadFile.TabIndex = 15;
            this.bUploadFile.Text = "Tải File lên";
            this.bUploadFile.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(651, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tóm Tắt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ghi chú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Thể Loại";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(81, 26);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(402, 22);
            this.txtTitle.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên File";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1165, 424);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // frmFixFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1165, 681);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmFixFile";
            this.Text = "FixFile";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.RichTextBox rSummary;
        private System.Windows.Forms.RichTextBox rNote;
        private System.Windows.Forms.TextBox txtKind;
        private System.Windows.Forms.Button bUploadFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}