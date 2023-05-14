using UnityEngine;
using UnityEngine.UI;

namespace BaseCode.MvcAndMvp
{
    public class PresenterScore : MonoBehaviour
    {
        [Header("Ui components")] 
        [SerializeField] private Button _addScore;
        [Header("My components")]
        [SerializeField] private ViewScore _viewScore;
        
        private ModelScore _modelScore;

        private void Start()
        {
            _modelScore = new ModelScore();
            _addScore.onClick.AddListener(() =>  _modelScore.IncreaseScore());
            _modelScore.UpdatedScore += (value) => _viewScore.UpdateText(value);
        }
    }
}