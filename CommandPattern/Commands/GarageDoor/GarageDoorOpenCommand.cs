using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Interfaces;

namespace CommandPattern.Commands.GarageDoor
{
    public class GarageDoorOpenCommand : ICommand
    {
        private readonly Vendors.GarageDoor _garageDoor;

        public GarageDoorOpenCommand(Vendors.GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Up();
        }

        public void Undo()
        {
            _garageDoor.Down();
        }
    }
}
