using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Interfaces;

namespace CommandPattern.Commands
{
    public class NoCommand : ICommand
    {
        public void Execute() {}
    }
}
