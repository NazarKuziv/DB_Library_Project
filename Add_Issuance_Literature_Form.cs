using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Lib_project
{
    public partial class Add_Issuance_Literature_Form : Form
    {
        public Add_Issuance_Literature_Form()
        {
            InitializeComponent();
        }

        public static int level;
        public string id =null;

        private void Add_Issuance_Literature_Form_Load(object sender, EventArgs e)
        {
            db.openConnection();
            employee_tb.Text = Issuance_Literature_Form.name;
            level = Issuance_Literature_Form.level;
            id = Issuance_Literature_Form.i_id;

           

            if (id != null)
            {
                add_book_button.Enabled = false;
                add_reader_button.Enabled = false;
                label5.Visible = true;
                return_date.Visible = true;
                return_date.Checked = true;

                db.cmd.CommandText = "select  issuance_literature.id as id, readers.reader_id as reader_id,reader_name," +
                "readers.phone_number as phone_number,books.book_id as book_id,title,employees.id as e_id,employee_name," +
                "issuance_date,return_date from issuance_literature " +
                "inner join readers on issuance_literature.reader_id = readers.reader_id " +
                "inner join books on issuance_literature.book_id = books.book_id " +
                "inner join employees on issuance_literature.employee_id = employees.id WHERE issuance_literature.id = " + id;


                SqlDataReader reader = db.cmd.ExecuteReader();
                reader.Read();
                reader_tb.Text = reader["reader_id"].ToString() + "." + reader["reader_name"];
                book_tb.Text = reader["book_id"].ToString() + "." + reader["title"].ToString();
                employee_tb.Text = reader["e_id"].ToString() + "." + reader["employee_name"].ToString();
                issuance_date.Value = Convert.ToDateTime(reader["issuance_date"]);
                return_date.Value = reader["return_date"] == DBNull.Value? DateTime.Now : Convert.ToDateTime(reader["return_date"]);
                reader.Close();
                if(return_date.Value != DateTime.Now)
                {
                    ok_button.Enabled = false;
                }
                
            }

        }

        public void Set_book(string book)
        {
            book_tb.Text = book;
        }
        public void Set_reader(string reader)
        {
            reader_tb.Text = reader;
        }

        private void Add_Issuance_Literature_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Issuance_Literature_Form.i_id = null;
            if (System.Windows.Forms.Application.OpenForms["Issuance_Literature_Form"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["Issuance_Literature_Form"] as Issuance_Literature_Form).Show();
                (System.Windows.Forms.Application.OpenForms["Issuance_Literature_Form"] as Issuance_Literature_Form).Update_ListView("select  issuance_literature.id as id, readers.reader_id as reader_id,reader_name," +
              "readers.phone_number as phone_number,books.book_id as book_id,title,employees.id as e_id,employee_name," +
              "issuance_date,return_date from issuance_literature " +
              "inner join readers on issuance_literature.reader_id = readers.reader_id " +
              "inner join books on issuance_literature.book_id = books.book_id " +
              "inner join employees on issuance_literature.employee_id = employees.id ");

            }

        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if(reader_tb.Text == "")
            {
                MessageBox.Show("Заповніть порожні поля");
                return;
            }
            if (book_tb.Text == "")
            {
                MessageBox.Show("Заповніть порожні поля");
                return;
            }

            string[] reader= reader_tb.Text.Split('.');
            string[] book = book_tb.Text.Split('.');
            string[] employee = employee_tb.Text.Split('.');
            string i_date ="'"+ String.Format("{0:dd/MM/yyyy}", issuance_date.Value)+"'";
            string r_date = return_date.Created == true? "'"+String.Format("{0:dd/MM/yyyy}", return_date.Value) + "'" : "NULL";

            if (id == null)
            {
                string queryString = "Insert into issuance_literature ([reader_id],[book_id],[employee_id],[issuance_date],[return_date])" +
                "Values(" + reader[0] + "," +
                  book[0] + "," +
                  employee[0] + "," +
                  i_date + "," +
                  r_date + ");";

                try
                {
                    db.cmd.CommandText = queryString;
                    db.cmd.ExecuteNonQuery();
                    MessageBox.Show("Додано до БД ");

                    db.cmd.CommandText = "UPDATE dbo.books SET " +
                    "[in_stock] = in_stock-1 WHERE book_id = " + book[0]; 
                    db.cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                string queryString = "UPDATE dbo.issuance_literature SET " +
                  "[return_date] = " + r_date + " WHERE id = " + id;

                try
                {
                    db.cmd.CommandText = queryString;
                    db.cmd.ExecuteNonQuery();
                    MessageBox.Show(" БД оновдено");

                    db.cmd.CommandText = "UPDATE dbo.books SET " +
                   "[in_stock] = in_stock+1 WHERE book_id = " + book[0];
                    db.cmd.ExecuteNonQuery();

                    if (issuance_date.Value.AddMonths(2) < return_date.Value)
                    {
                        db.cmd.CommandText = "UPDATE dbo.readers SET " +
                        "[penalty] = penalty+1 WHERE reader_id = " + book[0];
                        db.cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            reader_tb.Text = "";
            book_tb.Text = "";
        }

        private void add_book_button_Click(object sender, EventArgs e)
        {
            db.closeConnection();
            Books_Form books_form = new Books_Form();
            this.Hide();
            books_form.ShowDialog();
        }

        private void add_reader_button_Click(object sender, EventArgs e)
        {
            db.closeConnection();
            Readers_Form reader_form = new Readers_Form();
            this.Hide();
            reader_form.ShowDialog();
        }
    }
}
