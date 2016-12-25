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

            daBarang.UpdateCommand = new MySqlCommand("UPDATE POS.MSTBARANG SET KODE = @KODE, NAMA = @NAMA, JUMLAH_AWAL = @JUMLAH_AWAL, HARGA_HPP = @HARGA_HPP,HARGA_JUAL = @HARGA_JUAL,UPDATE_DT = @UPDATE_DT", conDb);

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
            daBarang.UpdateCommand.Parameters.AddWithValue("@UPDATE_DT", UpdatedDt);

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
        
    }
}
