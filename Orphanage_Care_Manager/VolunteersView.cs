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
    public partial class VolunteersView : Form
    {
        Admin admin = null;

        public VolunteersView(Admin admin)
        {
            InitializeComponent();
            this.admin = admin; 
        }

        private void VolunteersView_Load(object sender, EventArgs e)
        {

        }
    }
}
