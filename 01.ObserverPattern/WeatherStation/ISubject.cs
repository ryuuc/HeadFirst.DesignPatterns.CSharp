using System;

namespace WeatherStation
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers(Object arg);
        bool Changed { get; set; }
    }
}