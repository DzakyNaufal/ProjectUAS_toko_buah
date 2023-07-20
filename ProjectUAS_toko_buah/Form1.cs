using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUAS_toko_buah
{

    public partial class Form1 : Form
    {
        private string stringConnection = "data source=LAPTOP-69KQVMS1\\DZAKY_NAUFAL;" +
            "database=toko_buah;User ID=sa;Password=123";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void refreshform()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 fs = new Form9();
            fs.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshform();
        }
    }
}
