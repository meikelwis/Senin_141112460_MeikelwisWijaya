namespace Latihan_5_1
{
    partial class Form_5_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_5_1));
            this.cbBColor = new System.Windows.Forms.ComboBox();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBColor = new System.Windows.Forms.Label();
            this.pbU = new System.Windows.Forms.PictureBox();
            this.pBItalic = new System.Windows.Forms.PictureBox();
            this.pbBold = new System.Windows.Forms.PictureBox();
            this.rbContainer = new System.Windows.Forms.RichTextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFont = new System.Windows.Forms.Label();
            this.cbFontSize = new System.Windows.Forms.ComboBox();
            this.cbFont = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBItalic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBold)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbBColor
            // 
            this.cbBColor.FormattingEnabled = true;
            this.cbBColor.Location = new System.Drawing.Point(565, 27);
            this.cbBColor.Name = "cbBColor";
            this.cbBColor.Size = new System.Drawing.Size(121, 21);
            this.cbBColor.TabIndex = 34;
            this.cbBColor.SelectedIndexChanged += new System.EventHandler(this.cbBColor_SelectedIndexChanged);
            this.cbBColor.Click += new System.EventHandler(this.cbBColor_SelectedIndexChanged);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // lblBColor
            // 
            this.lblBColor.AutoSize = true;
            this.lblBColor.Location = new System.Drawing.Point(518, 30);
            this.lblBColor.Name = "lblBColor";
            this.lblBColor.Size = new System.Drawing.Size(41, 13);
            this.lblBColor.TabIndex = 35;
            this.lblBColor.Text = "B.Color";
            // 
            // pbU
            // 
            this.pbU.Image = ((System.Drawing.Image)(resources.GetObject("pbU.Image")));
            this.pbU.Location = new System.Drawing.Point(328, 27);
            this.pbU.Name = "pbU";
            this.pbU.Size = new System.Drawing.Size(28, 21);
            this.pbU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbU.TabIndex = 32;
            this.pbU.TabStop = false;
            this.pbU.Click += new System.EventHandler(this.pbU_Click);
            // 
            // pBItalic
            // 
            this.pBItalic.Image = ((System.Drawing.Image)(resources.GetObject("pBItalic.Image")));
            this.pBItalic.Location = new System.Drawing.Point(295, 27);
            this.pBItalic.Name = "pBItalic";
            this.pBItalic.Size = new System.Drawing.Size(28, 21);
            this.pBItalic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBItalic.TabIndex = 31;
            this.pBItalic.TabStop = false;
            this.pBItalic.Click += new System.EventHandler(this.pBItalic_Click);
            // 
            // pbBold
            // 
            this.pbBold.Image = ((System.Drawing.Image)(resources.GetObject("pbBold.Image")));
            this.pbBold.Location = new System.Drawing.Point(262, 27);
            this.pbBold.Name = "pbBold";
            this.pbBold.Size = new System.Drawing.Size(28, 21);
            this.pbBold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBold.TabIndex = 30;
            this.pbBold.TabStop = false;
            this.pbBold.Click += new System.EventHandler(this.pbBold_Click);
            // 
            // rbContainer
            // 
            this.rbContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbContainer.Location = new System.Drawing.Point(9, 54);
            this.rbContainer.Name = "rbContainer";
            this.rbContainer.Size = new System.Drawing.Size(679, 344);
            this.rbContainer.TabIndex = 29;
            this.rbContainer.Text = "";
            this.rbContainer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rbContainer_MouseUp);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(357, 30);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 28;
            this.lblColor.Text = "Color";
            // 
            // lblFontSize
            // 
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Location = new System.Drawing.Point(173, 30);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(27, 13);
            this.lblFontSize.TabIndex = 27;
            this.lblFontSize.Text = "Size";
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(394, 27);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(121, 21);
            this.cbColor.TabIndex = 24;
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.cbColor_SelectedIndexChanged);
            this.cbColor.Click += new System.EventHandler(this.cbColor_SelectedIndexChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(698, 24);
            this.menuStrip.TabIndex = 33;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 6);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            this.editorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editorToolStripMenuItem.Text = "Editor";
            this.editorToolStripMenuItem.Click += new System.EventHandler(this.editorToolStripMenuItem_Click);
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(7, 30);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(28, 13);
            this.lblFont.TabIndex = 26;
            this.lblFont.Text = "Font";
            // 
            // cbFontSize
            // 
            this.cbFontSize.FormattingEnabled = true;
            this.cbFontSize.Location = new System.Drawing.Point(206, 27);
            this.cbFontSize.Name = "cbFontSize";
            this.cbFontSize.Size = new System.Drawing.Size(50, 21);
            this.cbFontSize.TabIndex = 25;
            this.cbFontSize.SelectedIndexChanged += new System.EventHandler(this.cbFontSize_SelectedIndexChanged);
            // 
            // cbFont
            // 
            this.cbFont.FormattingEnabled = true;
            this.cbFont.Location = new System.Drawing.Point(36, 27);
            this.cbFont.Name = "cbFont";
            this.cbFont.Size = new System.Drawing.Size(121, 21);
            this.cbFont.TabIndex = 23;
            this.cbFont.SelectedIndexChanged += new System.EventHandler(this.cbFont_SelectedIndexChanged);
            // 
            // Form_5_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 400);
            this.Controls.Add(this.cbBColor);
            this.Controls.Add(this.lblBColor);
            this.Controls.Add(this.pbU);
            this.Controls.Add(this.pBItalic);
            this.Controls.Add(this.pbBold);
            this.Controls.Add(this.rbContainer);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblFontSize);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.lblFont);
            this.Controls.Add(this.cbFontSize);
            this.Controls.Add(this.cbFont);
            this.Name = "Form_5_1";
            this.Text = "Form_5_1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBItalic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBold)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBColor;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Label lblBColor;
        private System.Windows.Forms.PictureBox pbU;
        private System.Windows.Forms.PictureBox pBItalic;
        private System.Windows.Forms.PictureBox pbBold;
        private System.Windows.Forms.RichTextBox rbContainer;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.ComboBox cbFontSize;
        private System.Windows.Forms.ComboBox cbFont;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}

