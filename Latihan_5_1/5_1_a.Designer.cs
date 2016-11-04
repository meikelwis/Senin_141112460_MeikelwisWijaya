namespace Latihan_5_1
{
    partial class Form_5_1_a
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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Background");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Theme", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.tVEditor = new System.Windows.Forms.TreeView();
            this.cbBColor = new System.Windows.Forms.ComboBox();
            this.lblBColor = new System.Windows.Forms.Label();
            this.bOk = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tVEditor
            // 
            this.tVEditor.Dock = System.Windows.Forms.DockStyle.Left;
            this.tVEditor.Location = new System.Drawing.Point(0, 0);
            this.tVEditor.Name = "tVEditor";
            treeNode3.Name = "Th_Backgound";
            treeNode3.Text = "Background";
            treeNode4.Name = "nodeTheme";
            treeNode4.Text = "Theme";
            this.tVEditor.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.tVEditor.Size = new System.Drawing.Size(121, 304);
            this.tVEditor.TabIndex = 1;
            // 
            // cbBColor
            // 
            this.cbBColor.FormattingEnabled = true;
            this.cbBColor.Location = new System.Drawing.Point(188, 12);
            this.cbBColor.Name = "cbBColor";
            this.cbBColor.Size = new System.Drawing.Size(121, 21);
            this.cbBColor.TabIndex = 49;
            // 
            // lblBColor
            // 
            this.lblBColor.AutoSize = true;
            this.lblBColor.Location = new System.Drawing.Point(141, 15);
            this.lblBColor.Name = "lblBColor";
            this.lblBColor.Size = new System.Drawing.Size(41, 13);
            this.lblBColor.TabIndex = 50;
            this.lblBColor.Text = "B.Color";
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(144, 269);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(38, 23);
            this.bOk.TabIndex = 51;
            this.bOk.Text = "OK";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(202, 269);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(56, 23);
            this.bCancel.TabIndex = 52;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // Form_5_1_a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 304);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.cbBColor);
            this.Controls.Add(this.lblBColor);
            this.Controls.Add(this.tVEditor);
            this.Name = "Form_5_1_a";
            this.Text = "Form_5_1_a";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_5_1_a_FormClosing);
            this.Load += new System.EventHandler(this._5_1_a_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tVEditor;
        private System.Windows.Forms.ComboBox cbBColor;
        private System.Windows.Forms.Label lblBColor;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bCancel;
    }
}