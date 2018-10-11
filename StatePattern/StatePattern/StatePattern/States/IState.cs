using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.StatePattern.States
{
    /// <summary>
    /// State interface to handle diffirent states
    /// </summary>
    /// <typeparam name="TObject">Object which it's state can change</typeparam>
    public interface IState<TObject>
    {
        void EnterState();
        void ExitState();

        /**
         *  I think this is unneseccary because our Car object can easily do this by itself.
         * */
        //IState<TObject> SetState(IState<TObject> newState);
    }
}
