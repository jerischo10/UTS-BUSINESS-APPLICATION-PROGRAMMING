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
    public partial class OrderDataView : Form
    {
        Order _order;
        OrderDetail _detail;
        TempOrder _temp;
        OrderRecordView orderdetail;
        Print _print;
        public string username { get; set; }
        public OrderDataView(string username)
        {
            InitializeComponent();
            _order = new Order();
            _temp = new TempOrder();
            _detail = new OrderDetail();
            this.username = username;
            comboBoxStatus.Items.AddRange(new string[] { "Tercetak", "Belum Tercetak" });
            comboBoxStatus.Text = "Belum Tercetak";
            Init_DataBinding(DateTime.Now, "", "all");
        }

        private void Init_DataBinding(DateTime date, string txt, string show)
        {
            _order.data_bindings(ref dataGridViewData, date, txt, show, ref labelTotal);
            this.dataGridViewData.Columns["ID_Order"].Visible = false;
        }

        private void content_Change()
        {
            if (checkBoxShow.Checked)
                Init_DataBinding(dateTimePickerOrder.Value, comboBoxStatus.Text, "all");
            else
                Init_DataBinding(dateTimePickerOrder.Value, comboBoxStatus.Text, "depend");
        }

        private void dateTime_TextChanged(object sender, EventArgs e)
        {
            content_Change();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            if (_temp.total_data(username) > 0)
            {
                var confirmResult = MessageBox.Show("There are Datas unsaved, Retrieve Data?",
                                     "Data Confirmation",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.No)
                {
                    _temp.delete_temp(username);
                }
            }
            orderdetail = new OrderRecordView("new", username, 0);
            orderdetail.ShowDialog();
            content_Change();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            orderdetail = new OrderRecordView("edit", username, Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells[0].Value));
            if (_temp.total_data(username) > 0)
            {
                _temp.delete_temp(username);
            }
            _detail.clone_to_temp(Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells[0].Value), username);
            
            orderdetail.date = DateTime.Parse(dataGridViewData.SelectedRows[0].Cells[1].Value.ToString());
            orderdetail.status_order = dataGridViewData.SelectedRows[0].Cells[3].Value.ToString();
            orderdetail.ShowDialog();
            content_Change();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure?",
                                     "Deletion Confirmation",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (username == "Admin")
                {
                    int id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells[0].Value);
                    _order.delete_order(id);
                }
                else
                {
                    MessageBox.Show("Only Allowed for Admin");
                }
            }
            content_Change();
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            content_Change();
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            content_Change();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            _print = new Print(Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells[0].Value), _order);

            _print.ShowDialog();
            content_Change();
        }
    }
}
