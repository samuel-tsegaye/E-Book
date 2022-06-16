using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Book
{
    public partial class userlog : Form
    {
        public userlog()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            loginall lo = new loginall();
            lo.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        user UC = new user();
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registeration reg = new Registeration();
            reg.ShowDialog();
            reg = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UC.username = UL_name.Text;
            UC.password = UL_password.Text;

            int result = UC.LogIn(UC);
            if (result == 1)
            {
                userread us = new userread();
                us.Show();
                this.Hide();
            }
            else if (result == -1)
            {
                MessageBox.Show("Incorrect Username and Password");
            }
            else
                MessageBox.Show("Connection Error");
        }
    }
}
