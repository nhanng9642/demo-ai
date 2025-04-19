namespace QuanLyHangHoa
{
    partial class frm_LoaiHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_KetQua = new System.Windows.Forms.Label();
            this.label_TimKiem = new System.Windows.Forms.Label();
            this.MaLH_Search = new System.Windows.Forms.RadioButton();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.TenLH_Search = new System.Windows.Forms.RadioButton();
            this.Tim = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Them = new System.Windows.Forms.Button();
            this.TenLoaiHang = new System.Windows.Forms.Label();
            this.Th_TenLoaiHang = new System.Windows.Forms.TextBox();
            this.MaLoaiHang = new System.Windows.Forms.Label();
            this.Th_MaLoaiHang = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Back = new System.Windows.Forms.Button();
            this.Tim_Request = new System.Windows.Forms.Label();
            this.Tim_Refresh = new System.Windows.Forms.Button();
            this.NhapLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_KetQua
            // 
            this.label_KetQua.AutoSize = true;
            this.label_KetQua.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_KetQua.Location = new System.Drawing.Point(89, 300);
            this.label_KetQua.Name = "label_KetQua";
            this.label_KetQua.Size = new System.Drawing.Size(0, 15);
            this.label_KetQua.TabIndex = 35;
            // 
            // label_TimKiem
            // 
            this.label_TimKiem.AutoSize = true;
            this.label_TimKiem.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TimKiem.Location = new System.Drawing.Point(718, 63);
            this.label_TimKiem.Name = "label_TimKiem";
            this.label_TimKiem.Size = new System.Drawing.Size(136, 15);
            this.label_TimKiem.TabIndex = 34;
            this.label_TimKiem.Text = "Nhập loại hàng cần tìm";
            this.label_TimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MaLH_Search
            // 
            this.MaLH_Search.AutoSize = true;
            this.MaLH_Search.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaLH_Search.Location = new System.Drawing.Point(876, 24);
            this.MaLH_Search.Name = "MaLH_Search";
            this.MaLH_Search.Size = new System.Drawing.Size(156, 19);
            this.MaLH_Search.TabIndex = 33;
            this.MaLH_Search.TabStop = true;
            this.MaLH_Search.Text = "Tìm theo Mã Loại Hàng";
            this.MaLH_Search.UseVisualStyleBackColor = true;
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(876, 59);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(320, 23);
            this.SearchBox.TabIndex = 32;
            // 
            // TenLH_Search
            // 
            this.TenLH_Search.AutoSize = true;
            this.TenLH_Search.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenLH_Search.Location = new System.Drawing.Point(1037, 24);
            this.TenLH_Search.Name = "TenLH_Search";
            this.TenLH_Search.Size = new System.Drawing.Size(159, 19);
            this.TenLH_Search.TabIndex = 31;
            this.TenLH_Search.TabStop = true;
            this.TenLH_Search.Text = "Tìm theo Tên Loại Hàng";
            this.TenLH_Search.UseVisualStyleBackColor = true;
            // 
            // Tim
            // 
            this.Tim.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tim.Location = new System.Drawing.Point(1217, 59);
            this.Tim.Name = "Tim";
            this.Tim.Size = new System.Drawing.Size(62, 23);
            this.Tim.TabIndex = 30;
            this.Tim.Text = "Tìm";
            this.Tim.UseVisualStyleBackColor = true;
            this.Tim.Click += new System.EventHandler(this.Tim_Click);
            // 
            // Sua
            // 
            this.Sua.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sua.Location = new System.Drawing.Point(392, 238);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(53, 27);
            this.Sua.TabIndex = 29;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Xoa
            // 
            this.Xoa.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.Location = new System.Drawing.Point(296, 238);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(53, 27);
            this.Xoa.TabIndex = 28;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Them
            // 
            this.Them.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them.Location = new System.Drawing.Point(207, 238);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(53, 27);
            this.Them.TabIndex = 27;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // TenLoaiHang
            // 
            this.TenLoaiHang.AutoSize = true;
            this.TenLoaiHang.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenLoaiHang.Location = new System.Drawing.Point(89, 188);
            this.TenLoaiHang.Name = "TenLoaiHang";
            this.TenLoaiHang.Size = new System.Drawing.Size(88, 15);
            this.TenLoaiHang.TabIndex = 26;
            this.TenLoaiHang.Text = "Tên Loại Hàng";
            this.TenLoaiHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Th_TenLoaiHang
            // 
            this.Th_TenLoaiHang.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Th_TenLoaiHang.Location = new System.Drawing.Point(197, 186);
            this.Th_TenLoaiHang.Name = "Th_TenLoaiHang";
            this.Th_TenLoaiHang.Size = new System.Drawing.Size(250, 23);
            this.Th_TenLoaiHang.TabIndex = 25;
            // 
            // MaLoaiHang
            // 
            this.MaLoaiHang.AutoSize = true;
            this.MaLoaiHang.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaLoaiHang.Location = new System.Drawing.Point(89, 146);
            this.MaLoaiHang.Name = "MaLoaiHang";
            this.MaLoaiHang.Size = new System.Drawing.Size(85, 15);
            this.MaLoaiHang.TabIndex = 24;
            this.MaLoaiHang.Text = "Mã Loại Hàng";
            this.MaLoaiHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Th_MaLoaiHang
            // 
            this.Th_MaLoaiHang.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Th_MaLoaiHang.Location = new System.Drawing.Point(197, 144);
            this.Th_MaLoaiHang.Name = "Th_MaLoaiHang";
            this.Th_MaLoaiHang.Size = new System.Drawing.Size(250, 23);
            this.Th_MaLoaiHang.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(902, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(282, 265);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // button_Back
            // 
            this.button_Back.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Back.Location = new System.Drawing.Point(21, 20);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(120, 23);
            this.button_Back.TabIndex = 38;
            this.button_Back.Text = "Trở về Trang Chủ";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // Tim_Request
            // 
            this.Tim_Request.AutoSize = true;
            this.Tim_Request.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tim_Request.Location = new System.Drawing.Point(718, 104);
            this.Tim_Request.Name = "Tim_Request";
            this.Tim_Request.Size = new System.Drawing.Size(0, 15);
            this.Tim_Request.TabIndex = 40;
            // 
            // Tim_Refresh
            // 
            this.Tim_Refresh.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tim_Refresh.Location = new System.Drawing.Point(1125, 121);
            this.Tim_Refresh.Name = "Tim_Refresh";
            this.Tim_Refresh.Size = new System.Drawing.Size(154, 29);
            this.Tim_Refresh.TabIndex = 41;
            this.Tim_Refresh.Text = "Xóa kết quả tìm kiếm";
            this.Tim_Refresh.UseVisualStyleBackColor = true;
            this.Tim_Refresh.Click += new System.EventHandler(this.Tim_Refresh_Click);
            // 
            // NhapLai
            // 
            this.NhapLai.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapLai.Location = new System.Drawing.Point(92, 238);
            this.NhapLai.Name = "NhapLai";
            this.NhapLai.Size = new System.Drawing.Size(75, 27);
            this.NhapLai.TabIndex = 42;
            this.NhapLai.Text = "Nhập lại";
            this.NhapLai.UseVisualStyleBackColor = true;
            this.NhapLai.Click += new System.EventHandler(this.NhapLai_Click);
            // 
            // frm_LoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 767);
            this.Controls.Add(this.NhapLai);
            this.Controls.Add(this.Tim_Refresh);
            this.Controls.Add(this.Tim_Request);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_KetQua);
            this.Controls.Add(this.label_TimKiem);
            this.Controls.Add(this.MaLH_Search);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.TenLH_Search);
            this.Controls.Add(this.Tim);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.TenLoaiHang);
            this.Controls.Add(this.Th_TenLoaiHang);
            this.Controls.Add(this.MaLoaiHang);
            this.Controls.Add(this.Th_MaLoaiHang);
            this.Name = "frm_LoaiHang";
            this.Text = "frm_LoaiHang";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_LoaiHang_FormClosed);
            this.Load += new System.EventHandler(this.frm_LoaiHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_KetQua;
        private System.Windows.Forms.Label label_TimKiem;
        private System.Windows.Forms.RadioButton MaLH_Search;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.RadioButton TenLH_Search;
        private System.Windows.Forms.Button Tim;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Label TenLoaiHang;
        private System.Windows.Forms.TextBox Th_TenLoaiHang;
        private System.Windows.Forms.Label MaLoaiHang;
        private System.Windows.Forms.TextBox Th_MaLoaiHang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Label Tim_Request;
        private System.Windows.Forms.Button Tim_Refresh;
        private System.Windows.Forms.Button NhapLai;
    }
}