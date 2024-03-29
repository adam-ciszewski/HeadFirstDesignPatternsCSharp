﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Interfaces;
using CommandPattern.Vendors;

namespace CommandPattern.Commands.CeilingFan
{
    public class CeilingFanOffCommand : ICommand
    {
        private readonly Vendors.CeilingFan _ceilingFan;
        private  Stack<FanSpeed> _speedStack;

        public CeilingFanOffCommand(Vendors.CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
            _speedStack = _ceilingFan.SpeedStack;
        }

        public void Execute()
        {
            _speedStack.Push(_ceilingFan.GetSpeed());
            _ceilingFan.Off();
        }

        public void Undo()
        {
            switch (_speedStack.Pop())
            {
                case FanSpeed.High:
                    _ceilingFan.High();
                    break;
                case FanSpeed.Medium:
                    _ceilingFan.Medium();
                    break;
                case FanSpeed.Low:
                    _ceilingFan.Low();
                    break;
                case FanSpeed.Off:
                    _ceilingFan.Off();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
