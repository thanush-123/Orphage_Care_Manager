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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            load_form(new HomeView());
        }
        public void load_form(Object form)
        {
            if (this.panelMain.Controls.Count > 0)
            {
                this.panelMain.Controls.Clear();
            }
            Form f = form as Form;
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            this.panelMain.Controls.Add(f);
            f.Show();
        }

        private void btnHomeOnClick(object sender, EventArgs e)
        {
            load_form(new HomeView());
        }

        private void btnOrphanagesOnClick(object sender, EventArgs e)
        {
            load_form(new OrphanagesView());
        }

        private void btnOrphansOnClick(object sender, EventArgs e)
        {
            load_form(new OrphansView());
        }

        private void bntVolunteersOnClick(object sender, EventArgs e)
        {
            load_form(new VolunteersView());
        }

        private void btnDonatorsOnClick(object sender, EventArgs e)
        {
            load_form(new DonationsView());
        }

        private void btnDonationsOnClick(object sender, EventArgs e)
        {
            load_form(new DonationsView());
        }

        private void bntRequirementsOnClick(object sender, EventArgs e)
        {
            load_form(new RequirementsView());
        }

        private void btnEmailsOnClick(object sender, EventArgs e)
        {
            load_form(new EmailsView());
        }

        private void btnEventsOnClick(object sender, EventArgs e)
        {
            load_form(new EventsView());
        }
    }
}
