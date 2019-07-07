using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Ingredients.Factories
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomatoSouce();
        }

        public Cheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public List<Veggies> CreateVeggies()
        {
            return new List<Veggies>(
                new EggPlant(),
                new Spinach(),
                new BlackOlives());
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Clams CreateClams()
        {
            return new FrozenClams();
        }
    }
}
}
