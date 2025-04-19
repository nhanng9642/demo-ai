namespace QuanLyHangHoa
{
    partial class Login
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
            this.DangNhap = new System.Windows.Forms.Label();
            this.MatKhau = new System.Windows.Forms.Label();
            this.TH_DangNhap = new System.Windows.Forms.TextBox();
            this.TH_MatKhau = new System.Windows.Forms.TextBox();
            this.DangNhap_btn = new System.Windows.Forms.Button();
            this.Login_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DangNhap
            // 
            this.DangNhap.AutoSize = true;
            this.DangNhap.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangNhap.Location = new System.Drawing.Point(48, 30);
            this.DangNhap.Name = "DangNhap";
            this.DangNhap.Size = new System.Drawing.Size(94, 15);
            this.DangNhap.TabIndex = 0;
            this.DangNhap.Text = "Tên Đăng Nhập";
            this.DangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MatKhau
            // 
            this.MatKhau.AutoSize = true;
            this.MatKhau.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatKhau.Location = new System.Drawing.Point(51, 70);
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Size = new System.Drawing.Size(61, 15);
            this.MatKhau.TabIndex = 1;
            this.MatKhau.Text = "Mật Khẩu";
            this.MatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TH_DangNhap
            // 
            this.TH_DangNhap.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TH_DangNhap.Location = new System.Drawing.Point(150, 28);
            this.TH_DangNhap.Name = "TH_DangNhap";
            this.TH_DangNhap.Size = new System.Drawing.Size(172, 23);
            this.TH_DangNhap.TabIndex = 2;
            // 
            // TH_MatKhau
            // 
            this.TH_MatKhau.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TH_MatKhau.Location = new System.Drawing.Point(150, 70);
            this.TH_MatKhau.Name = "TH_MatKhau";
            this.TH_MatKhau.Size = new System.Drawing.Size(172, 23);
            this.TH_MatKhau.TabIndex = 3;
            // 
            // DangNhap_btn
            // 
            this.DangNhap_btn.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangNhap_btn.Location = new System.Drawing.Point(150, 112);
            this.DangNhap_btn.Name = "DangNhap_btn";
            this.DangNhap_btn.Size = new System.Drawing.Size(87, 27);
            this.DangNhap_btn.TabIndex = 4;
            this.DangNhap_btn.Text = "Đăng Nhập";
            this.DangNhap_btn.UseVisualStyleBackColor = true;
            this.DangNhap_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login_Result
            // 
            this.Login_Result.AutoSize = true;
            this.Login_Result.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Result.Location = new System.Drawing.Point(147, 162);
            this.Login_Result.Name = "Login_Result";
            this.Login_Result.Size = new System.Drawing.Size(0, 15);
            this.Login_Result.TabIndex = 5;
            this.Login_Result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 186);
            this.Controls.Add(this.Login_Result);
            this.Controls.Add(this.DangNhap_btn);
            this.Controls.Add(this.TH_MatKhau);
            this.Controls.Add(this.TH_DangNhap);
            this.Controls.Add(this.MatKhau);
            this.Controls.Add(this.DangNhap);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DangNhap;
        private System.Windows.Forms.Label MatKhau;
        private System.Windows.Forms.TextBox TH_DangNhap;
        private System.Windows.Forms.TextBox TH_MatKhau;
        private System.Windows.Forms.Button DangNhap_btn;
        private System.Windows.Forms.Label Login_Result;
    }
}