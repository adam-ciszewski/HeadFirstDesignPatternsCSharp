using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPattern.Interfaces;

namespace AdapterPattern.Entities
{
    public class MallardDuck : IDuck
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}
