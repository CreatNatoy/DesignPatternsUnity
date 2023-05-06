using UnityEngine;

namespace BaseCode.Factory
{
    public class ConcreteFactoryB : Factory<ProductB>
    {
        [SerializeField] private ProductB _productBPrefab; 
        
        private void Awake() => 
            SetPrefabProduct(_productBPrefab);
    }
}