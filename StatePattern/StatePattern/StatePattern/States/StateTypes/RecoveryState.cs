using StatePattern.StatePattern.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.StatePattern.States.StateTypes
{
    public class RecoveryState : IState<Car>
    {
        private Car car;

        public RecoveryState(Car car)
        {
            this.car = car;
        }

        public void EnterState()
        {
            Console.WriteLine("Someone is comming and starting to repairing our car.");
        }

        public void ExitState()
        {
            Console.WriteLine("The car is repaired! Now we can drive again.");
        }
    }
}
