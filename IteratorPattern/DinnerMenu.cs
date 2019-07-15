using System;

namespace IteratorPattern
{
    public class DinnerMenu
    {
        private readonly MenuItem[] _menuItems;

        private const int MaxItems = 6;
        private int _numberOfItems = 0;


        public DinnerMenu()
        {
            _menuItems = new MenuItem[MaxItems];

            AddItem("Vegetarian BLT",
                "(Fakin') Bacon with lettuce & tomato on whole wheat",
                true,
                2.99);

            AddItem("BLT",
                "Bacon with lettuce & tomato on whole wheat",
                false,
                2.99);

            AddItem("Hotdog",
                "A hot dog with sauerkraut, relish, onions, topped with cheese",
                false,
                3.05);

            AddItem("Another Vegetarian BLT",
                "(Fakin') Bacon with lettuce & tomato on whole wheat",
                true,
                2.99);

            AddItem("Another BLT",
                "Bacon with lettuce & tomato on whole wheat",
                false,
                2.99);

            AddItem("Another Hotdog",
                "A hot dog with sauerkraut, relish, onions, topped with cheese",
                false,
                3.05);

        }

        private void AddItem(string name, string description, bool vegetarian, double price)
        {
            if (_numberOfItems >= MaxItems)
            {
                Console.WriteLine("Sorry, menu is full! Can't add items to menu");
            }
            else
            {
                _menuItems[_numberOfItems] = new MenuItem(name, description, vegetarian, price);
                _numberOfItems++;
            }
        }

        public IIterator<MenuItem> CreateIterator()
        {
            return new DinerMenuIterator(_menuItems);
        }
    }
}
