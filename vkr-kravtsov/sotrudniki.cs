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
    public partial class sotrudniki : Form
    {
        public sotrudniki()
        {
            InitializeComponent();
            
            dgvSotrudniki.DataSource = table();

            dgvSotrudniki.Refresh();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private List<dynamic> GetStaff()
        {
            var data = new List<dynamic>();
            using (MySqlConnection connection = new MySqlConnection(DB.SqlConnection))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("select id, FirstName,LastName,GivenName,BirthDate,post_id  from staff", connection);
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
                            BirthDate = int.Parse(reader.GetValue(4).ToString()),
                            post_id = int.Parse(reader.GetValue(5).ToString()),
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
            MySqlCommand command = new MySqlCommand("select id, FirstName,LastName,GivenName,BirthDate,post_id  from staff", db.connection);
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

        private void sotrudniki_Load(object sender, EventArgs e)
        {
            main mn = new main();
            mn.Show();
            this.Hide();
            mn.FormClosed += (ls, le) => this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand($"INSERT INTO `staff`( `FirstName`, `LastName`, `GivenName`, `BirthDate`, `post_id`) VALUES ('{textBox1.Text}','{textBox2.Text}', '{textBox3.Text}' , '{textBox4.Text}' , '{textBox5.Text}')",
                db.connection);

            MessageBox.Show(command.ExecuteNonQuery().ToString());
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form sotrudniki = new sotrudniki();
            sotrudniki.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form sotrudniki = new sotrudniki();
            sotrudniki.Show();
        }

        private void button6_Click(object sender, EventArgs e)
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

            MySqlCommand command = new MySqlCommand($"INSERT INTO `staff`( `FirstName`, `LastName`, `GivenName`, `BirthDate`, `post_id`) VALUES ('{textBox1.Text}','{textBox2.Text}', '{textBox3.Text}' , '{textBox4.Text}' , '{textBox5.Text}')",
                db.connection);

            MessageBox.Show(command.ExecuteNonQuery().ToString());
        }
    }
}
