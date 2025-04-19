namespace DoAnCuoiKi
{
    partial class formChinh
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
            this.lvPanelHienThi = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTenHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHanDung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCtySanXuat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNamSanXuat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLoaiHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btHienThiAll = new System.Windows.Forms.Button();
            this.dtpNamSanXuat = new System.Windows.Forms.DateTimePicker();
            this.cbLoaiHang = new System.Windows.Forms.ComboBox();
            this.btThemMatHang = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCtySanXuat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHanDung = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTenMatHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btTimKiemMatHang = new System.Windows.Forms.Button();
            this.btXoaMatHang = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbTenLoaiHang = new System.Windows.Forms.TextBox();
            this.btThemLoaiHang = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btTimKiemLoaiHang = new System.Windows.Forms.Button();
            this.btXoaLoaiHang = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudCsNamSanXuat = new System.Windows.Forms.NumericUpDown();
            this.cbLoaiHang2 = new System.Windows.Forms.ComboBox();
            this.btChinhSuaMatHang = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCsCtySanXuat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCsHanDung = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbCsTenMatHang = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbCsID = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbCSTenLoaiHang = new System.Windows.Forms.TextBox();
            this.btSuaLoaiHang = new System.Windows.Forms.Button();
            this.cbCSLoaiHang = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCsNamSanXuat)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvPanelHienThi
            // 
            this.lvPanelHienThi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chTenHang,
            this.chHanDung,
            this.chCtySanXuat,
            this.chNamSanXuat,
            this.chLoaiHang});
            this.lvPanelHienThi.FullRowSelect = true;
            this.lvPanelHienThi.GridLines = true;
            this.lvPanelHienThi.HideSelection = false;
            this.lvPanelHienThi.Location = new System.Drawing.Point(518, 12);
            this.lvPanelHienThi.Name = "lvPanelHienThi";
            this.lvPanelHienThi.Size = new System.Drawing.Size(525, 382);
            this.lvPanelHienThi.TabIndex = 0;
            this.lvPanelHienThi.UseCompatibleStateImageBehavior = false;
            this.lvPanelHienThi.View = System.Windows.Forms.View.Details;
            this.lvPanelHienThi.SelectedIndexChanged += new System.EventHandler(this.lvPanelHienThi_SelectedIndexChanged);
            // 
            // chID
            // 
            this.chID.Text = "Mã";
            this.chID.Width = 45;
            // 
            // chTenHang
            // 
            this.chTenHang.Text = "Tên hàng";
            // 
            // chHanDung
            // 
            this.chHanDung.Text = "Hạn dùng(tháng)";
            this.chHanDung.Width = 100;
            // 
            // chCtySanXuat
            // 
            this.chCtySanXuat.Text = "Công ty sản xuất";
            this.chCtySanXuat.Width = 98;
            // 
            // chNamSanXuat
            // 
            this.chNamSanXuat.Text = "Năm sản xuất";
            this.chNamSanXuat.Width = 87;
            // 
            // chLoaiHang
            // 
            this.chLoaiHang.Text = "Loại hàng";
            this.chLoaiHang.Width = 135;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btHienThiAll);
            this.groupBox1.Controls.Add(this.dtpNamSanXuat);
            this.groupBox1.Controls.Add(this.cbLoaiHang);
            this.groupBox1.Controls.Add(this.btThemMatHang);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbCtySanXuat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbHanDung);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbTenMatHang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 253);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm mặt hàng";
            // 
            // btHienThiAll
            // 
            this.btHienThiAll.Location = new System.Drawing.Point(140, 177);
            this.btHienThiAll.Name = "btHienThiAll";
            this.btHienThiAll.Size = new System.Drawing.Size(75, 23);
            this.btHienThiAll.TabIndex = 18;
            this.btHienThiAll.Text = "Refresh";
            this.toolTip1.SetToolTip(this.btHienThiAll, "Refresh listview, hiển thị dử liệu tất cả hàng hóa");
            this.btHienThiAll.UseVisualStyleBackColor = true;
            this.btHienThiAll.Click += new System.EventHandler(this.btHienThiAll_Click);
            // 
            // dtpNamSanXuat
            // 
            this.dtpNamSanXuat.CustomFormat = "yyyy";
            this.dtpNamSanXuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNamSanXuat.Location = new System.Drawing.Point(91, 123);
            this.dtpNamSanXuat.Name = "dtpNamSanXuat";
            this.dtpNamSanXuat.ShowUpDown = true;
            this.dtpNamSanXuat.Size = new System.Drawing.Size(140, 20);
            this.dtpNamSanXuat.TabIndex = 15;
            // 
            // cbLoaiHang
            // 
            this.cbLoaiHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiHang.FormattingEnabled = true;
            this.cbLoaiHang.Location = new System.Drawing.Point(91, 150);
            this.cbLoaiHang.Name = "cbLoaiHang";
            this.cbLoaiHang.Size = new System.Drawing.Size(140, 21);
            this.cbLoaiHang.TabIndex = 15;
            // 
            // btThemMatHang
            // 
            this.btThemMatHang.Location = new System.Drawing.Point(34, 177);
            this.btThemMatHang.Name = "btThemMatHang";
            this.btThemMatHang.Size = new System.Drawing.Size(75, 23);
            this.btThemMatHang.TabIndex = 12;
            this.btThemMatHang.Text = "Thêm";
            this.btThemMatHang.UseVisualStyleBackColor = true;
            this.btThemMatHang.Click += new System.EventHandler(this.btThemMatHang_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Loại hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Năm sản xuất:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cty sản xuất:";
            // 
            // tbCtySanXuat
            // 
            this.tbCtySanXuat.Location = new System.Drawing.Point(91, 97);
            this.tbCtySanXuat.Name = "tbCtySanXuat";
            this.tbCtySanXuat.Size = new System.Drawing.Size(140, 20);
            this.tbCtySanXuat.TabIndex = 6;
            this.tbCtySanXuat.Text = "Hg Food";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hạn dùng:";
            // 
            // tbHanDung
            // 
            this.tbHanDung.Location = new System.Drawing.Point(91, 71);
            this.tbHanDung.Name = "tbHanDung";
            this.tbHanDung.Size = new System.Drawing.Size(140, 20);
            this.tbHanDung.TabIndex = 4;
            this.tbHanDung.Text = "9";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên hàng:";
            // 
            // tbTenMatHang
            // 
            this.tbTenMatHang.Location = new System.Drawing.Point(91, 45);
            this.tbTenMatHang.Name = "tbTenMatHang";
            this.tbTenMatHang.Size = new System.Drawing.Size(140, 20);
            this.tbTenMatHang.TabIndex = 2;
            this.tbTenMatHang.Text = "Bánh Gạo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(91, 19);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(140, 20);
            this.tbID.TabIndex = 0;
            this.tbID.Text = "BG82";
            // 
            // btTimKiemMatHang
            // 
            this.btTimKiemMatHang.Location = new System.Drawing.Point(137, 177);
            this.btTimKiemMatHang.Name = "btTimKiemMatHang";
            this.btTimKiemMatHang.Size = new System.Drawing.Size(75, 23);
            this.btTimKiemMatHang.TabIndex = 14;
            this.btTimKiemMatHang.Text = "Tìm kiếm";
            this.toolTip1.SetToolTip(this.btTimKiemMatHang, "Tìm kiếm với \"Tên hàng\"");
            this.btTimKiemMatHang.UseVisualStyleBackColor = true;
            this.btTimKiemMatHang.Click += new System.EventHandler(this.btTimKiemMatHang_Click);
            // 
            // btXoaMatHang
            // 
            this.btXoaMatHang.Location = new System.Drawing.Point(36, 206);
            this.btXoaMatHang.Name = "btXoaMatHang";
            this.btXoaMatHang.Size = new System.Drawing.Size(75, 23);
            this.btXoaMatHang.TabIndex = 13;
            this.btXoaMatHang.Text = "Xóa";
            this.btXoaMatHang.UseVisualStyleBackColor = true;
            this.btXoaMatHang.Click += new System.EventHandler(this.btXoaMatHang_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbTenLoaiHang);
            this.groupBox2.Controls.Add(this.btThemLoaiHang);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(12, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 118);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm loại hàng";
            // 
            // tbTenLoaiHang
            // 
            this.tbTenLoaiHang.Location = new System.Drawing.Point(96, 25);
            this.tbTenLoaiHang.Name = "tbTenLoaiHang";
            this.tbTenLoaiHang.Size = new System.Drawing.Size(135, 20);
            this.tbTenLoaiHang.TabIndex = 17;
            // 
            // btThemLoaiHang
            // 
            this.btThemLoaiHang.Location = new System.Drawing.Point(80, 51);
            this.btThemLoaiHang.Name = "btThemLoaiHang";
            this.btThemLoaiHang.Size = new System.Drawing.Size(75, 23);
            this.btThemLoaiHang.TabIndex = 12;
            this.btThemLoaiHang.Text = "Thêm";
            this.btThemLoaiHang.UseVisualStyleBackColor = true;
            this.btThemLoaiHang.Click += new System.EventHandler(this.btThemLoaiHang_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Tên loại hàng:";
            // 
            // btTimKiemLoaiHang
            // 
            this.btTimKiemLoaiHang.Location = new System.Drawing.Point(96, 73);
            this.btTimKiemLoaiHang.Name = "btTimKiemLoaiHang";
            this.btTimKiemLoaiHang.Size = new System.Drawing.Size(75, 23);
            this.btTimKiemLoaiHang.TabIndex = 14;
            this.btTimKiemLoaiHang.Text = "Tìm kiếm";
            this.btTimKiemLoaiHang.UseVisualStyleBackColor = true;
            this.btTimKiemLoaiHang.Click += new System.EventHandler(this.btTimKiemLoaiHang_Click);
            // 
            // btXoaLoaiHang
            // 
            this.btXoaLoaiHang.Location = new System.Drawing.Point(15, 73);
            this.btXoaLoaiHang.Name = "btXoaLoaiHang";
            this.btXoaLoaiHang.Size = new System.Drawing.Size(75, 23);
            this.btXoaLoaiHang.TabIndex = 13;
            this.btXoaLoaiHang.Text = "Xóa";
            this.btXoaLoaiHang.UseVisualStyleBackColor = true;
            this.btXoaLoaiHang.Click += new System.EventHandler(this.btXoaLoaiHang_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudCsNamSanXuat);
            this.groupBox3.Controls.Add(this.cbLoaiHang2);
            this.groupBox3.Controls.Add(this.btXoaMatHang);
            this.groupBox3.Controls.Add(this.btTimKiemMatHang);
            this.groupBox3.Controls.Add(this.btChinhSuaMatHang);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbCsCtySanXuat);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbCsHanDung);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.tbCsTenMatHang);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.tbCsID);
            this.groupBox3.Location = new System.Drawing.Point(264, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 253);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chỉnh sửa mặt hàng";
            // 
            // nudCsNamSanXuat
            // 
            this.nudCsNamSanXuat.Location = new System.Drawing.Point(91, 124);
            this.nudCsNamSanXuat.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nudCsNamSanXuat.Name = "nudCsNamSanXuat";
            this.nudCsNamSanXuat.Size = new System.Drawing.Size(140, 20);
            this.nudCsNamSanXuat.TabIndex = 16;
            // 
            // cbLoaiHang2
            // 
            this.cbLoaiHang2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiHang2.FormattingEnabled = true;
            this.cbLoaiHang2.Location = new System.Drawing.Point(91, 150);
            this.cbLoaiHang2.Name = "cbLoaiHang2";
            this.cbLoaiHang2.Size = new System.Drawing.Size(140, 21);
            this.cbLoaiHang2.TabIndex = 15;
            // 
            // btChinhSuaMatHang
            // 
            this.btChinhSuaMatHang.Location = new System.Drawing.Point(36, 177);
            this.btChinhSuaMatHang.Name = "btChinhSuaMatHang";
            this.btChinhSuaMatHang.Size = new System.Drawing.Size(75, 23);
            this.btChinhSuaMatHang.TabIndex = 12;
            this.btChinhSuaMatHang.Text = "Chỉnh sửa";
            this.btChinhSuaMatHang.UseVisualStyleBackColor = true;
            this.btChinhSuaMatHang.Click += new System.EventHandler(this.btChinhSuaMatHang_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Loại hàng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Năm sản xuất:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Cty sản xuất:";
            // 
            // tbCsCtySanXuat
            // 
            this.tbCsCtySanXuat.Location = new System.Drawing.Point(91, 97);
            this.tbCsCtySanXuat.Name = "tbCsCtySanXuat";
            this.tbCsCtySanXuat.Size = new System.Drawing.Size(140, 20);
            this.tbCsCtySanXuat.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Hạn dùng:";
            // 
            // tbCsHanDung
            // 
            this.tbCsHanDung.Location = new System.Drawing.Point(91, 71);
            this.tbCsHanDung.Name = "tbCsHanDung";
            this.tbCsHanDung.Size = new System.Drawing.Size(140, 20);
            this.tbCsHanDung.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Tên hàng:";
            // 
            // tbCsTenMatHang
            // 
            this.tbCsTenMatHang.Location = new System.Drawing.Point(91, 45);
            this.tbCsTenMatHang.Name = "tbCsTenMatHang";
            this.tbCsTenMatHang.Size = new System.Drawing.Size(140, 20);
            this.tbCsTenMatHang.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Mã:";
            // 
            // tbCsID
            // 
            this.tbCsID.Location = new System.Drawing.Point(91, 19);
            this.tbCsID.Name = "tbCsID";
            this.tbCsID.Size = new System.Drawing.Size(140, 20);
            this.tbCsID.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbCSTenLoaiHang);
            this.groupBox4.Controls.Add(this.btSuaLoaiHang);
            this.groupBox4.Controls.Add(this.cbCSLoaiHang);
            this.groupBox4.Controls.Add(this.btXoaLoaiHang);
            this.groupBox4.Controls.Add(this.btTimKiemLoaiHang);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(264, 276);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(237, 118);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chỉnh sửa loại hàng";
            // 
            // tbCSTenLoaiHang
            // 
            this.tbCSTenLoaiHang.Location = new System.Drawing.Point(96, 46);
            this.tbCSTenLoaiHang.Name = "tbCSTenLoaiHang";
            this.tbCSTenLoaiHang.Size = new System.Drawing.Size(135, 20);
            this.tbCSTenLoaiHang.TabIndex = 16;
            // 
            // btSuaLoaiHang
            // 
            this.btSuaLoaiHang.Location = new System.Drawing.Point(15, 44);
            this.btSuaLoaiHang.Name = "btSuaLoaiHang";
            this.btSuaLoaiHang.Size = new System.Drawing.Size(75, 23);
            this.btSuaLoaiHang.TabIndex = 17;
            this.btSuaLoaiHang.Text = "Chỉnh thành:";
            this.btSuaLoaiHang.UseVisualStyleBackColor = true;
            this.btSuaLoaiHang.Click += new System.EventHandler(this.btSuaLoaiHang_Click);
            // 
            // cbCSLoaiHang
            // 
            this.cbCSLoaiHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCSLoaiHang.FormattingEnabled = true;
            this.cbCSLoaiHang.Location = new System.Drawing.Point(96, 19);
            this.cbCSLoaiHang.Name = "cbCSLoaiHang";
            this.cbCSLoaiHang.Size = new System.Drawing.Size(135, 21);
            this.cbCSLoaiHang.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Tên loại hàng:";
            // 
            // formChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 417);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvPanelHienThi);
            this.Name = "formChinh";
            this.Text = "Phần mềm quản lý cửa hàng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCsNamSanXuat)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvPanelHienThi;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chTenHang;
        private System.Windows.Forms.ColumnHeader chHanDung;
        private System.Windows.Forms.ColumnHeader chCtySanXuat;
        private System.Windows.Forms.ColumnHeader chNamSanXuat;
        private System.Windows.Forms.ColumnHeader chLoaiHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btTimKiemMatHang;
        private System.Windows.Forms.Button btXoaMatHang;
        private System.Windows.Forms.Button btThemMatHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCtySanXuat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbHanDung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTenMatHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btTimKiemLoaiHang;
        private System.Windows.Forms.Button btXoaLoaiHang;
        private System.Windows.Forms.Button btThemLoaiHang;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbLoaiHang;
        private System.Windows.Forms.DateTimePicker dtpNamSanXuat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbLoaiHang2;
        private System.Windows.Forms.Button btChinhSuaMatHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCsCtySanXuat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbCsHanDung;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbCsTenMatHang;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbCsID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btSuaLoaiHang;
        private System.Windows.Forms.ComboBox cbCSLoaiHang;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbTenLoaiHang;
        private System.Windows.Forms.TextBox tbCSTenLoaiHang;
        private System.Windows.Forms.Button btHienThiAll;
        private System.Windows.Forms.NumericUpDown nudCsNamSanXuat;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

