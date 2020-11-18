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
    public partial class Order
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        string pesan;
        bool status;
        DB_Connect _db = new DB_Connect();
        public Order()
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

        public void data_bindings(ref DataGridView dgv, DateTime date, string status, string show, ref Label label)
        {
            ds = new DataSet();
            if (show == "all")
            {
                da = new SqlDataAdapter($"Select * From Order_Master", conn);
            }
            else
            {
                da = new SqlDataAdapter($"Select * From Order_Master where Tanggal = '{date.Date}' and Status_Order = '{status}'", conn);
            }

            da.Fill(ds, "Order_Master");
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DataSource = ds.Tables["Order_Master"];

            label.Text = $"Total Order = {(dgv.RowCount - 1).ToString("0")}";
        }
        public void add_order(DateTime date, long harga, string status)
        {
            string sql = $"Insert Into Order_Master Values ('{date.Date}', '{harga}', '{status}')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            string psn = String.Concat(cmd.ExecuteNonQuery(), "Inserted");
        }

        public void edit_order(int id, DateTime date, long harga, string status)
        {
            string sql = $"Update Order_Master Set Tanggal = '{date.Date}',Total_Harga = '{harga}', Status_Order = '{status}' Where ID_Order = '{id}'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            string psn = String.Concat(cmd.ExecuteNonQuery(), "Updated");
        }

        public void change_status_order(int id)
        {
            string sql = $"Update Order_Master Set Status_Order = 'Tercetak' Where ID_Order = '{id}'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            string psn = String.Concat(cmd.ExecuteNonQuery(), "Status Updated");
        }

        public void delete_order(int id)
        {
            string sql = $"Delete From Order_Master Where ID_Order = '{id}'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            string psn = String.Concat(cmd.ExecuteNonQuery(), "Master Deleted");

            sql = $"Delete From Order_Detail Where ID_Order = '{id}'";
            cmd = new SqlCommand(sql, conn);
            psn = String.Concat(cmd.ExecuteNonQuery(), "Detail Deleted");
        }
    }
}
