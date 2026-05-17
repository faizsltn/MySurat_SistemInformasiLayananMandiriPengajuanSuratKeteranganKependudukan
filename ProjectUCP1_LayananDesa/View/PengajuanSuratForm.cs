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
