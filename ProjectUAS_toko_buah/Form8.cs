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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjectUAS_toko_buah
{
    public partial class Form8 : Form
    {
        private string stringConnection = "data source=LAPTOP-69KQVMS1\\DZAKY_NAUFAL;" +
            "database=toko_buah;User ID=sa;Password=123";
        private SqlConnection koneksi;
        public Form8()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
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
            // TODO: This line of code loads data into the 'toko_buahDataSet.buah_rusak' table. You can move, or remove it, as needed.
            this.buah_rusakTableAdapter.Fill(this.toko_buahDataSet.buah_rusak);

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string idrsk = textBox1.Text;
            var tglrsk = dateTimePicker1;
            string ttlrskk = textBox2.Text;   

            if (idrsk == "")
            {
                MessageBox.Show("Masukkan Id Rusak", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ttlrskk == "")
            {
                MessageBox.Show("Masukkan Total Rusak", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.buah_rusak (id_rusak, tgl_rusak, total_rusak) " +
                "values(@id_rusak, @tgl_rusak, @total_rusak)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id_rusak", idrsk));
                cmd.Parameters.Add(new SqlParameter("tgl_rusak", tglrsk));
                cmd.Parameters.Add(new SqlParameter("total_rusak", ttlrskk));

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshform();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            koneksi.Open();
            string str = "select * from dbo.buah_rusak";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
    }
}
