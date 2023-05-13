namespace BaseCode.MvcAndMvp
{
    public class ModelScoreMVC
    {
        private int _countScore;
        private readonly ViewScoreMVC _viewScore;
        
        public ModelScoreMVC(ViewScoreMVC viewScoreMvc)
        {
            _countScore = 0;
            _viewScore = viewScoreMvc;
        }
        
        public void IncreaseScore()
        {
            _countScore++;
            _viewScore.UpdateText(_countScore);
        }
    }
}