using System;
using AdapterPattern.Adapters;
using AdapterPattern.Entities;
using AdapterPattern.Interfaces;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var duck = new MallardDuck();

            var turkey = new WildTurkey();
            var turkeyAdapter = new TurkeyAdapter(turkey);


            Console.WriteLine("The Turkey says...");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("The Duck says...");
            TestDuck(turkeyAdapter);

            var duckAdapter = new DuckAdapter(duck);

            TestTurkey(duckAdapter);
        }

        private static void TestTurkey(ITurkey turkey)
        {
            turkey.Gobble();
            turkey.Fly();
        }

        private static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
