using UnityEngine;

namespace BaseCode.MvcAndMvp
{
    public class ControllerScore : MonoBehaviour
    {
        [Header("My components")] 
        [SerializeField] private ViewScore _viewScore;
        
        private ModelScore _modelScore;

        private void Start()
        {
            _modelScore = new ModelScore();
            _modelScore.UpdatedScore += value => _viewScore.UpdateText(value); 
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                _modelScore.IncreaseScore();
        }
    }
}