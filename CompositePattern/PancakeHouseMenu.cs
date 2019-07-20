using System.Collections.Generic;

namespace CompositePattern
{
    public class PancakeHouseMenu
    {
        public List<MenuItem> MenuItems { get; }

        public PancakeHouseMenu()
        {
            MenuItems = new List<MenuItem>();

            AddItem("K&B's Pancake Breakfast",
                "Pancakes with scrambled eggs, and toast",
                true,
                2.99);

            AddItem("Regular Pancake Breakfast",
                "Pancakes with fried eggs, sausage",
                false,
                2.99);

            AddItem("Blueberry Pancakes",
                "Pancakes made with fresh blueberries.",
                true,
                3.49);

            AddItem("Waffles",
                "Waffles, with your choice of blueberries or strawberries.",
                true,
                3.59);
        }

        private void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItems.Add(new MenuItem(name, description, vegetarian, price));
        }
    }
}
