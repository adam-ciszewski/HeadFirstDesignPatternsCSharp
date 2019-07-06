using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Components;

namespace DecoratorPattern.Decorators.Condiments
{
    public class Soy : Beverage, ICondimentDecorator
    {
        private Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Soy";
        }

        public override double Cost()
        {
            switch (_beverage.Size)
            {
                case Size.Grande:
                    return _beverage.Cost() + 0.25;
                case Size.Tall:
                    return _beverage.Cost() + 0.20;
                case Size.Venti:
                    return _beverage.Cost() + 0.15;
                default:
                    return _beverage.Cost() + 0.15;
            }
        }
    }
}
