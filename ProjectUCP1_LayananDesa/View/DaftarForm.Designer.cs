namespace ProjectUCP1_LayananDesa
{
    partial class DaftarForm
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
            this.components = new System.ComponentModel.Container();
            this.btnDaftar = new System.Windows.Forms.Button();
            this.txtNIK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoHP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.btnBatal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.layananDesa_DBDataSet = new ProjectUCP1_LayananDesa.LayananDesa_DBDataSet();
            this.sURATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sURATTableAdapter = new ProjectUCP1_LayananDesa.LayananDesa_DBDataSetTableAdapters.SURATTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layananDesa_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sURATBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDaftar
            // 
            this.btnDaftar.Location = new System.Drawing.Point(254, 430);
            this.btnDaftar.Name = "btnDaftar";
            this.btnDaftar.Size = new System.Drawing.Size(90, 39);
            this.btnDaftar.TabIndex = 0;
            this.btnDaftar.Text = "Daftar";
            this.btnDaftar.UseVisualStyleBackColor = true;
            this.btnDaftar.Click += new System.EventHandler(this.btnDaftar_Click);
            // 
            // txtNIK
            // 
            this.txtNIK.BackColor = System.Drawing.SystemColors.Window;
            this.txtNIK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sURATBindingSource, "nik", true));
            this.txtNIK.Location = new System.Drawing.Point(254, 106);
            this.txtNIK.Name = "txtNIK";
            this.txtNIK.Size = new System.Drawing.Size(250, 22);
            this.txtNIK.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "NIK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nama";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(254, 155);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(250, 22);
            this.txtNama.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(254, 207);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 22);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "No HP";
            // 
            // txtNoHP
            // 
            this.txtNoHP.Location = new System.Drawing.Point(254, 261);
            this.txtNoHP.Name = "txtNoHP";
            this.txtNoHP.Size = new System.Drawing.Size(250, 22);
            this.txtNoHP.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Alamat";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(254, 312);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(250, 77);
            this.txtAlamat.TabIndex = 9;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(400, 430);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(92, 39);
            this.btnBatal.TabIndex = 11;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(275, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Halaman Daftar Akun";
            // 
            // layananDesa_DBDataSet
            // 
            this.layananDesa_DBDataSet.DataSetName = "LayananDesa_DBDataSet";
            this.layananDesa_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sURATBindingSource
            // 
            this.sURATBindingSource.DataMember = "SURAT";
            this.sURATBindingSource.DataSource = this.layananDesa_DBDataSet;
            // 
            // sURATTableAdapter
            // 
            this.sURATTableAdapter.ClearBeforeFill = true;
            // 
            // DaftarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNoHP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNIK);
            this.Controls.Add(this.btnDaftar);
            this.Name = "DaftarForm";
            this.Text = "Daftar";
            this.Load += new System.EventHandler(this.DaftarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layananDesa_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sURATBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDaftar;
        private System.Windows.Forms.TextBox txtNIK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoHP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Label label6;
        private LayananDesa_DBDataSet layananDesa_DBDataSet;
        private System.Windows.Forms.BindingSource sURATBindingSource;
        private LayananDesa_DBDataSetTableAdapters.SURATTableAdapter sURATTableAdapter;
    }
}