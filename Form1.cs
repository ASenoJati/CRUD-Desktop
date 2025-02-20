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
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM materi2",conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma",11,FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial",12,FontStyle.Regular);
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
    }
}
