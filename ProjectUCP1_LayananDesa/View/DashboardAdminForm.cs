using ProjectUCP1_LayananDesa.Controller;
using ProjectUCP1_LayananDesa.View;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;//

namespace ProjectUCP1_LayananDesa
{
    public partial class DashboardAdminForm : Form
    {
        public DashboardAdminForm()
        {
            InitializeComponent();
        }

        private void TampilData()
        {
            Koneksi kon = new Koneksi();
            using (SqlConnection conn = kon.GetKoneksi())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM SURAT";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    dgvSuratMasuk.DataSource = dt;//

                    // --- SETTING AGAR TAMPILAN FULL & TIDAK KEPOTONG ---
                    dgvSuratMasuk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Kolom melebar otomatis
                    dgvSuratMasuk.DefaultCellStyle.WrapMode = DataGridViewTriState.True;     // Teks panjang bakal turun ke bawah
                    dgvSuratMasuk.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Tinggi baris menyesuaikan isi
                    dgvSuratMasuk.RowHeadersVisible = false;                                // Menghilangkan kolom abu-abu di kiri
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal muat data: " + ex.Message);
                }
            }
        }

        private void DashboardAdminForm_Load(object sender, EventArgs e) { TampilData(); }
        private void btnRefresh_Click(object sender, EventArgs e) { TampilData(); }

        private void btnSetujui_Click(object sender, EventArgs e) { UpdateStatusSurat("Disetujui"); }
        private void btnTolak_Click(object sender, EventArgs e) { UpdateStatusSurat("Ditolak"); }

        private void UpdateStatusSurat(string statusBaru)
        {
            if (dgvSuratMasuk.CurrentRow != null)
            {
                try
                {
                    // Ambil ID dari kolom 'id_pengajuan' sesuai gambar database kamu
                    string idSurat = dgvSuratMasuk.CurrentRow.Cells["id_pengajuan"].Value.ToString();

                    Koneksi kon = new Koneksi();
                    using (SqlConnection conn = kon.GetKoneksi())
                    {
                        conn.Open();
                        // KUNCI PERBAIKAN: Harus pakai id_pengajuan
                        string query = "UPDATE SURAT SET status = @status WHERE id_pengajuan = @id";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@status", statusBaru);
                        cmd.Parameters.AddWithValue("@id", idSurat);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Surat berhasil " + statusBaru + "!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TampilData(); // Refresh tabel biar status langsung berubah
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal update status: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih data surat di tabel dulu!", "Peringatan");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }
    }
}