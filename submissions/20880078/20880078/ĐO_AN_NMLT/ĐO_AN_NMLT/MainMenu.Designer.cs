namespace ĐO_AN_NMLT
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtTimMatHang = new System.Windows.Forms.TextBox();
            this.btnTimMatHang = new System.Windows.Forms.Button();
            this.btnSuaMatHang = new System.Windows.Forms.Button();
            this.btnXoaMatHang = new System.Windows.Forms.Button();
            this.btnThemMatHang = new System.Windows.Forms.Button();
            this.dtpNamSanXuat = new System.Windows.Forms.DateTimePicker();
            this.cbLoaiHang = new System.Windows.Forms.ComboBox();
            this.dtpHanSuDung = new System.Windows.Forms.DateTimePicker();
            this.txtCTSanXuat = new System.Windows.Forms.TextBox();
            this.txtTenMatHang = new System.Windows.Forms.TextBox();
            this.txtMaMatHang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewMatHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.loạiHàngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1559, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loạiHàngToolStripMenuItem
            // 
            this.loạiHàngToolStripMenuItem.Name = "loạiHàngToolStripMenuItem";
            this.loạiHàngToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.loạiHàngToolStripMenuItem.Text = "Loại Hàng";
            this.loạiHàngToolStripMenuItem.Click += new System.EventHandler(this.loạiHàngToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(547, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC HÀNG HÓA\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.txtTimMatHang);
            this.groupBox1.Controls.Add(this.btnTimMatHang);
            this.groupBox1.Controls.Add(this.btnSuaMatHang);
            this.groupBox1.Controls.Add(this.btnXoaMatHang);
            this.groupBox1.Controls.Add(this.btnThemMatHang);
            this.groupBox1.Controls.Add(this.dtpNamSanXuat);
            this.groupBox1.Controls.Add(this.cbLoaiHang);
            this.groupBox1.Controls.Add(this.dtpHanSuDung);
            this.groupBox1.Controls.Add(this.txtCTSanXuat);
            this.groupBox1.Controls.Add(this.txtTenMatHang);
            this.groupBox1.Controls.Add(this.txtMaMatHang);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1495, 448);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::ĐO_AN_NMLT.Properties.Resources.floppy_disk;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(1018, 377);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(160, 47);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTimMatHang
            // 
            this.txtTimMatHang.Location = new System.Drawing.Point(226, 40);
            this.txtTimMatHang.Name = "txtTimMatHang";
            this.txtTimMatHang.Size = new System.Drawing.Size(519, 37);
            this.txtTimMatHang.TabIndex = 17;
            // 
            // btnTimMatHang
            // 
            this.btnTimMatHang.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMatHang.Image = global::ĐO_AN_NMLT.Properties.Resources.search;
            this.btnTimMatHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimMatHang.Location = new System.Drawing.Point(824, 40);
            this.btnTimMatHang.Name = "btnTimMatHang";
            this.btnTimMatHang.Size = new System.Drawing.Size(216, 37);
            this.btnTimMatHang.TabIndex = 16;
            this.btnTimMatHang.Text = "&Tìm mặt hàng";
            this.btnTimMatHang.UseVisualStyleBackColor = true;
            this.btnTimMatHang.Click += new System.EventHandler(this.btnTimMatHang_Click);
            // 
            // btnSuaMatHang
            // 
            this.btnSuaMatHang.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaMatHang.Image = global::ĐO_AN_NMLT.Properties.Resources.repair;
            this.btnSuaMatHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaMatHang.Location = new System.Drawing.Point(782, 377);
            this.btnSuaMatHang.Name = "btnSuaMatHang";
            this.btnSuaMatHang.Size = new System.Drawing.Size(160, 47);
            this.btnSuaMatHang.TabIndex = 15;
            this.btnSuaMatHang.Text = "&Sửa";
            this.btnSuaMatHang.UseVisualStyleBackColor = true;
            this.btnSuaMatHang.Click += new System.EventHandler(this.btnSuaMatHang_Click);
            // 
            // btnXoaMatHang
            // 
            this.btnXoaMatHang.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMatHang.Image = global::ĐO_AN_NMLT.Properties.Resources.delete__1_;
            this.btnXoaMatHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaMatHang.Location = new System.Drawing.Point(557, 377);
            this.btnXoaMatHang.Name = "btnXoaMatHang";
            this.btnXoaMatHang.Size = new System.Drawing.Size(157, 47);
            this.btnXoaMatHang.TabIndex = 14;
            this.btnXoaMatHang.Text = "&Xóa";
            this.btnXoaMatHang.UseVisualStyleBackColor = true;
            this.btnXoaMatHang.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnThemMatHang
            // 
            this.btnThemMatHang.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMatHang.Image = global::ĐO_AN_NMLT.Properties.Resources.add_to_cart__2_;
            this.btnThemMatHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMatHang.Location = new System.Drawing.Point(255, 377);
            this.btnThemMatHang.Name = "btnThemMatHang";
            this.btnThemMatHang.Size = new System.Drawing.Size(236, 47);
            this.btnThemMatHang.TabIndex = 13;
            this.btnThemMatHang.Text = "&Thêm mặt hàng";
            this.btnThemMatHang.UseVisualStyleBackColor = true;
            this.btnThemMatHang.Click += new System.EventHandler(this.btnThemMatHang_Click);
            // 
            // dtpNamSanXuat
            // 
            this.dtpNamSanXuat.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNamSanXuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNamSanXuat.Location = new System.Drawing.Point(968, 229);
            this.dtpNamSanXuat.Name = "dtpNamSanXuat";
            this.dtpNamSanXuat.Size = new System.Drawing.Size(334, 33);
            this.dtpNamSanXuat.TabIndex = 11;
            // 
            // cbLoaiHang
            // 
            this.cbLoaiHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiHang.FormattingEnabled = true;
            this.cbLoaiHang.Items.AddRange(new object[] {
            "Thực Phẩm",
            "Gia Dụng",
            "Thiết Bị Điện Tử",
            "Dược Phẩm - Y Tế",
            "Sách",
            "Nội Thất"});
            this.cbLoaiHang.Location = new System.Drawing.Point(968, 294);
            this.cbLoaiHang.Name = "cbLoaiHang";
            this.cbLoaiHang.Size = new System.Drawing.Size(334, 38);
            this.cbLoaiHang.TabIndex = 10;
            // 
            // dtpHanSuDung
            // 
            this.dtpHanSuDung.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHanSuDung.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHanSuDung.Location = new System.Drawing.Point(226, 292);
            this.dtpHanSuDung.Name = "dtpHanSuDung";
            this.dtpHanSuDung.Size = new System.Drawing.Size(334, 33);
            this.dtpHanSuDung.TabIndex = 9;
            // 
            // txtCTSanXuat
            // 
            this.txtCTSanXuat.Location = new System.Drawing.Point(968, 145);
            this.txtCTSanXuat.Name = "txtCTSanXuat";
            this.txtCTSanXuat.Size = new System.Drawing.Size(334, 37);
            this.txtCTSanXuat.TabIndex = 8;
            // 
            // txtTenMatHang
            // 
            this.txtTenMatHang.Location = new System.Drawing.Point(226, 228);
            this.txtTenMatHang.Name = "txtTenMatHang";
            this.txtTenMatHang.Size = new System.Drawing.Size(334, 37);
            this.txtTenMatHang.TabIndex = 7;
            // 
            // txtMaMatHang
            // 
            this.txtMaMatHang.Location = new System.Drawing.Point(226, 151);
            this.txtMaMatHang.Name = "txtMaMatHang";
            this.txtMaMatHang.Size = new System.Drawing.Size(334, 37);
            this.txtMaMatHang.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(794, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Năm sản xuất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(794, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Loại hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(794, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Công ty sản xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(81, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hạn sử dụng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(81, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên mặt hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(81, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã mặt hàng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1559, 546);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewMatHang
            // 
            this.dataGridViewMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewMatHang.Location = new System.Drawing.Point(212, 564);
            this.dataGridViewMatHang.Name = "dataGridViewMatHang";
            this.dataGridViewMatHang.RowHeadersWidth = 51;
            this.dataGridViewMatHang.RowTemplate.Height = 24;
            this.dataGridViewMatHang.Size = new System.Drawing.Size(1125, 213);
            this.dataGridViewMatHang.TabIndex = 1;
            this.dataGridViewMatHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatHang_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã mặt hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên mặt hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Hạn sử dụng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Công ty sản xuất";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Năm sản xuất";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Loại hàng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1398, 729);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Hồ Công Tấn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1398, 756);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "20880078";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 832);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridViewMatHang);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "QUẢN LÝ CỬA HÀNG";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiHàngToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimMatHang;
        private System.Windows.Forms.Button btnTimMatHang;
        private System.Windows.Forms.Button btnSuaMatHang;
        private System.Windows.Forms.Button btnXoaMatHang;
        private System.Windows.Forms.Button btnThemMatHang;
        private System.Windows.Forms.DateTimePicker dtpNamSanXuat;
        private System.Windows.Forms.ComboBox cbLoaiHang;
        private System.Windows.Forms.DateTimePicker dtpHanSuDung;
        private System.Windows.Forms.TextBox txtCTSanXuat;
        private System.Windows.Forms.TextBox txtTenMatHang;
        private System.Windows.Forms.TextBox txtMaMatHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

