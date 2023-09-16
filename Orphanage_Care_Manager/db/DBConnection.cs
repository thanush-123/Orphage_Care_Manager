using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orphanage_Care_Manager.db
{
     static class DBConnection
    {
        
        private static SqlConnection sqlConn=null;
        
       
        public static SqlConnection getConnection() { 
            if (sqlConn == null)
            {
                try
                {
                    sqlConn = new SqlConnection(@"Data Source=laptop-cj319hvf;Initial Catalog=Test; Integrated Security=True");
                    sqlConn.Open();
                }catch (SqlException ex) { 
                    Console.WriteLine("Please ensure that the sqlconnection string is correct OR check whether the database is exists");
                }
                
            }
            return sqlConn;
        }
    }
}
