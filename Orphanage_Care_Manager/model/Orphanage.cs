using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orphanage_Care_Manager.model
{
    public class Orphanage
    {
        private string orphanageRegNo;
        private string orphanageName;
        private string orphanageAddress;
        private string orphanageContactNo;
        private string orphanageEmail;
        private string vacancies;
        private Admin admin;
        private List<Orphan> orphans;
        private List<Requirement> requirements;

        public Orphanage(string orphanageRegNo, string orphanageName, string orphanageAddress, string orphanageContactNo, string orphanageEmail, string vacancies, Admin admin)
        {
            this.orphanageRegNo = orphanageRegNo;
            this.orphanageName = orphanageName;
            this.orphanageAddress = orphanageAddress;
            this.orphanageContactNo = orphanageContactNo;
            this.orphanageEmail = orphanageEmail;
            this.vacancies = vacancies;
            this.admin = admin;
        }

        public Orphanage(string orphanageRegNo)
        {
            this.orphanageRegNo = orphanageRegNo;
        }

        public string OrphanageRegNo { get => orphanageRegNo; set => orphanageRegNo = value; }
        public string OrphanageName { get => orphanageName; set => orphanageName = value; }
        public string OrphanageAddress { get => orphanageAddress; set => orphanageAddress = value; }
        public string OrphanageContactNo { get => orphanageContactNo; set => orphanageContactNo = value; }
        public string OrphanageEmail { get => orphanageEmail; set => orphanageEmail = value; }
        public string Vacancies { get => vacancies; set => vacancies = value; }
        public Admin Admin { get => admin; set => admin = value; }

        public void orphanageRequirement() {  }
    }
}
