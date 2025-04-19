namespace QuanLyHangHoa
{
    partial class MainForm
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
            this.ThaoTac = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MatHangBox = new System.Windows.Forms.Label();
            this.LoaiHangBox = new System.Windows.Forms.Label();
            this.DangXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ThaoTac
            // 
            this.ThaoTac.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThaoTac.Location = new System.Drawing.Point(331, 142);
            this.ThaoTac.Name = "ThaoTac";
            this.ThaoTac.Size = new System.Drawing.Size(603, 35);
            this.ThaoTac.TabIndex = 1;
            this.ThaoTac.Text = "Bạn muốn thao tác trên dữ liệu nào?";
            this.ThaoTac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyHangHoa.Properties.Resources.product_category_icon_png_3;
            this.pictureBox2.Location = new System.Drawing.Point(692, 227);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(171, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyHangHoa.Properties.Resources.fmcg_products_png_3;
            this.pictureBox1.Location = new System.Drawing.Point(375, 227);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MatHangBox
            // 
            this.MatHangBox.AutoSize = true;
            this.MatHangBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatHangBox.Location = new System.Drawing.Point(412, 337);
            this.MatHangBox.Name = "MatHangBox";
            this.MatHangBox.Size = new System.Drawing.Size(91, 19);
            this.MatHangBox.TabIndex = 4;
            this.MatHangBox.Text = "MẶT HÀNG";
            this.MatHangBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MatHangBox.Click += new System.EventHandler(this.MatHangBox_Click);
            // 
            // LoaiHangBox
            // 
            this.LoaiHangBox.AutoSize = true;
            this.LoaiHangBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoaiHangBox.Location = new System.Drawing.Point(730, 337);
            this.LoaiHangBox.Name = "LoaiHangBox";
            this.LoaiHangBox.Size = new System.Drawing.Size(93, 19);
            this.LoaiHangBox.TabIndex = 5;
            this.LoaiHangBox.Text = "LOẠI HÀNG";
            this.LoaiHangBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoaiHangBox.Click += new System.EventHandler(this.LoaiHangBox_Click);
            // 
            // DangXuat
            // 
            this.DangXuat.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangXuat.Location = new System.Drawing.Point(1212, 12);
            this.DangXuat.Name = "DangXuat";
            this.DangXuat.Size = new System.Drawing.Size(75, 23);
            this.DangXuat.TabIndex = 6;
            this.DangXuat.Text = "Đăng xuất";
            this.DangXuat.UseVisualStyleBackColor = true;
            this.DangXuat.Click += new System.EventHandler(this.DangXuat_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1309, 701);
            this.Controls.Add(this.DangXuat);
            this.Controls.Add(this.LoaiHangBox);
            this.Controls.Add(this.MatHangBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ThaoTac);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chào mừng đến với ứng dụng quản lý cửa hàng!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ThaoTac;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label MatHangBox;
        private System.Windows.Forms.Label LoaiHangBox;
        private System.Windows.Forms.Button DangXuat;
    }
}