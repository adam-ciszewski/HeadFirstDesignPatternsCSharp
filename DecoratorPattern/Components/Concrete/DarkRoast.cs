using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Components.Concrete
{
    public class DarkRoast : Beverage
    {
        public DarkRoast(Size size)
        {
            Description = "Dark Roast";
            Size = size;
        }
        public override double Cost()
        {
            switch (GetSize())
            {
                case Size.Grande:
                    return 1.09;
                case Size.Tall:
                    return 0.99;
                case Size.Venti:
                    return 0.89;
                default:
                    return 0.89;
            }
        }
    }
}
