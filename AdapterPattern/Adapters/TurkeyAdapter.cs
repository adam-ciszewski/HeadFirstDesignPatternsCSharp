using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPattern.Interfaces;

namespace AdapterPattern.Adapters
{
    public class TurkeyAdapter : IDuck
    {
        private ITurkey _turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }

        // Translated requests
        public void Fly()
        {
            for (var i = 0; i < 5; i++)
            {
                _turkey.Fly();
            }
        }

        public void Quack()
        {
            _turkey.Gobble();
        }
    }
}
