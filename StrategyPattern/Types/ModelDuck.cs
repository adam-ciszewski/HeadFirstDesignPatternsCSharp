using System;
using StrategyPattern.DuckSim.Behaviours;
using StrategyPattern.DuckSim.Entity;

namespace StrategyPattern.DuckSim.Types
{
    internal class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehaviour = new FlyNoWay();
            QuackBehaviour = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck.");
        }
    }
}