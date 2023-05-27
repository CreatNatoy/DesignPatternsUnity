using UnityEngine;

namespace BaseCode.StateMachine
{
    public class EnemyPatrolState : MonoBehaviour, IEnemyState
    {
        [Header("Configuration")]
        [SerializeField] private float _speed = 7f;
        [SerializeField] private float _offsetDistancePoint = 0.5f;
        [Header("Components scene")]
        [SerializeField] private Transform[] _points;

        private Vector3 _currentPoint;
        private int _indexPoints;
        private EnemyController _enemyController;

        public void Constructor(EnemyController enemyController)
        {
            _enemyController = enemyController;
            enabled = false;
        }

        private void Update()
        {
            if (Vector3.Distance(transform.position, _currentPoint) < _offsetDistancePoint) 
                UpdateCurrentPoint();

            MoveToPoint();
        }

        private void MoveToPoint()
        {
            Vector3 direction = (_currentPoint - transform.position).normalized;
            transform.Translate(direction * _speed * Time.deltaTime);
        }

        private void UpdateCurrentPoint()
        {
            _indexPoints = (_indexPoints + 1) % _points.Length;
            _currentPoint = _points[_indexPoints].position;
        }

        public void Enter()
        {
            _indexPoints = 0; 
            _currentPoint = _points[_indexPoints].position; 
            _enemyController.Renderer.material.color = Color.blue;
            _enemyController.OnUpdateNameState(GetType().Name);
            enabled = true;
        }

        public void Exit() => enabled = false;
    }
}