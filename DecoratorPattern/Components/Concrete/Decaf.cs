using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Components.Concrete
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf coffee";
        }
        public override double Cost()
        {
            return 1.05;
        }
    }
}
