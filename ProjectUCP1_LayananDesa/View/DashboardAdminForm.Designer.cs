namespace ProjectUCP1_LayananDesa
{
    partial class DashboardAdminForm
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblDshAdmin = new System.Windows.Forms.Label();
            this.dgvSuratMasuk = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetujui = new System.Windows.Forms.Button();
            this.btnTolak = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuratMasuk)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(55, 429);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 40);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblDshAdmin
            // 
            this.lblDshAdmin.AutoSize = true;
            this.lblDshAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDshAdmin.ForeColor = System.Drawing.Color.Black;
            this.lblDshAdmin.Location = new System.Drawing.Point(316, 24);
            this.lblDshAdmin.Name = "lblDshAdmin";
            this.lblDshAdmin.Size = new System.Drawing.Size(184, 25);
            this.lblDshAdmin.TabIndex = 1;
            this.lblDshAdmin.Text = "Dashboard Admin";
            // 
            // dgvSuratMasuk
            // 
            this.dgvSuratMasuk.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSuratMasuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuratMasuk.Location = new System.Drawing.Point(55, 119);
            this.dgvSuratMasuk.Name = "dgvSuratMasuk";
            this.dgvSuratMasuk.RowHeadersWidth = 51;
            this.dgvSuratMasuk.RowTemplate.Height = 24;
            this.dgvSuratMasuk.Size = new System.Drawing.Size(690, 268);
            this.dgvSuratMasuk.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(288, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Daftar Pengajuan Surat Warga";
            // 
            // btnSetujui
            // 
            this.btnSetujui.Location = new System.Drawing.Point(204, 417);
            this.btnSetujui.Name = "btnSetujui";
            this.btnSetujui.Size = new System.Drawing.Size(110, 52);
            this.btnSetujui.TabIndex = 4;
            this.btnSetujui.Text = "Setujui";
            this.btnSetujui.UseVisualStyleBackColor = true;
            this.btnSetujui.Click += new System.EventHandler(this.btnSetujui_Click);
            // 
            // btnTolak
            // 
            this.btnTolak.Location = new System.Drawing.Point(378, 417);
            this.btnTolak.Name = "btnTolak";
            this.btnTolak.Size = new System.Drawing.Size(110, 52);
            this.btnTolak.TabIndex = 5;
            this.btnTolak.Text = "Tolak";
            this.btnTolak.UseVisualStyleBackColor = true;
            this.btnTolak.Click += new System.EventHandler(this.btnTolak_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(656, 451);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(89, 29);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // DashboardAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnTolak);
            this.Controls.Add(this.btnSetujui);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSuratMasuk);
            this.Controls.Add(this.lblDshAdmin);
            this.Controls.Add(this.btnRefresh);
            this.Name = "DashboardAdminForm";
            this.Text = "DashdoardAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuratMasuk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblDshAdmin;
        private System.Windows.Forms.DataGridView dgvSuratMasuk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetujui;
        private System.Windows.Forms.Button btnTolak;
        private System.Windows.Forms.Button btnLogout;
    }
}