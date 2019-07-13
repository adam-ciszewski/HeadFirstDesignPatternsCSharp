using System;

namespace IteratorPattern
{
    public class DinnerMenu
    {
        public MenuItem[] MenuItems { get; }

        private const int MaxItems = 6;
        private int _numberOfItems = 0;


        public DinnerMenu(MenuItem[] menuItems)
        {
            MenuItems = new MenuItem[MaxItems];

        }

        private void AddItem(string name, string description, bool vegetarian, double price)
        {
            if (_numberOfItems >= MaxItems)
            {
                Console.WriteLine("Sorry, menu is full! Can't add items to menu");
            }
            else
            {
                MenuItems[_numberOfItems] = new MenuItem(name, description, vegetarian, price);
                _numberOfItems++;
            }
        }
    }
}
