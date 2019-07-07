using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Decorators;

namespace DecoratorPattern.Components.Concrete
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark Roast";
        }
        public override double Cost()
        {
            return 1.99;
        }
    }
}
