namespace ĐO_AN_NMLT
{
    partial class LoaiHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtThemLoaiHang = new System.Windows.Forms.TextBox();
            this.btnSuaLoaiHang = new System.Windows.Forms.Button();
            this.dataGridViewLoaiHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoaLoaiHang = new System.Windows.Forms.Button();
            this.txtTimLoaiHang = new System.Windows.Forms.TextBox();
            this.btnThemLoaiHang = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(492, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC LOẠI HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.txtThemLoaiHang);
            this.groupBox1.Controls.Add(this.btnSuaLoaiHang);
            this.groupBox1.Controls.Add(this.dataGridViewLoaiHang);
            this.groupBox1.Controls.Add(this.btnXoaLoaiHang);
            this.groupBox1.Controls.Add(this.txtTimLoaiHang);
            this.groupBox1.Controls.Add(this.btnThemLoaiHang);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1440, 747);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::ĐO_AN_NMLT.Properties.Resources.floppy_disk;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(771, 235);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(160, 47);
            this.btnLuu.TabIndex = 37;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtThemLoaiHang
            // 
            this.txtThemLoaiHang.Location = new System.Drawing.Point(235, 159);
            this.txtThemLoaiHang.Name = "txtThemLoaiHang";
            this.txtThemLoaiHang.Size = new System.Drawing.Size(519, 30);
            this.txtThemLoaiHang.TabIndex = 36;
            // 
            // btnSuaLoaiHang
            // 
            this.btnSuaLoaiHang.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLoaiHang.Image = global::ĐO_AN_NMLT.Properties.Resources.repair;
            this.btnSuaLoaiHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaLoaiHang.Location = new System.Drawing.Point(539, 235);
            this.btnSuaLoaiHang.Name = "btnSuaLoaiHang";
            this.btnSuaLoaiHang.Size = new System.Drawing.Size(160, 47);
            this.btnSuaLoaiHang.TabIndex = 32;
            this.btnSuaLoaiHang.Text = "&Sửa";
            this.btnSuaLoaiHang.UseVisualStyleBackColor = true;
            this.btnSuaLoaiHang.Click += new System.EventHandler(this.btnSuaLoaiHang_Click);
            // 
            // dataGridViewLoaiHang
            // 
            this.dataGridViewLoaiHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoaiHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridViewLoaiHang.Location = new System.Drawing.Point(235, 311);
            this.dataGridViewLoaiHang.Name = "dataGridViewLoaiHang";
            this.dataGridViewLoaiHang.RowHeadersWidth = 51;
            this.dataGridViewLoaiHang.RowTemplate.Height = 24;
            this.dataGridViewLoaiHang.Size = new System.Drawing.Size(696, 270);
            this.dataGridViewLoaiHang.TabIndex = 35;
            this.dataGridViewLoaiHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLoaiHang_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên Loại Hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // btnXoaLoaiHang
            // 
            this.btnXoaLoaiHang.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLoaiHang.Image = global::ĐO_AN_NMLT.Properties.Resources.delete__1_;
            this.btnXoaLoaiHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaLoaiHang.Location = new System.Drawing.Point(263, 225);
            this.btnXoaLoaiHang.Name = "btnXoaLoaiHang";
            this.btnXoaLoaiHang.Size = new System.Drawing.Size(157, 47);
            this.btnXoaLoaiHang.TabIndex = 31;
            this.btnXoaLoaiHang.Text = "&Xóa";
            this.btnXoaLoaiHang.UseVisualStyleBackColor = true;
            this.btnXoaLoaiHang.Click += new System.EventHandler(this.btnXoaLoaiHang_Click);
            // 
            // txtTimLoaiHang
            // 
            this.txtTimLoaiHang.Location = new System.Drawing.Point(235, 58);
            this.txtTimLoaiHang.Name = "txtTimLoaiHang";
            this.txtTimLoaiHang.Size = new System.Drawing.Size(519, 30);
            this.txtTimLoaiHang.TabIndex = 34;
            // 
            // btnThemLoaiHang
            // 
            this.btnThemLoaiHang.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLoaiHang.Image = global::ĐO_AN_NMLT.Properties.Resources.add_to_cart__2_;
            this.btnThemLoaiHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemLoaiHang.Location = new System.Drawing.Point(809, 153);
            this.btnThemLoaiHang.Name = "btnThemLoaiHang";
            this.btnThemLoaiHang.Size = new System.Drawing.Size(216, 47);
            this.btnThemLoaiHang.TabIndex = 30;
            this.btnThemLoaiHang.Text = "&Thêm loại hàng";
            this.btnThemLoaiHang.UseVisualStyleBackColor = true;
            this.btnThemLoaiHang.Click += new System.EventHandler(this.btnThemLoaiHang_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::ĐO_AN_NMLT.Properties.Resources.search;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(809, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(216, 41);
            this.button4.TabIndex = 33;
            this.button4.Text = "&Tìm loại hàng";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // LoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 870);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "LoaiHang";
            this.Text = "LoaiHang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimLoaiHang;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSuaLoaiHang;
        private System.Windows.Forms.Button btnXoaLoaiHang;
        private System.Windows.Forms.Button btnThemLoaiHang;
        private System.Windows.Forms.DataGridView dataGridViewLoaiHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox txtThemLoaiHang;
        private System.Windows.Forms.Button btnLuu;
    }
}