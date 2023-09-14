﻿using System;
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
                    sqlConn = new SqlConnection(@"Data Source=LAPTOP-MC83SL4O;Initial Catalog=Test; Integrated Security=True");
                    sqlConn.Open();
                }catch (SqlException ex) { 
                    Console.WriteLine("Please ensure that the sqlconnection string is correct OR check whether the database is exists");
                }
                
            }
            return sqlConn;
        }
    }
}