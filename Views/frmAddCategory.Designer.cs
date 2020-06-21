﻿namespace FileManager.Views
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataCategory = new System.Windows.Forms.DataGridView();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.cDeleteCategory = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCategoryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataCategory);
            this.panel1.Controls.Add(this.btnAddCategory);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.txtCategoryName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 276);
            this.panel1.TabIndex = 0;
            // 
            // dataCategory
            // 
            this.dataCategory.AllowUserToAddRows = false;
            this.dataCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCategory.ColumnHeadersHeight = 29;
            this.dataCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCategoryCode,
            this.cCategoryName,
            this.cDeleteCategory});
            this.dataCategory.Location = new System.Drawing.Point(19, 89);
            this.dataCategory.Name = "dataCategory";
            this.dataCategory.RowHeadersWidth = 51;
            this.dataCategory.RowTemplate.Height = 24;
            this.dataCategory.Size = new System.Drawing.Size(521, 161);
            this.dataCategory.TabIndex = 3;
            this.dataCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCategory_CellContentClick);
            this.dataCategory.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCategory_CellEndEdit);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(447, 25);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(93, 31);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(31, 34);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(59, 17);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Thể loại";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(105, 31);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(320, 22);
            this.txtCategoryName.TabIndex = 0;
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
            // cCategoryName
            // 
            this.cCategoryName.HeaderText = "Thể loại";
            this.cCategoryName.MinimumWidth = 6;
            this.cCategoryName.Name = "cCategoryName";
            // 
            // cCategoryCode
            // 
            this.cCategoryCode.HeaderText = "Mã thể loại";
            this.cCategoryCode.MinimumWidth = 6;
            this.cCategoryCode.Name = "cCategoryCode";
            this.cCategoryCode.ReadOnly = true;
            // 
            // frmAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 276);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddCategory";
            this.Text = "frmAddCategory";
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
    }
}