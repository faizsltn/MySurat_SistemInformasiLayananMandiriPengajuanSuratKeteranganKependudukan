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
