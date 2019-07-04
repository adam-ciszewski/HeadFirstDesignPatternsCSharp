using System;
using StrategyPattern.DuckSim.Behaviours.Interfaces;

namespace StrategyPattern.DuckSim.Behaviours
{
    internal class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Not flying");
        }
    }
}