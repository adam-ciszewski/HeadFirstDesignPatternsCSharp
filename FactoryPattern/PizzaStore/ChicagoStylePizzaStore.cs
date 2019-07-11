using FactoryPattern.Ingredients.Factories;
using FactoryPattern.PizzaTypes;

namespace FactoryPattern.PizzaStore
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza;
            var ingredientFactory = new ChicagoPizzaIngredientFactory();

            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.SetName("New York Style Cheese Pizza");
                    break;

                case "clam":
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.SetName("New York Style Clam Pizza");
                    break;

                case "veggie":
                    pizza = new VeggiePizza(ingredientFactory);
                    pizza.SetName("New York Style Veggie Pizza");
                    break;

                case "pepperoni":
                    pizza = new PepperoniPizza(ingredientFactory);
                    pizza.SetName("New York Style Pepperoni Pizza");
                    break;
                default:
                    pizza = null;
                    break;
            }

            return pizza;
        }
    }
}