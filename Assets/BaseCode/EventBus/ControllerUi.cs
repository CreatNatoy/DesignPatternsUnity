using UnityEngine;
using UnityEngine.UI;

namespace BaseCode.EventBus
{
    public class ControllerUi : MonoBehaviour
    {
        [SerializeField] private Button _buttonRed;
        [SerializeField] private Button _buttonGreen;
        [SerializeField] private Button _buttonBlue;

        private void Start()
        {
            _buttonRed.onClick.AddListener( () => EventBus.Publisher(ColorType.Red));
            _buttonGreen.onClick.AddListener( () => EventBus.Publisher(ColorType.Green));
            _buttonBlue.onClick.AddListener( () => EventBus.Publisher(ColorType.Blue));
        }
    }
}