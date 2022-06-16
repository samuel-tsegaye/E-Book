using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace E_Book
{
    internal class adminpasword
    {


        public string adminpass { get; set; }//for admin


        static string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
  

        public int LogIn(adminpasword U)

        {
                SqlConnection con = new SqlConnection(connectionString);

              
                //admin account log in
       

                try
                {
                    SqlCommand cmd = new SqlCommand("Select * from admin1 where Password = '" + U.adminpass + "' ", con);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Error", ex.ToString());
                }
                finally
                {
                    con.Close();
                }


                return 0;
            }






        }
    }

