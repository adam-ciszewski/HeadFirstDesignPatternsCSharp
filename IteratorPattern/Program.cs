using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var pancakeMenu = new PancakeHouseMenu();
            var dinnerMenu = new DinnerMenu();

            var  waitress = new Waitress(pancakeMenu, dinnerMenu);

            waitress.PrintMenu();
        }
    }
}
