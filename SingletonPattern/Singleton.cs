using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton _uniqueInstance;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            return _uniqueInstance ?? (_uniqueInstance = new Singleton());
        }
    }
}
