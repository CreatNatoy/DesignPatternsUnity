using UnityEngine;

namespace BaseCode.StateMachine
{
    public class EnemyAttackState : MonoBehaviour, IEnemyState
    {
        private EnemyController _enemyController;

        public void Constructor(EnemyController enemyController)
        {
            _enemyController = enemyController;
            enabled = false;
        }

        public void Enter()
        {
            _enemyController.Renderer.material.color = Color.red;
            _enemyController.OnUpdateNameState(GetType().Name);
            enabled = true;
        }

        public void Exit()
        {
            enabled = false;
        }
    }
}