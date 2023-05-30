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
    public partial class zakaz : Form
    {
        public zakaz()
        {
            InitializeComponent();
            dgvZakaz.DataSource = table();
            dgvZakaz.Refresh();
            dgvZakaz.Columns["id"].Visible = false;
        }

        private DataTable table()
        {
            DB db = new DB();
            db.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT zk.id, cl.FirstName + cl.LastName + cl.LastName Клиент, zk.date Дата, st.FirstName + st.LastName + st.GivenName Сотрудник" +
                " FROM zakaz zk" +
                " inner join client cl on cl.id = zk.client_id" +
                " inner join staff st on st.id = zk.staff_id", db.connection);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.closeConnection();
            return table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main mn = new main();
            mn.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvZakaz_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvPosition.DataSource = tablePosition();
        }

        private object tablePosition()
        {
            if (dgvZakaz.Rows.Count == 1)
                return new object();

            int id = int.Parse(dgvZakaz.SelectedRows[0].Cells["id"].Value.ToString());
            DB db = new DB();
            db.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand(@"select * from zakaz_position zp where zp.id = {id}", db.connection);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.closeConnection();
            return table;
        }
    }
}
