using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ProjectUCP1_LayananDesa.Controller;

namespace ProjectUCP1_LayananDesa.View
{
    public partial class PengajuanSuratForm : Form
    {
        private string nikPengaju;

        public PengajuanSuratForm(string nik)
        {
            InitializeComponent();
            nikPengaju = nik;
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            // 1. VALIDASI KOSONG
            if (string.IsNullOrEmpty(cbJenisSurat.Text) || string.IsNullOrEmpty(txtDeskripsi.Text))
            {
                MessageBox.Show("Jenis surat dan deskripsi tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. VALIDASI REVISI (HANYA HURUF & SPASI)
            // Pola: ^[a-zA-Z\s]+$ 
            // a-zA-Z = Huruf saja
            // \s = Spasi saja
            // Angka (0-9) dan Simbol (@#$%) akan otomatis ditolak
            string polaHanyaHuruf = @"^[a-zA-Z\s]+$";

            if (!Regex.IsMatch(cbJenisSurat.Text, polaHanyaHuruf))
            {
                MessageBox.Show("Jenis surat hanya boleh berisi huruf dan spasi (Tidak boleh angka/simbol)!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // Untuk deskripsi, kita beri kelonggaran boleh angka (0-9) dan titik (.) 
            // karena biasanya orang menulis alasan pakai nomor atau singkatan
            string polaDeskripsi = @"^[a-zA-Z0-9\s\.]+$";
            if (!Regex.IsMatch(txtDeskripsi.Text, polaDeskripsi))
            {
                MessageBox.Show("Deskripsi tidak boleh mengandung simbol karakter khusus!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // 3. PROSES SIMPAN KE DATABASE
            Koneksi kon = new Koneksi();
            using (SqlConnection conn = kon.GetKoneksi())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO SURAT (nik, jenis_surat, deskripsi, status) VALUES (@nik, @jenis, @alasan, 'Pending')";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nik", nikPengaju);
                    cmd.Parameters.AddWithValue("@jenis", cbJenisSurat.Text);
                    cmd.Parameters.AddWithValue("@alasan", txtDeskripsi.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pengajuan Berhasil Dikirim!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mengirim pengajuan: " + ex.Message);
                }
            }
        }
