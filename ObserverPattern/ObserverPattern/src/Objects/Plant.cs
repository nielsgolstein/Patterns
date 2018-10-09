using ObserverPattern.src.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.src.Objects
{
    /// <summary>
    /// We want the plant object to observe the weather
    /// </summary>
    public class Plant : IWeatherObserver
    {
        public void ObserverUpdate(WeatherTypes weather)
        {
            switch (weather)
            {
                case WeatherTypes.RAIN:
                    Console.WriteLine("Plant: Finaly, water!");
                    break;
                case WeatherTypes.SUNNY:
                    Console.WriteLine("Plant: Hot.. I hope I get water!");
                    break;
                case WeatherTypes.CLOUDLY:
                    Console.WriteLine("Plant: Please let it go rain soon!");
                    break;
            }
        }
    }
}
