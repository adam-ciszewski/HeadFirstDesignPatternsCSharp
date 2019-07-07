using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Components;

namespace DecoratorPattern.Decorators.Sizes
{
    public class Grande: Beverage, ISizeDecorator
    {
        private Beverage _beverage;

        public Grande(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + " Grande";
        }

        public override double Cost()
        {
            return _beverage.Cost() + .40;
        }
    }
}
