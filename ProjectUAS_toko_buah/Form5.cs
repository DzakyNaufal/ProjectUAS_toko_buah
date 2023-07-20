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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjectUAS_toko_buah
{
    public partial class Form5 : Form
    {
        private string stringConnection = "data source=LAPTOP-69KQVMS1\\DZAKY_NAUFAL;" +
            "database=toko_buah;User ID=sa;Password=123";
        private SqlConnection koneksi;
        public Form5()
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
            // TODO: This line of code loads data into the 'toko_buahDataSet.detail_jual' table. You can move, or remove it, as needed.
            this.detail_jualTableAdapter.Fill(this.toko_buahDataSet.detail_jual);
            // TODO: This line of code loads data into the 'toko_buahDataSet.detail_beli' table. You can move, or remove it, as needed.
            this.detail_beliTableAdapter.Fill(this.toko_buahDataSet.detail_beli);
            // TODO: This line of code loads data into the 'toko_buahDataSet.pemasok' table. You can move, or remove it, as needed.
            this.pemasokTableAdapter.Fill(this.toko_buahDataSet.pemasok);

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
            var tglbl = dateTimePicker1;
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
            else
            {
                koneksi.Open();
                string str = "insert into dbo.detail_beli (id_buah, tgl_beli, kuantitas_beli, total_beli) " +
                "values(@id_buah, @tgl_beli, @kuantitas_beli, @total_beli)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id_buah", idbh));
                cmd.Parameters.Add(new SqlParameter("tgl_beli", tglbl));
                cmd.Parameters.Add(new SqlParameter("kuantitas_beli", KuBl));
                cmd.Parameters.Add(new SqlParameter("total_beli", ToBl));

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshform();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            koneksi.Open();
            string str = "select * from dbo.detail_beli";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
    }
}
