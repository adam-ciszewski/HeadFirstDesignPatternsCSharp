using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class MenuItem
    {
        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            Name = name;
            Description = description;
            Vegetarian = vegetarian;
            Price = price;
        }

        public string Name { get; }
        public string Description { get; }
        public bool Vegetarian { get; }
        public double Price { get; }
    }
}
