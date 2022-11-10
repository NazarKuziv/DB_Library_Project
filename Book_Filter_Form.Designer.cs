namespace DB_Lib_project
{
    partial class Book_Filter_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_Filter_Form));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.date_from = new System.Windows.Forms.DateTimePicker();
            this.date_to = new System.Windows.Forms.DateTimePicker();
            this.in_stock_Check = new System.Windows.Forms.CheckBox();
            this.publisher_cBox = new System.Windows.Forms.ComboBox();
            this.authorListBox = new System.Windows.Forms.CheckedListBox();
            this.genreListBox = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.date_from, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.date_to, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.in_stock_Check, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.publisher_cBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.authorListBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.genreListBox, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(362, 381);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 123);
            this.label1.TabIndex = 0;
            this.label1.Text = "Автори";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 123);
            this.label2.TabIndex = 1;
            this.label2.Text = "Жанри";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Видавництво";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Видано від";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Видано до";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Є в наявності";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // date_from
            // 
            this.date_from.Checked = false;
            this.date_from.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_from.Location = new System.Drawing.Point(184, 275);
            this.date_from.Name = "date_from";
            this.date_from.Size = new System.Drawing.Size(175, 22);
            this.date_from.TabIndex = 7;
            // 
            // date_to
            // 
            this.date_to.Checked = false;
            this.date_to.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_to.Location = new System.Drawing.Point(184, 301);
            this.date_to.Name = "date_to";
            this.date_to.Size = new System.Drawing.Size(175, 22);
            this.date_to.TabIndex = 8;
            // 
            // in_stock_Check
            // 
            this.in_stock_Check.AutoSize = true;
            this.in_stock_Check.Dock = System.Windows.Forms.DockStyle.Fill;
            this.in_stock_Check.Location = new System.Drawing.Point(184, 327);
            this.in_stock_Check.Name = "in_stock_Check";
            this.in_stock_Check.Size = new System.Drawing.Size(175, 20);
            this.in_stock_Check.TabIndex = 9;
            this.in_stock_Check.Text = "Є в наявності";
            this.in_stock_Check.UseVisualStyleBackColor = true;
            // 
            // publisher_cBox
            // 
            this.publisher_cBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.publisher_cBox.FormattingEnabled = true;
            this.publisher_cBox.Location = new System.Drawing.Point(184, 249);
            this.publisher_cBox.Name = "publisher_cBox";
            this.publisher_cBox.Size = new System.Drawing.Size(175, 24);
            this.publisher_cBox.TabIndex = 10;
            this.publisher_cBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.publisher_cBox_KeyPress);
            // 
            // authorListBox
            // 
            this.authorListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorListBox.FormattingEnabled = true;
            this.authorListBox.Location = new System.Drawing.Point(184, 3);
            this.authorListBox.Name = "authorListBox";
            this.authorListBox.Size = new System.Drawing.Size(175, 117);
            this.authorListBox.TabIndex = 11;
            // 
            // genreListBox
            // 
            this.genreListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genreListBox.FormattingEnabled = true;
            this.genreListBox.Location = new System.Drawing.Point(184, 126);
            this.genreListBox.Name = "genreListBox";
            this.genreListBox.Size = new System.Drawing.Size(175, 117);
            this.genreListBox.TabIndex = 12;
            // 
            // Book_Filter_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 381);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(378, 420);
            this.MinimumSize = new System.Drawing.Size(378, 420);
            this.Name = "Book_Filter_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фільтр";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Book_Filter_Form_FormClosed);
            this.Load += new System.EventHandler(this.Book_Filter_Form_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker date_from;
        private System.Windows.Forms.DateTimePicker date_to;
        private System.Windows.Forms.CheckBox in_stock_Check;
        private System.Windows.Forms.ComboBox publisher_cBox;
        private System.Windows.Forms.CheckedListBox authorListBox;
        private System.Windows.Forms.CheckedListBox genreListBox;
    }
}