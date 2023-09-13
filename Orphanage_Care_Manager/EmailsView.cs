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
    public partial class EmailsView : Form
    {
        Admin admin = null;
        public EmailsView(Admin admin)
        {
            InitializeComponent();
            this.admin = admin; 
        }

        private void EmailsView_Load(object sender, EventArgs e)
        {

        }
    }
}
