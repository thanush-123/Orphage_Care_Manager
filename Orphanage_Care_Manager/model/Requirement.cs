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

        public Item Item_1 { get => item; set => item = value; }
        public Orphanage Orphanage_1 { get => orphanage; set => orphanage = value; }

        Requirement()
        {
               
        }
        public Requirement(Item item, Orphanage orphanage, Admin admin)
        {
           // date = DateTime.Today;
            this.item = item;
            this.orphanage = orphanage;
            this.admin = admin; 
        }
        //public Item Item
        //{
        //    get { return item; }
        //    set { item = value; }
        //}

        //public Orphanage Orphanage
        //{
        //    get { return orphanage; }
        //    set { orphanage = value; }
        //}



    }
}
