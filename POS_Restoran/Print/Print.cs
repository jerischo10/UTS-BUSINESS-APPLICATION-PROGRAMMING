using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Db;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace POS_Restoran
{
    class PrintModel
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        string pesan;
        bool status;
        DB_Connect _db = new DB_Connect();
        public PrintModel()
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

        public void data_bindings(ref ListView lv, int id_order, ref Label labelorder, ref Label labeltanggal)
        {
            string nama = "", tipe = "", id_menu, qty;
            long harga = 0;
            DateTime tanggal = DateTime.Now;
            long total = 0;
            string sql = $"Select * From Order_Detail Where ID_Order = '{id_order}'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            using (SqlDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    int id = (Convert.ToInt32(read["ID_Menu"]));
                    string sql_menu = $"Select * From Menu Where ID_Menu = '{id}'";
                    SqlCommand cmd_menu = new SqlCommand(sql_menu, conn);
                    cmd_menu.ExecuteNonQuery();
                    using (SqlDataReader read_menu = cmd_menu.ExecuteReader())
                    {
                        while (read_menu.Read())
                        {
                            id_menu = read_menu["ID_Menu"].ToString();
                            nama = read_menu["Nama_Menu"].ToString();
                            harga = Convert.ToInt64(read_menu["Harga_Menu"]);
                            tipe = read_menu["Tipe_Menu"].ToString();
                        }
                    }
                    qty = read["Quantity"].ToString();
                    string[] row = { id.ToString(), $"{qty}x", nama, "@", harga.ToString() };
                    ListViewItem lvi = new ListViewItem(row);
                    lv.Items.Add(lvi);
                }
            }
            string sql_order = $"Select * From Order_Master Where ID_Order = '{id_order}'";
            SqlCommand cmd_order = new SqlCommand(sql_order, conn);
            cmd_order.ExecuteNonQuery();
            using (SqlDataReader read_order = cmd_order.ExecuteReader())
            {
                while (read_order.Read())
                {
                    total = Convert.ToInt64(read_order["Total_Harga"]);
                    tanggal = Convert.ToDateTime(read_order["Tanggal"]);
                }
            }
            labelorder.Text = $"Order : {id_order}";
            string[] sec_last_row = { "", "", "", "", "" };
            ListViewItem last_lvi = new ListViewItem(sec_last_row);
            lv.Items.Add(last_lvi);

            string[] last_row = { "", "", "Total :", "Rp.", $"{Convert.ToInt64(total).ToString("0.###.###")}" };
            last_lvi = new ListViewItem(last_row);
            lv.Items.Add(last_lvi);

            labeltanggal.Text = $"Tanggal : {tanggal.ToString("dd/M/yyyy")}";
        }
    }
}
