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
    public partial class tovar : Form
    {


        public tovar()
        {
            InitializeComponent();

            dgvSklad.DataSource = table();

            dgvSklad.Refresh();

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            



        }

        private List<dynamic> GetSklad()
        {
            var data = new List<dynamic>();
            using (MySqlConnection connection = new MySqlConnection(DB.SqlConnection))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("select id, name, count, price,description,postavka_id from tovar", connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var a = new
                        {
                            id = int.Parse(reader.GetValue(0).ToString()),
                            name = reader.GetString(1),
                            count = int.Parse(reader.GetValue(2).ToString()),
                            price = int.Parse(reader.GetValue(3).ToString()),
                            description = reader.GetString(4),
                            postavka_id = int.Parse(reader.GetValue(5).ToString())
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
            MySqlCommand command = new MySqlCommand("select id, name, count, price,description,postavka_id	 from tovar", db.connection);
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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void sklad_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }




        private void button2_Click_1(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand($"INSERT INTO `tovar`( `name`, `count`, `price`, `description`, `postavka_id`) VALUES('{ textBox1.Text}','{ textBox2.Text}', '{textBox3.Text}' , '{textBox4.Text}', '{textBox5.Text}')",
                db.connection);

            MessageBox.Show(command.ExecuteNonQuery().ToString());


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand($"DELETE FROM `tovar` WHERE ({textBox6.Text})",
                db.connection);

            MessageBox.Show(command.ExecuteNonQuery().ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form tovar = new tovar();
            tovar.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form tovar = new tovar();
            tovar.Show();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
    /*
     sklad:
    sklad_ID
    sklad_name
    sklad_address

    goods:
    goods_ID
    goods_name
    goods_count
    sklad_ID
    {textBox1.Text}',N'{textBox2.Text}',N'{textBox3.Text}',N'{textBox4.Text}',N'{textBox5.Text}
     */





