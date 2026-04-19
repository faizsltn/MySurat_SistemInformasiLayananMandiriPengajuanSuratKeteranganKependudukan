using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectUCP1_LayananDesa.View; // Pastikan tambahkan ini agar dia kenal folder View

namespace ProjectUCP1_LayananDesa
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // GANTI baris ini supaya yang pertama muncul adalah Login
            Application.Run(new LoginForm());
        }
    }
}