using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.src.Observers
{
    public interface IWeatherObserver
    {
        void ObserverUpdate(WeatherTypes weather);
    }
}
