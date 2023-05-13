using System;
using UnityEngine;

namespace BaseCode.MvcAndMvp
{
    public class ModelScore : MonoBehaviour
    {
        private int _countScore;

        public event Action<int> UpdatedScore;
        
        public void IncreaseScore()
        {
            _countScore++;
            UpdatedScore?.Invoke(_countScore);
        }
    }
}