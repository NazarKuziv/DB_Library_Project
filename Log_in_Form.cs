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
    public partial class Log_in_Form : Form
    {
        public Log_in_Form()
        {
            InitializeComponent();
        }
        public static string employee_name=null;
        public static int level;
        private void Log_in_Form_Load(object sender, EventArgs e)
        {
            db.openConnection();
            //employee_name = "9.Струкевич Ілля Владиславович";
            //level = 3;

        }

        private void Log_in_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (num_tb.Text == "")
            {
                MessageBox.Show("Заповніть порожні поля");
                return;
            }
            if (password_tb.Text == "")
            {
                MessageBox.Show("Заповніть порожні поля");
                return;
            }


            db.cmd.CommandText = "Select * from employees where [phone_number] = '" + num_tb.Text + "' and [password] = N'" + password_tb.Text + "';";
            SqlDataReader reader = db.cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                employee_name = reader["id"].ToString() + "." + reader["employee_name"];
                level = Convert.ToInt32(reader["level"]);
                reader.Close();
            }
            else
            {
                MessageBox.Show("Неправильний номер або пароль!");
                reader.Close();
            }

            if (employee_name != null)
            {
                Issuance_Literature_Form i_form = new Issuance_Literature_Form();
                this.Hide();
                i_form.ShowDialog();

                employee_name = null;
                this.Close();
            }
            
        }
    }
}
