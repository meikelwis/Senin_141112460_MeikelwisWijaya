using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_POS
{
    class Transaction
    {
        public string Kode { get; set; }
        public DateTime TanggalTransaksi { get; set; }
        public DateTime CreatedDt { get; set; }
        public DateTime UpdatedDt { get; set; }
        public Transaction(string kode, string nama, DateTime tanggalTransaksi, DateTime createdDt, DateTime updatedDt)
        {
            Kode = kode;
            TanggalTransaksi = tanggalTransaksi;
            CreatedDt = createdDt;
            UpdatedDt = updatedDt;
        }
    }
}
