using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_5_1
{
    public partial class Form_5_1 : Form
    {
        Font vfont = new Font("Times New Rowman", 12, FontStyle.Regular);
        string family = "";
        int size = 0;
        FontStyle fs = FontStyle.Regular;

        
        public Form_5_1()
        {
            InitializeComponent(); 

        }
        private void Form1_Load(object sender, EventArgs e)//Load Jenis Font,Size dan Warna
        {
            for (int i = 8; i < 101; i++)
            {
                cbFontSize.Items.Add(i.ToString());
            }
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                cbFont.Items.Add(font.Name);
            }
            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                {
                    cbColor.Items.Add(prop.Name);
                    cbBColor.Items.Add(prop.Name);
                }
            }
        }

        private RichTextBox setFamily(RichTextBox rb, string vfont)
        {
            string newfont = cbFont.SelectedItem.ToString();
            rb.SelectionFont = new Font(newfont, rb.SelectionFont.Size, rb.SelectionFont.Style);
            return rb;
        }
        private RichTextBox setSize(RichTextBox rb, int vsize)
        {
            vsize = Convert.ToInt32(cbFontSize.SelectedIndex + 1);
            rb.SelectionFont = new Font(rb.SelectionFont.FontFamily, vsize, rb.SelectionFont.Style);
            return rb;
        }
        private RichTextBox setStyle(RichTextBox rb, FontStyle vfs)
        {
            rb.SelectionFont = new Font(rb.SelectionFont.FontFamily, rb.SelectionFont.Size, vfs);
            return rb;
        }

        private void setFont(RichTextBox rb, Font vff, int type, string vfont, int vsize, FontStyle vfs) //Untuk Set font satu per satu pake looping 
        //kalau gak terset semua 10/21/2016  Meikelwis 
        {
            int mulai = rb.SelectionStart;
            int akhir = rb.SelectionLength + mulai;

            if (mulai - akhir != 0)
            {
                string fnt = cbFont.Text;
                for (int i = mulai; i < akhir; i++)
                {
                    rb.SelectionStart = i;
                    rb.SelectionLength = 1;
                    try
                    {
                        switch (type)
                        {
                            case 1:
                                setFamily(rb, vfont);
                                break;
                            case 2:
                                setSize(rb, vsize);
                                break;
                            case 3:
                                setStyle(rb, FontStyle.Bold);
                                break;
                            case 4:
                                setStyle(rb, FontStyle.Italic);
                                break;
                            case 5:
                                setStyle(rb, FontStyle.Underline);
                                break;
                            default:
                                break;
                        }
                    }
                    catch
                    {
                        return;
                    }
                }
            }
            else
                rb.SelectionFont = vff;
        }

        private void cbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            setFont(rbContainer, vfont, 1, family, size, fs);
        }

        private void cbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            setFont(rbContainer, vfont, 2, family, size, fs);
        }

        private void pbBold_Click(object sender, EventArgs e)
        {
            setFont(rbContainer, vfont, 3, family, size, fs);
        }

        private void pBItalic_Click(object sender, EventArgs e)
        {
            setFont(rbContainer, vfont, 4, family, size, fs);
        }

        private void pbU_Click(object sender, EventArgs e)
        {
            setFont(rbContainer, vfont, 5, family, size, fs);
        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            rbContainer.SelectionColor = Color.FromName(cbColor.Text);
        }

        private void cbBColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            rbContainer.SelectionBackColor = Color.FromName(cbBColor.Text); //24/10/16 Meikelwis Lupa tambah background Color
        }

        private void saveFile(RichTextBox rb)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.DefaultExt = "*.rtf";
            sf.Filter = "RTF Files|*.rtf";
            if (rbContainer.Text == null) return;
            if (sf.ShowDialog() == System.Windows.Forms.DialogResult.OK & sf.FileName.Length > 0)
                rb.SaveFile(sf.FileName);
        }
        private void openFile(RichTextBox rb)
        {
            OpenFileDialog sf = new OpenFileDialog();
            sf.DefaultExt = "*.rtf";
            sf.Filter = "RTF Files|*.rtf";
            if (sf.ShowDialog() == System.Windows.Forms.DialogResult.OK & sf.FileName.Length > 0)
                rb.LoadFile(sf.FileName);
        }
        // 10/23/2016 Meikelwis untuk open,save,file
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to save these files ?", "Important Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (rbContainer.Text != null)
            {
                if (dr == DialogResult.Yes) saveFile(rbContainer);
                else if (dr == DialogResult.No)
                {
                    rbContainer.Focus();
                }
                else if (dr == DialogResult.Cancel) return;
                rbContainer.Text = "";
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to save these files ?", "Important Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (rbContainer.Text != null)
            {
                if (dr == DialogResult.Yes)
                {
                    saveFile(rbContainer);
                    openFile(rbContainer);
                }
                else if (dr == DialogResult.No)
                {
                    rbContainer.Text = "";
                    openFile(rbContainer);
                }
                else if (dr == DialogResult.Cancel) return;
            } 
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile(rbContainer);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to save these files ?", "Important Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (rbContainer.Text != null)
            {
                if (dr == DialogResult.Yes) saveFile(rbContainer);
                else if (dr == DialogResult.No) Application.Exit();
                else if (dr == DialogResult.Cancel) return;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to save these files ?", "Important Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (rbContainer.Text != null)
            {
                if (dr == DialogResult.Yes) saveFile(rbContainer);
                else if (dr == DialogResult.No) Application.Exit();
                else if (dr == DialogResult.Cancel) return;
            }
        }

        private void rbContainer_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button==System.Windows.Forms.MouseButtons.Right)
            {
                cm.Show(this, e.X, e.Y);
            }
        }
        
        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_5_1_a setting = new Form_5_1_a();
            setting.MdiParent = this;
            rbContainer.SendToBack();
            setting.Show();
        }
        private RichTextBox vrbContainer;
        //Meikelwis 4/11/2016 Tambah Untuk Cut, Copy, Paste, Delete
        public RichTextBox VrbContainer
        {
            get { return rbContainer; }
            set { vrbContainer = rbContainer; }
        }

        public void showMain()
        {
            VrbContainer.Show();
            VrbContainer.BringToFront();

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rbContainer.SelectedRtf, TextDataFormat.Rtf);
            rbContainer.SelectedRtf = "";
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rbContainer.SelectedRtf, TextDataFormat.Rtf);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbContainer.SelectedRtf = Clipboard.GetText(TextDataFormat.Rtf);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbContainer.SelectedRtf = "";
        }
        private void cm_Opening(object sender, CancelEventArgs e)
        {
            if (!Clipboard.ContainsText(TextDataFormat.Rtf)) pasteToolStripMenuItem.Enabled = false;
            else pasteToolStripMenuItem.Enabled = true;

            if (rbContainer.SelectedText.Length <= 0)
            {
                copyToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
            }
            else
            {
                copyToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
            }
        }

        private void Form_5_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to save these files ?", "Important Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (rbContainer.Text != null)
            {
                if (dr == DialogResult.Yes) saveFile(rbContainer);
                else if (dr == DialogResult.No) Application.Exit();
                else if (dr == DialogResult.Cancel) return;
            }
        }

    }
}
