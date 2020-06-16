namespace FileManager.Views
{
    partial class frmRead
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRead));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.rtbRead = new System.Windows.Forms.RichTextBox();
            this.ptbBackPage = new System.Windows.Forms.PictureBox();
            this.ptbNextPage = new System.Windows.Forms.PictureBox();
            this.txtCurrentPage = new System.Windows.Forms.TextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.btnDeleteNote = new System.Windows.Forms.Button();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteDrawNote = new System.Windows.Forms.Button();
            this.ptbNote = new System.Windows.Forms.PictureBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBackPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNextPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNote)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(858, 516);
            this.splitContainer1.SplitterDistance = 461;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.rtbRead);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ptbBackPage);
            this.splitContainer2.Panel2.Controls.Add(this.ptbNextPage);
            this.splitContainer2.Panel2.Controls.Add(this.txtCurrentPage);
            this.splitContainer2.Size = new System.Drawing.Size(461, 516);
            this.splitContainer2.SplitterDistance = 467;
            this.splitContainer2.TabIndex = 0;
            // 
            // rtbRead
            // 
            this.rtbRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbRead.Location = new System.Drawing.Point(0, 0);
            this.rtbRead.Margin = new System.Windows.Forms.Padding(2);
            this.rtbRead.Name = "rtbRead";
            this.rtbRead.ReadOnly = true;
            this.rtbRead.Size = new System.Drawing.Size(461, 467);
            this.rtbRead.TabIndex = 0;
            this.rtbRead.Text = "";
            // 
            // ptbBackPage
            // 
            this.ptbBackPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbBackPage.Image = ((System.Drawing.Image)(resources.GetObject("ptbBackPage.Image")));
            this.ptbBackPage.InitialImage = null;
            this.ptbBackPage.Location = new System.Drawing.Point(288, 5);
            this.ptbBackPage.Name = "ptbBackPage";
            this.ptbBackPage.Size = new System.Drawing.Size(40, 35);
            this.ptbBackPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbBackPage.TabIndex = 2;
            this.ptbBackPage.TabStop = false;
            this.ptbBackPage.Click += new System.EventHandler(this.ptbBackPage_Click);
            // 
            // ptbNextPage
            // 
            this.ptbNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbNextPage.Image = ((System.Drawing.Image)(resources.GetObject("ptbNextPage.Image")));
            this.ptbNextPage.InitialImage = null;
            this.ptbNextPage.Location = new System.Drawing.Point(416, 5);
            this.ptbNextPage.Name = "ptbNextPage";
            this.ptbNextPage.Size = new System.Drawing.Size(42, 35);
            this.ptbNextPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbNextPage.TabIndex = 1;
            this.ptbNextPage.TabStop = false;
            this.ptbNextPage.Click += new System.EventHandler(this.ptbNextPage_Click);
            // 
            // txtCurrentPage
            // 
            this.txtCurrentPage.Location = new System.Drawing.Point(334, 14);
            this.txtCurrentPage.Name = "txtCurrentPage";
            this.txtCurrentPage.ReadOnly = true;
            this.txtCurrentPage.Size = new System.Drawing.Size(76, 20);
            this.txtCurrentPage.TabIndex = 3;
            this.txtCurrentPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btnNew);
            this.splitContainer3.Panel2.Controls.Add(this.btnSave);
            this.splitContainer3.Size = new System.Drawing.Size(394, 516);
            this.splitContainer3.SplitterDistance = 450;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.btnDeleteNote);
            this.splitContainer4.Panel1.Controls.Add(this.rtbNote);
            this.splitContainer4.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.btnDeleteDrawNote);
            this.splitContainer4.Panel2.Controls.Add(this.ptbNote);
            this.splitContainer4.Panel2.Controls.Add(this.lb2);
            this.splitContainer4.Size = new System.Drawing.Size(394, 450);
            this.splitContainer4.SplitterDistance = 218;
            this.splitContainer4.TabIndex = 0;
            // 
            // btnDeleteNote
            // 
            this.btnDeleteNote.Enabled = false;
            this.btnDeleteNote.Location = new System.Drawing.Point(7, 192);
            this.btnDeleteNote.Name = "btnDeleteNote";
            this.btnDeleteNote.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteNote.TabIndex = 2;
            this.btnDeleteNote.Text = "Xóa ghi chú";
            this.btnDeleteNote.UseVisualStyleBackColor = true;
            this.btnDeleteNote.Click += new System.EventHandler(this.btnDeleteNote_Click);
            // 
            // rtbNote
            // 
            this.rtbNote.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtbNote.Location = new System.Drawing.Point(88, 0);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(306, 218);
            this.rtbNote.TabIndex = 1;
            this.rtbNote.Text = "";
            this.rtbNote.TextChanged += new System.EventHandler(this.rtbNote_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ghi chú";
            // 
            // btnDeleteDrawNote
            // 
            this.btnDeleteDrawNote.Enabled = false;
            this.btnDeleteDrawNote.Location = new System.Drawing.Point(8, 202);
            this.btnDeleteDrawNote.Name = "btnDeleteDrawNote";
            this.btnDeleteDrawNote.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteDrawNote.TabIndex = 4;
            this.btnDeleteDrawNote.Text = "Xóa hình vẽ";
            this.btnDeleteDrawNote.UseVisualStyleBackColor = true;
            this.btnDeleteDrawNote.Click += new System.EventHandler(this.btnDeleteDrawNote_Click);
            // 
            // ptbNote
            // 
            this.ptbNote.BackgroundImage = global::FileManager.Properties.Resources.nền_trắng_500x500;
            this.ptbNote.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbNote.Location = new System.Drawing.Point(88, 0);
            this.ptbNote.Name = "ptbNote";
            this.ptbNote.Size = new System.Drawing.Size(306, 228);
            this.ptbNote.TabIndex = 3;
            this.ptbNote.TabStop = false;
            this.ptbNote.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ptbNote_MouseDown);
            this.ptbNote.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptbNote_MouseMove);
            this.ptbNote.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptbNote_MouseUp);
            this.ptbNote.Resize += new System.EventHandler(this.ptbNote_Resize);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(3, 11);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(80, 16);
            this.lb2.TabIndex = 2;
            this.lb2.Text = "Vẽ ghi chú";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNew.Location = new System.Drawing.Point(0, 0);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(192, 62);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Xóa tất cả";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(196, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(198, 62);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu ghi chú";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 516);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRead";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRead_FormClosing);
            this.Load += new System.EventHandler(this.frmRead_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbBackPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNextPage)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbNote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rtbRead;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox ptbNextPage;
        private System.Windows.Forms.PictureBox ptbBackPage;
        private System.Windows.Forms.TextBox txtCurrentPage;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button btnDeleteNote;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteDrawNote;
        private System.Windows.Forms.PictureBox ptbNote;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Button btnNew;
    }
}