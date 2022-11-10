using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_Lib_project
{
    public partial class Employees_Form : Form
    {
        public Employees_Form()
        {
            InitializeComponent();
        }
        static int id = -1;
        private void Employees_Form_Load(object sender, EventArgs e)
        {

            First.Image = new Bitmap(Properties.Resources.skip_back_outline, new Size(24, 24));
            Prev.Image = new Bitmap(Properties.Resources.caret_left, new Size(24, 24));
            Next.Image = new Bitmap(Properties.Resources.caret_right, new Size(24, 24));
            Last.Image = new Bitmap(Properties.Resources.skip_forward_outline, new Size(24, 24));
            Add.Image = new Bitmap(Properties.Resources.add, new Size(24, 24));
            Edit.Image = new Bitmap(Properties.Resources.edit, new Size(24, 24));
            Delete.Image = new Bitmap(Properties.Resources.delete, new Size(24, 24));
            getItem("SELECT * FROM [employees];");

        }

        public void getItem(string sqlQuery)
        {
            db.cmd.CommandText =sqlQuery;
            SqlDataReader reader = db.cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                id = Convert.ToInt32(reader["id"]);
                idTextBox.Text = id.ToString();
                employee_nameTextBox.Text = reader["employee_name"].ToString();
                addressTextBox.Text = reader["address"].ToString();
                phone_numberTextBox.Text = reader["phone_number"].ToString();
                levelTextBox.Text = reader["level"].ToString();
                passwordTextBox.Text = reader["password"].ToString();

                if (reader["photo"] != DBNull.Value)
                {
                    img = (byte[])reader["photo"];
                    MemoryStream ms = new MemoryStream(img);
                    photoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    photoPictureBox.Image = Image.FromStream(ms);

                }
                else
                {
                    photoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    photoPictureBox.Image = new Bitmap(Properties.Resources.No_photo_m); 
                }
            }
           
            reader.Close();
        }

        private void Employees_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (System.Windows.Forms.Application.OpenForms["Issuance_Literature_Form"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["Issuance_Literature_Form"] as Issuance_Literature_Form).Show();


            }
        }
        public static byte[] GetPhoto(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open,
            FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] photo = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            return photo;
        }
        byte[] img = null;
        private void load_photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "ImageFiles(*.BMP; *.JPG; *.GIF; *.PNG)| *.BMP; *.JPG; *.GIF; *.PNG | All files(*.*) | *.* ";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    img = GetPhoto(open_dialog.FileName);
                    photoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    photoPictureBox.Image = Image.FromFile(open_dialog.FileName);
                }
                catch (Exception n)
                {
                    DialogResult rezult = MessageBox.Show(n.Message, n.Source,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void First_Click(object sender, EventArgs e)
        {
            getItem("SELECT * FROM [employees]; ");
        }

        private void Last_Click(object sender, EventArgs e)
        {
            getItem("SELECT * FROM employees WHERE id = (SELECT max(id) FROM employees);");
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            getItem("SELECT TOP 1* FROM employees WHERE id < " + id + " ORDER BY id DESC");
        }

        private void Next_Click(object sender, EventArgs e)
        {
            getItem("SELECT TOP 1* FROM employees WHERE id > " + id + " ORDER BY id;");
        }

        private void Add_Click(object sender, EventArgs e)
        {
            photoPictureBox.Image = null;
            idTextBox.Text = "";
            employee_nameTextBox.Text = "";
            addressTextBox.Text = "";
            phone_numberTextBox.Text = "";
            levelTextBox.Text = "";
            passwordTextBox.Text = "";

            employee_nameTextBox.Enabled = true;
            addressTextBox.Enabled = true;
            phone_numberTextBox.Enabled = true;
            levelTextBox.Enabled = true;
            passwordTextBox.Enabled = true;

            label7.Visible = true;
            passwordTextBox.Visible = true;
            load_photo.Visible = true;
            ok.Visible = true;
            tableLayoutPanel2.Visible = false;
            img = null;

        }

        private void ok_Click(object sender, EventArgs e)
        {
            if(employee_nameTextBox.Text == "")
            {
                MessageBox.Show("Заповніть порожні поля!");
                return;
            }
            if (addressTextBox.Text== "")
            {
                MessageBox.Show("Заповніть порожні поля!");
                return;
            }
            if (phone_numberTextBox.Text == "")
            {
                MessageBox.Show("Заповніть порожні поля!");
                return;
            }
            if (levelTextBox.Text == "")
            {
                MessageBox.Show("Заповніть порожні поля!");
                return;
            }
            if (phone_numberTextBox.Text == "")
            {
                MessageBox.Show("Заповніть порожні поля!");
                return;
            }
            if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Заповніть порожні поля!");
                return;
            }

            if (phone_numberTextBox.Text.Length != 10)
            {
                MessageBox.Show("Номер телефону введено неправильно!");
                return;
            }
            Regex regex = new Regex(@"^[0-9]+$");
            Match x = regex.Match(phone_numberTextBox.Text);
            if (x.Success == false)
            {
                MessageBox.Show("Номер телефону введено неправильно!");
                return;
            }

            if (idTextBox.Text == "")
            {
                db.cmd.CommandText = "Select * from employees where phone_number = '" + phone_numberTextBox.Text + "';";
                SqlDataReader reader = db.cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Читач з таким номером вже є в БД!");
                    reader.Close();
                    return;
                }
                reader.Close();
                string queryString;
                if (img == null)
                {
                    queryString = "Insert into employees ([employee_name],[address],[phone_number],[password],[level],[photo])" +
                    "Values(N'" + employee_nameTextBox.Text + "'," +
                    "N'" + addressTextBox.Text + "'," +
                    "N'" + phone_numberTextBox.Text + "'," +
                    "N'" + passwordTextBox.Text + "'," +
                     levelTextBox.Text + "," + "NULL);";

                }
                else
                {
                    queryString = "Insert into employees ([employee_name],[address],[phone_number],[password],[level],[photo])" +
                    "Values(N'" + employee_nameTextBox.Text + "'," +
                    "N'" + addressTextBox.Text + "'," +
                    "N'" + phone_numberTextBox.Text + "'," +
                    "N'" + passwordTextBox.Text + "'," +
                     levelTextBox.Text + ", @photo);";
                    db.cmd.Parameters.Add("@photo", SqlDbType.Image, img.Length);
                    db.cmd.Parameters["@photo"].Value = img;

                    img = null;
                }


                try
                {
                    db.cmd.CommandText = queryString;
                    db.cmd.ExecuteNonQuery();

                    db.cmd.Parameters.Clear();
                    MessageBox.Show(" " + employee_nameTextBox.Text + " додоно до БД");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                getItem("SELECT TOP 1 * FROM employees ORDER BY id DESC");
            }
            else
            {
                db.cmd.CommandText = "Select * from employees where phone_number = '" + phone_numberTextBox.Text + "';";
                SqlDataReader reader = db.cmd.ExecuteReader();
                
                string queryString;

                if (reader.HasRows)
                {
                    queryString = "UPDATE dbo.employees SET " +
                    "[employee_name] = N'" + employee_nameTextBox.Text + "'," +
                    "[address] = N'" + addressTextBox.Text + "'," +
                    "[password] = N'" + phone_numberTextBox.Text + "'," +
                    "[level] = " +levelTextBox.Text + "," +
                    "[photo] = @photo WHERE id = " + idTextBox.Text;

                    db.cmd.Parameters.Add("@photo", SqlDbType.Image, img.Length);
                    db.cmd.Parameters["@photo"].Value = img;

                }
                else
                {
                    queryString = "UPDATE dbo.employees SET " +
                    "[employee_name] = N'" + employee_nameTextBox.Text + "'," +
                    "[address] = N'" + addressTextBox.Text + "'," +
                    "[phone_number] = N'" + phone_numberTextBox.Text + "'," +
                    "[password] = N'" + phone_numberTextBox.Text + "'," +
                    "[level] = " + levelTextBox.Text + "," +
                    "[photo] = @photo WHERE id = " + idTextBox.Text;

                    db.cmd.Parameters.Add("@photo", SqlDbType.Image, img.Length);
                    db.cmd.Parameters["@photo"].Value = img;
                }
                reader.Close();
                img = null;
                try
                {
                    db.cmd.CommandText = queryString;
                    db.cmd.ExecuteNonQuery();

                    db.cmd.Parameters.Clear();
                    MessageBox.Show(" " + employee_nameTextBox.Text + " оновлено в БД");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                getItem("SELECT  * FROM employees where id = "+idTextBox.Text);
            }

            employee_nameTextBox.Enabled = false;
            addressTextBox.Enabled = false;
            phone_numberTextBox.Enabled = false;
            levelTextBox.Enabled = false;
            passwordTextBox.Enabled = false;

            label7.Visible = false;
            passwordTextBox.Visible = false;
            load_photo.Visible = false;
            ok.Visible = false;
            tableLayoutPanel2.Visible = true;
            img = null;


        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Видалити  " +employee_nameTextBox.Text + " ?", "F", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                try
                {
                    db.cmd.CommandText = "DELETE FROM employees WHERE id = " + idTextBox.Text + ";";
                    db.cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                getItem("SELECT * FROM [employees];");
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            employee_nameTextBox.Enabled = true;
            addressTextBox.Enabled = true;
            phone_numberTextBox.Enabled = true;
            levelTextBox.Enabled = true;
            passwordTextBox.Enabled = true;

            label7.Visible = true;
            passwordTextBox.Visible = true;
            load_photo.Visible = true;
            ok.Visible = true;
            tableLayoutPanel2.Visible = false;
        }
    }
}
