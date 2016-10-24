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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Background");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Theme", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tVEditor = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tVEditor
            // 
            this.tVEditor.Dock = System.Windows.Forms.DockStyle.Left;
            this.tVEditor.Location = new System.Drawing.Point(0, 0);
            this.tVEditor.Name = "tVEditor";
            treeNode1.Name = "Th_Backgound";
            treeNode1.Text = "Background";
            treeNode2.Name = "nodeTheme";
            treeNode2.Text = "Theme";
            this.tVEditor.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.tVEditor.Size = new System.Drawing.Size(121, 304);
            this.tVEditor.TabIndex = 1;
            // 
            // Form_5_1_a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 304);
            this.Controls.Add(this.tVEditor);
            this.IsMdiContainer = true;
            this.Name = "Form_5_1_a";
            this.Text = "Form_5_1_a";
            this.Load += new System.EventHandler(this._5_1_a_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tVEditor;
    }
}