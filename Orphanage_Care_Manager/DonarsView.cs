using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Orphanage_Care_Manager.model;

namespace Orphanage_Care_Manager
{
    public partial class DonarsView : Form
    {
        Admin admin = null;
        public DonarsView(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;

        }

        private void DonarsView_Load(object sender, EventArgs e)
        {

        }
    }
}
