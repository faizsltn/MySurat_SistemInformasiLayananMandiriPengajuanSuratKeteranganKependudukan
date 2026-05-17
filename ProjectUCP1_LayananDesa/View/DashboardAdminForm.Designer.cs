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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardAdminForm));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblDshAdmin = new System.Windows.Forms.Label();
            this.dgvSuratMasuk = new System.Windows.Forms.DataGridView();
            this.idpengajuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenissuratDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglpengajuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sURATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layananDesa_DBDataSet = new ProjectUCP1_LayananDesa.LayananDesa_DBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetujui = new System.Windows.Forms.Button();
            this.btnTolak = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.sURATTableAdapter = new ProjectUCP1_LayananDesa.LayananDesa_DBDataSetTableAdapters.SURATTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuratMasuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sURATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layananDesa_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Aquamarine;
            this.btnRefresh.Location = new System.Drawing.Point(55, 417);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 40);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblDshAdmin
            // 
            this.lblDshAdmin.AutoSize = true;
            this.lblDshAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDshAdmin.ForeColor = System.Drawing.Color.Black;
            this.lblDshAdmin.Location = new System.Drawing.Point(316, 38);
            this.lblDshAdmin.Name = "lblDshAdmin";
            this.lblDshAdmin.Size = new System.Drawing.Size(184, 25);
            this.lblDshAdmin.TabIndex = 1;
            this.lblDshAdmin.Text = "Dashboard Admin";
            // 
            // dgvSuratMasuk
            // 
            this.dgvSuratMasuk.AutoGenerateColumns = false;
            this.dgvSuratMasuk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuratMasuk.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSuratMasuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuratMasuk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpengajuanDataGridViewTextBoxColumn,
            this.nikDataGridViewTextBoxColumn,
            this.idadminDataGridViewTextBoxColumn,
            this.jenissuratDataGridViewTextBoxColumn,
            this.tglpengajuanDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.deskripsiDataGridViewTextBoxColumn});
            this.dgvSuratMasuk.DataSource = this.sURATBindingSource;
            this.dgvSuratMasuk.Location = new System.Drawing.Point(32, 121);
            this.dgvSuratMasuk.Name = "dgvSuratMasuk";
            this.dgvSuratMasuk.RowHeadersWidth = 51;
            this.dgvSuratMasuk.RowTemplate.Height = 24;
            this.dgvSuratMasuk.Size = new System.Drawing.Size(742, 276);
            this.dgvSuratMasuk.TabIndex = 2;
            // 
            // idpengajuanDataGridViewTextBoxColumn
            // 
            this.idpengajuanDataGridViewTextBoxColumn.DataPropertyName = "id_pengajuan";
            this.idpengajuanDataGridViewTextBoxColumn.HeaderText = "id_pengajuan";
            this.idpengajuanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpengajuanDataGridViewTextBoxColumn.Name = "idpengajuanDataGridViewTextBoxColumn";
            this.idpengajuanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nikDataGridViewTextBoxColumn
            // 
            this.nikDataGridViewTextBoxColumn.DataPropertyName = "nik";
            this.nikDataGridViewTextBoxColumn.HeaderText = "nik";
            this.nikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nikDataGridViewTextBoxColumn.Name = "nikDataGridViewTextBoxColumn";
            // 
            // idadminDataGridViewTextBoxColumn
            // 
            this.idadminDataGridViewTextBoxColumn.DataPropertyName = "id_admin";
            this.idadminDataGridViewTextBoxColumn.HeaderText = "id_admin";
            this.idadminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idadminDataGridViewTextBoxColumn.Name = "idadminDataGridViewTextBoxColumn";
            // 
            // jenissuratDataGridViewTextBoxColumn
            // 
            this.jenissuratDataGridViewTextBoxColumn.DataPropertyName = "jenis_surat";
            this.jenissuratDataGridViewTextBoxColumn.HeaderText = "jenis_surat";
            this.jenissuratDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jenissuratDataGridViewTextBoxColumn.Name = "jenissuratDataGridViewTextBoxColumn";
            // 
            // tglpengajuanDataGridViewTextBoxColumn
            // 
            this.tglpengajuanDataGridViewTextBoxColumn.DataPropertyName = "tgl_pengajuan";
            this.tglpengajuanDataGridViewTextBoxColumn.HeaderText = "tgl_pengajuan";
            this.tglpengajuanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tglpengajuanDataGridViewTextBoxColumn.Name = "tglpengajuanDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // deskripsiDataGridViewTextBoxColumn
            // 
            this.deskripsiDataGridViewTextBoxColumn.DataPropertyName = "deskripsi";
            this.deskripsiDataGridViewTextBoxColumn.HeaderText = "deskripsi";
            this.deskripsiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deskripsiDataGridViewTextBoxColumn.Name = "deskripsiDataGridViewTextBoxColumn";
            // 
            // sURATBindingSource
            // 
            this.sURATBindingSource.DataMember = "SURAT";
            this.sURATBindingSource.DataSource = this.layananDesa_DBDataSet;
            // 
            // layananDesa_DBDataSet
            // 
            this.layananDesa_DBDataSet.DataSetName = "LayananDesa_DBDataSet";
            this.layananDesa_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnSetujui.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSetujui.Location = new System.Drawing.Point(207, 417);
            this.btnSetujui.Name = "btnSetujui";
            this.btnSetujui.Size = new System.Drawing.Size(97, 52);
            this.btnSetujui.TabIndex = 4;
            this.btnSetujui.Text = "Setujui";
            this.btnSetujui.UseVisualStyleBackColor = false;
            this.btnSetujui.Click += new System.EventHandler(this.btnSetujui_Click);
            // 
            // btnTolak
            // 
            this.btnTolak.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnTolak.Location = new System.Drawing.Point(335, 417);
            this.btnTolak.Name = "btnTolak";
            this.btnTolak.Size = new System.Drawing.Size(106, 52);
            this.btnTolak.TabIndex = 5;
            this.btnTolak.Text = "Tolak";
            this.btnTolak.UseVisualStyleBackColor = false;
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
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Crimson;
            this.btnHapus.Location = new System.Drawing.Point(462, 416);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(117, 41);
            this.btnHapus.TabIndex = 7;
            this.btnHapus.Text = "Hapus\r\n";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // sURATTableAdapter
            // 
            this.sURATTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.sURATBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sURATBindingSource, "nik", true));
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 27);
            this.bindingNavigator1.TabIndex = 8;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // DashboardAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnTolak);
            this.Controls.Add(this.btnSetujui);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSuratMasuk);
            this.Controls.Add(this.lblDshAdmin);
            this.Controls.Add(this.btnRefresh);
            this.Name = "DashboardAdminForm";
            this.Text = "DashdoardAdmin";
            this.Load += new System.EventHandler(this.DashboardAdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuratMasuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sURATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layananDesa_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
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
        private System.Windows.Forms.Button btnHapus;
        private LayananDesa_DBDataSet layananDesa_DBDataSet;
        private System.Windows.Forms.BindingSource sURATBindingSource;
        private LayananDesa_DBDataSetTableAdapters.SURATTableAdapter sURATTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpengajuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenissuratDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglpengajuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}