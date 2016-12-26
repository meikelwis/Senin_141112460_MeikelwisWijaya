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
        //Created By Meikelwis 
        //declare Variable
        DateTime dt = DateTime.Now;
        DateTime ut = DateTime.Now;
        bool isUpdate = false;
        bool isDelete = false;
        bool isInsert = true;
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
            //Initialisasi data barang
            //-------------------------------------------------------------------------
            DataSet dsBarang = new DataSet();
            db.ViewDataSet("SELECT KODE,NAMA,JUMLAH_AWAL,HARGA_HPP,HARGA_JUAL FROM MSTBARANG", "MSTBARANG", dsBarang);
            
            DataTable dtBarang = new DataTable();
            BindingSource bsBarang = new BindingSource();
            bsBarang.DataSource = dtBarang;
            dgvBarang.DataSource = bsBarang;
            dgvBarang.ReadOnly = true;
            dgvBarang.MultiSelect = false;
            dgvBarang.AllowUserToAddRows = false;
            dgvBarang.AllowUserToDeleteRows = false;
            dgvBarang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBarang.DataSource = dsBarang.Tables["MSTBARANG"];
            //Tuk ganti judul header kolom
            dgvBarang.Columns[0].HeaderText = "Kode Barang";
            dgvBarang.Columns[1].HeaderText = "Nama Barang";
            dgvBarang.Columns[2].HeaderText = "Jumlah Awal";
            dgvBarang.Columns[3].HeaderText = "Harga HPP";
            dgvBarang.Columns[4].HeaderText = "Harga Jual";
            //-------------------------------------------------------------------------
            //Initialisasi data Customer
            DataSet dsCustomer = new DataSet();
            db.ViewDataSet("SELECT KODE,NAMA,ALAMAT,HANDPHONE FROM MSTCUSTOMER", "MSTCUSTOMER", dsCustomer);

            DataTable dtCustomer = new DataTable();
            BindingSource bsCustomer = new BindingSource();
            bsCustomer.DataSource = dtCustomer;
            dgvCustomer.DataSource = bsCustomer;
            dgvCustomer.ReadOnly = true;
            dgvCustomer.MultiSelect = false;
            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.AllowUserToDeleteRows = false;
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomer.DataSource = dsCustomer.Tables["MSTCUSTOMER"];
            //Tuk ganti judul header kolom
            dgvCustomer.Columns[0].HeaderText = "Kode Customer";
            dgvCustomer.Columns[1].HeaderText = "Nama Customer";
            dgvCustomer.Columns[2].HeaderText = "Alamat Customer";
            dgvCustomer.Columns[3].HeaderText = "Handphone";

        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            isInsert = true;
            isUpdate = false;
            isDelete = false;
            ClearData();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            ProcessData();
            ClearData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            isDelete = true;
            isInsert = false;
            isUpdate = false;
            ProcessData();
            ClearData();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearData()
        {
            //Hapus Data untukBarang
            //--------------------------------------------
            if (mtbRegis.SelectedTab == mtbRegis.TabPages["tbBarang"])
            {
                BarangKode.Clear();
                BarangNama.Clear();
                BarangJmlhAwal.Clear();
                BarangHargaHPP.Clear();
                BarangHargaJual.Clear();
                BarangKode.Enabled = true;
                BarangNama.Focus();
            }
            //Hapus Data untukCustomer
            //--------------------------------------------
            if (mtbRegis.SelectedTab == mtbRegis.TabPages["tbCustomer"])
            {
                CustomerKode.Clear();
                CustomerNama.Clear();
                CustomerAlamat.Clear();
                CustomerHp.Clear();
                CustomerKode.Enabled = true;
                CustomerNama.Focus();
            }
        }
        private void dgvBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //untukBarang
            BarangKode.Text = dgvBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
            BarangNama.Text = dgvBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
            BarangJmlhAwal.Text = dgvBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
            BarangHargaHPP.Text = dgvBarang.Rows[e.RowIndex].Cells[3].Value.ToString();
            BarangHargaJual.Text = dgvBarang.Rows[e.RowIndex].Cells[4].Value.ToString();
            BarangKode.Enabled = false;
            isUpdate = true;
            isInsert = false;
            isDelete = false;
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //untukCustomer
            CustomerKode.Text = dgvCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
            CustomerNama.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            CustomerAlamat.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
            CustomerHp.Text = dgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
            CustomerKode.Enabled = false;
            isUpdate = true;
            isInsert = false;
            isDelete = false;
        }
        //Method Untuk Cek Validasi
        private bool isValid()
        {
            if (mtbRegis.SelectedTab == mtbRegis.TabPages["tbBarang"])
            {
                if (BarangKode.Text == "")
                    return false;
                else if (BarangNama.Text == "")
                    return false;
                else if (BarangJmlhAwal.Text == "")
                    return false;
                else if (BarangHargaHPP.Text == "")
                    return false;
                else if (BarangHargaJual.Text == "")
                    return false;
            }
            if (mtbRegis.SelectedTab == mtbRegis.TabPages["tbCustomer"])
            {
                if (CustomerKode.Text == "")
                    return false;
                else if (CustomerNama.Text == "")
                    return false;
                else if (CustomerAlamat.Text == "")
                    return false;
                else if (CustomerHp.Text == "")
                    return false;
            }
            return true;
        }
        //Method untuk simpan Data
        private void ProcessData()
        {
            if (isValid() == false) MessageBox.Show("Please Check Your Data and Choose Data if you want to edit or delete data");
            if (isValid() == true)
            {
                if (MessageBox.Show("Are You want to save to save these transactions?",
                "Questions", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //untuk validasi barang
                    if (mtbRegis.SelectedTab == mtbRegis.TabPages["tbBarang"])
                    {
                        Barang mstBarang = new Barang(BarangKode.Text, BarangNama.Text, int.Parse(BarangJmlhAwal.Text), double.Parse(BarangHargaJual.Text), double.Parse(BarangHargaJual.Text), dt, dt);
                        string msg;
                        try
                        {
                            if (isInsert == true)
                            {
                                mstBarang.InsertData();
                                msg = "Record have been saved";
                                MessageBox.Show(msg, "Information");
                            }
                            if (isUpdate == true)
                            {
                                mstBarang.UpdateData();
                                msg = "Record have been updated";
                                MessageBox.Show(msg, "Information");
                            }
                            if (isDelete == true)
                            {
                                mstBarang.DeleteData();
                                msg = "Record have been deleted";
                                MessageBox.Show(msg, "Information");
                            }
                            InitializeData();
                            return;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    //untuk validasi customer
                    if (mtbRegis.SelectedTab == mtbRegis.TabPages["tbCustomer"])
                    {
                        Customer mstCustomer = new Customer(CustomerKode.Text, CustomerNama.Text, CustomerAlamat.Text, int.Parse(CustomerHp.Text), dt, dt);
                        string msg;
                        try
                        {
                            if (isInsert == true)
                            {
                                mstCustomer.InsertData();
                                msg = "Record have been saved";
                                MessageBox.Show(msg, "Information");
                            }
                            if (isUpdate == true)
                            {
                                mstCustomer.UpdateData();
                                msg = "Record have been updated";
                                MessageBox.Show(msg, "Information");
                            }
                            if (isDelete == true)
                            {
                                mstCustomer.DeleteData();
                                msg = "Record have been deleted";
                                MessageBox.Show(msg, "Information");
                            }
                            InitializeData();
                            return;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }


    }

}
