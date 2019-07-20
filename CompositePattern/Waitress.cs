using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public class Waitress
    {
        private readonly PancakeHouseMenu _pancakeHouseMenu;
        private readonly DinnerMenu _dinnerMenu;
        private readonly CafeMenu _cafeMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinnerMenu dinnerMenu, CafeMenu cafeMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinnerMenu = dinnerMenu;
            _cafeMenu = cafeMenu;
        }

        public void PrintMenu()
        {
            Console.WriteLine("MENU\n----\nBreakfast");
            PrintMenu(_dinnerMenu.MenuItems);
            Console.WriteLine("LUNCH");
            PrintMenu(_pancakeHouseMenu.MenuItems);
            Console.WriteLine("DINNER");
            PrintMenu(_cafeMenu.MenuItems.Values);
        }

        private static void PrintMenu(IEnumerable<MenuItem> iterator)
        {
            foreach (var menuItem in iterator)
            {
                Console.WriteLine($"{menuItem.Name}, {menuItem.Price} -- {menuItem.Description}");
            }
        }
    }
}
