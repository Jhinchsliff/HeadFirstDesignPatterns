using Observer.Contracts;
using System;

namespace Observer.DisplayElements
{
    public class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private readonly ISubject _weatherData;

        public CurrentConditionDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        private float Temperature { get; set; }
        private float Humidity { get; set; }

        public void Display()
        {
            Console.WriteLine($"Current Conditions: {Temperature} F degrees and {Humidity} % Humidity");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            Temperature = temp;
            Humidity = humidity;
            Display();
        }
    }
}
