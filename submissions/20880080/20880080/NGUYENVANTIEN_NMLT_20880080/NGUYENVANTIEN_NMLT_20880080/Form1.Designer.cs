namespace NGUYENVANTIEN_NMLT_20880080
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewSanPham = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMahang = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtTenhang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCongty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNamsanxuat = new System.Windows.Forms.DateTimePicker();
            this.txtHansudung = new System.Windows.Forms.DateTimePicker();
            this.cbPhanloai = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewTimKiem = new System.Windows.Forms.DataGridView();
            this.radMahang = new System.Windows.Forms.RadioButton();
            this.radTenhang = new System.Windows.Forms.RadioButton();
            this.radPhanloai = new System.Windows.Forms.RadioButton();
            this.radCongty = new System.Windows.Forms.RadioButton();
            this.radNamsanxuat = new System.Windows.Forms.RadioButton();
            this.radHansudung = new System.Windows.Forms.RadioButton();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtMahangTK = new System.Windows.Forms.TextBox();
            this.txtTenhangTK = new System.Windows.Forms.TextBox();
            this.txtCongtyTK = new System.Windows.Forms.TextBox();
            this.txtNamsanxuatTK = new System.Windows.Forms.DateTimePicker();
            this.txtHansudungTK = new System.Windows.Forms.DateTimePicker();
            this.cbPhanloaiTK = new System.Windows.Forms.ComboBox();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewSanPham);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản Lý Sản Phẩm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewTimKiem);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tìm Kiếm Sản Phẩm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbPhanloai);
            this.panel1.Controls.Add(this.txtHansudung);
            this.panel1.Controls.Add(this.txtNamsanxuat);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCongty);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTenhang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.txtMahang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Location = new System.Drawing.Point(7, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 243);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewSanPham
            // 
            this.dataGridViewSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewSanPham.Location = new System.Drawing.Point(7, 259);
            this.dataGridViewSanPham.Name = "dataGridViewSanPham";
            this.dataGridViewSanPham.RowHeadersWidth = 51;
            this.dataGridViewSanPham.RowTemplate.Height = 24;
            this.dataGridViewSanPham.Size = new System.Drawing.Size(778, 155);
            this.dataGridViewSanPham.TabIndex = 1;
            this.dataGridViewSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSanPham_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(48, 166);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 52);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Hàng";
            // 
            // txtMahang
            // 
            this.txtMahang.Location = new System.Drawing.Point(97, 13);
            this.txtMahang.Name = "txtMahang";
            this.txtMahang.Size = new System.Drawing.Size(215, 22);
            this.txtMahang.TabIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(187, 166);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 52);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(336, 166);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 52);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtTenhang
            // 
            this.txtTenhang.Location = new System.Drawing.Point(97, 54);
            this.txtTenhang.Name = "txtTenhang";
            this.txtTenhang.Size = new System.Drawing.Size(215, 22);
            this.txtTenhang.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phân Loại";
            // 
            // txtCongty
            // 
            this.txtCongty.Location = new System.Drawing.Point(546, 13);
            this.txtCongty.Name = "txtCongty";
            this.txtCongty.Size = new System.Drawing.Size(215, 22);
            this.txtCongty.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Công Ty Sản Xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Năm Sản Xuất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Hạn Sử Dụng";
            // 
            // txtNamsanxuat
            // 
            this.txtNamsanxuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNamsanxuat.Location = new System.Drawing.Point(546, 54);
            this.txtNamsanxuat.Name = "txtNamsanxuat";
            this.txtNamsanxuat.Size = new System.Drawing.Size(215, 22);
            this.txtNamsanxuat.TabIndex = 14;
            // 
            // txtHansudung
            // 
            this.txtHansudung.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtHansudung.Location = new System.Drawing.Point(546, 92);
            this.txtHansudung.Name = "txtHansudung";
            this.txtHansudung.Size = new System.Drawing.Size(215, 22);
            this.txtHansudung.TabIndex = 15;
            // 
            // cbPhanloai
            // 
            this.cbPhanloai.FormattingEnabled = true;
            this.cbPhanloai.Items.AddRange(new object[] {
            "Nước ngọt",
            "Nước suối",
            "Bia",
            "Bánh",
            "Kẹo"});
            this.cbPhanloai.Location = new System.Drawing.Point(97, 99);
            this.cbPhanloai.Name = "cbPhanloai";
            this.cbPhanloai.Size = new System.Drawing.Size(215, 24);
            this.cbPhanloai.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Phân Loại";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Công Ty Sản Xuất";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Năm Sản Xuất";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Hạn Sử Dụng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbPhanloaiTK);
            this.panel2.Controls.Add(this.txtHansudungTK);
            this.panel2.Controls.Add(this.txtNamsanxuatTK);
            this.panel2.Controls.Add(this.txtCongtyTK);
            this.panel2.Controls.Add(this.txtTenhangTK);
            this.panel2.Controls.Add(this.txtMahangTK);
            this.panel2.Controls.Add(this.btnTimkiem);
            this.panel2.Controls.Add(this.radHansudung);
            this.panel2.Controls.Add(this.radNamsanxuat);
            this.panel2.Controls.Add(this.radCongty);
            this.panel2.Controls.Add(this.radPhanloai);
            this.panel2.Controls.Add(this.radTenhang);
            this.panel2.Controls.Add(this.radMahang);
            this.panel2.Location = new System.Drawing.Point(7, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 215);
            this.panel2.TabIndex = 0;
            // 
            // dataGridViewTimKiem
            // 
            this.dataGridViewTimKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dataGridViewTimKiem.Location = new System.Drawing.Point(6, 231);
            this.dataGridViewTimKiem.Name = "dataGridViewTimKiem";
            this.dataGridViewTimKiem.RowHeadersWidth = 51;
            this.dataGridViewTimKiem.RowTemplate.Height = 24;
            this.dataGridViewTimKiem.Size = new System.Drawing.Size(779, 183);
            this.dataGridViewTimKiem.TabIndex = 1;
            // 
            // radMahang
            // 
            this.radMahang.AutoSize = true;
            this.radMahang.Location = new System.Drawing.Point(26, 16);
            this.radMahang.Name = "radMahang";
            this.radMahang.Size = new System.Drawing.Size(86, 21);
            this.radMahang.TabIndex = 0;
            this.radMahang.TabStop = true;
            this.radMahang.Text = "Mã Hàng";
            this.radMahang.UseVisualStyleBackColor = true;
            // 
            // radTenhang
            // 
            this.radTenhang.AutoSize = true;
            this.radTenhang.Location = new System.Drawing.Point(26, 65);
            this.radTenhang.Name = "radTenhang";
            this.radTenhang.Size = new System.Drawing.Size(92, 21);
            this.radTenhang.TabIndex = 1;
            this.radTenhang.TabStop = true;
            this.radTenhang.Text = "Tên Hàng";
            this.radTenhang.UseVisualStyleBackColor = true;
            // 
            // radPhanloai
            // 
            this.radPhanloai.AutoSize = true;
            this.radPhanloai.Location = new System.Drawing.Point(26, 111);
            this.radPhanloai.Name = "radPhanloai";
            this.radPhanloai.Size = new System.Drawing.Size(93, 21);
            this.radPhanloai.TabIndex = 2;
            this.radPhanloai.TabStop = true;
            this.radPhanloai.Text = "Phân Loại";
            this.radPhanloai.UseVisualStyleBackColor = true;
            // 
            // radCongty
            // 
            this.radCongty.AutoSize = true;
            this.radCongty.Location = new System.Drawing.Point(380, 16);
            this.radCongty.Name = "radCongty";
            this.radCongty.Size = new System.Drawing.Size(144, 21);
            this.radCongty.TabIndex = 3;
            this.radCongty.TabStop = true;
            this.radCongty.Text = "Công Ty Sản Xuất";
            this.radCongty.UseVisualStyleBackColor = true;
            // 
            // radNamsanxuat
            // 
            this.radNamsanxuat.AutoSize = true;
            this.radNamsanxuat.Location = new System.Drawing.Point(380, 65);
            this.radNamsanxuat.Name = "radNamsanxuat";
            this.radNamsanxuat.Size = new System.Drawing.Size(120, 21);
            this.radNamsanxuat.TabIndex = 4;
            this.radNamsanxuat.TabStop = true;
            this.radNamsanxuat.Text = "Năm Sản Xuất";
            this.radNamsanxuat.UseVisualStyleBackColor = true;
            // 
            // radHansudung
            // 
            this.radHansudung.AutoSize = true;
            this.radHansudung.Location = new System.Drawing.Point(380, 111);
            this.radHansudung.Name = "radHansudung";
            this.radHansudung.Size = new System.Drawing.Size(114, 21);
            this.radHansudung.TabIndex = 5;
            this.radHansudung.TabStop = true;
            this.radHansudung.Text = "Hạn Sử Dụng";
            this.radHansudung.UseVisualStyleBackColor = true;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(331, 170);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(81, 42);
            this.btnTimkiem.TabIndex = 6;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtMahangTK
            // 
            this.txtMahangTK.Location = new System.Drawing.Point(118, 16);
            this.txtMahangTK.Name = "txtMahangTK";
            this.txtMahangTK.Size = new System.Drawing.Size(232, 22);
            this.txtMahangTK.TabIndex = 7;
            // 
            // txtTenhangTK
            // 
            this.txtTenhangTK.Location = new System.Drawing.Point(118, 65);
            this.txtTenhangTK.Name = "txtTenhangTK";
            this.txtTenhangTK.Size = new System.Drawing.Size(232, 22);
            this.txtTenhangTK.TabIndex = 8;
            // 
            // txtCongtyTK
            // 
            this.txtCongtyTK.Location = new System.Drawing.Point(526, 16);
            this.txtCongtyTK.Name = "txtCongtyTK";
            this.txtCongtyTK.Size = new System.Drawing.Size(232, 22);
            this.txtCongtyTK.TabIndex = 10;
            // 
            // txtNamsanxuatTK
            // 
            this.txtNamsanxuatTK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNamsanxuatTK.Location = new System.Drawing.Point(526, 65);
            this.txtNamsanxuatTK.Name = "txtNamsanxuatTK";
            this.txtNamsanxuatTK.Size = new System.Drawing.Size(232, 22);
            this.txtNamsanxuatTK.TabIndex = 11;
            // 
            // txtHansudungTK
            // 
            this.txtHansudungTK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtHansudungTK.Location = new System.Drawing.Point(526, 111);
            this.txtHansudungTK.Name = "txtHansudungTK";
            this.txtHansudungTK.Size = new System.Drawing.Size(232, 22);
            this.txtHansudungTK.TabIndex = 12;
            // 
            // cbPhanloaiTK
            // 
            this.cbPhanloaiTK.FormattingEnabled = true;
            this.cbPhanloaiTK.Items.AddRange(new object[] {
            "Nước ngọt",
            "Nước suối",
            "Bia",
            "Bánh",
            "Kẹo"});
            this.cbPhanloaiTK.Location = new System.Drawing.Point(118, 113);
            this.cbPhanloaiTK.Name = "cbPhanloaiTK";
            this.cbPhanloaiTK.Size = new System.Drawing.Size(232, 24);
            this.cbPhanloaiTK.TabIndex = 13;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Mã Hàng";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Tên Hàng";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Phân Loại";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Công Ty Sản Xuất";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Năm Sản Xuất";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Hạn Sử Dụng";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbPhanloai;
        private System.Windows.Forms.DateTimePicker txtHansudung;
        private System.Windows.Forms.DateTimePicker txtNamsanxuat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCongty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMahang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridViewTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbPhanloaiTK;
        private System.Windows.Forms.DateTimePicker txtHansudungTK;
        private System.Windows.Forms.DateTimePicker txtNamsanxuatTK;
        private System.Windows.Forms.TextBox txtCongtyTK;
        private System.Windows.Forms.TextBox txtTenhangTK;
        private System.Windows.Forms.TextBox txtMahangTK;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.RadioButton radHansudung;
        private System.Windows.Forms.RadioButton radNamsanxuat;
        private System.Windows.Forms.RadioButton radCongty;
        private System.Windows.Forms.RadioButton radPhanloai;
        private System.Windows.Forms.RadioButton radTenhang;
        private System.Windows.Forms.RadioButton radMahang;
    }
}

