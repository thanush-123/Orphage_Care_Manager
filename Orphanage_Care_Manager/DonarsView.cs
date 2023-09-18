using Orphanage_Care_Manager.db;
using Orphanage_Care_Manager.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            loadDataGridview();
            this.admin = admin;

        }

        private void DonarsView_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadDataGridview()
        {
            DataTable dt = new DataTable();
            //dt.Columns.Add("NIC");
            //dt.Columns.Add("Name");
            //dt.Columns.Add("Contact");
            //dt.Columns.Add("Email");
            //dt.Columns.Add("DonorType");
            //dt.Columns.Add("Admin");


            DonarsQuery donarsQuery = new DonarsQuery();
            donarsQuery.retriveDonars(dt);
            //DataRow dataRow = dt.NewRow();
            //dataRow[0] = "20024586956";
            //dataRow[1] = "Gavesh";
            //dataRow[2] = "0767171332";
            //dataRow[3] = "gthanushika1@gmail.com";
            //dataRow[4] = "Gold";
            //dataRow[5] = "a001";

            //dt.Rows.Add(dataRow);
            //dt.Rows.Add("20024586956");
            //dt.Rows.Add("Gavesh");
            //dt.Rows.Add("0767171332");
            //dt.Rows.Add("gthanushika1@gmail.com");
            //dt.Rows.Add("Gold");
            //dt.Rows.Add("a001");

            gridDonars.DataSource = dt;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddOnAction(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                load_form(new DonarsViewForm(admin, "Add"));
            }
            else
            {
                MessageBox.Show("This control don't have a parent..");
            }

        }

        private void btnUpdateOnAction(object sender, EventArgs e)
        {
            load_form(new DonarsViewForm(admin, "Update"));
        }

        private void btnDeleteOnAction(object sender, EventArgs e)
        {
            //load_form(new DonarsViewForm(admin, "Delete"));
            // Check if a row is selected in the DataGridView
            if (gridDonars.SelectedRows.Count > 0)
            {
                // Get the value of the primary key (assuming it's in the first column)
                //int primaryKeyValue = Convert.ToInt32(gridDonars.SelectedRows[0].Cells[0].Value);
                DataGridViewRow selectedRow = gridDonars.SelectedRows[0];

                // Perform the deletion in the database (Assuming you have a SQL connection and a command set up)


                try
                {
                    string value = (string)selectedRow.Cells["DonatorNIC"].Value;
                    Donar donar = new Donar(value);
                    DonarsQuery donarsQuery = new DonarsQuery();
                    donarsQuery.deleteDonar(donar);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                

                // Remove the row from the DataGridView
                gridDonars.Rows.Remove(gridDonars.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }


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

        private void gridDonars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSendMails_Click(object sender, EventArgs e)
        {
            List<string> emails=null;
            if (gridDonars.SelectedRows.Count > 0)
            {
                for(int i=0;i<gridDonars.SelectedRows.Count;i++)
                {
                    DataGridViewCell cell = gridDonars.SelectedRows[i].Cells[3];
                    //emails.Add(gridDonars.SelectedRows[i].Cells[3].Value.ToString()); 
                    // Check if the cell and its value are not null
                    if (cell != null && cell.Value != null)
                    {
                        // Convert the cell value to a string and add it to the 'emails' list
                        string email = cell.Value.ToString();
                        emails.Add(email);
                    }
                    else
                    {
                        // Handle the case where the cell or its value is null
                        // You can choose to skip, log, or handle this situation as needed.
                    }

                }
                load_form(new EmailsView(admin,emails));
            }
            else
            {
                MessageBox.Show("Please select donars to send emails.");
            }
            

        }
    }
}
