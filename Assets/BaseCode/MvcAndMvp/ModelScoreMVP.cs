using System;

namespace BaseCode.MvcAndMvp
{
    public class ModelScoreMVP
    {
        private int _countScore;

        public event Action<int> UpdatedScore;

        public ModelScoreMVP()
        {
            _countScore = 0;
        }
        
        public void IncreaseScore()
        {
            _countScore++;
            UpdatedScore?.Invoke(_countScore);
        }
    }
}