using System;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using CommandPattern.Commands;
using CommandPattern.Commands.CeilingFan;
using CommandPattern.Commands.GarageDoor;
using CommandPattern.Commands.Lights;
using CommandPattern.Commands.Stereo;
using CommandPattern.Interfaces;
using CommandPattern.Remote;
using CommandPattern.Vendors;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup

            var remoteControl = new RemoteControl();

            var livingRoomLight = new Light("Living Room");
            var kitchenLight = new Light("Kitchen");
            var ceilingFan = new CeilingFan("Living Room");
            var garageDoor = new GarageDoor();
            var stereo = new Stereo();

            // Command initialization

            var livingRoomLightOn = new LightOnCommand(livingRoomLight);
            var livingRoomLightOff = new LightOffCommand(livingRoomLight);
            var kitchenLightOn = new LightOnCommand(kitchenLight);
            var kitchenLightOff = new LightOffCommand(kitchenLight);

            var ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            var ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            var ceilingFanLow = new CeilingFanLowCommand(ceilingFan);
            var ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            var garageDoorUp = new GarageDoorOpenCommand(garageDoor);
            var garageDoorDown = new GarageDoorDownCommand(garageDoor);

            var stereoWithCd = new StereoWithCdCommand(stereo);
            var stereoOff = new StereoOffCommand(stereo);

            // Remote setup

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, ceilingFanMedium, ceilingFanOff);
            remoteControl.SetCommand(3, ceilingFanHigh, ceilingFanOff);
            remoteControl.SetCommand(4, stereoWithCd, stereoOff);

            // Remote with undo

            Console.WriteLine(remoteControl);
            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            remoteControl.UndoButtonWasPushed();

            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);

            remoteControl.OnButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(2);
            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPushed();

            remoteControl.OnButtonWasPushed(3);
            remoteControl.UndoButtonWasPushed();
            Console.WriteLine(remoteControl);

            // Macro commands
            ICommand[] partyOn = {kitchenLightOn, livingRoomLightOn, stereoWithCd, ceilingFanMedium};
            ICommand[] partyOff = {kitchenLightOff, livingRoomLightOff, stereoOff, ceilingFanOff};

            var partyOnMacro = new MacroCommand(partyOn);
            var partyOffMacro = new MacroCommand(partyOff);

            remoteControl.SetCommand(5, partyOnMacro, partyOffMacro);

            Console.WriteLine(remoteControl);
            Console.WriteLine("--- Pushing Macro On---");
            remoteControl.OnButtonWasPushed(5);
            Console.WriteLine("--- Pushing Macro Off---");
            remoteControl.OffButtonWasPushed(5);
            Console.WriteLine("--- Pushing Macro Undo---");
            remoteControl.UndoButtonWasPushed();

            // Ceiling fan multiple undo 
            remoteControl.OnButtonWasPushed(2);
            remoteControl.OnButtonWasPushed(3);
            remoteControl.OffButtonWasPushed(3);
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();

            // Setting remote using lambdas instead of small classes
        }
    }
}
