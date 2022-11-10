using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;



namespace DB_Lib_project
{
    
    public partial class Books_Form : Form
    {
        public Books_Form()
        {
            InitializeComponent();
        }
       


        private void Books_Form_Load(object sender, EventArgs e)
        {

            if(Issuance_Literature_Form.level == 1)
            {
                back_button.Enabled = false;
                add_button.Enabled = false;
                edit_button.Enabled = false;
                delete_button.Enabled=false;
            }


            db.openConnection();
            back_button.Image = new Bitmap(Properties.Resources.skip_back, new Size(24, 24));
            add_button.Image = new Bitmap(Properties.Resources.add, new Size(24, 24));
            edit_button.Image = new Bitmap(Properties.Resources.edit, new Size(24, 24));
            delete_button.Image = new Bitmap(Properties.Resources.delete, new Size(24, 24));
            filter_button.Image = new Bitmap(Properties.Resources.filter, new Size(24, 24));
            sort_button.Image = new Bitmap(Properties.Resources.sort_down, new Size(24, 24));
            search_Icon.Image = new Bitmap(Properties.Resources.search, new Size(24, 24));
            sort_by_cBox.SelectedItem = null;
            sort_by_cBox.SelectedText = "--Сортувати за--";
            search_cBox.SelectedItem = null;
            search_cBox.SelectedText = "Введіть назву книги";


            Update_ListView("SELECT * FROM books " +
                 "LEFT JOIN publishers ON books.publisher_id = publishers.publisher_id");
        }
        
