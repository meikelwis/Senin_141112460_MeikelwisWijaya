namespace Latihan_1_no_1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblRMax = new System.Windows.Forms.Label();
            this.lblRMin = new System.Windows.Forms.Label();
            this.vSBMin = new System.Windows.Forms.VScrollBar();
            this.lblMax = new System.Windows.Forms.Label();
            this.vSBMax = new System.Windows.Forms.VScrollBar();
            this.lblMin = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(32, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(411, 350);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblRMax);
            this.tabPage1.Controls.Add(this.lblRMin);
            this.tabPage1.Controls.Add(this.vSBMin);
            this.tabPage1.Controls.Add(this.lblMax);
            this.tabPage1.Controls.Add(this.vSBMax);
            this.tabPage1.Controls.Add(this.lblMin);
            this.tabPage1.Controls.Add(this.monthCalendar);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(403, 323);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lblRMax
            // 
            this.lblRMax.AutoSize = true;
            this.lblRMax.Location = new System.Drawing.Point(272, 231);
            this.lblRMax.Name = "lblRMax";
            this.lblRMax.Size = new System.Drawing.Size(50, 13);
            this.lblRMax.TabIndex = 8;
            this.lblRMax.Text = "DateMax";
            // 
            // lblRMin
            // 
            this.lblRMin.AutoSize = true;
            this.lblRMin.Location = new System.Drawing.Point(3, 231);
            this.lblRMin.Name = "lblRMin";
            this.lblRMin.Size = new System.Drawing.Size(47, 13);
            this.lblRMin.TabIndex = 1;
            this.lblRMin.Text = "DateMin";
            // 
            // vSBMin
            // 
            this.vSBMin.Location = new System.Drawing.Point(20, 37);
            this.vSBMin.Name = "vSBMin";
            this.vSBMin.Size = new System.Drawing.Size(17, 162);
            this.vSBMin.TabIndex = 7;
            this.vSBMin.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vSBMin_Scroll);
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(272, 208);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(85, 13);
            this.lblMax.TabIndex = 3;
            this.lblMax.Text = "Tahun Maksimal";
            // 
            // vSBMax
            // 
            this.vSBMax.Location = new System.Drawing.Point(317, 37);
            this.vSBMax.Name = "vSBMax";
            this.vSBMax.Size = new System.Drawing.Size(17, 162);
            this.vSBMax.TabIndex = 1;
            this.vSBMax.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vSBMax_Scroll);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(3, 208);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(76, 13);
            this.lblMin.TabIndex = 2;
            this.lblMin.Text = "Tahun Minimal";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(71, 37);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(403, 323);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.jpg");
            this.imageList1.Images.SetKeyName(1, "2.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 374);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form_1_1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.VScrollBar vSBMax;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.VScrollBar vSBMin;
        private System.Windows.Forms.Label lblRMin;
        private System.Windows.Forms.Label lblRMax;
    }
}

