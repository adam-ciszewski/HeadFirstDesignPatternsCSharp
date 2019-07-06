using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Components.Concrete
{
    public class HouseBlend : Beverage
    {
        public HouseBlend(Size size)
        {
            Description = "House Blend Coffee";
            Size = size;
        }
        public override double Cost()
        {
            switch (GetSize())
            {
                case Size.Grande:
                    return 0.89;
                case Size.Tall:
                    return 0.79;
                case Size.Venti:
                    return 0.69;
                default:
                    return 0.69;
            }
        }
    }
}
