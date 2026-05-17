using System;
using System.Windows.Forms;

namespace ProjectUCP1_LayananDesa
{
    public partial class TrackingStatusForm : Form
    {
        private string nikWarga;

        // Constructor menerima NIK dari Dashboard Warga
        public TrackingStatusForm(string nik)
        {
            InitializeComponent();
            nikWarga = nik;
        }

        // EVENT LOAD FORM (Menggunakan Filter Disconnected Architecture Sesuai Modul 8)
        private void TrackingStatusForm_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Mengambil data dari database ke memori RAM lokal DataSet
                this.sURATTableAdapter.Fill(this.layananDesa_DBDataSet.SURAT);

                // 2. KUNCI SINKRONISASI: Filter data langsung pada komponen BindingSource
                sURATBindingSource.Filter = string.Format("nik = '{0}'", nikWarga);

                // 3. Pastikan DataGridView kamu memakai sURATBindingSource sebagai sumber datanya
                dgvStatus.DataSource = sURATBindingSource;

                // 4. Pengaturan visual tabel agar rapi dan proporsional
                dgvStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvStatus.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat status pengajuan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}