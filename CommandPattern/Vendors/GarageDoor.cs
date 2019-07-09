using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Interfaces;

namespace CommandPattern.Vendors
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Garage doors are open");
        }

        public void Down()
        {
            Console.WriteLine("Garage doors are closed");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped");
        }

        public void LightOn()
        {
            Console.WriteLine("Lights on in garage");
        }

        public void LightOff()
        {
            Console.WriteLine("Lights off in garage");
        }
    }
}
