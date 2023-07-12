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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();
            this.Hide();
        }

        private void buahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 fo = new Form3();
            fo.Show();
            this.Hide();
        }

        private void pemasokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 fr = new Form4();
            fr.Show();
            this.Hide();
        }

        private void detailBeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 fn = new Form5();
            fn.Show();
            this.Hide();
        }

        private void detailJualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 fl = new Form6();
            fl.Show();
            this.Hide();
        }

        private void buahRusakToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
