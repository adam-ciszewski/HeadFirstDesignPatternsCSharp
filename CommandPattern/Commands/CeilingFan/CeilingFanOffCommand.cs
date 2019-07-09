using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Interfaces;

namespace CommandPattern.Commands.CeilingFan
{
    public class CeilingFanOffCommand : ICommand
    {
        private readonly Vendors.CeilingFan _ceilingFan;

        public CeilingFanOffCommand(Vendors.CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _ceilingFan.Off();
        }
    }
}
