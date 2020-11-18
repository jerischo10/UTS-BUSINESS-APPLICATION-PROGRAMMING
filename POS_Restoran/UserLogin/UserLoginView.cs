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
    public partial class UserLoginView : Form
    {
        UserLogin user;
        public bool status_login { get; set; }
        public string login_as { get; set; }
        public UserLoginView()
        {
            InitializeComponent();
            user = new UserLogin();
        }

        private void UserLoginView_Load(object sender, EventArgs e)
        {
            string pesan = user.getpesan();
            MessageBox.Show(pesan);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool status = user.getstatus(textBoxUsername.Text, textBoxPassword.Text);
            if (status)
            {
                status_login = true;
                login_as = textBoxUsername.Text;
                this.Close();
            }
            else
                MessageBox.Show("Wrong Password");
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked)
                textBoxPassword.PasswordChar = '\0';
            else
                textBoxPassword.PasswordChar = '*';
        }
    }
}
