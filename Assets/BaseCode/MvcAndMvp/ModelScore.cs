using System;

namespace BaseCode.MvcAndMvp
{
    public class ModelScore
    {
        private int _countScore;

        public event Action<int> UpdatedScore;

        public ModelScore() => _countScore = 0;

        public void IncreaseScore()
        {
            _countScore++;
            UpdatedScore?.Invoke(_countScore);
        }
    }
}