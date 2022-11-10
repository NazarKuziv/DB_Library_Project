using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_Lib_project
{
    public partial class Book_Filter_Form : Form
    {
        public Book_Filter_Form()
        {
            InitializeComponent();
        }

        DateTime now;
        private void Book_Filter_Form_Load(object sender, EventArgs e)
        {
            now = date_from.Value;
            Update_CheckList();
           
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
            publisher_cBox.Items.Add("NULL");

        }

        public List<string> getList(string table)
        {

            db.cmd.CommandText = "Select * From " + table;
            SqlDataReader reader = db.cmd.ExecuteReader();

            List<string> list = new List<string>();
            while (reader.Read())
            {
                list.Add(reader.GetValue(0).ToString() + "-" + reader.GetString(1));

            }
            reader.Close();
            return list;
        }

        private void Book_Filter_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Books_Form.bf_form = null;
        }

        private void publisher_cBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar ==(char)Keys.Delete)
            {
                publisher_cBox.Text = "";
            }
            e.Handled = true;
        }
        public static List<string> Select_from(string table1, string table2, List<string> listID)
        {
            List<string> list = new List<string>();
            string id;

            id = table1 == "books_genres" ? "genre_id" : "author_id";
           
            foreach (string item in listID)
            {

                db.cmd.CommandText = $"SELECT books FROM {table1} INNER JOIN {table2} ON  {table1}.{table2} = {table2}.{id} WHERE {table1}.{table2} = {item}";
                SqlDataReader reader = db.cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(reader.GetValue(0).ToString());
                }

                reader.Close();

            }

            return list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            List<string> authors = new List<string>();
            for (int i = 0; i < authorListBox.Items.Count; i++)
            {
                if (authorListBox.GetItemCheckState(i) == CheckState.Checked)
                {

                    string[] split = authorListBox.Items[i].ToString().Split('-');
                    authors.Add(split[0]);
                }
            }

            if(authors.Count > 0)
            {
                authors = Select_from("authors_books", "authors", authors);
            }

            List<string> genres = new List<string>();
            for (int i = 0; i < genreListBox.Items.Count; i++)
            {
                if (genreListBox.GetItemCheckState(i) == CheckState.Checked)
                {

                    string[] split = genreListBox.Items[i].ToString().Split('-');
                    genres.Add(split[0]);
                }
            }
            if(genres.Count > 0)
            {
                genres = Select_from("books_genres", "genres", genres);
            }

            List<string> book_id = new List<string>();
            if (authors.Count > 0 && genres.Count > 0)
            {
                foreach (string a in authors)
                {
                    foreach (string g in genres)
                    {
                        if (a == g)
                        {
                            book_id.Add(g);
                            break;
                        }
                    }
                }
            }else if(genres.Count > 0)
            {
                book_id = genres;
            }
            else
            {
                book_id = authors;
            }

            string where = " WHERE 1=1 ";
            if(book_id.Count > 0)
            {
                book_id = book_id.Distinct().ToList();
                where += "And (";
                foreach (string id in book_id)
                {
                    where += " book_id = " + id + " or";
                }
                where = where.Remove(where.Length - 2);
                where += ") ";
            }
           

            string[] publisher = publisher_cBox.Text != "" ? publisher_cBox.Text.Split('-') : null;
            string publisher_id = publisher == null ? "false" : publisher[0];
            if(publisher_id != "false")
            {
                if(publisher_id == "NULL"){
                    where += " and  publishers.publisher_id IS " + publisher_id;

                }
                else
                {
                    where += " and  publishers.publisher_id = " + publisher_id;
                }
               
            }

            DateTime from, to;
            if(date_from.Checked == true)
            {
                from = date_from.Value;
                where += " and  publish_date > '" + String.Format("{0:yyyy/MM/dd}", from) + "' ";
            }

            if (date_from.Checked == true && date_to.Value > date_from.Value)
            {
                to = date_to.Value;
                where += " and  publish_date < '" + String.Format("{0:yyyy/MM/dd}", to) + "' ";
            }

            if (in_stock_Check.Checked==true)
            {
                where += " and in_stock > 0";
            }


            if (System.Windows.Forms.Application.OpenForms["Books_Form"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["Books_Form"] as Books_Form).Update_ListView("SELECT * FROM books " +
                 "LEFT JOIN publishers ON books.publisher_id = publishers.publisher_id " + where);
            }


        }

        
    }
}
