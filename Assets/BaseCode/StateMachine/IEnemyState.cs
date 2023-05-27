namespace BaseCode.StateMachine
{
    public interface IEnemyState
    {
        void Constructor(EnemyController enemyController); 
        void Enter();
        void Exit(); 
    }
}
