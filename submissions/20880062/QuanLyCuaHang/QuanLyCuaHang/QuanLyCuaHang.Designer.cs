using System;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    partial class QuanLyCuaHang
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyCuaHang));
            this.mnu = new System.Windows.Forms.MenuStrip();
            this.mnuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQLMatHang = new System.Windows.Forms.Button();
            this.btnQLLoaiHang = new System.Windows.Forms.Button();
            this.lblGioiThieu = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mnu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu
            // 
            this.mnu.AllowItemReorder = true;
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInfo});
            this.mnu.Location = new System.Drawing.Point(0, 0);
            this.mnu.Name = "mnu";
            this.mnu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnu.Size = new System.Drawing.Size(482, 24);
            this.mnu.TabIndex = 0;
            this.mnu.Text = "Thông tin";
            this.mnu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnu_ItemClicked);
            // 
            // mnuInfo
            // 
            this.mnuInfo.Name = "mnuInfo";
            this.mnuInfo.Size = new System.Drawing.Size(70, 20);
            this.mnuInfo.Text = "Thông tin";
            // 
            // btnQLMatHang
            // 
            this.btnQLMatHang.Location = new System.Drawing.Point(12, 376);
            this.btnQLMatHang.Name = "btnQLMatHang";
            this.btnQLMatHang.Size = new System.Drawing.Size(230, 50);
            this.btnQLMatHang.TabIndex = 1;
            this.btnQLMatHang.Text = "QUẢN LÝ MẶT HÀNG";
            this.btnQLMatHang.UseVisualStyleBackColor = true;
            this.btnQLMatHang.Click += new System.EventHandler(this.btnQLMatHang_Click);
            // 
            // btnQLLoaiHang
            // 
            this.btnQLLoaiHang.Location = new System.Drawing.Point(248, 376);
            this.btnQLLoaiHang.Name = "btnQLLoaiHang";
            this.btnQLLoaiHang.Size = new System.Drawing.Size(221, 50);
            this.btnQLLoaiHang.TabIndex = 2;
            this.btnQLLoaiHang.Text = "QUẢN LÝ LOẠI HÀNG";
            this.btnQLLoaiHang.UseVisualStyleBackColor = true;
            this.btnQLLoaiHang.Click += new System.EventHandler(this.btnQLLoaiHang_Click);
            // 
            // lblGioiThieu
            // 
            this.lblGioiThieu.AutoSize = true;
            this.lblGioiThieu.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGioiThieu.Location = new System.Drawing.Point(33, 24);
            this.lblGioiThieu.Name = "lblGioiThieu";
            this.lblGioiThieu.Size = new System.Drawing.Size(404, 50);
            this.lblGioiThieu.TabIndex = 3;
            this.lblGioiThieu.Text = "CHƯƠNG TRÌNH QUẢN LÝ CỬA HÀNG\r\n\r\n";
            this.lblGioiThieu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 134);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới thiệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 105);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 162);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hướng dẫn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(446, 120);
            this.label2.TabIndex = 6;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // QuanLyCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 435);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnQLMatHang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblGioiThieu);
            this.Controls.Add(this.btnQLLoaiHang);
            this.Controls.Add(this.mnu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QuanLyCuaHang";
            this.Text = "QUẢN LÝ CỬA HÀNG";
            this.mnu.ResumeLayout(false);
            this.mnu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu;
        private Button btnQLMatHang;
        private Button btnQLLoaiHang;
        private Label lblGioiThieu;
        private ToolStripMenuItem mnuInfo;
        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
    }
}

