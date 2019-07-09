using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommandPattern.Interfaces
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
