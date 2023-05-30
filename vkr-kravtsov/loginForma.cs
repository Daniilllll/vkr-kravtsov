using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vkr_kravtsov
{
    public partial class loginForma : Form
    {
        public loginForma()
        {
            InitializeComponent();

        }

        private void loginForma_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void passField_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void Bhod_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passUser = passField.Text;

            DB db = new DB();
            db.openConnection();

            DataTable table =  new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand($"SELECT * FROM user where login = \'{loginField.Text}\' and pass = \'{passField.Text}\'", db.connection);
            
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Авторизация успешна");
                main mn = new main();
                mn.Show();
                this.Hide();
                mn.FormClosed += (ls, le) => this.Close();
            }
            else
                MessageBox.Show("Нет авторизации");
            db.closeConnection();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
