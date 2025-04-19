namespace QLCuaHang
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataMH = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioTH = new System.Windows.Forms.RadioButton();
            this.radioMH = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbLH = new System.Windows.Forms.ComboBox();
            this.dateNamSX = new System.Windows.Forms.DateTimePicker();
            this.dateHanDung = new System.Windows.Forms.DateTimePicker();
            this.btnSuaMH = new System.Windows.Forms.Button();
            this.btnClearMH = new System.Windows.Forms.Button();
            this.btnThemMH = new System.Windows.Forms.Button();
            this.txtTH = new System.Windows.Forms.TextBox();
            this.txtCty = new System.Windows.Forms.TextBox();
            this.txtMH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimMH = new System.Windows.Forms.Button();
            this.txtTimMH = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataLH = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioTenLH = new System.Windows.Forms.RadioButton();
            this.radioMaLH = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClearLH = new System.Windows.Forms.Button();
            this.btnSuaLH = new System.Windows.Forms.Button();
            this.btnThemLH = new System.Windows.Forms.Button();
            this.txtTenLH = new System.Windows.Forms.TextBox();
            this.txtMaLH = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnTimLH = new System.Windows.Forms.Button();
            this.txtTimLH = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMH)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLH)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 361);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataMH);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "QL Mat hang";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataMH
            // 
            this.dataMH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataMH.Location = new System.Drawing.Point(0, 183);
            this.dataMH.Name = "dataMH";
            this.dataMH.Size = new System.Drawing.Size(793, 150);
            this.dataMH.TabIndex = 3;
            this.dataMH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMH_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ma Hang";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ten Hang";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Han Dung";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cty SX";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nam SX";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Loai Hang";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Sua";
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Xoa";
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioTH);
            this.panel1.Controls.Add(this.radioMH);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnTimMH);
            this.panel1.Controls.Add(this.txtTimMH);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 175);
            this.panel1.TabIndex = 2;
            // 
            // radioTH
            // 
            this.radioTH.AutoSize = true;
            this.radioTH.Location = new System.Drawing.Point(134, 18);
            this.radioTH.Name = "radioTH";
            this.radioTH.Size = new System.Drawing.Size(73, 17);
            this.radioTH.TabIndex = 4;
            this.radioTH.TabStop = true;
            this.radioTH.Text = "Ten Hang";
            this.radioTH.UseVisualStyleBackColor = true;
            // 
            // radioMH
            // 
            this.radioMH.AutoSize = true;
            this.radioMH.Location = new System.Drawing.Point(25, 20);
            this.radioMH.Name = "radioMH";
            this.radioMH.Size = new System.Drawing.Size(69, 17);
            this.radioMH.TabIndex = 4;
            this.radioMH.TabStop = true;
            this.radioMH.Text = "Ma Hang";
            this.radioMH.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbLH);
            this.panel2.Controls.Add(this.dateNamSX);
            this.panel2.Controls.Add(this.dateHanDung);
            this.panel2.Controls.Add(this.btnSuaMH);
            this.panel2.Controls.Add(this.btnClearMH);
            this.panel2.Controls.Add(this.btnThemMH);
            this.panel2.Controls.Add(this.txtTH);
            this.panel2.Controls.Add(this.txtCty);
            this.panel2.Controls.Add(this.txtMH);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 128);
            this.panel2.TabIndex = 3;
            // 
            // cbLH
            // 
            this.cbLH.FormattingEnabled = true;
            this.cbLH.Location = new System.Drawing.Point(431, 90);
            this.cbLH.Name = "cbLH";
            this.cbLH.Size = new System.Drawing.Size(100, 21);
            this.cbLH.TabIndex = 18;
            // 
            // dateNamSX
            // 
            this.dateNamSX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNamSX.Location = new System.Drawing.Point(431, 54);
            this.dateNamSX.Name = "dateNamSX";
            this.dateNamSX.Size = new System.Drawing.Size(100, 20);
            this.dateNamSX.TabIndex = 16;
            // 
            // dateHanDung
            // 
            this.dateHanDung.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateHanDung.Location = new System.Drawing.Point(139, 91);
            this.dateHanDung.Name = "dateHanDung";
            this.dateHanDung.Size = new System.Drawing.Size(100, 20);
            this.dateHanDung.TabIndex = 17;
            // 
            // btnSuaMH
            // 
            this.btnSuaMH.Location = new System.Drawing.Point(634, 52);
            this.btnSuaMH.Name = "btnSuaMH";
            this.btnSuaMH.Size = new System.Drawing.Size(75, 23);
            this.btnSuaMH.TabIndex = 14;
            this.btnSuaMH.Text = "Sua";
            this.btnSuaMH.UseVisualStyleBackColor = true;
            this.btnSuaMH.Click += new System.EventHandler(this.btnSuaMH_Click);
            // 
            // btnClearMH
            // 
            this.btnClearMH.Location = new System.Drawing.Point(634, 17);
            this.btnClearMH.Name = "btnClearMH";
            this.btnClearMH.Size = new System.Drawing.Size(75, 23);
            this.btnClearMH.TabIndex = 14;
            this.btnClearMH.Text = "Clear";
            this.btnClearMH.UseVisualStyleBackColor = true;
            this.btnClearMH.Click += new System.EventHandler(this.btnClearMH_Click);
            // 
            // btnThemMH
            // 
            this.btnThemMH.Location = new System.Drawing.Point(634, 84);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(75, 23);
            this.btnThemMH.TabIndex = 14;
            this.btnThemMH.Text = "Them";
            this.btnThemMH.UseVisualStyleBackColor = true;
            this.btnThemMH.Click += new System.EventHandler(this.btnThemMH_Click);
            // 
            // txtTH
            // 
            this.txtTH.Location = new System.Drawing.Point(139, 54);
            this.txtTH.Name = "txtTH";
            this.txtTH.Size = new System.Drawing.Size(100, 20);
            this.txtTH.TabIndex = 11;
            // 
            // txtCty
            // 
            this.txtCty.Location = new System.Drawing.Point(431, 17);
            this.txtCty.Name = "txtCty";
            this.txtCty.Size = new System.Drawing.Size(100, 20);
            this.txtCty.TabIndex = 12;
            // 
            // txtMH
            // 
            this.txtMH.Location = new System.Drawing.Point(139, 17);
            this.txtMH.Name = "txtMH";
            this.txtMH.Size = new System.Drawing.Size(100, 20);
            this.txtMH.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Loai Hang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Han Dung";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nam SX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ten Hang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cty SX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ma Hang";
            // 
            // btnTimMH
            // 
            this.btnTimMH.Location = new System.Drawing.Point(422, 16);
            this.btnTimMH.Name = "btnTimMH";
            this.btnTimMH.Size = new System.Drawing.Size(75, 23);
            this.btnTimMH.TabIndex = 2;
            this.btnTimMH.Text = "Tim";
            this.btnTimMH.UseVisualStyleBackColor = true;
            this.btnTimMH.Click += new System.EventHandler(this.btnTimMH_Click);
            // 
            // txtTimMH
            // 
            this.txtTimMH.Location = new System.Drawing.Point(243, 18);
            this.txtTimMH.Name = "txtTimMH";
            this.txtTimMH.Size = new System.Drawing.Size(167, 20);
            this.txtTimMH.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataLH);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "QL Loai Hang";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataLH
            // 
            this.dataLH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dataLH.Location = new System.Drawing.Point(0, 139);
            this.dataLH.Name = "dataLH";
            this.dataLH.Size = new System.Drawing.Size(797, 200);
            this.dataLH.TabIndex = 1;
            this.dataLH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLH_CellContentClick);
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Ma Loai Hang";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Ten Loai Hang";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Sua";
            this.Column11.Name = "Column11";
            this.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Xoa";
            this.Column12.Name = "Column12";
            this.Column12.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioTenLH);
            this.panel3.Controls.Add(this.radioMaLH);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.btnTimLH);
            this.panel3.Controls.Add(this.txtTimLH);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(797, 141);
            this.panel3.TabIndex = 0;
            // 
            // radioTenLH
            // 
            this.radioTenLH.AutoSize = true;
            this.radioTenLH.Location = new System.Drawing.Point(160, 17);
            this.radioTenLH.Name = "radioTenLH";
            this.radioTenLH.Size = new System.Drawing.Size(61, 17);
            this.radioTenLH.TabIndex = 8;
            this.radioTenLH.TabStop = true;
            this.radioTenLH.Text = "Ten LH";
            this.radioTenLH.UseVisualStyleBackColor = true;
            // 
            // radioMaLH
            // 
            this.radioMaLH.AutoSize = true;
            this.radioMaLH.Location = new System.Drawing.Point(55, 17);
            this.radioMaLH.Name = "radioMaLH";
            this.radioMaLH.Size = new System.Drawing.Size(57, 17);
            this.radioMaLH.TabIndex = 9;
            this.radioMaLH.TabStop = true;
            this.radioMaLH.Text = "Ma LH";
            this.radioMaLH.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnClearLH);
            this.panel4.Controls.Add(this.btnSuaLH);
            this.panel4.Controls.Add(this.btnThemLH);
            this.panel4.Controls.Add(this.txtTenLH);
            this.panel4.Controls.Add(this.txtMaLH);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(311, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(486, 139);
            this.panel4.TabIndex = 7;
            // 
            // btnClearLH
            // 
            this.btnClearLH.Location = new System.Drawing.Point(314, 24);
            this.btnClearLH.Name = "btnClearLH";
            this.btnClearLH.Size = new System.Drawing.Size(75, 23);
            this.btnClearLH.TabIndex = 14;
            this.btnClearLH.Text = "Clear";
            this.btnClearLH.UseVisualStyleBackColor = true;
            this.btnClearLH.Click += new System.EventHandler(this.btnClearLH_Click);
            // 
            // btnSuaLH
            // 
            this.btnSuaLH.Location = new System.Drawing.Point(314, 57);
            this.btnSuaLH.Name = "btnSuaLH";
            this.btnSuaLH.Size = new System.Drawing.Size(75, 23);
            this.btnSuaLH.TabIndex = 14;
            this.btnSuaLH.Text = "Sua";
            this.btnSuaLH.UseVisualStyleBackColor = true;
            this.btnSuaLH.Click += new System.EventHandler(this.btnSuaLH_Click);
            // 
            // btnThemLH
            // 
            this.btnThemLH.Location = new System.Drawing.Point(314, 90);
            this.btnThemLH.Name = "btnThemLH";
            this.btnThemLH.Size = new System.Drawing.Size(75, 23);
            this.btnThemLH.TabIndex = 14;
            this.btnThemLH.Text = "Them";
            this.btnThemLH.UseVisualStyleBackColor = true;
            this.btnThemLH.Click += new System.EventHandler(this.btnThemLH_Click);
            // 
            // txtTenLH
            // 
            this.txtTenLH.Location = new System.Drawing.Point(169, 92);
            this.txtTenLH.Name = "txtTenLH";
            this.txtTenLH.Size = new System.Drawing.Size(100, 20);
            this.txtTenLH.TabIndex = 12;
            // 
            // txtMaLH
            // 
            this.txtMaLH.Location = new System.Drawing.Point(169, 31);
            this.txtMaLH.Name = "txtMaLH";
            this.txtMaLH.Size = new System.Drawing.Size(100, 20);
            this.txtMaLH.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(118, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Ten LH";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(117, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Ma LH";
            // 
            // btnTimLH
            // 
            this.btnTimLH.Location = new System.Drawing.Point(97, 96);
            this.btnTimLH.Name = "btnTimLH";
            this.btnTimLH.Size = new System.Drawing.Size(75, 23);
            this.btnTimLH.TabIndex = 6;
            this.btnTimLH.Text = "Tim";
            this.btnTimLH.UseVisualStyleBackColor = true;
            this.btnTimLH.Click += new System.EventHandler(this.btnTimLH_Click);
            // 
            // txtTimLH
            // 
            this.txtTimLH.Location = new System.Drawing.Point(55, 60);
            this.txtTimLH.Name = "txtTimLH";
            this.txtTimLH.Size = new System.Drawing.Size(167, 20);
            this.txtTimLH.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 359);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLH)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataMH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioTH;
        private System.Windows.Forms.RadioButton radioMH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateNamSX;
        private System.Windows.Forms.DateTimePicker dateHanDung;
        private System.Windows.Forms.Button btnThemMH;
        private System.Windows.Forms.TextBox txtTH;
        private System.Windows.Forms.TextBox txtCty;
        private System.Windows.Forms.TextBox txtMH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimMH;
        private System.Windows.Forms.TextBox txtTimMH;
        private System.Windows.Forms.DataGridView dataLH;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioTenLH;
        private System.Windows.Forms.RadioButton radioMaLH;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnThemLH;
        private System.Windows.Forms.TextBox txtTenLH;
        private System.Windows.Forms.TextBox txtMaLH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnTimLH;
        private System.Windows.Forms.TextBox txtTimLH;
        private System.Windows.Forms.ComboBox cbLH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewButtonColumn Column11;
        private System.Windows.Forms.DataGridViewButtonColumn Column12;
        private System.Windows.Forms.Button btnSuaMH;
        private System.Windows.Forms.Button btnClearMH;
        private System.Windows.Forms.Button btnClearLH;
        private System.Windows.Forms.Button btnSuaLH;
    }
}

