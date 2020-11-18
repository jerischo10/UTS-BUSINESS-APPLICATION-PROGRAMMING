using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Db;

namespace POS_Restoran
{
    public partial class UserLogin
    {
        SqlConnection conn;
        string pesan;
        DB_Connect _db = new DB_Connect();
        public UserLogin()
        {
            try
            {
                conn = new SqlConnection(_db.db_connect());
                conn.Open();

                pesan = String.Concat("Koneksi ke = ", conn.DataSource, "\n");
                pesan = String.Concat(pesan, "Database = ", conn.Database, "\n");
                pesan = String.Concat(pesan, "WorkStationID = ", conn.WorkstationId, "\n");
                pesan = String.Concat(pesan, "Connection String = ", conn.ConnectionString);
            }
            catch (SqlException ex)
            {
                pesan = String.Concat("Error ", ex.ErrorCode, " : ");
                pesan = String.Concat(pesan, ex.Message);
            }
        }
        public string getpesan()
        {
            return pesan;
        }
        public bool getstatus(string u, string p)
        {
            bool cek = false;
            string sql = $"Select COUNT(*) From Users where Nama_User = '{u}' and Password_User = '{p}'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            if ((int)cmd.ExecuteScalar() == 0)
            {
                return cek = false;
            }
            else
            {
                return cek = true;
            }
        }
    }
}
