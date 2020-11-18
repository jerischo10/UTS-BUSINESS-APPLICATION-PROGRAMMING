using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Db;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using System.Data;

namespace POS_Restoran
{
    class Menu
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        string pesan;
        bool status;
        DB_Connect _db = new DB_Connect();
        public Menu()
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

        public void data_bindings(ref DataGridView dgv, string text, ref Label label)
        {
            string key;
            ds = new DataSet();
            if (text == "")
            {
                da = new SqlDataAdapter($"Select * From Menu", conn);
            }
            else
            {
                da = new SqlDataAdapter($"Select * From Menu where Nama_Menu like '%{text}%'", conn);
            }

            da.Fill(ds, "Menu");
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DataSource = ds.Tables["Menu"];

            label.Text = $"Total Menu = {(dgv.RowCount - 1).ToString("0")}";
        }
        public void data_bindings_for_order(ref DataGridView dgv, string text, ref Label label)
        {
            string key;
            ds = new DataSet();
            if (text == "getall")
            {
                da = new SqlDataAdapter($"Select * From Menu", conn);
            }
            else
            {
                da = new SqlDataAdapter($"Select * From Menu where Nama_Menu like '%{text}%'", conn);
            }

            da.Fill(ds, "Menu");
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DataSource = ds.Tables["Menu"];

            label.Text = $"Total Menu = {(dgv.RowCount - 1).ToString("0")}";
        }
        public void add_menu(string nama, long harga, string tipe)
        {
            string sql = $"Insert Into Menu Values ('{nama}', '{harga}', '{tipe}')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            string psn = String.Concat(cmd.ExecuteNonQuery(), "Inserted");
        }

        public void edit_menu(int id, string nama, long harga, string tipe)
        {
            string sql = $"Update Menu Set Nama_Menu = '{nama}', Harga_Menu = '{harga}', Tipe_Menu = '{tipe}' Where ID_Menu = '{id}'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            string psn = String.Concat(cmd.ExecuteNonQuery(), "Updated");
        }

        public void delete_menu(int id)
        {
            string sql = $"Delete From Menu Where ID_Menu = '{id}'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            string psn = String.Concat(cmd.ExecuteNonQuery(), "Deleted");
        }

        public bool cek_menu(string nama)
        {
            bool cek = false;
            string sql = $"Select COUNT(*) From Menu where Nama_Menu = '{nama}'";
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
        public string get_menu_name(int id)
        {
            string name = "";
            string sql = $"Select * From Menu Where ID_Menu = '{id}'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            using (SqlDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    name = read["Nama_Menu"].ToString();
                }
            }
            return name;
        }
    }
}
