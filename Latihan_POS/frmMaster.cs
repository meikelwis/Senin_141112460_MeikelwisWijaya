using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Latihan_POS
{
    
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
            InitializeData();
        }
        private void InitializeData()
        {
            DBConnection db = new DBConnection();
            if (db.CheckConnection() == false)
            {//meikelwis untuk cek ad koneksi atau gak
                MessageBox.Show("Please Check Your Connection", "Information");
                return;
            }
            //meikelwis untuk cek ad koneksi atau gak
            DataSet dsBarang = new DataSet();
            string vTable = "MSTBARANG";
            db.ViewDataSet("SELECT KODE,NAMA,JUMLAH_AWAL,HARGA_HPP,HARGA_JUAL FROM MSTBARANG", vTable, dsBarang);
            dgvBarang.ReadOnly = true;
            dgvBarang.MultiSelect = false;
            dgvBarang.AllowUserToAddRows = false;
            dgvBarang.AllowUserToDeleteRows = false;
            dgvBarang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBarang.DataSource = dsBarang.Tables[vTable];

        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            Barang mstBarang; 
            mstBarang = new Barang(txtKode.Text, txtNama.Text, int.Parse(txtJmlh_Awal.Text), double.Parse(txtHarga_Jual.Text), double.Parse(txtHarga_Jual.Text), dt, dt);
            try
            {
                mstBarang.InsertData();
                string msg = "Record have been saved";
                MessageBox.Show(msg, "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            txtKode.Clear();
            txtNama.Clear();
            txtJmlh_Awal.Clear();
            txtHarga_HPP.Clear();
            txtHarga_Jual.Clear();
            txtKode.Focus();
        }
    }

}
