using System;
using FactoryPattern.PizzaStore;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var nyStore = new NyStylePizzaStore();
            var chicagoStore = new ChicagoStylePizzaStore();

            var pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {pizza.GetName()}\n");

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Joel ordered a {pizza.GetName()}\n");
        }
    }
}
