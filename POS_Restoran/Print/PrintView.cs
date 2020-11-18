using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Restoran
{
    public partial class Print : Form
    {
        int id_order;
        PrintModel _db;
        Order _order;
        public Print(int id, Order _order)
        {
            InitializeComponent();
            id_order = id;
            _db = new PrintModel();
            this._order = _order;
            Init_List_View();
            data_bindings();
        }
        private void Init_List_View()
        {
            listViewData.Columns.Add("ID_Menu", 45, HorizontalAlignment.Left);
            listViewData.Columns.Add("Qty", 30, HorizontalAlignment.Left);
            listViewData.Columns.Add("Nama", 140, HorizontalAlignment.Left);
            listViewData.Columns.Add("@", 30, HorizontalAlignment.Left);
            listViewData.Columns.Add("Harga", 60, HorizontalAlignment.Right);
            
            listViewData.View = View.Details;
        }
        public void data_bindings()
        {
            _db.data_bindings(ref listViewData, id_order, ref labelOrder, ref labelTanggal);
            this.listViewData.Columns[0].Width = 0;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Invoice will be Printed");
            _order.change_status_order(id_order);
        }
    }
}
