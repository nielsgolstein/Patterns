using StatePattern.StatePattern.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.StatePattern.States.StateTypes
{
    public class BrokenState : IState<Car>
    {
        private Car car;
        public BrokenState(Car car)
        {
            this.car = car;
        }

        public void EnterState()
        {
            Console.WriteLine("Car starts smoking and is making weird sounds");
        }

        public void ExitState()
        {

        }

        /**
         *  I think this is unneseccary because our Car object can easily do this by itself.
         * */
        //public IState<Car> SetState(IState<Car> newState)
        //{
        //    //Same state
        //    if (newState != this)
        //    {
        //        this.ExitState();
        //        newState.EnterState();
        //    }

        //    return newState;
        //}
    }
}
