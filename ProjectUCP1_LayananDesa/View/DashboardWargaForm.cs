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
        }
