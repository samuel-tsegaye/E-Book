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
    public partial class libuser : Form
    {
        public libuser()
        {
            InitializeComponent();
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
        private void SaveFile(string FilePath)
        {

            using (Stream stream = File.OpenRead(FilePath))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);

                var fi = new FileInfo(FilePath);
                string extn = fi.Extension;
                string name = fi.Name;

                string query = "INSERT INTO documents(FileName,Data,Extension,Book_Title,Author,Catagories,Quantity)VALUES(@name,@data,@extn,'" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";

                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                    cmd.Parameters.Add("@data", SqlDbType.VarBinary).Value = buffer;
                    cmd.Parameters.Add("@extn", SqlDbType.Char).Value = extn;
                    con.Open();
                    cmd.ExecuteNonQuery();

                }
            }


        }
        private SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=DESKTOP-0D3AF2C;Initial Catalog=E_BOOK;Integrated Security=True;");
        }
        private void libuser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_BOOKDataSet7.documents' table. You can move, or remove it, as needed.
          
            LoadData();
            LoadData_read();
        }

        private void LoadData_read()
        {
            using (SqlConnection con = GetConnection())
            {
                string query = " Select ID,FileName,Book_Title,Author,Catagories,Quantity From documents";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView2.DataSource = dt;
                }

            }
        }
        private void LoadData()
        {
            using (SqlConnection con = GetConnection())
            {
                string query = " Select  ID,FileName,Book_Title,Author,Catagories,Quantity From documents";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
        
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginall lo = new loginall();
            lo.Show();
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "PDF Files (.pdf)|*.pdf";
            open.ShowDialog();
            textBox5.Text = open.FileName;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = 50;
            if (progressBar1.Value == 50)
            {
                timer1.Stop();
                SaveFile(textBox5.Text);

            }
            progressBar1.Value = 100;
            if (progressBar1.Value == 100)
            {
                MessageBox.Show("File Upload Successfully");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();

            }
            progressBar1.Value = 0;

            libuser_Load(sender, e);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var selectedRow = dataGridView2.SelectedRows;

            foreach (var row in selectedRow)
            {
                int id = (int)((DataGridViewRow)row).Cells[0].Value;
                OpenFile(id);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = GetConnection())
            {
                string query = "select ID,FileName,Book_Title,Author,Catagories,Quantity from documents where Book_Title like '" + textBox6.Text + "%'";

                SqlDataAdapter ad = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView2.DataSource = dt;
            }
        }
    }
}
