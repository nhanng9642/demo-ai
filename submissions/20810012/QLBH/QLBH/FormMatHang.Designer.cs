namespace QLBH
{
    partial class FormMatHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.txtTimMatHang = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblLoaiHang = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cboLoaiHang = new System.Windows.Forms.ComboBox();
            this.lblTenHang = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtCongTy = new System.Windows.Forms.TextBox();
            this.txtNamSanXuat = new System.Windows.Forms.TextBox();
            this.lblHanDung = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnThemLoaiHang = new System.Windows.Forms.Button();
            this.dtpHanDung = new System.Windows.Forms.DateTimePicker();
            this.lstMatHang = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 70);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(204, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHẦN MỀM QUẢN LÍ HÀNG HÓA 20810012";
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSach.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDanhSach.Location = new System.Drawing.Point(12, 73);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(195, 24);
            this.lblDanhSach.TabIndex = 1;
            this.lblDanhSach.Text = "Danh sách hàng hóa :";
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblThongTin.Location = new System.Drawing.Point(630, 73);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(98, 24);
            this.lblThongTin.TabIndex = 1;
            this.lblThongTin.Text = "Thông Tin";
            // 
            // txtTimMatHang
            // 
            this.txtTimMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimMatHang.Location = new System.Drawing.Point(12, 109);
            this.txtTimMatHang.Name = "txtTimMatHang";
            this.txtTimMatHang.Size = new System.Drawing.Size(259, 26);
            this.txtTimMatHang.TabIndex = 3;
            this.txtTimMatHang.TextChanged += new System.EventHandler(this.txtTimMatHang_TextChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(517, 523);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 26);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblLoaiHang
            // 
            this.lblLoaiHang.AutoSize = true;
            this.lblLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiHang.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblLoaiHang.Location = new System.Drawing.Point(394, 142);
            this.lblLoaiHang.Name = "lblLoaiHang";
            this.lblLoaiHang.Size = new System.Drawing.Size(82, 20);
            this.lblLoaiHang.TabIndex = 1;
            this.lblLoaiHang.Text = "Loại Hàng";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblMa.Location = new System.Drawing.Point(397, 217);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(31, 20);
            this.lblMa.TabIndex = 1;
            this.lblMa.Text = "Mã";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(537, 214);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(335, 26);
            this.txtID.TabIndex = 3;
            // 
            // cboLoaiHang
            // 
            this.cboLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiHang.FormattingEnabled = true;
            this.cboLoaiHang.Location = new System.Drawing.Point(536, 145);
            this.cboLoaiHang.Name = "cboLoaiHang";
            this.cboLoaiHang.Size = new System.Drawing.Size(226, 28);
            this.cboLoaiHang.TabIndex = 5;
            // 
            // lblTenHang
            // 
            this.lblTenHang.AutoSize = true;
            this.lblTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHang.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTenHang.Location = new System.Drawing.Point(397, 273);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(79, 20);
            this.lblTenHang.TabIndex = 1;
            this.lblTenHang.Text = "Tên Hàng";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHang.Location = new System.Drawing.Point(537, 273);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(336, 26);
            this.txtTenHang.TabIndex = 3;
            // 
            // txtCongTy
            // 
            this.txtCongTy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCongTy.Location = new System.Drawing.Point(537, 389);
            this.txtCongTy.Name = "txtCongTy";
            this.txtCongTy.Size = new System.Drawing.Size(336, 26);
            this.txtCongTy.TabIndex = 3;
            // 
            // txtNamSanXuat
            // 
            this.txtNamSanXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamSanXuat.Location = new System.Drawing.Point(537, 439);
            this.txtNamSanXuat.Name = "txtNamSanXuat";
            this.txtNamSanXuat.Size = new System.Drawing.Size(336, 26);
            this.txtNamSanXuat.TabIndex = 3;
            // 
            // lblHanDung
            // 
            this.lblHanDung.AutoSize = true;
            this.lblHanDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHanDung.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblHanDung.Location = new System.Drawing.Point(397, 334);
            this.lblHanDung.Name = "lblHanDung";
            this.lblHanDung.Size = new System.Drawing.Size(82, 20);
            this.lblHanDung.TabIndex = 1;
            this.lblHanDung.Text = "Hạn Dùng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(397, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Công Ty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(397, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Năm Sản Xuất";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(772, 523);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 26);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(281, 109);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 26);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnThemLoaiHang
            // 
            this.btnThemLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLoaiHang.Location = new System.Drawing.Point(768, 145);
            this.btnThemLoaiHang.Name = "btnThemLoaiHang";
            this.btnThemLoaiHang.Size = new System.Drawing.Size(100, 26);
            this.btnThemLoaiHang.TabIndex = 4;
            this.btnThemLoaiHang.Text = "Thêm";
            this.btnThemLoaiHang.UseVisualStyleBackColor = true;
            this.btnThemLoaiHang.Click += new System.EventHandler(this.btnThemLoaiHang_Click);
            // 
            // dtpHanDung
            // 
            this.dtpHanDung.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHanDung.CustomFormat = "dd/mm/yyyy";
            this.dtpHanDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHanDung.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHanDung.Location = new System.Drawing.Point(537, 333);
            this.dtpHanDung.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dtpHanDung.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpHanDung.Name = "dtpHanDung";
            this.dtpHanDung.Size = new System.Drawing.Size(335, 26);
            this.dtpHanDung.TabIndex = 6;
            this.dtpHanDung.Value = new System.DateTime(2020, 12, 11, 0, 0, 0, 0);
            // 
            // lstMatHang
            // 
            this.lstMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMatHang.FormattingEnabled = true;
            this.lstMatHang.ItemHeight = 20;
            this.lstMatHang.Location = new System.Drawing.Point(12, 160);
            this.lstMatHang.Name = "lstMatHang";
            this.lstMatHang.Size = new System.Drawing.Size(369, 364);
            this.lstMatHang.TabIndex = 7;
            this.lstMatHang.SelectedIndexChanged += new System.EventHandler(this.lstMatHang_SelectedIndexChanged);
            // 
            // FormMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lstMatHang);
            this.Controls.Add(this.dtpHanDung);
            this.Controls.Add(this.cboLoaiHang);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnThemLoaiHang);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtNamSanXuat);
            this.Controls.Add(this.txtCongTy);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtTimMatHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHanDung);
            this.Controls.Add(this.lblTenHang);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.lblLoaiHang);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.panel1);
            this.Name = "FormMatHang";
            this.Text = "Nguyễn Quang Khánh";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.TextBox txtTimMatHang;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblLoaiHang;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cboLoaiHang;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtCongTy;
        private System.Windows.Forms.TextBox txtNamSanXuat;
        private System.Windows.Forms.Label lblHanDung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnThemLoaiHang;
        private System.Windows.Forms.DateTimePicker dtpHanDung;
        private System.Windows.Forms.ListBox lstMatHang;
    }
}

