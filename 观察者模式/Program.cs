using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var weather = new WeatherData();
            var observer = new CurrentConditionsDisplay(weather);
            //其他观察者
            //
            weather.setMeasurements(3, 4, 6);
            Console.ReadKey();
        }
    }

    //定义：定义了对象之间的一对多依赖，这样一来，当一个对象改变状态时，它的所有依赖者都会收到通知并自动更新。


    public interface Subject
    {
        void RegisterObserver(Observer o);
        void RsemoveObserver(Observer o);
        void NotifyObservers();
    }

    public interface Observer
    {
        void Update(float temp, float humidity, float pressure);
    }

    public interface DispayElement
    {
        void Display();
    }

    public class WeatherData : Subject
    {
        private ArrayList Observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            Observers = new ArrayList();
        }

        public void RegisterObserver(Observer o)
        {
            Observers.Add(o);
        }

        public void RsemoveObserver(Observer o)
        {
            Observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (Observer o in Observers)
            {
                o.Update(this.temperature, this.humidity, this.pressure);
            }
        }

        public void measurementsChanged()
        {
            NotifyObservers();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }
    }

    public class CurrentConditionsDisplay : Observer, DispayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;

        public CurrentConditionsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + temperature + "F degrees and " + humidity + "% humidity");
        }
    }
}
