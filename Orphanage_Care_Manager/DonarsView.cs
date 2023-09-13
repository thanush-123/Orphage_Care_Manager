using Orphanage_Care_Manager.model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Orphanage_Care_Manager
{
    public partial class DonarsView : Form
    {
        Admin admin = null;
        public DonarsView(Admin admin)
        {
            InitializeComponent();
            loaddatagridview();
            this.admin = admin;

        }

        private void DonarsView_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loaddatagridview()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("NIC");
            dt.Columns.Add("Name");
            dt.Columns.Add("Contact");
            dt.Columns.Add("Email");
            dt.Columns.Add("DonorType");
            dt.Columns.Add("Admin");

            dt.Rows.Add("20024586956");
            dt.Rows.Add("Gavesh");
            dt.Rows.Add("0767171332");
            dt.Rows.Add("gthanushika1@gmail.com");
            dt.Rows.Add("Gold");
            dt.Rows.Add("a001");

            gridDonars.DataSource = dt;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddOnAction(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                load_form(new DonarsViewForm());
            }
            else
            {
                MessageBox.Show("This control don't have a parent..");
            }

        }

        private void btnUpdateOnAction(object sender, EventArgs e)
        {

        }

        private void btnDeleteOnAction(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        //public void load_form(Object form)
        //{
        //    if (this.Parent.Controls.Count > 0)
        //    {
        //        this.Parent.Controls.Clear();
        //    }
        //    Form f = form as Form;
        //    f.Dock = DockStyle.Fill;
        //    f.TopLevel = false;
        //    this.Parent.Controls.Add(f);
        //    f.Show();
        //}
        public void load_form(Form newForm)
        {
            if (newForm != null && newForm is Form)
            {
                Form currentForm = this.Parent.Controls.OfType<Form>().FirstOrDefault();
                if (currentForm != null)
                {
                    newForm.Dock = DockStyle.Fill;
                    newForm.TopLevel = false;
                    currentForm.Hide();
                    this.Parent.Controls.Add(newForm);
                }
                newForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid form parameter.");
            }
        }

    }
}
