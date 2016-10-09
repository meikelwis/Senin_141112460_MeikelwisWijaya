namespace Latihan_2_2
{
    partial class Form1
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
            this.dupBulan = new System.Windows.Forms.DomainUpDown();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.monthCalender = new System.Windows.Forms.MonthCalendar();
            this.nupTanggal = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nupTanggal)).BeginInit();
            this.SuspendLayout();
            // 
            // dupBulan
            // 
            this.dupBulan.Items.Add("Jan");
            this.dupBulan.Items.Add("Feb");
            this.dupBulan.Items.Add("Mar");
            this.dupBulan.Items.Add("Apr");
            this.dupBulan.Items.Add("May");
            this.dupBulan.Items.Add("Jun");
            this.dupBulan.Items.Add("Jul");
            this.dupBulan.Items.Add("Aug");
            this.dupBulan.Items.Add("Sep");
            this.dupBulan.Items.Add("Oct");
            this.dupBulan.Items.Add("Nov");
            this.dupBulan.Items.Add("Dec");
            this.dupBulan.Location = new System.Drawing.Point(193, 23);
            this.dupBulan.Name = "dupBulan";
            this.dupBulan.Size = new System.Drawing.Size(120, 20);
            this.dupBulan.TabIndex = 1;
            this.dupBulan.Text = "Bulan";
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(366, 23);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 3;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(486, 23);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 4;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // monthCalender
            // 
            this.monthCalender.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalender.Location = new System.Drawing.Point(18, 75);
            this.monthCalender.Name = "monthCalender";
            this.monthCalender.TabIndex = 5;
            // 
            // nupTanggal
            // 
            this.nupTanggal.Location = new System.Drawing.Point(42, 22);
            this.nupTanggal.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nupTanggal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupTanggal.Name = "nupTanggal";
            this.nupTanggal.Size = new System.Drawing.Size(120, 20);
            this.nupTanggal.TabIndex = 8;
            this.nupTanggal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 482);
            this.Controls.Add(this.nupTanggal);
            this.Controls.Add(this.monthCalender);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dupBulan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.nupTanggal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DomainUpDown dupBulan;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.MonthCalendar monthCalender;
        private System.Windows.Forms.NumericUpDown nupTanggal;

    }
}

