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
        private FanSpeed _speed;
        internal Stack<FanSpeed> SpeedStack;

        public CeilingFan(string roomName)
        {
            _roomName = roomName;
            _speed = FanSpeed.Off;
            SpeedStack = new Stack<FanSpeed>();
        }

        public void High()
        {
            Console.WriteLine($"Ceiling fan in {_roomName} set to high");
            _speed = FanSpeed.High;
        }

        public void Medium()
        {
            Console.WriteLine($"Ceiling fan in {_roomName} set to medium");
            _speed = FanSpeed.Medium;

        }
        public void Low()
        {
            Console.WriteLine($"Ceiling fan in {_roomName} set to low");
            _speed = FanSpeed.Low;
        }
        public void Off()
        {
            Console.WriteLine($"Ceiling fan in {_roomName} fan off");
            _speed = FanSpeed.Off;
        }

        public FanSpeed GetSpeed()
        {
            return _speed;
        }
    }

    public enum FanSpeed
    {
        High,
        Medium,
        Low,
        Off
    }
}
