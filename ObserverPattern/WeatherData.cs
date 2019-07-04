using System;
using System.Collections.Generic;

namespace ObserverPattern.Net
{
    public class WeatherData : IObservable<WeatherData>
    {
        private float Temperature { get; set; }
        private float Humidity { get; set; }
        private float Pressure { get; set; }

        private readonly List<IObserver<WeatherData>> _observers;
        public WeatherData()
        {
            _observers = new List<IObserver<WeatherData>>();
        }

        public float GetTemperature() => Temperature;
        public float GetHumidity() => Humidity;
        public float GetPressure() => Pressure;

        /// <summary>
        /// An IDisposable implementation that enables the provider to remove observers
        /// when notification is complete. Observers receive a reference to the IDisposable
        /// implementation from the Subscribe method, so they can also call the IDisposable.
        /// Dispose method to unsubscribe before the provider has finished sending notifications.
        /// https://docs.microsoft.com/en-us/dotnet/standard/events/observer-design-pattern
        /// </summary>
        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
            return new Unsubscriber<WeatherData>(_observers, observer);
        }
        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            Temperature = temp;
            Humidity = humidity;
            Pressure = pressure;
            MeasurementsChanged();
        }
        /// <summary>
        /// Notify all Observers passing in the current state of WeatherData.
        /// </summary>
        private void MeasurementsChanged()
        {
            foreach (var observer in _observers)
            {
                observer.OnNext(this);
            }
        }
    }
}
