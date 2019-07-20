using System.Collections.Generic;

namespace CompositePattern
{
    public class CafeMenu
    {
        public readonly Dictionary<string, MenuItem> MenuItems = new Dictionary<string, MenuItem>();

        public CafeMenu()
        {
            AddItem("Veggie Burger and Air Fries",
                "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
                true,
                3.99);
            AddItem("Soup of the day",
                "A cup of the soup of the day, with a side salad",
                false,
                3.69);
            AddItem("Burrito",
                "A large burrito, with whole pinto beans, salsa, guacamole",
                true,
                4.29);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            var menuItem = new MenuItem(name, description, vegetarian, price);
            MenuItems.Add(menuItem.Name, menuItem);
        }
    }
}
