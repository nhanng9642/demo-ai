
namespace DoAn1
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaLH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnLHTim = new System.Windows.Forms.Button();
            this.txtLHTim = new System.Windows.Forms.TextBox();
            this.btnQuayLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLH,
            this.LH,
            this.Xoa});
            this.dataGridView1.Location = new System.Drawing.Point(13, 113);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(537, 300);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // MaLH
            // 
            this.MaLH.DataPropertyName = "MaLH";
            this.MaLH.HeaderText = "Ma LH";
            this.MaLH.MinimumWidth = 8;
            this.MaLH.Name = "MaLH";
            this.MaLH.Width = 150;
            // 
            // LH
            // 
            this.LH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LH.DataPropertyName = "LH";
            this.LH.HeaderText = "Loai Hang";
            this.LH.MinimumWidth = 8;
            this.LH.Name = "LH";
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
            // btnLHTim
            // 
            this.btnLHTim.Location = new System.Drawing.Point(232, 18);
            this.btnLHTim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLHTim.Name = "btnLHTim";
            this.btnLHTim.Size = new System.Drawing.Size(112, 35);
            this.btnLHTim.TabIndex = 1;
            this.btnLHTim.Text = "Tim";
            this.btnLHTim.UseVisualStyleBackColor = true;
            this.btnLHTim.Click += new System.EventHandler(this.btnLHTim_Click);
            // 
            // txtLHTim
            // 
            this.txtLHTim.Location = new System.Drawing.Point(13, 27);
            this.txtLHTim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLHTim.Name = "txtLHTim";
            this.txtLHTim.Size = new System.Drawing.Size(202, 26);
            this.txtLHTim.TabIndex = 2;
            this.txtLHTim.TextChanged += new System.EventHandler(this.txtLHTim_TextChanged);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(232, 68);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(112, 35);
            this.btnQuayLai.TabIndex = 3;
            this.btnQuayLai.Text = "Quay Lai";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 418);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.txtLHTim);
            this.Controls.Add(this.btnLHTim);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLHTim;
        private System.Windows.Forms.TextBox txtLHTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LH;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
        private System.Windows.Forms.Button btnQuayLai;
    }
}