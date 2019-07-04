using System;
using StrategyPattern.DuckSim.Behaviours.Interfaces;

namespace StrategyPattern.DuckSim.Behaviours
{
    internal class Quack : IQuackBehaviour
    {
        public void LaudQuack()
        {
            Console.WriteLine("LaudQuack");
        }
    }
}