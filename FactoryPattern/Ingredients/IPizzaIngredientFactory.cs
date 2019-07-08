using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Ingredients
{
    public interface IPizzaIngredientFactory
    {
        public Dough CreateDough();
        public Sauce CreateSauce();
        public Cheese CreateCheese();
        public List<Veggies> CreateVeggies();
        public Pepperoni CreatePepperoni();
        public Clams CreateClams();
    }
}
