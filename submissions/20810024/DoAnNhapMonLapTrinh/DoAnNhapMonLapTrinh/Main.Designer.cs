namespace DoAnNhapMonLapTrinh
{
    partial class Main
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
            this.btAddHang = new System.Windows.Forms.Button();
            this.btAddLoaiHang = new System.Windows.Forms.Button();
            this.btDeleteLoaiHang = new System.Windows.Forms.Button();
            this.btSearchLoaiHang = new System.Windows.Forms.Button();
            this.btUpdateHang = new System.Windows.Forms.Button();
            this.btDeleteHang = new System.Windows.Forms.Button();
            this.btSearchHang = new System.Windows.Forms.Button();
            this.btUpdateLoaiHang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtHanDung = new System.Windows.Forms.TextBox();
            this.txtCtySX = new System.Windows.Forms.TextBox();
            this.txtNamSX = new System.Windows.Forms.TextBox();
            this.txtLoaiHang = new System.Windows.Forms.TextBox();
            this.tkHangHoa = new System.Windows.Forms.TextBox();
            this.tkLoaiHang = new System.Windows.Forms.TextBox();
            this.textLoaiHang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lvHangHoa = new System.Windows.Forms.ListView();
            this.maHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hanDung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctySanXuat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.namSanXuat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loaiHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lvLoaiHang = new System.Windows.Forms.ListView();
            this.listLoaiHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btAddHang
            // 
            this.btAddHang.BackColor = System.Drawing.SystemColors.Control;
            this.btAddHang.Location = new System.Drawing.Point(41, 219);
            this.btAddHang.Name = "btAddHang";
            this.btAddHang.Size = new System.Drawing.Size(75, 23);
            this.btAddHang.TabIndex = 0;
            this.btAddHang.Text = "Thêm";
            this.btAddHang.UseVisualStyleBackColor = false;
            this.btAddHang.Click += new System.EventHandler(this.button1_Click);
            // 
            // btAddLoaiHang
            // 
            this.btAddLoaiHang.BackColor = System.Drawing.SystemColors.Control;
            this.btAddLoaiHang.Location = new System.Drawing.Point(504, 111);
            this.btAddLoaiHang.Name = "btAddLoaiHang";
            this.btAddLoaiHang.Size = new System.Drawing.Size(75, 23);
            this.btAddLoaiHang.TabIndex = 1;
            this.btAddLoaiHang.Text = "Thêm";
            this.btAddLoaiHang.UseVisualStyleBackColor = false;
            this.btAddLoaiHang.Click += new System.EventHandler(this.btAddLoaiHang_Click);
            // 
            // btDeleteLoaiHang
            // 
            this.btDeleteLoaiHang.BackColor = System.Drawing.SystemColors.Control;
            this.btDeleteLoaiHang.ForeColor = System.Drawing.Color.Red;
            this.btDeleteLoaiHang.Location = new System.Drawing.Point(609, 111);
            this.btDeleteLoaiHang.Name = "btDeleteLoaiHang";
            this.btDeleteLoaiHang.Size = new System.Drawing.Size(75, 23);
            this.btDeleteLoaiHang.TabIndex = 2;
            this.btDeleteLoaiHang.Text = "Xóa";
            this.btDeleteLoaiHang.UseVisualStyleBackColor = false;
            this.btDeleteLoaiHang.Click += new System.EventHandler(this.btDeleteLoaiHang_Click);
            // 
            // btSearchLoaiHang
            // 
            this.btSearchLoaiHang.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSearchLoaiHang.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btSearchLoaiHang.Location = new System.Drawing.Point(713, 60);
            this.btSearchLoaiHang.Name = "btSearchLoaiHang";
            this.btSearchLoaiHang.Size = new System.Drawing.Size(75, 23);
            this.btSearchLoaiHang.TabIndex = 3;
            this.btSearchLoaiHang.Text = "Tìm kiếm";
            this.btSearchLoaiHang.UseVisualStyleBackColor = false;
            this.btSearchLoaiHang.Click += new System.EventHandler(this.btSearchLoaiHang_Click);
            // 
            // btUpdateHang
            // 
            this.btUpdateHang.BackColor = System.Drawing.SystemColors.Control;
            this.btUpdateHang.Location = new System.Drawing.Point(263, 219);
            this.btUpdateHang.Name = "btUpdateHang";
            this.btUpdateHang.Size = new System.Drawing.Size(75, 23);
            this.btUpdateHang.TabIndex = 4;
            this.btUpdateHang.Text = "Sửa";
            this.btUpdateHang.UseVisualStyleBackColor = false;
            this.btUpdateHang.Click += new System.EventHandler(this.btUpdateHang_Click);
            // 
            // btDeleteHang
            // 
            this.btDeleteHang.BackColor = System.Drawing.SystemColors.Control;
            this.btDeleteHang.ForeColor = System.Drawing.Color.Red;
            this.btDeleteHang.Location = new System.Drawing.Point(152, 219);
            this.btDeleteHang.Name = "btDeleteHang";
            this.btDeleteHang.Size = new System.Drawing.Size(75, 23);
            this.btDeleteHang.TabIndex = 5;
            this.btDeleteHang.Text = "Xóa";
            this.btDeleteHang.UseVisualStyleBackColor = false;
            this.btDeleteHang.Click += new System.EventHandler(this.btDeleteHang_Click);
            // 
            // btSearchHang
            // 
            this.btSearchHang.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSearchHang.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btSearchHang.Location = new System.Drawing.Point(263, 60);
            this.btSearchHang.Name = "btSearchHang";
            this.btSearchHang.Size = new System.Drawing.Size(75, 23);
            this.btSearchHang.TabIndex = 6;
            this.btSearchHang.Text = "Tìm kiếm";
            this.btSearchHang.UseVisualStyleBackColor = false;
            this.btSearchHang.Click += new System.EventHandler(this.btSearchHang_Click);
            // 
            // btUpdateLoaiHang
            // 
            this.btUpdateLoaiHang.BackColor = System.Drawing.SystemColors.Control;
            this.btUpdateLoaiHang.Location = new System.Drawing.Point(713, 111);
            this.btUpdateLoaiHang.Name = "btUpdateLoaiHang";
            this.btUpdateLoaiHang.Size = new System.Drawing.Size(75, 23);
            this.btUpdateLoaiHang.TabIndex = 7;
            this.btUpdateLoaiHang.Text = "Sửa";
            this.btUpdateLoaiHang.UseVisualStyleBackColor = false;
            this.btUpdateLoaiHang.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hàng hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hạn dùng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Công ty sản xuất";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Năm sản xuất";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Loại hàng";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(117, 86);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(221, 20);
            this.txtMaHang.TabIndex = 15;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(117, 106);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(221, 20);
            this.txtTenHang.TabIndex = 16;
            // 
            // txtHanDung
            // 
            this.txtHanDung.Location = new System.Drawing.Point(117, 126);
            this.txtHanDung.Name = "txtHanDung";
            this.txtHanDung.Size = new System.Drawing.Size(221, 20);
            this.txtHanDung.TabIndex = 17;
            // 
            // txtCtySX
            // 
            this.txtCtySX.Location = new System.Drawing.Point(117, 146);
            this.txtCtySX.Name = "txtCtySX";
            this.txtCtySX.Size = new System.Drawing.Size(221, 20);
            this.txtCtySX.TabIndex = 18;
            // 
            // txtNamSX
            // 
            this.txtNamSX.Location = new System.Drawing.Point(117, 166);
            this.txtNamSX.Name = "txtNamSX";
            this.txtNamSX.Size = new System.Drawing.Size(221, 20);
            this.txtNamSX.TabIndex = 19;
            // 
            // txtLoaiHang
            // 
            this.txtLoaiHang.Location = new System.Drawing.Point(117, 186);
            this.txtLoaiHang.Name = "txtLoaiHang";
            this.txtLoaiHang.Size = new System.Drawing.Size(221, 20);
            this.txtLoaiHang.TabIndex = 20;
            // 
            // tkHangHoa
            // 
            this.tkHangHoa.Location = new System.Drawing.Point(117, 38);
            this.tkHangHoa.Name = "tkHangHoa";
            this.tkHangHoa.Size = new System.Drawing.Size(221, 20);
            this.tkHangHoa.TabIndex = 21;
            // 
            // tkLoaiHang
            // 
            this.tkLoaiHang.Location = new System.Drawing.Point(567, 38);
            this.tkLoaiHang.Name = "tkLoaiHang";
            this.tkLoaiHang.Size = new System.Drawing.Size(221, 20);
            this.tkLoaiHang.TabIndex = 22;
            // 
            // textLoaiHang
            // 
            this.textLoaiHang.Location = new System.Drawing.Point(567, 85);
            this.textLoaiHang.Name = "textLoaiHang";
            this.textLoaiHang.Size = new System.Drawing.Size(221, 20);
            this.textLoaiHang.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(500, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 24);
            this.label8.TabIndex = 24;
            this.label8.Text = "Loại hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(501, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Loại hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Tìm kiếm theo tên";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(501, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Tìm kiếm";
            // 
            // lvHangHoa
            // 
            this.lvHangHoa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maHang,
            this.tenHang,
            this.hanDung,
            this.ctySanXuat,
            this.namSanXuat,
            this.loaiHang});
            this.lvHangHoa.HideSelection = false;
            this.lvHangHoa.Location = new System.Drawing.Point(16, 294);
            this.lvHangHoa.Name = "lvHangHoa";
            this.lvHangHoa.Size = new System.Drawing.Size(534, 144);
            this.lvHangHoa.TabIndex = 28;
            this.lvHangHoa.UseCompatibleStateImageBehavior = false;
            this.lvHangHoa.View = System.Windows.Forms.View.Details;
            // 
            // maHang
            // 
            this.maHang.Text = "Mã hàng";
            // 
            // tenHang
            // 
            this.tenHang.Text = "Tên hàng";
            this.tenHang.Width = 122;
            // 
            // hanDung
            // 
            this.hanDung.Text = "Hạn dùng";
            this.hanDung.Width = 87;
            // 
            // ctySanXuat
            // 
            this.ctySanXuat.Text = "Công ty SXuất";
            this.ctySanXuat.Width = 118;
            // 
            // namSanXuat
            // 
            this.namSanXuat.Text = "Năm SXuất";
            this.namSanXuat.Width = 71;
            // 
            // loaiHang
            // 
            this.loaiHang.Text = "Loại hàng";
            this.loaiHang.Width = 98;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(242, 259);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Danh sách hàng hóa";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(642, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 17);
            this.label13.TabIndex = 30;
            this.label13.Text = "Danh sách loại hàng";
            // 
            // lvLoaiHang
            // 
            this.lvLoaiHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listLoaiHang});
            this.lvLoaiHang.HideSelection = false;
            this.lvLoaiHang.Location = new System.Drawing.Point(645, 175);
            this.lvLoaiHang.Name = "lvLoaiHang";
            this.lvLoaiHang.Size = new System.Drawing.Size(135, 97);
            this.lvLoaiHang.TabIndex = 31;
            this.lvLoaiHang.UseCompatibleStateImageBehavior = false;
            this.lvLoaiHang.View = System.Windows.Forms.View.Details;
            // 
            // listLoaiHang
            // 
            this.listLoaiHang.Text = "Loại hàng";
            this.listLoaiHang.Width = 126;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvLoaiHang);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lvHangHoa);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textLoaiHang);
            this.Controls.Add(this.tkLoaiHang);
            this.Controls.Add(this.tkHangHoa);
            this.Controls.Add(this.txtLoaiHang);
            this.Controls.Add(this.txtNamSX);
            this.Controls.Add(this.txtCtySX);
            this.Controls.Add(this.txtHanDung);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btUpdateLoaiHang);
            this.Controls.Add(this.btSearchHang);
            this.Controls.Add(this.btDeleteHang);
            this.Controls.Add(this.btUpdateHang);
            this.Controls.Add(this.btSearchLoaiHang);
            this.Controls.Add(this.btDeleteLoaiHang);
            this.Controls.Add(this.btAddLoaiHang);
            this.Controls.Add(this.btAddHang);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAddHang;
        private System.Windows.Forms.Button btAddLoaiHang;
        private System.Windows.Forms.Button btDeleteLoaiHang;
        private System.Windows.Forms.Button btSearchLoaiHang;
        private System.Windows.Forms.Button btUpdateHang;
        private System.Windows.Forms.Button btDeleteHang;
        private System.Windows.Forms.Button btSearchHang;
        private System.Windows.Forms.Button btUpdateLoaiHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtHanDung;
        private System.Windows.Forms.TextBox txtCtySX;
        private System.Windows.Forms.TextBox txtNamSX;
        private System.Windows.Forms.TextBox txtLoaiHang;
        private System.Windows.Forms.TextBox tkHangHoa;
        private System.Windows.Forms.TextBox tkLoaiHang;
        private System.Windows.Forms.TextBox textLoaiHang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView lvHangHoa;
        private System.Windows.Forms.ColumnHeader maHang;
        private System.Windows.Forms.ColumnHeader tenHang;
        private System.Windows.Forms.ColumnHeader hanDung;
        private System.Windows.Forms.ColumnHeader ctySanXuat;
        private System.Windows.Forms.ColumnHeader namSanXuat;
        private System.Windows.Forms.ColumnHeader loaiHang;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView lvLoaiHang;
        private System.Windows.Forms.ColumnHeader listLoaiHang;
    }
}