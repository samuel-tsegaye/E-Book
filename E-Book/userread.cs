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
    public partial class userread : Form
    {
        public userread()
        {
            InitializeComponent();
        }
        private SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=DESKTOP-0D3AF2C;Initial Catalog=E_BOOK;Integrated Security=True;");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.SelectedRows;

            foreach (var row in selectedRow)
            {
                int id = (int)((DataGridViewRow)row).Cells[0].Value;
                OpenFile(id);
            }
        }

        private void userread_Load(object sender, EventArgs e)
        {
        }
        private void LoadData()
        {

            

            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("Select ID,FileName,Book_Title,Author,Catagories,Quantity From documents", con);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }
        private void OpenFile(int id)
        {
            using (SqlConnection con = GetConnection())
            {
                string query = " Select * From documents where ID=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                con.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var name = reader["FileName"].ToString();
                    var data = (byte[])reader["data"];
                    var extn = reader["Extension"].ToString();
                    var newFileName = name.Replace(extn, DateTime.Now.ToString("ddMMyyyyhhmmss")) + extn;

                    File.WriteAllBytes(newFileName, data);
                    System.Diagnostics.Process.Start(newFileName);



                }
            }
        }

        private void userread_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_BOOKDataSet6.documents' table. You can move, or remove it, as needed.
            this.documentsTableAdapter.Fill(this.e_BOOKDataSet6.documents);
            LoadData();
        }

        private void exitAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userlog us = new userlog();
            us.Show();
            this.Close();
        }

        private void termsAndConditionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 us = new Form3();
            us.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.SelectedRows;

            foreach (var row in selectedRow)
            {
                int id = (int)((DataGridViewRow)row).Cells[0].Value;
                OpenFile(id);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = GetConnection())
            {
                string query = "select ID,FileName,Book_Title,Author,Catagories,Quantity from documents where Book_Title like '" + textBox1.Text + "%'";

                SqlDataAdapter ad = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void priToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
