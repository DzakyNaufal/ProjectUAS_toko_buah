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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form10 fp = new Form10();
            fp.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toko_buahDataSet1.pemasok' table. You can move, or remove it, as needed.
            this.pemasokTableAdapter.Fill(this.toko_buahDataSet1.pemasok);

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
            else
            {
                koneksi.Open();
                string str = "insert into dbo.buah_rusak (Nama_Pemasok, Id_Pemasok, Alamat, No_Hp, Email) " +
                "values(@Nama_Pemasok, @Id_Pemasok, @Alamat, @No_Hp, @Email)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("Nama_Pemasok", nmpmsk));
                cmd.Parameters.Add(new SqlParameter("Id_Pemasok", idpmsk));
                cmd.Parameters.Add(new SqlParameter("Alamat", almt));
                cmd.Parameters.Add(new SqlParameter("No_Hp", nohp));
                cmd.Parameters.Add(new SqlParameter("Email", email));
                

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshform();
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void datagridview()
        {
            koneksi.Open();
            string str = "select * from dbo.pemasok";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
