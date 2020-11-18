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
    public partial class EditUser
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        string pesan;
        bool status;
        DB_Connect _db = new DB_Connect();
        public EditUser()
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
                da = new SqlDataAdapter($"Select * From Users", conn);
            }
            else
            {
                da = new SqlDataAdapter($"Select * From Users where Nama_User like '{text}%'", conn);
            }

            da.Fill(ds, "Users");
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DataSource = ds.Tables["Users"];

            label.Text = $"Total User = {dgv.RowCount - 1}";
        }
        public void add_user(string username, string password)
        {
            string sql = $"Insert Into Users Values ('{username}', '{password}')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            string psn = String.Concat(cmd.ExecuteNonQuery(), "Inserted");
        }

        public void edit_user(int id, string new_username, string new_password)
        {
            string sql = $"Update Users Set Nama_User = '{new_username}', Password_User = '{new_password}' Where ID_User = '{id}'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            string psn = String.Concat(cmd.ExecuteNonQuery(), "Updated");
        }

        public void delete_user(int id)
        {
            string sql = $"Delete From Users Where ID_User = '{id}'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            string psn = String.Concat(cmd.ExecuteNonQuery(), "Deleted");
        }

        public bool cek_user(string username)
        {
            bool cek = false;
            string sql = $"Select COUNT(*) From Users where Nama_User = '{username}'";
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
