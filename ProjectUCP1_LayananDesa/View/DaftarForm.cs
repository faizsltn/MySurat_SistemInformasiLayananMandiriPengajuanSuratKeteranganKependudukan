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

