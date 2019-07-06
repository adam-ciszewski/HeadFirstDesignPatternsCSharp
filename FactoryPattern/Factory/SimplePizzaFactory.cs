using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Entities;

namespace FactoryPattern.Factory
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza();
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza();
                    break;
                case "clam":
                    pizza = new ClamPizza();
                    break;
                case "veggie":
                    pizza = new VeggiePizza();
                    break;
                default:
                    throw new InvalidDataException("Invalid pizza type.");

            }

            return pizza;
        }
    }
}
