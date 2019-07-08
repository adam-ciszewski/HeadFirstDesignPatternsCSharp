using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.ChocolateBoilers
{
    public class ChocolateBoilerSingletonTreadSafe
    {
        private bool _empty;
        private bool _boiled;

        private static readonly Lazy<ChocolateBoilerSingletonTreadSafe> Lazy
            = new Lazy<ChocolateBoilerSingletonTreadSafe>(() => new ChocolateBoilerSingletonTreadSafe());

        public static ChocolateBoilerSingletonTreadSafe Instance => Lazy.Value;
        private ChocolateBoilerSingletonTreadSafe() { }

        public void Fill()
        {
            if (IsEmpty())
            {
                _empty = false;
                _boiled = false;
                // Fill the boiler with milk/chocolate mixture
            }
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                // Drain the boiled milk and chocolate
                _empty = true;
            }
        }

        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                // Bring contents to boil
                _boiled = true;
            }
        }

        public bool IsEmpty()
        {
            return _empty;
        }

        public bool IsBoiled()
        {
            return _boiled;
        }
    }
}
