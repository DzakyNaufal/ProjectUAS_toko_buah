﻿using System;
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
    public partial class Form9 : Form
    {
        private string stringConnection = "data source=LAPTOP-69KQVMS1\\DZAKY_NAUFAL;" +
            "database=toko_buah;User ID=sa;Password=123";
        public Form9()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form10 fw = new Form10();
            fw.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form11 fe = new Form11();
            fe.Show();
            this.Hide();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
