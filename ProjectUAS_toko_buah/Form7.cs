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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void refreshform()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            dateTimePicker1.Enabled = false;
            Clear.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form11 fp = new Form11();
            fp.Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            dateTimePicker1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string idpmsk = textBox1.Text;
            string idbh = textBox2.Text;
            string rspngrmn = textBox3.Text;

            if (idpmsk == "")
            {
                MessageBox.Show("Masukkan Id Pemasok", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (idbh == "")
            {
                MessageBox.Show("Masukkan Id Buah", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (rspngrmn == "")
            {
                MessageBox.Show("Masukkan Resi Pengiriman", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
