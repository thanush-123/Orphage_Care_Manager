using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orphanage_Care_Manager.model
{
    public class Volunteer
    {
        private string volunteerNIC;
        private string volunteerName;
        private string volunteerContact;
        private string volunteerEmail;
        private string volunteerType;
        private Admin admin;

        Volunteer()
        {

        }

        public Volunteer(string volunteerNIC, string volunteerName, string volunteerContact, string volunteerEmail, Admin admin)
        {
            this.volunteerNIC = volunteerNIC;
            this.volunteerName = volunteerName;
            this.volunteerContact = volunteerContact;
            this.volunteerEmail = volunteerEmail;
            this.admin = admin;
           
        }
       
       

        
    }
}
