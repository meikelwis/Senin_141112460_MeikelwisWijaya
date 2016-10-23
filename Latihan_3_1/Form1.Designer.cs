namespace Latihan_3_1
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
            this.cbFont = new System.Windows.Forms.ComboBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.cbFontSize = new System.Windows.Forms.ComboBox();
            this.lblFont = new System.Windows.Forms.Label();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.rbContainer = new System.Windows.Forms.RichTextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pbU = new System.Windows.Forms.PictureBox();
            this.pBItalic = new System.Windows.Forms.PictureBox();
            this.pbBold = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBItalic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBold)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFont
            // 
            this.cbFont.FormattingEnabled = true;
            this.cbFont.Location = new System.Drawing.Point(40, 12);
            this.cbFont.Name = "cbFont";
            this.cbFont.Size = new System.Drawing.Size(121, 21);
            this.cbFont.TabIndex = 0;
            this.cbFont.SelectedIndexChanged += new System.EventHandler(this.cbFont_SelectedIndexChanged);
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(398, 12);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(121, 21);
            this.cbColor.TabIndex = 1;
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.cbColor_SelectedIndexChanged);
            // 
            // cbFontSize
            // 
            this.cbFontSize.FormattingEnabled = true;
            this.cbFontSize.Location = new System.Drawing.Point(210, 12);
            this.cbFontSize.Name = "cbFontSize";
            this.cbFontSize.Size = new System.Drawing.Size(50, 21);
            this.cbFontSize.TabIndex = 2;
            this.cbFontSize.SelectedIndexChanged += new System.EventHandler(this.cbFontSize_SelectedIndexChanged);
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(11, 15);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(28, 13);
            this.lblFont.TabIndex = 3;
            this.lblFont.Text = "Font";
            // 
            // lblFontSize
            // 
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Location = new System.Drawing.Point(177, 15);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(27, 13);
            this.lblFontSize.TabIndex = 4;
            this.lblFontSize.Text = "Size";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(361, 15);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 5;
            this.lblColor.Text = "Color";
            // 
            // rbContainer
            // 
            this.rbContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbContainer.Location = new System.Drawing.Point(14, 44);
            this.rbContainer.Name = "rbContainer";
            this.rbContainer.Size = new System.Drawing.Size(528, 272);
            this.rbContainer.TabIndex = 6;
            this.rbContainer.Text = "";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pbU
            // 
            this.pbU.Image = global::Latihan_3_1.Properties.Resources._5094249309271;
            this.pbU.Location = new System.Drawing.Point(332, 12);
            this.pbU.Name = "pbU";
            this.pbU.Size = new System.Drawing.Size(28, 21);
            this.pbU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbU.TabIndex = 9;
            this.pbU.TabStop = false;
            this.pbU.Click += new System.EventHandler(this.pbU_Click);
            // 
            // pBItalic
            // 
            this.pBItalic.Image = global::Latihan_3_1.Properties.Resources._5094249340845;
            this.pBItalic.Location = new System.Drawing.Point(299, 12);
            this.pBItalic.Name = "pBItalic";
            this.pBItalic.Size = new System.Drawing.Size(28, 21);
            this.pBItalic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBItalic.TabIndex = 8;
            this.pBItalic.TabStop = false;
            this.pBItalic.Click += new System.EventHandler(this.pBItalic_Click);
            // 
            // pbBold
            // 
            this.pbBold.Image = global::Latihan_3_1.Properties.Resources._5094249278505;
            this.pbBold.Location = new System.Drawing.Point(266, 12);
            this.pbBold.Name = "pbBold";
            this.pbBold.Size = new System.Drawing.Size(28, 21);
            this.pbBold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBold.TabIndex = 7;
            this.pbBold.TabStop = false;
            this.pbBold.Click += new System.EventHandler(this.pbBold_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 328);
            this.Controls.Add(this.pbU);
            this.Controls.Add(this.pBItalic);
            this.Controls.Add(this.pbBold);
            this.Controls.Add(this.rbContainer);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblFontSize);
            this.Controls.Add(this.lblFont);
            this.Controls.Add(this.cbFontSize);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.cbFont);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBItalic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFont;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.ComboBox cbFontSize;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.RichTextBox rbContainer;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox pbU;
        private System.Windows.Forms.PictureBox pBItalic;
        private System.Windows.Forms.PictureBox pbBold;
    }
}

