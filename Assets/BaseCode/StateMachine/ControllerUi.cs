using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BaseCode.StateMachine
{
    public class ControllerUi : MonoBehaviour
    {
        [Header("Components Ui")]
        [SerializeField] private Button _buttonPatrol;
        [SerializeField] private Button _buttonFollow;
        [SerializeField] private TextMeshProUGUI _textTitleState;

        [Header("My components")] 
        [SerializeField] private EnemyController _enemyController;

        private void Start()
        {
            _buttonPatrol.onClick.AddListener(() => _enemyController.StartPatrol());
            _buttonFollow.onClick.AddListener(() => _enemyController.StartFollow());

            _enemyController.UpdatingName += text => _textTitleState.text = text; 
        }
    }
}