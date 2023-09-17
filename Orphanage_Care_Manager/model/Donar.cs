using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orphanage_Care_Manager.model
{
    public class Donar
    {
        private string _nic;
        private string _name;
        private string _address;
        private string _contact;
        private string _email;
        private string _type;
        private Admin _admin;
        private List<Donation> donations;

        public Donar(string nic) 
        {
            _nic = nic;        
        }  
        public Donar(string nic, string name, string contact, string email, string type , Admin admin)
        {
            _nic = nic;
            _name = name;
            _contact = contact;
            _email = email;
            _type = type;
            _admin = admin;
        }

        public string Nic { get => _nic; set => _nic = value; }
        public string Name { get => _name; set => _name = value; }
        public string Address { get => _address; set => _address = value; }
        public string Contact { get => _contact; set => _contact = value; }
        public string Email { get => _email; set => _email = value; }
        public string Type { get => _type; set => _type = value; }
        public Admin Admin { get => _admin; set => _admin = value; }
        public List<Donation> Donations { get => donations; set => donations = value; }
    }
}
