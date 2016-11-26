using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volleyball_problem
{
    public partial class Form1 : Form
    {
        public int a, b;
        public const int mods = 1000000007;
        public Form1()
        {
            InitializeComponent();
        }

        private int Hitung(int a,int b)
        {

            a = Convert.ToInt32(Txt1.Text);
            b = Convert.ToInt32(Txt2.Text);
            int result;
            if (a < b) Tukar(ref a, ref b);
            if (!cekValid(a, b)) result = 0;
            else
            {
                if (a > 25)
                {
                    result = kombinasi(24, 24, mods);
                    result = (int)((((long)result) * pow(2, b - 24, mods)) % mods);
                }
                else result = kombinasi(a - 1, b, mods);
            }
            return result;
        }
        private void BtnHitung_Click(object sender, EventArgs e)
        {
            TxtHasil.Text = Hitung(a, b).ToString();
        }

            static bool cekValid(int a, int b)
            {
                if (a < 25) return false;
                if (a == 25) return b <= 23;
                return b == (a - 2);
            }
            public static void Tukar<T>(ref T left, ref T right)
            {
                T temp;
                temp = left;
                left = right;
                right = temp;
            }
        public static int kombinasi(int n, int r, int mod)
        {
            if (n < r) Tukar(ref n, ref r);
            if (n < 1 || r < 1) return 1;
            var baris = new int[r];
            for (var i = 0; i < r; baris[i++] = 1) { }
            for (int i = 2; i < r; ++i)
            {
                for (int j = i - 1; j > 0; --j)
                {
                    baris[j] = (baris[j] + baris[j - 1]) % mod;
                }
            }
            --r;
            int jumlah = baris[r];
            for (int i = 0; i < n; ++i)
            {
                for (int j = r; j > 0; --j)
                {
                    baris[j] = (baris[j] + baris[j - 1]) % mod;
                }
                jumlah = (jumlah + baris[r]) % mod;
            }
            return jumlah;
        }
        private static int pow(int baseNo, int exponent, int mod)
        {
            if (exponent < 2)
            {
                return (exponent < 1) ? 1 : baseNo;
            }
            long product = pow(baseNo, exponent >> 1, mod);
            product = (product * product) % mod;
            return ((exponent % 1) == 1) ? (int)((product * baseNo) % mod) : (int)(product);
        }
        
    }
}
