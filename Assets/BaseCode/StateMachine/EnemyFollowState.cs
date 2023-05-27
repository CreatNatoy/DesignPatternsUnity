using UnityEngine;

namespace BaseCode.StateMachine
{
    public class EnemyFollowState : MonoBehaviour, IEnemyState
    {
        [SerializeField] private float _speed = 14f;
        [SerializeField] private float _offsetDistanceTarget = 0.5f; 
        [SerializeField] private Transform _target;
        
        private EnemyController _enemyController;

        public void Constructor(EnemyController enemyController)
        {
            _enemyController = enemyController;
            enabled = false;
        }

        private void Update()
        {
            if (Vector3.Distance(transform.position, _target.position) < _offsetDistanceTarget)
            {
                _enemyController.StartAttack();
                return;
            }

            MoveToTarget();
        }

        private void MoveToTarget()
        {
            Vector3 direction = (_target.position - transform.position).normalized;
            transform.Translate(direction * _speed * Time.deltaTime);
        }

        public void Enter()
        {
            _enemyController.Renderer.material.color = Color.yellow;
            _enemyController.OnUpdateNameState(GetType().Name);
            enabled = true; 
        }

        public void Exit()
        {
            enabled = false;
        }
    }
}