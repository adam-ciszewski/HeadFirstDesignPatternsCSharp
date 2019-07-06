using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Components;

namespace DecoratorPattern.Decorators.Condiments
{
    public class Whip : Beverage, ICondimentDecorator
    {
        private Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            switch (_beverage.Size)
            {
                case Size.Grande:
                    return _beverage.Cost() + 0.20;
                case Size.Tall:
                    return _beverage.Cost() + 0.15;
                case Size.Venti:
                    return _beverage.Cost() + 0.10;
                default:
                    return _beverage.Cost() + 0.10;
            }
        }
    }
}
