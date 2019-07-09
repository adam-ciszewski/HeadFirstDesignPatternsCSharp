using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Vendors
{
    public class Light
    {
        private readonly string _roomName;
        public Light(string roomName)
        {
            _roomName = roomName;
        }
        public void On()
        {
            Console.WriteLine($"{_roomName} light on");
        }

        public void Off()
        {
            Console.WriteLine($"{_roomName} light off");
        }
    }
}
