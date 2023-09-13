using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orphanage_Care_Manager.model
{
    
    internal class Requirement
    {
        private DateTime date;
        private List<Item> items ;
        private Item item;
        private Orphanage orphanage;
        private Admin admin;
        Requirement()
        {
               
        }
        Requirement(Item item, Orphanage orphanage, Admin admin)
        {
            date = DateTime.Today;
            this.item = item;
            this.orphanage = orphanage;
            this.admin = admin; 
        }
        public void setItem(Item item)
        {
            items.Add(item);    
        }
      
       
    }
}
