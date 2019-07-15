using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class DinerMenuIterator : IEnumerator<MenuItem>
    {
        private readonly MenuItem[] _items;
        private int _position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            _items = items;
        }

        public bool HasNext()
        {
            // Since dinner menu has fixed length we need to check if next item is not null.
            return _position < _items.Length && _items[_position] != null;
        }

        public MenuItem Next()
        {
            var menuItem = _items[_position];
            _position++;
            return menuItem;
        }
    }
}
