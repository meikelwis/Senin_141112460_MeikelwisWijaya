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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.msManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnRegis = new MetroFramework.Controls.MetroTile();
            this.btnTrans = new MetroFramework.Controls.MetroTile();
            this.gbNav = new System.Windows.Forms.GroupBox();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.btnExit = new MetroFramework.Controls.MetroTile();
            this.btnNew = new MetroFramework.Controls.MetroTile();
            this.btnSave = new MetroFramework.Controls.MetroTile();
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
            this.lblcustomerHp = new MetroFramework.Controls.MetroLabel();
            this.CustomerAlamat = new System.Windows.Forms.TextBox();
            this.lblcustomerAlamat = new MetroFramework.Controls.MetroLabel();
            this.CustomerNama = new System.Windows.Forms.TextBox();
            this.CustomerKode = new System.Windows.Forms.TextBox();
            this.lblcustomerNama = new MetroFramework.Controls.MetroLabel();
            this.lblcustomerKode = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.msManager)).BeginInit();
            this.gbNav.SuspendLayout();
            this.mtbRegis.SuspendLayout();
            this.tbBarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            this.tbCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // msManager
            // 
            this.msManager.Owner = this;
            this.msManager.Style = MetroFramework.MetroColorStyle.Blue;
            this.msManager.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnRegis
            // 
            this.btnRegis.BackColor = System.Drawing.Color.White;
            this.btnRegis.Location = new System.Drawing.Point(12, 24);
            this.btnRegis.Name = "btnRegis";
            this.btnRegis.Size = new System.Drawing.Size(98, 34);
            this.btnRegis.TabIndex = 24;
            this.btnRegis.Text = "Registration";
            this.btnRegis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTrans
            // 
            this.btnTrans.BackColor = System.Drawing.Color.White;
            this.btnTrans.Location = new System.Drawing.Point(129, 24);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(98, 34);
            this.btnTrans.TabIndex = 25;
            this.btnTrans.Text = "Transaction";
            this.btnTrans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbNav
            // 
            this.gbNav.AutoSize = true;
            this.gbNav.BackColor = System.Drawing.Color.Transparent;
            this.gbNav.Controls.Add(this.btnDelete);
            this.gbNav.Controls.Add(this.btnExit);
            this.gbNav.Controls.Add(this.btnNew);
            this.gbNav.Controls.Add(this.btnSave);
            this.gbNav.Controls.Add(this.btnTrans);
            this.gbNav.Controls.Add(this.btnRegis);
            this.gbNav.Controls.Add(this.mtbRegis);
            this.gbNav.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNav.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbNav.Location = new System.Drawing.Point(18, 63);
            this.gbNav.Name = "gbNav";
            this.gbNav.Padding = new System.Windows.Forms.Padding(3, 5, 5, 3);
            this.gbNav.Size = new System.Drawing.Size(858, 550);
            this.gbNav.TabIndex = 22;
            this.gbNav.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(240, 401);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 29);
            this.btnDelete.TabIndex = 71;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(344, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 29);
            this.btnExit.TabIndex = 70;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(18, 401);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 29);
            this.btnNew.TabIndex = 69;
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(127, 401);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 29);
            this.btnSave.TabIndex = 68;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // mtbRegis
            // 
            this.mtbRegis.Controls.Add(this.tbBarang);
            this.mtbRegis.Controls.Add(this.tbCustomer);
            this.mtbRegis.Location = new System.Drawing.Point(12, 74);
            this.mtbRegis.Name = "mtbRegis";
            this.mtbRegis.SelectedIndex = 1;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBarang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBarang.ColumnHeadersHeight = 22;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBarang.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.tbCustomer.Controls.Add(this.lblcustomerHp);
            this.tbCustomer.Controls.Add(this.CustomerAlamat);
            this.tbCustomer.Controls.Add(this.lblcustomerAlamat);
            this.tbCustomer.Controls.Add(this.CustomerNama);
            this.tbCustomer.Controls.Add(this.CustomerKode);
            this.tbCustomer.Controls.Add(this.lblcustomerNama);
            this.tbCustomer.Controls.Add(this.lblcustomerKode);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomer.ColumnHeadersHeight = 22;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomer.DefaultCellStyle = dataGridViewCellStyle4;
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
            // lblcustomerHp
            // 
            this.lblcustomerHp.AutoSize = true;
            this.lblcustomerHp.Location = new System.Drawing.Point(2, 101);
            this.lblcustomerHp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcustomerHp.Name = "lblcustomerHp";
            this.lblcustomerHp.Size = new System.Drawing.Size(91, 19);
            this.lblcustomerHp.TabIndex = 59;
            this.lblcustomerHp.Text = "HANDPHONE";
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
            // lblcustomerAlamat
            // 
            this.lblcustomerAlamat.AutoSize = true;
            this.lblcustomerAlamat.Location = new System.Drawing.Point(2, 74);
            this.lblcustomerAlamat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcustomerAlamat.Name = "lblcustomerAlamat";
            this.lblcustomerAlamat.Size = new System.Drawing.Size(61, 19);
            this.lblcustomerAlamat.TabIndex = 57;
            this.lblcustomerAlamat.Text = "ALAMAT";
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
            // lblcustomerNama
            // 
            this.lblcustomerNama.AutoSize = true;
            this.lblcustomerNama.Location = new System.Drawing.Point(2, 47);
            this.lblcustomerNama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcustomerNama.Name = "lblcustomerNama";
            this.lblcustomerNama.Size = new System.Drawing.Size(49, 19);
            this.lblcustomerNama.TabIndex = 54;
            this.lblcustomerNama.Text = "NAMA";
            // 
            // lblcustomerKode
            // 
            this.lblcustomerKode.AutoSize = true;
            this.lblcustomerKode.BackColor = System.Drawing.SystemColors.Control;
            this.lblcustomerKode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblcustomerKode.Location = new System.Drawing.Point(2, 21);
            this.lblcustomerKode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcustomerKode.Name = "lblcustomerKode";
            this.lblcustomerKode.Size = new System.Drawing.Size(43, 19);
            this.lblcustomerKode.TabIndex = 53;
            this.lblcustomerKode.Text = "KODE";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(894, 551);
            this.Controls.Add(this.gbNav);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 15);
            this.Text = "Cashier";
            ((System.ComponentModel.ISupportInitialize)(this.msManager)).EndInit();
            this.gbNav.ResumeLayout(false);
            this.mtbRegis.ResumeLayout(false);
            this.tbBarang.ResumeLayout(false);
            this.tbBarang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            this.tbCustomer.ResumeLayout(false);
            this.tbCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msManager;
        private System.Windows.Forms.GroupBox gbNav;
        private MetroFramework.Controls.MetroTile btnTrans;
        private MetroFramework.Controls.MetroTile btnRegis;
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
        private System.Windows.Forms.TextBox CustomerAlamat;
        private MetroFramework.Controls.MetroLabel lblcustomerAlamat;
        private System.Windows.Forms.TextBox CustomerNama;
        private System.Windows.Forms.TextBox CustomerKode;
        private MetroFramework.Controls.MetroLabel lblcustomerNama;
        private MetroFramework.Controls.MetroLabel lblcustomerKode;
        private MetroFramework.Controls.MetroTile btnDelete;
        private MetroFramework.Controls.MetroTile btnExit;
        private MetroFramework.Controls.MetroTile btnNew;
        private MetroFramework.Controls.MetroTile btnSave;
        private System.Windows.Forms.TextBox CustomerHp;
        private MetroFramework.Controls.MetroLabel lblcustomerHp;
        private System.Windows.Forms.DataGridView dgvCustomer;

    }
}

