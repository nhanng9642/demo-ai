﻿namespace DoAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHangHoaTim = new System.Windows.Forms.TextBox();
            this.btnHangHoaTim = new System.Windows.Forms.Button();
            this.cbbLH = new System.Windows.Forms.ComboBox();
            this.btnLHThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtHSD = new System.Windows.Forms.TextBox();
            this.txtNSX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLHHuy = new System.Windows.Forms.Button();
            this.BtnLHChon = new System.Windows.Forms.Button();
            this.btnLHTim = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtLHTim = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHangHoaTim);
            this.groupBox1.Controls.Add(this.btnHangHoaTim);
            this.groupBox1.Controls.Add(this.cbbLH);
            this.groupBox1.Controls.Add(this.btnLHThem);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txtHSD);
            this.groupBox1.Controls.Add(this.txtNSX);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCty);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenHH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaHH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(39, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1087, 674);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hàng Hóa";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtHangHoaTim
            // 
            this.txtHangHoaTim.Location = new System.Drawing.Point(0, 290);
            this.txtHangHoaTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHangHoaTim.Name = "txtHangHoaTim";
            this.txtHangHoaTim.Size = new System.Drawing.Size(239, 22);
            this.txtHangHoaTim.TabIndex = 42;
            // 
            // btnHangHoaTim
            // 
            this.btnHangHoaTim.Location = new System.Drawing.Point(248, 290);
            this.btnHangHoaTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHangHoaTim.Name = "btnHangHoaTim";
            this.btnHangHoaTim.Size = new System.Drawing.Size(65, 28);
            this.btnHangHoaTim.TabIndex = 41;
            this.btnHangHoaTim.Text = "Tìm";
            this.btnHangHoaTim.UseVisualStyleBackColor = true;
            this.btnHangHoaTim.Click += new System.EventHandler(this.btnHangHoaTim_Click);
            // 
            // cbbLH
            // 
            this.cbbLH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLH.FormattingEnabled = true;
            this.cbbLH.Location = new System.Drawing.Point(153, 170);
            this.cbbLH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbLH.Name = "cbbLH";
            this.cbbLH.Size = new System.Drawing.Size(239, 24);
            this.cbbLH.TabIndex = 40;
            // 
            // btnLHThem
            // 
            this.btnLHThem.Location = new System.Drawing.Point(401, 166);
            this.btnLHThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLHThem.Name = "btnLHThem";
            this.btnLHThem.Size = new System.Drawing.Size(60, 28);
            this.btnLHThem.TabIndex = 39;
            this.btnLHThem.Text = "Them";
            this.btnLHThem.UseVisualStyleBackColor = true;
            this.btnLHThem.Click += new System.EventHandler(this.btnLHThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(925, 278);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(136, 48);
            this.btnThoat.TabIndex = 38;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(925, 242);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 28);
            this.btnHuy.TabIndex = 37;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(817, 242);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 36;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(788, 278);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(129, 48);
            this.btnXoa.TabIndex = 35;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(652, 278);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(128, 48);
            this.btnSua.TabIndex = 34;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(508, 278);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(129, 48);
            this.btnThem.TabIndex = 33;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHH,
            this.TenHH,
            this.Cty,
            this.LH,
            this.NSX,
            this.HSD});
            this.dataGridView1.Location = new System.Drawing.Point(4, 335);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1057, 326);
            this.dataGridView1.TabIndex = 32;
            // 
            // MaHH
            // 
            this.MaHH.DataPropertyName = "MaHH";
            this.MaHH.HeaderText = "Mã HH";
            this.MaHH.MinimumWidth = 6;
            this.MaHH.Name = "MaHH";
            this.MaHH.Width = 125;
            // 
            // TenHH
            // 
            this.TenHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHH.DataPropertyName = "TenHH";
            this.TenHH.HeaderText = "Tên Hàng Hóa";
            this.TenHH.MinimumWidth = 6;
            this.TenHH.Name = "TenHH";
            // 
            // Cty
            // 
            this.Cty.DataPropertyName = "Cty";
            this.Cty.HeaderText = "Công ty";
            this.Cty.MinimumWidth = 6;
            this.Cty.Name = "Cty";
            this.Cty.Width = 125;
            // 
            // LH
            // 
            this.LH.DataPropertyName = "LH";
            this.LH.HeaderText = "Loại Hàng";
            this.LH.MinimumWidth = 6;
            this.LH.Name = "LH";
            this.LH.Width = 125;
            // 
            // NSX
            // 
            this.NSX.DataPropertyName = "NSX";
            this.NSX.HeaderText = "NSX";
            this.NSX.MinimumWidth = 6;
            this.NSX.Name = "NSX";
            this.NSX.Width = 125;
            // 
            // HSD
            // 
            this.HSD.DataPropertyName = "HSD";
            this.HSD.HeaderText = "HSD";
            this.HSD.MinimumWidth = 6;
            this.HSD.Name = "HSD";
            this.HSD.Width = 125;
            // 
            // txtHSD
            // 
            this.txtHSD.Location = new System.Drawing.Point(708, 81);
            this.txtHSD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHSD.Name = "txtHSD";
            this.txtHSD.Size = new System.Drawing.Size(307, 22);
            this.txtHSD.TabIndex = 31;
            // 
            // txtNSX
            // 
            this.txtNSX.Location = new System.Drawing.Point(708, 30);
            this.txtNSX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNSX.Name = "txtNSX";
            this.txtNSX.Size = new System.Drawing.Size(307, 22);
            this.txtNSX.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(597, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "HSD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "NSX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Loại Hàng";
            // 
            // txtCty
            // 
            this.txtCty.Location = new System.Drawing.Point(153, 124);
            this.txtCty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCty.Name = "txtCty";
            this.txtCty.Size = new System.Drawing.Size(307, 22);
            this.txtCty.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Công ty";
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(153, 80);
            this.txtTenHH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(307, 22);
            this.txtTenHH.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên Hàng Hóa";
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(153, 30);
            this.txtMaHH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(307, 22);
            this.txtMaHH.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã Hàng Hóa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLHHuy);
            this.groupBox2.Controls.Add(this.BtnLHChon);
            this.groupBox2.Controls.Add(this.btnLHTim);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.txtLHTim);
            this.groupBox2.Location = new System.Drawing.Point(39, 31);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(385, 478);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại Hàng";
            // 
            // btnLHHuy
            // 
            this.btnLHHuy.Location = new System.Drawing.Point(220, 402);
            this.btnLHHuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLHHuy.Name = "btnLHHuy";
            this.btnLHHuy.Size = new System.Drawing.Size(100, 28);
            this.btnLHHuy.TabIndex = 4;
            this.btnLHHuy.Text = "Quay lại";
            this.btnLHHuy.UseVisualStyleBackColor = true;
            this.btnLHHuy.Click += new System.EventHandler(this.btnLHHuy_Click);
            // 
            // BtnLHChon
            // 
            this.BtnLHChon.Location = new System.Drawing.Point(21, 402);
            this.BtnLHChon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnLHChon.Name = "BtnLHChon";
            this.BtnLHChon.Size = new System.Drawing.Size(100, 28);
            this.BtnLHChon.TabIndex = 3;
            this.BtnLHChon.Text = "Chọn";
            this.BtnLHChon.UseVisualStyleBackColor = true;
            this.BtnLHChon.Click += new System.EventHandler(this.BtnLHChon_Click);
            // 
            // btnLHTim
            // 
            this.btnLHTim.Location = new System.Drawing.Point(163, 46);
            this.btnLHTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLHTim.Name = "btnLHTim";
            this.btnLHTim.Size = new System.Drawing.Size(100, 28);
            this.btnLHTim.TabIndex = 2;
            this.btnLHTim.Text = "Tìm";
            this.btnLHTim.UseVisualStyleBackColor = true;
            this.btnLHTim.Click += new System.EventHandler(this.btnLHTim_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView2.Location = new System.Drawing.Point(21, 143);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(320, 185);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView2_CellBeginEdit);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView2_CellValidating);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Loại Hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Xóa";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Text = "X";
            this.Column2.Width = 30;
            // 
            // txtLHTim
            // 
            this.txtLHTim.Location = new System.Drawing.Point(21, 48);
            this.txtLHTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLHTim.Name = "txtLHTim";
            this.txtLHTim.Size = new System.Drawing.Size(132, 22);
            this.txtLHTim.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 706);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cty;
        private System.Windows.Forms.DataGridViewTextBoxColumn LH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSD;
        private System.Windows.Forms.TextBox txtHSD;
        private System.Windows.Forms.TextBox txtNSX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLHTim;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnLHTim;
        private System.Windows.Forms.Button btnLHThem;
        private System.Windows.Forms.Button btnLHHuy;
        private System.Windows.Forms.Button BtnLHChon;
        private System.Windows.Forms.ComboBox cbbLH;
        private System.Windows.Forms.Button btnHangHoaTim;
        private System.Windows.Forms.TextBox txtHangHoaTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
    }
}