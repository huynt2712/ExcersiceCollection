using System;
using System.Collections.Generic;
using System.Text;

namespace ExcersiceCollection
{
    class Product
    {
        private string id;
        private string name;
        private string description;
        private int price;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public Product(string ID,string Name,string Description, int Price)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
        } 

        public void GetInforProduct()
        {
            Console.WriteLine($"Name: {Name}, Description: {Description}");
        }
    }
}
