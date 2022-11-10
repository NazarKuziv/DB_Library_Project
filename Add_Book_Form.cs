using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DB_Lib_project
{
   
    public partial class Add_Book_Form : Form
    {
        public Add_Book_Form()
        {
            InitializeComponent();
        }


        string id = null;
        private void Add_Book_Form_Load(object sender, EventArgs e)
        {
            db.openConnection();
            id = Books_Form.id;
            Update_CheckList();

            if (id != null)
            {
                db.cmd.CommandText = "Select * From books WHERE book_id = " + id;
                SqlDataReader reader = db.cmd.ExecuteReader();
                while (reader.Read())
                {
                    title_tBox.Text = reader["title"].ToString();
                    language_tBox.Text = reader["language"].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(reader["publish_date"]);
                    num_of_cop_Up_Down.Value = Convert.ToInt32(reader["number_of_copies"]);
                    for (int i = 0; i < publisher_cBox.Items.Count; i++)
                    {
                        string[] publisher = publisher_cBox.Items[i].ToString().Split('-');
                        string publisher_id = publisher[0];
                       
                        if (publisher_id == reader["publisher_id"].ToString())
                        {
                            
                            publisher_cBox.SelectedIndex = i;
                            break;
                        }
                    }

                }
                reader.Close();
               
                List<string> genres = Select_from("books_genres", "genres", id);
                List<string> authors= Select_from("authors_books", "authors", id);

                for (int i = 0; i < authorListBox.Items.Count; i++)
                {
                    foreach(string author in authors)
                    {
                        if (authorListBox.Items[i].ToString() == author)
                        {
                            authorListBox.SetItemChecked(i,true);
                        }
                    }
                }
                for (int i = 0; i < genreListBox.Items.Count; i++)
                {
                    foreach (string genre in genres)
                    {
                        if (genreListBox.Items[i].ToString() == genre)
                        {
                            genreListBox.SetItemChecked(i, true);
                        }
                    }
                }


            }
                   
        }
        public List<string> Select_from(string table1, string table2, string book_id)
        {
            List<string> list = new List<string>();
            string id, name;

            id = table1 == "books_genres" ? "genre_id" : "author_id";
            name = table1 == "books_genres" ? "genre_name" : "author_name";
            string str = "";

                db.cmd.CommandText = $"SELECT {table2}.{id},{table2}.{name} FROM {table1} INNER JOIN {table2} ON  {table1}.{table2} = {table2}.{id} WHERE {table1}.books = {book_id}";
                SqlDataReader reader = db.cmd.ExecuteReader();

            while (reader.Read())
            {
                str = reader.GetValue(0).ToString() + "-" + reader.GetString(1);
                list.Add(str);
            }

            reader.Close();

            return list;
        }
        public void Update_CheckList()
        {
            authorListBox.Items.Clear();
            genreListBox.Items.Clear();
            publisher_cBox.Items.Clear();

            List<string> list = getList("authors");
            foreach (string item in list)
                authorListBox.Items.Add(item);

            list = getList("genres");
            foreach (string item in list)
                genreListBox.Items.Add(item);

            list = getList("publishers");
            foreach (string item in list)
                publisher_cBox.Items.Add(item);
        }
      
        public List<string> getList(string table)
        {

            db.cmd.CommandText = "Select * From "+table;
            SqlDataReader reader = db.cmd.ExecuteReader();

            List<string> list = new List<string>();
            while (reader.Read())
            {
                list.Add(reader.GetValue(0).ToString() + "-" + reader.GetString(1));

            }
            reader.Close();
            return list;
        }



        private void Add_Book_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Books_Form.id = null;
            db.closeConnection();
            Books_Form books_form = new Books_Form();
            this.Hide();
            books_form.ShowDialog();
            this.Close();

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            title_tBox.Text = "";
            language_tBox.Text = "";
            num_of_cop_Up_Down.Value = 0;
            publisher_cBox.SelectedIndex = 0;
            for(int i = 0; i < authorListBox.Items.Count;i++)
            {
                authorListBox.SetItemChecked(i,false);
            }
            for (int i = 0; i < genreListBox.Items.Count; i++)
            {
                genreListBox.SetItemChecked(i, false);
            }
           
            dateTimePicker1.Value = DateTime.Now;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            
            if (title_tBox.Text=="")
            {
                MessageBox.Show("Введіть назву!");
                return;
            }

            bool isCheck = false;
            foreach (int i in authorListBox.SelectedIndices)
            {
                if (authorListBox.GetItemCheckState(i) == CheckState.Checked)
                {  
                   isCheck = true;
                }
            }
           
            if (isCheck == false)
            {
                MessageBox.Show("Виберіть Автора!");
                return;
            }
            isCheck = false;
            foreach (int i in genreListBox.SelectedIndices)
            {
                if (genreListBox.GetItemCheckState(i) == CheckState.Checked)
                {
                    isCheck = true;
                }
            }
            if (isCheck == false)
            {
                MessageBox.Show("Виберіть жанр!");
                return;
            }
            if (language_tBox.Text == "")
            {
                MessageBox.Show("Введіть мову!");
                return;
            }

            if (dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("Ви з майбутнього?");
                return;
            }
            if (num_of_cop_Up_Down.Value == 0)
            {
                MessageBox.Show("Вкажеть кількість!");
                return;
            }

            

            string[] publisher = publisher_cBox.Text != "" ? publisher_cBox.Text.Split('-') : null;
            string publisher_id = publisher == null ? "NULL" : publisher[0];
            
            if(id == null)
            {
                string queryString = "Insert into books ([title],[publisher_id],[language],[publish_date],[number_of_copies],[in_stock])" +
                "Values(N'" + title_tBox.Text + "'," +
                  publisher_id + "," +
                "N'" + language_tBox.Text + "'," +
                "'" + String.Format("{0:yyyy/MM/dd}", dateTimePicker1.Value) + "'," +
                num_of_cop_Up_Down.Value.ToString() + "," +
                num_of_cop_Up_Down.Value.ToString() +
                ");";

                try
                {
                    db.cmd.CommandText = queryString;
                    db.cmd.ExecuteNonQuery();

                    queryString = "SELECT TOP 1 * FROM books ORDER BY book_id DESC";
                    db.cmd.CommandText = queryString;
                    SqlDataReader reader = db.cmd.ExecuteReader();


                    reader.Read();
                    string book_id = reader["book_id"].ToString();
                    reader.Close();

                    List<string> list = new List<string>();
                    for (int i = 0; i < authorListBox.Items.Count; i++)
                    {
                        if (authorListBox.GetItemCheckState(i) == CheckState.Checked)
                        {

                            string[] split = authorListBox.Items[i].ToString().Split('-');
                            list.Add(split[0]);
                        }
                    }
                    Insert_Into("authors_books", list, book_id);
                    list.Clear();
                    for (int i = 0; i < genreListBox.Items.Count; i++)
                    {
                        if (genreListBox.GetItemCheckState(i) == CheckState.Checked)
                        {
                            string[] split = genreListBox.Items[i].ToString().Split('-');
                            list.Add(split[0]);
                        }
                    }
                    Insert_Into("books_genres", list, book_id);

                    MessageBox.Show(" " + title_tBox.Text + " додоно до БД");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
               
                string queryString = "SELECT * FROM books WHERE book_id =" + id;
                db.cmd.CommandText = queryString;
                SqlDataReader reader = db.cmd.ExecuteReader();

                reader.Read();
                var num = Convert.ToInt32(reader["number_of_copies"]) > num_of_cop_Up_Down.Value ? Convert.ToInt32(reader["number_of_copies"])-(int)num_of_cop_Up_Down.Value:0;
                bool is_num = Convert.ToInt32(reader["in_stock"]) < num? false:true;
             
                if (is_num == true)
                {
                   
                    var num_diff = Convert.ToInt32(reader["number_of_copies"]) > num_of_cop_Up_Down.Value ? Convert.ToInt32(reader["number_of_copies"]) - (int)num_of_cop_Up_Down.Value : (int)num_of_cop_Up_Down.Value - Convert.ToInt32(reader["number_of_copies"]);
                    var in_stock = Convert.ToInt32(reader["number_of_copies"]) > num_of_cop_Up_Down.Value ? Convert.ToInt32(reader["in_stock"]) - num_diff : Convert.ToInt32(reader["in_stock"]) + num_diff;
                    reader.Close();
                    queryString = "UPDATE dbo.books SET " +
                    "[title] = N'" + title_tBox.Text + "'," +
                    "[publisher_id] = " + publisher_id + "," +
                    "[language] = N'" + language_tBox.Text + "'," +
                    "[publish_date] = '" + String.Format("{0:yyyy/MM/dd}", dateTimePicker1.Value) + "'," +
                    "[number_of_copies] = " + num_of_cop_Up_Down.Value.ToString() + "," +
                    "[in_stock] = " + in_stock.ToString() + " WHERE book_id = " + id;

                    try
                    {
                        db.cmd.CommandText = queryString;
                        db.cmd.ExecuteNonQuery();

                        db.cmd.CommandText = "DELETE FROM books_genres WHERE books = " + id + ";";
                        db.cmd.ExecuteNonQuery();

                        db.cmd.CommandText = "DELETE FROM authors_books WHERE books = " + id + ";";
                        db.cmd.ExecuteNonQuery();

                        List<string> list = new List<string>();
                        for (int i = 0; i < authorListBox.Items.Count; i++)
                        {
                            if (authorListBox.GetItemCheckState(i) == CheckState.Checked)
                            {

                                string[] split = authorListBox.Items[i].ToString().Split('-');
                                list.Add(split[0]);
                            }
                        }
                        Insert_Into("authors_books", list, id);
                        list.Clear();
                        for (int i = 0; i < genreListBox.Items.Count; i++)
                        {
                            if (genreListBox.GetItemCheckState(i) == CheckState.Checked)
                            {
                                string[] split = genreListBox.Items[i].ToString().Split('-');
                                list.Add(split[0]);
                            }
                        }
                        Insert_Into("books_genres", list, id);

                        MessageBox.Show(" " + title_tBox.Text + " оновлено");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Неправильна кількість!");

                }
                 

            }
            

        }
        public void Insert_Into(string table, List<string> list_id,string book_id)
        {
            string col_name = table == "books_genres" ? "genres" : "authors";
            foreach (string id in list_id)
            {
                db.cmd.CommandText = "Insert into "+table+" ([books],["+ col_name + "]) VALUES("+book_id+","+id+") ";
                db.cmd.ExecuteNonQuery();
            }
        }
        private void publisher_cBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void add_author_Click(object sender, EventArgs e)
        {
            string message, title;
            string author; string[] a;

            message = "Введіть П.І.П автора і країну, в якій він народився (П.І.П-Країна)";
            title = "Додати автора";

            author = Interaction.InputBox(message,title);

            if (author == "")
                return;

            try
            {
                a = author.Split('-');
                if (a.Length == 2)
                {

                    db.cmd.CommandText = "Insert into authors ([author_name],[country]) VALUES(N'" + a[0] + "',N'" + a[1] + "')";
                    db.cmd.ExecuteNonQuery();
                    Update_CheckList();
                    Console.WriteLine("До таблиці автори додано: " + a[0]);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Упс.. Щось пішо не так. Повторіть спробу\n"+ex.Message);
            }
            
        }

        private void add_genre_Click(object sender, EventArgs e)
        {
            string message, title;
            object genre; 

            message = "Введіть жанр";
            title = "Додати жанр";

            genre = Interaction.InputBox(message, title);

            if ((string)genre == "")
                return;

            
              db.cmd.CommandText = "Insert into genres ([genre_name]) VALUES(N'" + genre.ToString() + "');";
              db.cmd.ExecuteNonQuery();
              Update_CheckList();
               
        }

        private void add_publisher_Click(object sender, EventArgs e)
        {
            string message, title;
            object publisher;

            message = "Введіть Назву Видавництва";
            title = "Додати Видавництво";

            publisher = Interaction.InputBox(message, title);

            if ((string)publisher == "")
                return;

                db.cmd.CommandText = "Insert into publishers ([publisher_name]) VALUES(N'" + publisher.ToString() + "');";
                db.cmd.ExecuteNonQuery();
                Update_CheckList();

            
            
        }
    }
}
