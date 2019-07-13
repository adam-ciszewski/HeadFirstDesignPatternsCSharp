using System;
using TemplateMethodPattern.Algorithms;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var teaWithHook = new TeaWithHook();
            var coffeeWithHook = new CoffeeWithHook();

            Console.WriteLine("\nMaking tea...");
            teaWithHook.PrepareRecipe();

            Console.WriteLine("\nMaking coffee...");
            coffeeWithHook.PrepareRecipe();
        }
    }
}
