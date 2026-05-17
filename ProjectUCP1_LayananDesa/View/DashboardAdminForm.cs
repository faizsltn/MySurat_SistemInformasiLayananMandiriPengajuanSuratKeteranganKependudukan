using ProjectUCP1_LayananDesa.Controller;
using ProjectUCP1_LayananDesa.View;
using System;
using System.Data;
using System.Windows.Forms;
namespace ProjectUCP1_LayananDesa
{
    public partial class DashboardAdminForm : Form
    {
        // Variabel penampung identitas admin yang login
        private string idAdminAktif;

        public DashboardAdminForm(string idAdmin, string namaAdmin)
        {
            InitializeComponent();
            this.idAdminAktif = idAdmin;

            // =========================================================================
            // ANTISIPASI DOUBLE EVENT GANDA (Biar MessageBox tidak muncul 2x)
            // =========================================================================
            // Langkah 1: Cabut antrean click lama (jika sudah didaftarkan oleh desainer)
            this.btnSetujui.Click -= this.btnSetujui_Click;
            this.btnTolak.Click -= this.btnTolak_Click;
            this.btnRefresh.Click -= this.btnRefresh_Click;
            this.btnHapus.Click -= this.btnHapus_Click;

            // Langkah 2: Daftarkan kembali secara bersih murni 1 jalur resmi
            this.btnSetujui.Click += new System.EventHandler(this.btnSetujui_Click);
            this.btnTolak.Click += new System.EventHandler(this.btnTolak_Click);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
        }

        // 1. EVENT LOAD FORM UTAMA (Sesuai Standar Automasi Modul 8)
        private void DashboardAdminForm_Load(object sender, EventArgs e)
        {
            TampilDataOtomatis();
        }

        // 2. FUNGSI UNTUK REFRESH / AMBIL DATA DISCONNECTED (TableAdapter)
        private void TampilDataOtomatis()
        {
            try
            {
                // Mengambil data murni Disconnected ke memori DataSet lokal laptop
                this.sURATTableAdapter.Fill(this.layananDesa_DBDataSet.SURAT);

                // Pengaturan visual DataGridView agar rapi
                dgvSuratMasuk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvSuratMasuk.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
