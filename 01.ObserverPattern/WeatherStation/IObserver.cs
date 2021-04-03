using System;

namespace WeatherStation
{
    public interface IObserver
    {
        void Update(ISubject subject, Object arg);
    }
}