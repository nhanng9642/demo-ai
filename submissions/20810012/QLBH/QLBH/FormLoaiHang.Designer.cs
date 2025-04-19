namespace QLBH
{
    partial class FormLoaiHang
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
            this.lblDanhSachLoaiHang = new System.Windows.Forms.Label();
            this.txtTimLoaiHang = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblThongTinLoaiHang = new System.Windows.Forms.Label();
            this.txtLoaiHang = new System.Windows.Forms.TextBox();
            this.btnLuuLoaiHang = new System.Windows.Forms.Button();
            this.btnXoaLoaiHang = new System.Windows.Forms.Button();
            this.lstLoaiHang = new System.Windows.Forms.ListBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLoaiHang = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDanhSachLoaiHang
            // 
            this.lblDanhSachLoaiHang.AutoSize = true;
            this.lblDanhSachLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachLoaiHang.Location = new System.Drawing.Point(12, 9);
            this.lblDanhSachLoaiHang.Name = "lblDanhSachLoaiHang";
            this.lblDanhSachLoaiHang.Size = new System.Drawing.Size(173, 20);
            this.lblDanhSachLoaiHang.TabIndex = 0;
            this.lblDanhSachLoaiHang.Text = "Danh sách loại hàng";
            // 
            // txtTimLoaiHang
            // 
            this.txtTimLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimLoaiHang.Location = new System.Drawing.Point(16, 55);
            this.txtTimLoaiHang.Name = "txtTimLoaiHang";
            this.txtTimLoaiHang.Size = new System.Drawing.Size(157, 26);
            this.txtTimLoaiHang.TabIndex = 2;
            this.txtTimLoaiHang.TextChanged += new System.EventHandler(this.txtTimLoaiHang_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(195, 55);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 26);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblThongTinLoaiHang
            // 
            this.lblThongTinLoaiHang.AutoSize = true;
            this.lblThongTinLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinLoaiHang.Location = new System.Drawing.Point(315, 99);
            this.lblThongTinLoaiHang.Name = "lblThongTinLoaiHang";
            this.lblThongTinLoaiHang.Size = new System.Drawing.Size(88, 20);
            this.lblThongTinLoaiHang.TabIndex = 0;
            this.lblThongTinLoaiHang.Text = "Loại hàng";
            // 
            // txtLoaiHang
            // 
            this.txtLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiHang.Location = new System.Drawing.Point(319, 138);
            this.txtLoaiHang.Name = "txtLoaiHang";
            this.txtLoaiHang.Size = new System.Drawing.Size(241, 26);
            this.txtLoaiHang.TabIndex = 2;
            // 
            // btnLuuLoaiHang
            // 
            this.btnLuuLoaiHang.BackColor = System.Drawing.Color.GreenYellow;
            this.btnLuuLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuLoaiHang.Location = new System.Drawing.Point(319, 263);
            this.btnLuuLoaiHang.Name = "btnLuuLoaiHang";
            this.btnLuuLoaiHang.Size = new System.Drawing.Size(92, 26);
            this.btnLuuLoaiHang.TabIndex = 3;
            this.btnLuuLoaiHang.Text = "Lưu";
            this.btnLuuLoaiHang.UseVisualStyleBackColor = false;
            this.btnLuuLoaiHang.Click += new System.EventHandler(this.btnLuuLoaiHang_Click);
            // 
            // btnXoaLoaiHang
            // 
            this.btnXoaLoaiHang.BackColor = System.Drawing.Color.Chocolate;
            this.btnXoaLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLoaiHang.Location = new System.Drawing.Point(468, 263);
            this.btnXoaLoaiHang.Name = "btnXoaLoaiHang";
            this.btnXoaLoaiHang.Size = new System.Drawing.Size(92, 26);
            this.btnXoaLoaiHang.TabIndex = 3;
            this.btnXoaLoaiHang.Text = "Xóa";
            this.btnXoaLoaiHang.UseVisualStyleBackColor = false;
            this.btnXoaLoaiHang.Click += new System.EventHandler(this.btnXoaLoaiHang_Click);
            // 
            // lstLoaiHang
            // 
            this.lstLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLoaiHang.FormattingEnabled = true;
            this.lstLoaiHang.ItemHeight = 20;
            this.lstLoaiHang.Location = new System.Drawing.Point(16, 114);
            this.lstLoaiHang.Name = "lstLoaiHang";
            this.lstLoaiHang.Size = new System.Drawing.Size(271, 324);
            this.lstLoaiHang.TabIndex = 4;
            this.lstLoaiHang.SelectedIndexChanged += new System.EventHandler(this.lstLoaiHang_SelectedIndexChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightBlue;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThoat.Location = new System.Drawing.Point(319, 365);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(241, 73);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Cập nhật và Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Loại hàng";
            // 
            // txtMaLoaiHang
            // 
            this.txtMaLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiHang.Location = new System.Drawing.Point(319, 213);
            this.txtMaLoaiHang.Name = "txtMaLoaiHang";
            this.txtMaLoaiHang.Size = new System.Drawing.Size(241, 26);
            this.txtMaLoaiHang.TabIndex = 2;
            // 
            // FormLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 485);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lstLoaiHang);
            this.Controls.Add(this.btnXoaLoaiHang);
            this.Controls.Add(this.btnLuuLoaiHang);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtMaLoaiHang);
            this.Controls.Add(this.txtLoaiHang);
            this.Controls.Add(this.txtTimLoaiHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblThongTinLoaiHang);
            this.Controls.Add(this.lblDanhSachLoaiHang);
            this.Name = "FormLoaiHang";
            this.Text = "Thêm Loại Hàng";
            this.Load += new System.EventHandler(this.FormLoaiHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanhSachLoaiHang;
        private System.Windows.Forms.TextBox txtTimLoaiHang;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblThongTinLoaiHang;
        private System.Windows.Forms.TextBox txtLoaiHang;
        private System.Windows.Forms.Button btnLuuLoaiHang;
        private System.Windows.Forms.Button btnXoaLoaiHang;
        private System.Windows.Forms.ListBox lstLoaiHang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLoaiHang;
    }
}