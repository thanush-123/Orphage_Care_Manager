using Orphanage_Care_Manager.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orphanage_Care_Manager.db
{
    class DBQuery
    {
        private SqlConnection _conn;
        public DBQuery() { 
            _conn = DBConnection.getConnection();
        }
        public void AdminAuthenticate()
        {
            
            _conn.Close();
        }
        public void login() { }
        public void addOrphanage(Orphanage orphanage) {
            
        }
        public void deleteOrphage(Orphanage orphanage) { }
        public void updateOrphanageDetails(Orphanage orphanage) { }
        public void registerOrphan(Orphan orphan) { }
        public void registerDonar(Donar donar) { }
        public void registerVolunteer(Volunteer volunteer) { }
        public void addRequirements() { }


    }
}
