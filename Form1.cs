using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise6
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" && txtPassword.Text == "")
            {
                result.Text = "Please Enter valid username and password";
            }
            else
            {
                login user = new login
                {
                    name = txtUser.Text,
                    password = txtPassword.Text,

                };
                bool a = login.authenticateUser(user);
                if (a)
                {
                    HomePage home = new HomePage();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    result.Text = "Invalid User Name and Password";
                }
            }
        }
    }
}
