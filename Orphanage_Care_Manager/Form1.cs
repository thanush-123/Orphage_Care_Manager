using Orphanage_Care_Manager.model;
using System;
using System.Windows.Forms;

namespace Orphanage_Care_Manager
{
    public partial class Form1 : Form
    {
        private Admin admin=null;
        public Form1(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            load_form(new HomeView(admin));
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
            load_form(new HomeView(admin));
        }

        private void btnOrphanagesOnClick(object sender, EventArgs e)
        {
            load_form(new OrphanagesView(admin));
        }

        private void btnOrphansOnClick(object sender, EventArgs e)
        {
            load_form(new OrphansView(admin));
        }

        private void bntVolunteersOnClick(object sender, EventArgs e)
        {
            load_form(new VolunteersView(admin));
        }

        private void btnDonatorsOnClick(object sender, EventArgs e)
        {
            load_form(new DonarsView(admin));
        }

        private void btnDonationsOnClick(object sender, EventArgs e)
        {
            load_form(new DonationsView(admin));
        }

        private void bntRequirementsOnClick(object sender, EventArgs e)
        {
            load_form(new RequirementsView(admin));
        }

        private void btnEmailsOnClick(object sender, EventArgs e)
        {
            load_form(new EmailsView(admin));
            new EmailsView(admin);
        }

        private void btnEventsOnClick(object sender, EventArgs e)
        {
            load_form(new EventsView(admin));
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
