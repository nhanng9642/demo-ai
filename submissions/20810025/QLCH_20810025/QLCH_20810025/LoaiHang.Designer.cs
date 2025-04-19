
namespace QLCH_20810025
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đóngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_Diengiai = new System.Windows.Forms.TextBox();
            this.tB_TenLH = new System.Windows.Forms.TextBox();
            this.tB_MaLH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_LamMoi = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_CapNhat = new System.Windows.Forms.Button();
            this.bt_ThemLH = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_TimkiemLH = new System.Windows.Forms.Button();
            this.tB_TìmkiemLH = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaLH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaytaoLH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiengiaiLH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.thôngTinToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.cậpNhậtToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.đóngToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.quảnLýToolStripMenuItem.Text = "&Quản Lý";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // cậpNhậtToolStripMenuItem
            // 
            this.cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            this.cậpNhậtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cậpNhậtToolStripMenuItem.Text = "Cập nhật";
            this.cậpNhậtToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // đóngToolStripMenuItem
            // 
            this.đóngToolStripMenuItem.Name = "đóngToolStripMenuItem";
            this.đóngToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.đóngToolStripMenuItem.Text = "Đóng";
            this.đóngToolStripMenuItem.Click += new System.EventHandler(this.đóngToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(86, 26);
            this.thôngTinToolStripMenuItem.Text = "&Thông tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(61, 26);
            this.thoátToolStripMenuItem.Text = "&Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(245, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(456, 57);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quản Lý Loại Hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tB_Diengiai);
            this.groupBox1.Controls.Add(this.tB_TenLH);
            this.groupBox1.Controls.Add(this.tB_MaLH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(899, 156);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Loại Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(461, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Diễn Giải";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(585, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 24);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(461, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày Tạo";
            // 
            // tB_Diengiai
            // 
            this.tB_Diengiai.Location = new System.Drawing.Point(585, 98);
            this.tB_Diengiai.Multiline = true;
            this.tB_Diengiai.Name = "tB_Diengiai";
            this.tB_Diengiai.Size = new System.Drawing.Size(250, 25);
            this.tB_Diengiai.TabIndex = 4;
            // 
            // tB_TenLH
            // 
            this.tB_TenLH.Location = new System.Drawing.Point(155, 98);
            this.tB_TenLH.Multiline = true;
            this.tB_TenLH.Name = "tB_TenLH";
            this.tB_TenLH.Size = new System.Drawing.Size(250, 25);
            this.tB_TenLH.TabIndex = 2;
            // 
            // tB_MaLH
            // 
            this.tB_MaLH.Location = new System.Drawing.Point(155, 30);
            this.tB_MaLH.Multiline = true;
            this.tB_MaLH.Name = "tB_MaLH";
            this.tB_MaLH.Size = new System.Drawing.Size(250, 25);
            this.tB_MaLH.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Loại Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Loại Hàng";
            // 
            // bt_LamMoi
            // 
            this.bt_LamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_LamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_LamMoi.Location = new System.Drawing.Point(766, 30);
            this.bt_LamMoi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_LamMoi.Name = "bt_LamMoi";
            this.bt_LamMoi.Size = new System.Drawing.Size(125, 45);
            this.bt_LamMoi.TabIndex = 8;
            this.bt_LamMoi.Text = "&Làm Mới\r";
            this.bt_LamMoi.UseVisualStyleBackColor = true;
            this.bt_LamMoi.Click += new System.EventHandler(this.bt_LamMoi_Click);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_Xoa.Location = new System.Drawing.Point(524, 30);
            this.bt_Xoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(125, 45);
            this.bt_Xoa.TabIndex = 7;
            this.bt_Xoa.Text = "&Xóa\r\n";
            this.bt_Xoa.UseVisualStyleBackColor = true;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_CapNhat
            // 
            this.bt_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CapNhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_CapNhat.Location = new System.Drawing.Point(260, 30);
            this.bt_CapNhat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_CapNhat.Name = "bt_CapNhat";
            this.bt_CapNhat.Size = new System.Drawing.Size(125, 45);
            this.bt_CapNhat.TabIndex = 6;
            this.bt_CapNhat.Text = "&Cập Nhật\r\n";
            this.bt_CapNhat.UseVisualStyleBackColor = true;
            this.bt_CapNhat.Click += new System.EventHandler(this.bt_CapNhat_Click);
            // 
            // bt_ThemLH
            // 
            this.bt_ThemLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ThemLH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_ThemLH.Location = new System.Drawing.Point(10, 30);
            this.bt_ThemLH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bt_ThemLH.Name = "bt_ThemLH";
            this.bt_ThemLH.Size = new System.Drawing.Size(125, 45);
            this.bt_ThemLH.TabIndex = 5;
            this.bt_ThemLH.Text = "&Thêm Mới";
            this.bt_ThemLH.UseVisualStyleBackColor = true;
            this.bt_ThemLH.Click += new System.EventHandler(this.bt_ThemLH_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_TimkiemLH);
            this.groupBox2.Controls.Add(this.tB_TìmkiemLH);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 366);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(899, 98);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm Loại Hàng";
            // 
            // bt_TimkiemLH
            // 
            this.bt_TimkiemLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_TimkiemLH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_TimkiemLH.Location = new System.Drawing.Point(392, 41);
            this.bt_TimkiemLH.Name = "bt_TimkiemLH";
            this.bt_TimkiemLH.Size = new System.Drawing.Size(125, 35);
            this.bt_TimkiemLH.TabIndex = 10;
            this.bt_TimkiemLH.Text = "&Tìm Kiếm";
            this.bt_TimkiemLH.UseVisualStyleBackColor = true;
            this.bt_TimkiemLH.Click += new System.EventHandler(this.bt_TimkiemLH_Click);
            // 
            // tB_TìmkiemLH
            // 
            this.tB_TìmkiemLH.Location = new System.Drawing.Point(10, 46);
            this.tB_TìmkiemLH.Multiline = true;
            this.tB_TìmkiemLH.Name = "tB_TìmkiemLH";
            this.tB_TìmkiemLH.Size = new System.Drawing.Size(360, 25);
            this.tB_TìmkiemLH.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLH,
            this.TenLH,
            this.NgaytaoLH,
            this.DiengiaiLH});
            this.dataGridView1.Location = new System.Drawing.Point(12, 483);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(899, 175);
            this.dataGridView1.TabIndex = 11;
            // 
            // MaLH
            // 
            this.MaLH.DataPropertyName = "Maloaihang";
            this.MaLH.HeaderText = "Mã Loại Hàng";
            this.MaLH.MinimumWidth = 6;
            this.MaLH.Name = "MaLH";
            this.MaLH.Width = 120;
            // 
            // TenLH
            // 
            this.TenLH.DataPropertyName = "Tenloaihang";
            this.TenLH.HeaderText = "Tên Loại Hàng";
            this.TenLH.MinimumWidth = 6;
            this.TenLH.Name = "TenLH";
            this.TenLH.Width = 220;
            // 
            // NgaytaoLH
            // 
            this.NgaytaoLH.DataPropertyName = "Ngaytao";
            this.NgaytaoLH.HeaderText = "Ngày Tạo";
            this.NgaytaoLH.MinimumWidth = 6;
            this.NgaytaoLH.Name = "NgaytaoLH";
            this.NgaytaoLH.Width = 160;
            // 
            // DiengiaiLH
            // 
            this.DiengiaiLH.DataPropertyName = "Diengiai";
            this.DiengiaiLH.HeaderText = "Diễn Giải";
            this.DiengiaiLH.MinimumWidth = 6;
            this.DiengiaiLH.Name = "DiengiaiLH";
            this.DiengiaiLH.Width = 220;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_LamMoi);
            this.groupBox3.Controls.Add(this.bt_ThemLH);
            this.groupBox3.Controls.Add(this.bt_CapNhat);
            this.groupBox3.Controls.Add(this.bt_Xoa);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(898, 96);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // LoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(929, 670);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LoaiHang";
            this.Text = "Phần Mềm Quản Lý Cửa Hàng Bách Hóa - [Giao diện Quản lý loại hàng]";
            this.Load += new System.EventHandler(this.LoaiHang_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đóngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tB_MaLH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tB_TenLH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tB_Diengiai;
        private System.Windows.Forms.Button bt_LamMoi;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_CapNhat;
        private System.Windows.Forms.Button bt_ThemLH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_TimkiemLH;
        private System.Windows.Forms.TextBox tB_TìmkiemLH;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaytaoLH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiengiaiLH;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}