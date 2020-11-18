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
    public partial class EditUserView : Form
    {
        EditUser edituser;
        EditUserRecordView adduser;
        public EditUserView()
        {
            InitializeComponent();
            edituser = new EditUser();
            Init_DataBinding("");
        }

        private void Init_DataBinding(string txt)
        {
            edituser.data_bindings(ref dataGridViewData, txt, ref labelTotal);
            this.dataGridViewData.Columns["ID_User"].Visible = false;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

            Init_DataBinding(textBoxSearch.Text);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            adduser = new EditUserRecordView("new");
            adduser.ShowDialog();
            Init_DataBinding(textBoxSearch.Text);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            adduser = new EditUserRecordView("edit");
            adduser.id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells[0].Value);
            adduser.username = dataGridViewData.SelectedRows[0].Cells[1].Value.ToString();
            adduser.password = dataGridViewData.SelectedRows[0].Cells[2].Value.ToString();
            adduser.ShowDialog();
            Init_DataBinding(textBoxSearch.Text);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells[0].Value);
            edituser.delete_user(id);
            Init_DataBinding(textBoxSearch.Text);
        }
        private void dataGridViewData_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
