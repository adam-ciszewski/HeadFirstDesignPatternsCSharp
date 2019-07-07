using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Components;

namespace DecoratorPattern.Decorators.Sizes
{
    public class Tall : Beverage, ISizeDecorator
    {
        private Beverage _beverage;

        public Tall(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override string GetDescription()
        {
            return _beverage.GetDescription() + " Tall";
        }

        public override double Cost()
        {
            return _beverage.Cost() * 0.30;
        }
    }
}
