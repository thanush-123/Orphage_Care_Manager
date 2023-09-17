using Orphanage_Care_Manager.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orphanage_Care_Manager.db
{
    class DonarsQuery
    {
        private Donar donar;
        private Admin admin;
        public DonarsQuery()
        {
          

        }


        public void addDonar(Donar donar)
        {


            this.donar = donar;
            try
            {
                // Your code to insert data into the database goes here
                SqlConnection conn = DBConnection.getConnection();
                string sqlString = "insert into dbo.Donator values(@donarNIC,@donarName,@donarContact,@donarEmail,@donarType,@admin)";
                using (SqlCommand cmd = new SqlCommand(sqlString, conn))
                {
                    cmd.Parameters.AddWithValue("@donarNIC", donar.Nic);
                    cmd.Parameters.AddWithValue("@donarName", donar.Name);
                    cmd.Parameters.AddWithValue("@donarContact", donar.Contact);
                    cmd.Parameters.AddWithValue("@donarEmail", donar.Email);
                    cmd.Parameters.AddWithValue("@donarType", donar.Type);
                    cmd.Parameters.AddWithValue("@admin", donar.Admin.UserName);

                    int affectedRows = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Error number for a unique key violation
                {
                    // Handle the duplicate key violation here
                    MessageBox.Show("A record with this key already exists.");
                }
                else
                {
                    // Handle other SQL Server exceptions
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                // Handle other exceptions (not related to SQL Server)
                MessageBox.Show("An error occurred: " + ex.Message);
            }


        }

        public void retriveDonars(DataTable dt)
        {
            string sqlString = "select * from dbo.Donator";
            using (SqlCommand cmd = new SqlCommand(sqlString, DBConnection.getConnection()))
            {
               using (SqlDataAdapter adapter=new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
                cmd.ExecuteNonQuery();
            };
            
        }
        public void updateDonar(Donar donar)
        {
            this.donar = donar;
        }
        public void deleteDonar(Donar donar)
        {
            this.donar = donar;
            try
            {
                string sqlString = "DELETE FROM dbo.Donator WHERE PrimaryKeyColumn = @PrimaryKeyValue";
                using (SqlCommand cmd = new SqlCommand(sqlString, DBConnection.getConnection()))
                {
                    cmd.Parameters.Add(donar.Nic);
                    cmd.ExecuteNonQuery();
                };
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Exception: "+ex.Message);
            }


        }

    }
}
