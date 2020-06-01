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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mFuntion = new System.Windows.Forms.MenuStrip();
            this.thêmFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabAddFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tabReadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.mFuntion.SuspendLayout();
            this.SuspendLayout();
            // 
            // mFuntion
            // 
            this.mFuntion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mFuntion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmFileToolStripMenuItem});
            this.mFuntion.Location = new System.Drawing.Point(0, 0);
            this.mFuntion.Name = "mFuntion";
            this.mFuntion.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mFuntion.Size = new System.Drawing.Size(843, 28);
            this.mFuntion.TabIndex = 1;
            this.mFuntion.Text = "menuStrip1";
            // 
            // thêmFileToolStripMenuItem
            // 
            this.thêmFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabAddFile,
            this.tabReadFile});
            this.thêmFileToolStripMenuItem.Name = "thêmFileToolStripMenuItem";
            this.thêmFileToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.thêmFileToolStripMenuItem.Text = "&Chức năng";
            // 
            // tabAddFile
            // 
            this.tabAddFile.Name = "tabAddFile";
            this.tabAddFile.Size = new System.Drawing.Size(224, 26);
            this.tabAddFile.Text = "&Thêm File";
            this.tabAddFile.Click += new System.EventHandler(this.tabAddFile_Click);
            // 
            // tabReadFile
            // 
            this.tabReadFile.Name = "tabReadFile";
            this.tabReadFile.Size = new System.Drawing.Size(224, 26);
            this.tabReadFile.Text = "&Danh sách File";
            this.tabReadFile.Click += new System.EventHandler(this.tabReadFile_Click);
            // 
            // tabMain
            // 
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMain.Location = new System.Drawing.Point(0, 28);
            this.tabMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(843, 39);
            this.tabMain.TabIndex = 2;
            // 
            // frmMainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.mFuntion);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mFuntion;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMainGUI";
            this.Text = "frmMainGUI";
            this.MdiChildActivate += new System.EventHandler(this.frmMainGUI_MdiChildActivate);
            this.mFuntion.ResumeLayout(false);
            this.mFuntion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip mFuntion;
        private System.Windows.Forms.ToolStripMenuItem thêmFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabAddFile;
        private System.Windows.Forms.ToolStripMenuItem tabReadFile;
        private System.Windows.Forms.TabControl tabMain;
    }
}



