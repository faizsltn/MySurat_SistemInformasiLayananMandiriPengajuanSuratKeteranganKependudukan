namespace ProjectUCP1_LayananDesa
{
    partial class DashboardWargaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblNamaWarga = new System.Windows.Forms.Label();
            this.btnPengajuan = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(260, 35);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(298, 25);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Layanan Mandiri Warga Desa";
            // 
            // lblNamaWarga
            // 
            this.lblNamaWarga.AutoSize = true;
            this.lblNamaWarga.Location = new System.Drawing.Point(284, 140);
            this.lblNamaWarga.Name = "lblNamaWarga";
            this.lblNamaWarga.Size = new System.Drawing.Size(199, 16);
            this.lblNamaWarga.TabIndex = 1;
            this.lblNamaWarga.Text = "Selamat Datang, [Nama Warga]";
            // 
            // btnPengajuan
            // 
            this.btnPengajuan.Location = new System.Drawing.Point(130, 260);
            this.btnPengajuan.Name = "btnPengajuan";
            this.btnPengajuan.Size = new System.Drawing.Size(168, 46);
            this.btnPengajuan.TabIndex = 2;
            this.btnPengajuan.Text = "Ajukan Surat";
            this.btnPengajuan.UseVisualStyleBackColor = true;
            this.btnPengajuan.Click += new System.EventHandler(this.btnPengajuan_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(454, 260);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(168, 46);
            this.btnStatus.TabIndex = 3;
            this.btnStatus.Text = "Cek Status Pengajuan";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.MistyRose;
            this.btnLogout.Location = new System.Drawing.Point(677, 413);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(93, 28);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // DashboardWargaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btnPengajuan);
            this.Controls.Add(this.lblNamaWarga);
            this.Controls.Add(this.lblJudul);
            this.Name = "DashboardWargaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Warga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblNamaWarga;
        private System.Windows.Forms.Button btnPengajuan;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnLogout;
    }
}