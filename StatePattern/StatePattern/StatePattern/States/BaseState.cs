namespace StatePattern.StatePattern.States.StateTypes
{
    public class BaseState<TObjectType>
    {
        /// <summary>
        /// Sets the new state end exits the old one (if exists)
        /// </summary>
        /// <param name="newState">The new state we want to enter</param>
        /// <param name="oldState">The old state we want to exit (Optional)</param>
        /// <returns>The entered state</returns>
        public IState<TObjectType> SetState(IState<TObjectType> newState, IState<TObjectType> oldState = null)
        {
            if(oldState != null)
                oldState.ExitState();
            newState.EnterState();

            return newState;
        }
    }
}