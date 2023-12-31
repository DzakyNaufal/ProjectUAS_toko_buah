﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjectUAS_toko_buah
{
    public partial class Form12 : Form
    {
        private string stringConnection = "data source=LAPTOP-69KQVMS1\\DZAKY_NAUFAL;" +
            "database=toko_buah;User ID=sa;Password=123";
        private SqlConnection koneksi;
        public Form12()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            button1.Enabled = true;
            Clear.Enabled = true;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idrusak = textBox1.Text;
            string nmbuah = textBox2.Text;
            string totalrusak = textBox3.Text;

            if (idrusak == "")
            {
                MessageBox.Show("Masukkan Id Rusak", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(nmbuah == "")
            {
                MessageBox.Show("Masukkan Nama Buah", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(totalrusak == "")
            {
                MessageBox.Show("Masukkan Total Rusak", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.Memiliki (id_rusak, nama_buah, total_rusak) " +
                "values(@id_rusak, @nama_buah, @total_rusak)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id_rusak", idrusak));
                cmd.Parameters.Add(new SqlParameter("nama_buah", nmbuah));
                cmd.Parameters.Add(new SqlParameter("total_rusak", totalrusak));

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshform();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form11 fp = new Form11();
            fp.Show();
            this.Hide();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toko_buahDataSet.Memiliki' table. You can move, or remove it, as needed.
            this.memilikiTableAdapter.Fill(this.toko_buahDataSet.Memiliki);

        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select dbo,Memiliki";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            koneksi.Open();
            string str = "select * from dbo.Memiliki";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
    }
}
