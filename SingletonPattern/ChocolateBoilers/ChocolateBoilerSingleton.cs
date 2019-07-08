using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.ChocolateBoilers
{
    public class ChocolateBoilerSingleton
    {
        private bool _empty;
        private bool _boiled;

        private static ChocolateBoilerSingleton _boilerSingleton;

        private ChocolateBoilerSingleton()
        {
            _empty = true;
            _boiled = false;
        }

        public static ChocolateBoilerSingleton GetInstance()
        {
            return _boilerSingleton ?? (_boilerSingleton = new ChocolateBoilerSingleton());
        } 

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
