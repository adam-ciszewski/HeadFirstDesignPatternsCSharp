using ObserverPattern.Net.Interfaces;
using System;

namespace ObserverPattern.Net.Displays
{
    public class ForecastDisplay : IObserver<WeatherData>, IDisplayElement
    {
        private float _temperature;
        private float _humidity;

        public void Display()
        {
            Console.WriteLine($"Forecast is: {_temperature}C and {_humidity} % humidity");
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
            Display();
        }
    }
}
