namespace Latihan_POS
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            this.msManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnTrans = new MetroFramework.Controls.MetroTile();
            this.btnRegis = new MetroFramework.Controls.MetroTile();
            this.mtbRegis = new MetroFramework.Controls.MetroTabControl();
            this.tbBarang = new MetroFramework.Controls.MetroTabPage();
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            this.BarangHargaJual = new System.Windows.Forms.TextBox();
            this.BarangHargaHPP = new System.Windows.Forms.TextBox();
            this.BarangJmlhAwal = new System.Windows.Forms.TextBox();
            this.BarangNama = new System.Windows.Forms.TextBox();
            this.BarangKode = new System.Windows.Forms.TextBox();
            this.lblHargaJual = new MetroFramework.Controls.MetroLabel();
            this.lblHargaHPP = new MetroFramework.Controls.MetroLabel();
            this.lblJumlahAwal = new MetroFramework.Controls.MetroLabel();
            this.lblNamaBarang = new MetroFramework.Controls.MetroLabel();
            this.lblKodeBarang = new MetroFramework.Controls.MetroLabel();
            this.tbCustomer = new MetroFramework.Controls.MetroTabPage();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.CustomerHp = new System.Windows.Forms.TextBox();
            this.lblCustomerHp = new MetroFramework.Controls.MetroLabel();
            this.CustomerAlamat = new System.Windows.Forms.TextBox();
            this.lblCustomerAlamat = new MetroFramework.Controls.MetroLabel();
            this.CustomerNama = new System.Windows.Forms.TextBox();
            this.CustomerKode = new System.Windows.Forms.TextBox();
            this.lblCustomerNama = new MetroFramework.Controls.MetroLabel();
            this.lblCustomerKode = new MetroFramework.Controls.MetroLabel();
            this.tbSupplier = new MetroFramework.Controls.MetroTabPage();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.SupplierHp = new System.Windows.Forms.TextBox();
            this.lblSupplierHp = new MetroFramework.Controls.MetroLabel();
            this.SupplierAlamat = new System.Windows.Forms.TextBox();
            this.lblSupplierAlamat = new MetroFramework.Controls.MetroLabel();
            this.SupplierNama = new System.Windows.Forms.TextBox();
            this.SupplierKode = new System.Windows.Forms.TextBox();
            this.lblSupplierNama = new MetroFramework.Controls.MetroLabel();
            this.lblSupplierKode = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.btnNew = new MetroFramework.Controls.MetroTile();
            this.btnExit = new MetroFramework.Controls.MetroTile();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.gbNav = new System.Windows.Forms.GroupBox();
            this.mtbTransc = new MetroFramework.Controls.MetroTabControl();
            this.mtbPenjualan = new MetroFramework.Controls.MetroTabPage();
            this.JualAlamat = new System.Windows.Forms.TextBox();
            this.lblJualAlamat = new MetroFramework.Controls.MetroLabel();
            this.JualCustomer = new System.Windows.Forms.TextBox();
            this.lblJualCustomer = new MetroFramework.Controls.MetroLabel();
            this.JualNama = new System.Windows.Forms.TextBox();
            this.JualKode = new System.Windows.Forms.TextBox();
            this.lblJualTanggal = new MetroFramework.Controls.MetroLabel();
            this.lblJualNoBatch = new MetroFramework.Controls.MetroLabel();
            this.dgvDetailJual = new System.Windows.Forms.DataGridView();
            this.mtbPembelian = new MetroFramework.Controls.MetroTabPage();
            this.NamaSupplier = new System.Windows.Forms.TextBox();
            this.lblBeliNamaSupplier = new MetroFramework.Controls.MetroLabel();
            this.BeliSupplier = new System.Windows.Forms.TextBox();
            this.lblBeliSupplier = new MetroFramework.Controls.MetroLabel();
            this.BeliTanggal = new System.Windows.Forms.TextBox();
            this.BeliNoBatch = new System.Windows.Forms.TextBox();
            this.lblBeliTanggal = new MetroFramework.Controls.MetroLabel();
            this.lblBeliNoBatch = new MetroFramework.Controls.MetroLabel();
            this.dgvDetailBeli = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.msManager)).BeginInit();
            this.mtbRegis.SuspendLayout();
            this.tbBarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            this.tbCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.tbSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.gbNav.SuspendLayout();
            this.mtbTransc.SuspendLayout();
            this.mtbPenjualan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailJual)).BeginInit();
            this.mtbPembelian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailBeli)).BeginInit();
            this.SuspendLayout();
            // 
            // msManager
            // 
            this.msManager.Owner = this;
            this.msManager.Style = MetroFramework.MetroColorStyle.Blue;
            this.msManager.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnTrans
            // 
            this.btnTrans.BackColor = System.Drawing.Color.White;
            this.btnTrans.Location = new System.Drawing.Point(18, 144);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(98, 34);
            this.btnTrans.TabIndex = 27;
            this.btnTrans.Text = "Transaction";
            this.btnTrans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // btnRegis
            // 
            this.btnRegis.BackColor = System.Drawing.Color.White;
            this.btnRegis.Location = new System.Drawing.Point(18, 93);
            this.btnRegis.Name = "btnRegis";
            this.btnRegis.Size = new System.Drawing.Size(98, 34);
            this.btnRegis.TabIndex = 26;
            this.btnRegis.Text = "Registration";
            this.btnRegis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegis.Click += new System.EventHandler(this.btnRegis_Click);
            // 
            // mtbRegis
            // 
            this.mtbRegis.Controls.Add(this.tbBarang);
            this.mtbRegis.Controls.Add(this.tbCustomer);
            this.mtbRegis.Controls.Add(this.tbSupplier);
            this.mtbRegis.Location = new System.Drawing.Point(18, 24);
            this.mtbRegis.Name = "mtbRegis";
            this.mtbRegis.SelectedIndex = 0;
            this.mtbRegis.Size = new System.Drawing.Size(694, 321);
            this.mtbRegis.TabIndex = 19;
            // 
            // tbBarang
            // 
            this.tbBarang.Controls.Add(this.dgvBarang);
            this.tbBarang.Controls.Add(this.BarangHargaJual);
            this.tbBarang.Controls.Add(this.BarangHargaHPP);
            this.tbBarang.Controls.Add(this.BarangJmlhAwal);
            this.tbBarang.Controls.Add(this.BarangNama);
            this.tbBarang.Controls.Add(this.BarangKode);
            this.tbBarang.Controls.Add(this.lblHargaJual);
            this.tbBarang.Controls.Add(this.lblHargaHPP);
            this.tbBarang.Controls.Add(this.lblJumlahAwal);
            this.tbBarang.Controls.Add(this.lblNamaBarang);
            this.tbBarang.Controls.Add(this.lblKodeBarang);
            this.tbBarang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tbBarang.HorizontalScrollbarBarColor = true;
            this.tbBarang.HorizontalScrollbarSize = 20;
            this.tbBarang.Location = new System.Drawing.Point(4, 35);
            this.tbBarang.Name = "tbBarang";
            this.tbBarang.Size = new System.Drawing.Size(686, 282);
            this.tbBarang.TabIndex = 0;
            this.tbBarang.Text = "BARANG";
            this.tbBarang.VerticalScrollbarBarColor = true;
            // 
            // dgvBarang
            // 
            this.dgvBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBarang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBarang.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBarang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvBarang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBarang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvBarang.ColumnHeadersHeight = 22;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBarang.DefaultCellStyle = dataGridViewCellStyle32;
            this.dgvBarang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBarang.GridColor = System.Drawing.SystemColors.Window;
            this.dgvBarang.Location = new System.Drawing.Point(0, 175);
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBarang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBarang.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBarang.Size = new System.Drawing.Size(686, 107);
            this.dgvBarang.TabIndex = 62;
            this.dgvBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarang_CellClick);
            // 
            // BarangHargaJual
            // 
            this.BarangHargaJual.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BarangHargaJual.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarangHargaJual.Location = new System.Drawing.Point(142, 128);
            this.BarangHargaJual.Name = "BarangHargaJual";
            this.BarangHargaJual.Size = new System.Drawing.Size(100, 25);
            this.BarangHargaJual.TabIndex = 55;
            // 
            // BarangHargaHPP
            // 
            this.BarangHargaHPP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BarangHargaHPP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarangHargaHPP.Location = new System.Drawing.Point(142, 102);
            this.BarangHargaHPP.Name = "BarangHargaHPP";
            this.BarangHargaHPP.Size = new System.Drawing.Size(100, 25);
            this.BarangHargaHPP.TabIndex = 54;
            // 
            // BarangJmlhAwal
            // 
            this.BarangJmlhAwal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BarangJmlhAwal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarangJmlhAwal.Location = new System.Drawing.Point(142, 76);
            this.BarangJmlhAwal.Name = "BarangJmlhAwal";
            this.BarangJmlhAwal.Size = new System.Drawing.Size(100, 25);
            this.BarangJmlhAwal.TabIndex = 53;
            // 
            // BarangNama
            // 
            this.BarangNama.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BarangNama.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarangNama.Location = new System.Drawing.Point(142, 50);
            this.BarangNama.Name = "BarangNama";
            this.BarangNama.Size = new System.Drawing.Size(200, 25);
            this.BarangNama.TabIndex = 52;
            // 
            // BarangKode
            // 
            this.BarangKode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BarangKode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarangKode.Location = new System.Drawing.Point(142, 24);
            this.BarangKode.Name = "BarangKode";
            this.BarangKode.Size = new System.Drawing.Size(100, 25);
            this.BarangKode.TabIndex = 51;
            // 
            // lblHargaJual
            // 
            this.lblHargaJual.AutoSize = true;
            this.lblHargaJual.Location = new System.Drawing.Point(2, 129);
            this.lblHargaJual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHargaJual.Name = "lblHargaJual";
            this.lblHargaJual.Size = new System.Drawing.Size(86, 19);
            this.lblHargaJual.TabIndex = 50;
            this.lblHargaJual.Text = "HARGA JUAL";
            // 
            // lblHargaHPP
            // 
            this.lblHargaHPP.AutoSize = true;
            this.lblHargaHPP.Location = new System.Drawing.Point(2, 103);
            this.lblHargaHPP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHargaHPP.Name = "lblHargaHPP";
            this.lblHargaHPP.Size = new System.Drawing.Size(82, 19);
            this.lblHargaHPP.TabIndex = 49;
            this.lblHargaHPP.Text = "HARGA HPP";
            // 
            // lblJumlahAwal
            // 
            this.lblJumlahAwal.AutoSize = true;
            this.lblJumlahAwal.Location = new System.Drawing.Point(2, 76);
            this.lblJumlahAwal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJumlahAwal.Name = "lblJumlahAwal";
            this.lblJumlahAwal.Size = new System.Drawing.Size(100, 19);
            this.lblJumlahAwal.TabIndex = 48;
            this.lblJumlahAwal.Text = "JUMLAH AWAL";
            // 
            // lblNamaBarang
            // 
            this.lblNamaBarang.AutoSize = true;
            this.lblNamaBarang.Location = new System.Drawing.Point(2, 50);
            this.lblNamaBarang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamaBarang.Name = "lblNamaBarang";
            this.lblNamaBarang.Size = new System.Drawing.Size(49, 19);
            this.lblNamaBarang.TabIndex = 47;
            this.lblNamaBarang.Text = "NAMA";
            // 
            // lblKodeBarang
            // 
            this.lblKodeBarang.AutoSize = true;
            this.lblKodeBarang.BackColor = System.Drawing.SystemColors.Control;
            this.lblKodeBarang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKodeBarang.Location = new System.Drawing.Point(2, 24);
            this.lblKodeBarang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKodeBarang.Name = "lblKodeBarang";
            this.lblKodeBarang.Size = new System.Drawing.Size(43, 19);
            this.lblKodeBarang.TabIndex = 46;
            this.lblKodeBarang.Text = "KODE";
            // 
            // tbCustomer
            // 
            this.tbCustomer.Controls.Add(this.dgvCustomer);
            this.tbCustomer.Controls.Add(this.CustomerHp);
            this.tbCustomer.Controls.Add(this.lblCustomerHp);
            this.tbCustomer.Controls.Add(this.CustomerAlamat);
            this.tbCustomer.Controls.Add(this.lblCustomerAlamat);
            this.tbCustomer.Controls.Add(this.CustomerNama);
            this.tbCustomer.Controls.Add(this.CustomerKode);
            this.tbCustomer.Controls.Add(this.lblCustomerNama);
            this.tbCustomer.Controls.Add(this.lblCustomerKode);
            this.tbCustomer.HorizontalScrollbarBarColor = true;
            this.tbCustomer.Location = new System.Drawing.Point(4, 35);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(686, 282);
            this.tbCustomer.TabIndex = 1;
            this.tbCustomer.Text = "CUSTOMER";
            this.tbCustomer.VerticalScrollbarBarColor = true;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCustomer.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dgvCustomer.ColumnHeadersHeight = 22;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomer.DefaultCellStyle = dataGridViewCellStyle34;
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCustomer.GridColor = System.Drawing.SystemColors.Window;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 175);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCustomer.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomer.Size = new System.Drawing.Size(686, 107);
            this.dgvCustomer.TabIndex = 63;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            // 
            // CustomerHp
            // 
            this.CustomerHp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomerHp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerHp.Location = new System.Drawing.Point(142, 101);
            this.CustomerHp.Name = "CustomerHp";
            this.CustomerHp.Size = new System.Drawing.Size(167, 25);
            this.CustomerHp.TabIndex = 60;
            // 
            // lblCustomerHp
            // 
            this.lblCustomerHp.AutoSize = true;
            this.lblCustomerHp.Location = new System.Drawing.Point(2, 101);
            this.lblCustomerHp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerHp.Name = "lblCustomerHp";
            this.lblCustomerHp.Size = new System.Drawing.Size(91, 19);
            this.lblCustomerHp.TabIndex = 59;
            this.lblCustomerHp.Text = "HANDPHONE";
            // 
            // CustomerAlamat
            // 
            this.CustomerAlamat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomerAlamat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerAlamat.Location = new System.Drawing.Point(142, 74);
            this.CustomerAlamat.Name = "CustomerAlamat";
            this.CustomerAlamat.Size = new System.Drawing.Size(200, 25);
            this.CustomerAlamat.TabIndex = 58;
            // 
            // lblCustomerAlamat
            // 
            this.lblCustomerAlamat.AutoSize = true;
            this.lblCustomerAlamat.Location = new System.Drawing.Point(2, 74);
            this.lblCustomerAlamat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerAlamat.Name = "lblCustomerAlamat";
            this.lblCustomerAlamat.Size = new System.Drawing.Size(61, 19);
            this.lblCustomerAlamat.TabIndex = 57;
            this.lblCustomerAlamat.Text = "ALAMAT";
            // 
            // CustomerNama
            // 
            this.CustomerNama.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomerNama.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNama.Location = new System.Drawing.Point(142, 47);
            this.CustomerNama.Name = "CustomerNama";
            this.CustomerNama.Size = new System.Drawing.Size(200, 25);
            this.CustomerNama.TabIndex = 56;
            // 
            // CustomerKode
            // 
            this.CustomerKode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomerKode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerKode.Location = new System.Drawing.Point(142, 21);
            this.CustomerKode.Name = "CustomerKode";
            this.CustomerKode.Size = new System.Drawing.Size(100, 25);
            this.CustomerKode.TabIndex = 55;
            // 
            // lblCustomerNama
            // 
            this.lblCustomerNama.AutoSize = true;
            this.lblCustomerNama.Location = new System.Drawing.Point(2, 47);
            this.lblCustomerNama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerNama.Name = "lblCustomerNama";
            this.lblCustomerNama.Size = new System.Drawing.Size(49, 19);
            this.lblCustomerNama.TabIndex = 54;
            this.lblCustomerNama.Text = "NAMA";
            // 
            // lblCustomerKode
            // 
            this.lblCustomerKode.AutoSize = true;
            this.lblCustomerKode.BackColor = System.Drawing.SystemColors.Control;
            this.lblCustomerKode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCustomerKode.Location = new System.Drawing.Point(2, 21);
            this.lblCustomerKode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerKode.Name = "lblCustomerKode";
            this.lblCustomerKode.Size = new System.Drawing.Size(43, 19);
            this.lblCustomerKode.TabIndex = 53;
            this.lblCustomerKode.Text = "KODE";
            // 
            // tbSupplier
            // 
            this.tbSupplier.Controls.Add(this.dgvSupplier);
            this.tbSupplier.Controls.Add(this.SupplierHp);
            this.tbSupplier.Controls.Add(this.lblSupplierHp);
            this.tbSupplier.Controls.Add(this.SupplierAlamat);
            this.tbSupplier.Controls.Add(this.lblSupplierAlamat);
            this.tbSupplier.Controls.Add(this.SupplierNama);
            this.tbSupplier.Controls.Add(this.SupplierKode);
            this.tbSupplier.Controls.Add(this.lblSupplierNama);
            this.tbSupplier.Controls.Add(this.lblSupplierKode);
            this.tbSupplier.HorizontalScrollbarBarColor = true;
            this.tbSupplier.Location = new System.Drawing.Point(4, 35);
            this.tbSupplier.Name = "tbSupplier";
            this.tbSupplier.Size = new System.Drawing.Size(686, 282);
            this.tbSupplier.TabIndex = 2;
            this.tbSupplier.Text = "SUPPLIER";
            this.tbSupplier.VerticalScrollbarBarColor = true;
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSupplier.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSupplier.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSupplier.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvSupplier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.dgvSupplier.ColumnHeadersHeight = 22;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSupplier.DefaultCellStyle = dataGridViewCellStyle36;
            this.dgvSupplier.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSupplier.GridColor = System.Drawing.SystemColors.Window;
            this.dgvSupplier.Location = new System.Drawing.Point(0, 175);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSupplier.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSupplier.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSupplier.Size = new System.Drawing.Size(686, 107);
            this.dgvSupplier.TabIndex = 72;
            this.dgvSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplier_CellClick);
            // 
            // SupplierHp
            // 
            this.SupplierHp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SupplierHp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierHp.Location = new System.Drawing.Point(142, 102);
            this.SupplierHp.Name = "SupplierHp";
            this.SupplierHp.Size = new System.Drawing.Size(167, 25);
            this.SupplierHp.TabIndex = 71;
            // 
            // lblSupplierHp
            // 
            this.lblSupplierHp.AutoSize = true;
            this.lblSupplierHp.Location = new System.Drawing.Point(2, 102);
            this.lblSupplierHp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierHp.Name = "lblSupplierHp";
            this.lblSupplierHp.Size = new System.Drawing.Size(91, 19);
            this.lblSupplierHp.TabIndex = 70;
            this.lblSupplierHp.Text = "HANDPHONE";
            // 
            // SupplierAlamat
            // 
            this.SupplierAlamat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SupplierAlamat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierAlamat.Location = new System.Drawing.Point(142, 75);
            this.SupplierAlamat.Name = "SupplierAlamat";
            this.SupplierAlamat.Size = new System.Drawing.Size(200, 25);
            this.SupplierAlamat.TabIndex = 69;
            // 
            // lblSupplierAlamat
            // 
            this.lblSupplierAlamat.AutoSize = true;
            this.lblSupplierAlamat.Location = new System.Drawing.Point(2, 75);
            this.lblSupplierAlamat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierAlamat.Name = "lblSupplierAlamat";
            this.lblSupplierAlamat.Size = new System.Drawing.Size(61, 19);
            this.lblSupplierAlamat.TabIndex = 68;
            this.lblSupplierAlamat.Text = "ALAMAT";
            // 
            // SupplierNama
            // 
            this.SupplierNama.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SupplierNama.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierNama.Location = new System.Drawing.Point(142, 48);
            this.SupplierNama.Name = "SupplierNama";
            this.SupplierNama.Size = new System.Drawing.Size(200, 25);
            this.SupplierNama.TabIndex = 67;
            // 
            // SupplierKode
            // 
            this.SupplierKode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SupplierKode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierKode.Location = new System.Drawing.Point(142, 22);
            this.SupplierKode.Name = "SupplierKode";
            this.SupplierKode.Size = new System.Drawing.Size(100, 25);
            this.SupplierKode.TabIndex = 66;
            // 
            // lblSupplierNama
            // 
            this.lblSupplierNama.AutoSize = true;
            this.lblSupplierNama.Location = new System.Drawing.Point(2, 48);
            this.lblSupplierNama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierNama.Name = "lblSupplierNama";
            this.lblSupplierNama.Size = new System.Drawing.Size(49, 19);
            this.lblSupplierNama.TabIndex = 65;
            this.lblSupplierNama.Text = "NAMA";
            // 
            // lblSupplierKode
            // 
            this.lblSupplierKode.AutoSize = true;
            this.lblSupplierKode.BackColor = System.Drawing.SystemColors.Control;
            this.lblSupplierKode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSupplierKode.Location = new System.Drawing.Point(2, 22);
            this.lblSupplierKode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplierKode.Name = "lblSupplierKode";
            this.lblSupplierKode.Size = new System.Drawing.Size(43, 19);
            this.lblSupplierKode.TabIndex = 64;
            this.lblSupplierKode.Text = "KODE";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(131, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 29);
            this.btnSave.TabIndex = 68;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(22, 370);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 29);
            this.btnNew.TabIndex = 69;
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(348, 370);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 29);
            this.btnExit.TabIndex = 70;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(244, 370);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 29);
            this.btnDelete.TabIndex = 71;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbNav
            // 
            this.gbNav.AutoSize = true;
            this.gbNav.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbNav.BackColor = System.Drawing.Color.Transparent;
            this.gbNav.Controls.Add(this.mtbTransc);
            this.gbNav.Controls.Add(this.btnDelete);
            this.gbNav.Controls.Add(this.btnExit);
            this.gbNav.Controls.Add(this.btnNew);
            this.gbNav.Controls.Add(this.btnSave);
            this.gbNav.Controls.Add(this.mtbRegis);
            this.gbNav.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNav.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbNav.Location = new System.Drawing.Point(122, 93);
            this.gbNav.Name = "gbNav";
            this.gbNav.Padding = new System.Windows.Forms.Padding(3, 5, 5, 3);
            this.gbNav.Size = new System.Drawing.Size(720, 421);
            this.gbNav.TabIndex = 22;
            this.gbNav.TabStop = false;
            // 
            // mtbTransc
            // 
            this.mtbTransc.Controls.Add(this.mtbPenjualan);
            this.mtbTransc.Controls.Add(this.mtbPembelian);
            this.mtbTransc.Location = new System.Drawing.Point(19, 24);
            this.mtbTransc.Name = "mtbTransc";
            this.mtbTransc.SelectedIndex = 0;
            this.mtbTransc.Size = new System.Drawing.Size(693, 321);
            this.mtbTransc.TabIndex = 28;
            // 
            // mtbPenjualan
            // 
            this.mtbPenjualan.Controls.Add(this.JualAlamat);
            this.mtbPenjualan.Controls.Add(this.lblJualAlamat);
            this.mtbPenjualan.Controls.Add(this.JualCustomer);
            this.mtbPenjualan.Controls.Add(this.lblJualCustomer);
            this.mtbPenjualan.Controls.Add(this.JualNama);
            this.mtbPenjualan.Controls.Add(this.JualKode);
            this.mtbPenjualan.Controls.Add(this.lblJualTanggal);
            this.mtbPenjualan.Controls.Add(this.lblJualNoBatch);
            this.mtbPenjualan.Controls.Add(this.dgvDetailJual);
            this.mtbPenjualan.HorizontalScrollbarBarColor = true;
            this.mtbPenjualan.Location = new System.Drawing.Point(4, 35);
            this.mtbPenjualan.Name = "mtbPenjualan";
            this.mtbPenjualan.Size = new System.Drawing.Size(685, 282);
            this.mtbPenjualan.TabIndex = 1;
            this.mtbPenjualan.Text = "PENJUALAN";
            this.mtbPenjualan.VerticalScrollbarBarColor = true;
            // 
            // JualAlamat
            // 
            this.JualAlamat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.JualAlamat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JualAlamat.Location = new System.Drawing.Point(140, 104);
            this.JualAlamat.Name = "JualAlamat";
            this.JualAlamat.Size = new System.Drawing.Size(167, 25);
            this.JualAlamat.TabIndex = 88;
            // 
            // lblJualAlamat
            // 
            this.lblJualAlamat.AutoSize = true;
            this.lblJualAlamat.Location = new System.Drawing.Point(0, 104);
            this.lblJualAlamat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJualAlamat.Name = "lblJualAlamat";
            this.lblJualAlamat.Size = new System.Drawing.Size(61, 19);
            this.lblJualAlamat.TabIndex = 87;
            this.lblJualAlamat.Text = "ALAMAT";
            // 
            // JualCustomer
            // 
            this.JualCustomer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.JualCustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JualCustomer.Location = new System.Drawing.Point(140, 77);
            this.JualCustomer.Name = "JualCustomer";
            this.JualCustomer.Size = new System.Drawing.Size(200, 25);
            this.JualCustomer.TabIndex = 86;
            // 
            // lblJualCustomer
            // 
            this.lblJualCustomer.AutoSize = true;
            this.lblJualCustomer.Location = new System.Drawing.Point(0, 77);
            this.lblJualCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJualCustomer.Name = "lblJualCustomer";
            this.lblJualCustomer.Size = new System.Drawing.Size(123, 19);
            this.lblJualCustomer.TabIndex = 85;
            this.lblJualCustomer.Text = "NAMA CUSTOMER";
            // 
            // JualNama
            // 
            this.JualNama.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.JualNama.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JualNama.Location = new System.Drawing.Point(140, 50);
            this.JualNama.Name = "JualNama";
            this.JualNama.Size = new System.Drawing.Size(200, 25);
            this.JualNama.TabIndex = 84;
            // 
            // JualKode
            // 
            this.JualKode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.JualKode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JualKode.Location = new System.Drawing.Point(140, 24);
            this.JualKode.Name = "JualKode";
            this.JualKode.Size = new System.Drawing.Size(100, 25);
            this.JualKode.TabIndex = 83;
            // 
            // lblJualTanggal
            // 
            this.lblJualTanggal.AutoSize = true;
            this.lblJualTanggal.Location = new System.Drawing.Point(0, 50);
            this.lblJualTanggal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJualTanggal.Name = "lblJualTanggal";
            this.lblJualTanggal.Size = new System.Drawing.Size(68, 19);
            this.lblJualTanggal.TabIndex = 82;
            this.lblJualTanggal.Text = "TANGGAL";
            // 
            // lblJualNoBatch
            // 
            this.lblJualNoBatch.AutoSize = true;
            this.lblJualNoBatch.BackColor = System.Drawing.SystemColors.Control;
            this.lblJualNoBatch.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblJualNoBatch.Location = new System.Drawing.Point(0, 24);
            this.lblJualNoBatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJualNoBatch.Name = "lblJualNoBatch";
            this.lblJualNoBatch.Size = new System.Drawing.Size(76, 19);
            this.lblJualNoBatch.TabIndex = 81;
            this.lblJualNoBatch.Text = "NO BATCH";
            // 
            // dgvDetailJual
            // 
            this.dgvDetailJual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDetailJual.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetailJual.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvDetailJual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetailJual.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvDetailJual.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetailJual.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dgvDetailJual.ColumnHeadersHeight = 22;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetailJual.DefaultCellStyle = dataGridViewCellStyle38;
            this.dgvDetailJual.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDetailJual.GridColor = System.Drawing.SystemColors.Window;
            this.dgvDetailJual.Location = new System.Drawing.Point(0, 175);
            this.dgvDetailJual.Name = "dgvDetailJual";
            this.dgvDetailJual.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetailJual.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDetailJual.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetailJual.Size = new System.Drawing.Size(685, 107);
            this.dgvDetailJual.TabIndex = 63;
            // 
            // mtbPembelian
            // 
            this.mtbPembelian.Controls.Add(this.NamaSupplier);
            this.mtbPembelian.Controls.Add(this.lblBeliNamaSupplier);
            this.mtbPembelian.Controls.Add(this.BeliSupplier);
            this.mtbPembelian.Controls.Add(this.lblBeliSupplier);
            this.mtbPembelian.Controls.Add(this.BeliTanggal);
            this.mtbPembelian.Controls.Add(this.BeliNoBatch);
            this.mtbPembelian.Controls.Add(this.lblBeliTanggal);
            this.mtbPembelian.Controls.Add(this.lblBeliNoBatch);
            this.mtbPembelian.Controls.Add(this.dgvDetailBeli);
            this.mtbPembelian.HorizontalScrollbarBarColor = true;
            this.mtbPembelian.Location = new System.Drawing.Point(4, 35);
            this.mtbPembelian.Name = "mtbPembelian";
            this.mtbPembelian.Size = new System.Drawing.Size(685, 282);
            this.mtbPembelian.TabIndex = 2;
            this.mtbPembelian.Text = "PEMBELIAN";
            this.mtbPembelian.VerticalScrollbarBarColor = true;
            // 
            // NamaSupplier
            // 
            this.NamaSupplier.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NamaSupplier.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaSupplier.Location = new System.Drawing.Point(136, 104);
            this.NamaSupplier.Name = "NamaSupplier";
            this.NamaSupplier.Size = new System.Drawing.Size(167, 25);
            this.NamaSupplier.TabIndex = 88;
            // 
            // lblBeliNamaSupplier
            // 
            this.lblBeliNamaSupplier.AutoSize = true;
            this.lblBeliNamaSupplier.Location = new System.Drawing.Point(-4, 104);
            this.lblBeliNamaSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBeliNamaSupplier.Name = "lblBeliNamaSupplier";
            this.lblBeliNamaSupplier.Size = new System.Drawing.Size(123, 19);
            this.lblBeliNamaSupplier.TabIndex = 87;
            this.lblBeliNamaSupplier.Text = "NAMA CUSTOMER";
            // 
            // BeliSupplier
            // 
            this.BeliSupplier.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BeliSupplier.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeliSupplier.Location = new System.Drawing.Point(136, 77);
            this.BeliSupplier.Name = "BeliSupplier";
            this.BeliSupplier.Size = new System.Drawing.Size(200, 25);
            this.BeliSupplier.TabIndex = 86;
            // 
            // lblBeliSupplier
            // 
            this.lblBeliSupplier.AutoSize = true;
            this.lblBeliSupplier.Location = new System.Drawing.Point(-4, 77);
            this.lblBeliSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBeliSupplier.Name = "lblBeliSupplier";
            this.lblBeliSupplier.Size = new System.Drawing.Size(79, 19);
            this.lblBeliSupplier.TabIndex = 85;
            this.lblBeliSupplier.Text = "CUSTOMER";
            // 
            // BeliTanggal
            // 
            this.BeliTanggal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BeliTanggal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeliTanggal.Location = new System.Drawing.Point(136, 50);
            this.BeliTanggal.Name = "BeliTanggal";
            this.BeliTanggal.Size = new System.Drawing.Size(200, 25);
            this.BeliTanggal.TabIndex = 84;
            // 
            // BeliNoBatch
            // 
            this.BeliNoBatch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BeliNoBatch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeliNoBatch.Location = new System.Drawing.Point(136, 24);
            this.BeliNoBatch.Name = "BeliNoBatch";
            this.BeliNoBatch.Size = new System.Drawing.Size(100, 25);
            this.BeliNoBatch.TabIndex = 83;
            // 
            // lblBeliTanggal
            // 
            this.lblBeliTanggal.AutoSize = true;
            this.lblBeliTanggal.Location = new System.Drawing.Point(-4, 50);
            this.lblBeliTanggal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBeliTanggal.Name = "lblBeliTanggal";
            this.lblBeliTanggal.Size = new System.Drawing.Size(68, 19);
            this.lblBeliTanggal.TabIndex = 82;
            this.lblBeliTanggal.Text = "TANGGAL";
            // 
            // lblBeliNoBatch
            // 
            this.lblBeliNoBatch.AutoSize = true;
            this.lblBeliNoBatch.BackColor = System.Drawing.SystemColors.Control;
            this.lblBeliNoBatch.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBeliNoBatch.Location = new System.Drawing.Point(-4, 24);
            this.lblBeliNoBatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBeliNoBatch.Name = "lblBeliNoBatch";
            this.lblBeliNoBatch.Size = new System.Drawing.Size(76, 19);
            this.lblBeliNoBatch.TabIndex = 81;
            this.lblBeliNoBatch.Text = "NO BATCH";
            // 
            // dgvDetailBeli
            // 
            this.dgvDetailBeli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDetailBeli.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetailBeli.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvDetailBeli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetailBeli.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvDetailBeli.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetailBeli.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.dgvDetailBeli.ColumnHeadersHeight = 22;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetailBeli.DefaultCellStyle = dataGridViewCellStyle40;
            this.dgvDetailBeli.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDetailBeli.GridColor = System.Drawing.SystemColors.Window;
            this.dgvDetailBeli.Location = new System.Drawing.Point(0, 175);
            this.dgvDetailBeli.Name = "dgvDetailBeli";
            this.dgvDetailBeli.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetailBeli.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDetailBeli.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetailBeli.Size = new System.Drawing.Size(685, 107);
            this.dgvDetailBeli.TabIndex = 72;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1212, 551);
            this.Controls.Add(this.btnTrans);
            this.Controls.Add(this.btnRegis);
            this.Controls.Add(this.gbNav);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 15);
            this.Text = "Cashier";
            ((System.ComponentModel.ISupportInitialize)(this.msManager)).EndInit();
            this.mtbRegis.ResumeLayout(false);
            this.tbBarang.ResumeLayout(false);
            this.tbBarang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            this.tbCustomer.ResumeLayout(false);
            this.tbCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.tbSupplier.ResumeLayout(false);
            this.tbSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.gbNav.ResumeLayout(false);
            this.mtbTransc.ResumeLayout(false);
            this.mtbPenjualan.ResumeLayout(false);
            this.mtbPenjualan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailJual)).EndInit();
            this.mtbPembelian.ResumeLayout(false);
            this.mtbPembelian.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailBeli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msManager;
        private MetroFramework.Controls.MetroTile btnTrans;
        private MetroFramework.Controls.MetroTile btnRegis;
        private System.Windows.Forms.GroupBox gbNav;
        private MetroFramework.Controls.MetroTile btnDelete;
        private MetroFramework.Controls.MetroTile btnExit;
        private MetroFramework.Controls.MetroTile btnNew;
        private MetroFramework.Controls.MetroTile btnSave;
        private MetroFramework.Controls.MetroTabControl mtbRegis;
        private MetroFramework.Controls.MetroTabPage tbBarang;
        private System.Windows.Forms.DataGridView dgvBarang;
        private System.Windows.Forms.TextBox BarangHargaJual;
        private System.Windows.Forms.TextBox BarangHargaHPP;
        private System.Windows.Forms.TextBox BarangJmlhAwal;
        private System.Windows.Forms.TextBox BarangNama;
        private System.Windows.Forms.TextBox BarangKode;
        private MetroFramework.Controls.MetroLabel lblHargaJual;
        private MetroFramework.Controls.MetroLabel lblHargaHPP;
        private MetroFramework.Controls.MetroLabel lblJumlahAwal;
        private MetroFramework.Controls.MetroLabel lblNamaBarang;
        private MetroFramework.Controls.MetroLabel lblKodeBarang;
        private MetroFramework.Controls.MetroTabPage tbCustomer;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.TextBox CustomerHp;
        private MetroFramework.Controls.MetroLabel lblCustomerHp;
        private System.Windows.Forms.TextBox CustomerAlamat;
        private MetroFramework.Controls.MetroLabel lblCustomerAlamat;
        private System.Windows.Forms.TextBox CustomerNama;
        private System.Windows.Forms.TextBox CustomerKode;
        private MetroFramework.Controls.MetroLabel lblCustomerNama;
        private MetroFramework.Controls.MetroLabel lblCustomerKode;
        private MetroFramework.Controls.MetroTabPage tbSupplier;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.TextBox SupplierHp;
        private MetroFramework.Controls.MetroLabel lblSupplierHp;
        private System.Windows.Forms.TextBox SupplierAlamat;
        private MetroFramework.Controls.MetroLabel lblSupplierAlamat;
        private System.Windows.Forms.TextBox SupplierNama;
        private System.Windows.Forms.TextBox SupplierKode;
        private MetroFramework.Controls.MetroLabel lblSupplierNama;
        private MetroFramework.Controls.MetroLabel lblSupplierKode;
        private MetroFramework.Controls.MetroTabControl mtbTransc;
        private MetroFramework.Controls.MetroTabPage mtbPenjualan;
        private System.Windows.Forms.TextBox JualAlamat;
        private MetroFramework.Controls.MetroLabel lblJualAlamat;
        private System.Windows.Forms.TextBox JualCustomer;
        private MetroFramework.Controls.MetroLabel lblJualCustomer;
        private System.Windows.Forms.TextBox JualNama;
        private System.Windows.Forms.TextBox JualKode;
        private MetroFramework.Controls.MetroLabel lblJualTanggal;
        private MetroFramework.Controls.MetroLabel lblJualNoBatch;
        private System.Windows.Forms.DataGridView dgvDetailJual;
        private MetroFramework.Controls.MetroTabPage mtbPembelian;
        private System.Windows.Forms.TextBox NamaSupplier;
        private MetroFramework.Controls.MetroLabel lblBeliNamaSupplier;
        private System.Windows.Forms.TextBox BeliSupplier;
        private MetroFramework.Controls.MetroLabel lblBeliSupplier;
        private System.Windows.Forms.TextBox BeliTanggal;
        private System.Windows.Forms.TextBox BeliNoBatch;
        private MetroFramework.Controls.MetroLabel lblBeliTanggal;
        private MetroFramework.Controls.MetroLabel lblBeliNoBatch;
        private System.Windows.Forms.DataGridView dgvDetailBeli;

    }
}

