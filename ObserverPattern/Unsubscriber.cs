using System;
using System.Collections.Generic;

namespace ObserverPattern.Net
{
    internal class Unsubscriber<T> : IDisposable
    {
        private readonly List<IObserver<WeatherData>> _observers;
        private readonly IObserver<WeatherData> _observer;

        public Unsubscriber(List<IObserver<WeatherData>> observers, IObserver<WeatherData> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observer != null) _observers.Remove(_observer);
        }
    }
}