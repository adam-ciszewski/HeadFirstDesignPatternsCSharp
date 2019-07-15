using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class PancakeHouseMenuIterator : IIterator<MenuItem>
    {
        private readonly List<MenuItem> _items;
        private int _position = 0;

        public PancakeHouseMenuIterator(List<MenuItem> items)
        {
            _items = items;
        }

        public bool HasNext()
        {
            return _position + 1 < _items.Count;
        }

        public MenuItem Next()
        {
            var menuItem = _items[_position];
            _position++;
            return menuItem;
        }
    }
}
