namespace StateMachine
{
    public class StateMachine
    {
        State currentState;

        public void Update()
        {
            currentState.Execute(); 
        }
    }
}