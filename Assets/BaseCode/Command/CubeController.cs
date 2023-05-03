using UnityEngine;
using UnityEngine.UI;

namespace BaseCode.Command
{
    public class CubeController : MonoBehaviour
    {
        [Header("Ui components")]
        [SerializeField] private Button _buttonUp;
        [SerializeField] private Button _buttonDown;
        [SerializeField] private Button _buttonLeft;
        [SerializeField] private Button _buttonRight;
        [Header("Global components")] 
        [SerializeField] private CubeMover _cubeMover;
        
        private void Start() => ListenerEvents();

        private void ListenerEvents()
        {
            _buttonUp.onClick.AddListener(() => Move(Vector3.up));
            _buttonDown.onClick.AddListener(() => Move(Vector3.down));
            _buttonLeft.onClick.AddListener(() => Move(Vector3.left));
            _buttonRight.onClick.AddListener(() => Move(Vector3.right));
        }

        private void Move(Vector3 movement)
        {
            var command = new MoveCommand(_cubeMover, movement);
            CommandInvoker.ExecuteCommand(command);
        }
    }
}
