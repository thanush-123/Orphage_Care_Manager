using Orphanage_Care_Manager.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orphanage_Care_Manager.db
{
    internal class DBRequirements
    {
        public DBRequirements() {
        
        }
       
        public void addRequirement(Requirement requirement)
        {
            SqlConnection sqlconn = DBConnection.getConnection();

            
            string sql = "INSERT INTO Requirement (RequirementID, RequirementName, RequirementCount, OrphanageRegNo) " +
                     "VALUES (@RequirementID, @RequirementName, @RequirementCount, @OrphanageRegNo)";
            SqlCommand cmd = new SqlCommand(sql, sqlconn);
            
            cmd.Parameters.AddWithValue("@RequirementID", requirement.Item_1.Id);
            cmd.Parameters.AddWithValue("@RequirementName", requirement.Item_1.Name);
            cmd.Parameters.AddWithValue("@RequirementCount", requirement.Item_1.Quantity);
            cmd.Parameters.AddWithValue("@OrphanageRegNo", requirement.Orphanage_1.OrphanageRegNo);
            
            cmd.ExecuteNonQuery();

            sqlconn.Close();
            MessageBox.Show("Success");



        }
    }
}
