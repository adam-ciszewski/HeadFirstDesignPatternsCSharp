using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Interfaces;

namespace CommandPattern.Commands.Stereo
{
    public class StereoOffCommand : ICommand
    {
        private readonly Vendors.Stereo _stereo;

        public StereoOffCommand(Vendors.Stereo stereo)
        {
            _stereo = stereo;
        }


        public void Execute()
        {
            _stereo.Off();
        }

        public void Undo()
        {
            _stereo.On();
        }
    }
}
