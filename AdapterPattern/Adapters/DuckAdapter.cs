using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPattern.Interfaces;

namespace AdapterPattern.Adapters
{
    public class DuckAdapter : ITurkey
    {
        private IDuck _duck;

        public DuckAdapter(IDuck duck)
        {
            _duck = duck;
        }

        // Translate request
        public void Gobble()
        {
            _duck.Quack();
        }

        public void Fly()
        {
            _duck.Fly();
        }
    }
}
