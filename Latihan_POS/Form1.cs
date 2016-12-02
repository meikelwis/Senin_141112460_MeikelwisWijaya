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
            
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string conString = "Server=wisz;Port=3306;Database=POS;Uid=meikelwis;password=''";
            MySqlConnection conDb = new MySqlConnection(conString);
            MySqlCommand cmdDb = conDb.CreateCommand();
            cmdDb.CommandText = "INSERT INTO POS.MSTBARANG (KODE,NAMA,JUMLAH_AWAL,HARGA_HPP,HARGA_JUAL,CREATED_DT,UPDATE_DT) VALUES (@KODE,@NAMA,@JUMLAH_AWAL,@HARGA_HPP,@HARGA_JUAL,@CREATED_DT,@UPDATE_DT);"; 
            cmdDb.Parameters.AddWithValue("@KODE", txtKode.Text);
            cmdDb.Parameters.AddWithValue("@NAMA", txtNama.Text);
            cmdDb.Parameters.AddWithValue("@JUMLAH_AWAL", Convert.ToInt32(txtJmlh_Awal.Text));
            cmdDb.Parameters.AddWithValue("@HARGA_HPP", Convert.ToDecimal(txtHarga_HPP.Text));
            cmdDb.Parameters.AddWithValue("@HARGA_JUAL", Convert.ToDecimal(txtHarga_Jual.Text));
            cmdDb.Parameters.AddWithValue("@CREATED_DT", dt);
            cmdDb.Parameters.AddWithValue("@UPDATE_DT", dt);
            try
            {
                conDb.Open();
                cmdDb.ExecuteNonQuery();
                conDb.Close();
                MessageBox.Show("Saved");
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
            txtKode.Text = "";
            txtNama.Text = "";
            txtJmlh_Awal.Text = "";
            txtHarga_HPP.Text = "";
            txtHarga_Jual.Text = "";
            txtKode.Focus();
        }

        



        
        
        
    }
}
