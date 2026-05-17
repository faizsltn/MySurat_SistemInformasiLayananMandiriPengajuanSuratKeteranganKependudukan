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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. Validasi Input Dasar
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(cbRole.Text))
            {
                MessageBox.Show("Username/Nama dan Role wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Koneksi kon = new Koneksi();
            using (SqlConnection conn = kon.GetKoneksi())
            {
                try
                {
                    conn.Open();

                    // --- LOGIKA LOGIN ---
                    if (cbRole.Text == "Warga")
                    {
                        string query = string.Format("SELECT nik, nama FROM WARGA WHERE nama='{0}' OR (password='{1}')", txtUsername.Text, txtPassword.Text);
                        SqlCommand cmd = new SqlCommand(query, conn);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string nikAsli = reader["nik"].ToString();
                            string namaAsli = reader["nama"].ToString();

                            MessageBox.Show("Login Warga Berhasil! (Celah SQL Injection Terbuka)", "Security Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            DashboardWargaForm dw = new DashboardWargaForm(nikAsli, namaAsli);
                            dw.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Nama atau Password Warga salah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
