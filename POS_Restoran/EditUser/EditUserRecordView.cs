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
    public partial class EditUserRecordView : Form
    {
        EditUser adduser;
        bool status = true;
        string stat = "new";
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public EditUserRecordView(string stat)
        {
            InitializeComponent();
            this.stat = stat;
            adduser = new EditUser();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (stat == "new")
            {
                if (status == false)
                {
                    adduser.add_user(textBoxUsername.Text, textBoxPassword.Text);
                    if (adduser.cek_user(textBoxUsername.Text))
                    {
                        MessageBox.Show("User Created");
                    }
                    else
                    {
                        MessageBox.Show("User Create Failed");
                    }
                }
                else
                {
                    MessageBox.Show("Username Has Been Used", "Username Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (status == false)
                {
                    adduser.edit_user(id, textBoxUsername.Text, textBoxPassword.Text);
                    if (adduser.cek_user(textBoxUsername.Text))
                    {
                        MessageBox.Show("User Updated");
                    }
                    else
                    {
                        MessageBox.Show("User Update Failed");
                    }
                }
                else
                {
                    MessageBox.Show("Username Has Been Used", "Username Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            status = adduser.cek_user(textBoxUsername.Text);

            if (textBoxUsername.Text == username || status == false)
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(textBoxUsername, "Username Has Been Used");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked)
                textBoxPassword.PasswordChar = '\0';
            else
                textBoxPassword.PasswordChar = '*';
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
        }

        private void AddUserView_Load(object sender, EventArgs e)
        {
            if (stat == "edit")
            {
                textBoxUsername.Text = username;
                textBoxPassword.Text = password;
            }
        }
    }
}
