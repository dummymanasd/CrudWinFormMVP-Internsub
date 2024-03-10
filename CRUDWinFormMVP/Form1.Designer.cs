namespace CRUDWinFormMVP
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
        public void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.productIDlbl = new System.Windows.Forms.Label();
            this.ItemNamelbl = new System.Windows.Forms.Label();
            this.Designlbl = new System.Windows.Forms.Label();
            this.colorlbl = new System.Windows.Forms.Label();
            this.pIDtbox = new System.Windows.Forms.TextBox();
            this.itemNametbox = new System.Windows.Forms.TextBox();
            this.designtbox = new System.Windows.Forms.TextBox();
            this.colorCombobox = new System.Windows.Forms.ComboBox();
            this.insertbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Management";
            // 
            // productIDlbl
            // 
            this.productIDlbl.AutoSize = true;
            this.productIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDlbl.Location = new System.Drawing.Point(50, 62);
            this.productIDlbl.Name = "productIDlbl";
            this.productIDlbl.Size = new System.Drawing.Size(105, 20);
            this.productIDlbl.TabIndex = 1;
            this.productIDlbl.Text = "Product ID:";
            // 
            // ItemNamelbl
            // 
            this.ItemNamelbl.AutoSize = true;
            this.ItemNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNamelbl.Location = new System.Drawing.Point(50, 110);
            this.ItemNamelbl.Name = "ItemNamelbl";
            this.ItemNamelbl.Size = new System.Drawing.Size(105, 20);
            this.ItemNamelbl.TabIndex = 2;
            this.ItemNamelbl.Text = "Item Name:";
            // 
            // Designlbl
            // 
            this.Designlbl.AutoSize = true;
            this.Designlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Designlbl.Location = new System.Drawing.Point(50, 158);
            this.Designlbl.Name = "Designlbl";
            this.Designlbl.Size = new System.Drawing.Size(74, 20);
            this.Designlbl.TabIndex = 3;
            this.Designlbl.Text = "Design:";
            // 
            // colorlbl
            // 
            this.colorlbl.AutoSize = true;
            this.colorlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorlbl.Location = new System.Drawing.Point(50, 196);
            this.colorlbl.Name = "colorlbl";
            this.colorlbl.Size = new System.Drawing.Size(60, 20);
            this.colorlbl.TabIndex = 4;
            this.colorlbl.Text = "Color:";
            // 
            // pIDtbox
            // 
            this.pIDtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pIDtbox.Location = new System.Drawing.Point(179, 60);
            this.pIDtbox.Name = "pIDtbox";
            this.pIDtbox.Size = new System.Drawing.Size(362, 26);
            this.pIDtbox.TabIndex = 5;
            // 
            // itemNametbox
            // 
            this.itemNametbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNametbox.Location = new System.Drawing.Point(179, 104);
            this.itemNametbox.Name = "itemNametbox";
            this.itemNametbox.Size = new System.Drawing.Size(362, 26);
            this.itemNametbox.TabIndex = 6;
            // 
            // designtbox
            // 
            this.designtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designtbox.Location = new System.Drawing.Point(179, 151);
            this.designtbox.Name = "designtbox";
            this.designtbox.Size = new System.Drawing.Size(362, 26);
            this.designtbox.TabIndex = 7;
            // 
            // colorCombobox
            // 
            this.colorCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorCombobox.FormattingEnabled = true;
            this.colorCombobox.Items.AddRange(new object[] { "Blue ", "Green", "Red", "Yellow", "White", "Orange", "Black" });
            this.colorCombobox.Location = new System.Drawing.Point(179, 191);
            this.colorCombobox.Name = "colorCombobox";
            this.colorCombobox.Size = new System.Drawing.Size(362, 28);
            this.colorCombobox.TabIndex = 8;
            // 
            // insertbtn
            // 
            this.insertbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertbtn.Location = new System.Drawing.Point(179, 284);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(102, 37);
            this.insertbtn.TabIndex = 9;
            this.insertbtn.Text = "Insert";
            this.insertbtn.UseVisualStyleBackColor = true;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 338);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(787, 195);
            this.dataGridView1.TabIndex = 10;
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(310, 284);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(102, 37);
            this.updateBtn.TabIndex = 11;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(179, 237);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(362, 28);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(439, 284);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(102, 37);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(583, 49);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(102, 37);
            this.searchBtn.TabIndex = 15;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.insertbtn);
            this.Controls.Add(this.colorCombobox);
            this.Controls.Add(this.designtbox);
            this.Controls.Add(this.itemNametbox);
            this.Controls.Add(this.pIDtbox);
            this.Controls.Add(this.colorlbl);
            this.Controls.Add(this.Designlbl);
            this.Controls.Add(this.ItemNamelbl);
            this.Controls.Add(this.productIDlbl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public System.Windows.Forms.Button searchBtn;

        private System.Windows.Forms.Button deleteBtn;

        public System.Windows.Forms.DateTimePicker dateTimePicker1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button updateBtn;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label productIDlbl;
        private System.Windows.Forms.Label ItemNamelbl;
        private System.Windows.Forms.Label Designlbl;
        private System.Windows.Forms.Label colorlbl;
        public System.Windows.Forms.TextBox pIDtbox;
        public System.Windows.Forms.TextBox itemNametbox;
        public System.Windows.Forms.TextBox designtbox;
        public System.Windows.Forms.ComboBox colorCombobox;
        private System.Windows.Forms.Button insertbtn;
        public System.Windows.Forms.DataGridView dataGridView1;
    
    }
}