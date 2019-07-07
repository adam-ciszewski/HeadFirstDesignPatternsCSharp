using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Components;

namespace DecoratorPattern.Decorators.Condiments
{
    public class Milk : Beverage, ICondimentDecorator
    {
        private Beverage _beverage;

        public Milk(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Milk";
        }

        public override double Cost()
        {
                return _beverage.Cost() + 0.20;
        }
    }
}
