
namespace PhanMemQuanLyCuaHang
{
    partial class PhanLoaiHang
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
            this.DSLoaiHang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.phanmathangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phanloaihangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NhapLoaiHangText = new System.Windows.Forms.TextBox();
            this.NhapLoaiHang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.XoaLoaiHangText = new System.Windows.Forms.TextBox();
            this.XoaLoaiHang = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CapNhatLoaiHang = new System.Windows.Forms.Button();
            this.CapNhatLoaiHangText = new System.Windows.Forms.TextBox();
            this.TKChinhSuaText = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TimKiemLoaiHang = new System.Windows.Forms.Button();
            this.TKLoaiHangText = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // DSLoaiHang
            // 
            this.DSLoaiHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.DSLoaiHang.HideSelection = false;
            this.DSLoaiHang.Location = new System.Drawing.Point(39, 106);
            this.DSLoaiHang.Name = "DSLoaiHang";
            this.DSLoaiHang.Size = new System.Drawing.Size(189, 248);
            this.DSLoaiHang.TabIndex = 0;
            this.DSLoaiHang.UseCompatibleStateImageBehavior = false;
            this.DSLoaiHang.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Loại Hàng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phanmathangToolStripMenuItem,
            this.phanloaihangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // phanmathangToolStripMenuItem
            // 
            this.phanmathangToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.phanmathangToolStripMenuItem.Name = "phanmathangToolStripMenuItem";
            this.phanmathangToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.phanmathangToolStripMenuItem.Text = "PHẦN MẶT HÀNG";
            this.phanmathangToolStripMenuItem.Click += new System.EventHandler(this.phanmathangToolStripMenuItem_Click);
            // 
            // phanloaihangToolStripMenuItem
            // 
            this.phanloaihangToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.phanloaihangToolStripMenuItem.Name = "phanloaihangToolStripMenuItem";
            this.phanloaihangToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.phanloaihangToolStripMenuItem.Text = "PHẦN LOẠI HÀNG";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.NhapLoaiHangText);
            this.groupBox2.Controls.Add(this.NhapLoaiHang);
            this.groupBox2.Location = new System.Drawing.Point(249, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 80);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập Loại Hàng";
            // 
            // NhapLoaiHangText
            // 
            this.NhapLoaiHangText.Location = new System.Drawing.Point(6, 37);
            this.NhapLoaiHangText.Name = "NhapLoaiHangText";
            this.NhapLoaiHangText.Size = new System.Drawing.Size(121, 22);
            this.NhapLoaiHangText.TabIndex = 13;
            // 
            // NhapLoaiHang
            // 
            this.NhapLoaiHang.Location = new System.Drawing.Point(144, 35);
            this.NhapLoaiHang.Name = "NhapLoaiHang";
            this.NhapLoaiHang.Size = new System.Drawing.Size(90, 27);
            this.NhapLoaiHang.TabIndex = 0;
            this.NhapLoaiHang.Text = "Nhập";
            this.NhapLoaiHang.UseVisualStyleBackColor = true;
            this.NhapLoaiHang.Click += new System.EventHandler(this.NhapLoaiHang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ CỬA HÀNG";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.XoaLoaiHangText);
            this.groupBox3.Controls.Add(this.XoaLoaiHang);
            this.groupBox3.Location = new System.Drawing.Point(249, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 78);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xóa Loại Hàng";
            // 
            // XoaLoaiHangText
            // 
            this.XoaLoaiHangText.Location = new System.Drawing.Point(6, 33);
            this.XoaLoaiHangText.Name = "XoaLoaiHangText";
            this.XoaLoaiHangText.Size = new System.Drawing.Size(121, 22);
            this.XoaLoaiHangText.TabIndex = 12;
            // 
            // XoaLoaiHang
            // 
            this.XoaLoaiHang.Location = new System.Drawing.Point(144, 31);
            this.XoaLoaiHang.Name = "XoaLoaiHang";
            this.XoaLoaiHang.Size = new System.Drawing.Size(90, 27);
            this.XoaLoaiHang.TabIndex = 1;
            this.XoaLoaiHang.Text = "Xóa";
            this.XoaLoaiHang.UseVisualStyleBackColor = true;
            this.XoaLoaiHang.Click += new System.EventHandler(this.XoaLoaiHang_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.CapNhatLoaiHang);
            this.groupBox4.Controls.Add(this.CapNhatLoaiHangText);
            this.groupBox4.Controls.Add(this.TKChinhSuaText);
            this.groupBox4.Location = new System.Drawing.Point(511, 141);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(185, 186);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chỉnh Sửa Loại Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nhập Nội Dung Chỉnh Sửa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nhập Loại Hàng";
            // 
            // CapNhatLoaiHang
            // 
            this.CapNhatLoaiHang.Location = new System.Drawing.Point(6, 144);
            this.CapNhatLoaiHang.Name = "CapNhatLoaiHang";
            this.CapNhatLoaiHang.Size = new System.Drawing.Size(90, 27);
            this.CapNhatLoaiHang.TabIndex = 14;
            this.CapNhatLoaiHang.Text = "Cập Nhật";
            this.CapNhatLoaiHang.UseVisualStyleBackColor = true;
            this.CapNhatLoaiHang.Click += new System.EventHandler(this.CapNhatLoaiHang_Click);
            // 
            // CapNhatLoaiHangText
            // 
            this.CapNhatLoaiHangText.Location = new System.Drawing.Point(6, 105);
            this.CapNhatLoaiHangText.Name = "CapNhatLoaiHangText";
            this.CapNhatLoaiHangText.Size = new System.Drawing.Size(121, 22);
            this.CapNhatLoaiHangText.TabIndex = 14;
            // 
            // TKChinhSuaText
            // 
            this.TKChinhSuaText.Location = new System.Drawing.Point(6, 45);
            this.TKChinhSuaText.Name = "TKChinhSuaText";
            this.TKChinhSuaText.Size = new System.Drawing.Size(121, 22);
            this.TKChinhSuaText.TabIndex = 14;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox5.Controls.Add(this.TimKiemLoaiHang);
            this.groupBox5.Controls.Add(this.TKLoaiHangText);
            this.groupBox5.Location = new System.Drawing.Point(249, 276);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(256, 78);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tìm Kiếm Loại Hàng";
            // 
            // TimKiemLoaiHang
            // 
            this.TimKiemLoaiHang.Location = new System.Drawing.Point(143, 31);
            this.TimKiemLoaiHang.Name = "TimKiemLoaiHang";
            this.TimKiemLoaiHang.Size = new System.Drawing.Size(90, 26);
            this.TimKiemLoaiHang.TabIndex = 17;
            this.TimKiemLoaiHang.Text = "Tìm Kiếm";
            this.TimKiemLoaiHang.UseVisualStyleBackColor = true;
            this.TimKiemLoaiHang.Click += new System.EventHandler(this.TimKiemLoaiHang_Click);
            // 
            // TKLoaiHangText
            // 
            this.TKLoaiHangText.Location = new System.Drawing.Point(6, 33);
            this.TKLoaiHangText.Name = "TKLoaiHangText";
            this.TKLoaiHangText.Size = new System.Drawing.Size(121, 22);
            this.TKLoaiHangText.TabIndex = 14;
            // 
            // PhanLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 388);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.DSLoaiHang);
            this.Name = "PhanLoaiHang";
            this.Text = "Phần Mềm Quản Lý Cửa Hàng";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView DSLoaiHang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem phanmathangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phanloaihangToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button NhapLoaiHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NhapLoaiHangText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox XoaLoaiHangText;
        private System.Windows.Forms.Button XoaLoaiHang;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button TimKiemLoaiHang;
        private System.Windows.Forms.TextBox TKLoaiHangText;
        private System.Windows.Forms.Button CapNhatLoaiHang;
        private System.Windows.Forms.TextBox CapNhatLoaiHangText;
        private System.Windows.Forms.TextBox TKChinhSuaText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}