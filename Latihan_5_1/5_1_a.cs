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
    public partial class Form_5_1_a : Form
    {
        Form_5_1 main = (Form_5_1)Form_5_1.ActiveForm;
        public Form_5_1_a()
        {
            InitializeComponent();
        }
        
        private void _5_1_a_Load(object sender, EventArgs e)
        {
            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                {
                    cbBColor.Items.Add(prop.Name);
                }
            }
        }
        
        private void Form_5_1_a_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            main.showMain();
        }
        private void setEditor(RichTextBox rb, int type,string vcolor) 
        {
            try
            {
                switch (type)
                {
                    case 1:
                        main.VrbContainer.BackColor = Color.FromName(vcolor);
                        break;
                }
            }
            catch
            {
                return;
            }
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            setEditor(main.VrbContainer, 1, cbBColor.Text);
            this.Dispose();
            main.showMain();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            main.showMain();
        }

    }
}
