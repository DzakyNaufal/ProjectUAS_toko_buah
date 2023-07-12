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
    public partial class Form5 : Form
    {
        public Form5()
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
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form11 fp = new Form11();
            fp.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            dateTimePicker1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idbh = textBox1.Text;
            string KuBl = textBox2.Text;
            string ToBl = textBox3.Text;

            if (idbh == "")
            {
                MessageBox.Show("Masukkan Id Buah", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (KuBl == "")
            {
                MessageBox.Show("Masukkan Kuantitas Beli", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ToBl == "")
            {
                MessageBox.Show("Masukkan Total Beli", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
