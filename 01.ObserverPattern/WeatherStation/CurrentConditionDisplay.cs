using System;

namespace WeatherStation
{
    public class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private ISubject _weatherData;

        public CurrentConditionDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(ISubject subject, Object arg)
        {
            if (subject is WeatherData weather)
            {
                _temperature = weather.Temperature;
                _humidity = weather.Humidity;

                Display();
            }
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {_temperature} F degree and {_humidity} % humidity.");
        }
    }
}