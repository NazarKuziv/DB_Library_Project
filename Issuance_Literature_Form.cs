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
    public partial class Issuance_Literature_Form : Form
    {
        public Issuance_Literature_Form()
        {
            InitializeComponent();
        }

        public static string i_id = null;
        public static string name;
        public static int level;

        private void Issuance_Literature_Form_Load(object sender, EventArgs e)
        {
            name = Log_in_Form.employee_name;
            name_label.Text = Log_in_Form.employee_name;
            level = Log_in_Form.level;
            level_label.Text = "Рівень " + level.ToString();

            sort_by_cBox.SelectedItem = null;
            sort_by_cBox.SelectedText = "--Сортувати за--";
           

            if (level == 1)
            {
                books_button.Enabled = false;
                employee_button.Enabled = false;
            }

            if (level == 2)
            {
                employee_button.Enabled = false;
            }

            db.openConnection();
            log_out_button.Image = new Bitmap(Properties.Resources.exit, new Size(24, 24));
            add_button.Image = new Bitmap(Properties.Resources.add, new Size(24, 24));
            edit_button.Image = new Bitmap(Properties.Resources.edit, new Size(24, 24));
            delete_button.Image = new Bitmap(Properties.Resources.delete, new Size(24, 24));
            sort_button.Image = new Bitmap(Properties.Resources.sort_down, new Size(24, 24));
           

            Update_ListView("select  issuance_literature.id as id, readers.reader_id as reader_id,reader_name," +
                "readers.phone_number as phone_number,books.book_id as book_id,title,employees.id as e_id,employee_name," +
                "issuance_date,return_date from issuance_literature " +
                "inner join readers on issuance_literature.reader_id = readers.reader_id " +
                "inner join books on issuance_literature.book_id = books.book_id " +
                "inner join employees on issuance_literature.employee_id = employees.id ");

        }
        public void Update_ListView(string queryString)
        {

            db.cmd.CommandText = queryString;
            SqlDataReader reader = db.cmd.ExecuteReader();

            if (reader.HasRows)
            {

                listIssueneBooks.Items.Clear();


                while (reader.Read())
                {
                    ListViewItem items = new ListViewItem(reader["id"].ToString());
                    items.SubItems.Add(reader["reader_id"].ToString() + "." + reader["reader_name"].ToString());
                    items.SubItems.Add(reader["book_id"].ToString() + "." + reader["title"].ToString());
                    items.SubItems.Add(reader["e_id"].ToString() + "." + reader["employee_name"].ToString());
                    items.SubItems.Add(String.Format("{0:dd/MM/yyyy}", reader["issuance_date"]));
                    items.SubItems.Add(String.Format("{0:dd/MM/yyyy}", reader["return_date"]));
                    items.SubItems.Add(reader["phone_number"].ToString());

                    listIssueneBooks.Items.Add(items);

                }
                reader.Close();
            }
            else
            {
                reader.Close();
                MessageBox.Show("Немає записів в БД!");
            }

            listIssueneBooks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void Issuance_Literature_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.closeConnection();
            Log_in_Form form = new Log_in_Form();
            this.Hide();
            form.ShowDialog();
            this.Close();


        }

        private void books_button_Click_1(object sender, EventArgs e)
        {
            db.closeConnection();
            Books_Form books_form = new Books_Form();
            this.Hide();
            books_form.ShowDialog();
        }

        private void reader_button_Click(object sender, EventArgs e)
        {
            db.closeConnection();
            Readers_Form r_form = new Readers_Form();
            this.Hide();
            r_form.ShowDialog();
        }

        private void log_out_button_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            db.closeConnection();
            Add_Issuance_Literature_Form form = new Add_Issuance_Literature_Form();
            this.Hide();
            form.ShowDialog();


        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if (listIssueneBooks.SelectedItems.Count == 0)
            {
                MessageBox.Show("Виділіть рядок, щоб редагувати!");
            }
            else
            {
                i_id = listIssueneBooks.SelectedItems[0].Text;
                Add_Issuance_Literature_Form add_form = new Add_Issuance_Literature_Form();
                this.Hide();
                add_form.ShowDialog();


            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (listIssueneBooks.SelectedItems.Count == 0)
            {
                MessageBox.Show("Виділіть рядок, щоб видалити!");
            }
            else
            {

                string id = listIssueneBooks.SelectedItems[0].Text;

                if (DialogResult.Yes == MessageBox.Show("Видалити запис " + listIssueneBooks.SelectedItems[0].Text + " ?", "F", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    try
                    {
                        db.cmd.CommandText = "DELETE FROM issuance_literature WHERE id = " + id + ";";
                        db.cmd.ExecuteNonQuery();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                        Update_ListView("select  issuance_literature.id as id, readers.reader_id as reader_id,reader_name," +
                    "readers.phone_number as phone_number,books.book_id as book_id,title,employees.id as e_id,employee_name," +
                    "issuance_date,return_date from issuance_literature " +
                    "inner join readers on issuance_literature.reader_id = readers.reader_id " +
                    "inner join books on issuance_literature.book_id = books.book_id " +
                    "inner join employees on issuance_literature.employee_id = employees.id ");
                }
            }
        }

        
        string sort = "DESC";
        private void sort_button_Click(object sender, EventArgs e)
        {

            sort = sort == "DESC" ? "ASC" : "DESC";
            sort_button.Image = sort == "DESC" ? new Bitmap(Properties.Resources.sort_down, new Size(24, 24)) :
                new Bitmap(Properties.Resources.sort_up, new Size(24, 24));

            if (sort_by_cBox.Text != "--Сортувати за--")
            { sort_by_cBox_SelectedIndexChanged(sender, e); }
        }

        private void sort_by_cBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string sort_by = sort_by_cBox.SelectedItem.ToString();
            List<Issuance_Literature> i_lits = new List<Issuance_Literature>();
            foreach (ListViewItem itemRow in listIssueneBooks.Items)
            {
                Issuance_Literature i_lit = new Issuance_Literature();
                i_lit.ID = itemRow.SubItems[0].Text;
                i_lit.Reader = itemRow.SubItems[1].Text;
                i_lit.Book = itemRow.SubItems[2].Text;
                i_lit.Employee = itemRow.SubItems[3].Text;
                i_lit.Issuance_Date = Convert.ToDateTime(itemRow.SubItems[4].Text);
                if(itemRow.SubItems[5].Text != "")
                    i_lit.Return_Date =  Convert.ToDateTime(itemRow.SubItems[5].Text);
                i_lit.Phone = itemRow.SubItems[6].Text;

                i_lits.Add(i_lit);

            }
           
            switch (sort_by)
            {
                case "Датою видачі": { i_lits = sort == "ASC" ? i_lits.OrderBy(order => order.Issuance_Date).ToList() : i_lits.OrderByDescending(order => order.Issuance_Date).ToList(); break; }
                case "Датою повернення": { i_lits = sort == "ASC" ? i_lits.OrderBy(order => order.Return_Date).ToList() : i_lits.OrderByDescending(order => order.Return_Date).ToList(); break; }
                case "--Сортувати за--": { break; }
                default: { break; }
            }

            listIssueneBooks.Items.Clear();
            foreach (var i_lit in i_lits)
            {
                ListViewItem items = new ListViewItem(i_lit.ID);
                items.SubItems.Add(i_lit.Reader);
                items.SubItems.Add(i_lit.Book);
                items.SubItems.Add(i_lit.Employee);
                items.SubItems.Add(i_lit.Issuance_Date.ToString("d"));
                items.SubItems.Add(String.Format("{0:dd/MM/yyyy}", i_lit.Return_Date));
                items.SubItems.Add(i_lit.Phone);
                listIssueneBooks.Items.Add(items);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                List<Issuance_Literature> i_lits = new List<Issuance_Literature>();
                foreach (ListViewItem itemRow in listIssueneBooks.Items)
                {
                    Issuance_Literature i_lit = new Issuance_Literature();
                    if(itemRow.SubItems[5].Text != "")
                    {
                        listIssueneBooks.Items.Remove(itemRow);
                    }

                }

            }
            else
            {
                Update_ListView("select  issuance_literature.id as id, readers.reader_id as reader_id,reader_name," +
                 "readers.phone_number as phone_number,books.book_id as book_id,title,employees.id as e_id,employee_name," +
                 "issuance_date,return_date from issuance_literature " +
                 "inner join readers on issuance_literature.reader_id = readers.reader_id " +
                 "inner join books on issuance_literature.book_id = books.book_id " +
                 "inner join employees on issuance_literature.employee_id = employees.id ");
            }
        }

        private void employee_button_Click(object sender, EventArgs e)
        {
           
            Employees_Form f = new Employees_Form();
            this.Hide();
            f.ShowDialog();
        }
    }

    public class Issuance_Literature
    {
        public string ID { get; set; }
        public string Reader { get; set; }
        public string Book { get; set; }
        public string Employee { get; set; }
        public DateTime Issuance_Date { get; set; }
        public DateTime? Return_Date { get; set; }
        public string Phone { get; set; }

    }
}

