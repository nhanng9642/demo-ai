namespace _20880010
{
    partial class MH_Chinh
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
            this.lv_DanhSach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_MaHang = new System.Windows.Forms.TextBox();
            this.tb_TenHang = new System.Windows.Forms.TextBox();
            this.bt_Them = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_CapNhat = new System.Windows.Forms.Button();
            this.tb_TimSP = new System.Windows.Forms.TextBox();
            this.bt_Tim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_HanDung = new System.Windows.Forms.DateTimePicker();
            this.tb_CongTySX = new System.Windows.Forms.TextBox();
            this.cbb_NamSX = new System.Windows.Forms.ComboBox();
            this.cbb_Loai = new System.Windows.Forms.ComboBox();
            this.lv_LoaiHang = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_lh_LoaiHang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_lh_Them = new System.Windows.Forms.Button();
            this.bt_lh_Xoa = new System.Windows.Forms.Button();
            this.bt_lh_CapNhat = new System.Windows.Forms.Button();
            this.tb_lh_TimKiem = new System.Windows.Forms.TextBox();
            this.bt_lh_Tim = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_DanhSach
            // 
            this.lv_DanhSach.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lv_DanhSach.CheckBoxes = true;
            this.lv_DanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lv_DanhSach.FullRowSelect = true;
            this.lv_DanhSach.GridLines = true;
            this.lv_DanhSach.HideSelection = false;
            this.lv_DanhSach.HoverSelection = true;
            this.lv_DanhSach.Location = new System.Drawing.Point(243, 138);
            this.lv_DanhSach.Name = "lv_DanhSach";
            this.lv_DanhSach.Size = new System.Drawing.Size(664, 175);
            this.lv_DanhSach.TabIndex = 0;
            this.lv_DanhSach.UseCompatibleStateImageBehavior = false;
            this.lv_DanhSach.View = System.Windows.Forms.View.Details;
            this.lv_DanhSach.SelectedIndexChanged += new System.EventHandler(this.lv_DanhSach_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã hàng";
            this.columnHeader1.Width = 59;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên hàng";
            this.columnHeader2.Width = 176;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hạn dùng";
            this.columnHeader3.Width = 106;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Công ty sản xuất";
            this.columnHeader4.Width = 168;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Năm sản xuất";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Loại";
            // 
            // tb_MaHang
            // 
            this.tb_MaHang.Location = new System.Drawing.Point(112, 138);
            this.tb_MaHang.Name = "tb_MaHang";
            this.tb_MaHang.Size = new System.Drawing.Size(100, 20);
            this.tb_MaHang.TabIndex = 1;
            this.tb_MaHang.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_TenHang
            // 
            this.tb_TenHang.Location = new System.Drawing.Point(112, 172);
            this.tb_TenHang.Name = "tb_TenHang";
            this.tb_TenHang.Size = new System.Drawing.Size(100, 20);
            this.tb_TenHang.TabIndex = 2;
            // 
            // bt_Them
            // 
            this.bt_Them.Location = new System.Drawing.Point(306, 319);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(75, 23);
            this.bt_Them.TabIndex = 3;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Location = new System.Drawing.Point(419, 319);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(75, 23);
            this.bt_Xoa.TabIndex = 4;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = true;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_CapNhat
            // 
            this.bt_CapNhat.Location = new System.Drawing.Point(545, 319);
            this.bt_CapNhat.Name = "bt_CapNhat";
            this.bt_CapNhat.Size = new System.Drawing.Size(75, 23);
            this.bt_CapNhat.TabIndex = 5;
            this.bt_CapNhat.Text = "Cập nhật";
            this.bt_CapNhat.UseVisualStyleBackColor = true;
            this.bt_CapNhat.Click += new System.EventHandler(this.bt_CapNhat_Click);
            // 
            // tb_TimSP
            // 
            this.tb_TimSP.Location = new System.Drawing.Point(644, 109);
            this.tb_TimSP.Multiline = true;
            this.tb_TimSP.Name = "tb_TimSP";
            this.tb_TimSP.Size = new System.Drawing.Size(157, 23);
            this.tb_TimSP.TabIndex = 6;
            this.tb_TimSP.TextChanged += new System.EventHandler(this.tb_TimSP_TextChanged);
            // 
            // bt_Tim
            // 
            this.bt_Tim.Location = new System.Drawing.Point(807, 109);
            this.bt_Tim.Name = "bt_Tim";
            this.bt_Tim.Size = new System.Drawing.Size(100, 23);
            this.bt_Tim.TabIndex = 7;
            this.bt_Tim.Text = "Tìm tên hàng";
            this.bt_Tim.UseVisualStyleBackColor = true;
            this.bt_Tim.Click += new System.EventHandler(this.bt_Tim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hạn dùng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Công ty sản xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Năm sản xuất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Loại";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // dt_HanDung
            // 
            this.dt_HanDung.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_HanDung.Location = new System.Drawing.Point(112, 198);
            this.dt_HanDung.Name = "dt_HanDung";
            this.dt_HanDung.Size = new System.Drawing.Size(100, 20);
            this.dt_HanDung.TabIndex = 15;
            // 
            // tb_CongTySX
            // 
            this.tb_CongTySX.Location = new System.Drawing.Point(112, 224);
            this.tb_CongTySX.Name = "tb_CongTySX";
            this.tb_CongTySX.Size = new System.Drawing.Size(100, 20);
            this.tb_CongTySX.TabIndex = 16;
            // 
            // cbb_NamSX
            // 
            this.cbb_NamSX.FormattingEnabled = true;
            this.cbb_NamSX.Location = new System.Drawing.Point(112, 250);
            this.cbb_NamSX.Name = "cbb_NamSX";
            this.cbb_NamSX.Size = new System.Drawing.Size(100, 21);
            this.cbb_NamSX.TabIndex = 17;
            this.cbb_NamSX.SelectedIndexChanged += new System.EventHandler(this.cbb_NamSX_SelectedIndexChanged);
            // 
            // cbb_Loai
            // 
            this.cbb_Loai.FormattingEnabled = true;
            this.cbb_Loai.Location = new System.Drawing.Point(112, 282);
            this.cbb_Loai.Name = "cbb_Loai";
            this.cbb_Loai.Size = new System.Drawing.Size(100, 21);
            this.cbb_Loai.TabIndex = 18;
            // 
            // lv_LoaiHang
            // 
            this.lv_LoaiHang.CheckBoxes = true;
            this.lv_LoaiHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7});
            this.lv_LoaiHang.GridLines = true;
            this.lv_LoaiHang.HideSelection = false;
            this.lv_LoaiHang.Location = new System.Drawing.Point(372, 420);
            this.lv_LoaiHang.Name = "lv_LoaiHang";
            this.lv_LoaiHang.Size = new System.Drawing.Size(104, 156);
            this.lv_LoaiHang.TabIndex = 19;
            this.lv_LoaiHang.UseCompatibleStateImageBehavior = false;
            this.lv_LoaiHang.View = System.Windows.Forms.View.Details;
            this.lv_LoaiHang.SelectedIndexChanged += new System.EventHandler(this.Lv_LoaiHang_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Loại hàng";
            this.columnHeader7.Width = 95;
            // 
            // tb_lh_LoaiHang
            // 
            this.tb_lh_LoaiHang.Location = new System.Drawing.Point(241, 420);
            this.tb_lh_LoaiHang.Name = "tb_lh_LoaiHang";
            this.tb_lh_LoaiHang.Size = new System.Drawing.Size(100, 20);
            this.tb_lh_LoaiHang.TabIndex = 20;
            this.tb_lh_LoaiHang.TextChanged += new System.EventHandler(this.Tb_lh_LoaiHang_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(150, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Loại hàng";
            // 
            // bt_lh_Them
            // 
            this.bt_lh_Them.Location = new System.Drawing.Point(241, 463);
            this.bt_lh_Them.Name = "bt_lh_Them";
            this.bt_lh_Them.Size = new System.Drawing.Size(100, 23);
            this.bt_lh_Them.TabIndex = 22;
            this.bt_lh_Them.Text = "Thêm";
            this.bt_lh_Them.UseVisualStyleBackColor = true;
            this.bt_lh_Them.Click += new System.EventHandler(this.Bt_lh_Them_Click);
            // 
            // bt_lh_Xoa
            // 
            this.bt_lh_Xoa.Location = new System.Drawing.Point(241, 505);
            this.bt_lh_Xoa.Name = "bt_lh_Xoa";
            this.bt_lh_Xoa.Size = new System.Drawing.Size(100, 23);
            this.bt_lh_Xoa.TabIndex = 23;
            this.bt_lh_Xoa.Text = "Xóa";
            this.bt_lh_Xoa.UseVisualStyleBackColor = true;
            this.bt_lh_Xoa.Click += new System.EventHandler(this.Bt_lh_Xoa_Click);
            // 
            // bt_lh_CapNhat
            // 
            this.bt_lh_CapNhat.Location = new System.Drawing.Point(241, 553);
            this.bt_lh_CapNhat.Name = "bt_lh_CapNhat";
            this.bt_lh_CapNhat.Size = new System.Drawing.Size(100, 23);
            this.bt_lh_CapNhat.TabIndex = 24;
            this.bt_lh_CapNhat.Text = "Cập nhật";
            this.bt_lh_CapNhat.UseVisualStyleBackColor = true;
            this.bt_lh_CapNhat.Click += new System.EventHandler(this.Bt_lh_CapNhat_Click);
            // 
            // tb_lh_TimKiem
            // 
            this.tb_lh_TimKiem.Location = new System.Drawing.Point(508, 448);
            this.tb_lh_TimKiem.Multiline = true;
            this.tb_lh_TimKiem.Name = "tb_lh_TimKiem";
            this.tb_lh_TimKiem.Size = new System.Drawing.Size(109, 23);
            this.tb_lh_TimKiem.TabIndex = 25;
            // 
            // bt_lh_Tim
            // 
            this.bt_lh_Tim.Location = new System.Drawing.Point(507, 477);
            this.bt_lh_Tim.Name = "bt_lh_Tim";
            this.bt_lh_Tim.Size = new System.Drawing.Size(109, 23);
            this.bt_lh_Tim.TabIndex = 26;
            this.bt_lh_Tim.Text = "Tìm loại hàng";
            this.bt_lh_Tim.UseVisualStyleBackColor = true;
            this.bt_lh_Tim.Click += new System.EventHandler(this.Bt_lh_Tim_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Họ Tên: Đoàn Thái Châu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(12, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "MSSV: 20880010";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(355, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(300, 31);
            this.label10.TabIndex = 29;
            this.label10.Text = "QUẢN LÝ CỬA HÀNG";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(528, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Nhập tên hàng để tìm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(505, 423);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Nhập loại hàng để tìm";
            this.label12.Click += new System.EventHandler(this.Label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(355, 364);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(339, 31);
            this.label13.TabIndex = 32;
            this.label13.Text = "THÔNG TIN LOẠI HÀNG";
            this.label13.Click += new System.EventHandler(this.Label13_Click);
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Location = new System.Drawing.Point(659, 319);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(75, 23);
            this.bt_Thoat.TabIndex = 33;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = true;
            this.bt_Thoat.Click += new System.EventHandler(this.Bt_Thoat_Click);
            // 
            // MH_Chinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 609);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bt_lh_Tim);
            this.Controls.Add(this.tb_lh_TimKiem);
            this.Controls.Add(this.bt_lh_CapNhat);
            this.Controls.Add(this.bt_lh_Xoa);
            this.Controls.Add(this.bt_lh_Them);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_lh_LoaiHang);
            this.Controls.Add(this.lv_LoaiHang);
            this.Controls.Add(this.cbb_Loai);
            this.Controls.Add(this.cbb_NamSX);
            this.Controls.Add(this.tb_CongTySX);
            this.Controls.Add(this.dt_HanDung);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Tim);
            this.Controls.Add(this.tb_TimSP);
            this.Controls.Add(this.bt_CapNhat);
            this.Controls.Add(this.bt_Xoa);
            this.Controls.Add(this.bt_Them);
            this.Controls.Add(this.tb_TenHang);
            this.Controls.Add(this.tb_MaHang);
            this.Controls.Add(this.lv_DanhSach);
            this.Name = "MH_Chinh";
            this.Text = "Đồ án Nhập Môn Lập Trình";
            this.Load += new System.EventHandler(this.MH_Chinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_DanhSach;
        private System.Windows.Forms.TextBox tb_MaHang;
        private System.Windows.Forms.TextBox tb_TenHang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_CapNhat;
        private System.Windows.Forms.TextBox tb_TimSP;
        private System.Windows.Forms.Button bt_Tim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dt_HanDung;
        private System.Windows.Forms.TextBox tb_CongTySX;
        private System.Windows.Forms.ComboBox cbb_NamSX;
        private System.Windows.Forms.ComboBox cbb_Loai;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lv_LoaiHang;
        private System.Windows.Forms.TextBox tb_lh_LoaiHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_lh_Them;
        private System.Windows.Forms.Button bt_lh_Xoa;
        private System.Windows.Forms.Button bt_lh_CapNhat;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox tb_lh_TimKiem;
        private System.Windows.Forms.Button bt_lh_Tim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bt_Thoat;
    }
}

