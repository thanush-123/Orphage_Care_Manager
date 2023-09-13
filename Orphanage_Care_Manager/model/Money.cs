using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orphanage_Care_Manager.model
{
    internal class Money : Donation
    {

        private int amount;
        public Money():base("Money",DateTime.Today) {
            
        }

        public int Amount { get => amount; set => amount = value; }
    }
}
