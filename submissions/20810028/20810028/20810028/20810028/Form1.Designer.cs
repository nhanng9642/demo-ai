namespace _20810028
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.loạiHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtCty = new System.Windows.Forms.TextBox();
            this.txtNamSx = new System.Windows.Forms.TextBox();
            this.txtHanSuDung = new System.Windows.Forms.TextBox();
            this.cboLoaiHang = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.MaHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoaiHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NamSx = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HSD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loạiHàngToolStripMenuItem,
            this.mặtHàngToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // loạiHàngToolStripMenuItem
            // 
            this.loạiHàngToolStripMenuItem.Name = "loạiHàngToolStripMenuItem";
            this.loạiHàngToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.loạiHàngToolStripMenuItem.Text = "Loại Hàng";
            this.loạiHàngToolStripMenuItem.Click += new System.EventHandler(this.loạiHàngToolStripMenuItem_Click);
            // 
            // mặtHàngToolStripMenuItem
            // 
            this.mặtHàngToolStripMenuItem.Name = "mặtHàngToolStripMenuItem";
            this.mặtHàngToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.mặtHàngToolStripMenuItem.Text = "Mặt Hàng";
            this.mặtHàngToolStripMenuItem.Click += new System.EventHandler(this.mặtHàngToolStripMenuItem_Click);
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(85, 52);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(177, 20);
            this.txtMaHang.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Công Ty Sản Xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Năm Sản Xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Loại Hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Hạn Sử Dụng";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(84, 92);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(214, 20);
            this.txtTenHang.TabIndex = 9;
            // 
            // txtCty
            // 
            this.txtCty.Location = new System.Drawing.Point(458, 55);
            this.txtCty.Name = "txtCty";
            this.txtCty.Size = new System.Drawing.Size(177, 20);
            this.txtCty.TabIndex = 10;
            // 
            // txtNamSx
            // 
            this.txtNamSx.Location = new System.Drawing.Point(458, 92);
            this.txtNamSx.Name = "txtNamSx";
            this.txtNamSx.Size = new System.Drawing.Size(177, 20);
            this.txtNamSx.TabIndex = 11;
            // 
            // txtHanSuDung
            // 
            this.txtHanSuDung.Location = new System.Drawing.Point(458, 133);
            this.txtHanSuDung.Name = "txtHanSuDung";
            this.txtHanSuDung.Size = new System.Drawing.Size(177, 20);
            this.txtHanSuDung.TabIndex = 12;
            // 
            // cboLoaiHang
            // 
            this.cboLoaiHang.FormattingEnabled = true;
            this.cboLoaiHang.Location = new System.Drawing.Point(86, 133);
            this.cboLoaiHang.Name = "cboLoaiHang";
            this.cboLoaiHang.Size = new System.Drawing.Size(212, 21);
            this.cboLoaiHang.TabIndex = 13;
            this.cboLoaiHang.SelectedIndexChanged += new System.EventHandler(this.cboLoaiHang_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(26, 175);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 23);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm Mặt Hàng";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaHang,
            this.TenHang,
            this.LoaiHang,
            this.Cty,
            this.NamSx,
            this.HSD});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 226);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(762, 139);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // MaHang
            // 
            this.MaHang.Text = "Mã Hàng";
            this.MaHang.Width = 97;
            // 
            // TenHang
            // 
            this.TenHang.Text = "Tên Hàng";
            this.TenHang.Width = 124;
            // 
            // LoaiHang
            // 
            this.LoaiHang.Text = "Loại Hàng";
            this.LoaiHang.Width = 123;
            // 
            // Cty
            // 
            this.Cty.Text = "Công Ty SX";
            this.Cty.Width = 111;
            // 
            // NamSx
            // 
            this.NamSx.Text = "Năm SX";
            this.NamSx.Width = 93;
            // 
            // HSD
            // 
            this.HSD.Text = "Hạn Sử Dụng";
            this.HSD.Width = 108;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Xóa  (* tích chọn để xóa)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Sửa (* tích chọn để sửa)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboLoaiHang);
            this.Controls.Add(this.txtHanSuDung);
            this.Controls.Add(this.txtNamSx);
            this.Controls.Add(this.txtCty);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Nguyễn Đức Sơn Trường 20810028";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem loạiHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mặtHàngToolStripMenuItem;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtCty;
        private System.Windows.Forms.TextBox txtNamSx;
        private System.Windows.Forms.TextBox txtHanSuDung;
        private System.Windows.Forms.ComboBox cboLoaiHang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader MaHang;
        private System.Windows.Forms.ColumnHeader TenHang;
        private System.Windows.Forms.ColumnHeader LoaiHang;
        private System.Windows.Forms.ColumnHeader Cty;
        private System.Windows.Forms.ColumnHeader NamSx;
        private System.Windows.Forms.ColumnHeader HSD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

