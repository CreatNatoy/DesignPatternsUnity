using UnityEngine;

namespace BaseCode.EventBus
{
    public class UpdateColor : MonoBehaviour
    {
        [SerializeField] private Renderer _renderer;

        private void Start()
        {
            EventBus.Subscribe(ColorType.Red, SetRedColor);
            EventBus.Subscribe(ColorType.Blue, SetBlueColor);
            EventBus.Subscribe(ColorType.Green, SetGreenColor);
        }

        private void OnDestroy()
        {
            EventBus.Unsubscribe(ColorType.Red, SetRedColor);
            EventBus.Unsubscribe(ColorType.Blue, SetBlueColor);
            EventBus.Unsubscribe(ColorType.Green, SetGreenColor);
        }

        private void SetRedColor() => _renderer.material.color = Color.red;
        
        private void SetBlueColor() => _renderer.material.color = Color.blue;
        
        private void SetGreenColor() => _renderer.material.color = Color.green;
    }
}
