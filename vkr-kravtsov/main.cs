using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data.SqlClient;

namespace vkr_kravtsov
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            tovar mn = new tovar();
            mn.Show();
            this.Hide();
            mn.FormClosed += (ls, le) => this.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            postavhik  mn = new postavhik();
            mn.Show();
            this.Hide();
            mn.FormClosed += (ls, le) => this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            dogovor mn = new dogovor();
            mn.Show();
            this.Hide();
            mn.FormClosed += (ls, le) => this.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            plateh mn = new plateh ();
            mn.Show();
            this.Hide();
            mn.FormClosed += (ls, le) => this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zakaz mn = new zakaz();
            mn.Show();
            this.Hide();
            mn.FormClosed += (ls, le) => this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sotrudniki mn = new sotrudniki();
            mn.Show();
            this.Hide();
            mn.FormClosed += (ls, le) => this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            client mn = new client();
            mn.Show();
            this.Hide();
            mn.FormClosed += (ls, le) => this.Close();
        }

       

        

        private void button6_Click(object sender, EventArgs e)
        {
            postavki mn = new postavki();
            mn.Show();
            this.Hide();
            mn.FormClosed += (ls, le) => this.Close();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

