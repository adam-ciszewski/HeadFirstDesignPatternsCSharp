using ObserverPattern.Net.Interfaces;
using System;

namespace ObserverPattern.Net.Displays
{
    public class StaticDisplay : IObserver<WeatherData>, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public void Display()
        {
            Console.WriteLine($"{_temperature}C and {_humidity} % humidity, {_pressure}pascals");
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(WeatherData value)
        {
            _temperature = value.GetTemperature();
            _humidity = value.GetHumidity();
            _pressure = value.GetPressure();
            Display();
        }
    }
}
