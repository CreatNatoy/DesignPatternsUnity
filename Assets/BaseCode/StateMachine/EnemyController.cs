using System;
using UnityEngine;

namespace BaseCode.StateMachine
{
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] private Renderer _renderer; 
        
        private EnemyStateMachine _stateMachine;
        private IEnemyState _statePatrol; 
        private IEnemyState _stateFollow; 
        private IEnemyState _stateAttack;

        public Renderer Renderer => _renderer;

        public event Action<string> UpdatingName; 

        private void Start()
        {
            InitialState();

            _stateMachine = new EnemyStateMachine(_statePatrol);
        }

        private void InitialState()
        {
            _statePatrol = GetComponent<EnemyPatrolState>();
            _stateFollow = GetComponent<EnemyFollowState>();
            _stateAttack = GetComponent<EnemyAttackState>();
            
            _statePatrol.Constructor(this);
            _stateFollow.Constructor(this);
            _stateAttack.Constructor(this);
        }

        public void StartPatrol() => _stateMachine.Transition(_statePatrol);

        public void StartFollow() => _stateMachine.Transition(_stateFollow);

        public void StartAttack() => _stateMachine.Transition(_stateAttack);

        public void OnUpdateNameState(string nameState) => UpdatingName?.Invoke(nameState);
    }
}