using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Components;

namespace DecoratorPattern.Decorators.Sizes
{
    public class Venti : Beverage, ISizeDecorator
    {
        private Beverage _beverage;

        public Venti(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override string GetDescription()
        {
            return _beverage.GetDescription() + " Venti";
        }
        public override double Cost()
        {
            return _beverage.Cost();
        }
    }
}
