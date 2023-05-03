using UnityEngine;

namespace BaseCode.Command
{
    public class CubeMover : MonoBehaviour
    {
        public void Move(Vector3 movement) => 
            transform.position += movement;
    }
}
