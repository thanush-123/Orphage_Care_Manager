using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orphanage_Care_Manager.model
{
    internal class Good : Donation
    {
        List<Item> items;
        Orphanage orphanage;
        
        public Good():base("Goods",DateTime.Today){

        }
      
        public void checkAvailability(Good good) { 
        
        }
    }
}
