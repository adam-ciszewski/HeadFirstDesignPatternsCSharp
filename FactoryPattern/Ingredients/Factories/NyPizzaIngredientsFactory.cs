using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Ingredients.Factories
{
    public class NyPizzaIngredientsFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSouce();
        }

        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public List<Veggies> CreateVeggies()
        {
            return new List<Veggies>(
                new Garlic(), 
                new Onion(), 
                new Mushroom(), 
                new RedPepper());
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Clams CreateClams()
        {
            return new FreshClams();
        }
    }
}
