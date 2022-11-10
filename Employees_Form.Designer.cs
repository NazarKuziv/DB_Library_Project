namespace DB_Lib_project
{
    partial class Employees_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees_Form));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.First = new System.Windows.Forms.Button();
            this.Prev = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Last = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.employee_nameTextBox = new System.Windows.Forms.TextBox();
            this.phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.levelTextBox = new System.Windows.Forms.TextBox();
            this.load_photo = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 235);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(473, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Controls.Add(this.First, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Prev, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Next, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Last, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.Add, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.Edit, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.Delete, 6, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(279, 40);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // First
            // 
            this.First.Dock = System.Windows.Forms.DockStyle.Fill;
            this.First.Location = new System.Drawing.Point(4, 4);
            this.First.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(32, 32);
            this.First.TabIndex = 0;
            this.First.UseVisualStyleBackColor = true;
            this.First.Click += new System.EventHandler(this.First_Click);
            // 
            // Prev
            // 
            this.Prev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Prev.Location = new System.Drawing.Point(44, 4);
            this.Prev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(32, 32);
            this.Prev.TabIndex = 1;
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // Next
            // 
            this.Next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Next.Location = new System.Drawing.Point(84, 4);
            this.Next.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(32, 32);
            this.Next.TabIndex = 2;
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Last
            // 
            this.Last.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Last.Location = new System.Drawing.Point(124, 4);
            this.Last.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Last.Name = "Last";
            this.Last.Size = new System.Drawing.Size(32, 32);
            this.Last.TabIndex = 3;
            this.Last.UseVisualStyleBackColor = true;
            this.Last.Click += new System.EventHandler(this.Last_Click);
            // 
            // Add
            // 
            this.Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add.Location = new System.Drawing.Point(164, 4);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(32, 32);
            this.Add.TabIndex = 4;
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Edit
            // 
            this.Edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Edit.Location = new System.Drawing.Point(204, 4);
            this.Edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(32, 32);
            this.Edit.TabIndex = 5;
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Delete.Location = new System.Drawing.Point(244, 4);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(32, 32);
            this.Delete.TabIndex = 6;
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фото";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "П.І.П";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Асреса";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Номер тел.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Рівень";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Пароль";
            this.label7.Visible = false;
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(266, 26);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(195, 22);
            this.idTextBox.TabIndex = 9;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Enabled = false;
            this.addressTextBox.Location = new System.Drawing.Point(266, 83);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(195, 22);
            this.addressTextBox.TabIndex = 10;
            // 
            // employee_nameTextBox
            // 
            this.employee_nameTextBox.Enabled = false;
            this.employee_nameTextBox.Location = new System.Drawing.Point(266, 55);
            this.employee_nameTextBox.Name = "employee_nameTextBox";
            this.employee_nameTextBox.Size = new System.Drawing.Size(195, 22);
            this.employee_nameTextBox.TabIndex = 11;
            // 
            // phone_numberTextBox
            // 
            this.phone_numberTextBox.Enabled = false;
            this.phone_numberTextBox.Location = new System.Drawing.Point(266, 110);
            this.phone_numberTextBox.Name = "phone_numberTextBox";
            this.phone_numberTextBox.Size = new System.Drawing.Size(195, 22);
            this.phone_numberTextBox.TabIndex = 12;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(266, 170);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(195, 22);
            this.passwordTextBox.TabIndex = 13;
            this.passwordTextBox.Visible = false;
            // 
            // levelTextBox
            // 
            this.levelTextBox.Enabled = false;
            this.levelTextBox.Location = new System.Drawing.Point(266, 140);
            this.levelTextBox.Name = "levelTextBox";
            this.levelTextBox.Size = new System.Drawing.Size(195, 22);
            this.levelTextBox.TabIndex = 14;
            // 
            // load_photo
            // 
            this.load_photo.Location = new System.Drawing.Point(8, 205);
            this.load_photo.Name = "load_photo";
            this.load_photo.Size = new System.Drawing.Size(152, 23);
            this.load_photo.TabIndex = 15;
            this.load_photo.Text = "Вибрати фото";
            this.load_photo.UseVisualStyleBackColor = true;
            this.load_photo.Visible = false;
            this.load_photo.Click += new System.EventHandler(this.load_photo_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(168, 205);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 16;
            this.ok.Text = "ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Visible = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.Location = new System.Drawing.Point(8, 28);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(152, 171);
            this.photoPictureBox.TabIndex = 2;
            this.photoPictureBox.TabStop = false;
            // 
            // Employees_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 285);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.load_photo);
            this.Controls.Add(this.levelTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.phone_numberTextBox);
            this.Controls.Add(this.employee_nameTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Employees_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Робітники";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Employees_Form_FormClosed);
            this.Load += new System.EventHandler(this.Employees_Form_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button First;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Last;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox employee_nameTextBox;
        private System.Windows.Forms.TextBox phone_numberTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox levelTextBox;
        private System.Windows.Forms.Button load_photo;
        private System.Windows.Forms.Button ok;
    }
}