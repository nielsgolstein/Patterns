using ObserverPattern.src.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.src.Objects
{
    /// <summary>
    /// Class Ant is an animal which we want to possibly can observe the weather
    /// </summary>
    public class Ant : IWeatherObserver
    {
        public void ObserverUpdate(WeatherTypes weather)
        {
            switch(weather) {
                case WeatherTypes.RAIN:
                    Console.WriteLine("Ant: Back to the holes! TSUNAMI!");
                    break;
                case WeatherTypes.SUNNY:
                    Console.WriteLine("Ant: Come out of the holes, work!");
                    break;
                case WeatherTypes.CLOUDLY:
                    Console.WriteLine("Ant: Being sad. Sad weather...");
                    break;
            }
        }
    }
}
