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
    class OrderDetail
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        string pesan;
        bool status;
        DB_Connect _db = new DB_Connect();
        public OrderDetail()
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
        public void data_bindings(ref ListView lv, int id_order)
        {
            string nama = "", tipe = "", harga = "", id_menu, qty;
            string sql = $"Select * From Order_Detail Where ID_Order = '{id_order}'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            if (total_data() > 0)
            {
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
                                harga = read_menu["Harga_Menu"].ToString();
                                tipe = read_menu["Tipe_Menu"].ToString();
                            }

                        }
                        qty = read["Quantity"].ToString();
                        string[] row = { id.ToString(), nama, harga, tipe, qty };
                        ListViewItem lvi = new ListViewItem(row);
                        lv.Items.Add(lvi);
                    }
                }
            }
        }
        
        public void clone_to_temp(int id_order, string user)
        {
            int id_menu, qty;
            string query = $"Select * From Order_Detail where ID_Order = '{id_order}'";
            SqlCommand command = new SqlCommand(query, conn);
            command.ExecuteNonQuery();
            using (SqlDataReader read_order = command.ExecuteReader())
            {
                while (read_order.Read())
                {
                    id_menu = Convert.ToInt32(read_order["ID_Menu"]);
                    qty = Convert.ToInt32(read_order["Quantity"]);
                    string query_insert = $"Insert into tempOrder Values ('{id_menu}', '{qty}', '{user}')";
                    SqlCommand command2 = new SqlCommand(query_insert, conn);
                    string psn = String.Concat(command2.ExecuteNonQuery(), "Cloned");
                }
            }
        }
        public void delete_detail(int id_order)
        {
            string sql = $"Delete From Order_Detail where ID_Order = '{id_order}'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            string psn = String.Concat(cmd.ExecuteNonQuery(), "Deleted");
        }
        public void edit_menu(int id_order, int id_menu, int qty)
        {
            string sql = $"Update Order_Detail Set ID_Order = '{id_order}', ID_Menu = '{id_menu}', Quantity = '{qty}' Where ID_Order = '{id_order}'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            string psn = String.Concat(cmd.ExecuteNonQuery(), "Updated");
        }

        public void delete_menu(int id)
        {
            string sql = $"Delete From Order_Detail Where ID_Menu = '{id}'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            string psn = String.Concat(cmd.ExecuteNonQuery(), "Deleted");
        }
        public bool cek_menu(int id)
        {
            bool cek = false;
            string sql = $"Select COUNT(*) From Order_Detail where ID_Menu = '{id}'";
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
        public int total_data()
        {
            string sql = $"Select COUNT(*) From Order_Detail";
            SqlCommand cmd = new SqlCommand(sql, conn);
            return (int)cmd.ExecuteScalar();
        }
    }
}
