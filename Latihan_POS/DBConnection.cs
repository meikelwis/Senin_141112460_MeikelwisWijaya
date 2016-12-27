using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Latihan_POS
{
    class DBConnection
    {
        public static MySqlConnection GetDBConnection()
        {
            string server = "wisz";
            int port = 3306;
            string database = "POS";
            string uid = "meikelwis";
            string password = "";
            String connString = "Server=" + server + ";Database=" + database + ";port=" + port + ";User Id=" + uid + ";password=" + password + ";";
            MySqlConnection conDb = new MySqlConnection(connString);
            return conDb;
        }
        public bool CheckConnection()
        {
            MySqlConnection conDb = DBConnection.GetDBConnection();
            try
            {
                conDb.Open();
            }
            catch (MySqlException)
            {
                return false;
            }
            return true;
        }
        public void ViewDataSet(string sQuery,string vTable,DataSet ds)
        {
            if (CheckConnection() == true)
            {
                if (vTable == "MSTBARANG")
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(sQuery, DBConnection.GetDBConnection());
                    da.Fill(ds, "MSTBARANG");
                }
                if (vTable == "MSTCUSTOMER")
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(sQuery, DBConnection.GetDBConnection());
                    da.Fill(ds, "MSTCUSTOMER");
                }
                if (vTable == "MSTSUPPLIER")
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(sQuery, DBConnection.GetDBConnection());
                    da.Fill(ds, "MSTSUPPLIER");
                }
            }
        }
    }
}
