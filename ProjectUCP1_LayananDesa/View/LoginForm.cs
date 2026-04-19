using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ProjectUCP1_LayananDesa.Controller;

namespace ProjectUCP1_LayananDesa.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        //

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. Validasi Input
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(cbRole.Text))
            {
                MessageBox.Show("Username/Nama, Password, dan Role wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Koneksi kon = new Koneksi();
            using (SqlConnection conn = kon.GetKoneksi())
            {
                try
                {
                    conn.Open();

                    if (cbRole.Text == "Warga")
                    {
                        // QUERY WARGA: Ambil NIK dan Nama sekaligus
                        string query = "SELECT nik, nama FROM WARGA WHERE nama=@user AND password=@pass";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string nikAsli = reader["nik"].ToString();
                            string namaAsli = reader["nama"].ToString();

                            MessageBox.Show("Login Berhasil! Selamat Datang " + namaAsli, "Sukses");

                            // KIRIM DUA DATA ke DashboardWarga
                            DashboardWargaForm dw = new DashboardWargaForm(nikAsli, namaAsli);
                            dw.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Nama atau Password Warga salah!", "Gagal");
                        }
                    }
                    else if (cbRole.Text == "Admin")
                    {
                        // QUERY ADMIN: Pakai COUNT saja karena Admin tidak punya relasi NIK
                        string query = "SELECT COUNT(*) FROM ADMIN WHERE username=@user AND password=@pass";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

                        int result = Convert.ToInt32(cmd.ExecuteScalar());

                        if (result > 0)
                        {
                            MessageBox.Show("Login Berhasil sebagai Admin", "Sukses");
                            DashboardAdminForm da = new DashboardAdminForm();
                            da.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username atau Password Admin salah!", "Gagal");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal terhubung ke Database: " + ex.Message, "Error Koneksi");
                }
            }
        }
        //

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            DaftarForm df = new DaftarForm();
            df.Show();
            this.Hide();
        }
    }
}
//