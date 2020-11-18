using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Restoran
{
    public partial class MainProgram : Form
    {
        UserLoginView user;
        EditUserView edituser;
        MenuDataView menu;
        OrderDataView order;
        public string username { set; get; }
        public bool status;
        public MainProgram()
        {
            InitializeComponent();
            Program_Load();
            WindowState = FormWindowState.Maximized;
        }

        private void Program_Load()
        {
            menuToolStripMenuItem.Enabled = false;
            orderToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = false;
            editUserToolStripMenuItem.Visible = false;
        }

        private void Login_User()
        {
            user = new UserLoginView();
            user.MdiParent = this;
            user.FormClosed += User_FormClosed;
            user.Show();
        }

        private void Edit_User()
        {
            edituser = new EditUserView();
            edituser.MdiParent = this;
            edituser.FormClosed += Edituser_FormClosed;
            edituser.Show();
        }

        private void Menu()
        {
            menu = new MenuDataView();
            menu.MdiParent = this;
            menu.FormClosed += Menu_FormClosed;
            menu.Show();
        }
        private void Order()
        {
            order = new OrderDataView(username);
            order.MdiParent = this;
            order.FormClosed += Order_FormClosed;
            order.Show();
        }

        private void Order_FormClosed(object sender, FormClosedEventArgs e)
        {
            order = null;
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu = null;
        }

        private void Edituser_FormClosed(object sender, FormClosedEventArgs e)
        {
            edituser = null;
        }

        private void User_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (user.status_login == true)
            {
                menuToolStripMenuItem.Enabled = true;
                orderToolStripMenuItem.Enabled = true;
                logoutToolStripMenuItem.Enabled = true;
                username = user.login_as;
                youLoginAsToolStripMenuItem.Text = $"You Login as : {user.login_as}";
                Refresh(username);
            }
            //throw new NotImplementedException();
        }

        private void Refresh(string name)
        {
            if (name == "Admin")
            {
                editUserToolStripMenuItem.Visible = true;
            }
            else
            {
                editUserToolStripMenuItem.Visible = false;
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menu == null)
            {
                Menu();
            }
            else
            {
                menu.Activate();
            }
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (order == null)
            {
                Order();
            }
            else
            {
                order.Activate();
            }
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (edituser == null)
            {
                Edit_User();
            }
            else
            {
                edituser.Activate();
            }
        }

        private void MainProgram_Load(object sender, EventArgs e)
        {
            if (user == null)
            {
                Login_User();
            }
            else
            {
                user.Activate();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            youLoginAsToolStripMenuItem.Text = $"You Login as : ";
            if (edituser != null)
            {
                edituser.Close();
            }
            if (menu != null)
            {
                menu.Close();
            }
            if (order != null)
            {
                order.Close();
            }
            Program_Load();
            Login_User();
        }

        
    }
}
