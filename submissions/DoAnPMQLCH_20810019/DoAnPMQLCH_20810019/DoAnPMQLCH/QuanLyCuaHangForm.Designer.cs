using System;

namespace DoAnPMQLCH_20810019
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNSX = new System.Windows.Forms.TextBox();
            this.txtHSD = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CongTy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanSuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtMaHH
            // 
            resources.ApplyResources(this.txtMaHH, "txtMaHH");
            this.txtMaHH.Name = "txtMaHH";
            // 
            // txtTenHH
            // 
            resources.ApplyResources(this.txtTenHH, "txtTenHH");
            this.txtTenHH.Name = "txtTenHH";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtCty
            // 
            resources.ApplyResources(this.txtCty, "txtCty");
            this.txtCty.Name = "txtCty";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtLH
            // 
            resources.ApplyResources(this.txtLH, "txtLH");
            this.txtLH.Name = "txtLH";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // txtNSX
            // 
            resources.ApplyResources(this.txtNSX, "txtNSX");
            this.txtNSX.Name = "txtNSX";
            // 
            // txtHSD
            // 
            resources.ApplyResources(this.txtHSD, "txtHSD");
            this.txtHSD.Name = "txtHSD";
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHangHoa,
            this.TenHangHoa,
            this.CongTy,
            this.LoaiHang,
            this.NgaySanXuat,
            this.HanSuDung});
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // MaHangHoa
            // 
            this.MaHangHoa.DataPropertyName = "MaHangHoa";
            resources.ApplyResources(this.MaHangHoa, "MaHangHoa");
            this.MaHangHoa.Name = "MaHangHoa";
            // 
            // TenHangHoa
            // 
            this.TenHangHoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHangHoa.DataPropertyName = "TenHangHoa";
            resources.ApplyResources(this.TenHangHoa, "TenHangHoa");
            this.TenHangHoa.Name = "TenHangHoa";
            // 
            // CongTy
            // 
            this.CongTy.DataPropertyName = "CongTy";
            resources.ApplyResources(this.CongTy, "CongTy");
            this.CongTy.Name = "CongTy";
            // 
            // LoaiHang
            // 
            this.LoaiHang.DataPropertyName = "LoaiHang";
            resources.ApplyResources(this.LoaiHang, "LoaiHang");
            this.LoaiHang.Name = "LoaiHang";
            // 
            // NgaySanXuat
            // 
            this.NgaySanXuat.DataPropertyName = "NgaySanXuat";
            resources.ApplyResources(this.NgaySanXuat, "NgaySanXuat");
            this.NgaySanXuat.Name = "NgaySanXuat";
            // 
            // HanSuDung
            // 
            this.HanSuDung.DataPropertyName = "HanSuDung";
            resources.ApplyResources(this.HanSuDung, "HanSuDung");
            this.HanSuDung.Name = "HanSuDung";
            // 
            // btnThem
            // 
            resources.ApplyResources(this.btnThem, "btnThem");
            this.btnThem.Name = "btnThem";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            resources.ApplyResources(this.btnSua, "btnSua");
            this.btnSua.Name = "btnSua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            resources.ApplyResources(this.btnXoa, "btnXoa");
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnHuy
            // 
            resources.ApplyResources(this.btnHuy, "btnHuy");
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            resources.ApplyResources(this.btnThoat, "btnThoat");
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtHSD);
            this.Controls.Add(this.txtNSX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenHH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaHH);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Opacity = 0.94D;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNSX;
        private System.Windows.Forms.TextBox txtHSD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CongTy;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanSuDung;
        private System.Windows.Forms.Button btnSearch;
        private EventHandler button1_Click;
        private System.Windows.Forms.TextBox txtSearch;
    }
}