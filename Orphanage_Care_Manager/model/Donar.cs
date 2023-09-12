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
        private string _status;
        private Admin _admin;
        private List<Donation> donations;

        public Donar(string nic, string name, string address, string contact, string email, string status, Admin admin)
        {
            _nic = nic;
            _name = name;
            _address = address;
            _contact = contact;
            _email = email;
            _status = status;
            _admin = admin;
        }

        public string Nic { get => _nic; set => _nic = value; }
        public string Name { get => _name; set => _name = value; }
        public string Address { get => _address; set => _address = value; }
        public string Contact { get => _contact; set => _contact = value; }
        public string Email { get => _email; set => _email = value; }
        public string Status { get => _status; set => _status = value; }
        public Admin Admin { get => _admin; set => _admin = value; }
        public List<Donation> Donations { get => donations; set => donations = value; }
    }
}
