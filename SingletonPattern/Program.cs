using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var single = Singleton.GetInstance();
        }
    }
}
