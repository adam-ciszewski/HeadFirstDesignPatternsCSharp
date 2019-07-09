using CommandPattern.Interfaces;
using CommandPattern.Vendors;

namespace CommandPattern.Commands.Lights
{
    public class LightOnCommand : ICommand
    {
        private readonly Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On();
        }

        public void Undo()
        {
            _light.Off();
        }
    }
}
