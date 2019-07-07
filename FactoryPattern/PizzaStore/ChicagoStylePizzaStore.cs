using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.PizzaTypes;
using FactoryPattern.PizzaTypes.ChicagoStyle;

namespace FactoryPattern.PizzaStore
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new ChicagoStyleCheesePizza();
                case "clam":
                    return new ChicagoStyleClamPizza();
                case "veggie":
                    return new ChicagoStyleVeggiePizza();
                case "pepperoni":
                    return new ChicagoStylePepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
