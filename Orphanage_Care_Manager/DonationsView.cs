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
    public partial class DonationsView : Form
    {
        Admin admin = null;
        public DonationsView(Admin admin)
        {
            InitializeComponent();
            this.admin = admin; 
        }

        private void DonationsView_Load(object sender, EventArgs e)
        {

        }
    }
}
