using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Vendors
{
    public class Stereo
    {
        public void On()
        {
            Console.WriteLine("Stereo is on");
        }

        public void Off()
        {
            Console.WriteLine("Stereo is off");
        }

        public void SetCd()
        {
            Console.WriteLine("Cd set");
        }

        public void SetDvd()
        {
            Console.WriteLine("DVD set");
        }

        public void SetRadio()
        {
            Console.WriteLine("Radio set");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"Volume set to {volume}");
        }
    }
}
