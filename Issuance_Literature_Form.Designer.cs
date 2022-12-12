namespace DB_Lib_project
{
    partial class Issuance_Literature_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Issuance_Literature_Form));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.reader_button = new System.Windows.Forms.Button();
            this.books_button = new System.Windows.Forms.Button();
            this.employee_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.log_out_button = new System.Windows.Forms.Button();
            this.level_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.add_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.sort_button = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.sort_by_cBox = new System.Windows.Forms.ComboBox();
            this.listIssueneBooks = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reader_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.book_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employee_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.issuance_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.return_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reader_phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listIssueneBooks, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1114, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1108, 44);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.reader_button, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.books_button, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.employee_button, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(299, 38);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // reader_button
            // 
            this.reader_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reader_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reader_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reader_button.Location = new System.Drawing.Point(3, 3);
            this.reader_button.Name = "reader_button";
            this.reader_button.Size = new System.Drawing.Size(93, 32);
            this.reader_button.TabIndex = 0;
            this.reader_button.Text = "Читачі";
            this.reader_button.UseVisualStyleBackColor = false;
            this.reader_button.Click += new System.EventHandler(this.reader_button_Click);
            // 
            // books_button
            // 
            this.books_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.books_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.books_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.books_button.Location = new System.Drawing.Point(102, 3);
            this.books_button.Name = "books_button";
            this.books_button.Size = new System.Drawing.Size(93, 32);
            this.books_button.TabIndex = 1;
            this.books_button.Text = "Книги";
            this.books_button.UseVisualStyleBackColor = true;
            this.books_button.Click += new System.EventHandler(this.books_button_Click_1);
            // 
            // employee_button
            // 
            this.employee_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employee_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employee_button.Location = new System.Drawing.Point(201, 3);
            this.employee_button.Name = "employee_button";
            this.employee_button.Size = new System.Drawing.Size(95, 32);
            this.employee_button.TabIndex = 2;
            this.employee_button.Text = "Робітники";
            this.employee_button.UseVisualStyleBackColor = true;
            this.employee_button.Click += new System.EventHandler(this.employee_button_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel7.Controls.Add(this.log_out_button, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.level_label, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.name_label, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel7.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel7.Location = new System.Drawing.Point(592, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(513, 38);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // log_out_button
            // 
            this.log_out_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log_out_button.Location = new System.Drawing.Point(476, 3);
            this.log_out_button.Name = "log_out_button";
            this.log_out_button.Size = new System.Drawing.Size(34, 32);
            this.log_out_button.TabIndex = 0;
            this.log_out_button.UseVisualStyleBackColor = true;
            this.log_out_button.Click += new System.EventHandler(this.log_out_button_Click);
            // 
            // level_label
            // 
            this.level_label.AutoSize = true;
            this.level_label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.level_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.level_label.Location = new System.Drawing.Point(339, 18);
            this.level_label.Name = "level_label";
            this.level_label.Size = new System.Drawing.Size(131, 20);
            this.level_label.TabIndex = 1;
            this.level_label.Text = "Рівень 3";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_label.Location = new System.Drawing.Point(3, 18);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(330, 20);
            this.name_label.TabIndex = 2;
            this.name_label.Text = "П,І,П";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1108, 44);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel5.ColumnCount = 6;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.add_button, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.edit_button, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.delete_button, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.sort_button, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.checkBox1, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.sort_by_cBox, 5, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(548, 38);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // add_button
            // 
            this.add_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_button.Location = new System.Drawing.Point(3, 3);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(34, 32);
            this.add_button.TabIndex = 0;
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edit_button.Location = new System.Drawing.Point(43, 3);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(34, 32);
            this.edit_button.TabIndex = 1;
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete_button.Location = new System.Drawing.Point(83, 3);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(34, 32);
            this.delete_button.TabIndex = 2;
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // sort_button
            // 
            this.sort_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sort_button.Location = new System.Drawing.Point(253, 3);
            this.sort_button.Name = "sort_button";
            this.sort_button.Size = new System.Drawing.Size(34, 32);
            this.sort_button.TabIndex = 3;
            this.sort_button.UseVisualStyleBackColor = true;
            this.sort_button.Click += new System.EventHandler(this.sort_button_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(123, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 32);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Не повернули";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // sort_by_cBox
            // 
            this.sort_by_cBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sort_by_cBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sort_by_cBox.FormattingEnabled = true;
            this.sort_by_cBox.Items.AddRange(new object[] {
            "--Сортувати за--",
            "Датою видачі",
            "Датою повернення"});
            this.sort_by_cBox.Location = new System.Drawing.Point(293, 3);
            this.sort_by_cBox.Name = "sort_by_cBox";
            this.sort_by_cBox.Size = new System.Drawing.Size(252, 24);
            this.sort_by_cBox.TabIndex = 5;
            this.sort_by_cBox.SelectedIndexChanged += new System.EventHandler(this.sort_by_cBox_SelectedIndexChanged);
            // 
            // listIssueneBooks
            // 
            this.listIssueneBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.reader_id,
            this.book_id,
            this.employee_id,
            this.issuance_date,
            this.return_date,
            this.reader_phone});
            this.listIssueneBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listIssueneBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listIssueneBooks.FullRowSelect = true;
            this.listIssueneBooks.HideSelection = false;
            this.listIssueneBooks.Location = new System.Drawing.Point(3, 103);
            this.listIssueneBooks.Name = "listIssueneBooks";
            this.listIssueneBooks.Size = new System.Drawing.Size(1108, 344);
            this.listIssueneBooks.TabIndex = 2;
            this.listIssueneBooks.UseCompatibleStateImageBehavior = false;
            this.listIssueneBooks.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 29;
            // 
            // reader_id
            // 
            this.reader_id.Text = "Читач";
            this.reader_id.Width = 59;
            // 
            // book_id
            // 
            this.book_id.Text = "Книга";
            this.book_id.Width = 59;
            // 
            // employee_id
            // 
            this.employee_id.Text = "Робітник";
            this.employee_id.Width = 59;
            // 
            // issuance_date
            // 
            this.issuance_date.Text = "Дата видачі";
            this.issuance_date.Width = 125;
            // 
            // return_date
            // 
            this.return_date.Text = "Дата повернення";
            this.return_date.Width = 125;
            // 
            // reader_phone
            // 
            this.reader_phone.Text = "Тел. читача";
            this.reader_phone.Width = 108;
            // 
            // Issuance_Literature_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1114, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1130, 489);
            this.Name = "Issuance_Literature_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Видача книг";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Issuance_Literature_Form_FormClosed);
            this.Load += new System.EventHandler(this.Issuance_Literature_Form_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button reader_button;
        private System.Windows.Forms.Button books_button;
        private System.Windows.Forms.Button employee_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button sort_button;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox sort_by_cBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button log_out_button;
        private System.Windows.Forms.Label level_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.ListView listIssueneBooks;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader reader_id;
        private System.Windows.Forms.ColumnHeader book_id;
        private System.Windows.Forms.ColumnHeader employee_id;
        private System.Windows.Forms.ColumnHeader issuance_date;
        private System.Windows.Forms.ColumnHeader return_date;
        private System.Windows.Forms.ColumnHeader reader_phone;
    }
}