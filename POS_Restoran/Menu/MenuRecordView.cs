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
    public partial class MenuRecordView : Form
    {
        Menu _menu;
        bool status;
        string stat = "new";
        public int id { get; set; }
        public string name { get; set; }
        public long harga { get; set; }
        public string tipe { get; set; }
        public MenuRecordView(string stat)
        {
            InitializeComponent();
            this.comboBoxTipe.Items.AddRange(new string[] { "Makanan", "Minuman" });
            this.stat = stat;
            _menu = new Menu();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (status == false)
            {
                if (stat == "new")
                    _menu.add_menu(textBoxNama.Text, Convert.ToInt64(textBoxHarga.Text), comboBoxTipe.Text);
                else
                    _menu.edit_menu(id, textBoxNama.Text, Convert.ToInt64(textBoxHarga.Text), comboBoxTipe.Text);
                if (_menu.cek_menu(textBoxNama.Text))
                {
                    MessageBox.Show("Menu Created");
                }
                else
                {
                    MessageBox.Show("Menu Create Failed");
                }
            }
            else
            {
                MessageBox.Show("Name Has Been Used", "Name Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            status = _menu.cek_menu(textBoxNama.Text);

            if (textBoxNama.Text == name || status == false)
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(textBoxNama, "Name Has Been Used");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void MenuRecordView_Load(object sender, EventArgs e)
        {
            if (stat == "edit")
            {
                textBoxNama.Text = name;
                textBoxHarga.Text = harga.ToString();
                comboBoxTipe.Text = tipe;
            }
        }
    }
}
