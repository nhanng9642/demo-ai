
namespace QuanLyCuaHang_20880110
{
    partial class frmQLyCuaHang
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
            this.lblMaHang = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.lblTenHang = new System.Windows.Forms.Label();
            this.lblHanDung = new System.Windows.Forms.Label();
            this.txtLoaiHang = new System.Windows.Forms.TextBox();
            this.lblLoaiHang = new System.Windows.Forms.Label();
            this.txtNamSanXuat = new System.Windows.Forms.TextBox();
            this.lblNamSanXuat = new System.Windows.Forms.Label();
            this.txtCtySanXuat = new System.Windows.Forms.TextBox();
            this.lblCtySanXuat = new System.Windows.Forms.Label();
            this.process1 = new System.Diagnostics.Process();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.listKetQua = new System.Windows.Forms.ListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHanDung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCtySanXuat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNamSanXuat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLoaiHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datetimeHanDung = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaHang
            // 
            this.lblMaHang.AutoSize = true;
            this.lblMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHang.Location = new System.Drawing.Point(26, 27);
            this.lblMaHang.Name = "lblMaHang";
            this.lblMaHang.Size = new System.Drawing.Size(69, 15);
            this.lblMaHang.TabIndex = 0;
            this.lblMaHang.Text = "Mã Hàng:";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHang.Location = new System.Drawing.Point(124, 24);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(218, 21);
            this.txtMaHang.TabIndex = 1;
            this.txtMaHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaHang_KeyPress);
            // 
            // txtTenHang
            // 
            this.txtTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHang.Location = new System.Drawing.Point(124, 62);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(218, 21);
            this.txtTenHang.TabIndex = 3;
            this.txtTenHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenHang_KeyPress);
            // 
            // lblTenHang
            // 
            this.lblTenHang.AutoSize = true;
            this.lblTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHang.Location = new System.Drawing.Point(26, 65);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(73, 15);
            this.lblTenHang.TabIndex = 2;
            this.lblTenHang.Text = "Tên Hàng:";
            // 
            // lblHanDung
            // 
            this.lblHanDung.AutoSize = true;
            this.lblHanDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHanDung.Location = new System.Drawing.Point(26, 104);
            this.lblHanDung.Name = "lblHanDung";
            this.lblHanDung.Size = new System.Drawing.Size(75, 15);
            this.lblHanDung.TabIndex = 4;
            this.lblHanDung.Text = "Hạn Dùng:";
            // 
            // txtLoaiHang
            // 
            this.txtLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiHang.Location = new System.Drawing.Point(545, 98);
            this.txtLoaiHang.Name = "txtLoaiHang";
            this.txtLoaiHang.Size = new System.Drawing.Size(218, 21);
            this.txtLoaiHang.TabIndex = 11;
            this.txtLoaiHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoaiHang_KeyPress);
            // 
            // lblLoaiHang
            // 
            this.lblLoaiHang.AutoSize = true;
            this.lblLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiHang.Location = new System.Drawing.Point(394, 101);
            this.lblLoaiHang.Name = "lblLoaiHang";
            this.lblLoaiHang.Size = new System.Drawing.Size(77, 15);
            this.lblLoaiHang.TabIndex = 10;
            this.lblLoaiHang.Text = "Loại Hàng:";
            // 
            // txtNamSanXuat
            // 
            this.txtNamSanXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamSanXuat.Location = new System.Drawing.Point(545, 59);
            this.txtNamSanXuat.Name = "txtNamSanXuat";
            this.txtNamSanXuat.Size = new System.Drawing.Size(218, 21);
            this.txtNamSanXuat.TabIndex = 9;
            this.txtNamSanXuat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamSanXuat_KeyPress);
            // 
            // lblNamSanXuat
            // 
            this.lblNamSanXuat.AutoSize = true;
            this.lblNamSanXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamSanXuat.Location = new System.Drawing.Point(394, 62);
            this.lblNamSanXuat.Name = "lblNamSanXuat";
            this.lblNamSanXuat.Size = new System.Drawing.Size(103, 15);
            this.lblNamSanXuat.TabIndex = 8;
            this.lblNamSanXuat.Text = "Năm Sản Xuất:";
            // 
            // txtCtySanXuat
            // 
            this.txtCtySanXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCtySanXuat.Location = new System.Drawing.Point(545, 21);
            this.txtCtySanXuat.Name = "txtCtySanXuat";
            this.txtCtySanXuat.Size = new System.Drawing.Size(218, 21);
            this.txtCtySanXuat.TabIndex = 7;
            this.txtCtySanXuat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCtySanXuat_KeyPress);
            // 
            // lblCtySanXuat
            // 
            this.lblCtySanXuat.AutoSize = true;
            this.lblCtySanXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCtySanXuat.Location = new System.Drawing.Point(394, 24);
            this.lblCtySanXuat.Name = "lblCtySanXuat";
            this.lblCtySanXuat.Size = new System.Drawing.Size(124, 15);
            this.lblCtySanXuat.TabIndex = 6;
            this.lblCtySanXuat.Text = "Công Ty Sản Xuất:";
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(63, 146);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 30);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(207, 146);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 30);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(353, 146);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 30);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(495, 146);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(94, 30);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // listKetQua
            // 
            this.listKetQua.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colMaHang,
            this.colTenHang,
            this.colHanDung,
            this.colCtySanXuat,
            this.colNamSanXuat,
            this.colLoaiHang});
            this.listKetQua.FullRowSelect = true;
            this.listKetQua.HideSelection = false;
            this.listKetQua.Location = new System.Drawing.Point(29, 198);
            this.listKetQua.Name = "listKetQua";
            this.listKetQua.Size = new System.Drawing.Size(734, 231);
            this.listKetQua.TabIndex = 17;
            this.listKetQua.UseCompatibleStateImageBehavior = false;
            this.listKetQua.View = System.Windows.Forms.View.Details;
            this.listKetQua.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listKetQua_MouseClick);
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            this.colSTT.Width = 40;
            // 
            // colMaHang
            // 
            this.colMaHang.Text = "Mã Hàng";
            this.colMaHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMaHang.Width = 80;
            // 
            // colTenHang
            // 
            this.colTenHang.Text = "Tên Hàng";
            this.colTenHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTenHang.Width = 120;
            // 
            // colHanDung
            // 
            this.colHanDung.Text = "Hạn Dùng";
            this.colHanDung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHanDung.Width = 111;
            // 
            // colCtySanXuat
            // 
            this.colCtySanXuat.Text = "Công Ty Sản Xuất";
            this.colCtySanXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCtySanXuat.Width = 129;
            // 
            // colNamSanXuat
            // 
            this.colNamSanXuat.Text = "Năm Sản Xuất";
            this.colNamSanXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNamSanXuat.Width = 130;
            // 
            // colLoaiHang
            // 
            this.colLoaiHang.Text = "Loại Hàng";
            this.colLoaiHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colLoaiHang.Width = 114;
            // 
            // datetimeHanDung
            // 
            this.datetimeHanDung.CustomFormat = "dd/MM/yyyy";
            this.datetimeHanDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeHanDung.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeHanDung.Location = new System.Drawing.Point(124, 101);
            this.datetimeHanDung.Name = "datetimeHanDung";
            this.datetimeHanDung.Size = new System.Drawing.Size(218, 21);
            this.datetimeHanDung.TabIndex = 5;
            this.datetimeHanDung.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.datetimeHanDung.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.datetimeHanDung_KeyPress);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(637, 146);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 30);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmQLyCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.datetimeHanDung);
            this.Controls.Add(this.listKetQua);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtLoaiHang);
            this.Controls.Add(this.lblLoaiHang);
            this.Controls.Add(this.txtNamSanXuat);
            this.Controls.Add(this.lblNamSanXuat);
            this.Controls.Add(this.txtCtySanXuat);
            this.Controls.Add(this.lblCtySanXuat);
            this.Controls.Add(this.lblHanDung);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.lblTenHang);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.lblMaHang);
            this.Name = "frmQLyCuaHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmQLyCuaHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaHang;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.Label lblHanDung;
        private System.Windows.Forms.TextBox txtLoaiHang;
        private System.Windows.Forms.Label lblLoaiHang;
        private System.Windows.Forms.TextBox txtNamSanXuat;
        private System.Windows.Forms.Label lblNamSanXuat;
        private System.Windows.Forms.TextBox txtCtySanXuat;
        private System.Windows.Forms.Label lblCtySanXuat;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ListView listKetQua;
        private System.Windows.Forms.ColumnHeader colMaHang;
        private System.Windows.Forms.ColumnHeader colTenHang;
        private System.Windows.Forms.ColumnHeader colHanDung;
        private System.Windows.Forms.ColumnHeader colCtySanXuat;
        private System.Windows.Forms.ColumnHeader colNamSanXuat;
        private System.Windows.Forms.ColumnHeader colLoaiHang;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.DateTimePicker datetimeHanDung;
        private System.Windows.Forms.Button btnClear;
    }
}

