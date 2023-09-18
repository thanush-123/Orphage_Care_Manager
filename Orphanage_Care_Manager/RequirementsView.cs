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
    public partial class RequirementsView : Form
    {
        Admin admin = null;
        public RequirementsView(Admin admin)
        {
            InitializeComponent();
            this.admin = admin; 
        }

        private void RequirementsView_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addNewReq(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                load_form(new RequirementAddForm());
            }
            else
            {
                MessageBox.Show("This control don't have a parent..");
            }
        }

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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
