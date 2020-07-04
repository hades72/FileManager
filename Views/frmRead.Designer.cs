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
            this.cbbWidth = new System.Windows.Forms.ComboBox();
            this.btnColorPen = new System.Windows.Forms.Button();
            this.btnDeleteDrawNote = new System.Windows.Forms.Button();
            this.ptbNote = new System.Windows.Forms.PictureBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnFont = new System.Windows.Forms.Button();
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
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.helpProvider1.SetShowHelp(this.splitContainer1.Panel1, ((bool)(resources.GetObject("splitContainer1.Panel1.ShowHelp"))));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.helpProvider1.SetShowHelp(this.splitContainer1.Panel2, ((bool)(resources.GetObject("splitContainer1.Panel2.ShowHelp"))));
            this.helpProvider1.SetShowHelp(this.splitContainer1, ((bool)(resources.GetObject("splitContainer1.ShowHelp"))));
            // 
            // splitContainer2
            // 
            resources.ApplyResources(this.splitContainer2, "splitContainer2");
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.rtbRead);
            this.helpProvider1.SetShowHelp(this.splitContainer2.Panel1, ((bool)(resources.GetObject("splitContainer2.Panel1.ShowHelp"))));
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer2.Panel2.Controls.Add(this.btnFont);
            this.splitContainer2.Panel2.Controls.Add(this.ptbBackPage);
            this.splitContainer2.Panel2.Controls.Add(this.ptbNextPage);
            this.splitContainer2.Panel2.Controls.Add(this.txtCurrentPage);
            this.helpProvider1.SetShowHelp(this.splitContainer2.Panel2, ((bool)(resources.GetObject("splitContainer2.Panel2.ShowHelp"))));
            this.helpProvider1.SetShowHelp(this.splitContainer2, ((bool)(resources.GetObject("splitContainer2.ShowHelp"))));
            // 
            // rtbRead
            // 
            this.rtbRead.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.rtbRead, "rtbRead");
            this.rtbRead.Name = "rtbRead";
            this.rtbRead.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.rtbRead, ((bool)(resources.GetObject("rtbRead.ShowHelp"))));
            // 
            // ptbBackPage
            // 
            this.ptbBackPage.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ptbBackPage, "ptbBackPage");
            this.ptbBackPage.Name = "ptbBackPage";
            this.helpProvider1.SetShowHelp(this.ptbBackPage, ((bool)(resources.GetObject("ptbBackPage.ShowHelp"))));
            this.ptbBackPage.TabStop = false;
            this.ptbBackPage.Click += new System.EventHandler(this.ptbBackPage_Click);
            // 
            // ptbNextPage
            // 
            this.ptbNextPage.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ptbNextPage, "ptbNextPage");
            this.ptbNextPage.Name = "ptbNextPage";
            this.helpProvider1.SetShowHelp(this.ptbNextPage, ((bool)(resources.GetObject("ptbNextPage.ShowHelp"))));
            this.ptbNextPage.TabStop = false;
            this.ptbNextPage.Click += new System.EventHandler(this.ptbNextPage_Click);
            // 
            // txtCurrentPage
            // 
            this.txtCurrentPage.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtCurrentPage, "txtCurrentPage");
            this.txtCurrentPage.Name = "txtCurrentPage";
            this.txtCurrentPage.ReadOnly = true;
            this.helpProvider1.SetShowHelp(this.txtCurrentPage, ((bool)(resources.GetObject("txtCurrentPage.ShowHelp"))));
            // 
            // splitContainer3
            // 
            resources.ApplyResources(this.splitContainer3, "splitContainer3");
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            this.helpProvider1.SetShowHelp(this.splitContainer3.Panel1, ((bool)(resources.GetObject("splitContainer3.Panel1.ShowHelp"))));
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer3.Panel2.Controls.Add(this.btnNew);
            this.splitContainer3.Panel2.Controls.Add(this.btnSave);
            this.helpProvider1.SetShowHelp(this.splitContainer3.Panel2, ((bool)(resources.GetObject("splitContainer3.Panel2.ShowHelp"))));
            this.helpProvider1.SetShowHelp(this.splitContainer3, ((bool)(resources.GetObject("splitContainer3.ShowHelp"))));
            // 
            // splitContainer4
            // 
            resources.ApplyResources(this.splitContainer4, "splitContainer4");
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer4.Panel1.Controls.Add(this.btnDeleteNote);
            this.splitContainer4.Panel1.Controls.Add(this.rtbNote);
            this.splitContainer4.Panel1.Controls.Add(this.label1);
            this.helpProvider1.SetShowHelp(this.splitContainer4.Panel1, ((bool)(resources.GetObject("splitContainer4.Panel1.ShowHelp"))));
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer4.Panel2.Controls.Add(this.cbbWidth);
            this.splitContainer4.Panel2.Controls.Add(this.btnColorPen);
            this.splitContainer4.Panel2.Controls.Add(this.btnDeleteDrawNote);
            this.splitContainer4.Panel2.Controls.Add(this.ptbNote);
            this.splitContainer4.Panel2.Controls.Add(this.lb2);
            this.helpProvider1.SetShowHelp(this.splitContainer4.Panel2, ((bool)(resources.GetObject("splitContainer4.Panel2.ShowHelp"))));
            this.helpProvider1.SetShowHelp(this.splitContainer4, ((bool)(resources.GetObject("splitContainer4.ShowHelp"))));
            // 
            // btnDeleteNote
            // 
            resources.ApplyResources(this.btnDeleteNote, "btnDeleteNote");
            this.btnDeleteNote.Name = "btnDeleteNote";
            this.helpProvider1.SetShowHelp(this.btnDeleteNote, ((bool)(resources.GetObject("btnDeleteNote.ShowHelp"))));
            this.btnDeleteNote.UseVisualStyleBackColor = true;
            this.btnDeleteNote.Click += new System.EventHandler(this.btnDeleteNote_Click);
            this.btnDeleteNote.MouseEnter += new System.EventHandler(this.btnDeleteNote_MouseEnter);
            this.btnDeleteNote.MouseLeave += new System.EventHandler(this.btnDeleteNote_MouseLeave);
            // 
            // rtbNote
            // 
            this.rtbNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.rtbNote, "rtbNote");
            this.rtbNote.Name = "rtbNote";
            this.helpProvider1.SetShowHelp(this.rtbNote, ((bool)(resources.GetObject("rtbNote.ShowHelp"))));
            this.rtbNote.TextChanged += new System.EventHandler(this.rtbNote_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.helpProvider1.SetShowHelp(this.label1, ((bool)(resources.GetObject("label1.ShowHelp"))));
            // 
            // cbbWidth
            // 
            this.cbbWidth.BackColor = System.Drawing.Color.AliceBlue;
            resources.ApplyResources(this.cbbWidth, "cbbWidth");
            this.cbbWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbWidth.FormattingEnabled = true;
            this.cbbWidth.Items.AddRange(new object[] {
            resources.GetString("cbbWidth.Items"),
            resources.GetString("cbbWidth.Items1"),
            resources.GetString("cbbWidth.Items2"),
            resources.GetString("cbbWidth.Items3"),
            resources.GetString("cbbWidth.Items4")});
            this.cbbWidth.Name = "cbbWidth";
            this.cbbWidth.SelectedIndexChanged += new System.EventHandler(this.cbbWidth_SelectedIndexChanged);
            // 
            // btnColorPen
            // 
            this.btnColorPen.BackColor = System.Drawing.Color.AliceBlue;
            resources.ApplyResources(this.btnColorPen, "btnColorPen");
            this.btnColorPen.Name = "btnColorPen";
            this.btnColorPen.UseVisualStyleBackColor = false;
            this.btnColorPen.Click += new System.EventHandler(this.btnColorPen_Click);
            this.btnColorPen.MouseEnter += new System.EventHandler(this.btnColorPen_MouseEnter);
            this.btnColorPen.MouseLeave += new System.EventHandler(this.btnColorPen_MouseLeave);
            // 
            // btnDeleteDrawNote
            // 
            this.btnDeleteDrawNote.BackColor = System.Drawing.Color.AliceBlue;
            resources.ApplyResources(this.btnDeleteDrawNote, "btnDeleteDrawNote");
            this.btnDeleteDrawNote.Name = "btnDeleteDrawNote";
            this.helpProvider1.SetShowHelp(this.btnDeleteDrawNote, ((bool)(resources.GetObject("btnDeleteDrawNote.ShowHelp"))));
            this.btnDeleteDrawNote.UseVisualStyleBackColor = false;
            this.btnDeleteDrawNote.Click += new System.EventHandler(this.btnDeleteDrawNote_Click);
            this.btnDeleteDrawNote.MouseEnter += new System.EventHandler(this.btnDeleteDrawNote_MouseEnter);
            this.btnDeleteDrawNote.MouseLeave += new System.EventHandler(this.btnDeleteDrawNote_MouseLeave);
            // 
            // ptbNote
            // 
            this.ptbNote.BackgroundImage = global::FileManager.Properties.Resources.nền_trắng_500x500;
            this.ptbNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.ptbNote, "ptbNote");
            this.ptbNote.Name = "ptbNote";
            this.helpProvider1.SetShowHelp(this.ptbNote, ((bool)(resources.GetObject("ptbNote.ShowHelp"))));
            this.ptbNote.TabStop = false;
            this.ptbNote.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ptbNote_MouseDown);
            this.ptbNote.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptbNote_MouseMove);
            this.ptbNote.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptbNote_MouseUp);
            this.ptbNote.Resize += new System.EventHandler(this.ptbNote_Resize);
            // 
            // lb2
            // 
            resources.ApplyResources(this.lb2, "lb2");
            this.lb2.Name = "lb2";
            this.helpProvider1.SetShowHelp(this.lb2, ((bool)(resources.GetObject("lb2.ShowHelp"))));
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.AliceBlue;
            resources.ApplyResources(this.btnNew, "btnNew");
            this.btnNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNew.Name = "btnNew";
            this.helpProvider1.SetShowHelp(this.btnNew, ((bool)(resources.GetObject("btnNew.ShowHelp"))));
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            this.btnNew.MouseEnter += new System.EventHandler(this.btnNew_MouseEnter);
            this.btnNew.MouseLeave += new System.EventHandler(this.btnNew_MouseLeave);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.AliceBlue;
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Name = "btnSave";
            this.helpProvider1.SetShowHelp(this.btnSave, ((bool)(resources.GetObject("btnSave.ShowHelp"))));
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // btnFont
            // 
            resources.ApplyResources(this.btnFont, "btnFont");
            this.btnFont.Name = "btnFont";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // frmRead
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmRead";
            this.helpProvider1.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Button btnColorPen;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ComboBox cbbWidth;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}