        public void Update_ListView(string queryString)
        {

           
            //List<Books> books = new List<Books>();
            db.cmd.CommandText =queryString;
            SqlDataReader reader = db.cmd.ExecuteReader();

            if (reader.HasRows)
            {

                listBooks.Items.Clear();

                List<string> listID = new List<string>();

                while (reader.Read())
                {
                    string id = reader["book_id"].ToString();
                   
                    listID.Add(id);
                    ListViewItem items = new ListViewItem(id);
                    items.SubItems.Add(reader["title"].ToString());
                    //items.SubItems.Add(Select_from("authors_books", "authors", book_id));
                    //items.SubItems.Add(Select_from("books_genres", "genres", book_id));
                    items.SubItems.Add("");
                    items.SubItems.Add("");
                    items.SubItems.Add(reader["publisher_name"].ToString());
                    items.SubItems.Add(reader["language"].ToString());
                    items.SubItems.Add(String.Format("{0:dd/MM/yyyy}", reader["publish_date"]));
                    items.SubItems.Add(reader["number_of_copies"].ToString());
                    items.SubItems.Add(reader["in_stock"].ToString());
                    listBooks.Items.Add(items);

                    //Books newBook = new Books();

                    //newBook.ID = id;
                    //newBook.Title = reader["title"].ToString();
                    //newBook.Publisher = reader["publisher_name"].ToString();
                    //newBook.Language = reader["language"].ToString();
                    //newBook.Publisher_date = Convert.ToDateTime(reader["publish_date"]);
                    //newBook.Num_of_cop = Convert.ToInt32(reader["number_of_copies"]);
                    //newBook.In_stock = Convert.ToInt32(reader["number_of_copies"]);
                    //books.Add(newBook);

                }
                reader.Close();

                List<string> genres = Select_from("books_genres", "genres", listID);
                List<string> authors = Select_from("authors_books", "authors", listID);

                int i = 0;
                foreach (string a in authors)
                {
                    listBooks.Items[i].SubItems[2].Text = a;
                    i++;
                }
                i = 0;
                foreach (string g in genres)
                {
                    listBooks.Items[i].SubItems[3].Text = g;
                    i++;
                }
            }
            else
            {
                reader.Close();
                MessageBox.Show("Немає записів в БД!");
            }

            listBooks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
       
        public static List<string> Select_from(string table1, string table2,List<string> listID)
        {
            List<string> list = new List<string>();
            string id,name;
            
            id = table1 == "books_genres" ? "genre_id" :"author_id";
            name = table1 == "books_genres" ? "genre_name" : "author_name";

            foreach (string book_id in listID)
            {
                string str = " ";

                db.cmd.CommandText = $"SELECT {table2}.{name} FROM {table1} INNER JOIN {table2} ON  {table1}.{table2} = {table2}.{id} WHERE {table1}.books = {book_id}";
                SqlDataReader reader = db.cmd.ExecuteReader();

                while (reader.Read()) str += reader.GetString(0) + ", ";

                list.Add(str);
                reader.Close();

            }

            return list;
        }

        private void Books_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (System.Windows.Forms.Application.OpenForms["Add_Issuance_Literature_Form"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["Add_Issuance_Literature_Form"] as Add_Issuance_Literature_Form).Show();
            }
            else
            {
                (System.Windows.Forms.Application.OpenForms["Issuance_Literature_Form"] as Issuance_Literature_Form).Show();
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
        
        string sort = "DESC";
        private void sort_button_Click(object sender, EventArgs e)
        {
            sort = sort == "DESC" ?"ASC":"DESC";
            sort_button.Image = sort=="DESC"?new Bitmap(Properties.Resources.sort_down, new Size(24, 24)): 
                new Bitmap(Properties.Resources.sort_up, new Size(24, 24));

            if(sort_by_cBox.Text != "--Сортувати за--") 
            { 
                sort_by_cBox_SelectedIndexChanged(sender, e);
            }

        }

        private void sort_by_cBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sort_by = sort_by_cBox.SelectedItem.ToString();          
            List<Books> books = new List<Books>();
            foreach(ListViewItem itemRow in listBooks.Items)
            {
                Books book = new Books();
                book.ID = itemRow.SubItems[0].Text;
                book.Title = itemRow.SubItems[1].Text;
                book.Authors = itemRow.SubItems[2].Text;
                book.Genres = itemRow.SubItems[3].Text;
                book.Publisher = itemRow.SubItems[4].Text;
                book.Language = itemRow.SubItems[5].Text;
                book.Publisher_date = Convert.ToDateTime(itemRow.SubItems[6].Text);
                book.Num_of_cop = Convert.ToInt32(itemRow.SubItems[7].Text);
                book.In_stock = Convert.ToInt32(itemRow.SubItems[8].Text);
                books.Add(book);

            }
          
            switch (sort_by)
            {
                case "Назвою": { books = sort == "ASC" ? books.OrderBy(order => order.Title).ToList() : books.OrderByDescending(order => order.Title).ToList();  break; }
                case "Автором": { books = sort == "ASC" ? books.OrderBy(order => order.Authors).ToList() : books.OrderByDescending(order => order.Authors).ToList(); break; }
                case "Жанром": { books = sort == "ASC" ? books.OrderBy(order => order.Genres).ToList() : books.OrderByDescending(order => order.Genres).ToList(); break; }
                case "Видавництвом": { books = sort == "ASC" ? books.OrderBy(order => order.Publisher).ToList() : books.OrderByDescending(order => order.Publisher).ToList(); break; }
                case "Датою пуплікації": { books = sort == "ASC" ? books.OrderBy(order => order.Publisher_date).ToList() : books.OrderByDescending(order => order.Publisher_date).ToList(); break; }
                case "Кількістю": { books = sort == "ASC" ? books.OrderBy(order => order.Num_of_cop).ToList() : books.OrderByDescending(order => order.Num_of_cop).ToList(); break; }
                case "Кількістю в наявності": { books = sort == "ASC" ? books.OrderBy(order => order.In_stock).ToList() : books.OrderByDescending(order => order.In_stock).ToList(); break; }
                case "--Сортувати за--": {  break; }
                default: { break; }
            }

            listBooks.Items.Clear();
            foreach (var book in books)
            {
                ListViewItem items = new ListViewItem(book.ID);
                items.SubItems.Add(book.Title);
                items.SubItems.Add(book.Authors);
                items.SubItems.Add(book.Genres);
                items.SubItems.Add(book.Publisher);
                items.SubItems.Add(book.Language);
                items.SubItems.Add(String.Format("{0:dd/MM/yyyy}", book.Publisher_date));
                items.SubItems.Add(book.Num_of_cop.ToString());
                items.SubItems.Add(book.In_stock.ToString());
                listBooks.Items.Add(items);
            }
        }

       
        private void search_cBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string where = " ";
            if (search_cBox.SelectedItem.ToString() != "Вивети все")
            {
                string key_word = search_cBox.SelectedItem.ToString();
                where = "WHERE title = N'" + key_word + "' OR publisher_name = N'" + key_word + "' ";
            }
            

            Update_ListView("SELECT * FROM books " +
                "LEFT JOIN publishers ON books.publisher_id = publishers.publisher_id "+where);

        }

