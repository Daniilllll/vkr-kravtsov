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
    public partial class postavhik : Form
    {
        public postavhik()
        {
            InitializeComponent();

            dgvPostavhiki.DataSource = table();

            dgvPostavhiki.Refresh();
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
                MySqlCommand command = new MySqlCommand("select id, name, adress, tel from postavhik", connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var a = new
                        {
                            id = int.Parse(reader.GetValue(0).ToString()),
                            name = reader.GetString(1),
                            address = int.Parse(reader.GetValue(2).ToString()),
                            phone = int.Parse(reader.GetValue(3).ToString()),
                            

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
            MySqlCommand command = new MySqlCommand("select id, name, address, phone from postavshik", db.connection);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.closeConnection();
            return table;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            {
                main mn = new main();
                mn.Show();
                this.Hide();
                mn.FormClosed += (ls, le) => this.Close();
            }
        }

        private void postavhik_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form postavhik = new postavhik();
            postavhik.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand($"INSERT INTO `postavshik`(`name`, `address`, `phone`) VALUES  ('{textBox1.Text}','{textBox2.Text}', '{textBox3.Text}' )",
                db.connection);

            MessageBox.Show(command.ExecuteNonQuery().ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand($"DELETE FROM `postavshik` WHERE ({textBox4.Text})",
                db.connection);

            MessageBox.Show(command.ExecuteNonQuery().ToString());
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form postavshik = new postavhik();
            postavshik.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            main mn = new main();
            mn.Show();
            this.Hide();
            mn.FormClosed += (ls, le) => this.Close();
        }
    }
}
