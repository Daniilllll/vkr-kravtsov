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
using MySql.Data.MySqlClient;
using System.IO;

namespace vkr_kravtsov
{
    public partial class postavki : Form
    {
        public postavki()
        {
            InitializeComponent();
            InitializeComponent();
            dgvPostavki.DataSource = table();
            dgvPostavki.Refresh();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private List<dynamic> GetPostavhiki()
        {
            var data = new List<dynamic>();
            using (MySqlConnection connection = new MySqlConnection(DB.SqlConnection))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("select id, postavshik_id, date from postavki", connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var a = new
                        {
                            id = int.Parse(reader.GetValue(0).ToString()),
                            postavshik_id = reader.GetString(1),
                            date = int.Parse(reader.GetValue(2).ToString()),
                            


                        };
                        data.Add(a);
                    }
                }
                connection.Close();
            }
            return data;
        }

        private DataTable table()
        {
            DB db = new DB();
            db.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("select id, postavshik_id, date from postavki", db.connection);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.closeConnection();
            return table;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            main mn = new main();
            mn.Show();
            this.Hide();
            mn.FormClosed += (ls, le) => this.Close();
        }

        private void postavki_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            main mn = new main();
            mn.Show();
            this.Hide();
            mn.FormClosed += (ls, le) => this.Close();

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("select id, postavshik_id, date from postavki", db.connection);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.closeConnection();
            return table;
        }
    }
}
