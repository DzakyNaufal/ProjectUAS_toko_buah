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
    public partial class Form7 : Form
    {
        private string stringConnection = "data source=LAPTOP-69KQVMS1\\DZAKY_NAUFAL;" +
            "database=toko_buah;User ID=sa;Password=123";
        private SqlConnection koneksi;
        public Form7()
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
            // TODO: This line of code loads data into the 'toko_buahDataSet.Mengirim' table. You can move, or remove it, as needed.
            this.mengirimTableAdapter.Fill(this.toko_buahDataSet.Mengirim);

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
            else
            {
                koneksi.Open();
                string str = "insert into dbo.Mengirim (id_pengirim, nmr_buah, resi_pengiriman) " +
                "values(@id_pengirim, @nmr_buah, @resi_pengiriman)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id_pengirim", idpmsk));
                cmd.Parameters.Add(new SqlParameter("nmr_buah", idbh));
                cmd.Parameters.Add(new SqlParameter("resi_pengiriman", rspngrmn));

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshform();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            koneksi.Open();
            string str = "select * from dbo.Mengirim";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
    }
}
