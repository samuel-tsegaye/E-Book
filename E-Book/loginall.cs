using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace E_Book
{
    public partial class loginall : Form
    {
        public loginall()
        {
            InitializeComponent();
        }
      

        private void loginall_Load(object sender, EventArgs e)
        {

        }
        private void Edit(bool value)
        {
            ad_password.Enabled = value;

        }
        private void label15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registeration reg = new Registeration();
            reg.ShowDialog();
            reg = null;
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userlog lo = new userlog();
            lo.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        labacc UCLA = new labacc();

        private void button3_Click_1(object sender, EventArgs e)
        {
            UCLA.username = lib_name.Text;
            UCLA.password = lib_pass.Text;

            int result = UCLA.LogIn(UCLA);
            if (result == 1)
            {
                libuser us = new libuser();
                us.Show();
                this.Hide();
            }
            else if (result == -1)
            {
                MessageBox.Show("Incorrect Username and Password");
            }
          
        }

        private void UL_name_TextChanged(object sender, EventArgs e)
        {
        }
       
        private void button7_Click_1(object sender, EventArgs e)
        {
           
        }

     

        adminpasword Ap = new adminpasword();
        private void button6_Click(object sender, EventArgs e)
        {
            Ap.adminpass = ad_password.Text;

            int result = Ap.LogIn(Ap);

            if (result == 1)
            {
                admin ad_sc = new admin();
                ad_sc.Show();
                this.Hide();
            }
            else if (result == -1)
            {
                MessageBox.Show("Incorrect Username and Password");
            }
            else
                MessageBox.Show("Connection Error");

        }
        private void admintext_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userlog lo = new userlog();
            lo.Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            userlog lo = new userlog();
            lo.Show();
            this.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        Autlog Au = new Autlog();
        private void button9_Click(object sender, EventArgs e)
        {
            Au.username = textBox6.Text;
            Au.password = textBox4.Text;

            int result = Au.LogIn(Au);
            if (result == 1)
            {
                Author_view us = new Author_view();
                us.Show();
                this.Hide();
            }
            else if (result == -1)
            {
                MessageBox.Show("Incorrect Username and Password");
            }
        }
    }
}
