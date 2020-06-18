using System;

namespace FileManager.Views
{
    partial class frmViewThumb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewThumb));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlDanhMuc = new System.Windows.Forms.Panel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabView = new System.Windows.Forms.TabControl();
            this.tabThumb = new System.Windows.Forms.TabPage();
            this.flpnlThumb = new System.Windows.Forms.FlowLayoutPanel();
            this.listViewThumb1 = new FileManager.Views.listViewThumb();
            this.tabDataGV = new System.Windows.Forms.TabPage();
            this.dataFileM = new System.Windows.Forms.DataGridView();
            this.cFileCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRecentlyRead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabAddFile = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlDanhMuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabView.SuspendLayout();
            this.tabThumb.SuspendLayout();
            this.flpnlThumb.SuspendLayout();
            this.tabDataGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFileM)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer1.Panel1.Controls.Add(this.pnlDanhMuc);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1354, 635);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // pnlDanhMuc
            // 
            this.pnlDanhMuc.Controls.Add(this.splitContainer3);
            this.pnlDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.pnlDanhMuc.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDanhMuc.Name = "pnlDanhMuc";
            this.pnlDanhMuc.Size = new System.Drawing.Size(200, 635);
            this.pnlDanhMuc.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer3.Size = new System.Drawing.Size(200, 635);
            this.splitContainer3.SplitterDistance = 126;
            this.splitContainer3.SplitterWidth = 3;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer2.Panel1.Controls.Add(this.btnReadFile);
            this.splitContainer2.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer2.Panel1.Controls.Add(this.txtSearch);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabView);
            this.splitContainer2.Size = new System.Drawing.Size(1151, 635);
            this.splitContainer2.SplitterDistance = 57;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(558, 5);
            this.btnReadFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(82, 41);
            this.btnReadFile.TabIndex = 18;
            this.btnReadFile.Text = "Đọc file";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(378, 5);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSearch.Size = new System.Drawing.Size(82, 41);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(28, 16);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(346, 20);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.tabThumb);
            this.tabView.Controls.Add(this.tabDataGV);
            this.tabView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabView.Location = new System.Drawing.Point(0, 0);
            this.tabView.Margin = new System.Windows.Forms.Padding(2);
            this.tabView.Name = "tabView";
            this.tabView.SelectedIndex = 0;
            this.tabView.Size = new System.Drawing.Size(1151, 575);
            this.tabView.TabIndex = 0;
            this.tabView.SelectedIndexChanged += new System.EventHandler(this.tabView_SelectedIndexChanged);
            // 
            // tabThumb
            // 
            this.tabThumb.Controls.Add(this.flpnlThumb);
            this.tabThumb.Location = new System.Drawing.Point(4, 22);
            this.tabThumb.Margin = new System.Windows.Forms.Padding(2);
            this.tabThumb.Name = "tabThumb";
            this.tabThumb.Size = new System.Drawing.Size(1143, 549);
            this.tabThumb.TabIndex = 0;
            this.tabThumb.Text = "Theo hình";
            this.tabThumb.UseVisualStyleBackColor = true;
            // 
            // flpnlThumb
            // 
            this.flpnlThumb.Controls.Add(this.listViewThumb1);
            this.flpnlThumb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnlThumb.Location = new System.Drawing.Point(0, 0);
            this.flpnlThumb.Margin = new System.Windows.Forms.Padding(2);
            this.flpnlThumb.Name = "flpnlThumb";
            this.flpnlThumb.Size = new System.Drawing.Size(1143, 549);
            this.flpnlThumb.TabIndex = 0;
            // 
            // listViewThumb1
            // 
            this.listViewThumb1.BackColor = System.Drawing.Color.White;
            this.listViewThumb1.Category = null;
            this.listViewThumb1.FileCode = null;
            this.listViewThumb1.LinkFile = null;
            this.listViewThumb1.Location = new System.Drawing.Point(2, 2);
            this.listViewThumb1.Margin = new System.Windows.Forms.Padding(2);
            this.listViewThumb1.Name = "listViewThumb1";
            this.listViewThumb1.Note = null;
            this.listViewThumb1.RecentlyRead = null;
            this.listViewThumb1.Size = new System.Drawing.Size(205, 157);
            this.listViewThumb1.TabIndex = 0;
            this.listViewThumb1.Title = null;
            // 
            // tabDataGV
            // 
            this.tabDataGV.Controls.Add(this.dataFileM);
            this.tabDataGV.Location = new System.Drawing.Point(4, 22);
            this.tabDataGV.Margin = new System.Windows.Forms.Padding(2);
            this.tabDataGV.Name = "tabDataGV";
            this.tabDataGV.Size = new System.Drawing.Size(1143, 549);
            this.tabDataGV.TabIndex = 1;
            this.tabDataGV.Text = "Theo danh sách";
            this.tabDataGV.UseVisualStyleBackColor = true;
            // 
            // dataFileM
            // 
            this.dataFileM.AllowUserToAddRows = false;
            this.dataFileM.BackgroundColor = System.Drawing.Color.White;
            this.dataFileM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFileM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cFileCode,
            this.cTitle,
            this.cCategory,
            this.cDateUpdate,
            this.cRecentlyRead,
            this.cDelete});
            this.dataFileM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataFileM.Location = new System.Drawing.Point(0, 0);
            this.dataFileM.Margin = new System.Windows.Forms.Padding(2);
            this.dataFileM.Name = "dataFileM";
            this.dataFileM.ReadOnly = true;
            this.dataFileM.RowHeadersWidth = 51;
            this.dataFileM.RowTemplate.Height = 24;
            this.dataFileM.Size = new System.Drawing.Size(1143, 549);
            this.dataFileM.TabIndex = 1;
            this.dataFileM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFileM_CellContentClick);
            // 
            // cFileCode
            // 
            this.cFileCode.HeaderText = "Mã số File";
            this.cFileCode.MinimumWidth = 6;
            this.cFileCode.Name = "cFileCode";
            this.cFileCode.ReadOnly = true;
            this.cFileCode.Width = 80;
            // 
            // cTitle
            // 
            this.cTitle.HeaderText = "Tên File";
            this.cTitle.MinimumWidth = 6;
            this.cTitle.Name = "cTitle";
            this.cTitle.ReadOnly = true;
            this.cTitle.Width = 200;
            // 
            // cCategory
            // 
            this.cCategory.HeaderText = "Thể Loại";
            this.cCategory.MinimumWidth = 6;
            this.cCategory.Name = "cCategory";
            this.cCategory.ReadOnly = true;
            this.cCategory.Width = 125;
            // 
            // cDateUpdate
            // 
            this.cDateUpdate.HeaderText = "Ngày cập nhật";
            this.cDateUpdate.MinimumWidth = 6;
            this.cDateUpdate.Name = "cDateUpdate";
            this.cDateUpdate.ReadOnly = true;
            this.cDateUpdate.Width = 125;
            // 
            // cRecentlyRead
            // 
            this.cRecentlyRead.HeaderText = "Gần đây đã đọc";
            this.cRecentlyRead.MinimumWidth = 6;
            this.cRecentlyRead.Name = "cRecentlyRead";
            this.cRecentlyRead.ReadOnly = true;
            this.cRecentlyRead.Width = 125;
            // 
            // cDelete
            // 
            this.cDelete.HeaderText = "Xóa File";
            this.cDelete.MinimumWidth = 6;
            this.cDelete.Name = "cDelete";
            this.cDelete.ReadOnly = true;
            this.cDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cDelete.Text = "Xóa";
            this.cDelete.UseColumnTextForButtonValue = true;
            this.cDelete.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "File đọc gần nhất";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1354, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabAddFile});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // tabAddFile
            // 
            this.tabAddFile.Name = "tabAddFile";
            this.tabAddFile.Size = new System.Drawing.Size(126, 22);
            this.tabAddFile.Text = "&Thêm File";
            this.tabAddFile.Click += new System.EventHandler(this.tabAddFile_Click);
            // 
            // frmViewThumb
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 659);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmViewThumb";
            this.Text = "frmViewThumb";
            this.Load += new System.EventHandler(this.frmViewThumb_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlDanhMuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabView.ResumeLayout(false);
            this.tabThumb.ResumeLayout(false);
            this.flpnlThumb.ResumeLayout(false);
            this.tabDataGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFileM)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabView;
        private System.Windows.Forms.TabPage tabThumb;
        private System.Windows.Forms.FlowLayoutPanel flpnlThumb;
        private System.Windows.Forms.TabPage tabDataGV;
        private System.Windows.Forms.DataGridView dataFileM;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFileCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRecentlyRead;
        private System.Windows.Forms.DataGridViewButtonColumn cDelete;
        private System.Windows.Forms.Panel pnlDanhMuc;
        private listViewThumb listViewThumb1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabAddFile;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label1;
    }
}