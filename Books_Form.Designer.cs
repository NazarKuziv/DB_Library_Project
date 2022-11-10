using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_Lib_project
{
    partial class Books_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books_Form));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.search_Icon = new System.Windows.Forms.PictureBox();
            this.search_cBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.back_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.filter_button = new System.Windows.Forms.Button();
            this.sort_button = new System.Windows.Forms.Button();
            this.sort_by_cBox = new System.Windows.Forms.ComboBox();
            this.listBooks = new System.Windows.Forms.ListView();
            this.book_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.publisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.language = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.publish_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.num_of_cop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.In_stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_Icon)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBooks, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1584, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1578, 44);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.Controls.Add(this.search_Icon, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.search_cBox, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(792, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(783, 38);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // search_Icon
            // 
            this.search_Icon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_Icon.Location = new System.Drawing.Point(746, 3);
            this.search_Icon.MaximumSize = new System.Drawing.Size(34, 32);
            this.search_Icon.Name = "search_Icon";
            this.search_Icon.Size = new System.Drawing.Size(34, 32);
            this.search_Icon.TabIndex = 7;
            this.search_Icon.TabStop = false;
            // 
            // search_cBox
            // 
            this.search_cBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_cBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_cBox.FormattingEnabled = true;
            this.search_cBox.Location = new System.Drawing.Point(3, 3);
            this.search_cBox.Name = "search_cBox";
            this.search_cBox.Size = new System.Drawing.Size(737, 24);
            this.search_cBox.TabIndex = 0;
            this.search_cBox.SelectedIndexChanged += new System.EventHandler(this.search_cBox_SelectedIndexChanged);
            this.search_cBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.search_cBox_KeyUp);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.back_button, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.add_button, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.edit_button, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.delete_button, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.filter_button, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.sort_button, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.sort_by_cBox, 6, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(783, 38);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // back_button
            // 
            this.back_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back_button.Location = new System.Drawing.Point(3, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(34, 32);
            this.back_button.TabIndex = 0;
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // add_button
            // 
            this.add_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_button.Location = new System.Drawing.Point(43, 3);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(34, 32);
            this.add_button.TabIndex = 1;
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edit_button.Location = new System.Drawing.Point(83, 3);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(34, 32);
            this.edit_button.TabIndex = 2;
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete_button.Location = new System.Drawing.Point(123, 3);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(34, 32);
            this.delete_button.TabIndex = 3;
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // filter_button
            // 
            this.filter_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filter_button.Location = new System.Drawing.Point(163, 3);
            this.filter_button.Name = "filter_button";
            this.filter_button.Size = new System.Drawing.Size(34, 32);
            this.filter_button.TabIndex = 4;
            this.filter_button.UseVisualStyleBackColor = true;
            this.filter_button.Click += new System.EventHandler(this.filter_button_Click);
            // 
            // sort_button
            // 
            this.sort_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sort_button.Location = new System.Drawing.Point(203, 3);
            this.sort_button.Name = "sort_button";
            this.sort_button.Size = new System.Drawing.Size(34, 32);
            this.sort_button.TabIndex = 5;
            this.sort_button.UseVisualStyleBackColor = true;
            this.sort_button.Click += new System.EventHandler(this.sort_button_Click);
            // 
            // sort_by_cBox
            // 
            this.sort_by_cBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sort_by_cBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sort_by_cBox.FormattingEnabled = true;
            this.sort_by_cBox.Items.AddRange(new object[] {
            "--Сортувати за--",
            "Назвою",
            "Автором",
            "Жанром",
            "Видавництвом",
            "Датою пуплікації",
            "Кількістю",
            "Кількістю в наявності"});
            this.sort_by_cBox.Location = new System.Drawing.Point(243, 3);
            this.sort_by_cBox.Name = "sort_by_cBox";
            this.sort_by_cBox.Size = new System.Drawing.Size(537, 24);
            this.sort_by_cBox.TabIndex = 6;
            this.sort_by_cBox.SelectedIndexChanged += new System.EventHandler(this.sort_by_cBox_SelectedIndexChanged);
            // 
            // listBooks
            // 
            this.listBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.book_id,
            this.title,
            this.author,
            this.genres,
            this.publisher,
            this.language,
            this.publish_date,
            this.num_of_cop,
            this.In_stock});
            this.listBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBooks.FullRowSelect = true;
            this.listBooks.HideSelection = false;
            this.listBooks.Location = new System.Drawing.Point(3, 53);
            this.listBooks.Name = "listBooks";
            this.listBooks.Size = new System.Drawing.Size(1578, 405);
            this.listBooks.TabIndex = 1;
            this.listBooks.UseCompatibleStateImageBehavior = false;
            this.listBooks.View = System.Windows.Forms.View.Details;
            this.listBooks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBooks_MouseDoubleClick);
            // 
            // book_id
            // 
            this.book_id.Text = "ID";
            this.book_id.Width = 29;
            // 
            // title
            // 
            this.title.Text = "Назва";
            this.title.Width = 59;
            // 
            // author
            // 
            this.author.Text = "Автор";
            this.author.Width = 59;
            // 
            // genres
            // 
            this.genres.Text = "Жанри";
            this.genres.Width = 61;
            // 
            // publisher
            // 
            this.publisher.Text = "Видавництво";
            this.publisher.Width = 115;
            // 
            // language
            // 
            this.language.Text = "Мова";
            // 
            // publish_date
            // 
            this.publish_date.Text = "Дата публікації";
            this.publish_date.Width = 125;
            // 
            // num_of_cop
            // 
            this.num_of_cop.Text = "Кількість";
            this.num_of_cop.Width = 81;
            // 
            // In_stock
            // 
            this.In_stock.Text = "Є в наявності";
            this.In_stock.Width = 124;
            // 
            // Books_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1600, 500);
            this.Name = "Books_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталог книг";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Books_Form_FormClosed);
            this.Load += new System.EventHandler(this.Books_Form_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.search_Icon)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listBooks;
        private System.Windows.Forms.ColumnHeader book_id;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.ColumnHeader genres;
        private System.Windows.Forms.ColumnHeader publisher;
        private System.Windows.Forms.ColumnHeader publish_date;
        private System.Windows.Forms.ColumnHeader num_of_cop;
        private System.Windows.Forms.ColumnHeader In_stock;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button filter_button;
        private System.Windows.Forms.Button sort_button;
        private System.Windows.Forms.ComboBox sort_by_cBox;
        private TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox search_cBox;
        private PictureBox search_Icon;
        private ColumnHeader language;
    }
}

