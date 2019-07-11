using System.Collections.Generic;
using FactoryPattern.Ingredients.Concrete;

namespace FactoryPattern.Ingredients
{
    public interface IPizzaIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
        List<Veggies> CreateVeggies();
        Pepperoni CreatePepperoni();
        Clams CreateClams();
    }
}