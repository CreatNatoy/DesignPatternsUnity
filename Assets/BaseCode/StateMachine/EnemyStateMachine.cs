namespace BaseCode.StateMachine
{
    public class EnemyStateMachine
    {
        private IEnemyState _currentState;

        public EnemyStateMachine(IEnemyState firstState)
        {
            _currentState = firstState; 
            _currentState.Enter();
        }

        public void Transition(IEnemyState enemyState)
        {
            _currentState.Exit();
            _currentState = enemyState; 
            _currentState.Enter();
        }
    }
}