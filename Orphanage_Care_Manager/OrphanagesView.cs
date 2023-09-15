using Orphanage_Care_Manager.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orphanage_Care_Manager
{
    public partial class OrphanagesView : Form
    {
        Admin admin = null;
        public OrphanagesView(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void OrphanagesView_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OrphanageDetails orphanageDetails = new OrphanageDetails();
            orphanageDetails.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OrphanageDetails orphanageDetails=new OrphanageDetails();
            orphanageDetails.Show();
        }
    }
}
