using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.PizzaTypes.NyStyle
{
    public class NyStyleCheesePizza : Pizza
    {
        public NyStyleCheesePizza()
        {
            Name = "NY Style Sauce and Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";

            Toppings.Add("Grated Reggiano Cheese");
        }
    }
}
