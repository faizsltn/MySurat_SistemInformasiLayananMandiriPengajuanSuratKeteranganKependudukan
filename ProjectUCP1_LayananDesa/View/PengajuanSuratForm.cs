using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ProjectUCP1_LayananDesa.Controller;

namespace ProjectUCP1_LayananDesa.View
{
    public partial class PengajuanSuratForm : Form
    {
        private string nikPengaju;

        // Constructor kita ubah agar menerima NIK dari Dashboard
        public PengajuanSuratForm(string nik)
        {
            InitializeComponent();
            nikPengaju = nik;
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            // Validasi input
            if (string.IsNullOrEmpty(cbJenisSurat.Text) || string.IsNullOrEmpty(txtDeskripsi.Text))
            {
                MessageBox.Show("Jenis surat dan alasan tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Koneksi kon = new Koneksi();
            using (SqlConnection conn = kon.GetKoneksi())
            {
                try
                {
                    conn.Open();
                    // Query untuk memasukkan data ke tabel SURAT
                    string query = "INSERT INTO SURAT (nik, jenis_surat, deskripsi, status) VALUES (@nik, @jenis, @alasan, 'Pending')";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nik", nikPengaju);
                    cmd.Parameters.AddWithValue("@jenis", cbJenisSurat.Text);
                    cmd.Parameters.AddWithValue("@alasan", txtDeskripsi.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pengajuan Berhasil Dikirim!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Tutup form setelah berhasil
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mengirim pengajuan: " + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}//