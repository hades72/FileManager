namespace FileManager.Views
{
    partial class frmMainGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainGUI));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabMain = new System.Windows.Forms.TabControl();
            this.thêmFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabReadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mFuntion = new System.Windows.Forms.MenuStrip();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.mFuntion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMain.Location = new System.Drawing.Point(0, 28);
            this.tabMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(815, 27);
            this.tabMain.TabIndex = 2;
            // 
            // thêmFileToolStripMenuItem
            // 
            this.thêmFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabReadFile});
            this.thêmFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thêmFileToolStripMenuItem.Image")));
            this.thêmFileToolStripMenuItem.Name = "thêmFileToolStripMenuItem";
            this.thêmFileToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.thêmFileToolStripMenuItem.Text = "&Chức năng";
            // 
            // tabReadFile
            // 
            this.tabReadFile.Image = ((System.Drawing.Image)(resources.GetObject("tabReadFile.Image")));
            this.tabReadFile.Name = "tabReadFile";
            this.tabReadFile.Size = new System.Drawing.Size(184, 26);
            this.tabReadFile.Text = "&Danh sách File";
            this.tabReadFile.Click += new System.EventHandler(this.tabReadFile_Click);
            // 
            // mFuntion
            // 
            this.mFuntion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mFuntion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmFileToolStripMenuItem});
            this.mFuntion.Location = new System.Drawing.Point(0, 0);
            this.mFuntion.Name = "mFuntion";
            this.mFuntion.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mFuntion.Size = new System.Drawing.Size(815, 28);
            this.mFuntion.TabIndex = 1;
            this.mFuntion.Text = "menuStrip1";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 55);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 405);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // frmMainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FileManager.Properties.Resources.nền_trắng_500x500;
            this.ClientSize = new System.Drawing.Size(815, 460);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.mFuntion);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mFuntion;
            this.Name = "frmMainGUI";
            this.Text = "Quản lý File";
            this.MdiChildActivate += new System.EventHandler(this.frmMainGUI_MdiChildActivate);
            this.mFuntion.ResumeLayout(false);
            this.mFuntion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.ToolStripMenuItem thêmFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabReadFile;
        private System.Windows.Forms.MenuStrip mFuntion;
        private System.Windows.Forms.Splitter splitter1;
    }
}



