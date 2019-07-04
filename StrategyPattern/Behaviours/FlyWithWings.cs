using System;
using StrategyPattern.DuckSim.Behaviours.Interfaces;

namespace StrategyPattern.DuckSim.Behaviours
{
    public class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Flying with wings.");
        }
    }
}
