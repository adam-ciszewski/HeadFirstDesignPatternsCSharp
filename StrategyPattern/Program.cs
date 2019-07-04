using System;
using StrategyPattern.DuckSim.Behaviours;
using StrategyPattern.DuckSim.Entity;
using StrategyPattern.DuckSim.Types;

namespace StrategyPattern.DuckSim
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Duck mallard = new MallardDuck();
            mallard.PerformFly();
            mallard.PerformQuack();

            mallard.SetFlyBehaviour(new FlyNoWay());
            mallard.PerformFly();
        }
    }
}