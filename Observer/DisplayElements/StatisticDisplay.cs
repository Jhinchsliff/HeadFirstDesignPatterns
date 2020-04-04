using Observer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Observer.DisplayElements
{
    public class StatisticDisplay : IObserver, IDisplayElement
    {
        private readonly ISubject _weatherData;
        private Queue<float> _historicalTemps;

        public StatisticDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);

            _historicalTemps = new Queue<float>(capacity: 3);
        }

        public void Display()
        {
            float min = _historicalTemps.Min();
            float max = _historicalTemps.Max();
            float average = _historicalTemps.Average();

            Console.WriteLine($"Avg Temperature: {average}. Max Temperature {max}. Min Temperature: {min}");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _historicalTemps.Enqueue(temp);
            Display();
        }
    }
}
