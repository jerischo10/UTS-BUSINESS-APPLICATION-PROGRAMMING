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
    public partial class MenuDataView : Form
    {
        Menu _menu;
        MenuRecordView addmenu;
        public MenuDataView()
        {
            InitializeComponent();
            _menu = new Menu();
            Init_DataBinding("");
        }

        private void Init_DataBinding(string txt)
        {
            _menu.data_bindings(ref dataGridViewData, txt, ref labelTotal);
            this.dataGridViewData.Columns["ID_Menu"].Visible = false;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Init_DataBinding(textBoxSearch.Text);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            addmenu = new MenuRecordView("new");
            addmenu.ShowDialog();
            Init_DataBinding(textBoxSearch.Text);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            addmenu = new MenuRecordView("edit");
            addmenu.id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells[0].Value);
            addmenu.name = dataGridViewData.SelectedRows[0].Cells[1].Value.ToString();
            addmenu.harga = Convert.ToInt64(dataGridViewData.SelectedRows[0].Cells[2].Value);
            addmenu.tipe = dataGridViewData.SelectedRows[0].Cells[3].Value.ToString();
            addmenu.ShowDialog();
            Init_DataBinding(textBoxSearch.Text);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells[0].Value);
            _menu.delete_menu(id);
            Init_DataBinding(textBoxSearch.Text);
        }

        private void dataGridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
