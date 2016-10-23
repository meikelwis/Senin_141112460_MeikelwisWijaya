using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_3_1
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
            for(int i=8; i<101; i++)
            {
                cbFontSize.Items.Add(i.ToString());
            }
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                cbFont.Items.Add(font.Name);
            }
            foreach(System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if(prop.PropertyType.FullName == "System.Drawing.Color")
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
            //kalau gak terset semua Meikelwis 10/23/2016 
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

    }
}
