using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orphanage_Care_Manager.db
{
     class DBConnection
    {
        
        private static SqlConnection sqlConn=null;
        
       
        public static SqlConnection getConnection() { 
            if (sqlConn == null)
            {
                try
                {
                    sqlConn = new SqlConnection(@"Data Source=SAYUMI-PC;Initial Catalog=5-6314573820384512714;Integrated Security=True");
                    sqlConn.Open();
                }catch (SqlException ex) { 
                    Console.WriteLine("Please ensure that the sqlconnection string is correct OR check whether the database is exists");
                }
                
            }
            return sqlConn;
        }
    }
}
