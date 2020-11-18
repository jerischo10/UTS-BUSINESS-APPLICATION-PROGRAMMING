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
    public partial class UserForm : Form
    {
        
        TempOrder _temp;
        OrderRecordView orderdetail;
        MainProgram _admin;
        string username = "user";
        public UserForm()
        {
            InitializeComponent();
            _temp = new TempOrder();
            _admin = new MainProgram();
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
            if (orderdetail == null)
            {
                orderdetail = new OrderRecordView("new", username, 0);
                orderdetail.FormClosed += Orderdetail_FormClosed;
                orderdetail.ShowDialog();
            }
            else
            {
                orderdetail.Activate();
            }
        }

        private void Orderdetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            orderdetail = null;
        }

        private void buttonAdm_Click(object sender, EventArgs e)
        {
            _admin.ShowDialog();
        }

    }
}
