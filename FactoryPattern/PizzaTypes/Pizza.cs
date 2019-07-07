using System;
using System.Collections.Generic;
using FactoryPattern.PizzaTypes.Regular;

namespace FactoryPattern.PizzaTypes
{
    public abstract class Pizza
    {
        protected string Name { get; set; }
        protected Dough Dough { get; set; }
        protected Sauce Sauce { get; set; }

        protected List<Veggies> Veggies { get; set; }
        protected Cheese Cheese { get; set; }
        protected Pepperoni Pepperoni { get; set; }
        protected Clam  Clam { get; set; }

        protected List<string> Toppings = new List<string>();
        public abstract void Prepare();

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }
        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slice");
        }

        public string GetName() => Name;

        public void SetName(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "";
        }
    }
}
