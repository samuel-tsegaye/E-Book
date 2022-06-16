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
using System.IO;


namespace E_Book
{
    public partial class admin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0D3AF2C;Initial Catalog=E_BOOK;Integrated Security=True;");


        public admin()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            loginall log = new loginall();
            log.Show();
        }

        private void Lb_add_Click(object sender, EventArgs e)
        {
            
                SqlCommand cmd = new SqlCommand("INSERT INTO Lib_info VALUES ( " + Lb_id.Text + ", '" + Lb_firstname.Text + "', '" + Lb_lastname.Text + "'," + Lb_phone.Text + ")", con);
                 SqlDataReader dr;
            try
            {

                con.Open();

                dr = cmd.ExecuteReader();
                MessageBox.Show("New Librarien Successfully Added");
                clear();
                while (dr.Read())
                {

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            RefreshData();
        }
        public void RefreshData()
        {
            SqlCommand cmd = new SqlCommand("select * from Lib_info ", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void Au_RefreshData()
        {
            SqlCommand cmd = new SqlCommand("select * from Aut_info ", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView3.DataSource = dt;
        }
        public void Aut_RefreshData()
        {
            SqlCommand cmd = new SqlCommand("select * from Aut_acc ", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView4.DataSource = dt;
        }
        private void admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_BOOKDataSet.Lib_Info' table. You can move, or remove it, as needed.
            this.lib_InfoTableAdapter.Fill(this.e_BOOKDataSet.Lib_Info);
            RefreshData();
            RefreshData1();
            Au_RefreshData();
            Aut_RefreshData();

            this.reportViewer3.RefreshReport();
        }

        private void Lb_reset_Click(object sender, EventArgs e)
        {
            clear();
        }
        void clear()
        {
            Lb_id.Clear();
            Lb_firstname.Clear();
            Lb_lastname.Clear();
            Lb_phone.Clear();
        }

        private void Lib_add_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Lib_acc VALUES ( " + Lib_id.Text + ", '" + Lib_username.Text + "', '" + Lib_password.Text + "')", con);
            SqlDataReader dr;


            try
            {

                con.Open();

                dr = cmd.ExecuteReader();
                MessageBox.Show("New Librarien Account Successfully Created");
                acc_clear();
                while (dr.Read())
                {

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            RefreshData();
          
            
         
        }
        public void RefreshData1()
        {

            SqlCommand cmd1 = new SqlCommand("select * from Lib_acc ", con);
            SqlDataAdapter ad1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            ad1.Fill(dt1);
            dataGridView2.DataSource = dt1;

        }

        private void Lib_reset_Click(object sender, EventArgs e)
        {
            acc_clear();
        }
        private void acc_clear()
        {
            Lib_id.Text = "";
            Lib_username.Text = "";
            Lib_password.Text = "";
        }

        private void Au_add_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("INSERT INTO Aut_info VALUES ( " + Au_id.Text + ", '" + Au_firstname.Text + "', '" + Au_lastname.Text + "','"+Au_phone.Text+"')", con);
            SqlDataReader dr;
            try
            {

                con.Open();

                dr = cmd.ExecuteReader();
                MessageBox.Show("New Author Successfully Added");
                Au_clean();
                while (dr.Read())
                {

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            Au_RefreshData();
        }

        private void Aut_add_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Aut_acc VALUES ( " + Aut_id.Text + ", '" + Aut_username.Text + "', '" + Aut_password.Text + "')", con);
            SqlDataReader dr;


            try
            {

                con.Open();

                dr = cmd.ExecuteReader();
                MessageBox.Show("New Author Account Successfully Created");
                Aut_clean();
                while (dr.Read())
                {

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            Aut_RefreshData();
        }

        private void Au_reset_Click(object sender, EventArgs e)
        {
            Au_clean();
        }
        private void Au_clean()
        {
            Au_id.Text = "";
            Au_firstname.Text = "";
            Au_lastname.Text = "";
            Au_phone.Text = "";
        }

        private void Aut_reset_Click(object sender, EventArgs e)
        {
            Aut_clean();
        }
        private void Aut_clean()
        {
            Aut_id.Text = "";
            Aut_username.Text = "";
            Aut_password.Text = "";
        }

        private void Lib_delete_Click(object sender, EventArgs e)
        {

        }

        private void Aut_delete_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
 }

