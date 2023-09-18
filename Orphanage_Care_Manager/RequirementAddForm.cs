using Orphanage_Care_Manager.db;
using Orphanage_Care_Manager.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orphanage_Care_Manager
{
    public partial class RequirementAddForm : Form
    {
       
        public RequirementAddForm()
        {
            InitializeComponent();
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            Item item = new Item(txtItemID.Text, txtItemName.Text, Convert.ToInt32(nudQuantity.Value));
            Orphanage orphanage = new Orphanage(txtOrphanageID.Text);

            DBRequirements dbRequirements = new DBRequirements();
            Requirement requirement = new Requirement(item, orphanage, admin);
            
            dbRequirements.addRequirement(requirement);
            

        }
    }
}
