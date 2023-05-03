using UnityEngine;
using UnityEngine.UI;

namespace BaseCode.Command
{
    public class ControllerCommand : MonoBehaviour
    {
        [SerializeField] private Button _undoButton;
        [SerializeField] private Button _redoButton;

        private void Start() => 
            ListenerEvents();

        private void ListenerEvents()
        {
            _undoButton.onClick.AddListener(() => CommandInvoker.UndoCommand());
            _redoButton.onClick.AddListener(() => CommandInvoker.RedoCommand());
        }
    }
}
