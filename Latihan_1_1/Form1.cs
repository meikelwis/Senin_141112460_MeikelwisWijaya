using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_no_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vSBMin.Minimum = 1;
            vSBMin.Maximum = 20;
            vSBMax.Minimum = 1;
            vSBMax.Maximum = 20;
        }

        private void vSBMin_Scroll(object sender, ScrollEventArgs e)
        {
            DateTime yearmin = new DateTime(DateTime.Today.Year - vSBMin.Value, DateTime.Today.Month, DateTime.Today.Day);
            lblRMin.Text = yearmin.ToString();
            monthCalendar.MaxDate = yearmin;
        }
        private void vSBMax_Scroll(object sender, ScrollEventArgs e)
        {
            DateTime yearmax = new DateTime(DateTime.Today.Year + vSBMax.Value, DateTime.Today.Month, DateTime.Today.Day);
            lblRMax.Text = yearmax.ToString();
            monthCalendar.MaxDate = yearmax;
        }
        
    }
}
