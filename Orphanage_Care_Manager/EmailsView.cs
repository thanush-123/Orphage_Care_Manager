using Orphanage_Care_Manager.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orphanage_Care_Manager
{
    public partial class EmailsView : Form
    {
        Admin admin = null;
        List<string> emails;
        public EmailsView(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }
        public EmailsView(Admin admin, List<string> emails)
        {
            InitializeComponent();
            this.admin = admin;
            this.emails = emails;
            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }

        }

        private void EmailsView_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string from = "radgroup08@gmail.com";
            string password = "uhydvoskqhrkjtmk";
            // Create an SMTP client
            SmtpClient smtpClient = new SmtpClient(); // Replace with your SMTP server address
            smtpClient.Host = "smtp.gmail.com";
            // Configure the SMTP client
            smtpClient.Port = 587; // Port number (587 is commonly used for TLS/SSL)
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(from, password); // Replace with your credentials
            smtpClient.EnableSsl = true; // Enable SSL/TLS (if required)

            // Create an email message
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(from); // Replace with your email address
            mailMessage.To.Add(new MailAddress("gthanushika1@gmail.com")); // Replace with the recipient's email address
            mailMessage.Subject = "Hello, World!";
            mailMessage.Body = "This is a test email sent from C#.";

            try
            {
                // Send the email
                smtpClient.Send(mailMessage);
                Console.WriteLine("Email sent successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
