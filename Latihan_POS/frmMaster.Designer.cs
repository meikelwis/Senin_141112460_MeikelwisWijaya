﻿namespace Latihan_POS
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
            this.msManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mtbBarang = new MetroFramework.Controls.MetroTabControl();
            this.tbBarang = new MetroFramework.Controls.MetroTabPage();
            this.btnExit = new MetroFramework.Controls.MetroTile();
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            this.btnReset = new MetroFramework.Controls.MetroTile();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.txtHarga_Jual = new System.Windows.Forms.TextBox();
            this.txtHarga_HPP = new System.Windows.Forms.TextBox();
            this.txtJmlh_Awal = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.lblHargaJual = new MetroFramework.Controls.MetroLabel();
            this.lblHargaHPP = new MetroFramework.Controls.MetroLabel();
            this.lblJumlahAwal = new MetroFramework.Controls.MetroLabel();
            this.lblNama = new MetroFramework.Controls.MetroLabel();
            this.lblKode = new MetroFramework.Controls.MetroLabel();
            this.tbCustomer = new MetroFramework.Controls.MetroTabPage();
            this.mtRegis = new MetroFramework.Controls.MetroTile();
            this.mtTrans = new MetroFramework.Controls.MetroTile();
            this.gbNav = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.msManager)).BeginInit();
            this.mtbBarang.SuspendLayout();
            this.tbBarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            this.gbNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // msManager
            // 
            this.msManager.Owner = this;
            this.msManager.Style = MetroFramework.MetroColorStyle.Blue;
            this.msManager.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // mtbBarang
            // 
            this.mtbBarang.Controls.Add(this.tbBarang);
            this.mtbBarang.Controls.Add(this.tbCustomer);
            this.mtbBarang.Location = new System.Drawing.Point(12, 64);
            this.mtbBarang.Name = "mtbBarang";
            this.mtbBarang.SelectedIndex = 0;
            this.mtbBarang.Size = new System.Drawing.Size(694, 464);
            this.mtbBarang.TabIndex = 19;
            // 
            // tbBarang
            // 
            this.tbBarang.Controls.Add(this.btnExit);
            this.tbBarang.Controls.Add(this.dgvBarang);
            this.tbBarang.Controls.Add(this.btnReset);
            this.tbBarang.Controls.Add(this.btnSave);
            this.tbBarang.Controls.Add(this.txtHarga_Jual);
            this.tbBarang.Controls.Add(this.txtHarga_HPP);
            this.tbBarang.Controls.Add(this.txtJmlh_Awal);
            this.tbBarang.Controls.Add(this.txtNama);
            this.tbBarang.Controls.Add(this.txtKode);
            this.tbBarang.Controls.Add(this.lblHargaJual);
            this.tbBarang.Controls.Add(this.lblHargaHPP);
            this.tbBarang.Controls.Add(this.lblJumlahAwal);
            this.tbBarang.Controls.Add(this.lblNama);
            this.tbBarang.Controls.Add(this.lblKode);
            this.tbBarang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tbBarang.HorizontalScrollbarBarColor = true;
            this.tbBarang.HorizontalScrollbarSize = 20;
            this.tbBarang.Location = new System.Drawing.Point(4, 35);
            this.tbBarang.Name = "tbBarang";
            this.tbBarang.Size = new System.Drawing.Size(686, 425);
            this.tbBarang.TabIndex = 0;
            this.tbBarang.Text = "Barang";
            this.tbBarang.VerticalScrollbarBarColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(224, 342);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 29);
            this.btnExit.TabIndex = 65;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBarang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBarang.ColumnHeadersHeight = 22;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBarang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBarang.GridColor = System.Drawing.SystemColors.Window;
            this.dgvBarang.Location = new System.Drawing.Point(-4, 167);
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBarang.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBarang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBarang.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBarang.Size = new System.Drawing.Size(748, 159);
            this.dgvBarang.TabIndex = 62;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(113, 342);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 29);
            this.btnReset.TabIndex = 64;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(0, 342);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 29);
            this.btnSave.TabIndex = 63;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtHarga_Jual
            // 
            this.txtHarga_Jual.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtHarga_Jual.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHarga_Jual.Location = new System.Drawing.Point(102, 128);
            this.txtHarga_Jual.Name = "txtHarga_Jual";
            this.txtHarga_Jual.Size = new System.Drawing.Size(100, 25);
            this.txtHarga_Jual.TabIndex = 55;
            // 
            // txtHarga_HPP
            // 
            this.txtHarga_HPP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtHarga_HPP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHarga_HPP.Location = new System.Drawing.Point(102, 102);
            this.txtHarga_HPP.Name = "txtHarga_HPP";
            this.txtHarga_HPP.Size = new System.Drawing.Size(100, 25);
            this.txtHarga_HPP.TabIndex = 54;
            // 
            // txtJmlh_Awal
            // 
            this.txtJmlh_Awal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtJmlh_Awal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJmlh_Awal.Location = new System.Drawing.Point(102, 76);
            this.txtJmlh_Awal.Name = "txtJmlh_Awal";
            this.txtJmlh_Awal.Size = new System.Drawing.Size(100, 25);
            this.txtJmlh_Awal.TabIndex = 53;
            // 
            // txtNama
            // 
            this.txtNama.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(102, 50);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(200, 25);
            this.txtNama.TabIndex = 52;
            // 
            // txtKode
            // 
            this.txtKode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtKode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKode.Location = new System.Drawing.Point(102, 24);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(100, 25);
            this.txtKode.TabIndex = 51;
            // 
            // lblHargaJual
            // 
            this.lblHargaJual.AutoSize = true;
            this.lblHargaJual.Location = new System.Drawing.Point(2, 129);
            this.lblHargaJual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHargaJual.Name = "lblHargaJual";
            this.lblHargaJual.Size = new System.Drawing.Size(71, 19);
            this.lblHargaJual.TabIndex = 50;
            this.lblHargaJual.Text = "Harga Jual";
            // 
            // lblHargaHPP
            // 
            this.lblHargaHPP.AutoSize = true;
            this.lblHargaHPP.Location = new System.Drawing.Point(2, 103);
            this.lblHargaHPP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHargaHPP.Name = "lblHargaHPP";
            this.lblHargaHPP.Size = new System.Drawing.Size(74, 19);
            this.lblHargaHPP.TabIndex = 49;
            this.lblHargaHPP.Text = "Harga HPP";
            // 
            // lblJumlahAwal
            // 
            this.lblJumlahAwal.AutoSize = true;
            this.lblJumlahAwal.Location = new System.Drawing.Point(2, 76);
            this.lblJumlahAwal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJumlahAwal.Name = "lblJumlahAwal";
            this.lblJumlahAwal.Size = new System.Drawing.Size(82, 19);
            this.lblJumlahAwal.TabIndex = 48;
            this.lblJumlahAwal.Text = "Jumlah Awal";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(2, 50);
            this.lblNama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(45, 19);
            this.lblNama.TabIndex = 47;
            this.lblNama.Text = "Nama";
            // 
            // lblKode
            // 
            this.lblKode.AutoSize = true;
            this.lblKode.BackColor = System.Drawing.SystemColors.Control;
            this.lblKode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKode.Location = new System.Drawing.Point(2, 24);
            this.lblKode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKode.Name = "lblKode";
            this.lblKode.Size = new System.Drawing.Size(39, 19);
            this.lblKode.TabIndex = 46;
            this.lblKode.Text = "Kode";
            // 
            // tbCustomer
            // 
            this.tbCustomer.HorizontalScrollbarBarColor = true;
            this.tbCustomer.Location = new System.Drawing.Point(4, 35);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(686, 425);
            this.tbCustomer.TabIndex = 1;
            this.tbCustomer.Text = "Customer";
            this.tbCustomer.VerticalScrollbarBarColor = true;
            // 
            // mtRegis
            // 
            this.mtRegis.BackColor = System.Drawing.Color.White;
            this.mtRegis.Location = new System.Drawing.Point(12, 24);
            this.mtRegis.Name = "mtRegis";
            this.mtRegis.Size = new System.Drawing.Size(98, 34);
            this.mtRegis.TabIndex = 24;
            this.mtRegis.Text = "Registration";
            this.mtRegis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtTrans
            // 
            this.mtTrans.BackColor = System.Drawing.Color.White;
            this.mtTrans.Location = new System.Drawing.Point(129, 24);
            this.mtTrans.Name = "mtTrans";
            this.mtTrans.Size = new System.Drawing.Size(98, 34);
            this.mtTrans.TabIndex = 25;
            this.mtTrans.Text = "Transaction";
            this.mtTrans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbNav
            // 
            this.gbNav.AutoSize = true;
            this.gbNav.BackColor = System.Drawing.Color.Transparent;
            this.gbNav.Controls.Add(this.mtTrans);
            this.gbNav.Controls.Add(this.mtRegis);
            this.gbNav.Controls.Add(this.mtbBarang);
            this.gbNav.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNav.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbNav.Location = new System.Drawing.Point(18, 63);
            this.gbNav.Name = "gbNav";
            this.gbNav.Padding = new System.Windows.Forms.Padding(3, 5, 5, 3);
            this.gbNav.Size = new System.Drawing.Size(858, 550);
            this.gbNav.TabIndex = 22;
            this.gbNav.TabStop = false;
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
            this.mtbBarang.ResumeLayout(false);
            this.tbBarang.ResumeLayout(false);
            this.tbBarang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            this.gbNav.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msManager;
        private System.Windows.Forms.GroupBox gbNav;
        private MetroFramework.Controls.MetroTile mtTrans;
        private MetroFramework.Controls.MetroTile mtRegis;
        private MetroFramework.Controls.MetroTabControl mtbBarang;
        private MetroFramework.Controls.MetroTabPage tbBarang;
        private System.Windows.Forms.TextBox txtHarga_Jual;
        private System.Windows.Forms.TextBox txtHarga_HPP;
        private System.Windows.Forms.TextBox txtJmlh_Awal;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtKode;
        private MetroFramework.Controls.MetroLabel lblHargaJual;
        private MetroFramework.Controls.MetroLabel lblHargaHPP;
        private MetroFramework.Controls.MetroLabel lblJumlahAwal;
        private MetroFramework.Controls.MetroLabel lblNama;
        private MetroFramework.Controls.MetroLabel lblKode;
        private MetroFramework.Controls.MetroTabPage tbCustomer;
        private MetroFramework.Controls.MetroTile btnExit;
        private MetroFramework.Controls.MetroTile btnReset;
        private MetroFramework.Controls.MetroTile btnSave;
        private System.Windows.Forms.DataGridView dgvBarang;

    }
}

