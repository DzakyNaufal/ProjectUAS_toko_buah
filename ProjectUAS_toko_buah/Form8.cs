using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectUAS_toko_buah
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void refreshform()
        {
            textBox1.Text = "";
            textBox2.Text = "";           
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            dateTimePicker1.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            Button3.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form10 fn = new Form10();
            fn.Show();
            this.Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string idrsk = textBox1.Text;
            string ttlrskk = textBox2.Text;   

            if (idrsk == "")
            {
                MessageBox.Show("Masukkan Id Rusak", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ttlrskk == "")
            {
                MessageBox.Show("Masukkan Total Rusak", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            dateTimePicker1.Enabled = true; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            refreshform();
        }
    }
}
