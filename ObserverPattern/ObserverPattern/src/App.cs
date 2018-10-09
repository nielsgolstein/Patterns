



using ObserverPattern.src.Objects;
using ObserverPattern.src.Observers;
using System;

namespace ObserverPattern.src
{
    public class App
    {

        public App()
        {
            //Lets create a new weather object
            Weather weather = new Weather();

            //We also create an Ant and a Plant.
            Plant plant = new Plant();
            Ant ant = new Ant();

            //Now we set the plant and and to observe the weather
            weather.AddObserver(plant);
            weather.AddObserver(ant);

            //Now we change the weather and track down the observers
            weather.ChangeWeather();
            weather.ChangeWeather();
            weather.ChangeWeather();
            weather.ChangeWeather();

            Console.ReadLine();
        }

    }
}