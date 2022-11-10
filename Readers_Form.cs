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
    
    public partial class Readers_Form : Form
    {
        public Readers_Form()
        {
            InitializeComponent();
        }

        private void Readers_Form_Load(object sender, EventArgs e)
        {
            db.openConnection();
            back_button.Image = new Bitmap(Properties.Resources.skip_back, new Size(24, 24));
            add_button.Image = new Bitmap(Properties.Resources.add, new Size(24, 24));
            edit_button.Image = new Bitmap(Properties.Resources.edit, new Size(24, 24));
            delete_button.Image = new Bitmap(Properties.Resources.delete, new Size(24, 24));
           
            sort_button.Image = new Bitmap(Properties.Resources.sort_down, new Size(24, 24));
            search_Icon.Image = new Bitmap(Properties.Resources.search, new Size(24, 24));
            sort_by_cBox.SelectedItem = null;
            sort_by_cBox.SelectedText = "--Сортувати за--";
            search_cBox.SelectedItem = null;
            search_cBox.SelectedText = "Введіть Ім'я";

            Update_ListView("SELECT * FROM readers");
        }
        public void Update_ListView(string queryString)
        {

            db.cmd.CommandText = queryString;
            SqlDataReader reader = db.cmd.ExecuteReader();

            if (reader.HasRows)
            {

                listReaders.Items.Clear();


                while (reader.Read())
                {
                    ListViewItem items = new ListViewItem(reader["reader_id"].ToString());
                    items.SubItems.Add(reader["reader_name"].ToString());
                    items.SubItems.Add(reader["address"].ToString());
                    items.SubItems.Add(reader["phone_number"].ToString());
                    items.SubItems.Add(reader["penalty"].ToString());

                    listReaders.Items.Add(items);

                }
                reader.Close();
            }
            else
            {
                reader.Close();
                MessageBox.Show("Немає записів в БД!");
            }

            listReaders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


        }
        private void Readers_Form_FormClosed(object sender, FormClosedEventArgs e)
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

        private void sort_by_cBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sort_by = sort_by_cBox.SelectedItem.ToString();
            List<Reader> readers = new List<Reader>();
            foreach (ListViewItem itemRow in listReaders.Items)
            {
                Reader reader = new Reader();
                reader.ID = itemRow.SubItems[0].Text;
                reader.Name = itemRow.SubItems[1].Text;
                reader.Address = itemRow.SubItems[2].Text;
                reader.Phone = itemRow.SubItems[3].Text;
                reader.Penalty = Convert.ToInt32(itemRow.SubItems[4].Text);
                readers.Add(reader);

            }

            switch (sort_by)
            {
                case "П.І.П": { readers = sort == "ASC" ? readers.OrderBy(order => order.Name).ToList() : readers.OrderByDescending(order => order.Name).ToList(); break; }
                case "Кількістю штрафних балів": { readers = sort == "ASC" ? readers.OrderBy(order => order.Penalty).ToList() : readers.OrderByDescending(order => order.Penalty).ToList(); break; }
                case "--Сортувати за--": { break; }
                default: { break; }
            }

            listReaders.Items.Clear();
            foreach (var reader in readers)
            {
                ListViewItem items = new ListViewItem(reader.ID);
                items.SubItems.Add(reader.Name);
                items.SubItems.Add(reader.Address);
                items.SubItems.Add(reader.Phone);
                items.SubItems.Add(reader.Penalty.ToString());
                listReaders.Items.Add(items);
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


        private void search_cBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            string where = " ";
            if (search_cBox.SelectedItem.ToString() != "Вивети всіх")
            {
                string key_word = search_cBox.SelectedItem.ToString();
                where = "WHERE reader_name = N'" + key_word + "'";
            }


            Update_ListView("SELECT * FROM readers " + where);
        }
        public void search_cBox_display()
        {
            string txt = search_cBox.Text;

            db.cmd.CommandText = "SELECT reader_name FROM readers " +
                "WHERE reader_name like N'%" + txt + "%' ";
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
                search_cBox.Text = "Такого читача немає";
                return;
            }
        }

        private void search_cBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (search_cBox.Text.Length >= 3) search_cBox_display();
        }
        public static string reader_id = null;
        private void add_button_Click(object sender, EventArgs e)
        {

            Add_Reader_Form add_form = new Add_Reader_Form();
            this.Hide();
            add_form.ShowDialog();
            this.Close();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if (listReaders.SelectedItems.Count == 0)
            {
                MessageBox.Show("Виділіть читача, щоб редагувати!");
            }
            else
            {
                reader_id = listReaders.SelectedItems[0].Text;
                Add_Reader_Form add_form = new Add_Reader_Form();
                this.Hide();
                add_form.ShowDialog();
                this.Close();

            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (listReaders.SelectedItems.Count == 0)
            {
                MessageBox.Show("Виділіть читача, щоб видалити!");
            }
            else
            {
                
                string reader_id =listReaders.SelectedItems[0].Text;

                if (DialogResult.Yes == MessageBox.Show("Видалити " + listReaders.SelectedItems[0].SubItems[1].Text + " ?", "F", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    try
                    {
                        db.cmd.CommandText = "DELETE FROM readers WHERE reader_id = " + reader_id + ";";
                        db.cmd.ExecuteNonQuery();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    Update_ListView("SELECT * FROM readers");
                }

            }

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listReaders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string i = listReaders.SelectedItems[0].Text + "." + listReaders.SelectedItems[0].SubItems[1].Text;
            if (System.Windows.Forms.Application.OpenForms["Add_Issuance_Literature_Form"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["Add_Issuance_Literature_Form"] as Add_Issuance_Literature_Form).Set_reader(i);

            }
            this.Close();
        }
    }
    public class Reader
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Penalty { get; set; }
       
    }
}
