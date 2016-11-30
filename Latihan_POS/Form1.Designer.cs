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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabInput = new System.Windows.Forms.TabControl();
            this.tbpMasterInput = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblJumlah_Awal = new System.Windows.Forms.Label();
            this.lblHarga_Jual = new System.Windows.Forms.Label();
            this.lblHarga_HPP = new System.Windows.Forms.Label();
            this.txtHarga_Jual = new System.Windows.Forms.TextBox();
            this.txtHarga_HPP = new System.Windows.Forms.TextBox();
            this.txtJmlh_Awal = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblKode = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.tbpMasterList = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabInput.SuspendLayout();
            this.tbpMasterInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(704, 25);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrationToolStripMenuItem
            // 
            this.registrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barangToolStripMenuItem});
            this.registrationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            this.registrationToolStripMenuItem.Size = new System.Drawing.Size(90, 21);
            this.registrationToolStripMenuItem.Text = "Registration";
            // 
            // barangToolStripMenuItem
            // 
            this.barangToolStripMenuItem.Name = "barangToolStripMenuItem";
            this.barangToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.barangToolStripMenuItem.Text = "Barang";
            // 
            // tabInput
            // 
            this.tabInput.Controls.Add(this.tbpMasterInput);
            this.tabInput.Controls.Add(this.tbpMasterList);
            this.tabInput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabInput.Location = new System.Drawing.Point(16, 27);
            this.tabInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tabInput.Name = "tabInput";
            this.tabInput.Padding = new System.Drawing.Point(5, 5);
            this.tabInput.SelectedIndex = 0;
            this.tabInput.Size = new System.Drawing.Size(667, 310);
            this.tabInput.TabIndex = 17;
            // 
            // tbpMasterInput
            // 
            this.tbpMasterInput.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbpMasterInput.Controls.Add(this.btnExit);
            this.tbpMasterInput.Controls.Add(this.btnCancel);
            this.tbpMasterInput.Controls.Add(this.btnSave);
            this.tbpMasterInput.Controls.Add(this.lblJumlah_Awal);
            this.tbpMasterInput.Controls.Add(this.lblHarga_Jual);
            this.tbpMasterInput.Controls.Add(this.lblHarga_HPP);
            this.tbpMasterInput.Controls.Add(this.txtHarga_Jual);
            this.tbpMasterInput.Controls.Add(this.txtHarga_HPP);
            this.tbpMasterInput.Controls.Add(this.txtJmlh_Awal);
            this.tbpMasterInput.Controls.Add(this.lblNama);
            this.tbpMasterInput.Controls.Add(this.lblKode);
            this.tbpMasterInput.Controls.Add(this.txtNama);
            this.tbpMasterInput.Controls.Add(this.txtKode);
            this.tbpMasterInput.Location = new System.Drawing.Point(4, 30);
            this.tbpMasterInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbpMasterInput.Name = "tbpMasterInput";
            this.tbpMasterInput.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbpMasterInput.Size = new System.Drawing.Size(659, 276);
            this.tbpMasterInput.TabIndex = 1;
            this.tbpMasterInput.Text = "Input";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.CadetBlue;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(297, 171);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 23);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(147, 171);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(7, 171);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblJumlah_Awal
            // 
            this.lblJumlah_Awal.AutoSize = true;
            this.lblJumlah_Awal.Location = new System.Drawing.Point(19, 76);
            this.lblJumlah_Awal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJumlah_Awal.Name = "lblJumlah_Awal";
            this.lblJumlah_Awal.Size = new System.Drawing.Size(79, 17);
            this.lblJumlah_Awal.TabIndex = 24;
            this.lblJumlah_Awal.Text = "Jumlah Awal";
            this.lblJumlah_Awal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblHarga_Jual
            // 
            this.lblHarga_Jual.AutoSize = true;
            this.lblHarga_Jual.Location = new System.Drawing.Point(19, 128);
            this.lblHarga_Jual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHarga_Jual.Name = "lblHarga_Jual";
            this.lblHarga_Jual.Size = new System.Drawing.Size(70, 17);
            this.lblHarga_Jual.TabIndex = 23;
            this.lblHarga_Jual.Text = "Harga Jual";
            this.lblHarga_Jual.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblHarga_HPP
            // 
            this.lblHarga_HPP.AutoSize = true;
            this.lblHarga_HPP.Location = new System.Drawing.Point(19, 102);
            this.lblHarga_HPP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHarga_HPP.Name = "lblHarga_HPP";
            this.lblHarga_HPP.Size = new System.Drawing.Size(71, 17);
            this.lblHarga_HPP.TabIndex = 22;
            this.lblHarga_HPP.Text = "Harga HPP";
            this.lblHarga_HPP.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtHarga_Jual
            // 
            this.txtHarga_Jual.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtHarga_Jual.Location = new System.Drawing.Point(147, 128);
            this.txtHarga_Jual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHarga_Jual.Name = "txtHarga_Jual";
            this.txtHarga_Jual.Size = new System.Drawing.Size(132, 25);
            this.txtHarga_Jual.TabIndex = 21;
            // 
            // txtHarga_HPP
            // 
            this.txtHarga_HPP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtHarga_HPP.Location = new System.Drawing.Point(147, 102);
            this.txtHarga_HPP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHarga_HPP.Name = "txtHarga_HPP";
            this.txtHarga_HPP.Size = new System.Drawing.Size(132, 25);
            this.txtHarga_HPP.TabIndex = 20;
            // 
            // txtJmlh_Awal
            // 
            this.txtJmlh_Awal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtJmlh_Awal.Location = new System.Drawing.Point(147, 76);
            this.txtJmlh_Awal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtJmlh_Awal.Name = "txtJmlh_Awal";
            this.txtJmlh_Awal.Size = new System.Drawing.Size(132, 25);
            this.txtJmlh_Awal.TabIndex = 19;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(19, 50);
            this.lblNama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(43, 17);
            this.lblNama.TabIndex = 18;
            this.lblNama.Text = "Nama";
            this.lblNama.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblKode
            // 
            this.lblKode.AutoSize = true;
            this.lblKode.Location = new System.Drawing.Point(20, 24);
            this.lblKode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKode.Name = "lblKode";
            this.lblKode.Size = new System.Drawing.Size(39, 17);
            this.lblKode.TabIndex = 17;
            this.lblKode.Text = "Kode";
            this.lblKode.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNama
            // 
            this.txtNama.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNama.Location = new System.Drawing.Point(147, 50);
            this.txtNama.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(265, 25);
            this.txtNama.TabIndex = 16;
            // 
            // txtKode
            // 
            this.txtKode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtKode.Location = new System.Drawing.Point(147, 24);
            this.txtKode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(132, 25);
            this.txtKode.TabIndex = 15;
            // 
            // tbpMasterList
            // 
            this.tbpMasterList.Location = new System.Drawing.Point(4, 30);
            this.tbpMasterList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbpMasterList.Name = "tbpMasterList";
            this.tbpMasterList.Size = new System.Drawing.Size(659, 276);
            this.tbpMasterList.TabIndex = 2;
            this.tbpMasterList.Text = "List";
            this.tbpMasterList.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 346);
            this.Controls.Add(this.tabInput);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain";
            this.Text = "Cashier";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabInput.ResumeLayout(false);
            this.tbpMasterInput.ResumeLayout(false);
            this.tbpMasterInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barangToolStripMenuItem;
        private System.Windows.Forms.TabControl tabInput;
        private System.Windows.Forms.TabPage tbpMasterInput;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblJumlah_Awal;
        private System.Windows.Forms.Label lblHarga_Jual;
        private System.Windows.Forms.Label lblHarga_HPP;
        private System.Windows.Forms.TextBox txtHarga_Jual;
        private System.Windows.Forms.TextBox txtHarga_HPP;
        private System.Windows.Forms.TextBox txtJmlh_Awal;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblKode;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.TabPage tbpMasterList;

    }
}

