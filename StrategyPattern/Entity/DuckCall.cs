using StrategyPattern.DuckSim.Behaviours.Interfaces;

namespace StrategyPattern.DuckSim.Entity
{
    public class DuckCall
    {
        public IQuackBehaviour QuackBehaviour { get; set; }

        public void SetQuackBehaviour(IQuackBehaviour quackBehaviour)
        {
            QuackBehaviour = quackBehaviour;
        }

        public void PerformQuack()
        {
            QuackBehaviour.LaudQuack();
        }
    }
}
