using StatePattern.StatePattern.States;
using StatePattern.StatePattern.States.StateTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.StatePattern.Objects
{
    public class Car
    {
        private IState<Car> state;

        public Car()
        {
            //Set starting state
            SetState(new NormalState(this));
        }

        /// <summary>
        /// Simple method to switch states
        /// </summary>
        public void SwitchState()
        {
            if(state.GetType() == typeof(NormalState))
            {
                SetState(new BrokenState(this));
            } else if(state.GetType() == typeof(BrokenState))
            {
                SetState(new RecoveryState(this));
            } else
            {
                SetState(new NormalState(this));
            }
        }

        /// <summary>
        /// Does switch the state to the new one executing the interface method
        /// </summary>
        /// <param name="newState">The new state</param>
        public void SetState(IState<Car> newState)
        {
            //Is already the newState.
            if (newState == state)
                return;

            //State is not yet known, we enter it by our own.
            if (state != null)
            {
                state.ExitState();
            }

            state = newState;
            state.EnterState();

        }
    }
}
