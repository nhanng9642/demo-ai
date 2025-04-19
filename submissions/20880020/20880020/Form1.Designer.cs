namespace _20880020
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
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Item = new System.Windows.Forms.TabPage();
            this.findItem = new System.Windows.Forms.TextBox();
            this.findBtn = new System.Windows.Forms.Button();
            this.listViewItem = new System.Windows.Forms.ListView();
            this.Category = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.findBtnCtg = new System.Windows.Forms.Button();
            this.listViewCtg = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editBtnCtg = new System.Windows.Forms.Button();
            this.addBtnCtg = new System.Windows.Forms.Button();
            this.delBtnCtg = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.Item.SuspendLayout();
            this.Category.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(19, 21);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(100, 21);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(181, 21);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 5;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Item);
            this.tabControl.Controls.Add(this.Category);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(604, 315);
            this.tabControl.TabIndex = 6;
            // 
            // Item
            // 
            this.Item.Controls.Add(this.findItem);
            this.Item.Controls.Add(this.findBtn);
            this.Item.Controls.Add(this.listViewItem);
            this.Item.Controls.Add(this.editBtn);
            this.Item.Controls.Add(this.addBtn);
            this.Item.Controls.Add(this.deleteBtn);
            this.Item.Location = new System.Drawing.Point(4, 22);
            this.Item.Name = "Item";
            this.Item.Padding = new System.Windows.Forms.Padding(3);
            this.Item.Size = new System.Drawing.Size(596, 289);
            this.Item.TabIndex = 0;
            this.Item.Text = "Item";
            this.Item.UseVisualStyleBackColor = true;
            this.Item.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // findItem
            // 
            this.findItem.Location = new System.Drawing.Point(272, 23);
            this.findItem.Name = "findItem";
            this.findItem.Size = new System.Drawing.Size(223, 20);
            this.findItem.TabIndex = 8;
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(501, 21);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(75, 23);
            this.findBtn.TabIndex = 7;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // listViewItem
            // 
            this.listViewItem.CheckBoxes = true;
            this.listViewItem.HideSelection = false;
            this.listViewItem.Location = new System.Drawing.Point(19, 64);
            this.listViewItem.Name = "listViewItem";
            this.listViewItem.Size = new System.Drawing.Size(557, 207);
            this.listViewItem.TabIndex = 6;
            this.listViewItem.UseCompatibleStateImageBehavior = false;
            this.listViewItem.View = System.Windows.Forms.View.Details;
            this.listViewItem.SelectedIndexChanged += new System.EventHandler(this.listViewItem_SelectedIndexChanged_1);
            // 
            // Category
            // 
            this.Category.Controls.Add(this.label1);
            this.Category.Controls.Add(this.textBox1);
            this.Category.Controls.Add(this.findBtnCtg);
            this.Category.Controls.Add(this.listViewCtg);
            this.Category.Controls.Add(this.editBtnCtg);
            this.Category.Controls.Add(this.addBtnCtg);
            this.Category.Controls.Add(this.delBtnCtg);
            this.Category.Location = new System.Drawing.Point(4, 22);
            this.Category.Name = "Category";
            this.Category.Padding = new System.Windows.Forms.Padding(3);
            this.Category.Size = new System.Drawing.Size(596, 289);
            this.Category.TabIndex = 1;
            this.Category.Text = "Category";
            this.Category.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Type here to add, edit and find:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 20);
            this.textBox1.TabIndex = 11;
            // 
            // findBtnCtg
            // 
            this.findBtnCtg.Location = new System.Drawing.Point(502, 34);
            this.findBtnCtg.Name = "findBtnCtg";
            this.findBtnCtg.Size = new System.Drawing.Size(75, 23);
            this.findBtnCtg.TabIndex = 10;
            this.findBtnCtg.Text = "Find";
            this.findBtnCtg.UseVisualStyleBackColor = true;
            this.findBtnCtg.Click += new System.EventHandler(this.findBtnCtg_Click);
            // 
            // listViewCtg
            // 
            this.listViewCtg.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewCtg.HideSelection = false;
            this.listViewCtg.Location = new System.Drawing.Point(18, 77);
            this.listViewCtg.Name = "listViewCtg";
            this.listViewCtg.Size = new System.Drawing.Size(559, 195);
            this.listViewCtg.TabIndex = 9;
            this.listViewCtg.UseCompatibleStateImageBehavior = false;
            this.listViewCtg.SelectedIndexChanged += new System.EventHandler(this.listViewCtg_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Expiry Date";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Company";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Manufacture Year";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Category";
            // 
            // editBtnCtg
            // 
            this.editBtnCtg.Location = new System.Drawing.Point(180, 34);
            this.editBtnCtg.Name = "editBtnCtg";
            this.editBtnCtg.Size = new System.Drawing.Size(75, 23);
            this.editBtnCtg.TabIndex = 8;
            this.editBtnCtg.Text = "Edit";
            this.editBtnCtg.UseVisualStyleBackColor = true;
            this.editBtnCtg.Click += new System.EventHandler(this.editBtnCtg_Click);
            // 
            // addBtnCtg
            // 
            this.addBtnCtg.Location = new System.Drawing.Point(18, 34);
            this.addBtnCtg.Name = "addBtnCtg";
            this.addBtnCtg.Size = new System.Drawing.Size(75, 23);
            this.addBtnCtg.TabIndex = 6;
            this.addBtnCtg.Text = "Add";
            this.addBtnCtg.UseVisualStyleBackColor = true;
            this.addBtnCtg.Click += new System.EventHandler(this.addBtnCtg_Click);
            // 
            // delBtnCtg
            // 
            this.delBtnCtg.Location = new System.Drawing.Point(99, 34);
            this.delBtnCtg.Name = "delBtnCtg";
            this.delBtnCtg.Size = new System.Drawing.Size(75, 23);
            this.delBtnCtg.TabIndex = 7;
            this.delBtnCtg.Text = "Delete";
            this.delBtnCtg.UseVisualStyleBackColor = true;
            this.delBtnCtg.Click += new System.EventHandler(this.delBtnCtg_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(12, 344);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(599, 34);
            this.resetBtn.TabIndex = 7;
            this.resetBtn.TabStop = false;
            this.resetBtn.Text = "Reset";
            this.resetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 390);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.Item.ResumeLayout(false);
            this.Item.PerformLayout();
            this.Category.ResumeLayout(false);
            this.Category.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TabPage Item;
        private System.Windows.Forms.TabPage Category;
        public System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ListView listViewCtg;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button editBtnCtg;
        private System.Windows.Forms.Button addBtnCtg;
        private System.Windows.Forms.Button delBtnCtg;
        private System.Windows.Forms.ListView listViewItem;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.TextBox findItem;
        private System.Windows.Forms.Button findBtnCtg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label label1;
    }
}

