using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orphanage_Care_Manager.model
{
    public abstract class Donation
    {
        public string donationType;
        public DateTime date;
        public Donar donar;
        public Admin admin;
        public Donation(string donationType,DateTime date) { 
            this.donationType = donationType;
            this.date = date;
            
        }
       
    }
}
