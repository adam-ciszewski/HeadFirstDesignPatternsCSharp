using System;
using System.IO;

namespace TemplateMethodPattern.Algorithms
{
    public class CoffeeWithHook : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override bool CustomerWantsCondiments()
        {
            var answer = GetUserInput();
            return answer.ToLower().StartsWith("y");
        }

        private static string GetUserInput()
        {
            var answer = string.Empty;

            Console.WriteLine("Would you like milk and sugar with your coffee (y/n)? ");

            try
            {
                answer = Console.ReadLine();
            }
            catch (IOException ioe)
            {
                Console.WriteLine($"{ioe.Message} Error trying to read your answer");
            }

            return answer ?? "no";
        }
    }
}
