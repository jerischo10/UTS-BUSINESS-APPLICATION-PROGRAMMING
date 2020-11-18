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
    public partial class OrderRecordView : Form
    {
        Order _order;
        OrderDetail _detail;
        AddMenuToOrderView _show;
        TempOrder _temp;
        Menu _menu;
        
        bool status;
        string stat;
        string stat_tempOrder = "new";
        public int id_order { get; set; }
        public int id_menu { get; set; }
        public int qty { get; set; }
        public DateTime date { get; set; }
        public string status_order { get; set; }
        public string nama_user { get; set; }
        public OrderRecordView(string stat, string username, int id_order)
        {
            InitializeComponent();
            dateTimePickerTanggal.Enabled = false;
            this.status = true;
            this.stat = stat;
            nama_user = username;
            this.id_order = id_order;
            _order = new Order();
            _detail = new OrderDetail();
            _temp = new TempOrder();
            _menu = new Menu();
            Init_List_View();
            Init_DataBinding_Order();
        }
        private void Init_List_View()
        {
            listViewOrder.Columns.Add("ID_Menu", 45, HorizontalAlignment.Left);
            listViewOrder.Columns.Add("Nama");
            listViewOrder.Columns.Add("Harga");
            listViewOrder.Columns.Add("Tipe");
            listViewOrder.Columns.Add("Qty");
            listViewOrder.View = View.Details;
        }

        private void Init_DataBinding_Order()
        {
            listViewOrder.Items.Clear();
            if (stat == "edit" && status == true)
                _detail.data_bindings(ref listViewOrder, id_order);
            else
                _temp.data_bindings(ref listViewOrder, nama_user);
            this.listViewOrder.Columns[0].Width = 0;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (_temp.total_data(nama_user) > 0)
            {
                var confirmResult = MessageBox.Show($"You have an unsaved changes, Are you sure?",
                                     "Saving Confirmation",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    if (stat == "edit")
                    {
                        _temp.delete_temp(nama_user);
                    }
                    this.Close();
                }
            }
            this.Close();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            this.status = false;
            //if (stat == "new")
            var confirmResult = MessageBox.Show($"{_menu.get_menu_name(Convert.ToInt32(listViewOrder.SelectedItems[0].SubItems[0].Text))} Will be Deleted!",
                                     "Deletion Confirmation",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _temp.delete_menu(Convert.ToInt32(listViewOrder.SelectedItems[0].SubItems[0].Text));
            }
            Init_DataBinding_Order();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.status = false;
            _show = new AddMenuToOrderView("new");
            _show.nama_user = nama_user;
            _show.id_order = id_order;
            _show.ShowDialog();
            Init_DataBinding_Order();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            status = false;
            _show = new AddMenuToOrderView("edit");
            _show.id_order = id_order;
            _show.id_menu = Convert.ToInt32(listViewOrder.SelectedItems[0].SubItems[0].Text);
            _show.qty = Convert.ToInt32(listViewOrder.SelectedItems[0].SubItems[4].Text);
            _show.nama_user = nama_user;
            _show.ShowDialog();
            Init_DataBinding_Order();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            long total_harga = _temp.total_harga(nama_user);
            if (stat == "new")
            {
                _order.add_order(DateTime.Parse(dateTimePickerTanggal.Value.ToString()), total_harga, "Belum Tercetak");
                //_detail.add_order();
                _temp.migrate_to_order_detail(nama_user);
                MessageBox.Show("Order Saved");
            }
            else if (stat == "edit")
            {
                _order.edit_order(id_order, DateTime.Parse(dateTimePickerTanggal.Value.ToString()), total_harga, status_order);
                _detail.delete_detail(id_order);
                _temp.migrate_to_existing_order_detail(id_order, nama_user);
                MessageBox.Show("Order Saved");
            }
        }
    }
}
