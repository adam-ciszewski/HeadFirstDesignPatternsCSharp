using System;
using StrategyPattern.DuckSim.Behaviours.Interfaces;

namespace StrategyPattern.DuckSim.Behaviours
{
    internal class MuteQuack : IQuackBehaviour
    {
        public void LaudQuack()
        {
            Console.WriteLine("Does nothing");
        }
    }
}