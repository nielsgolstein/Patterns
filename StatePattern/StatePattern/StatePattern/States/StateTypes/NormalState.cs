using StatePattern.StatePattern.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.StatePattern.States.StateTypes
{
    public class NormalState : IState<Car>
    {
        private Car car;
        public NormalState(Car car) {
            this.car = car;
        }


        public void EnterState()
        {
            Console.WriteLine("The car starts driving");
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
        //    if(newState != this)
        //    {
        //        this.ExitState();
        //        newState.EnterState();
        //    }

        //    return newState;
        //}
    }
}
