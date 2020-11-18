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
    public partial class TempOrder
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        string pesan;
        bool status;
        DB_Connect _db = new DB_Connect();
        public TempOrder()
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

        public void data_bindings(ref ListView lv, string user)
        {
            //ds = new DataSet();
            string nama = "", tipe = "", harga = "", id_menu, qty;
            string sql = $"Select * From tempOrder Where Nama_User = '{user}' or Nama_User = 'user'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            
            if (total_data(user) > 0)
            {
                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        int id = (Convert.ToInt32(read["ID_Menu"]));
                        string sql_menu = $"Select * From Menu where ID_Menu = '{id}'";
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
        public void add_menu(int id_menu, int qty, string user)
        {
            string sql = $"Insert Into tempOrder Values ('{id_menu}', '{qty}', '{user}')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            string psn = String.Concat(cmd.ExecuteNonQuery(), "Inserted");
        }

        public void delete_menu(int id)
        {
            string sql = $"Delete From tempOrder Where ID_Menu = '{id}'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            string psn = String.Concat(cmd.ExecuteNonQuery(), "Deleted");
        }

        public void delete_temp(string user)
        {
            string sql = $"Delete From tempOrder Where Nama_User = '{user}' or Nama_User = 'user'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            string psn = String.Concat(cmd.ExecuteNonQuery(), "Deleted");
        }

        public void delete_temp_fully()
        {
            string sql = $"Delete From tempOrder";
            SqlCommand cmd = new SqlCommand(sql, conn);
            string psn = String.Concat(cmd.ExecuteNonQuery(), "Deleted");
        }

        public void edit_menu(int id_menu, int qty, string user)
        {
            string sql = $"Update tempOrder Set ID_Menu = '{id_menu}', Quantity = '{qty}', Nama_User = '{user}' Where ID_Menu = '{id_menu}'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            string psn = String.Concat(cmd.ExecuteNonQuery(), "Updated");
        }

        public bool cek_menu(int id)
        {
            bool cek = false;
            string sql = $"Select COUNT(*) From tempOrder where ID_Menu = '{id}'";
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
        public long total_harga(string user)
        {
            long total = 0;
            string sql = $"Select * From tempOrder Where Nama_User = '{user}' or Nama_User = 'user'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            using (SqlDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    int id = (Convert.ToInt32(read["ID_Menu"]));
                    int qty = (Convert.ToInt32(read["Quantity"]));
                    string sql_menu = $"Select * From Menu where ID_Menu = '{id}'";
                    SqlCommand cmd_menu = new SqlCommand(sql_menu, conn);
                    cmd_menu.ExecuteNonQuery();
                    using (SqlDataReader read_menu = cmd_menu.ExecuteReader())
                    {
                        while (read_menu.Read())
                        {
                            total += (Convert.ToInt64(read_menu["Harga_Menu"]) * qty);
                        }
                    }
                }
            }
            return total;
        }
        public int total_data(string nama_user)
        {
            string sql = $"Select COUNT(*) From tempOrder Where Nama_User = '{nama_user}' or Nama_User = 'user'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            return (int)cmd.ExecuteScalar();
        }

        public void migrate_to_order_detail(string nama_user)
        {
            int id = 0;
            string sql = $"Select TOP 1 * From Order_Master ORDER BY ID_Order DESC";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            using (SqlDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    id = Convert.ToInt32(read["ID_Order"]);
                }
            }

            int id_menu, qty;
            string query = $"Select * From tempOrder where Nama_User = '{nama_user}' or Nama_User='user'";
            SqlCommand command = new SqlCommand(query, conn);
            command.ExecuteNonQuery();
            using (SqlDataReader read_order = command.ExecuteReader())
            {
                while (read_order.Read())
                {
                    id_menu = Convert.ToInt32(read_order["ID_Menu"]);
                    qty = Convert.ToInt32(read_order["Quantity"]);
                    string query_insert = $"Insert into Order_Detail Values ('{id}', '{id_menu}', '{qty}')";
                    SqlCommand command2 = new SqlCommand(query_insert, conn);
                    string psn = String.Concat(command2.ExecuteNonQuery(), "Inserted");
                }
            }
            delete_temp(nama_user);
        }
        public void migrate_to_existing_order_detail(int id, string nama_user)
        {
            int id_menu, qty;
            string query = $"Select * From tempOrder where Nama_User = '{nama_user}' or Nama_User = 'user'";
            SqlCommand command = new SqlCommand(query, conn);
            command.ExecuteNonQuery();
            using (SqlDataReader read_order = command.ExecuteReader())
            {
                while (read_order.Read())
                {
                    id_menu = Convert.ToInt32(read_order["ID_Menu"]);
                    qty = Convert.ToInt32(read_order["Quantity"]);
                    string query_insert = $"Insert into Order_Detail Values ('{id}', '{id_menu}', '{qty}')";
                    SqlCommand command2 = new SqlCommand(query_insert, conn);
                    string psn = String.Concat(command2.ExecuteNonQuery(), "Inserted");
                }
            }
            delete_temp(nama_user);
        }
    }
}
