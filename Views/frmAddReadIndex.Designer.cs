namespace FileManager.Views
{
    partial class frmAddReadIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddReadIndex));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteReadIndex = new System.Windows.Forms.Button();
            this.btnAddReadPreview = new System.Windows.Forms.Button();
            this.rtbShowFileReadPreview = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveReadIndex = new System.Windows.Forms.Button();
            this.cbReadPreview = new System.Windows.Forms.ComboBox();
            this.cbCurrentFile = new System.Windows.Forms.ComboBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.btnDeleteReadIndex);
            this.panel1.Controls.Add(this.btnAddReadPreview);
            this.panel1.Controls.Add(this.rtbShowFileReadPreview);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSaveReadIndex);
            this.panel1.Controls.Add(this.cbReadPreview);
            this.panel1.Controls.Add(this.cbCurrentFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 315);
            this.panel1.TabIndex = 0;
            // 
            // btnDeleteReadIndex
            // 
            this.btnDeleteReadIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteReadIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteReadIndex.Location = new System.Drawing.Point(227, 252);
            this.btnDeleteReadIndex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteReadIndex.Name = "btnDeleteReadIndex";
            this.btnDeleteReadIndex.Size = new System.Drawing.Size(103, 49);
            this.btnDeleteReadIndex.TabIndex = 7;
            this.btnDeleteReadIndex.Text = "Xóa";
            this.btnDeleteReadIndex.UseVisualStyleBackColor = true;
            this.btnDeleteReadIndex.Click += new System.EventHandler(this.btnDeleteReadIndex_Click);
            this.btnDeleteReadIndex.MouseEnter += new System.EventHandler(this.btnDeleteReadIndex_MouseEnter);
            this.btnDeleteReadIndex.MouseLeave += new System.EventHandler(this.btnDeleteReadIndex_MouseLeave);
            // 
            // btnAddReadPreview
            // 
            this.btnAddReadPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReadPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReadPreview.Location = new System.Drawing.Point(389, 62);
            this.btnAddReadPreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddReadPreview.Name = "btnAddReadPreview";
            this.btnAddReadPreview.Size = new System.Drawing.Size(69, 36);
            this.btnAddReadPreview.TabIndex = 6;
            this.btnAddReadPreview.Text = "Thêm";
            this.btnAddReadPreview.UseVisualStyleBackColor = true;
            this.btnAddReadPreview.Click += new System.EventHandler(this.btnAddReadPreview_Click);
            this.btnAddReadPreview.MouseEnter += new System.EventHandler(this.btnAddReadPreview_MouseEnter);
            this.btnAddReadPreview.MouseLeave += new System.EventHandler(this.btnAddReadPreview_MouseLeave);
            // 
            // rtbShowFileReadPreview
            // 
            this.rtbShowFileReadPreview.Location = new System.Drawing.Point(28, 130);
            this.rtbShowFileReadPreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbShowFileReadPreview.Name = "rtbShowFileReadPreview";
            this.rtbShowFileReadPreview.Size = new System.Drawing.Size(431, 102);
            this.rtbShowFileReadPreview.TabIndex = 5;
            this.rtbShowFileReadPreview.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "File cần đọc trước";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "File hiện tại";
            // 
            // btnSaveReadIndex
            // 
            this.btnSaveReadIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveReadIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveReadIndex.Location = new System.Drawing.Point(357, 252);
            this.btnSaveReadIndex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveReadIndex.Name = "btnSaveReadIndex";
            this.btnSaveReadIndex.Size = new System.Drawing.Size(103, 49);
            this.btnSaveReadIndex.TabIndex = 2;
            this.btnSaveReadIndex.Text = "Lưu";
            this.btnSaveReadIndex.UseVisualStyleBackColor = true;
            this.btnSaveReadIndex.Click += new System.EventHandler(this.btnSaveReadIndex_Click);
            this.btnSaveReadIndex.MouseEnter += new System.EventHandler(this.btnSaveReadIndex_MouseEnter);
            this.btnSaveReadIndex.MouseLeave += new System.EventHandler(this.btnSaveReadIndex_MouseLeave);
            // 
            // cbReadPreview
            // 
            this.cbReadPreview.FormattingEnabled = true;
            this.cbReadPreview.Location = new System.Drawing.Point(215, 68);
            this.cbReadPreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbReadPreview.Name = "cbReadPreview";
            this.cbReadPreview.Size = new System.Drawing.Size(157, 24);
            this.cbReadPreview.TabIndex = 1;
            // 
            // cbCurrentFile
            // 
            this.cbCurrentFile.FormattingEnabled = true;
            this.cbCurrentFile.Location = new System.Drawing.Point(28, 68);
            this.cbCurrentFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCurrentFile.Name = "cbCurrentFile";
            this.cbCurrentFile.Size = new System.Drawing.Size(155, 24);
            this.cbCurrentFile.TabIndex = 0;
            this.cbCurrentFile.SelectedIndexChanged += new System.EventHandler(this.cbCurrentFile_SelectedIndexChanged);
            // 
            // frmAddReadIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 315);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddReadIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Thứ tự đọc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReadIndex_FormClosing);
            this.Load += new System.EventHandler(this.frmAddReadIndex_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbReadPreview;
        private System.Windows.Forms.ComboBox cbCurrentFile;
        private System.Windows.Forms.Button btnAddReadPreview;
        private System.Windows.Forms.RichTextBox rtbShowFileReadPreview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveReadIndex;
        private System.Windows.Forms.Button btnDeleteReadIndex;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}