
namespace DoAn1
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
            this.btnThemLH = new System.Windows.Forms.Button();
            this.btnHHTim = new System.Windows.Forms.Button();
            this.txtHHTim = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CongTy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemLH
            // 
            this.btnThemLH.Location = new System.Drawing.Point(308, 41);
            this.btnThemLH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemLH.Name = "btnThemLH";
            this.btnThemLH.Size = new System.Drawing.Size(232, 35);
            this.btnThemLH.TabIndex = 2;
            this.btnThemLH.Text = "Them Loai Hang";
            this.btnThemLH.UseVisualStyleBackColor = true;
            this.btnThemLH.Click += new System.EventHandler(this.btnThemLH_Click);
            // 
            // btnHHTim
            // 
            this.btnHHTim.Location = new System.Drawing.Point(308, 107);
            this.btnHHTim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHHTim.Name = "btnHHTim";
            this.btnHHTim.Size = new System.Drawing.Size(112, 35);
            this.btnHHTim.TabIndex = 3;
            this.btnHHTim.Text = "Tim";
            this.btnHHTim.UseVisualStyleBackColor = true;
            this.btnHHTim.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHHTim
            // 
            this.txtHHTim.Location = new System.Drawing.Point(13, 41);
            this.txtHHTim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHHTim.Name = "txtHHTim";
            this.txtHHTim.Size = new System.Drawing.Size(230, 26);
            this.txtHHTim.TabIndex = 4;
            this.txtHHTim.TextChanged += new System.EventHandler(this.txtHHTim_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHH,
            this.TenHH,
            this.CongTy,
            this.LoaiHang,
            this.NSX,
            this.HSD,
            this.Xoa});
            this.dataGridView1.Location = new System.Drawing.Point(27, 237);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1148, 402);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaHH
            // 
            this.MaHH.DataPropertyName = "MaHH";
            this.MaHH.HeaderText = "Ma Hang Hoa";
            this.MaHH.MinimumWidth = 8;
            this.MaHH.Name = "MaHH";
            this.MaHH.Width = 150;
            // 
            // TenHH
            // 
            this.TenHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHH.DataPropertyName = "TenHH";
            this.TenHH.HeaderText = "Ten Hang Hoa";
            this.TenHH.MinimumWidth = 8;
            this.TenHH.Name = "TenHH";
            // 
            // CongTy
            // 
            this.CongTy.DataPropertyName = "CongTy";
            this.CongTy.HeaderText = "Cong Ty";
            this.CongTy.MinimumWidth = 8;
            this.CongTy.Name = "CongTy";
            this.CongTy.Width = 150;
            // 
            // LoaiHang
            // 
            this.LoaiHang.DataPropertyName = "LH";
            this.LoaiHang.HeaderText = "LoaiHang";
            this.LoaiHang.MinimumWidth = 8;
            this.LoaiHang.Name = "LoaiHang";
            this.LoaiHang.Width = 150;
            // 
            // NSX
            // 
            this.NSX.DataPropertyName = "NSX";
            this.NSX.HeaderText = "NSX";
            this.NSX.MinimumWidth = 8;
            this.NSX.Name = "NSX";
            this.NSX.Width = 150;
            // 
            // HSD
            // 
            this.HSD.DataPropertyName = "HSD";
            this.HSD.HeaderText = "HSD";
            this.HSD.MinimumWidth = 8;
            this.HSD.Name = "HSD";
            this.HSD.Width = 150;
            // 
            // Xoa
            // 
            this.Xoa.HeaderText = "Xoa";
            this.Xoa.MinimumWidth = 8;
            this.Xoa.Name = "Xoa";
            this.Xoa.Text = "X";
            this.Xoa.UseColumnTextForButtonValue = true;
            this.Xoa.Width = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 654);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtHHTim);
            this.Controls.Add(this.btnHHTim);
            this.Controls.Add(this.btnThemLH);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThemLH;
        private System.Windows.Forms.Button btnHHTim;
        private System.Windows.Forms.TextBox txtHHTim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CongTy;
        private System.Windows.Forms.DataGridViewComboBoxColumn LoaiHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSD;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
    }
}

