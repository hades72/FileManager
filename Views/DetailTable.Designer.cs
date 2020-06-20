namespace FileManager.Views
{
    partial class DetailTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btProperties = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btRead = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btProperties, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btDelete, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btRead, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(220, 102);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btProperties
            // 
            this.btProperties.BackColor = System.Drawing.Color.White;
            this.btProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProperties.Location = new System.Drawing.Point(3, 74);
            this.btProperties.Name = "btProperties";
            this.btProperties.Size = new System.Drawing.Size(214, 25);
            this.btProperties.TabIndex = 2;
            this.btProperties.Text = "Chi tiết";
            this.btProperties.UseVisualStyleBackColor = false;
            this.btProperties.Click += new System.EventHandler(this.btProperties_Click);
            this.btProperties.MouseEnter += new System.EventHandler(this.btProperties_MouseEnter);
            this.btProperties.MouseLeave += new System.EventHandler(this.btProperties_MouseLeave);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.White;
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(3, 41);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(214, 27);
            this.btDelete.TabIndex = 1;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            this.btDelete.MouseEnter += new System.EventHandler(this.btDelete_MouseEnter);
            this.btDelete.MouseLeave += new System.EventHandler(this.btDelete_MouseLeave);
            // 
            // btRead
            // 
            this.btRead.BackColor = System.Drawing.Color.White;
            this.btRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRead.Location = new System.Drawing.Point(3, 3);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(214, 32);
            this.btRead.TabIndex = 0;
            this.btRead.Text = "Đọc";
            this.btRead.UseVisualStyleBackColor = false;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            this.btRead.MouseEnter += new System.EventHandler(this.btRead_MouseEnter);
            this.btRead.MouseLeave += new System.EventHandler(this.btRead_MouseLeave);
            // 
            // DetailTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DetailTable";
            this.Size = new System.Drawing.Size(220, 102);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btProperties;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btRead;
    }
}
