using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_2
{
    public partial class Form1 : Form
    {
        DateTime dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            int vmonth = Convert.ToInt32(dupBulan.SelectedIndex) + 1;
            int vdate = Convert.ToInt32(nupTanggal.Value);
            if ( vmonth == 2 )
            {
                if (vdate >= 28)
                {
                    MessageBox.Show("Invalid Date");
                    return;
                }
            }
            dt = new DateTime(DateTime.Now.Year, vmonth, vdate);
            monthCalender.AddAnnuallyBoldedDate(dt);
            monthCalender.UpdateBoldedDates();
            monthCalender.SetDate(dt);
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            dt = new DateTime(DateTime.Now.Year, Convert.ToInt32(dupBulan.SelectedIndex) + 1, Convert.ToInt32(nupTanggal.Value));
            monthCalender.RemoveAnnuallyBoldedDate(dt);
            monthCalender.UpdateBoldedDates();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            dupBulan.SelectedIndex = 0;
            dt = new DateTime(DateTime.Now.Year, 1, 8);
            DateTime sm = new DateTime(2016, 1, 1);
            while (sm.Year == 2016)
            {
                if (sm.DayOfWeek == DayOfWeek.Saturday || sm.DayOfWeek == DayOfWeek.Sunday)
                {
                    monthCalender.AddBoldedDate(sm);
                }
                sm = sm.AddDays(1);
            }

            monthCalender.AddAnnuallyBoldedDate(dt);
            monthCalender.UpdateBoldedDates();
        }
        
    }
}
