using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.src.Observers
{
    public class Weather
    {
        /// <summary>
        /// Holds all registered observers
        /// </summary>
        private List<IWeatherObserver> observers { get; set; }


        #region Constructor

        public Weather()
        {
            observers = new List<IWeatherObserver>();
        }

        #endregion


        /// <summary>
        /// Simply adds an observer to this weater object, now it tracks the weather when it changes
        /// </summary>
        /// <param name="observer">The object which observes the weather</param>
        public void AddObserver(IWeatherObserver observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// Removes a observer from the observers list
        /// </summary>
        /// <param name="observer">The object which observes the weather</param>
        public void RemoveObserver(IWeatherObserver observer)
        {
            observers.Remove(observer);
        }

        /// <summary>
        /// If the weather changes, our observers get updated
        /// </summary>
        private void NotifyObservers()
        {
            foreach (IWeatherObserver observer in observers)
            {
                observer.ObserverUpdate(currentWeather);
            }
        }

        #region Weather changes

        private WeatherTypes currentWeather { get; set; }

        /// <summary>
        /// Change the weater, example which triggers the observers to do something based on the new weather
        /// </summary>
        public void ChangeWeather()
        {
            if(currentWeather == WeatherTypes.RAIN)
            {
                currentWeather = WeatherTypes.SUNNY;
            } else if (currentWeather == WeatherTypes.SUNNY)
            {
                currentWeather = WeatherTypes.CLOUDLY;
            } else
            {
                currentWeather = WeatherTypes.RAIN;
            }

            Console.WriteLine("Weather changed to " + currentWeather.ToString());

            NotifyObservers();

            Console.WriteLine(" ");
        }

        #endregion
    }
}
