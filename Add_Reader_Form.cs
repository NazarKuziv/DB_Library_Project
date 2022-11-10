using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Lib_project
{
    public partial class Add_Reader_Form : Form
    {
        public Add_Reader_Form()
        {
            InitializeComponent();
        }
        string reader_id = null;
        private void Add_Reader_Form_Load(object sender, EventArgs e)
        {
            db.openConnection();
            reader_id = Readers_Form.reader_id;

            if (reader_id != null)
            {
                penalty_nUpDown.Visible = true;

                db.cmd.CommandText = "Select * From readers WHERE reader_id = " + reader_id;
                SqlDataReader reader = db.cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] str = reader["reader_name"].ToString().Split(' ');
                    surname_tb.Text = str[0];
                    name_tb.Text = str[1];
                    middle_name_tb.Text = str[2];
                    address_tb.Text = reader["address"].ToString();
                    phone_tb.Text = reader["phone_number"].ToString();
                    penalty_nUpDown.Value = Convert.ToInt32(reader["penalty"].ToString());
                }
                reader.Close();

            }
        }

        private void Add_Reader_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Readers_Form.reader_id = null;
            db.closeConnection();
            Readers_Form form = new Readers_Form();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (surname_tb.Text == null)
            {
                MessageBox.Show("Зоповніть порожні поля!");
                return;
            }

            if (name_tb.Text == null)
            {
                MessageBox.Show("Зоповніть порожні поля!");
                return;
            }


            if (middle_name_tb.Text == null)
            {
                MessageBox.Show("Зоповніть порожні поля!");
                return;
            }

            if (address_tb.Text == null)
            {
                MessageBox.Show("Зоповніть порожні поля!");
                return;
            }
            if (phone_tb.Text == null)
            {
                MessageBox.Show("Зоповніть порожні поля!");
                return;
            }

            if (phone_tb.Text.Length != 10)
            {
                MessageBox.Show("Номер телефону введено неправильно!");
                return;
            }
            Regex regex = new Regex(@"^[0-9]+$");
            Match x = regex.Match(phone_tb.Text);
            if (x.Success == false)
            {
                MessageBox.Show("Номер телефону введено неправильно!");
                return;
            }






            if (reader_id == null)
            {
                db.cmd.CommandText = "Select * from readers where phone_number = '" + phone_tb.Text + "';";
                SqlDataReader reader = db.cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Читач з таким номером вже є в БД!");
                    reader.Close();
                    return;
                }
                reader.Close();

                string queryString = "Insert into readers ([reader_name],[address],[phone_number],[penalty])" +
                "Values(N'" + surname_tb.Text + " " + name_tb.Text + " " + middle_name_tb.Text + "'," +
                "N'" + address_tb.Text + "'," +
                "N'" + phone_tb.Text + "'," +
                penalty_nUpDown.Value.ToString() +
                ");";

                try
                {
                    db.cmd.CommandText = queryString;
                    db.cmd.ExecuteNonQuery();

                    MessageBox.Show(" " + surname_tb.Text + " додоно до БД");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                string queryString = "UPDATE dbo.readers SET " +
                   "[reader_name] = N'" + surname_tb.Text + " " + name_tb.Text + " " + middle_name_tb.Text + "'," +
                   "[address] = N'" + address_tb.Text + "'," +
                   "[phone_number] = N'" + phone_tb.Text + "'," +
                   "[penalty] = " + penalty_nUpDown.Value.ToString() + " WHERE reader_id = " + reader_id;

                try
                {
                    db.cmd.CommandText = queryString;
                    db.cmd.ExecuteNonQuery();
                    MessageBox.Show(" " + surname_tb.Text + " оновдено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            surname_tb.Text = "";
            name_tb.Text = "";
            middle_name_tb.Text = "";
            address_tb.Text = "";
            phone_tb.Text = "";
            penalty_nUpDown.Value = 0;
        }
    }
}
