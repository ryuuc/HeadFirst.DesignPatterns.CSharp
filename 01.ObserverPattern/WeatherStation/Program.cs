using System;

namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay(weatherData);
          
            weatherData.SetMeasurements(80, 65, 30.4f);
            CurrentConditionDisplay currentConditionDisplay2 = new CurrentConditionDisplay(weatherData);
            weatherData.SetMeasurements(70, 65, 30.4f);
            Console.ReadKey();
        }
    }
}
