using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class Waitress
    {
        private PancakeHouseMenu _pancakeHouseMenu;
        private DinnerMenu _dinnerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinnerMenu dinnerMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinnerMenu = dinnerMenu;
        }

        public void PrintMenu()
        {
            var pancakeIterator = _pancakeHouseMenu.CreateIterator();
            var dinnerIterator = _dinnerMenu.CreateIterator();

            Console.WriteLine("MENU\n----\nBreakfast");
            PrintMenu(pancakeIterator);
            Console.WriteLine("LUNCH");
            PrintMenu(dinnerIterator);
        }

        private static void PrintMenu(IIterator<MenuItem> iterator)
        {
            while (iterator.HasNext())
            {
                var menuItem = iterator.Next();
                Console.WriteLine($"{menuItem.Name}, {menuItem.Price} -- {menuItem.Description}");
            }
        }
    }
}
