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
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();

            dgvClient.DataSource = table();

            dgvClient.Refresh();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private List<dynamic> GetClient()
        {
            var data = new List<dynamic>();
            using (MySqlConnection connection = new MySqlConnection(DB.SqlConnection))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("select id, FirstName, LastName, GivenName,address from client", connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var a = new
                        {
                            id = int.Parse(reader.GetValue(0).ToString()),
                            FirstName = reader.GetString(1),
                            LastName = int.Parse(reader.GetValue(2).ToString()),
                            GivenName = int.Parse(reader.GetValue(3).ToString()),
                            address = int.Parse(reader.GetValue(4).ToString()),

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
            MySqlCommand command = new MySqlCommand("select id, FirstName, LastName, GivenName,address from client", db.connection);
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

        private void client_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand($"INSERT INTO `client`(`FirstName`, `LastName`, `GivenName`, `address`) VALUES('{textBox1.Text}','{textBox2.Text}', '{textBox3.Text}' , '{textBox4.Text}' )",
                db.connection);

            MessageBox.Show(command.ExecuteNonQuery().ToString());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            main mn = new main();
            mn.Show();
            this.Hide();
            mn.FormClosed += (ls, le) => this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form client = new client();
            client.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            main mn = new main();
            mn.Show();
            this.Hide();
            mn.FormClosed += (ls, le) => this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand($"DELETE FROM `client` WHERE ({textBox5.Text})",
                db.connection);

            MessageBox.Show(command.ExecuteNonQuery().ToString());
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form tovar = new tovar();
            tovar.Show();
        }
    }
}
