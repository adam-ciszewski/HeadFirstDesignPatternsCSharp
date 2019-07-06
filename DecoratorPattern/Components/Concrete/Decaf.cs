using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Components.Concrete
{
    public class Decaf : Beverage
    {
        public Decaf(Size size)
        {
            Description = "Decaf coffee";
            Size = size;
        }
        public override double Cost()
        {
            switch (GetSize())
            {
                case Size.Grande:
                    return 1.05;
                case Size.Tall:
                    return 0.95;
                case Size.Venti:
                    return 0.85;
                default:
                    return 0.85;
            }
        }
    }
}
