using ObserverPattern.Net.Displays;
using System;

namespace ObserverPattern.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup
            var weatherData = new WeatherData();

            // Subscribe
            weatherData.Subscribe(new CurrentConditionsDisplay());
            weatherData.Subscribe(new StaticDisplay());
            weatherData.Subscribe(new ForecastDisplay());
            weatherData.Subscribe(new HeatIndexDisplay());

            // Update the subject
            weatherData.SetMeasurements(22, 80, 22.3f);

            Console.ReadLine();
        }
    }
}
