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
    public partial class DonarsViewForm : Form
    {
        Admin admin;
        String status;
        public DonarsViewForm(Admin admin,String status)
        {
            InitializeComponent();
            this.admin = admin;
            this.status = status;
            restrictComponents();
           
        }

        private void DonarsViewForm_Load(object sender, EventArgs e)
        {
          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void restrictComponents() {
            if (status == "Add")
            {
                lblTopic.Text ="Create an Orphanage";
                btnDelete.Enabled=false;
                btnDelete.BackColor = System.Drawing.ColorTranslator.FromHtml("#d2d4e9");
                btnUpdate.Enabled=false;
                btnUpdate.BackColor = System.Drawing.ColorTranslator.FromHtml("#d2d4e9");
                

            }
            if (status == "Update")
            {
                lblTopic.Text = "Update Details";
                btnDelete.Enabled=false;
                btnDelete.BackColor = System.Drawing.ColorTranslator.FromHtml("#f4f5fa");
                btnAdd.Enabled=false;
                btnAdd.BackColor = System.Drawing.ColorTranslator.FromHtml("#f4f5fa");
            }
            if (status == "Delete")
            {
                lblTopic.Text = "Delete Orphanage";
                btnAdd.Enabled = false;
                btnAdd.BackColor = System.Drawing.ColorTranslator.FromHtml("#f4f5fa");
                btnUpdate.Enabled = false;
                btnUpdate.BackColor = System.Drawing.ColorTranslator.FromHtml("#f4f5fa");

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}