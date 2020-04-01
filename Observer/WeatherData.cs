using Observer.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class WeatherData : ISubject
    {
        public List<IObserver> Observers { get; set; }
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }

        public WeatherData()
        {
            Observers = new List<IObserver>();
        }

        public void OnMeasurementsChanged()
        {
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach (var observer in Observers)
            {
                observer.Update(Temperature, Humidity, Pressure);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            int index = Observers.IndexOf(observer);

            if (index >= 0)
            {
                Observers.RemoveAt(index);
            }
        }

        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            Temperature = temp;
            Humidity = humidity;
            Pressure = pressure;

            OnMeasurementsChanged();
        }
    }
}
