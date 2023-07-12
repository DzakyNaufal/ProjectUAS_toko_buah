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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 fq = new Form6();
            fq.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form9 fq = new Form9();
            fq.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 fq = new Form5();
            fq.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 fp = new Form7();
            fp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form12 fp = new Form12();
            fp.Show();
            this.Hide();
        }
    }
}
