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
using System.ComponentModel.DataAnnotations;

namespace E_Book
{
    public partial class Registeration : Form
    {
        string gender;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0D3AF2C;Initial Catalog=E_BOOK;Integrated Security=True;");


        public Registeration()
        {
            InitializeComponent();
        }

        public void GetUserID()
        {
            string proid;
            string query = "Select ID from userinfo order by ID Desc";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if(dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                proid = id.ToString("00000");
            }
            else if(Convert.IsDBNull(dr))
            {
                proid = ("900001");
            }
            else
            {
                proid = ("900001");
            }
            con.Close();
            textBox1.Text = proid.ToString();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            GetUserID();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            loginall log = new loginall();
            log.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (radioButton2.Checked)
            {
                gender = "male";
            }
            else if(radioButton4.Checked)
            {
                gender = "female";
            }
            SqlCommand cmd = new SqlCommand("INSERT INTO userinfo VALUES (" + textBox1.Text+",'" + firstname.Text + "', '" + lastname.Text + "', '" + email.Text + "',@Gender,'" + phone.Text + "')", con);
            cmd.Parameters.AddWithValue("@Gender", gender);
            con.Open();
            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = new SqlCommand("INSERT INTO user_account VALUES ( " + textBox1.Text + ", '" + username.Text + "', '" + password.Text + "')", con);
            cmd1.ExecuteNonQuery();
          
            con.Close();



            loginall log = new loginall();
            log.Show();
            this.Close();
        
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
