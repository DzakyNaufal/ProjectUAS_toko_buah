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
    public partial class Form6 : Form
    {
        private string stringConnection = "data source=LAPTOP-69KQVMS1\\DZAKY_NAUFAL;" +
            "database=toko_buah;User ID=sa;Password=123";
        private SqlConnection koneksi;
        public Form6()
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
            button3.Enabled = true;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form11 fp = new Form11();
            fp.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toko_buahDataSet.detail_jual' table. You can move, or remove it, as needed.
            this.detail_jualTableAdapter.Fill(this.toko_buahDataSet.detail_jual);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idjl = textBox1.Text;
            var tgljl = dateTimePicker1;
            string ttljl = textBox2.Text;

            if (idjl == "")
            {
                MessageBox.Show("Masukkan Id Jual", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ttljl == "")
            {
                MessageBox.Show("Masukkan Total Jual", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.detail_jual (id_jual, tgl_jual, total_jual) " +
                "values(@id_jual, @tgl_jual, @total_jual)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id_jual", idjl));
                cmd.Parameters.Add(new SqlParameter("tgl_jual", tgljl));
                cmd.Parameters.Add(new SqlParameter("total_jual", ttljl));

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            koneksi.Open();
            string str = "select * from dbo.detail_jual";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
    }
}
