using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var pancakeMenu = new PancakeHouseMenu();
            var dinnerMenu = new DinnerMenu();
            var cafeMenu = new CafeMenu();

            var  waitress = new Waitress(pancakeMenu, dinnerMenu, cafeMenu);

            waitress.PrintMenu();
        }
    }
}
