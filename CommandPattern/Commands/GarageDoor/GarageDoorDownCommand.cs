using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Interfaces;

namespace CommandPattern.Commands.GarageDoor
{
    public class GarageDoorDownCommand : ICommand
    {
        private readonly Vendors.GarageDoor _garageDoor;

        public GarageDoorDownCommand(Vendors.GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Down();
        }
    }
}
