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

namespace ProjectUAS_toko_buah
{
    public partial class Form4 : Form
    {
        private string stringConnection = "data source=LAPTOP-69KQVMS1\\DZAKY_NAUFAL;" +
            "database=toko_buah;User ID=sa;Password=123";
        private SqlConnection koneksi;
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form10 fp = new Form10();
            fp.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void refreshform()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nmpmsk = textBox1.Text;
            string idpmsk = textBox2.Text;
            string almt = textBox3.Text;
            string nohp = textBox4.Text;
            string email = textBox5.Text;

            if (nmpmsk == "")
            {
                MessageBox.Show("Masukkan Nama Pemasok", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (idpmsk == "")
            {
                MessageBox.Show("Masukkan Id Pemasok", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (almt == "")
            {
                MessageBox.Show("Masukkan Alamat", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nohp == "")
            {
                MessageBox.Show("Masukkan No Hp", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (email == "")
            {
                MessageBox.Show("Masukkan Email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            refreshform();
        }
    }
}
