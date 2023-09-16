using Orphanage_Care_Manager.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Orphanage_Care_Manager
{
    public partial class OrphanageDetails : Form
    {
        
        
        

        public OrphanageDetails()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OrphanageDetails_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C://Desktop";
            ofd.Title = "Select Image to be upload";
            ofd.Filter = "Image only(*.jpg;*.jpeg; *.gif; *.bmp; *.png)|*.jpg;*.jpeg; *.gif; *.bmp; *.png";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                if (ofd.CheckFileExists)
                {
                    string path = System.IO.Path.GetFullPath(ofd.FileName);
                    lblPath.Text = path;
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else {
                    MessageBox.Show("Please Upload Image");
                }
            }
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            try { 
            OpenFileDialog ofd=new OpenFileDialog();
            string filename = System.IO.Path.GetFileName(ofd.FileName);
            if (filename == null)
            {
                MessageBox.Show("Please select a valid Image");
            }
            else {
                OrphanageQuery query = new OrphanageQuery();
                SqlConnection con;
                con = query.connectDB();

               
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into wallpaper (image)values('\\Image\\" + filename + "')", con);
                string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                System.IO.File.Copy(ofd.FileName, path + "\\Image\\" + filename);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Image uploaded successfully.");

            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File Already exits");
            }
        }
    }
}
