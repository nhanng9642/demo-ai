namespace QuanLyHangHoa
{
    partial class frm_MatHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Display_MaHang = new System.Windows.Forms.TextBox();
            this.Th_MaHang = new System.Windows.Forms.Label();
            this.Th_TenHang = new System.Windows.Forms.Label();
            this.Display_TenHang = new System.Windows.Forms.TextBox();
            this.Th_HanSuDung = new System.Windows.Forms.Label();
            this.Display_HSD = new System.Windows.Forms.TextBox();
            this.Th_CTSX = new System.Windows.Forms.Label();
            this.Display_CTSX = new System.Windows.Forms.TextBox();
            this.Th_NamSX = new System.Windows.Forms.Label();
            this.Display_NamSX = new System.Windows.Forms.TextBox();
            this.lTh_LoaiHang = new System.Windows.Forms.Label();
            this.Them = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            this.Tim = new System.Windows.Forms.Button();
            this.TimTheoTenHang = new System.Windows.Forms.RadioButton();
            this.MH_SearchBox = new System.Windows.Forms.TextBox();
            this.TimTheoMaHang = new System.Windows.Forms.RadioButton();
            this.label_TimKiem = new System.Windows.Forms.Label();
            this.label_KetQua = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Back = new System.Windows.Forms.Button();
            this.Display_LoaiHang_Combo = new System.Windows.Forms.ComboBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.Tim_Request = new System.Windows.Forms.Label();
            this.XoaTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Display_MaHang
            // 
            this.Display_MaHang.Location = new System.Drawing.Point(155, 147);
            this.Display_MaHang.Name = "Display_MaHang";
            this.Display_MaHang.Size = new System.Drawing.Size(292, 23);
            this.Display_MaHang.TabIndex = 1;
            // 
            // Th_MaHang
            // 
            this.Th_MaHang.AutoSize = true;
            this.Th_MaHang.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Th_MaHang.Location = new System.Drawing.Point(29, 149);
            this.Th_MaHang.Name = "Th_MaHang";
            this.Th_MaHang.Size = new System.Drawing.Size(58, 15);
            this.Th_MaHang.TabIndex = 2;
            this.Th_MaHang.Text = "Mã Hàng";
            this.Th_MaHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Th_TenHang
            // 
            this.Th_TenHang.AutoSize = true;
            this.Th_TenHang.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Th_TenHang.Location = new System.Drawing.Point(29, 198);
            this.Th_TenHang.Name = "Th_TenHang";
            this.Th_TenHang.Size = new System.Drawing.Size(61, 15);
            this.Th_TenHang.TabIndex = 4;
            this.Th_TenHang.Text = "Tên Hàng";
            this.Th_TenHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Display_TenHang
            // 
            this.Display_TenHang.Location = new System.Drawing.Point(155, 196);
            this.Display_TenHang.Name = "Display_TenHang";
            this.Display_TenHang.Size = new System.Drawing.Size(292, 23);
            this.Display_TenHang.TabIndex = 3;
            // 
            // Th_HanSuDung
            // 
            this.Th_HanSuDung.AutoSize = true;
            this.Th_HanSuDung.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Th_HanSuDung.Location = new System.Drawing.Point(29, 242);
            this.Th_HanSuDung.Name = "Th_HanSuDung";
            this.Th_HanSuDung.Size = new System.Drawing.Size(82, 15);
            this.Th_HanSuDung.TabIndex = 6;
            this.Th_HanSuDung.Text = "Hạn Sử Dụng";
            this.Th_HanSuDung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Display_HSD
            // 
            this.Display_HSD.Location = new System.Drawing.Point(156, 239);
            this.Display_HSD.Name = "Display_HSD";
            this.Display_HSD.Size = new System.Drawing.Size(292, 23);
            this.Display_HSD.TabIndex = 5;
            // 
            // Th_CTSX
            // 
            this.Th_CTSX.AutoSize = true;
            this.Th_CTSX.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Th_CTSX.Location = new System.Drawing.Point(29, 287);
            this.Th_CTSX.Name = "Th_CTSX";
            this.Th_CTSX.Size = new System.Drawing.Size(107, 15);
            this.Th_CTSX.TabIndex = 8;
            this.Th_CTSX.Text = "Công Ty Sản Xuất";
            this.Th_CTSX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Display_CTSX
            // 
            this.Display_CTSX.Location = new System.Drawing.Point(155, 284);
            this.Display_CTSX.Name = "Display_CTSX";
            this.Display_CTSX.Size = new System.Drawing.Size(292, 23);
            this.Display_CTSX.TabIndex = 7;
            // 
            // Th_NamSX
            // 
            this.Th_NamSX.AutoSize = true;
            this.Th_NamSX.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Th_NamSX.Location = new System.Drawing.Point(29, 331);
            this.Th_NamSX.Name = "Th_NamSX";
            this.Th_NamSX.Size = new System.Drawing.Size(88, 15);
            this.Th_NamSX.TabIndex = 10;
            this.Th_NamSX.Text = "Năm Sản Xuất";
            this.Th_NamSX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Display_NamSX
            // 
            this.Display_NamSX.Location = new System.Drawing.Point(155, 328);
            this.Display_NamSX.Name = "Display_NamSX";
            this.Display_NamSX.Size = new System.Drawing.Size(292, 23);
            this.Display_NamSX.TabIndex = 9;
            // 
            // lTh_LoaiHang
            // 
            this.lTh_LoaiHang.AutoSize = true;
            this.lTh_LoaiHang.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTh_LoaiHang.Location = new System.Drawing.Point(29, 376);
            this.lTh_LoaiHang.Name = "lTh_LoaiHang";
            this.lTh_LoaiHang.Size = new System.Drawing.Size(64, 15);
            this.lTh_LoaiHang.TabIndex = 12;
            this.lTh_LoaiHang.Text = "Loại Hàng";
            this.lTh_LoaiHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Them
            // 
            this.Them.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them.Location = new System.Drawing.Point(162, 431);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(63, 28);
            this.Them.TabIndex = 13;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // Xoa
            // 
            this.Xoa.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.Location = new System.Drawing.Point(267, 431);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(63, 28);
            this.Xoa.TabIndex = 14;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Sua
            // 
            this.Sua.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sua.Location = new System.Drawing.Point(370, 431);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(63, 28);
            this.Sua.TabIndex = 15;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Tim
            // 
            this.Tim.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tim.Location = new System.Drawing.Point(1196, 65);
            this.Tim.Name = "Tim";
            this.Tim.Size = new System.Drawing.Size(66, 27);
            this.Tim.TabIndex = 16;
            this.Tim.Text = "Tìm";
            this.Tim.UseVisualStyleBackColor = true;
            this.Tim.Click += new System.EventHandler(this.Tim_Click);
            // 
            // TimTheoTenHang
            // 
            this.TimTheoTenHang.AutoSize = true;
            this.TimTheoTenHang.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimTheoTenHang.Location = new System.Drawing.Point(1004, 28);
            this.TimTheoTenHang.Name = "TimTheoTenHang";
            this.TimTheoTenHang.Size = new System.Drawing.Size(132, 19);
            this.TimTheoTenHang.TabIndex = 17;
            this.TimTheoTenHang.TabStop = true;
            this.TimTheoTenHang.Text = "Tìm theo Tên Hàng";
            this.TimTheoTenHang.UseVisualStyleBackColor = true;
            // 
            // MH_SearchBox
            // 
            this.MH_SearchBox.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MH_SearchBox.Location = new System.Drawing.Point(844, 68);
            this.MH_SearchBox.Name = "MH_SearchBox";
            this.MH_SearchBox.Size = new System.Drawing.Size(310, 23);
            this.MH_SearchBox.TabIndex = 18;
            // 
            // TimTheoMaHang
            // 
            this.TimTheoMaHang.AutoSize = true;
            this.TimTheoMaHang.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimTheoMaHang.Location = new System.Drawing.Point(844, 28);
            this.TimTheoMaHang.Name = "TimTheoMaHang";
            this.TimTheoMaHang.Size = new System.Drawing.Size(129, 19);
            this.TimTheoMaHang.TabIndex = 19;
            this.TimTheoMaHang.TabStop = true;
            this.TimTheoMaHang.Text = "Tìm theo Mã Hàng";
            this.TimTheoMaHang.UseVisualStyleBackColor = true;
            // 
            // label_TimKiem
            // 
            this.label_TimKiem.AutoSize = true;
            this.label_TimKiem.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TimKiem.Location = new System.Drawing.Point(659, 73);
            this.label_TimKiem.Name = "label_TimKiem";
            this.label_TimKiem.Size = new System.Drawing.Size(138, 15);
            this.label_TimKiem.TabIndex = 20;
            this.label_TimKiem.Text = "Nhập mặt hàng cần tìm";
            this.label_TimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_KetQua
            // 
            this.label_KetQua.AutoSize = true;
            this.label_KetQua.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_KetQua.Location = new System.Drawing.Point(38, 488);
            this.label_KetQua.Name = "label_KetQua";
            this.label_KetQua.Size = new System.Drawing.Size(0, 15);
            this.label_KetQua.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(620, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(765, 460);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(27, 12);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(120, 23);
            this.button_Back.TabIndex = 24;
            this.button_Back.Text = "Trở về Trang Chủ";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // Display_LoaiHang_Combo
            // 
            this.Display_LoaiHang_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Display_LoaiHang_Combo.FormattingEnabled = true;
            this.Display_LoaiHang_Combo.Location = new System.Drawing.Point(155, 376);
            this.Display_LoaiHang_Combo.Name = "Display_LoaiHang_Combo";
            this.Display_LoaiHang_Combo.Size = new System.Drawing.Size(293, 23);
            this.Display_LoaiHang_Combo.TabIndex = 25;
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(41, 431);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(70, 28);
            this.Refresh.TabIndex = 26;
            this.Refresh.Text = "Nhập lại";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Tim_Request
            // 
            this.Tim_Request.AutoSize = true;
            this.Tim_Request.Location = new System.Drawing.Point(659, 110);
            this.Tim_Request.Name = "Tim_Request";
            this.Tim_Request.Size = new System.Drawing.Size(0, 15);
            this.Tim_Request.TabIndex = 27;
            // 
            // XoaTimKiem
            // 
            this.XoaTimKiem.Location = new System.Drawing.Point(1237, 110);
            this.XoaTimKiem.Name = "XoaTimKiem";
            this.XoaTimKiem.Size = new System.Drawing.Size(150, 27);
            this.XoaTimKiem.TabIndex = 28;
            this.XoaTimKiem.Text = "Xóa kết quả tìm kiếm";
            this.XoaTimKiem.UseVisualStyleBackColor = true;
            this.XoaTimKiem.Click += new System.EventHandler(this.XoaTimKiem_Click);
            // 
            // frm_MatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 767);
            this.Controls.Add(this.XoaTimKiem);
            this.Controls.Add(this.Tim_Request);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Display_LoaiHang_Combo);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_KetQua);
            this.Controls.Add(this.label_TimKiem);
            this.Controls.Add(this.TimTheoMaHang);
            this.Controls.Add(this.MH_SearchBox);
            this.Controls.Add(this.TimTheoTenHang);
            this.Controls.Add(this.Tim);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.lTh_LoaiHang);
            this.Controls.Add(this.Th_NamSX);
            this.Controls.Add(this.Display_NamSX);
            this.Controls.Add(this.Th_CTSX);
            this.Controls.Add(this.Display_CTSX);
            this.Controls.Add(this.Th_HanSuDung);
            this.Controls.Add(this.Display_HSD);
            this.Controls.Add(this.Th_TenHang);
            this.Controls.Add(this.Display_TenHang);
            this.Controls.Add(this.Th_MaHang);
            this.Controls.Add(this.Display_MaHang);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_MatHang";
            this.Text = "Quản lý Mặt Hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_MatHang_FormClosed);
            this.Load += new System.EventHandler(this.frm_MatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Display_MaHang;
        private System.Windows.Forms.Label Th_MaHang;
        private System.Windows.Forms.Label Th_TenHang;
        private System.Windows.Forms.TextBox Display_TenHang;
        private System.Windows.Forms.Label Th_HanSuDung;
        private System.Windows.Forms.TextBox Display_HSD;
        private System.Windows.Forms.Label Th_CTSX;
        private System.Windows.Forms.TextBox Display_CTSX;
        private System.Windows.Forms.Label Th_NamSX;
        private System.Windows.Forms.TextBox Display_NamSX;
        private System.Windows.Forms.Label lTh_LoaiHang;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Tim;
        private System.Windows.Forms.RadioButton TimTheoTenHang;
        private System.Windows.Forms.TextBox MH_SearchBox;
        private System.Windows.Forms.RadioButton TimTheoMaHang;
        private System.Windows.Forms.Label label_TimKiem;
        private System.Windows.Forms.Label label_KetQua;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.ComboBox Display_LoaiHang_Combo;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Label Tim_Request;
        private System.Windows.Forms.Button XoaTimKiem;
    }
}