using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ProjectUCP1_LayananDesa.Controller;

namespace ProjectUCP1_LayananDesa
{
    public partial class TrackingStatusForm : Form
    {
        private string nikWarga;

        // Constructor menerima NIK dari Dashboard
        public TrackingStatusForm(string nik)
        {
            InitializeComponent();
            nikWarga = nik;
        }
        
        private void TampilStatus()
        {
            Koneksi kon = new Koneksi();
            using (SqlConnection conn = kon.GetKoneksi())
            {
                try
                {
                    conn.Open();

                    // PERBAIKAN: Gunakan 'deskripsi' sesuai nama di database kamu
                    string query = "SELECT id_pengajuan, jenis_surat, deskripsi, status FROM SURAT WHERE nik = @nik";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nik", nikWarga);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    // Pastikan dgvStatus adalah nama DataGridView di Design kamu
                    dgvStatus.DataSource = dt;

                    // Setting tampilan agar rapi dan tidak kepotong
                    dgvStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvStatus.RowHeadersVisible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat status: " + ex.Message);
                }
            }
        }

        private void TrackingStatusForm_Load(object sender, EventArgs e)
        {
            TampilStatus();
        }
    }
}//