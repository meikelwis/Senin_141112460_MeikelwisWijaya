namespace Latihan_4_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbContainer = new System.Windows.Forms.RichTextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.lblFont = new System.Windows.Forms.Label();
            this.cbFontSize = new System.Windows.Forms.ComboBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.cbFont = new System.Windows.Forms.ComboBox();
            this.pbU = new System.Windows.Forms.PictureBox();
            this.pBItalic = new System.Windows.Forms.PictureBox();
            this.pbBold = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBItalic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBold)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbContainer
            // 
            this.rbContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbContainer.Location = new System.Drawing.Point(15, 51);
            this.rbContainer.Name = "rbContainer";
            this.rbContainer.Size = new System.Drawing.Size(528, 290);
            this.rbContainer.TabIndex = 16;
            this.rbContainer.Text = "";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(362, 29);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 15;
            this.lblColor.Text = "Color";
            // 
            // lblFontSize
            // 
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Location = new System.Drawing.Point(178, 29);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(27, 13);
            this.lblFontSize.TabIndex = 14;
            this.lblFontSize.Text = "Size";
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(12, 29);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(28, 13);
            this.lblFont.TabIndex = 13;
            this.lblFont.Text = "Font";
            // 
            // cbFontSize
            // 
            this.cbFontSize.FormattingEnabled = true;
            this.cbFontSize.Location = new System.Drawing.Point(211, 26);
            this.cbFontSize.Name = "cbFontSize";
            this.cbFontSize.Size = new System.Drawing.Size(50, 21);
            this.cbFontSize.TabIndex = 12;
            this.cbFontSize.SelectedIndexChanged += new System.EventHandler(this.cbFontSize_SelectedIndexChanged);
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(399, 26);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(121, 21);
            this.cbColor.TabIndex = 11;
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.cbColor_SelectedIndexChanged);
            // 
            // cbFont
            // 
            this.cbFont.FormattingEnabled = true;
            this.cbFont.Location = new System.Drawing.Point(41, 26);
            this.cbFont.Name = "cbFont";
            this.cbFont.Size = new System.Drawing.Size(121, 21);
            this.cbFont.TabIndex = 10;
            this.cbFont.SelectedIndexChanged += new System.EventHandler(this.cbFont_SelectedIndexChanged);
            // 
            // pbU
            // 
            this.pbU.Image = ((System.Drawing.Image)(resources.GetObject("pbU.Image")));
            this.pbU.Location = new System.Drawing.Point(333, 26);
            this.pbU.Name = "pbU";
            this.pbU.Size = new System.Drawing.Size(28, 21);
            this.pbU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbU.TabIndex = 19;
            this.pbU.TabStop = false;
            this.pbU.Click += new System.EventHandler(this.pbU_Click);
            // 
            // pBItalic
            // 
            this.pBItalic.Image = ((System.Drawing.Image)(resources.GetObject("pBItalic.Image")));
            this.pBItalic.Location = new System.Drawing.Point(300, 26);
            this.pBItalic.Name = "pBItalic";
            this.pBItalic.Size = new System.Drawing.Size(28, 21);
            this.pBItalic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBItalic.TabIndex = 18;
            this.pBItalic.TabStop = false;
            this.pBItalic.Click += new System.EventHandler(this.pBItalic_Click);
            // 
            // pbBold
            // 
            this.pbBold.Image = ((System.Drawing.Image)(resources.GetObject("pbBold.Image")));
            this.pbBold.Location = new System.Drawing.Point(267, 26);
            this.pbBold.Name = "pbBold";
            this.pbBold.Size = new System.Drawing.Size(28, 21);
            this.pbBold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBold.TabIndex = 17;
            this.pbBold.TabStop = false;
            this.pbBold.Click += new System.EventHandler(this.pbBold_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 346);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBItalic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBold)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbU;
        private System.Windows.Forms.PictureBox pBItalic;
        private System.Windows.Forms.PictureBox pbBold;
        private System.Windows.Forms.RichTextBox rbContainer;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.ComboBox cbFontSize;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.ComboBox cbFont;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

    }
}

