using System;
using StrategyPattern.DuckSim.Behaviours;
using StrategyPattern.DuckSim.Entity;

namespace StrategyPattern.DuckSim.Types
{
    internal class MallardDuck : Duck
    {
        public MallardDuck()
        {
            SetFlyBehaviour(new FlyWithWings());
            SetQuackBehaviour(new Quack());
        }

        public override void Display()
        {
            Console.WriteLine("Display a mallard duck");
        }
    }
}