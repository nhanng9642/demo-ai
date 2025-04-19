namespace DoAn_QL_CuaHang
{
    partial class Form_MatHang
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
            this.lvmathang = new System.Windows.Forms.ListView();
            this.lvmahang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvtenhang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvcolumhansudung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvcolumnctysx = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvcolumnnamsx = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvcolumnloaihang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.cbbloaihang = new System.Windows.Forms.ComboBox();
            this.txtnamsanxuat = new System.Windows.Forms.TextBox();
            this.txtctysanxuat = new System.Windows.Forms.TextBox();
            this.txthansudung = new System.Windows.Forms.TextBox();
            this.txttenhang = new System.Windows.Forms.TextBox();
            this.txtmahang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvloaihang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnsualoaihang = new System.Windows.Forms.Button();
            this.btnxoaloaihang = new System.Windows.Forms.Button();
            this.btnthemloaihang = new System.Windows.Forms.Button();
            this.txttenloaihang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmaloaihang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btntimkiemloaihang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvmathang
            // 
            this.lvmathang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvmahang,
            this.lvtenhang,
            this.lsvcolumhansudung,
            this.lsvcolumnctysx,
            this.lsvcolumnnamsx,
            this.lsvcolumnloaihang});
            this.lvmathang.HideSelection = false;
            this.lvmathang.Location = new System.Drawing.Point(106, 335);
            this.lvmathang.Name = "lvmathang";
            this.lvmathang.Size = new System.Drawing.Size(427, 199);
            this.lvmathang.TabIndex = 24;
            this.lvmathang.UseCompatibleStateImageBehavior = false;
            this.lvmathang.View = System.Windows.Forms.View.Details;
            this.lvmathang.SelectedIndexChanged += new System.EventHandler(this.lvmathang_SelectedIndexChanged);
            // 
            // lvmahang
            // 
            this.lvmahang.Text = "Mã Hàng";
            // 
            // lvtenhang
            // 
            this.lvtenhang.Text = "Tên Hàng";
            // 
            // lsvcolumhansudung
            // 
            this.lsvcolumhansudung.Text = "Hạn Sử dụng";
            this.lsvcolumhansudung.Width = 77;
            // 
            // lsvcolumnctysx
            // 
            this.lsvcolumnctysx.Text = "Công Ty SX";
            this.lsvcolumnctysx.Width = 73;
            // 
            // lsvcolumnnamsx
            // 
            this.lsvcolumnnamsx.Text = "Năm Sản Xuất";
            this.lsvcolumnnamsx.Width = 81;
            // 
            // lsvcolumnloaihang
            // 
            this.lsvcolumnloaihang.Text = "Loại Hàng";
            this.lsvcolumnloaihang.Width = 62;
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(320, 306);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(101, 23);
            this.btnsua.TabIndex = 23;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(213, 306);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(101, 23);
            this.btnxoa.TabIndex = 22;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Location = new System.Drawing.Point(432, 306);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(101, 23);
            this.btntimkiem.TabIndex = 21;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(106, 306);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(101, 23);
            this.btnthem.TabIndex = 19;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // cbbloaihang
            // 
            this.cbbloaihang.FormattingEnabled = true;
            this.cbbloaihang.Location = new System.Drawing.Point(106, 262);
            this.cbbloaihang.Name = "cbbloaihang";
            this.cbbloaihang.Size = new System.Drawing.Size(427, 21);
            this.cbbloaihang.TabIndex = 18;
            this.cbbloaihang.SelectedIndexChanged += new System.EventHandler(this.cbbloaihang_SelectedIndexChanged);
            // 
            // txtnamsanxuat
            // 
            this.txtnamsanxuat.Location = new System.Drawing.Point(106, 223);
            this.txtnamsanxuat.Name = "txtnamsanxuat";
            this.txtnamsanxuat.Size = new System.Drawing.Size(427, 20);
            this.txtnamsanxuat.TabIndex = 16;
            // 
            // txtctysanxuat
            // 
            this.txtctysanxuat.Location = new System.Drawing.Point(106, 184);
            this.txtctysanxuat.Name = "txtctysanxuat";
            this.txtctysanxuat.Size = new System.Drawing.Size(427, 20);
            this.txtctysanxuat.TabIndex = 15;
            // 
            // txthansudung
            // 
            this.txthansudung.Location = new System.Drawing.Point(106, 145);
            this.txthansudung.Name = "txthansudung";
            this.txthansudung.Size = new System.Drawing.Size(427, 20);
            this.txthansudung.TabIndex = 17;
            // 
            // txttenhang
            // 
            this.txttenhang.Location = new System.Drawing.Point(106, 108);
            this.txttenhang.Name = "txttenhang";
            this.txttenhang.Size = new System.Drawing.Size(427, 20);
            this.txttenhang.TabIndex = 14;
            // 
            // txtmahang
            // 
            this.txtmahang.Location = new System.Drawing.Point(106, 66);
            this.txtmahang.Name = "txtmahang";
            this.txtmahang.Size = new System.Drawing.Size(427, 20);
            this.txtmahang.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Loại Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Năm Sản Xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CTY Sản Xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hạn Sử Dụng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên Hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(239, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "MẶT HÀNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã Hàng";
            // 
            // lsvloaihang
            // 
            this.lsvloaihang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsvloaihang.HideSelection = false;
            this.lsvloaihang.Location = new System.Drawing.Point(725, 184);
            this.lsvloaihang.Name = "lsvloaihang";
            this.lsvloaihang.Size = new System.Drawing.Size(225, 97);
            this.lsvloaihang.TabIndex = 33;
            this.lsvloaihang.UseCompatibleStateImageBehavior = false;
            this.lsvloaihang.View = System.Windows.Forms.View.Details;
            this.lsvloaihang.SelectedIndexChanged += new System.EventHandler(this.lsvloaihang_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Loại Hàng";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Loại Hàng";
            this.columnHeader2.Width = 120;
            // 
            // btnsualoaihang
            // 
            this.btnsualoaihang.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsualoaihang.Location = new System.Drawing.Point(828, 146);
            this.btnsualoaihang.Name = "btnsualoaihang";
            this.btnsualoaihang.Size = new System.Drawing.Size(41, 23);
            this.btnsualoaihang.TabIndex = 30;
            this.btnsualoaihang.Text = "Sửa";
            this.btnsualoaihang.UseVisualStyleBackColor = true;
            this.btnsualoaihang.Click += new System.EventHandler(this.btnsualoaihang_Click);
            // 
            // btnxoaloaihang
            // 
            this.btnxoaloaihang.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoaloaihang.Location = new System.Drawing.Point(783, 146);
            this.btnxoaloaihang.Name = "btnxoaloaihang";
            this.btnxoaloaihang.Size = new System.Drawing.Size(40, 23);
            this.btnxoaloaihang.TabIndex = 31;
            this.btnxoaloaihang.Text = "Xóa";
            this.btnxoaloaihang.UseVisualStyleBackColor = true;
            this.btnxoaloaihang.Click += new System.EventHandler(this.btnxoaloaihang_Click);
            // 
            // btnthemloaihang
            // 
            this.btnthemloaihang.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemloaihang.Location = new System.Drawing.Point(724, 146);
            this.btnthemloaihang.Name = "btnthemloaihang";
            this.btnthemloaihang.Size = new System.Drawing.Size(54, 23);
            this.btnthemloaihang.TabIndex = 32;
            this.btnthemloaihang.Text = "Thêm";
            this.btnthemloaihang.UseVisualStyleBackColor = true;
            this.btnthemloaihang.Click += new System.EventHandler(this.btnthemloaihang_Click);
            // 
            // txttenloaihang
            // 
            this.txttenloaihang.Location = new System.Drawing.Point(723, 106);
            this.txttenloaihang.Name = "txttenloaihang";
            this.txttenloaihang.Size = new System.Drawing.Size(227, 20);
            this.txttenloaihang.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(642, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Tên Loại Hàng";
            // 
            // txtmaloaihang
            // 
            this.txtmaloaihang.Location = new System.Drawing.Point(723, 66);
            this.txtmaloaihang.Name = "txtmaloaihang";
            this.txtmaloaihang.Size = new System.Drawing.Size(227, 20);
            this.txtmaloaihang.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(791, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "LOẠI HÀNG";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(642, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Mã Loại Hàng";
            // 
            // btntimkiemloaihang
            // 
            this.btntimkiemloaihang.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiemloaihang.Location = new System.Drawing.Point(875, 145);
            this.btntimkiemloaihang.Name = "btntimkiemloaihang";
            this.btntimkiemloaihang.Size = new System.Drawing.Size(75, 23);
            this.btntimkiemloaihang.TabIndex = 21;
            this.btntimkiemloaihang.Text = "Tìm Kiếm";
            this.btntimkiemloaihang.UseVisualStyleBackColor = true;
            this.btntimkiemloaihang.Click += new System.EventHandler(this.btntimkiemloaihang_Click);
            // 
            // Form_MatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 714);
            this.Controls.Add(this.lsvloaihang);
            this.Controls.Add(this.btnsualoaihang);
            this.Controls.Add(this.btnxoaloaihang);
            this.Controls.Add(this.btnthemloaihang);
            this.Controls.Add(this.txttenloaihang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtmaloaihang);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lvmathang);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btntimkiemloaihang);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.cbbloaihang);
            this.Controls.Add(this.txtnamsanxuat);
            this.Controls.Add(this.txtctysanxuat);
            this.Controls.Add(this.txthansudung);
            this.Controls.Add(this.txttenhang);
            this.Controls.Add(this.txtmahang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "Form_MatHang";
            this.Text = "Form_MatHang";
            this.Load += new System.EventHandler(this.Form_MatHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvmathang;
        private System.Windows.Forms.ColumnHeader lvmahang;
        private System.Windows.Forms.ColumnHeader lvtenhang;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.ComboBox cbbloaihang;
        private System.Windows.Forms.TextBox txtnamsanxuat;
        private System.Windows.Forms.TextBox txtctysanxuat;
        private System.Windows.Forms.TextBox txthansudung;
        private System.Windows.Forms.TextBox txttenhang;
        private System.Windows.Forms.TextBox txtmahang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader lsvcolumhansudung;
        private System.Windows.Forms.ColumnHeader lsvcolumnctysx;
        private System.Windows.Forms.ColumnHeader lsvcolumnnamsx;
        private System.Windows.Forms.ColumnHeader lsvcolumnloaihang;
        private System.Windows.Forms.ListView lsvloaihang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnsualoaihang;
        private System.Windows.Forms.Button btnxoaloaihang;
        private System.Windows.Forms.Button btnthemloaihang;
        private System.Windows.Forms.TextBox txttenloaihang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmaloaihang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btntimkiemloaihang;
    }
}