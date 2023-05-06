using UnityEngine;

namespace BaseCode.Factory
{
    public class ProductA : MonoBehaviour, IProduct
    {
        public void Initialize()
        {
            var render = GetComponent<Renderer>(); 
            if(render == null) return;
            render.material.color = new Color(Random.value, Random.value, Random.value); 
        }
    }
}