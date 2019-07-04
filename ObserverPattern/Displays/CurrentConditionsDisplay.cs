using ObserverPattern.Net.Interfaces;
using System;

namespace ObserverPattern.Net.Displays
{
    /// <summary>
    /// For info on how to implement a more robust Observer Pattern using build in
    /// .Net System.IObservable<T> and System.IObserver<T> see:
    /// https://docs.microsoft.com/en-us/dotnet/standard/events/observer-design-pattern
    /// </summary>
    public class CurrentConditionsDisplay : IObserver<WeatherData>, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public void Display()
        {
            Console.WriteLine($"Current condition: {_temperature}C, {_humidity}% humidity, {_pressure} pressure.");
        }
        /// <summary>
        /// Notifies the observer that the provider has finished sending push-based notifications.
        /// https://docs.microsoft.com/en-us/dotnet/api/system.iobserver-1.oncompleted?view=netframework-4.8
        /// </summary>
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Notifies the observer that the provider has experienced an error condition.
        /// https://docs.microsoft.com/en-us/dotnet/api/system.iobserver-1.onerror?view=netframework-4.8
        /// </summary>
        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Provides the observer with new data.
        /// https://docs.microsoft.com/en-us/dotnet/api/system.iobserver-1.onnext?view=netframework-4.8
        /// </summary>
        public void OnNext(WeatherData value)
        {
            _temperature = value.GetTemperature();
            _humidity = value.GetHumidity();
            _pressure = value.GetPressure();
            Display();
        }
    }
}
