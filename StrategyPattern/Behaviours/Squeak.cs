using System;
using StrategyPattern.DuckSim.Behaviours.Interfaces;

namespace StrategyPattern.DuckSim.Behaviours
{
    internal class Squeak : IQuackBehaviour
    {
        public void LaudQuack()
        {
            Console.WriteLine("Squeak");
        }
    }
}