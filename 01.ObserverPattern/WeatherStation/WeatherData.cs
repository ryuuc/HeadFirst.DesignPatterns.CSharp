using System;
using System.Collections.Generic;

namespace WeatherStation
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver> _observers;
        public float Temperature { get; private set; }
        public float Humidity { get; private set; }
        public float Pressure { get; private set; }
        public bool Changed { get; set; }

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            if (_observers.Contains(observer))
                return;
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers(Object arg)
        {
            if (Changed)
            {
                _observers.ForEach(r => r.Update(this, arg));
                Changed = false;
            }
        }

        public void MeasurementsChanged()
        {
            Changed = true;
            NotifyObservers(null);
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            MeasurementsChanged();
        }
    }
}