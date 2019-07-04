using System;
using StrategyPattern.DuckSim.Behaviours.Interfaces;

namespace StrategyPattern.DuckSim.Behaviours
{
    internal class FlyRocketPowered : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket.");
        }
    }
}