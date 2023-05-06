using UnityEngine;

namespace BaseCode.Factory
{
    public abstract class Factory<T> : MonoBehaviour where T : Object, IProduct
    {
        private T productPrefab;

        public void SetPrefabProduct(T product) => productPrefab = product;

        public virtual T GetProduct(Vector3 position)
        {
            var instance = Instantiate(productPrefab, position, Quaternion.identity); 
            instance.Initialize();
            return instance; 
        }
    }
}
