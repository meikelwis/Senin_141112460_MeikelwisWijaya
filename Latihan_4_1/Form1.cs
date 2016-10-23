using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_4_1
{
    public partial class Form1 : Form
    {

        Font vfont = new Font("Times New Rowman", 12, FontStyle.Regular);
        string family = "";
        int size = 0;
        FontStyle fs = FontStyle.Regular;

        public Form1()
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
                }
            }
            cbFont.SelectedIndex = 0;
            cbFontSize.SelectedItem = 0;
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

    }
}
