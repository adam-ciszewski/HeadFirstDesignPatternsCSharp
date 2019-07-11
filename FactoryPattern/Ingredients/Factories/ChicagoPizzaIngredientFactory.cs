using System.Collections.Generic;
using FactoryPattern.Ingredients.Concrete;

namespace FactoryPattern.Ingredients.Factories
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new Dough();
        }

        public Sauce CreateSauce()
        {
            return new Sauce();
        }

        public Cheese CreateCheese()
        {
            return new Cheese();
        }

        public List<Veggies> CreateVeggies()
        {
            return new List<Veggies>();
        }

        public Pepperoni CreatePepperoni()
        {
            return new Pepperoni();
        }

        public Clams CreateClams()
        {
            return new Clams();
        }
    }
}