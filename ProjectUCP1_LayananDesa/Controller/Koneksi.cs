using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectUCP1_LayananDesa.Controller
{
    internal class Koneksi
    {
        // Sudah saya ganti sesuai nama server laptop kamu
        private string stringKoneksi = @"Data Source=Faizsltn-27\FAIZSLTN;Initial Catalog=LayananDesa_DB;Integrated Security=True";

        public SqlConnection GetKoneksi()
        {
            SqlConnection conn = new SqlConnection(stringKoneksi);
            return conn;
        }
    }
}