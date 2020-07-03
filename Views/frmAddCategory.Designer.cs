namespace FileManager.Views
{
    partial class frmAddCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCategory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataCategory = new System.Windows.Forms.DataGridView();
            this.cCategoryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDeleteCategory = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.dataCategory);
            this.panel1.Controls.Add(this.btnAddCategory);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.txtCategoryName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 224);
            this.panel1.TabIndex = 0;
            // 
            // dataCategory
            // 
            this.dataCategory.AllowUserToAddRows = false;
            this.dataCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCategory.BackgroundColor = System.Drawing.Color.White;
            this.dataCategory.ColumnHeadersHeight = 29;
            this.dataCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCategoryCode,
            this.cCategoryName,
            this.cDeleteCategory});
            this.dataCategory.Location = new System.Drawing.Point(14, 72);
            this.dataCategory.Margin = new System.Windows.Forms.Padding(2);
            this.dataCategory.Name = "dataCategory";
            this.dataCategory.RowHeadersWidth = 51;
            this.dataCategory.RowTemplate.Height = 24;
            this.dataCategory.Size = new System.Drawing.Size(391, 131);
            this.dataCategory.TabIndex = 3;
            this.dataCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCategory_CellContentClick);
            this.dataCategory.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCategory_CellEndEdit);
            // 
            // cCategoryCode
            // 
            this.cCategoryCode.HeaderText = "Mã thể loại";
            this.cCategoryCode.MinimumWidth = 6;
            this.cCategoryCode.Name = "cCategoryCode";
            this.cCategoryCode.ReadOnly = true;
            // 
            // cCategoryName
            // 
            this.cCategoryName.HeaderText = "Thể loại";
            this.cCategoryName.MinimumWidth = 6;
            this.cCategoryName.Name = "cCategoryName";
            // 
            // cDeleteCategory
            // 
            this.cDeleteCategory.HeaderText = "Xóa";
            this.cDeleteCategory.MinimumWidth = 6;
            this.cDeleteCategory.Name = "cDeleteCategory";
            this.cDeleteCategory.ReadOnly = true;
            this.cDeleteCategory.Text = "Xóa";
            this.cDeleteCategory.UseColumnTextForButtonValue = true;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(335, 22);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(70, 25);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(23, 28);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(45, 13);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Thể loại";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(79, 25);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(241, 20);
            this.txtCategoryName.TabIndex = 0;
            // 
            // frmAddCategory
            // 
            this.AcceptButton = this.btnAddCategory;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 224);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Thể loại";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddCategory_FormClosing);
            this.Load += new System.EventHandler(this.frmAddCategory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.DataGridView dataCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCategoryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCategoryName;
        private System.Windows.Forms.DataGridViewButtonColumn cDeleteCategory;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}