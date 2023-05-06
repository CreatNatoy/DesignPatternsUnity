using UnityEngine;
using UnityEngine.UI;

namespace BaseCode.Factory
{
    public class ControllerFactory : MonoBehaviour
    {
        [Header("Ui components")]
        [SerializeField] private Button _buttonFactoryA;
        [SerializeField] private Button _buttonFactoryB;

        [Header("My components")] 
        [SerializeField] private ConcreteFactoryA _concreteFactoryA;
        [SerializeField] private ConcreteFactoryB _concreteFactoryB;

        private void Start() => 
            ListenerEvents();

        private void ListenerEvents()
        {
            _buttonFactoryA.onClick.AddListener(() => _concreteFactoryA.GetProduct(Vector3.up));
            _buttonFactoryB.onClick.AddListener(() => _concreteFactoryB.GetProduct(Vector3.up));
        }
    }
}