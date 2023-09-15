using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Orphanage_Care_Manager.db
{
    internal class OrphanageQuery
    {
        public OrphanageQuery() {
        connectDB();
        }

        public SqlConnection connectDB() {
            string connectionString;
            SqlConnection con;

            connectionString = @"Data Source=LAPTOP-CJ319HVF;Initial Catalog=orphanage;Integrated Security=True";
            
          
            con = new SqlConnection(connectionString);
            con.Open();
            MessageBox.Show("Connection open!");

            return con;
        }
       
    }
}
