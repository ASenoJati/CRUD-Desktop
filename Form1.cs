using Microsoft.Data.SqlClient;
using System.Data;
//using System.Data.SqlClient;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=SENO;Initial Catalog=materi2;Integrated Security=True;TrustServerCertificate=True");

        private void bind_data()
        {
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM materi2", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO materi2(noid,namaDepan,namaBelakang,nilai)Values(@noid,@namaDepan,@namaBelakang,@nilai)", conn);
            cmd.Parameters.AddWithValue("@noid", txtNoID.Text);
            cmd.Parameters.AddWithValue("@namaDepan", txtNamaDepan.Text);
            cmd.Parameters.AddWithValue("@namaBelakang", txtNamaBelakang.Text);
            cmd.Parameters.AddWithValue("@nilai", txtNilai.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            bind_data();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView1.Rows[index];
            txtNoID.Text = selectedrow.Cells[0].Value.ToString();
            txtNamaDepan.Text = selectedrow.Cells[1].Value.ToString();
            txtNamaBelakang.Text = selectedrow.Cells[2].Value.ToString();
            txtNilai.Text = selectedrow.Cells[3].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNoID.Text = string.Empty;
            txtNamaDepan.Text = string.Empty;
            txtNamaBelakang.Text = string.Empty;
            txtNilai.Text = string.Empty;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin Ingin Diupdate?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("UPDATE materi2 SET noid=@noid,namaDepan=@namaDepan,namaBelakang=@namaBelakang,nilai=@nilai WHERE noid=@noid", conn);
                cmd.Parameters.AddWithValue("@noid", txtNoID.Text);
                cmd.Parameters.AddWithValue("@namaDepan", txtNamaDepan.Text);
                cmd.Parameters.AddWithValue("@namaBelakang", txtNamaBelakang.Text);
                cmd.Parameters.AddWithValue("@nilai", txtNilai.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                bind_data();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin Ingin Dihapus?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM materi2 WHERE noid=@noid", conn);
                cmd.Parameters.AddWithValue("@noid", txtNoID.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                bind_data();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM materi2 WHERE namadepan like @namadepan+'%'", conn);
            cmd.Parameters.AddWithValue("@namadepan", txtSearch.Text);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
        }
    }
}
