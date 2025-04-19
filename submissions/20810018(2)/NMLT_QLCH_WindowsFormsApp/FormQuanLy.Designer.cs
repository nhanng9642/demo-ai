namespace NMLT_QLCH_WindowsFormsApp
{
    partial class FormQuanLy
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
            this.tabApp = new System.Windows.Forms.TabControl();
            this.tabQuanLyHang = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstvHang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pnlThongTinHang = new System.Windows.Forms.Panel();
            this.dtpNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbLoaiHang = new System.Windows.Forms.ComboBox();
            this.dtpNgaySanXuat = new System.Windows.Forms.DateTimePicker();
            this.txtNoiSanXuat = new System.Windows.Forms.TextBox();
            this.numHanDungTheoNgay = new System.Windows.Forms.NumericUpDown();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabQuanLyLoaiHang = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lstvLoaiHang = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSaveLoaiHang = new System.Windows.Forms.Button();
            this.btnUndoLoaiHang = new System.Windows.Forms.Button();
            this.btnXoaLoaiHang = new System.Windows.Forms.Button();
            this.btnThemLoaiHang = new System.Windows.Forms.Button();
            this.pnlThongTinLoaiHang = new System.Windows.Forms.Panel();
            this.txtTenLoaiHang = new System.Windows.Forms.TextBox();
            this.txtMaLoaiHang = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefreshLoaihang = new System.Windows.Forms.Button();
            this.btnSearchLoaiHang = new System.Windows.Forms.Button();
            this.txtSearchLoaiHang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabApp.SuspendLayout();
            this.tabQuanLyHang.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlThongTinHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHanDungTheoNgay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabQuanLyLoaiHang.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlThongTinLoaiHang.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabApp
            // 
            this.tabApp.Controls.Add(this.tabQuanLyHang);
            this.tabApp.Controls.Add(this.tabQuanLyLoaiHang);
            this.tabApp.Location = new System.Drawing.Point(1, 27);
            this.tabApp.Name = "tabApp";
            this.tabApp.SelectedIndex = 0;
            this.tabApp.Size = new System.Drawing.Size(740, 692);
            this.tabApp.TabIndex = 2;
            this.tabApp.SelectedIndexChanged += new System.EventHandler(this.tabApp_SelectedIndexChanged);
            // 
            // tabQuanLyHang
            // 
            this.tabQuanLyHang.Controls.Add(this.groupBox3);
            this.tabQuanLyHang.Controls.Add(this.groupBox2);
            this.tabQuanLyHang.Controls.Add(this.groupBox1);
            this.tabQuanLyHang.Location = new System.Drawing.Point(4, 22);
            this.tabQuanLyHang.Name = "tabQuanLyHang";
            this.tabQuanLyHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuanLyHang.Size = new System.Drawing.Size(732, 666);
            this.tabQuanLyHang.TabIndex = 0;
            this.tabQuanLyHang.Text = "Quản lý hàng";
            this.tabQuanLyHang.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstvHang);
            this.groupBox3.Location = new System.Drawing.Point(5, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(719, 400);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách hàng";
            // 
            // lstvHang
            // 
            this.lstvHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstvHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvHang.FullRowSelect = true;
            this.lstvHang.GridLines = true;
            this.lstvHang.HideSelection = false;
            this.lstvHang.Location = new System.Drawing.Point(3, 16);
            this.lstvHang.MultiSelect = false;
            this.lstvHang.Name = "lstvHang";
            this.lstvHang.Size = new System.Drawing.Size(713, 381);
            this.lstvHang.TabIndex = 9;
            this.lstvHang.UseCompatibleStateImageBehavior = false;
            this.lstvHang.View = System.Windows.Forms.View.Details;
            this.lstvHang.SelectedIndexChanged += new System.EventHandler(this.lstvHang_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã hàng";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên hàng";
            this.columnHeader2.Width = 131;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sản xuất tại";
            this.columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Loại hàng";
            this.columnHeader4.Width = 128;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày sản xuất";
            this.columnHeader5.Width = 95;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Hạn dùng (Ngày)";
            this.columnHeader6.Width = 95;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ngày hết hạn";
            this.columnHeader7.Width = 96;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.pnlThongTinHang);
            this.groupBox2.Location = new System.Drawing.Point(8, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 187);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnUndo);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Location = new System.Drawing.Point(0, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(715, 57);
            this.panel2.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(580, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 23);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(444, 17);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(130, 23);
            this.btnUndo.TabIndex = 22;
            this.btnUndo.Text = "Hủy thay đổi";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(308, 17);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(130, 23);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(19, 17);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(130, 23);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pnlThongTinHang
            // 
            this.pnlThongTinHang.Controls.Add(this.dtpNgayHetHan);
            this.pnlThongTinHang.Controls.Add(this.label8);
            this.pnlThongTinHang.Controls.Add(this.cbbLoaiHang);
            this.pnlThongTinHang.Controls.Add(this.dtpNgaySanXuat);
            this.pnlThongTinHang.Controls.Add(this.txtNoiSanXuat);
            this.pnlThongTinHang.Controls.Add(this.numHanDungTheoNgay);
            this.pnlThongTinHang.Controls.Add(this.txtTenHang);
            this.pnlThongTinHang.Controls.Add(this.txtMaHang);
            this.pnlThongTinHang.Controls.Add(this.label6);
            this.pnlThongTinHang.Controls.Add(this.label5);
            this.pnlThongTinHang.Controls.Add(this.label4);
            this.pnlThongTinHang.Controls.Add(this.label3);
            this.pnlThongTinHang.Controls.Add(this.label2);
            this.pnlThongTinHang.Controls.Add(this.label1);
            this.pnlThongTinHang.Enabled = false;
            this.pnlThongTinHang.Location = new System.Drawing.Point(3, 16);
            this.pnlThongTinHang.Name = "pnlThongTinHang";
            this.pnlThongTinHang.Size = new System.Drawing.Size(712, 107);
            this.pnlThongTinHang.TabIndex = 4;
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHetHan.Enabled = false;
            this.dtpNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayHetHan.Location = new System.Drawing.Point(503, 55);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Size = new System.Drawing.Size(204, 20);
            this.dtpNgayHetHan.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ngày hết hạn";
            // 
            // cbbLoaiHang
            // 
            this.cbbLoaiHang.FormattingEnabled = true;
            this.cbbLoaiHang.Location = new System.Drawing.Point(132, 81);
            this.cbbLoaiHang.Name = "cbbLoaiHang";
            this.cbbLoaiHang.Size = new System.Drawing.Size(204, 21);
            this.cbbLoaiHang.TabIndex = 13;
            // 
            // dtpNgaySanXuat
            // 
            this.dtpNgaySanXuat.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySanXuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySanXuat.Location = new System.Drawing.Point(503, 4);
            this.dtpNgaySanXuat.Name = "dtpNgaySanXuat";
            this.dtpNgaySanXuat.Size = new System.Drawing.Size(204, 20);
            this.dtpNgaySanXuat.TabIndex = 14;
            this.dtpNgaySanXuat.ValueChanged += new System.EventHandler(this.dtpNgaySanXuat_ValueChanged);
            // 
            // txtNoiSanXuat
            // 
            this.txtNoiSanXuat.Location = new System.Drawing.Point(132, 55);
            this.txtNoiSanXuat.Name = "txtNoiSanXuat";
            this.txtNoiSanXuat.Size = new System.Drawing.Size(204, 20);
            this.txtNoiSanXuat.TabIndex = 12;
            // 
            // numHanDungTheoNgay
            // 
            this.numHanDungTheoNgay.Location = new System.Drawing.Point(503, 29);
            this.numHanDungTheoNgay.Maximum = new decimal(new int[] {
            268435456,
            1042612833,
            542101086,
            0});
            this.numHanDungTheoNgay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHanDungTheoNgay.Name = "numHanDungTheoNgay";
            this.numHanDungTheoNgay.Size = new System.Drawing.Size(204, 20);
            this.numHanDungTheoNgay.TabIndex = 15;
            this.numHanDungTheoNgay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHanDungTheoNgay.ValueChanged += new System.EventHandler(this.numHanDungTheoNgay_ValueChanged);
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(132, 29);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(204, 20);
            this.txtTenHang.TabIndex = 11;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(132, 2);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(204, 20);
            this.txtMaHang.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Loại hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày sản xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sản xuất tại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hạn dùng (Ngày)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 55);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm theo tên hàng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(713, 36);
            this.panel3.TabIndex = 12;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(580, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(130, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(444, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(14, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(424, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 0;
            // 
            // tabQuanLyLoaiHang
            // 
            this.tabQuanLyLoaiHang.Controls.Add(this.groupBox6);
            this.tabQuanLyLoaiHang.Controls.Add(this.groupBox5);
            this.tabQuanLyLoaiHang.Controls.Add(this.groupBox4);
            this.tabQuanLyLoaiHang.Location = new System.Drawing.Point(4, 22);
            this.tabQuanLyLoaiHang.Name = "tabQuanLyLoaiHang";
            this.tabQuanLyLoaiHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuanLyLoaiHang.Size = new System.Drawing.Size(732, 666);
            this.tabQuanLyLoaiHang.TabIndex = 1;
            this.tabQuanLyLoaiHang.Text = "Quản lý loại hàng";
            this.tabQuanLyLoaiHang.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lstvLoaiHang);
            this.groupBox6.Location = new System.Drawing.Point(7, 161);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(719, 499);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Danh sách loại hàng";
            // 
            // lstvLoaiHang
            // 
            this.lstvLoaiHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9});
            this.lstvLoaiHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvLoaiHang.FullRowSelect = true;
            this.lstvLoaiHang.GridLines = true;
            this.lstvLoaiHang.HideSelection = false;
            this.lstvLoaiHang.Location = new System.Drawing.Point(3, 16);
            this.lstvLoaiHang.MultiSelect = false;
            this.lstvLoaiHang.Name = "lstvLoaiHang";
            this.lstvLoaiHang.Size = new System.Drawing.Size(713, 480);
            this.lstvLoaiHang.TabIndex = 9;
            this.lstvLoaiHang.UseCompatibleStateImageBehavior = false;
            this.lstvLoaiHang.View = System.Windows.Forms.View.Details;
            this.lstvLoaiHang.SelectedIndexChanged += new System.EventHandler(this.lstvLoaiHang_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mã loại hàng";
            this.columnHeader8.Width = 133;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tên loại hàng";
            this.columnHeader9.Width = 574;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.panel4);
            this.groupBox5.Controls.Add(this.pnlThongTinLoaiHang);
            this.groupBox5.Location = new System.Drawing.Point(7, 67);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(718, 88);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin loại hàng";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSaveLoaiHang);
            this.panel4.Controls.Add(this.btnUndoLoaiHang);
            this.panel4.Controls.Add(this.btnXoaLoaiHang);
            this.panel4.Controls.Add(this.btnThemLoaiHang);
            this.panel4.Location = new System.Drawing.Point(3, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(712, 38);
            this.panel4.TabIndex = 5;
            // 
            // btnSaveLoaiHang
            // 
            this.btnSaveLoaiHang.Location = new System.Drawing.Point(577, 8);
            this.btnSaveLoaiHang.Name = "btnSaveLoaiHang";
            this.btnSaveLoaiHang.Size = new System.Drawing.Size(130, 23);
            this.btnSaveLoaiHang.TabIndex = 23;
            this.btnSaveLoaiHang.Text = "Lưu";
            this.btnSaveLoaiHang.UseVisualStyleBackColor = true;
            this.btnSaveLoaiHang.Visible = false;
            this.btnSaveLoaiHang.Click += new System.EventHandler(this.btnSaveLoaiHang_Click);
            // 
            // btnUndoLoaiHang
            // 
            this.btnUndoLoaiHang.Location = new System.Drawing.Point(442, 8);
            this.btnUndoLoaiHang.Name = "btnUndoLoaiHang";
            this.btnUndoLoaiHang.Size = new System.Drawing.Size(130, 23);
            this.btnUndoLoaiHang.TabIndex = 22;
            this.btnUndoLoaiHang.Text = "Hủy thay đổi";
            this.btnUndoLoaiHang.UseVisualStyleBackColor = true;
            this.btnUndoLoaiHang.Click += new System.EventHandler(this.btnUndoLoaiHang_Click);
            // 
            // btnXoaLoaiHang
            // 
            this.btnXoaLoaiHang.Location = new System.Drawing.Point(306, 8);
            this.btnXoaLoaiHang.Name = "btnXoaLoaiHang";
            this.btnXoaLoaiHang.Size = new System.Drawing.Size(130, 23);
            this.btnXoaLoaiHang.TabIndex = 21;
            this.btnXoaLoaiHang.Text = "Xóa";
            this.btnXoaLoaiHang.UseVisualStyleBackColor = true;
            this.btnXoaLoaiHang.Click += new System.EventHandler(this.btnXoaLoaiHang_Click);
            // 
            // btnThemLoaiHang
            // 
            this.btnThemLoaiHang.Location = new System.Drawing.Point(14, 8);
            this.btnThemLoaiHang.Name = "btnThemLoaiHang";
            this.btnThemLoaiHang.Size = new System.Drawing.Size(130, 23);
            this.btnThemLoaiHang.TabIndex = 20;
            this.btnThemLoaiHang.Text = "Thêm";
            this.btnThemLoaiHang.UseVisualStyleBackColor = true;
            this.btnThemLoaiHang.Click += new System.EventHandler(this.btnThemLoaiHang_Click);
            // 
            // pnlThongTinLoaiHang
            // 
            this.pnlThongTinLoaiHang.Controls.Add(this.txtTenLoaiHang);
            this.pnlThongTinLoaiHang.Controls.Add(this.txtMaLoaiHang);
            this.pnlThongTinLoaiHang.Controls.Add(this.label15);
            this.pnlThongTinLoaiHang.Controls.Add(this.label16);
            this.pnlThongTinLoaiHang.Enabled = false;
            this.pnlThongTinLoaiHang.Location = new System.Drawing.Point(3, 16);
            this.pnlThongTinLoaiHang.Name = "pnlThongTinLoaiHang";
            this.pnlThongTinLoaiHang.Size = new System.Drawing.Size(712, 30);
            this.pnlThongTinLoaiHang.TabIndex = 4;
            // 
            // txtTenLoaiHang
            // 
            this.txtTenLoaiHang.Location = new System.Drawing.Point(503, 3);
            this.txtTenLoaiHang.Name = "txtTenLoaiHang";
            this.txtTenLoaiHang.Size = new System.Drawing.Size(204, 20);
            this.txtTenLoaiHang.TabIndex = 11;
            // 
            // txtMaLoaiHang
            // 
            this.txtMaLoaiHang.Location = new System.Drawing.Point(132, 2);
            this.txtMaLoaiHang.Name = "txtMaLoaiHang";
            this.txtMaLoaiHang.Size = new System.Drawing.Size(204, 20);
            this.txtMaLoaiHang.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(384, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Tên loại hàng";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Mã loại hàng";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(719, 55);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm theo tên loại hàng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefreshLoaihang);
            this.panel1.Controls.Add(this.btnSearchLoaiHang);
            this.panel1.Controls.Add(this.txtSearchLoaiHang);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 36);
            this.panel1.TabIndex = 12;
            // 
            // btnRefreshLoaihang
            // 
            this.btnRefreshLoaihang.Location = new System.Drawing.Point(579, 6);
            this.btnRefreshLoaihang.Name = "btnRefreshLoaihang";
            this.btnRefreshLoaihang.Size = new System.Drawing.Size(130, 23);
            this.btnRefreshLoaihang.TabIndex = 3;
            this.btnRefreshLoaihang.Text = "Làm mới";
            this.btnRefreshLoaihang.UseVisualStyleBackColor = true;
            this.btnRefreshLoaihang.Click += new System.EventHandler(this.btnRefreshLoaihang_Click);
            // 
            // btnSearchLoaiHang
            // 
            this.btnSearchLoaiHang.Location = new System.Drawing.Point(443, 6);
            this.btnSearchLoaiHang.Name = "btnSearchLoaiHang";
            this.btnSearchLoaiHang.Size = new System.Drawing.Size(130, 23);
            this.btnSearchLoaiHang.TabIndex = 2;
            this.btnSearchLoaiHang.Text = "Tìm kiếm";
            this.btnSearchLoaiHang.UseVisualStyleBackColor = true;
            this.btnSearchLoaiHang.Click += new System.EventHandler(this.btnSearchLoaiHang_Click);
            // 
            // txtSearchLoaiHang
            // 
            this.txtSearchLoaiHang.Location = new System.Drawing.Point(15, 7);
            this.txtSearchLoaiHang.Name = "txtSearchLoaiHang";
            this.txtSearchLoaiHang.Size = new System.Drawing.Size(422, 20);
            this.txtSearchLoaiHang.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(743, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem1,
            this.thoátToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem1
            // 
            this.thôngTinToolStripMenuItem1.Name = "thôngTinToolStripMenuItem1";
            this.thôngTinToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.thôngTinToolStripMenuItem1.Text = "Thông tin";
            this.thôngTinToolStripMenuItem1.Click += new System.EventHandler(this.thôngTinToolStripMenuItem1_Click);
            // 
            // FormQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 720);
            this.Controls.Add(this.tabApp);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cửa hàng";
            this.tabApp.ResumeLayout(false);
            this.tabQuanLyHang.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlThongTinHang.ResumeLayout(false);
            this.pnlThongTinHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHanDungTheoNgay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabQuanLyLoaiHang.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnlThongTinLoaiHang.ResumeLayout(false);
            this.pnlThongTinLoaiHang.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabApp;
        private System.Windows.Forms.TabPage tabQuanLyHang;
        private System.Windows.Forms.Panel pnlThongTinHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabQuanLyLoaiHang;
        private System.Windows.Forms.ComboBox cbbLoaiHang;
        private System.Windows.Forms.DateTimePicker dtpNgaySanXuat;
        private System.Windows.Forms.TextBox txtNoiSanXuat;
        private System.Windows.Forms.NumericUpDown numHanDungTheoNgay;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lstvHang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.DateTimePicker dtpNgayHetHan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSaveLoaiHang;
        private System.Windows.Forms.Button btnUndoLoaiHang;
        private System.Windows.Forms.Button btnXoaLoaiHang;
        private System.Windows.Forms.Button btnThemLoaiHang;
        private System.Windows.Forms.Panel pnlThongTinLoaiHang;
        private System.Windows.Forms.TextBox txtTenLoaiHang;
        private System.Windows.Forms.TextBox txtMaLoaiHang;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearchLoaiHang;
        private System.Windows.Forms.TextBox txtSearchLoaiHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListView lstvLoaiHang;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btnRefreshLoaihang;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem1;
    }
}


