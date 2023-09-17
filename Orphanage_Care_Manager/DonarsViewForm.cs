using Orphanage_Care_Manager.db;
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
        private ErrorProvider errorProvider;
        public DonarsViewForm(Admin admin,String status)
        {
            InitializeComponent();
            this.admin = admin;
            this.status = status;
            restrictComponents();
            errorProvider = new ErrorProvider();

        }

        private void DonarsViewForm_Load(object sender, EventArgs e)
        {
            errorName.Text = "";
            errorNIC.Text = "";
            errorEmail.Text = "";
            errorContact.Text = "";
            errorType.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Boolean validation = true;
            if (string.IsNullOrEmpty(txtNic.Text.Trim()))
            {
                //txtNic.Text = "Please Enter NIC";
                //txtNic.ForeColor = Color.IndianRed;
                errorNIC.Text = "required";
                errorNIC.ForeColor = Color.IndianRed;
                validation = false;
            }
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                //txtName.Text = "Please Enter NIC";
                //txtName.ForeColor = Color.IndianRed;
                errorName.Text = "required";
                errorName.ForeColor = Color.IndianRed;
                validation = false;
            }
            if (string.IsNullOrEmpty(txtContact.Text.Trim()))
            {
                //txtContact.Text = "Please Enter NIC";
                //txtContact.ForeColor = Color.IndianRed;
                errorContact.Text = "required";
                errorContact.ForeColor = Color.IndianRed;
                validation = false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                //txtEmail.Text = "Please Enter NIC";
                //txtEmail.ForeColor = Color.IndianRed;
                errorEmail.Text = "required";
                errorEmail.ForeColor = Color.IndianRed;
                validation = false;
            }
             if (string.IsNullOrEmpty(txtDonarType.Text.Trim()))
            {
                //txtDonarType.Text = "Please Enter NIC";
                //txtDonarType.ForeColor = Color.IndianRed;
                errorType.Text = "required";
                errorType.ForeColor = Color.IndianRed;
                validation = false;
            }
            if(validation==true)
            {
                Admin admin1 = new Admin();
                admin1.UserName = "Gavesh";
                Donar donar = new Donar(txtNic.Text, txtName.Text, txtContact.Text, txtEmail.Text, txtDonarType.Text, admin1);
                DonarsQuery donarsQuery = new DonarsQuery();
                donarsQuery.addDonar(donar);

            }
            
         

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

        
        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            

            if (string.IsNullOrWhiteSpace(txtNic.Text))
            {
                errorProvider.SetError(txtNic, "Name is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNic, ""); // Clear error message
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

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
    }
}