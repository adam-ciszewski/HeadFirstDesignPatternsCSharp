using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Components.Concrete
{
    public class Espresso : Beverage
    {
        public Espresso(Size size)
        {
            Description = "Espresso";
            SetSize(size);
        }
        public override double Cost()
        {
            switch (GetSize())
            {
                case Size.Grande:
                    return 1.99;
                case Size.Tall:
                    return 1.59;
                case Size.Venti:
                    return 1.49;
                default:
                    return 1.49;
            }
        }
    }
}
