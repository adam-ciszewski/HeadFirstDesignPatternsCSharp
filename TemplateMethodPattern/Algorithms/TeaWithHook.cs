using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Algorithms
{
    public class TeaWithHook : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
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
