using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orphanage_Care_Manager.model
{
    class Item
    {
        private string id;
        private string name;
        private int quantity;

        public Item(string id,string name,int quantity) { 
            this.id = id;
            this.name = name;   
            this.quantity = quantity;   
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
