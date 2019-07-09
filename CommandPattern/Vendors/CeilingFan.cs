using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Vendors
{
    public class CeilingFan
    {
        private readonly string _roomName;

        public CeilingFan(string roomName)
        {
            _roomName = roomName;
        }

        public void On()
        {
            Console.WriteLine($"Ceiling in {_roomName} fan on");
        }
        public void Off()
        {
            Console.WriteLine($"Ceiling in {_roomName} fan off");
        }
    }
}