        public void search_cBox_display()
        {
            string txt = search_cBox.Text;

            db.cmd.CommandText = "SELECT title FROM books " +
                "WHERE title like N'%"+ txt + "%' " +
                "UNION ALL SELECT publisher_name FROM publishers " +
                "WHERE publisher_name like N'%" + txt + "%' ";
            SqlDataReader reader = db.cmd.ExecuteReader();

            List<string> list = new List<string>();
            
            while (reader.Read())
            {
                list.Add(reader.GetString(0));
               
            }
            reader.Close();

            list.Add("Вивети все");

            if (list.Count() > 1)
            {
                search_cBox.DataSource = list.ToList();
                //comboBox1.SelectedIndex = 0;
                var sText = search_cBox.Items[0].ToString();
                search_cBox.SelectionStart = txt.Length;
                search_cBox.SelectionLength = sText.Length - txt.Length;
                search_cBox.DroppedDown = true;
                return;
            }
            else
            {
                search_cBox.DataSource = list.ToList();
                var sText = search_cBox.Items[0].ToString();
                search_cBox.SelectionStart = txt.Length;
                search_cBox.SelectionLength = sText.Length - txt.Length;
                search_cBox.DataSource = list.ToList();
                search_cBox. Text = "Такої книги у нас немає :(";
                return;
            }
        }
       
        private void search_cBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(search_cBox.Text.Length >= 3) search_cBox_display();
        }

        private void listBooks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(Convert.ToInt32(listBooks.SelectedItems[0].SubItems[8].Text) > 0)
            {
                string i = listBooks.SelectedItems[0].Text + "." + listBooks.SelectedItems[0].SubItems[1].Text;
                if (System.Windows.Forms.Application.OpenForms["Add_Issuance_Literature_Form"] != null)
                {
                    (System.Windows.Forms.Application.OpenForms["Add_Issuance_Literature_Form"] as Add_Issuance_Literature_Form).Set_book(i);

                }
                this.Close();
            }
            else
            {
                MessageBox.Show(listBooks.SelectedItems[0].Text + "." + listBooks.SelectedItems[0].SubItems[1].Text + " Немає в наявності!");
            }
          
            
        }

       
        public static string id = null;
        
        private void add_button_Click(object sender, EventArgs e)
        {

            Add_Book_Form add_form = new Add_Book_Form();
            this.Hide();
            add_form.ShowDialog();
            this.Close();


        }
        
           
        private void edit_button_Click(object sender, EventArgs e)
        {
           
            if(listBooks.SelectedItems.Count == 0)
            {
                MessageBox.Show("Виділіть книгу, щоб редагувати!");
            }
            else
            {
                id = listBooks.SelectedItems[0].Text;
                Add_Book_Form add_form = new Add_Book_Form();
                this.Hide();
                add_form.ShowDialog();
                this.Close();

            }
            
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
           

            if (listBooks.SelectedItems.Count == 0)
            {
                MessageBox.Show("Виділіть книгу, щоб видалити!");
            }
            else
            {
                string book_id = listBooks.SelectedItems[0].Text;
               
                if (DialogResult.Yes == MessageBox.Show("Видалити " + listBooks.SelectedItems[0].SubItems[1].Text + " ?", "F", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    try
                    {
                        db.cmd.CommandText = "DELETE FROM books_genres WHERE books = " + book_id + ";";
                        db.cmd.ExecuteNonQuery();

                        db.cmd.CommandText = "DELETE FROM authors_books WHERE books = " + book_id + ";";
                        db.cmd.ExecuteNonQuery();
                         
                        db.cmd.CommandText = "DELETE FROM dbo.books WHERE [book_id] = " + book_id + ";"; 
                        db.cmd.ExecuteNonQuery();

                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                    Update_ListView("SELECT * FROM books " +
                    "LEFT JOIN publishers ON books.publisher_id = publishers.publisher_id");
                }


            }
        }
        static public Book_Filter_Form bf_form = null;
        private void filter_button_Click(object sender, EventArgs e)
        {
            if (bf_form == null)
                bf_form = new Book_Filter_Form();
            bf_form.Show();
            bf_form.Activate();

        }
    }
}
