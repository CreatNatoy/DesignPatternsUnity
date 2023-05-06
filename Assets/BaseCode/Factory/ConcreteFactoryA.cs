using UnityEngine;

namespace BaseCode.Factory
{
    public class ConcreteFactoryA : Factory<ProductA>
    {
        [SerializeField] private ProductA _productAPrefab;

        private void Awake() => 
            SetPrefabProduct(_productAPrefab);
    }
}