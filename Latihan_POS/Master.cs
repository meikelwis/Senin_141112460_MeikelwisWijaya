using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Latihan_POS
{
    class Master
    {
        public string Kode { get; set; }
        public string Nama { get; set; }
        public DateTime CreatedDt { get; set; }
        public DateTime UpdatedDt { get; set; }
        public Master(string kode, string nama, DateTime createdDt, DateTime updatedDt)
        {
            Kode = kode;
            Nama = nama;
            CreatedDt = createdDt;
            UpdatedDt = updatedDt;
        }
    }

    //class untuk barang
    class Barang : Master
    {
        MySqlConnection conDb = DBConnection.GetDBConnection();
        MySqlDataAdapter daBarang = new MySqlDataAdapter();
        public int JlhAwal { get; set; }
        public double HargaHpp { get; set; }
        public double HargaJual { get; set; }

        public Barang(string kode, string nama, int jlhAwal, double hargaHpp, double hargaJual, DateTime createdDt, DateTime updatedDt)
            : base(kode, nama, createdDt, updatedDt)
        {
            JlhAwal = jlhAwal;
            HargaHpp = hargaHpp;
            HargaJual = hargaJual;
        }
        
        private void InitializeData()
        {
            daBarang.SelectCommand = new MySqlCommand("SELECT KODE,NAMA,JUMLAH_AWAL,HARGA_HPP,HARGA_JUAL FROM POS.MSTBARANG;", conDb);

            daBarang.UpdateCommand = new MySqlCommand("UPDATE POS.MSTBARANG SET KODE = @KODE, NAMA = @NAMA, JUMLAH_AWAL = @JUMLAH_AWAL, HARGA_HPP = @HARGA_HPP,HARGA_JUAL = @HARGA_JUAL,UPDATED_DT = @UPDATED_DT WHERE KODE = @KODE", conDb);

            daBarang.InsertCommand = new MySqlCommand("INSERT INTO POS.MSTBARANG (KODE,NAMA,JUMLAH_AWAL,HARGA_HPP,HARGA_JUAL,CREATED_DT) VALUES (@KODE,@NAMA,@JUMLAH_AWAL,@HARGA_HPP,@HARGA_JUAL,@CREATED_DT);", conDb);

            daBarang.DeleteCommand = new MySqlCommand("DELETE FROM POS.MSTBARANG WHERE KODE = @KODE;", conDb);

            //UNTUK INSERT DATA
            daBarang.InsertCommand.Parameters.AddWithValue("@KODE", Kode);
            daBarang.InsertCommand.Parameters.AddWithValue("@NAMA", Nama);
            daBarang.InsertCommand.Parameters.AddWithValue("@JUMLAH_AWAL", JlhAwal);
            daBarang.InsertCommand.Parameters.AddWithValue("@HARGA_HPP", HargaHpp);
            daBarang.InsertCommand.Parameters.AddWithValue("@HARGA_JUAL", HargaJual);
            daBarang.InsertCommand.Parameters.AddWithValue("@CREATED_DT", CreatedDt);

            //UNTUK UPDATE DATA
            daBarang.UpdateCommand.Parameters.AddWithValue("@KODE", Kode);
            daBarang.UpdateCommand.Parameters.AddWithValue("@NAMA", Nama);
            daBarang.UpdateCommand.Parameters.AddWithValue("@JUMLAH_AWAL", JlhAwal);
            daBarang.UpdateCommand.Parameters.AddWithValue("@HARGA_HPP", HargaHpp);
            daBarang.UpdateCommand.Parameters.AddWithValue("@HARGA_JUAL", HargaJual);
            daBarang.UpdateCommand.Parameters.AddWithValue("@UPDATED_DT", UpdatedDt);

            //UNTUK DELETE DATA
            daBarang.DeleteCommand.Parameters.AddWithValue("@KODE", Kode);
        }
        public void ViewData()
        {
            conDb.Open();
            InitializeData();
            daBarang.SelectCommand.ExecuteReader();
            conDb.Close();
        }
        public void InsertData()
        {
            conDb.Open();
            InitializeData();
            daBarang.InsertCommand.ExecuteNonQuery();
            conDb.Close();
        }
        public void UpdateData()
        {
            conDb.Open();
            InitializeData();
            daBarang.UpdateCommand.ExecuteNonQuery();
            conDb.Close();
        }
        public void DeleteData()
        {
            conDb.Open();
            InitializeData();
            daBarang.DeleteCommand.ExecuteNonQuery();
            conDb.Close();
        }
    }

    //class untuk customer
    class Customer : Master
    {
        MySqlConnection conDb = DBConnection.GetDBConnection();
        MySqlDataAdapter daCustomer = new MySqlDataAdapter();

        public string Alamat { set; get; }
        public int Handphone { set; get; }
        public Customer(string kode, string nama, string alamat, int handphone,DateTime createdDt, DateTime updatedDt)
            : base(kode, nama, createdDt, updatedDt)
        {
            this.Alamat = alamat;
            this.Handphone = handphone;
        }
        private void InitializeData()
        {
            daCustomer.SelectCommand = new MySqlCommand("SELECT KODE,NAMA,ALAMAT,HANDPHONE FROM POS.MSTCUSTOMER;", conDb);

            daCustomer.UpdateCommand = new MySqlCommand("UPDATE POS.MSTCUSTOMER SET KODE = @KODE, NAMA = @NAMA, ALAMAT = @ALAMAT, HANDPHONE=@HANDPHONE,UPDATED_DT = @UPDATED_DT WHERE KODE = @KODE", conDb);

            daCustomer.InsertCommand = new MySqlCommand("INSERT INTO POS.MSTCUSTOMER (KODE,NAMA,ALAMAT,HANDPHONE,CREATED_DT) VALUES (@KODE,@NAMA,@ALAMAT,@HANDPHONE,@CREATED_DT);", conDb);

            daCustomer.DeleteCommand = new MySqlCommand("DELETE FROM POS.MSTCUSTOMER WHERE KODE = @KODE;", conDb);

            //UNTUK INSERT DATA
            daCustomer.InsertCommand.Parameters.AddWithValue("@KODE", Kode);
            daCustomer.InsertCommand.Parameters.AddWithValue("@NAMA", Nama);
            daCustomer.InsertCommand.Parameters.AddWithValue("@ALAMAT", Alamat);
            daCustomer.InsertCommand.Parameters.AddWithValue("@HANDPHONE", Handphone);
            daCustomer.InsertCommand.Parameters.AddWithValue("@CREATED_DT", CreatedDt);

            //UNTUK UPDATE DATA
            daCustomer.UpdateCommand.Parameters.AddWithValue("@KODE", Kode);
            daCustomer.UpdateCommand.Parameters.AddWithValue("@NAMA", Nama);
            daCustomer.UpdateCommand.Parameters.AddWithValue("@ALAMAT", Alamat);
            daCustomer.UpdateCommand.Parameters.AddWithValue("@HANDPHONE", Handphone);
            daCustomer.UpdateCommand.Parameters.AddWithValue("@UPDATED_DT", UpdatedDt);

            //UNTUK DELETE DATA
            daCustomer.DeleteCommand.Parameters.AddWithValue("@KODE", Kode);
        }
        public void ViewData()
        {
            conDb.Open();
            InitializeData();
            daCustomer.SelectCommand.ExecuteReader();
            conDb.Close();
        }
        public void InsertData()
        {
            conDb.Open();
            InitializeData();
            daCustomer.InsertCommand.ExecuteNonQuery();
            conDb.Close();
        }
        public void UpdateData()
        {
            conDb.Open();
            InitializeData();
            daCustomer.UpdateCommand.ExecuteNonQuery();
            conDb.Close();
        }
        public void DeleteData()
        {
            conDb.Open();
            InitializeData();
            daCustomer.DeleteCommand.ExecuteNonQuery();
            conDb.Close();
        }

    }
}
