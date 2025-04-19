
namespace baithi
{
    partial class DataMgrApp
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Savetmp = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.accept = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.goods_type = new System.Windows.Forms.TextBox();
            this.made_date = new System.Windows.Forms.TextBox();
            this.company = new System.Windows.Forms.TextBox();
            this.Exp = new System.Windows.Forms.TextBox();
            this.goods_name = new System.Windows.Forms.TextBox();
            this.goods_num = new System.Windows.Forms.TextBox();
            this.find = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.Location = new System.Drawing.Point(10, 186);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.ShowCellToolTips = false;
            this.dataGridView.Size = new System.Drawing.Size(700, 261);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.row_selected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Savetmp);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.status);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cancel);
            this.groupBox1.Controls.Add(this.accept);
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.goods_type);
            this.groupBox1.Controls.Add(this.made_date);
            this.groupBox1.Controls.Add(this.company);
            this.groupBox1.Controls.Add(this.Exp);
            this.groupBox1.Controls.Add(this.goods_name);
            this.groupBox1.Controls.Add(this.goods_num);
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Controls.Add(this.find);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 473);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dữ liệu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(724, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 26);
            this.label10.TabIndex = 29;
            this.label10.Text = "Lưu data \r\nxuống database";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(250, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Tháng";
            // 
            // Savetmp
            // 
            this.Savetmp.Location = new System.Drawing.Point(727, 235);
            this.Savetmp.Name = "Savetmp";
            this.Savetmp.Size = new System.Drawing.Size(92, 40);
            this.Savetmp.TabIndex = 27;
            this.Savetmp.Text = "Lưu thay đổi";
            this.Savetmp.UseVisualStyleBackColor = true;
            this.Savetmp.Click += new System.EventHandler(this.Savetmp_Click);
            this.Savetmp.MouseEnter += new System.EventHandler(this.Savetmp_MouseEnter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(491, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "trạng thái:";
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(551, 163);
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Size = new System.Drawing.Size(159, 20);
            this.status.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Bảng:";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(727, 404);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(92, 43);
            this.cancel.TabIndex = 23;
            this.cancel.Text = "Hủy";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            this.cancel.MouseEnter += new System.EventHandler(this.cancel_MouseEnter);
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(727, 355);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(92, 43);
            this.accept.TabIndex = 22;
            this.accept.Text = "Đồng ý";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            this.accept.MouseEnter += new System.EventHandler(this.accept_MouseEnter);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(727, 189);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(92, 40);
            this.clear.TabIndex = 21;
            this.clear.Text = "Xóa";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            this.clear.MouseEnter += new System.EventHandler(this.clear_MouseEnter);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(665, 104);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(92, 41);
            this.add.TabIndex = 20;
            this.add.Text = "Thêm";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Loại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Năm sx:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Công ty:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Hạn SD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên Hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã hàng:";
            // 
            // goods_type
            // 
            this.goods_type.Location = new System.Drawing.Point(405, 124);
            this.goods_type.Name = "goods_type";
            this.goods_type.Size = new System.Drawing.Size(231, 20);
            this.goods_type.TabIndex = 13;
            this.goods_type.TextChanged += new System.EventHandler(this.goods_type_TextChanged);
            // 
            // made_date
            // 
            this.made_date.Location = new System.Drawing.Point(405, 87);
            this.made_date.Name = "made_date";
            this.made_date.Size = new System.Drawing.Size(231, 20);
            this.made_date.TabIndex = 12;
            this.made_date.TextChanged += new System.EventHandler(this.made_date_TextChanged);
            // 
            // company
            // 
            this.company.Location = new System.Drawing.Point(405, 48);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(231, 20);
            this.company.TabIndex = 11;
            this.company.TextChanged += new System.EventHandler(this.company_TextChanged);
            // 
            // Exp
            // 
            this.Exp.Location = new System.Drawing.Point(67, 125);
            this.Exp.Name = "Exp";
            this.Exp.Size = new System.Drawing.Size(177, 20);
            this.Exp.TabIndex = 10;
            this.Exp.TextChanged += new System.EventHandler(this.Exp_TextChanged);
            // 
            // goods_name
            // 
            this.goods_name.Location = new System.Drawing.Point(67, 87);
            this.goods_name.Name = "goods_name";
            this.goods_name.Size = new System.Drawing.Size(231, 20);
            this.goods_name.TabIndex = 9;
            this.goods_name.TextChanged += new System.EventHandler(this.goods_name_TextChanged);
            // 
            // goods_num
            // 
            this.goods_num.Location = new System.Drawing.Point(67, 48);
            this.goods_num.Name = "goods_num";
            this.goods_num.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.goods_num.Size = new System.Drawing.Size(231, 20);
            this.goods_num.TabIndex = 8;
            this.goods_num.TextChanged += new System.EventHandler(this.goods_num_TextChanged);
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(664, 48);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(92, 42);
            this.find.TabIndex = 2;
            this.find.Text = "Tìm kiếm";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            this.find.MouseEnter += new System.EventHandler(this.find_MouseEnter);
            // 
            // DataMgrApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 490);
            this.Controls.Add(this.groupBox1);
            this.Name = "DataMgrApp";
            this.Text = "App quản lý dữ liệu hàng hóa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox goods_type;
        private System.Windows.Forms.TextBox made_date;
        private System.Windows.Forms.TextBox company;
        private System.Windows.Forms.TextBox Exp;
        private System.Windows.Forms.TextBox goods_name;
        private System.Windows.Forms.TextBox goods_num;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namSXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMatHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctySXDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Savetmp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

