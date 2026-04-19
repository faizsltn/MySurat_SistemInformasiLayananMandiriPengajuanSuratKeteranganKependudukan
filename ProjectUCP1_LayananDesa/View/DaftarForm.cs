using ProjectUCP1_LayananDesa.Controller;
using ProjectUCP1_LayananDesa.View;
using System;
using System.Data.SqlClient;
using System.Windows.Forms; 

namespace ProjectUCP1_LayananDesa
{
    public partial class DaftarForm : Form
    {
        public DaftarForm()
        {
            InitializeComponent();
        }


        private void btnDaftar_Click(object sender, EventArgs e)
        {
            // Validasi agar tidak ada data yang kosong
            if (string.IsNullOrWhiteSpace(txtNIK.Text) || string.IsNullOrWhiteSpace(txtNama.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtNoHP.Text))
            {
                MessageBox.Show("Mohon lengkapi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Koneksi kon = new Koneksi();
            using (SqlConnection conn = kon.GetKoneksi())
            {
                try
                {
                    conn.Open();
                    // Query untuk memasukkan data ke tabel WARGA
                    string query = "INSERT INTO WARGA (nik, nama, password, nomor_hp, alamat) VALUES (@nik, @nama, @pass, @hp, @alamat)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nik", txtNIK.Text);
                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@hp", txtNoHP.Text);
                    cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Akun berhasil dibuat! Silakan Login.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Setelah sukses, balik ke Login
                    LoginForm lg = new LoginForm();
                    lg.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mendaftar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
            this.Close();
        }
    }
}
