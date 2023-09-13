using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orphanage_Care_Manager.model
{
    public class Orphan
    {
        private string _orphanNIC;
        private string _orphanName;
        private string _orphanAge;
        private string _orphanContact;
        private string _orphanGender;
        private Orphanage _orphanage;
        private Admin admin;

        public string OrphanNIC { get => OrphanNIC1; set => OrphanNIC1 = value; }
        public string OrphanNIC1 { get => _orphanNIC; set => _orphanNIC = value; }
        public string OrphanName { get => _orphanName; set => _orphanName = value; }
        public string OrphanAge { get => _orphanAge; set => _orphanAge = value; }
        public string OrphanContact { get => _orphanContact; set => _orphanContact = value; }
        public string OrphanGender { get => _orphanGender; set => _orphanGender = value; }
        public Admin Admin { get => admin; set => admin = value; }
        internal Orphanage Orphanage { get => _orphanage; set => _orphanage = value; }
    }
}
