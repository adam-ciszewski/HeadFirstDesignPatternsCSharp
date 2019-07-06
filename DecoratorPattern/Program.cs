using System;
using System.Runtime.InteropServices.ComTypes;
using DecoratorPattern.Components;
using DecoratorPattern.Components.Concrete;
using DecoratorPattern.Decorators.Condiments;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso(Size.Venti);
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());

            Beverage beverage5 = new Espresso(Size.Grande);
            Console.WriteLine(beverage5.GetDescription() + " $" + beverage5.Cost());

            Beverage beverage2 = new DarkRoast(Size.Grande);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.GetDescription() + " $" + beverage2.Cost());

            Beverage beverage3 = new DarkRoast(Size.Tall);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.GetDescription() + " $" + beverage3.Cost());

            Beverage beverage4 = new DarkRoast(Size.Tall);
            beverage4 = new Milk(beverage4);
            beverage4 = new Soy(beverage4);
            beverage4 = new Whip(beverage4);
            Console.WriteLine(beverage4.GetDescription() + " $" + beverage3.Cost());

        }
    }
}
