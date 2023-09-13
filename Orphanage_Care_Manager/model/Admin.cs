using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orphanage_Care_Manager.model
{
   
    public class Admin
    {
        private string _userName;
        private string _password;
        private string _email;

        public string UserName { get => _userName; set => _userName = value; }
        public string Password { get => _password; set => _password = value; }
        public string Email { get => _email; set => _email = value; }

        
        public void categorizeDonar(Donar donar) { }
        public void distributeDonations() { }
        public void informDonators(List<Donar> donars) { }
    }
}
