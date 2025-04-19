namespace _20880020
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
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelExpDate = new System.Windows.Forms.Label();
            this.textBoxExpDate = new System.Windows.Forms.TextBox();
            this.labelCompany = new System.Windows.Forms.Label();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMfYear = new System.Windows.Forms.TextBox();
            this.labelCtg = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.ctgBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(150, 25);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(252, 20);
            this.textBoxID.TabIndex = 0;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(15, 28);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID";
            this.labelID.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(15, 70);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(150, 67);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(252, 20);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelExpDate
            // 
            this.labelExpDate.AutoSize = true;
            this.labelExpDate.Location = new System.Drawing.Point(15, 115);
            this.labelExpDate.Name = "labelExpDate";
            this.labelExpDate.Size = new System.Drawing.Size(61, 13);
            this.labelExpDate.TabIndex = 5;
            this.labelExpDate.Text = "Expiry Date";
            // 
            // textBoxExpDate
            // 
            this.textBoxExpDate.Location = new System.Drawing.Point(150, 112);
            this.textBoxExpDate.Name = "textBoxExpDate";
            this.textBoxExpDate.Size = new System.Drawing.Size(252, 20);
            this.textBoxExpDate.TabIndex = 4;
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Location = new System.Drawing.Point(15, 160);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(51, 13);
            this.labelCompany.TabIndex = 7;
            this.labelCompany.Text = "Company";
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.Location = new System.Drawing.Point(150, 157);
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.Size = new System.Drawing.Size(252, 20);
            this.textBoxCompany.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Manufacture Year";
            // 
            // textBoxMfYear
            // 
            this.textBoxMfYear.Location = new System.Drawing.Point(150, 204);
            this.textBoxMfYear.Name = "textBoxMfYear";
            this.textBoxMfYear.Size = new System.Drawing.Size(252, 20);
            this.textBoxMfYear.TabIndex = 8;
            // 
            // labelCtg
            // 
            this.labelCtg.AutoSize = true;
            this.labelCtg.Location = new System.Drawing.Point(15, 250);
            this.labelCtg.Name = "labelCtg";
            this.labelCtg.Size = new System.Drawing.Size(49, 13);
            this.labelCtg.TabIndex = 11;
            this.labelCtg.Text = "Category";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(443, 204);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 12;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(443, 245);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // ctgBox
            // 
            this.ctgBox.FormattingEnabled = true;
            this.ctgBox.Location = new System.Drawing.Point(150, 250);
            this.ctgBox.Name = "ctgBox";
            this.ctgBox.Size = new System.Drawing.Size(252, 21);
            this.ctgBox.TabIndex = 14;
            this.ctgBox.SelectedIndexChanged += new System.EventHandler(this.ctgBox_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 292);
            this.Controls.Add(this.ctgBox);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelCtg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMfYear);
            this.Controls.Add(this.labelCompany);
            this.Controls.Add(this.textBoxCompany);
            this.Controls.Add(this.labelExpDate);
            this.Controls.Add(this.textBoxExpDate);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxID);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelExpDate;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCtg;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.TextBox textBoxID;
        public System.Windows.Forms.TextBox textBoxExpDate;
        public System.Windows.Forms.TextBox textBoxCompany;
        public System.Windows.Forms.TextBox textBoxMfYear;
        public System.Windows.Forms.TextBox textBoxName;
        public System.Windows.Forms.ComboBox ctgBox;
    }
}