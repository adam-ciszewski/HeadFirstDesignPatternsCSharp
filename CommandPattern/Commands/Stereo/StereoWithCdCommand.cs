using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Interfaces;

namespace CommandPattern.Commands.Stereo
{
    public class StereoWithCdCommand : ICommand
    {
        private readonly Vendors.Stereo _stereo;

        public StereoWithCdCommand(Vendors.Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.On();
            _stereo.SetCd();
            _stereo.SetVolume(11);
        }

        public void Undo()
        {
            _stereo.Off();
        }
    }
}
