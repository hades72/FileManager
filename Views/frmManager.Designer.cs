using System;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManager));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlDanhMuc = new System.Windows.Forms.Panel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.pnlLastRead = new System.Windows.Forms.Panel();
            this.lbFileCode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReadLastFile = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.picLastFile = new System.Windows.Forms.PictureBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnRecentlyRead = new System.Windows.Forms.Button();
            this.btnRecentlyAdd = new System.Windows.Forms.Button();
            this.btnAllFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabView = new System.Windows.Forms.TabControl();
            this.tabThumb = new System.Windows.Forms.TabPage();
            this.flpnlThumb = new System.Windows.Forms.FlowLayoutPanel();
            this.ctmenuRefresh = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.tabDataGV = new System.Windows.Forms.TabPage();
            this.dataFileM = new System.Windows.Forms.DataGridView();
            this.cFileCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRecentlyRead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cReadIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFile = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.addReadIndex = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.lbShowDanhMuc = new System.Windows.Forms.Label();
            this.usrViewThumb = new FileManager.Views.usrViewThumb();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlDanhMuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.pnlLastRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLastFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabView.SuspendLayout();
            this.tabThumb.SuspendLayout();
            this.flpnlThumb.SuspendLayout();
            this.ctmenuRefresh.SuspendLayout();
            this.tabDataGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFileM)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
            this.splitContainer1.Size = new System.Drawing.Size(1924, 1025);
            this.splitContainer1.SplitterDistance = 321;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // pnlDanhMuc
            // 
            this.pnlDanhMuc.Controls.Add(this.splitContainer3);
            this.pnlDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.pnlDanhMuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDanhMuc.Name = "pnlDanhMuc";
            this.pnlDanhMuc.Size = new System.Drawing.Size(321, 1025);
            this.pnlDanhMuc.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.pnlLastRead);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.cbCategory);
            this.splitContainer3.Panel2.Controls.Add(this.btnRecentlyRead);
            this.splitContainer3.Panel2.Controls.Add(this.btnRecentlyAdd);
            this.splitContainer3.Panel2.Controls.Add(this.btnAllFile);
            this.splitContainer3.Panel2.Controls.Add(this.label3);
            this.splitContainer3.Size = new System.Drawing.Size(321, 1025);
            this.splitContainer3.SplitterDistance = 325;
            this.splitContainer3.TabIndex = 0;
            // 
            // pnlLastRead
            // 
            this.pnlLastRead.Controls.Add(this.lbFileCode);
            this.pnlLastRead.Controls.Add(this.label2);
            this.pnlLastRead.Controls.Add(this.btnReadLastFile);
            this.pnlLastRead.Controls.Add(this.lbTitle);
            this.pnlLastRead.Controls.Add(this.picLastFile);
            this.pnlLastRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLastRead.Location = new System.Drawing.Point(0, 0);
            this.pnlLastRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLastRead.Name = "pnlLastRead";
            this.pnlLastRead.Size = new System.Drawing.Size(319, 323);
            this.pnlLastRead.TabIndex = 2;
            this.pnlLastRead.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlLastRead_MouseDoubleClick);
            // 
            // lbFileCode
            // 
            this.lbFileCode.AutoSize = true;
            this.lbFileCode.Location = new System.Drawing.Point(131, 153);
            this.lbFileCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFileCode.Name = "lbFileCode";
            this.lbFileCode.Size = new System.Drawing.Size(0, 17);
            this.lbFileCode.TabIndex = 4;
            this.lbFileCode.Visible = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "FILE ĐỌC GẦN NHẤT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReadLastFile
            // 
            this.btnReadLastFile.Location = new System.Drawing.Point(88, 260);
            this.btnReadLastFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReadLastFile.Name = "btnReadLastFile";
            this.btnReadLastFile.Size = new System.Drawing.Size(125, 28);
            this.btnReadLastFile.TabIndex = 3;
            this.btnReadLastFile.Text = "Đọc File";
            this.btnReadLastFile.UseVisualStyleBackColor = true;
            this.btnReadLastFile.Click += new System.EventHandler(this.btnReadLastFile_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Location = new System.Drawing.Point(13, 203);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(232, 32);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLastFile
            // 
            this.picLastFile.BackColor = System.Drawing.Color.Transparent;
            this.picLastFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLastFile.Location = new System.Drawing.Point(92, 41);
            this.picLastFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLastFile.Name = "picLastFile";
            this.picLastFile.Size = new System.Drawing.Size(121, 160);
            this.picLastFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLastFile.TabIndex = 1;
            this.picLastFile.TabStop = false;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.White;
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(0, 170);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(319, 33);
            this.cbCategory.TabIndex = 7;
            this.cbCategory.Text = "THỂ LOẠI";
            this.cbCategory.SelectedValueChanged += new System.EventHandler(this.cbCategory_SelectedValueChanged);
            // 
            // btnRecentlyRead
            // 
            this.btnRecentlyRead.BackColor = System.Drawing.Color.Transparent;
            this.btnRecentlyRead.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecentlyRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecentlyRead.Location = new System.Drawing.Point(0, 128);
            this.btnRecentlyRead.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRecentlyRead.Name = "btnRecentlyRead";
            this.btnRecentlyRead.Size = new System.Drawing.Size(319, 42);
            this.btnRecentlyRead.TabIndex = 6;
            this.btnRecentlyRead.Text = "LỊCH SỬ ĐỌC";
            this.btnRecentlyRead.UseVisualStyleBackColor = false;
            this.btnRecentlyRead.Click += new System.EventHandler(this.btnRecentlyRead_Click);
            // 
            // btnRecentlyAdd
            // 
            this.btnRecentlyAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnRecentlyAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecentlyAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecentlyAdd.Location = new System.Drawing.Point(0, 86);
            this.btnRecentlyAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRecentlyAdd.Name = "btnRecentlyAdd";
            this.btnRecentlyAdd.Size = new System.Drawing.Size(319, 42);
            this.btnRecentlyAdd.TabIndex = 5;
            this.btnRecentlyAdd.Text = "FILE THÊM GẦN ĐÂY";
            this.btnRecentlyAdd.UseVisualStyleBackColor = false;
            this.btnRecentlyAdd.Click += new System.EventHandler(this.btnRecentlyAdd_Click);
            // 
            // btnAllFile
            // 
            this.btnAllFile.BackColor = System.Drawing.Color.Transparent;
            this.btnAllFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllFile.Location = new System.Drawing.Point(0, 44);
            this.btnAllFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAllFile.Name = "btnAllFile";
            this.btnAllFile.Size = new System.Drawing.Size(319, 42);
            this.btnAllFile.TabIndex = 4;
            this.btnAllFile.Text = "TẤT CẢ";
            this.btnAllFile.UseVisualStyleBackColor = false;
            this.btnAllFile.Click += new System.EventHandler(this.btnAllFile_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 44);
            this.label3.TabIndex = 3;
            this.label3.Text = "DANH MỤC";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer2.Panel1.Controls.Add(this.lbShowDanhMuc);
            this.splitContainer2.Panel1.Controls.Add(this.btnReadFile);
            this.splitContainer2.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer2.Panel1.Controls.Add(this.txtSearch);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabView);
            this.splitContainer2.Size = new System.Drawing.Size(1598, 1025);
            this.splitContainer2.SplitterDistance = 82;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(1202, 6);
            this.btnReadFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(109, 50);
            this.btnReadFile.TabIndex = 18;
            this.btnReadFile.Text = "Đọc file";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(1055, 6);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSearch.Size = new System.Drawing.Size(109, 50);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(564, 20);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(460, 22);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.tabThumb);
            this.tabView.Controls.Add(this.tabDataGV);
            this.tabView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabView.Location = new System.Drawing.Point(0, 0);
            this.tabView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabView.Name = "tabView";
            this.tabView.SelectedIndex = 0;
            this.tabView.Size = new System.Drawing.Size(1598, 939);
            this.tabView.TabIndex = 0;
            this.tabView.SelectedIndexChanged += new System.EventHandler(this.tabView_SelectedIndexChanged);
            // 
            // tabThumb
            // 
            this.tabThumb.Controls.Add(this.flpnlThumb);
            this.tabThumb.Location = new System.Drawing.Point(4, 25);
            this.tabThumb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabThumb.Name = "tabThumb";
            this.tabThumb.Size = new System.Drawing.Size(1590, 910);
            this.tabThumb.TabIndex = 0;
            this.tabThumb.Text = "Dạng lưới";
            this.tabThumb.UseVisualStyleBackColor = true;
            // 
            // flpnlThumb
            // 
            this.flpnlThumb.AutoScroll = true;
            this.flpnlThumb.ContextMenuStrip = this.ctmenuRefresh;
            this.flpnlThumb.Controls.Add(this.usrViewThumb);
            this.flpnlThumb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnlThumb.Location = new System.Drawing.Point(0, 0);
            this.flpnlThumb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpnlThumb.Name = "flpnlThumb";
            this.flpnlThumb.Size = new System.Drawing.Size(1590, 910);
            this.flpnlThumb.TabIndex = 0;
            // 
            // ctmenuRefresh
            // 
            this.ctmenuRefresh.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctmenuRefresh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripRefresh});
            this.ctmenuRefresh.Name = "ctmenuRefresh";
            this.ctmenuRefresh.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ctmenuRefresh.Size = new System.Drawing.Size(188, 28);
            // 
            // toolStripRefresh
            // 
            this.toolStripRefresh.Name = "toolStripRefresh";
            this.toolStripRefresh.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.toolStripRefresh.Size = new System.Drawing.Size(187, 24);
            this.toolStripRefresh.Text = "Làm mới";
            this.toolStripRefresh.Click += new System.EventHandler(this.toolStripRefresh_Click);
            // 
            // tabDataGV
            // 
            this.tabDataGV.Controls.Add(this.dataFileM);
            this.tabDataGV.Location = new System.Drawing.Point(4, 25);
            this.tabDataGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDataGV.Name = "tabDataGV";
            this.tabDataGV.Size = new System.Drawing.Size(1590, 910);
            this.tabDataGV.TabIndex = 1;
            this.tabDataGV.Text = "Dạng danh sách";
            this.tabDataGV.UseVisualStyleBackColor = true;
            // 
            // dataFileM
            // 
            this.dataFileM.AllowUserToAddRows = false;
            this.dataFileM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataFileM.BackgroundColor = System.Drawing.Color.White;
            this.dataFileM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFileM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cFileCode,
            this.cTitle,
            this.cCategory,
            this.cDateUpdate,
            this.cRecentlyRead,
            this.cReadIndex,
            this.cDelete});
            this.dataFileM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataFileM.Location = new System.Drawing.Point(0, 0);
            this.dataFileM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataFileM.Name = "dataFileM";
            this.dataFileM.ReadOnly = true;
            this.dataFileM.RowHeadersWidth = 51;
            this.dataFileM.RowTemplate.Height = 24;
            this.dataFileM.Size = new System.Drawing.Size(1590, 910);
            this.dataFileM.TabIndex = 1;
            this.dataFileM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFileM_CellContentClick);
            this.dataFileM.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFileM_RowEnter);
            this.dataFileM.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFileM_RowLeave);
            // 
            // cFileCode
            // 
            this.cFileCode.HeaderText = "Mã số File";
            this.cFileCode.MinimumWidth = 6;
            this.cFileCode.Name = "cFileCode";
            this.cFileCode.ReadOnly = true;
            // 
            // cTitle
            // 
            this.cTitle.HeaderText = "Tên File";
            this.cTitle.MinimumWidth = 6;
            this.cTitle.Name = "cTitle";
            this.cTitle.ReadOnly = true;
            // 
            // cCategory
            // 
            this.cCategory.HeaderText = "Thể Loại";
            this.cCategory.MinimumWidth = 6;
            this.cCategory.Name = "cCategory";
            this.cCategory.ReadOnly = true;
            // 
            // cDateUpdate
            // 
            this.cDateUpdate.HeaderText = "Ngày cập nhật";
            this.cDateUpdate.MinimumWidth = 6;
            this.cDateUpdate.Name = "cDateUpdate";
            this.cDateUpdate.ReadOnly = true;
            // 
            // cRecentlyRead
            // 
            this.cRecentlyRead.HeaderText = "Lần đọc gần nhất";
            this.cRecentlyRead.MinimumWidth = 6;
            this.cRecentlyRead.Name = "cRecentlyRead";
            this.cRecentlyRead.ReadOnly = true;
            // 
            // cReadIndex
            // 
            this.cReadIndex.HeaderText = "File cần đọc trước";
            this.cReadIndex.MinimumWidth = 6;
            this.cReadIndex.Name = "cReadIndex";
            this.cReadIndex.ReadOnly = true;
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
            this.fileMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1924, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFile,
            this.addCategory,
            this.addReadIndex});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileMenuItem.Text = "&File";
            // 
            // addFile
            // 
            this.addFile.Name = "addFile";
            this.addFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addFile.Size = new System.Drawing.Size(280, 26);
            this.addFile.Text = "Thêm File";
            this.addFile.Click += new System.EventHandler(this.addFile_Click);
            // 
            // addCategory
            // 
            this.addCategory.Name = "addCategory";
            this.addCategory.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.addCategory.Size = new System.Drawing.Size(280, 26);
            this.addCategory.Text = "Thêm Thể Loại";
            this.addCategory.Click += new System.EventHandler(this.addCategory_Click);
            // 
            // addReadIndex
            // 
            this.addReadIndex.Name = "addReadIndex";
            this.addReadIndex.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.addReadIndex.Size = new System.Drawing.Size(280, 26);
            this.addReadIndex.Text = "Thêm Thứ Tự Đọc";
            this.addReadIndex.Click += new System.EventHandler(this.addReadIndex_Click);
            // 
            // lbShowDanhMuc
            // 
            this.lbShowDanhMuc.AutoSize = true;
            this.lbShowDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowDanhMuc.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lbShowDanhMuc.Location = new System.Drawing.Point(29, 23);
            this.lbShowDanhMuc.Name = "lbShowDanhMuc";
            this.lbShowDanhMuc.Size = new System.Drawing.Size(0, 33);
            this.lbShowDanhMuc.TabIndex = 19;
            // 
            // usrViewThumb
            // 
            this.usrViewThumb.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.usrViewThumb.BackColor = System.Drawing.Color.White;
            this.usrViewThumb.Category = null;
            this.usrViewThumb.FileCode = null;
            this.usrViewThumb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.usrViewThumb.LinkFile = null;
            this.usrViewThumb.Location = new System.Drawing.Point(4, 2);
            this.usrViewThumb.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.usrViewThumb.Name = "usrViewThumb";
            this.usrViewThumb.Note = null;
            this.usrViewThumb.RecentlyRead = null;
            this.usrViewThumb.Size = new System.Drawing.Size(273, 193);
            this.usrViewThumb.TabIndex = 0;
            this.usrViewThumb.Title = null;
            // 
            // frmManager
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManager";
            this.Text = "Reader River";
            this.Load += new System.EventHandler(this.frmViewThumb_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlDanhMuc.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.pnlLastRead.ResumeLayout(false);
            this.pnlLastRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLastFile)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabView.ResumeLayout(false);
            this.tabThumb.ResumeLayout(false);
            this.flpnlThumb.ResumeLayout(false);
            this.ctmenuRefresh.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlDanhMuc;
        private usrViewThumb usrViewThumb;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFile;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlLastRead;
        private System.Windows.Forms.PictureBox picLastFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReadLastFile;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbFileCode;
        private System.Windows.Forms.ToolStripMenuItem addCategory;
        private System.Windows.Forms.ToolStripMenuItem addReadIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFileCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRecentlyRead;
        private System.Windows.Forms.DataGridViewTextBoxColumn cReadIndex;
        private System.Windows.Forms.DataGridViewButtonColumn cDelete;
        private System.Windows.Forms.ContextMenuStrip ctmenuRefresh;
        private System.Windows.Forms.ToolStripMenuItem toolStripRefresh;
        private System.Windows.Forms.Button btnAllFile;
        private System.Windows.Forms.Button btnRecentlyRead;
        private System.Windows.Forms.Button btnRecentlyAdd;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lbShowDanhMuc;
    }
}