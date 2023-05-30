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
    public partial class plateh : Form
    {
        public plateh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main mn = new main();
            mn.Show();
            this.Hide();
            mn.FormClosed += (ls, le) => this.Close();
        }

        private void plateh_Load(object sender, EventArgs e)
        {

        }
    }
}
