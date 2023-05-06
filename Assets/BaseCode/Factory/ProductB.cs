using UnityEngine;

namespace BaseCode.Factory
{
    public class ProductB : MonoBehaviour, IProduct
    {
        public void Initialize()
        {
            var value = Random.value;
            transform.localScale = new Vector3(value, value, value);
        }
    }
}