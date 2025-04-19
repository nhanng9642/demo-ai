namespace PROJECT_NMLT
{
    partial class MainFrom
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
            this.label2 = new System.Windows.Forms.Label();
            this.MH_THEMSANPHAM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "                     ";
            // 
            // MH_THEMSANPHAM
            // 
            this.MH_THEMSANPHAM.Location = new System.Drawing.Point(98, 308);
            this.MH_THEMSANPHAM.Name = "MH_THEMSANPHAM";
            this.MH_THEMSANPHAM.Size = new System.Drawing.Size(130, 42);
            this.MH_THEMSANPHAM.TabIndex = 4;
            this.MH_THEMSANPHAM.Text = "THEM SAN PHAM";
            this.MH_THEMSANPHAM.UseVisualStyleBackColor = true;
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MH_THEMSANPHAM);
            this.Controls.Add(this.label2);
            this.Name = "MainFrom";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MH_THEMSANPHAM;
    }
}

