using System;
using System.Windows.Forms;
using ProjectUCP1_LayananDesa.View;//

namespace ProjectUCP1_LayananDesa
{
    public partial class DashboardWargaForm : Form
    {
        // Kita siapkan variabel untuk menampung NIK asli agar bisa dipakai buat kirim surat
        private string nikUser;

        // SEKARANG: Constructor menerima DUA data (NIK dan Nama)
        public DashboardWargaForm(string nik, string nama)
        {
            InitializeComponent();

            // 1. Simpan NIK di memori (buat dipake di tombol pengajuan)
            nikUser = nik;

            // 2. Tampilkan NAMA di label (biar lebih ramah di layar)
            lblNamaWarga.Text = "Selamat Datang, " + nama;
        }//

        private void btnPengajuan_Click(object sender, EventArgs e)
        {
            // Mengirim NIK asli ke form pengajuan supaya tidak error Foreign Key
            PengajuanSuratForm ps = new PengajuanSuratForm(nikUser);
            ps.Show();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            // UPDATE: Kirim NIK juga ke form status supaya dia tau surat siapa yang mau dicek
            TrackingStatusForm ts = new TrackingStatusForm(nikUser);
            ts.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah anda yakin ingin Logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                LoginForm log = new LoginForm();
                log.Show();
                this.Close();
            }
        }
    }
}