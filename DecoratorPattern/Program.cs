using System;
using System.Runtime.InteropServices.ComTypes;
using DecoratorPattern.Components;
using DecoratorPattern.Components.Concrete;
using DecoratorPattern.Decorators.Condiments;
using DecoratorPattern.Decorators.Sizes;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            beverage = new Venti(beverage);
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());

            Beverage beverage5 = new Espresso();
            beverage5 = new Grande(beverage5);

            Console.WriteLine(beverage5.GetDescription() + " $" + beverage5.Cost());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Grande(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.GetDescription() + " $" + beverage2.Cost());

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Venti(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.GetDescription() + " $" + beverage3.Cost());

            Beverage beverage4 = new Decaf();
            beverage4 = new Tall(beverage4);
            beverage4 = new Milk(beverage4);
            beverage4 = new Soy(beverage4);
            beverage4 = new Whip(beverage4);
            Console.WriteLine(beverage4.GetDescription() + " $" + beverage3.Cost());

        }
    }
}
