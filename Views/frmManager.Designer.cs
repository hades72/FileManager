namespace FileManager.Views
{
    partial class frmManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManager));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.listCategory = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataFileM = new System.Windows.Forms.DataGridView();
            this.cFileCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCategory = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cDateUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFileM)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox4);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.listCategory);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataFileM);
            this.splitContainer1.Size = new System.Drawing.Size(1224, 605);
            this.splitContainer1.SplitterDistance = 170;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(698, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thể Loại";
            // 
            // listCategory
            // 
            this.listCategory.FormattingEnabled = true;
            this.listCategory.ItemHeight = 16;
            this.listCategory.Location = new System.Drawing.Point(813, 39);
            this.listCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listCategory.Name = "listCategory";
            this.listCategory.Size = new System.Drawing.Size(276, 68);
            this.listCategory.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(515, 35);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSearch.Size = new System.Drawing.Size(109, 37);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(40, 42);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(460, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataFileM
            // 
            this.dataFileM.AllowUserToAddRows = false;
            this.dataFileM.AllowUserToDeleteRows = false;
            this.dataFileM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFileM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cFileCode,
            this.cTitle,
            this.cCategory,
            this.cDateUpdate,
            this.cDelete});
            this.dataFileM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataFileM.Location = new System.Drawing.Point(0, 0);
            this.dataFileM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataFileM.Name = "dataFileM";
            this.dataFileM.ReadOnly = true;
            this.dataFileM.RowHeadersWidth = 51;
            this.dataFileM.RowTemplate.Height = 24;
            this.dataFileM.Size = new System.Drawing.Size(1224, 431);
            this.dataFileM.TabIndex = 0;
            this.dataFileM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFileM_CellContentClick);
            // 
            // cFileCode
            // 
            this.cFileCode.HeaderText = "Mã số File";
            this.cFileCode.MinimumWidth = 6;
            this.cFileCode.Name = "cFileCode";
            this.cFileCode.ReadOnly = true;
            this.cFileCode.Width = 125;
            // 
            // cTitle
            // 
            this.cTitle.HeaderText = "Tên File";
            this.cTitle.MinimumWidth = 6;
            this.cTitle.Name = "cTitle";
            this.cTitle.ReadOnly = true;
            this.cTitle.Width = 125;
            // 
            // cCategory
            // 
            this.cCategory.HeaderText = "Thể Loại";
            this.cCategory.MinimumWidth = 6;
            this.cCategory.Name = "cCategory";
            this.cCategory.ReadOnly = true;
            this.cCategory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // cDelete
            // 
            this.cDelete.HeaderText = "Xóa File";
            this.cDelete.MinimumWidth = 6;
            this.cDelete.Name = "cDelete";
            this.cDelete.ReadOnly = true;
            this.cDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cDelete.Text = "Xóa";
            this.cDelete.UseColumnTextForButtonValue = true;
            this.cDelete.Width = 125;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1224, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddFileToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // AddFileToolStripMenuItem
            // 
            this.AddFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AddFileToolStripMenuItem.Image")));
            this.AddFileToolStripMenuItem.Name = "AddFileToolStripMenuItem";
            this.AddFileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.AddFileToolStripMenuItem.Text = "&Thêm File";
            this.AddFileToolStripMenuItem.Click += new System.EventHandler(this.AddFileToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ExitToolStripMenuItem.Image")));
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ExitToolStripMenuItem.Text = "&Thoát";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.InitialImage")));
            this.pictureBox4.Location = new System.Drawing.Point(768, 39);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 40);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 633);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmManager";
            this.Text = "Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFileM)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listCategory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataFileM;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFileCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTitle;
        private System.Windows.Forms.DataGridViewComboBoxColumn cCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn cDelete;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

