namespace ProjectUCP1_LayananDesa.View
{
    partial class PengajuanSuratForm
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
            this.lblJenisSurat = new System.Windows.Forms.Label();
            this.cbJenisSurat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.btnKirim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblJenisSurat
            // 
            this.lblJenisSurat.AutoSize = true;
            this.lblJenisSurat.Location = new System.Drawing.Point(129, 105);
            this.lblJenisSurat.Name = "lblJenisSurat";
            this.lblJenisSurat.Size = new System.Drawing.Size(73, 16);
            this.lblJenisSurat.TabIndex = 0;
            this.lblJenisSurat.Text = "Jenis Surat";
            // 
            // cbJenisSurat
            // 
            this.cbJenisSurat.FormattingEnabled = true;
            this.cbJenisSurat.Items.AddRange(new object[] {
            "Surat Keterangan Tidak Mampu",
            "Surat Keterangan Usaha",
            "Surat Pengantar Domisili",
            "Surat Keterangan Catatan Kepolisian"});
            this.cbJenisSurat.Location = new System.Drawing.Point(229, 102);
            this.cbJenisSurat.Name = "cbJenisSurat";
            this.cbJenisSurat.Size = new System.Drawing.Size(239, 24);
            this.cbJenisSurat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Deskripsi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Location = new System.Drawing.Point(229, 160);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(239, 93);
            this.txtDeskripsi.TabIndex = 3;
            // 
            // btnKirim
            // 
            this.btnKirim.Location = new System.Drawing.Point(229, 293);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(75, 34);
            this.btnKirim.TabIndex = 4;
            this.btnKirim.Text = "Kirim";
            this.btnKirim.UseVisualStyleBackColor = true;
            this.btnKirim.Click += new System.EventHandler(this.btnKirim_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pengajuan Surat";
            // 
            // PengajuanSuratForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKirim);
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbJenisSurat);
            this.Controls.Add(this.lblJenisSurat);
            this.Name = "PengajuanSuratForm";
            this.Text = "PengajuanSurat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJenisSurat;
        private System.Windows.Forms.ComboBox cbJenisSurat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.Button btnKirim;
        private System.Windows.Forms.Label label2;
    }
}