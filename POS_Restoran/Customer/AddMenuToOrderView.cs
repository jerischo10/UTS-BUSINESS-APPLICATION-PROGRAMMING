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
    public partial class AddMenuToOrderView : Form
    {
        Menu _menu;
        TempOrder _temp;
        OrderDetail _detail;
        string stat;
        public string nama_user { get; set; }
        public int id_order { get; set; }
        public int id_menu { get; set; }
        public int qty { get; set; }
        public AddMenuToOrderView(string stat)
        {
            InitializeComponent();
            this.stat = stat;
            _menu = new Menu();
            _detail = new OrderDetail();
            _temp = new TempOrder();
            Init_DataBinding_Menu("");
        }

        private void Init_DataBinding_Menu(string txt)
        {
            _menu.data_bindings_for_order(ref dataGridViewMenu, txt, ref labelTotal);
            this.dataGridViewMenu.Columns["ID_Menu"].Visible = false;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Init_DataBinding_Menu(textBoxSearch.Text);
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked)
            {
                Init_DataBinding_Menu("getall");
            }
            else
            {
                Init_DataBinding_Menu(textBoxSearch.Text);
            }
        }

        private void dataGridViewMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_menu = Convert.ToInt32(dataGridViewMenu.SelectedRows[0].Cells[0].Value);
            labelMenu.Text = dataGridViewMenu.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (stat == "new")
            {
                _temp.add_menu(id_menu, qty, nama_user);
                if (_temp.cek_menu(id_menu))
                {
                    MessageBox.Show("Menu Added");
                }
                else
                {
                    MessageBox.Show("Menu Add Failed");
                }
            }
            else if (stat == "edit")
            {
                _temp.edit_menu(id_menu, qty, nama_user);
                if (_temp.cek_menu(id_menu))
                {
                    MessageBox.Show("Menu Added");
                }
                else
                {
                    MessageBox.Show("Menu Add Failed");
                }
            }
            else
            {
                MessageBox.Show("Error", "Name Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            qty = Convert.ToInt32(numericUpDownQty.Value);
        }
        private void AddMenuToOrderView_Load(object sender, EventArgs e)
        {
            if (stat == "edit")
            {
                labelMenu.Text = _menu.get_menu_name(id_menu);
                numericUpDownQty.Value = qty;
                Init_DataBinding_Menu(labelMenu.Text);
            }
        }

        private void dataGridViewMenu_SelectionChanged(object sender, EventArgs e)
        {
            id_menu = Convert.ToInt32(dataGridViewMenu.SelectedRows[0].Cells[0].Value);
            labelMenu.Text = dataGridViewMenu.SelectedRows[0].Cells[1].Value.ToString();
        }

        
    }
}
