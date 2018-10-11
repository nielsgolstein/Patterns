using StatePattern.StatePattern.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.StatePattern
{
    /// <summary>
    /// Base application class
    /// </summary>
    public class App
    {
        public App()
        {
            Car myCar = new Car();
            myCar.SwitchState();
            myCar.SwitchState();
            myCar.SwitchState();
            myCar.SwitchState();
            myCar.SwitchState();


            Console.ReadLine();
        }
    }
}
