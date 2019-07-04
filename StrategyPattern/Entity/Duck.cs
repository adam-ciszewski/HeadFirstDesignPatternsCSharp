using StrategyPattern.DuckSim.Behaviours.Interfaces;

namespace StrategyPattern.DuckSim.Entity
{
    internal abstract class Duck
    {
        protected IQuackBehaviour QuackBehaviour { get; set; }
        protected IFlyBehaviour FlyBehaviour { get; set; }
        public abstract void Display();

        public void PerformQuack()
        {
            QuackBehaviour.LaudQuack();
        }

        public void PerformFly()
        {
            FlyBehaviour.Fly();
        }

        public void SetFlyBehaviour(IFlyBehaviour flyBehaviour)
        {
            FlyBehaviour = flyBehaviour;
        }

        public void SetQuackBehaviour(IQuackBehaviour quackBehaviour)
        {
            QuackBehaviour = quackBehaviour;
        }
    }
}